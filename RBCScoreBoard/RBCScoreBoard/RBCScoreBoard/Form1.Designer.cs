
namespace RBCScoreBoard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnMode = new System.Windows.Forms.Button();
            this.bttnExport = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnPause = new System.Windows.Forms.Button();
            this.bttnFinish = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.RedPotLabel = new System.Windows.Forms.Label();
            this.ViolationAR = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.RetryAR = new System.Windows.Forms.Label();
            this.PotIIIRed = new System.Windows.Forms.Label();
            this.PotIIRed = new System.Windows.Forms.Label();
            this.PotIRRed = new System.Windows.Forms.Label();
            this.PotILRed = new System.Windows.Forms.Label();
            this.ViolationARNum = new System.Windows.Forms.NumericUpDown();
            this.RetryARNum = new System.Windows.Forms.NumericUpDown();
            this.PotIIRedNum = new System.Windows.Forms.NumericUpDown();
            this.PotIIIRedNum = new System.Windows.Forms.NumericUpDown();
            this.PotIRRedNum = new System.Windows.Forms.NumericUpDown();
            this.PotILRedNum = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.nameTeam = new System.Windows.Forms.TextBox();
            this.ViolationTR = new System.Windows.Forms.Label();
            this.BluePotLabel = new System.Windows.Forms.Label();
            this.RetryTR = new System.Windows.Forms.Label();
            this.PotILBlueNum = new System.Windows.Forms.NumericUpDown();
            this.PotIRBlueNum = new System.Windows.Forms.NumericUpDown();
            this.PotIIIBlue = new System.Windows.Forms.Label();
            this.PotIIIBlueNum = new System.Windows.Forms.NumericUpDown();
            this.PotIIBlue = new System.Windows.Forms.Label();
            this.ViolationTRNum = new System.Windows.Forms.NumericUpDown();
            this.PotIIBlueNum = new System.Windows.Forms.NumericUpDown();
            this.RetryTRNum = new System.Windows.Forms.NumericUpDown();
            this.PotIRBlue = new System.Windows.Forms.Label();
            this.PotILBlue = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.TotalScore = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.TotScoreDisp = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblMode = new System.Windows.Forms.Label();
            this.lblModeNum = new System.Windows.Forms.Label();
            this.dispIncrementFlag = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dispColourFlag = new System.Windows.Forms.Label();
            this.lblColourFlag = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationARNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryARNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIRedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIIRedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIRRedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotILRedNum)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PotILBlueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIRBlueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIIBlueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationTRNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIBlueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryTRNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttnMode);
            this.panel1.Controls.Add(this.bttnExport);
            this.panel1.Controls.Add(this.bttnReset);
            this.panel1.Controls.Add(this.bttnPause);
            this.panel1.Controls.Add(this.bttnFinish);
            this.panel1.Controls.Add(this.bttnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 690);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 60);
            this.panel1.TabIndex = 0;
            // 
            // bttnMode
            // 
            this.bttnMode.BackColor = System.Drawing.Color.White;
            this.bttnMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnMode.FlatAppearance.BorderSize = 0;
            this.bttnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMode.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnMode.Location = new System.Drawing.Point(0, 3);
            this.bttnMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnMode.Name = "bttnMode";
            this.bttnMode.Size = new System.Drawing.Size(160, 55);
            this.bttnMode.TabIndex = 0;
            this.bttnMode.Tag = "";
            this.bttnMode.Text = "Mode";
            this.bttnMode.UseVisualStyleBackColor = false;
            this.bttnMode.Click += new System.EventHandler(this.bttnMode_Click);
            // 
            // bttnExport
            // 
            this.bttnExport.BackColor = System.Drawing.Color.White;
            this.bttnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnExport.FlatAppearance.BorderSize = 0;
            this.bttnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExport.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnExport.Location = new System.Drawing.Point(858, 3);
            this.bttnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(160, 55);
            this.bttnExport.TabIndex = 0;
            this.bttnExport.Tag = "";
            this.bttnExport.Text = "Export";
            this.bttnExport.UseVisualStyleBackColor = false;
            this.bttnExport.Click += new System.EventHandler(this.bttnExport_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.BackColor = System.Drawing.Color.White;
            this.bttnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnReset.FlatAppearance.BorderSize = 0;
            this.bttnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReset.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnReset.Location = new System.Drawing.Point(170, 3);
            this.bttnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(160, 55);
            this.bttnReset.TabIndex = 0;
            this.bttnReset.Tag = "";
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = false;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // bttnPause
            // 
            this.bttnPause.BackColor = System.Drawing.Color.White;
            this.bttnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnPause.FlatAppearance.BorderSize = 0;
            this.bttnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPause.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnPause.Location = new System.Drawing.Point(694, 3);
            this.bttnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnPause.Name = "bttnPause";
            this.bttnPause.Size = new System.Drawing.Size(160, 55);
            this.bttnPause.TabIndex = 0;
            this.bttnPause.Tag = "";
            this.bttnPause.Text = "Pause";
            this.bttnPause.UseVisualStyleBackColor = false;
            this.bttnPause.Click += new System.EventHandler(this.bttnPause_Click);
            // 
            // bttnFinish
            // 
            this.bttnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnFinish.BackColor = System.Drawing.Color.White;
            this.bttnFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnFinish.FlatAppearance.BorderSize = 0;
            this.bttnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFinish.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnFinish.Location = new System.Drawing.Point(530, 3);
            this.bttnFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnFinish.Name = "bttnFinish";
            this.bttnFinish.Size = new System.Drawing.Size(162, 55);
            this.bttnFinish.TabIndex = 0;
            this.bttnFinish.Tag = "";
            this.bttnFinish.Text = "Finish";
            this.bttnFinish.UseVisualStyleBackColor = false;
            this.bttnFinish.Click += new System.EventHandler(this.bttnFinish_Click);
            // 
            // bttnStart
            // 
            this.bttnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnStart.BackColor = System.Drawing.Color.White;
            this.bttnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnStart.FlatAppearance.BorderSize = 0;
            this.bttnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStart.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnStart.Location = new System.Drawing.Point(334, 3);
            this.bttnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(162, 55);
            this.bttnStart.TabIndex = 0;
            this.bttnStart.Tag = "";
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.lblFileName);
            this.panel2.Controls.Add(this.RedPotLabel);
            this.panel2.Controls.Add(this.ViolationAR);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Controls.Add(this.RetryAR);
            this.panel2.Controls.Add(this.PotIIIRed);
            this.panel2.Controls.Add(this.PotIIRed);
            this.panel2.Controls.Add(this.PotIRRed);
            this.panel2.Controls.Add(this.PotILRed);
            this.panel2.Controls.Add(this.ViolationARNum);
            this.panel2.Controls.Add(this.RetryARNum);
            this.panel2.Controls.Add(this.PotIIRedNum);
            this.panel2.Controls.Add(this.PotIIIRedNum);
            this.panel2.Controls.Add(this.PotIRRedNum);
            this.panel2.Controls.Add(this.PotILRedNum);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 560);
            this.panel2.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(50, 477);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(112, 25);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "File Name:";
            // 
            // RedPotLabel
            // 
            this.RedPotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedPotLabel.AutoSize = true;
            this.RedPotLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedPotLabel.Location = new System.Drawing.Point(99, 12);
            this.RedPotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RedPotLabel.Name = "RedPotLabel";
            this.RedPotLabel.Size = new System.Drawing.Size(139, 52);
            this.RedPotLabel.TabIndex = 2;
            this.RedPotLabel.Text = "RED POT";
            // 
            // ViolationAR
            // 
            this.ViolationAR.AutoSize = true;
            this.ViolationAR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationAR.Location = new System.Drawing.Point(50, 408);
            this.ViolationAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViolationAR.Name = "ViolationAR";
            this.ViolationAR.Size = new System.Drawing.Size(141, 33);
            this.ViolationAR.TabIndex = 1;
            this.ViolationAR.Text = "Violation AR";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(56, 510);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(240, 36);
            this.txtFileName.TabIndex = 3;
            // 
            // RetryAR
            // 
            this.RetryAR.AutoSize = true;
            this.RetryAR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryAR.Location = new System.Drawing.Point(50, 355);
            this.RetryAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RetryAR.Name = "RetryAR";
            this.RetryAR.Size = new System.Drawing.Size(108, 33);
            this.RetryAR.TabIndex = 1;
            this.RetryAR.Text = "Retry AR";
            // 
            // PotIIIRed
            // 
            this.PotIIIRed.AutoSize = true;
            this.PotIIIRed.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIIRed.Location = new System.Drawing.Point(50, 276);
            this.PotIIIRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotIIIRed.Name = "PotIIIRed";
            this.PotIIIRed.Size = new System.Drawing.Size(72, 33);
            this.PotIIIRed.TabIndex = 1;
            this.PotIIIRed.Text = "Pot III";
            // 
            // PotIIRed
            // 
            this.PotIIRed.AutoSize = true;
            this.PotIIRed.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIRed.Location = new System.Drawing.Point(50, 224);
            this.PotIIRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotIIRed.Name = "PotIIRed";
            this.PotIIRed.Size = new System.Drawing.Size(66, 33);
            this.PotIIRed.TabIndex = 1;
            this.PotIIRed.Text = "Pot II";
            // 
            // PotIRRed
            // 
            this.PotIRRed.AutoSize = true;
            this.PotIRRed.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIRRed.Location = new System.Drawing.Point(50, 170);
            this.PotIRRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotIRRed.Name = "PotIRRed";
            this.PotIRRed.Size = new System.Drawing.Size(81, 33);
            this.PotIRRed.TabIndex = 1;
            this.PotIRRed.Text = "Pot I R";
            // 
            // PotILRed
            // 
            this.PotILRed.AutoSize = true;
            this.PotILRed.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotILRed.Location = new System.Drawing.Point(50, 116);
            this.PotILRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotILRed.Name = "PotILRed";
            this.PotILRed.Size = new System.Drawing.Size(79, 33);
            this.PotILRed.TabIndex = 1;
            this.PotILRed.Text = "Pot I L";
            // 
            // ViolationARNum
            // 
            this.ViolationARNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationARNum.Location = new System.Drawing.Point(233, 413);
            this.ViolationARNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViolationARNum.Name = "ViolationARNum";
            this.ViolationARNum.Size = new System.Drawing.Size(60, 32);
            this.ViolationARNum.TabIndex = 0;
            this.ViolationARNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // RetryARNum
            // 
            this.RetryARNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryARNum.Location = new System.Drawing.Point(233, 360);
            this.RetryARNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RetryARNum.Name = "RetryARNum";
            this.RetryARNum.Size = new System.Drawing.Size(60, 32);
            this.RetryARNum.TabIndex = 0;
            this.RetryARNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIIRedNum
            // 
            this.PotIIRedNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIRedNum.Location = new System.Drawing.Point(233, 229);
            this.PotIIRedNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotIIRedNum.Name = "PotIIRedNum";
            this.PotIIRedNum.Size = new System.Drawing.Size(60, 32);
            this.PotIIRedNum.TabIndex = 0;
            this.PotIIRedNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIIIRedNum
            // 
            this.PotIIIRedNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIIRedNum.Location = new System.Drawing.Point(233, 281);
            this.PotIIIRedNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotIIIRedNum.Name = "PotIIIRedNum";
            this.PotIIIRedNum.Size = new System.Drawing.Size(60, 32);
            this.PotIIIRedNum.TabIndex = 0;
            this.PotIIIRedNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIRRedNum
            // 
            this.PotIRRedNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIRRedNum.Location = new System.Drawing.Point(233, 177);
            this.PotIRRedNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotIRRedNum.Name = "PotIRRedNum";
            this.PotIRRedNum.Size = new System.Drawing.Size(60, 32);
            this.PotIRRedNum.TabIndex = 0;
            this.PotIRRedNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotILRedNum
            // 
            this.PotILRedNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotILRedNum.Location = new System.Drawing.Point(233, 123);
            this.PotILRedNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotILRedNum.Name = "PotILRedNum";
            this.PotILRedNum.Size = new System.Drawing.Size(60, 32);
            this.PotILRedNum.TabIndex = 0;
            this.PotILRedNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.lblTeamName);
            this.panel3.Controls.Add(this.nameTeam);
            this.panel3.Controls.Add(this.ViolationTR);
            this.panel3.Controls.Add(this.BluePotLabel);
            this.panel3.Controls.Add(this.RetryTR);
            this.panel3.Controls.Add(this.PotILBlueNum);
            this.panel3.Controls.Add(this.PotIRBlueNum);
            this.panel3.Controls.Add(this.PotIIIBlue);
            this.panel3.Controls.Add(this.PotIIIBlueNum);
            this.panel3.Controls.Add(this.PotIIBlue);
            this.panel3.Controls.Add(this.ViolationTRNum);
            this.panel3.Controls.Add(this.PotIIBlueNum);
            this.panel3.Controls.Add(this.RetryTRNum);
            this.panel3.Controls.Add(this.PotIRBlue);
            this.panel3.Controls.Add(this.PotILBlue);
            this.panel3.Location = new System.Drawing.Point(658, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 560);
            this.panel3.TabIndex = 1;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.White;
            this.lblTeamName.Location = new System.Drawing.Point(61, 477);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(66, 25);
            this.lblTeamName.TabIndex = 8;
            this.lblTeamName.Text = "Team:";
            // 
            // nameTeam
            // 
            this.nameTeam.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTeam.Location = new System.Drawing.Point(67, 510);
            this.nameTeam.Name = "nameTeam";
            this.nameTeam.Size = new System.Drawing.Size(240, 36);
            this.nameTeam.TabIndex = 3;
            // 
            // ViolationTR
            // 
            this.ViolationTR.AutoSize = true;
            this.ViolationTR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationTR.Location = new System.Drawing.Point(74, 408);
            this.ViolationTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViolationTR.Name = "ViolationTR";
            this.ViolationTR.Size = new System.Drawing.Size(138, 33);
            this.ViolationTR.TabIndex = 1;
            this.ViolationTR.Text = "Violation TR";
            // 
            // BluePotLabel
            // 
            this.BluePotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BluePotLabel.AutoSize = true;
            this.BluePotLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BluePotLabel.Location = new System.Drawing.Point(111, 16);
            this.BluePotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BluePotLabel.Name = "BluePotLabel";
            this.BluePotLabel.Size = new System.Drawing.Size(152, 52);
            this.BluePotLabel.TabIndex = 2;
            this.BluePotLabel.Text = "BLUE POT";
            // 
            // RetryTR
            // 
            this.RetryTR.AutoSize = true;
            this.RetryTR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryTR.Location = new System.Drawing.Point(74, 355);
            this.RetryTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RetryTR.Name = "RetryTR";
            this.RetryTR.Size = new System.Drawing.Size(105, 33);
            this.RetryTR.TabIndex = 1;
            this.RetryTR.Text = "Retry TR";
            // 
            // PotILBlueNum
            // 
            this.PotILBlueNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotILBlueNum.Location = new System.Drawing.Point(246, 123);
            this.PotILBlueNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotILBlueNum.Name = "PotILBlueNum";
            this.PotILBlueNum.Size = new System.Drawing.Size(60, 32);
            this.PotILBlueNum.TabIndex = 0;
            this.PotILBlueNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIRBlueNum
            // 
            this.PotIRBlueNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIRBlueNum.Location = new System.Drawing.Point(246, 175);
            this.PotIRBlueNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotIRBlueNum.Name = "PotIRBlueNum";
            this.PotIRBlueNum.Size = new System.Drawing.Size(60, 32);
            this.PotIRBlueNum.TabIndex = 0;
            this.PotIRBlueNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIIIBlue
            // 
            this.PotIIIBlue.AutoSize = true;
            this.PotIIIBlue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIIBlue.Location = new System.Drawing.Point(74, 276);
            this.PotIIIBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotIIIBlue.Name = "PotIIIBlue";
            this.PotIIIBlue.Size = new System.Drawing.Size(72, 33);
            this.PotIIIBlue.TabIndex = 1;
            this.PotIIIBlue.Text = "Pot III";
            // 
            // PotIIIBlueNum
            // 
            this.PotIIIBlueNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIIBlueNum.Location = new System.Drawing.Point(247, 281);
            this.PotIIIBlueNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotIIIBlueNum.Name = "PotIIIBlueNum";
            this.PotIIIBlueNum.Size = new System.Drawing.Size(60, 32);
            this.PotIIIBlueNum.TabIndex = 0;
            this.PotIIIBlueNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIIBlue
            // 
            this.PotIIBlue.AutoSize = true;
            this.PotIIBlue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIBlue.Location = new System.Drawing.Point(74, 224);
            this.PotIIBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotIIBlue.Name = "PotIIBlue";
            this.PotIIBlue.Size = new System.Drawing.Size(66, 33);
            this.PotIIBlue.TabIndex = 1;
            this.PotIIBlue.Text = "Pot II";
            // 
            // ViolationTRNum
            // 
            this.ViolationTRNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationTRNum.Location = new System.Drawing.Point(245, 413);
            this.ViolationTRNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViolationTRNum.Name = "ViolationTRNum";
            this.ViolationTRNum.Size = new System.Drawing.Size(60, 32);
            this.ViolationTRNum.TabIndex = 0;
            this.ViolationTRNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIIBlueNum
            // 
            this.PotIIBlueNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIIBlueNum.Location = new System.Drawing.Point(247, 229);
            this.PotIIBlueNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PotIIBlueNum.Name = "PotIIBlueNum";
            this.PotIIBlueNum.Size = new System.Drawing.Size(60, 32);
            this.PotIIBlueNum.TabIndex = 0;
            this.PotIIBlueNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // RetryTRNum
            // 
            this.RetryTRNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryTRNum.Location = new System.Drawing.Point(245, 360);
            this.RetryTRNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RetryTRNum.Name = "RetryTRNum";
            this.RetryTRNum.Size = new System.Drawing.Size(60, 32);
            this.RetryTRNum.TabIndex = 0;
            this.RetryTRNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // PotIRBlue
            // 
            this.PotIRBlue.AutoSize = true;
            this.PotIRBlue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotIRBlue.Location = new System.Drawing.Point(73, 172);
            this.PotIRBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotIRBlue.Name = "PotIRBlue";
            this.PotIRBlue.Size = new System.Drawing.Size(81, 33);
            this.PotIRBlue.TabIndex = 1;
            this.PotIRBlue.Text = "Pot I R";
            // 
            // PotILBlue
            // 
            this.PotILBlue.AutoSize = true;
            this.PotILBlue.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotILBlue.Location = new System.Drawing.Point(74, 118);
            this.PotILBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PotILBlue.Name = "PotILBlue";
            this.PotILBlue.Size = new System.Drawing.Size(79, 33);
            this.PotILBlue.TabIndex = 1;
            this.PotILBlue.Text = "Pot I L";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.White;
            this.Timer.Location = new System.Drawing.Point(404, 193);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(76, 25);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "Timer :";
            // 
            // TotalScore
            // 
            this.TotalScore.AutoSize = true;
            this.TotalScore.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScore.ForeColor = System.Drawing.Color.White;
            this.TotalScore.Location = new System.Drawing.Point(422, 346);
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.Size = new System.Drawing.Size(193, 42);
            this.TotalScore.TabIndex = 4;
            this.TotalScore.Text = "Total Score";
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(232, 15);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(541, 58);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "UTM ROBOCON SCOREBOARD 2021";
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.Color.White;
            this.Countdown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Countdown.Location = new System.Drawing.Point(474, 178);
            this.Countdown.Name = "Countdown";
            this.Countdown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Countdown.Size = new System.Drawing.Size(68, 77);
            this.Countdown.TabIndex = 5;
            this.Countdown.Text = "5";
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Red;
            this.bttnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnExit.Location = new System.Drawing.Point(978, 15);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(25, 25);
            this.bttnExit.TabIndex = 6;
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 12);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(226, 45);
            this.WindowsMediaPlayer.TabIndex = 7;
            this.WindowsMediaPlayer.Visible = false;
            // 
            // TotScoreDisp
            // 
            this.TotScoreDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotScoreDisp.AutoSize = true;
            this.TotScoreDisp.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotScoreDisp.ForeColor = System.Drawing.Color.White;
            this.TotScoreDisp.Location = new System.Drawing.Point(468, 421);
            this.TotScoreDisp.Name = "TotScoreDisp";
            this.TotScoreDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotScoreDisp.Size = new System.Drawing.Size(102, 77);
            this.TotScoreDisp.TabIndex = 5;
            this.TotScoreDisp.Text = "00";
            this.TotScoreDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(433, 282);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(45, 16);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Mode :";
            // 
            // lblModeNum
            // 
            this.lblModeNum.AutoSize = true;
            this.lblModeNum.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeNum.ForeColor = System.Drawing.Color.White;
            this.lblModeNum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblModeNum.Location = new System.Drawing.Point(495, 282);
            this.lblModeNum.Name = "lblModeNum";
            this.lblModeNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblModeNum.Size = new System.Drawing.Size(19, 25);
            this.lblModeNum.TabIndex = 5;
            this.lblModeNum.Text = "1";
            this.lblModeNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dispIncrementFlag
            // 
            this.dispIncrementFlag.AutoSize = true;
            this.dispIncrementFlag.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispIncrementFlag.ForeColor = System.Drawing.Color.White;
            this.dispIncrementFlag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dispIncrementFlag.Location = new System.Drawing.Point(556, 574);
            this.dispIncrementFlag.Name = "dispIncrementFlag";
            this.dispIncrementFlag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dispIncrementFlag.Size = new System.Drawing.Size(23, 25);
            this.dispIncrementFlag.TabIndex = 11;
            this.dispIncrementFlag.Text = "+";
            this.dispIncrementFlag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(518, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Increment Flag :";
            // 
            // dispColourFlag
            // 
            this.dispColourFlag.AutoSize = true;
            this.dispColourFlag.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispColourFlag.ForeColor = System.Drawing.Color.White;
            this.dispColourFlag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dispColourFlag.Location = new System.Drawing.Point(408, 574);
            this.dispColourFlag.Name = "dispColourFlag";
            this.dispColourFlag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dispColourFlag.Size = new System.Drawing.Size(48, 25);
            this.dispColourFlag.TabIndex = 9;
            this.dispColourFlag.Text = "Red";
            this.dispColourFlag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColourFlag
            // 
            this.lblColourFlag.AutoSize = true;
            this.lblColourFlag.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourFlag.ForeColor = System.Drawing.Color.White;
            this.lblColourFlag.Location = new System.Drawing.Point(398, 551);
            this.lblColourFlag.Name = "lblColourFlag";
            this.lblColourFlag.Size = new System.Drawing.Size(81, 16);
            this.lblColourFlag.TabIndex = 8;
            this.lblColourFlag.Text = "Colour Flag :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1022, 750);
            this.Controls.Add(this.dispIncrementFlag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dispColourFlag);
            this.Controls.Add(this.lblColourFlag);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.TotScoreDisp);
            this.Controls.Add(this.lblModeNum);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.TotalScore);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationARNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryARNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIRedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIIRedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIRRedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotILRedNum)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PotILBlueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIRBlueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIIBlueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationTRNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotIIBlueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryTRNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnExport;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown PotILRedNum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RedPotLabel;
        private System.Windows.Forms.Label ViolationAR;
        private System.Windows.Forms.Label RetryAR;
        private System.Windows.Forms.Label PotIIIRed;
        private System.Windows.Forms.Label PotIIRed;
        private System.Windows.Forms.Label PotIRRed;
        private System.Windows.Forms.Label PotILRed;
        private System.Windows.Forms.NumericUpDown ViolationARNum;
        private System.Windows.Forms.NumericUpDown RetryARNum;
        private System.Windows.Forms.NumericUpDown PotIIRedNum;
        private System.Windows.Forms.NumericUpDown PotIIIRedNum;
        private System.Windows.Forms.NumericUpDown PotIRRedNum;
        private System.Windows.Forms.Label BluePotLabel;
        private System.Windows.Forms.Button bttnMode;
        private System.Windows.Forms.Button bttnPause;
        private System.Windows.Forms.NumericUpDown PotILBlueNum;
        private System.Windows.Forms.NumericUpDown PotIRBlueNum;
        private System.Windows.Forms.Label PotIIIBlue;
        private System.Windows.Forms.NumericUpDown PotIIIBlueNum;
        private System.Windows.Forms.Label PotIIBlue;
        private System.Windows.Forms.NumericUpDown PotIIBlueNum;
        private System.Windows.Forms.Label PotIRBlue;
        private System.Windows.Forms.Label PotILBlue;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label TotalScore;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Button bttnExit;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Label TotScoreDisp;
        private System.Windows.Forms.Button bttnFinish;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox nameTeam;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblModeNum;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label ViolationTR;
        private System.Windows.Forms.Label RetryTR;
        private System.Windows.Forms.NumericUpDown ViolationTRNum;
        private System.Windows.Forms.NumericUpDown RetryTRNum;
        private System.Windows.Forms.Label dispIncrementFlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dispColourFlag;
        private System.Windows.Forms.Label lblColourFlag;
    }
}

