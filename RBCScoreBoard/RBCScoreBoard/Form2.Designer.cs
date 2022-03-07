
namespace RBCScoreBoard
{
    partial class Form2
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
            this.TotScoreDisp = new System.Windows.Forms.Label();
            this.TotalScore = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.ScoreProgress = new System.Windows.Forms.Label();
            this.scoreBar = new System.Windows.Forms.ProgressBar();
            this.MainLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.laghoriShotDisp = new System.Windows.Forms.Label();
            this.lblLaghoriShot = new System.Windows.Forms.Label();
            this.statusDisp = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.laghoriPickUpDisp = new System.Windows.Forms.Label();
            this.lblLaghoriPickup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBreakShot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotScoreDisp
            // 
            this.TotScoreDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotScoreDisp.AutoSize = true;
            this.TotScoreDisp.Font = new System.Drawing.Font("Bahnschrift", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotScoreDisp.ForeColor = System.Drawing.Color.White;
            this.TotScoreDisp.Location = new System.Drawing.Point(792, 839);
            this.TotScoreDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotScoreDisp.Name = "TotScoreDisp";
            this.TotScoreDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotScoreDisp.Size = new System.Drawing.Size(316, 240);
            this.TotScoreDisp.TabIndex = 8;
            this.TotScoreDisp.Text = "00";
            this.TotScoreDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalScore
            // 
            this.TotalScore.AutoSize = true;
            this.TotalScore.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScore.ForeColor = System.Drawing.Color.White;
            this.TotalScore.Location = new System.Drawing.Point(840, 788);
            this.TotalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.Size = new System.Drawing.Size(244, 53);
            this.TotalScore.TabIndex = 6;
            this.TotalScore.Text = "Total Score";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.White;
            this.Timer.Location = new System.Drawing.Point(860, 293);
            this.Timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(121, 48);
            this.Timer.TabIndex = 7;
            this.Timer.Text = "Timer";
            // 
            // ScoreProgress
            // 
            this.ScoreProgress.AutoSize = true;
            this.ScoreProgress.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreProgress.ForeColor = System.Drawing.Color.White;
            this.ScoreProgress.Location = new System.Drawing.Point(147, 788);
            this.ScoreProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreProgress.Name = "ScoreProgress";
            this.ScoreProgress.Size = new System.Drawing.Size(301, 48);
            this.ScoreProgress.TabIndex = 11;
            this.ScoreProgress.Text = "Score Progress";
            // 
            // scoreBar
            // 
            this.scoreBar.BackColor = System.Drawing.Color.White;
            this.scoreBar.ForeColor = System.Drawing.Color.Lime;
            this.scoreBar.Location = new System.Drawing.Point(155, 871);
            this.scoreBar.Margin = new System.Windows.Forms.Padding(4);
            this.scoreBar.Maximum = 75;
            this.scoreBar.Name = "scoreBar";
            this.scoreBar.Size = new System.Drawing.Size(384, 49);
            this.scoreBar.Step = 75;
            this.scoreBar.TabIndex = 10;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(452, 27);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(889, 96);
            this.MainLabel.TabIndex = 12;
            this.MainLabel.Text = "UTM ROBOCON SCOREBOARD 2021";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Bahnschrift", 190F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinutes.Location = new System.Drawing.Point(485, 341);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinutes.Size = new System.Drawing.Size(920, 380);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "0 : 00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(785, 142);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(144, 36);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "date/time";
            // 
            // laghoriShotDisp
            // 
            this.laghoriShotDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laghoriShotDisp.AutoSize = true;
            this.laghoriShotDisp.Font = new System.Drawing.Font("Bahnschrift", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laghoriShotDisp.ForeColor = System.Drawing.Color.White;
            this.laghoriShotDisp.Location = new System.Drawing.Point(1603, 403);
            this.laghoriShotDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laghoriShotDisp.Name = "laghoriShotDisp";
            this.laghoriShotDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laghoriShotDisp.Size = new System.Drawing.Size(158, 120);
            this.laghoriShotDisp.TabIndex = 14;
            this.laghoriShotDisp.Text = "00";
            this.laghoriShotDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaghoriShot
            // 
            this.lblLaghoriShot.AutoSize = true;
            this.lblLaghoriShot.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaghoriShot.ForeColor = System.Drawing.Color.White;
            this.lblLaghoriShot.Location = new System.Drawing.Point(1544, 351);
            this.lblLaghoriShot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaghoriShot.Name = "lblLaghoriShot";
            this.lblLaghoriShot.Size = new System.Drawing.Size(276, 53);
            this.lblLaghoriShot.TabIndex = 13;
            this.lblLaghoriShot.Text = "Laghori Shot";
            // 
            // statusDisp
            // 
            this.statusDisp.AutoSize = true;
            this.statusDisp.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisp.ForeColor = System.Drawing.Color.White;
            this.statusDisp.Location = new System.Drawing.Point(223, 996);
            this.statusDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Size = new System.Drawing.Size(230, 48);
            this.statusDisp.TabIndex = 15;
            this.statusDisp.Text = "Preparation";
            this.statusDisp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(164, 962);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(99, 33);
            this.statusLbl.TabIndex = 16;
            this.statusLbl.Text = "Status:";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laghoriPickUpDisp
            // 
            this.laghoriPickUpDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laghoriPickUpDisp.AutoSize = true;
            this.laghoriPickUpDisp.Font = new System.Drawing.Font("Bahnschrift", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laghoriPickUpDisp.ForeColor = System.Drawing.Color.White;
            this.laghoriPickUpDisp.Location = new System.Drawing.Point(1608, 632);
            this.laghoriPickUpDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laghoriPickUpDisp.Name = "laghoriPickUpDisp";
            this.laghoriPickUpDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laghoriPickUpDisp.Size = new System.Drawing.Size(158, 120);
            this.laghoriPickUpDisp.TabIndex = 18;
            this.laghoriPickUpDisp.Text = "00";
            this.laghoriPickUpDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaghoriPickup
            // 
            this.lblLaghoriPickup.AutoSize = true;
            this.lblLaghoriPickup.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaghoriPickup.ForeColor = System.Drawing.Color.White;
            this.lblLaghoriPickup.Location = new System.Drawing.Point(1515, 580);
            this.lblLaghoriPickup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaghoriPickup.Name = "lblLaghoriPickup";
            this.lblLaghoriPickup.Size = new System.Drawing.Size(334, 53);
            this.lblLaghoriPickup.TabIndex = 17;
            this.lblLaghoriPickup.Text = "Laghori Pick Up";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1334, 932);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(158, 120);
            this.label1.TabIndex = 20;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakShot
            // 
            this.lblBreakShot.AutoSize = true;
            this.lblBreakShot.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakShot.ForeColor = System.Drawing.Color.White;
            this.lblBreakShot.Location = new System.Drawing.Point(1222, 867);
            this.lblBreakShot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreakShot.Name = "lblBreakShot";
            this.lblBreakShot.Size = new System.Drawing.Size(423, 53);
            this.lblBreakShot.TabIndex = 19;
            this.lblBreakShot.Text = "Break Shot Duration";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1920, 1102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBreakShot);
            this.Controls.Add(this.laghoriPickUpDisp);
            this.Controls.Add(this.lblLaghoriPickup);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.laghoriShotDisp);
            this.Controls.Add(this.lblLaghoriShot);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ScoreProgress);
            this.Controls.Add(this.scoreBar);
            this.Controls.Add(this.TotScoreDisp);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.TotalScore);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.Timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotScoreDisp;
        private System.Windows.Forms.Label TotalScore;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label ScoreProgress;
        private System.Windows.Forms.ProgressBar scoreBar;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label laghoriShotDisp;
        private System.Windows.Forms.Label lblLaghoriShot;
        private System.Windows.Forms.Label statusDisp;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label laghoriPickUpDisp;
        private System.Windows.Forms.Label lblLaghoriPickup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBreakShot;
    }
}