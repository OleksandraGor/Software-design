
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace proces
{
    public partial class ProcessManagerForm : Form
    {

        private void LoadProcesses()
        {
            int? selectedProcessId = null;

            if (dgvProcesses.SelectedRows.Count > 0)
            {
                selectedProcessId = Convert.ToInt32(
                    dgvProcesses.SelectedRows[0].Cells["colProcessId"].Value
                );
            }

            dgvProcesses.Rows.Clear();

            Process[] processes = Process.GetProcesses()
                .OrderBy(p => p.ProcessName)
                .ToArray();

            foreach (Process process in processes)
            {
                try
                {
                    int rowIndex = dgvProcesses.Rows.Add(
                        process.Id,
                        process.ProcessName,
                        (process.WorkingSet64 / 1024 / 1024) + " MB",
                        process.StartTime.ToString("HH:mm:ss"),
                        process.PriorityClass.ToString(),
                        process.Threads.Count
                    );

                    if (IsSystemProcess(process))
                    {
                        dgvProcesses.Rows[rowIndex]
                            .DefaultCellStyle.ForeColor = Color.Gray;
                    }

                    // возвращаем выделение
                    if (selectedProcessId.HasValue &&
                        process.Id == selectedProcessId.Value)
                    {
                        dgvProcesses.Rows[rowIndex].Selected = true;
                    }
                }
                catch
                {
                }
            }
        }




        private void LaunchApp(string fileName)
        {
            try
            {
                Process.Start(fileName);
                LoadProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не вдалося запустити програму:\n" + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnLaunchCalculator_Click(object sender, EventArgs e)
        {
            LaunchApp("calc");
        }

        //private void btnLaunchWord_Click(object sender, EventArgs e)
        //{
        //    LaunchApp("winword");
        //}

        private void btnLaunchNotepad_Click(object sender, EventArgs e)
        {
            LaunchApp("notepad");
        }

        private void btnLaunchPaint_Click(object sender, EventArgs e)
        {
            LaunchApp("mspaint");
        }

        private void btnLaunchExplorer_Click(object sender, EventArgs e)
        {
            LaunchApp("explorer");
        }

        private void btnRefreshProcesses_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void ProcessManagerForm_Load(object sender, EventArgs e)
        {
            LoadProcesses();

            cbPriority.Items.AddRange(new object[]
            {
        ProcessPriorityClass.Idle,
        ProcessPriorityClass.BelowNormal,
        ProcessPriorityClass.Normal,
        ProcessPriorityClass.AboveNormal,
        ProcessPriorityClass.High,
        ProcessPriorityClass.RealTime
            });

            cbPriority.SelectedIndex = 2; // Normal
        }

        private int GetSelectedProcessId()
        {
            if (dgvProcesses.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(
                dgvProcesses.SelectedRows[0].Cells["colProcessId"].Value
            );
        }


        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            int processId = GetSelectedProcessId();

            if (processId == -1)
            {
                MessageBox.Show("Оберіть процес у таблиці.");
                return;
            }

            try
            {
                Process process = Process.GetProcessById(processId);

                DialogResult result = MessageBox.Show(
                    $"Зупинити процес {process.ProcessName}?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    process.Kill();
                    LoadProcesses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не вдалося зупинити процес:\n" + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnSetPriority_Click(object sender, EventArgs e)
        {
            int processId = GetSelectedProcessId();

            if (processId == -1)
            {
                MessageBox.Show("Оберіть процес у таблиці.");
                return;
            }

            try
            {
                Process process = Process.GetProcessById(processId);
                if (IsSystemProcess(process))
                {
                    MessageBox.Show(
                        "Це системний процес. Його не можна зупиняти.",
                        "Заборонено",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                ProcessPriorityClass priority =
                    (ProcessPriorityClass)cbPriority.SelectedItem;

                process.PriorityClass = priority;
                LoadProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не вдалося змінити пріоритет:\n" + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool IsSystemProcess(Process process)
        {
            try
            {
                var _ = process.StartTime;
                var __ = process.PriorityClass;
                return false;
            }
            catch
            {
                return true;
            }
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadProcesses();
        }
        private void btnLaunchTelegram_Click(object sender, EventArgs e)
        {
            LaunchApp("telegram.exe");
        }
        private void btnLaunchPhotoshop_Click(object sender, EventArgs e)
        {
            LaunchApp("photoshop.exe");
        }
        private void btnLaunchChrome_Click(object sender, EventArgs e)
        {
            LaunchApp("chrome.exe");
        }
        private void btnLaunchWord_Click(object sender, EventArgs e)
        {
            LaunchApp("winword.exe");
        }


        public ProcessManagerForm()
        {
            InitializeComponent();
        }
    }
}
