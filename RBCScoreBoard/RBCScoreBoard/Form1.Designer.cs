
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
            this.bttnRound = new System.Windows.Forms.Button();
            this.bttnExport = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnPause = new System.Windows.Forms.Button();
            this.bttnFinish = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.TotalScore = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.TotScoreDisp = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblRound = new System.Windows.Forms.Label();
            this.lblRoundName = new System.Windows.Forms.Label();
            this.laghoriShotNum = new System.Windows.Forms.NumericUpDown();
            this.LaghoriShot = new System.Windows.Forms.Label();
            this.lblLagoriPick = new System.Windows.Forms.Label();
            this.laghoriPickUpNum = new System.Windows.Forms.NumericUpDown();
            this.lblR1Ctrl = new System.Windows.Forms.Label();
            this.lblR2Ctrl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.R1ViolationNum = new System.Windows.Forms.NumericUpDown();
            this.lblR1Violation = new System.Windows.Forms.Label();
            this.R1RetryNum = new System.Windows.Forms.NumericUpDown();
            this.lblR1Retry = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.R2ViolationNum = new System.Windows.Forms.NumericUpDown();
            this.lblR2Violation = new System.Windows.Forms.Label();
            this.R2RetryNum = new System.Windows.Forms.NumericUpDown();
            this.lblR2Retry = new System.Windows.Forms.Label();
            this.prevRoundDurationTime = new System.Windows.Forms.Label();
            this.lblPrevRoundDura = new System.Windows.Forms.Label();
            this.breakShotDurationTime = new System.Windows.Forms.Label();
            this.lblBreakShotTime = new System.Windows.Forms.Label();
            this.bttnBreakShotEnd = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laghoriShotNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laghoriPickUpNum)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R1ViolationNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1RetryNum)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R2ViolationNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2RetryNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttnRound);
            this.panel1.Controls.Add(this.bttnExport);
            this.panel1.Controls.Add(this.bttnReset);
            this.panel1.Controls.Add(this.bttnPause);
            this.panel1.Controls.Add(this.bttnFinish);
            this.panel1.Controls.Add(this.bttnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 849);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 74);
            this.panel1.TabIndex = 0;
            // 
            // bttnRound
            // 
            this.bttnRound.BackColor = System.Drawing.Color.White;
            this.bttnRound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnRound.FlatAppearance.BorderSize = 0;
            this.bttnRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRound.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnRound.Location = new System.Drawing.Point(0, 4);
            this.bttnRound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnRound.Name = "bttnRound";
            this.bttnRound.Size = new System.Drawing.Size(213, 68);
            this.bttnRound.TabIndex = 0;
            this.bttnRound.Tag = "";
            this.bttnRound.Text = "Round";
            this.bttnRound.UseVisualStyleBackColor = false;
            this.bttnRound.Click += new System.EventHandler(this.bttnMode_Click);
            // 
            // bttnExport
            // 
            this.bttnExport.BackColor = System.Drawing.Color.White;
            this.bttnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnExport.FlatAppearance.BorderSize = 0;
            this.bttnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExport.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnExport.Location = new System.Drawing.Point(1144, 4);
            this.bttnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(213, 68);
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
            this.bttnReset.Location = new System.Drawing.Point(227, 4);
            this.bttnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(213, 68);
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
            this.bttnPause.Location = new System.Drawing.Point(925, 4);
            this.bttnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnPause.Name = "bttnPause";
            this.bttnPause.Size = new System.Drawing.Size(213, 68);
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
            this.bttnFinish.Location = new System.Drawing.Point(707, 4);
            this.bttnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnFinish.Name = "bttnFinish";
            this.bttnFinish.Size = new System.Drawing.Size(216, 68);
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
            this.bttnStart.Location = new System.Drawing.Point(445, 4);
            this.bttnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(216, 68);
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
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.White;
            this.Timer.Location = new System.Drawing.Point(984, 164);
            this.Timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(97, 33);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "Timer :";
            // 
            // TotalScore
            // 
            this.TotalScore.AutoSize = true;
            this.TotalScore.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScore.ForeColor = System.Drawing.Color.White;
            this.TotalScore.Location = new System.Drawing.Point(570, 125);
            this.TotalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.Size = new System.Drawing.Size(244, 53);
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
            this.MainLabel.Location = new System.Drawing.Point(327, 18);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(676, 72);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "UTM ROBOCON SCOREBOARD 2022";
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.Color.White;
            this.Countdown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Countdown.Location = new System.Drawing.Point(990, 190);
            this.Countdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Countdown.Name = "Countdown";
            this.Countdown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Countdown.Size = new System.Drawing.Size(125, 96);
            this.Countdown.TabIndex = 5;
            this.Countdown.Text = "60";
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Red;
            this.bttnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnExit.Location = new System.Drawing.Point(1304, 18);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(33, 31);
            this.bttnExit.TabIndex = 6;
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // TotScoreDisp
            // 
            this.TotScoreDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotScoreDisp.AutoSize = true;
            this.TotScoreDisp.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotScoreDisp.ForeColor = System.Drawing.Color.White;
            this.TotScoreDisp.Location = new System.Drawing.Point(619, 176);
            this.TotScoreDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotScoreDisp.Name = "TotScoreDisp";
            this.TotScoreDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotScoreDisp.Size = new System.Drawing.Size(126, 96);
            this.TotScoreDisp.TabIndex = 5;
            this.TotScoreDisp.Text = "00";
            this.TotScoreDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(335, 176);
            this.lblRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(66, 21);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Round :";
            // 
            // lblRoundName
            // 
            this.lblRoundName.AutoSize = true;
            this.lblRoundName.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundName.ForeColor = System.Drawing.Color.White;
            this.lblRoundName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRoundName.Location = new System.Drawing.Point(288, 207);
            this.lblRoundName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundName.Name = "lblRoundName";
            this.lblRoundName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRoundName.Size = new System.Drawing.Size(158, 33);
            this.lblRoundName.TabIndex = 5;
            this.lblRoundName.Text = "Preparation";
            this.lblRoundName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laghoriShotNum
            // 
            this.laghoriShotNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laghoriShotNum.Location = new System.Drawing.Point(348, 87);
            this.laghoriShotNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laghoriShotNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.laghoriShotNum.Name = "laghoriShotNum";
            this.laghoriShotNum.Size = new System.Drawing.Size(80, 38);
            this.laghoriShotNum.TabIndex = 0;
            this.laghoriShotNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // LaghoriShot
            // 
            this.LaghoriShot.AutoSize = true;
            this.LaghoriShot.BackColor = System.Drawing.Color.Red;
            this.LaghoriShot.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaghoriShot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LaghoriShot.Location = new System.Drawing.Point(60, 84);
            this.LaghoriShot.Name = "LaghoriShot";
            this.LaghoriShot.Size = new System.Drawing.Size(165, 36);
            this.LaghoriShot.TabIndex = 1;
            this.LaghoriShot.Text = "Laghori Shot";
            // 
            // lblLagoriPick
            // 
            this.lblLagoriPick.AutoSize = true;
            this.lblLagoriPick.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLagoriPick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLagoriPick.Location = new System.Drawing.Point(72, 84);
            this.lblLagoriPick.Name = "lblLagoriPick";
            this.lblLagoriPick.Size = new System.Drawing.Size(226, 36);
            this.lblLagoriPick.TabIndex = 9;
            this.lblLagoriPick.Text = "Laghori Picked Up";
            // 
            // laghoriPickUpNum
            // 
            this.laghoriPickUpNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laghoriPickUpNum.Location = new System.Drawing.Point(360, 87);
            this.laghoriPickUpNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laghoriPickUpNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.laghoriPickUpNum.Name = "laghoriPickUpNum";
            this.laghoriPickUpNum.Size = new System.Drawing.Size(80, 38);
            this.laghoriPickUpNum.TabIndex = 8;
            this.laghoriPickUpNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblR1Ctrl
            // 
            this.lblR1Ctrl.AutoSize = true;
            this.lblR1Ctrl.BackColor = System.Drawing.Color.Red;
            this.lblR1Ctrl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1Ctrl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR1Ctrl.Location = new System.Drawing.Point(176, 16);
            this.lblR1Ctrl.Name = "lblR1Ctrl";
            this.lblR1Ctrl.Size = new System.Drawing.Size(156, 36);
            this.lblR1Ctrl.TabIndex = 10;
            this.lblR1Ctrl.Text = "R1 CONTROL";
            // 
            // lblR2Ctrl
            // 
            this.lblR2Ctrl.AutoSize = true;
            this.lblR2Ctrl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR2Ctrl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR2Ctrl.Location = new System.Drawing.Point(183, 16);
            this.lblR2Ctrl.Name = "lblR2Ctrl";
            this.lblR2Ctrl.Size = new System.Drawing.Size(161, 36);
            this.lblR2Ctrl.TabIndex = 11;
            this.lblR2Ctrl.Text = "R2 CONTROL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.R1ViolationNum);
            this.panel2.Controls.Add(this.lblR1Violation);
            this.panel2.Controls.Add(this.R1RetryNum);
            this.panel2.Controls.Add(this.lblR1Retry);
            this.panel2.Controls.Add(this.lblR1Ctrl);
            this.panel2.Controls.Add(this.laghoriShotNum);
            this.panel2.Controls.Add(this.LaghoriShot);
            this.panel2.Location = new System.Drawing.Point(55, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 278);
            this.panel2.TabIndex = 12;
            // 
            // R1ViolationNum
            // 
            this.R1ViolationNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1ViolationNum.Location = new System.Drawing.Point(348, 211);
            this.R1ViolationNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R1ViolationNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.R1ViolationNum.Name = "R1ViolationNum";
            this.R1ViolationNum.Size = new System.Drawing.Size(80, 38);
            this.R1ViolationNum.TabIndex = 13;
            this.R1ViolationNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblR1Violation
            // 
            this.lblR1Violation.AutoSize = true;
            this.lblR1Violation.BackColor = System.Drawing.Color.Red;
            this.lblR1Violation.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1Violation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR1Violation.Location = new System.Drawing.Point(60, 208);
            this.lblR1Violation.Name = "lblR1Violation";
            this.lblR1Violation.Size = new System.Drawing.Size(118, 36);
            this.lblR1Violation.TabIndex = 14;
            this.lblR1Violation.Text = "Violation";
            // 
            // R1RetryNum
            // 
            this.R1RetryNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1RetryNum.Location = new System.Drawing.Point(348, 147);
            this.R1RetryNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R1RetryNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.R1RetryNum.Name = "R1RetryNum";
            this.R1RetryNum.Size = new System.Drawing.Size(80, 38);
            this.R1RetryNum.TabIndex = 11;
            this.R1RetryNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblR1Retry
            // 
            this.lblR1Retry.AutoSize = true;
            this.lblR1Retry.BackColor = System.Drawing.Color.Red;
            this.lblR1Retry.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1Retry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR1Retry.Location = new System.Drawing.Point(60, 144);
            this.lblR1Retry.Name = "lblR1Retry";
            this.lblR1Retry.Size = new System.Drawing.Size(78, 36);
            this.lblR1Retry.TabIndex = 12;
            this.lblR1Retry.Text = "Retry";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.R2ViolationNum);
            this.panel3.Controls.Add(this.lblR2Ctrl);
            this.panel3.Controls.Add(this.lblR2Violation);
            this.panel3.Controls.Add(this.lblLagoriPick);
            this.panel3.Controls.Add(this.R2RetryNum);
            this.panel3.Controls.Add(this.laghoriPickUpNum);
            this.panel3.Controls.Add(this.lblR2Retry);
            this.panel3.Location = new System.Drawing.Point(801, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 278);
            this.panel3.TabIndex = 13;
            // 
            // R2ViolationNum
            // 
            this.R2ViolationNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2ViolationNum.Location = new System.Drawing.Point(360, 211);
            this.R2ViolationNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R2ViolationNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.R2ViolationNum.Name = "R2ViolationNum";
            this.R2ViolationNum.Size = new System.Drawing.Size(80, 38);
            this.R2ViolationNum.TabIndex = 17;
            this.R2ViolationNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblR2Violation
            // 
            this.lblR2Violation.AutoSize = true;
            this.lblR2Violation.BackColor = System.Drawing.Color.Blue;
            this.lblR2Violation.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR2Violation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR2Violation.Location = new System.Drawing.Point(72, 208);
            this.lblR2Violation.Name = "lblR2Violation";
            this.lblR2Violation.Size = new System.Drawing.Size(118, 36);
            this.lblR2Violation.TabIndex = 18;
            this.lblR2Violation.Text = "Violation";
            // 
            // R2RetryNum
            // 
            this.R2RetryNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2RetryNum.Location = new System.Drawing.Point(360, 147);
            this.R2RetryNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R2RetryNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.R2RetryNum.Name = "R2RetryNum";
            this.R2RetryNum.Size = new System.Drawing.Size(80, 38);
            this.R2RetryNum.TabIndex = 15;
            this.R2RetryNum.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblR2Retry
            // 
            this.lblR2Retry.AutoSize = true;
            this.lblR2Retry.BackColor = System.Drawing.Color.Blue;
            this.lblR2Retry.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR2Retry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR2Retry.Location = new System.Drawing.Point(72, 144);
            this.lblR2Retry.Name = "lblR2Retry";
            this.lblR2Retry.Size = new System.Drawing.Size(78, 36);
            this.lblR2Retry.TabIndex = 16;
            this.lblR2Retry.Text = "Retry";
            // 
            // prevRoundDurationTime
            // 
            this.prevRoundDurationTime.AutoSize = true;
            this.prevRoundDurationTime.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevRoundDurationTime.ForeColor = System.Drawing.Color.White;
            this.prevRoundDurationTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prevRoundDurationTime.Location = new System.Drawing.Point(991, 701);
            this.prevRoundDurationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prevRoundDurationTime.Name = "prevRoundDurationTime";
            this.prevRoundDurationTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prevRoundDurationTime.Size = new System.Drawing.Size(126, 96);
            this.prevRoundDurationTime.TabIndex = 15;
            this.prevRoundDurationTime.Text = "00";
            this.prevRoundDurationTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrevRoundDura
            // 
            this.lblPrevRoundDura.AutoSize = true;
            this.lblPrevRoundDura.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevRoundDura.ForeColor = System.Drawing.Color.White;
            this.lblPrevRoundDura.Location = new System.Drawing.Point(919, 668);
            this.lblPrevRoundDura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevRoundDura.Name = "lblPrevRoundDura";
            this.lblPrevRoundDura.Size = new System.Drawing.Size(279, 33);
            this.lblPrevRoundDura.TabIndex = 14;
            this.lblPrevRoundDura.Text = "Prev Round Duration :";
            // 
            // breakShotDurationTime
            // 
            this.breakShotDurationTime.AutoSize = true;
            this.breakShotDurationTime.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakShotDurationTime.ForeColor = System.Drawing.Color.White;
            this.breakShotDurationTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.breakShotDurationTime.Location = new System.Drawing.Point(155, 701);
            this.breakShotDurationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakShotDurationTime.Name = "breakShotDurationTime";
            this.breakShotDurationTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.breakShotDurationTime.Size = new System.Drawing.Size(126, 96);
            this.breakShotDurationTime.TabIndex = 17;
            this.breakShotDurationTime.Text = "00";
            this.breakShotDurationTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBreakShotTime
            // 
            this.lblBreakShotTime.AutoSize = true;
            this.lblBreakShotTime.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakShotTime.ForeColor = System.Drawing.Color.White;
            this.lblBreakShotTime.Location = new System.Drawing.Point(88, 668);
            this.lblBreakShotTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreakShotTime.Name = "lblBreakShotTime";
            this.lblBreakShotTime.Size = new System.Drawing.Size(274, 33);
            this.lblBreakShotTime.TabIndex = 16;
            this.lblBreakShotTime.Text = "Break Shot Duration :";
            // 
            // bttnBreakShotEnd
            // 
            this.bttnBreakShotEnd.BackColor = System.Drawing.Color.White;
            this.bttnBreakShotEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnBreakShotEnd.FlatAppearance.BorderSize = 0;
            this.bttnBreakShotEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBreakShotEnd.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBreakShotEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnBreakShotEnd.Location = new System.Drawing.Point(421, 729);
            this.bttnBreakShotEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnBreakShotEnd.Name = "bttnBreakShotEnd";
            this.bttnBreakShotEnd.Size = new System.Drawing.Size(96, 49);
            this.bttnBreakShotEnd.TabIndex = 1;
            this.bttnBreakShotEnd.Tag = "";
            this.bttnBreakShotEnd.Text = "End";
            this.bttnBreakShotEnd.UseVisualStyleBackColor = false;
            this.bttnBreakShotEnd.Click += new System.EventHandler(this.bttnBreakShotEnd_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 12);
            this.WindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(226, 45);
            this.WindowsMediaPlayer.TabIndex = 7;
            this.WindowsMediaPlayer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1363, 923);
            this.Controls.Add(this.bttnBreakShotEnd);
            this.Controls.Add(this.breakShotDurationTime);
            this.Controls.Add(this.lblBreakShotTime);
            this.Controls.Add(this.prevRoundDurationTime);
            this.Controls.Add(this.lblPrevRoundDura);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.TotScoreDisp);
            this.Controls.Add(this.lblRoundName);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.TotalScore);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laghoriShotNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laghoriPickUpNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R1ViolationNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1RetryNum)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R2ViolationNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2RetryNum)).EndInit();
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
        private System.Windows.Forms.Button bttnRound;
        private System.Windows.Forms.Button bttnPause;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label TotalScore;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Button bttnExit;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Label TotScoreDisp;
        private System.Windows.Forms.Button bttnFinish;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblRoundName;
        private System.Windows.Forms.NumericUpDown laghoriShotNum;
        private System.Windows.Forms.Label LaghoriShot;
        private System.Windows.Forms.Label lblLagoriPick;
        private System.Windows.Forms.NumericUpDown laghoriPickUpNum;
        private System.Windows.Forms.Label lblR1Ctrl;
        private System.Windows.Forms.Label lblR2Ctrl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label prevRoundDurationTime;
        private System.Windows.Forms.Label lblPrevRoundDura;
        private System.Windows.Forms.Label breakShotDurationTime;
        private System.Windows.Forms.Label lblBreakShotTime;
        private System.Windows.Forms.NumericUpDown R1ViolationNum;
        private System.Windows.Forms.Label lblR1Violation;
        private System.Windows.Forms.NumericUpDown R1RetryNum;
        private System.Windows.Forms.Label lblR1Retry;
        private System.Windows.Forms.NumericUpDown R2ViolationNum;
        private System.Windows.Forms.Label lblR2Violation;
        private System.Windows.Forms.NumericUpDown R2RetryNum;
        private System.Windows.Forms.Label lblR2Retry;
        private System.Windows.Forms.Button bttnBreakShotEnd;
    }
}

