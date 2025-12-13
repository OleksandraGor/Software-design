namespace proces
{
    partial class ProcessManagerForm
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
            dgvProcesses = new DataGridView();
            colProcessId = new DataGridViewTextBoxColumn();
            colProcessName = new DataGridViewTextBoxColumn();
            colMemory = new DataGridViewTextBoxColumn();
            colStartTime = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colThreads = new DataGridViewTextBoxColumn();
            gbLaunchApps = new GroupBox();
            button1 = new Button();
            button7 = new Button();
            button6 = new Button();
            btnLaunchExplorer = new Button();
            btnLaunchPaint = new Button();
            btnLaunchNotepad = new Button();
            btnLaunchWord = new Button();
            btnLaunchCalculator = new Button();
            gbProcessControl = new GroupBox();
            cbPriority = new ComboBox();
            btnKillProcess = new Button();
            btnRefreshProcesses = new Button();
            btnSetPriority = new Button();
            timerRefresh = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvProcesses).BeginInit();
            gbLaunchApps.SuspendLayout();
            gbProcessControl.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProcesses
            // 
            dgvProcesses.AllowUserToOrderColumns = true;
            dgvProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcesses.Columns.AddRange(new DataGridViewColumn[] { colProcessId, colProcessName, colMemory, colStartTime, colPriority, colThreads });
            dgvProcesses.Location = new Point(12, 12);
            dgvProcesses.MultiSelect = false;
            dgvProcesses.Name = "dgvProcesses";
            dgvProcesses.ReadOnly = true;
            dgvProcesses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProcesses.Size = new Size(754, 937);
            dgvProcesses.TabIndex = 0;
            // 
            // colProcessId
            // 
            colProcessId.HeaderText = "ID";
            colProcessId.Name = "colProcessId";
            colProcessId.ReadOnly = true;
            // 
            // colProcessName
            // 
            colProcessName.HeaderText = "ProcessName";
            colProcessName.Name = "colProcessName";
            colProcessName.ReadOnly = true;
            // 
            // colMemory
            // 
            colMemory.HeaderText = "MemoryMB";
            colMemory.Name = "colMemory";
            colMemory.ReadOnly = true;
            // 
            // colStartTime
            // 
            colStartTime.HeaderText = "StartTime";
            colStartTime.Name = "colStartTime";
            colStartTime.ReadOnly = true;
            // 
            // colPriority
            // 
            colPriority.HeaderText = "Priority";
            colPriority.Name = "colPriority";
            colPriority.ReadOnly = true;
            // 
            // colThreads
            // 
            colThreads.HeaderText = "ThreadsCount";
            colThreads.Name = "colThreads";
            colThreads.ReadOnly = true;
            // 
            // gbLaunchApps
            // 
            gbLaunchApps.Controls.Add(button1);
            gbLaunchApps.Controls.Add(button7);
            gbLaunchApps.Controls.Add(button6);
            gbLaunchApps.Controls.Add(btnLaunchExplorer);
            gbLaunchApps.Controls.Add(btnLaunchPaint);
            gbLaunchApps.Controls.Add(btnLaunchNotepad);
            gbLaunchApps.Controls.Add(btnLaunchWord);
            gbLaunchApps.Controls.Add(btnLaunchCalculator);
            gbLaunchApps.Location = new Point(772, 244);
            gbLaunchApps.Name = "gbLaunchApps";
            gbLaunchApps.Size = new Size(200, 270);
            gbLaunchApps.TabIndex = 1;
            gbLaunchApps.TabStop = false;
            gbLaunchApps.Text = "Запуск програм";
            // 
            // button1
            // 
            button1.Location = new Point(6, 225);
            button1.Name = "button1";
            button1.Size = new Size(188, 23);
            button1.TabIndex = 6;
            button1.Text = "telegram";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLaunchTelegram_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 196);
            button7.Name = "button7";
            button7.Size = new Size(188, 23);
            button7.TabIndex = 5;
            button7.Text = "chtome";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnLaunchChrome_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 167);
            button6.Name = "button6";
            button6.Size = new Size(188, 23);
            button6.TabIndex = 4;
            button6.Text = "PS";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnLaunchPhotoshop_Click;
            // 
            // btnLaunchExplorer
            // 
            btnLaunchExplorer.Location = new Point(6, 138);
            btnLaunchExplorer.Name = "btnLaunchExplorer";
            btnLaunchExplorer.Size = new Size(188, 23);
            btnLaunchExplorer.TabIndex = 3;
            btnLaunchExplorer.Text = "Проводник";
            btnLaunchExplorer.UseVisualStyleBackColor = true;
            // 
            // btnLaunchPaint
            // 
            btnLaunchPaint.Location = new Point(6, 109);
            btnLaunchPaint.Name = "btnLaunchPaint";
            btnLaunchPaint.Size = new Size(188, 23);
            btnLaunchPaint.TabIndex = 2;
            btnLaunchPaint.Text = "Paint";
            btnLaunchPaint.UseVisualStyleBackColor = true;
            // 
            // btnLaunchNotepad
            // 
            btnLaunchNotepad.Location = new Point(6, 80);
            btnLaunchNotepad.Name = "btnLaunchNotepad";
            btnLaunchNotepad.Size = new Size(188, 23);
            btnLaunchNotepad.TabIndex = 2;
            btnLaunchNotepad.Text = "Блокнот";
            btnLaunchNotepad.UseVisualStyleBackColor = true;
            // 
            // btnLaunchWord
            // 
            btnLaunchWord.Location = new Point(6, 51);
            btnLaunchWord.Name = "btnLaunchWord";
            btnLaunchWord.Size = new Size(188, 23);
            btnLaunchWord.TabIndex = 1;
            btnLaunchWord.Text = "Microsoft Word";
            btnLaunchWord.UseVisualStyleBackColor = true;
            btnLaunchWord.Click += btnLaunchWord_Click;
            // 
            // btnLaunchCalculator
            // 
            btnLaunchCalculator.Location = new Point(6, 22);
            btnLaunchCalculator.Name = "btnLaunchCalculator";
            btnLaunchCalculator.Size = new Size(188, 23);
            btnLaunchCalculator.TabIndex = 0;
            btnLaunchCalculator.Text = "Калькулятор";
            btnLaunchCalculator.UseVisualStyleBackColor = true;
            btnLaunchCalculator.Click += btnLaunchCalculator_Click;
            // 
            // gbProcessControl
            // 
            gbProcessControl.Controls.Add(cbPriority);
            gbProcessControl.Controls.Add(btnKillProcess);
            gbProcessControl.Controls.Add(btnRefreshProcesses);
            gbProcessControl.Controls.Add(btnSetPriority);
            gbProcessControl.Location = new Point(772, 12);
            gbProcessControl.Name = "gbProcessControl";
            gbProcessControl.Size = new Size(200, 216);
            gbProcessControl.TabIndex = 2;
            gbProcessControl.TabStop = false;
            gbProcessControl.Text = "Керування процесами";
            // 
            // cbPriority
            // 
            cbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "ProcessPriorityClass.Idle", "ProcessPriorityClass.BelowNormal", "ProcessPriorityClass.Normal", "ProcessPriorityClass.AboveNormal", "ProcessPriorityClass.High", "ProcessPriorityClass.RealTime" });
            cbPriority.Location = new Point(0, 77);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(188, 23);
            cbPriority.TabIndex = 9;
            // 
            // btnKillProcess
            // 
            btnKillProcess.Location = new Point(0, 48);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new Size(188, 23);
            btnKillProcess.TabIndex = 8;
            btnKillProcess.Text = "Зупинити процес";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += btnKillProcess_Click;
            // 
            // btnRefreshProcesses
            // 
            btnRefreshProcesses.Location = new Point(0, 22);
            btnRefreshProcesses.Name = "btnRefreshProcesses";
            btnRefreshProcesses.Size = new Size(188, 23);
            btnRefreshProcesses.TabIndex = 7;
            btnRefreshProcesses.Text = "Оновити список";
            btnRefreshProcesses.UseVisualStyleBackColor = true;
            // 
            // btnSetPriority
            // 
            btnSetPriority.Location = new Point(0, 106);
            btnSetPriority.Name = "btnSetPriority";
            btnSetPriority.Size = new Size(188, 23);
            btnSetPriority.TabIndex = 6;
            btnSetPriority.Text = "Змінити пріоритет";
            btnSetPriority.UseVisualStyleBackColor = true;
            btnSetPriority.Click += btnSetPriority_Click;
            // 
            // timerRefresh
            // 
            timerRefresh.Enabled = true;
            timerRefresh.Interval = 3000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // ProcessManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 961);
            Controls.Add(gbProcessControl);
            Controls.Add(gbLaunchApps);
            Controls.Add(dgvProcesses);
            Name = "ProcessManagerForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProcesses).EndInit();
            gbLaunchApps.ResumeLayout(false);
            gbProcessControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProcesses;
        private DataGridViewTextBoxColumn ProcessId;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewTextBoxColumn MemoryMB;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn ThreadsCount;
        private GroupBox gbLaunchApps;
        private Button button6;
        private Button btnLaunchExplorer;
        private Button btnLaunchPaint;
        private Button btnLaunchNotepad;
        private Button btnLaunchWord;
        private Button btnLaunchCalculator;
        private Button button7;
        private GroupBox gbProcessControl;
        private ComboBox cbPriority;
        private Button btnKillProcess;
        private Button btnRefreshProcesses;
        private Button btnSetPriority;
        private DataGridViewTextBoxColumn colProcessId;
        private DataGridViewTextBoxColumn colProcessName;
        private DataGridViewTextBoxColumn colMemory;
        private DataGridViewTextBoxColumn colStartTime;
        private DataGridViewTextBoxColumn colPriority;
        private DataGridViewTextBoxColumn colThreads;
        private System.Windows.Forms.Timer timerRefresh;
        private Button button1;
    }
}
