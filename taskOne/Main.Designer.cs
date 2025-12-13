namespace taskOne
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtKey = new TextBox();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtOutputPath = new TextBox();
            btnSaveAs = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            progressBar1 = new ProgressBar();
            lblProgress = new Label();
            lblElapsedTime = new Label();
            timer = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Ключ шифрування";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(12, 27);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(270, 23);
            txtKey.TabIndex = 1;
            txtKey.UseSystemPasswordChar = true;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 97);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(270, 23);
            txtFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(12, 126);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(113, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Обрати файл";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new Point(332, 97);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.ReadOnly = true;
            txtOutputPath.Size = new Size(270, 23);
            txtOutputPath.TabIndex = 4;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Location = new Point(332, 140);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(113, 23);
            btnSaveAs.TabIndex = 5;
            btnSaveAs.Text = "Куди зберегти…";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(447, 363);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(113, 23);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Шифрувати";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(566, 363);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(113, 23);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Розшифрувати";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.TabIndex = 8;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(387, 415);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(23, 15);
            lblProgress.TabIndex = 9;
            lblProgress.Text = "0%";
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(354, 397);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(75, 15);
            lblElapsedTime.TabIndex = 10;
            lblElapsedTime.Text = "Час: 00:00:00";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblElapsedTime);
            Controls.Add(lblProgress);
            Controls.Add(progressBar1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnSaveAs);
            Controls.Add(txtOutputPath);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(txtKey);
            Controls.Add(label1);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKey;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
        private TextBox txtOutputPath;
        private Button btnSaveAs;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private ProgressBar progressBar1;
        private Label lblProgress;
        private Label lblElapsedTime;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
