
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using taskOne.Models;
using taskOne.Services;

namespace taskOne
{
    public partial class Main : Form
    {
        private readonly IFileEncryptor _encryptor;
        private DateTime _startTime;

        public Main()
        {
            InitializeComponent();

            _encryptor = new XorFileEncryptor();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;

            backgroundWorker1.DoWork += BackgroundWorker_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            timer.Interval = 1000;
            timer.Tick += Timer1_Tick;
        }

        // ==========================
        // КНОПКИ
        // ==========================
     

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            StartProcessing(CryptoMode.Encrypt);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            StartProcessing(CryptoMode.Decrypt);
        }

        // ==========================
        // ЗАПУСК ФОНА
        // ==========================

        private void StartProcessing(CryptoMode mode)
        {
            if (backgroundWorker1.IsBusy)
                return;

            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Файл не найден");
                return;
            }

            if (!Directory.Exists(txtOutputPath.Text))
            {
                MessageBox.Show("Укажите папку для сохранения");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Введите ключ");
                return;
            }

            progressBar1.Value = 0;
            lblProgress.Text = "0 %";

            _startTime = DateTime.Now;
            timer.Start();

            backgroundWorker1.RunWorkerAsync(new object[]
            {
        txtFilePath.Text,
        txtOutputPath.Text,
        txtKey.Text,
        mode
            });
        }


        // ==========================
        // BACKGROUND WORKER
        // ==========================

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var args = (object[])e.Argument;

            string inputPath = args[0].ToString();
            string outputDir = args[1].ToString();
            string key = args[2].ToString();
            CryptoMode mode = (CryptoMode)args[3];

            string outputFileName;

            if (mode == CryptoMode.Encrypt)
            {
                outputFileName = Path.GetFileName(inputPath) + ".enc";
            }
            else
            {
                string name = Path.GetFileName(inputPath);

                if (!name.EndsWith(".enc", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Файл не является зашифрованным");

                outputFileName = name.Substring(0, name.Length - 4);
            }

            string outputPath = Path.Combine(outputDir, outputFileName);

            e.Result = _encryptor.Process(
                inputPath,
                outputPath,
                key,
                percent => backgroundWorker1.ReportProgress(percent)
            );
        }




        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage} %";
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Stop();

            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;

            if (e.Error != null)
            {
                MessageBox.Show(
                    e.Error.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var result = (EncryptionResult)e.Result;

            MessageBox.Show(
                $"Файл: {result.FileName}\n" +
                $"Размер: {result.FileSize} байт\n" +
                $"Время: {result.ElapsedTime}",
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ==========================
        // ТАЙМЕР
        // ==========================

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            lblElapsedTime.Text = $"Час: {elapsed:hh\\:mm\\:ss}";
        }
    }
}
