
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
            this.ArrowShotDisp = new System.Windows.Forms.Label();
            this.ArrowShot = new System.Windows.Forms.Label();
            this.statusDisp = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotScoreDisp
            // 
            this.TotScoreDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotScoreDisp.AutoSize = true;
            this.TotScoreDisp.Font = new System.Drawing.Font("Bahnschrift", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotScoreDisp.ForeColor = System.Drawing.Color.White;
            this.TotScoreDisp.Location = new System.Drawing.Point(594, 682);
            this.TotScoreDisp.Name = "TotScoreDisp";
            this.TotScoreDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotScoreDisp.Size = new System.Drawing.Size(253, 192);
            this.TotScoreDisp.TabIndex = 8;
            this.TotScoreDisp.Text = "00";
            this.TotScoreDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalScore
            // 
            this.TotalScore.AutoSize = true;
            this.TotalScore.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScore.ForeColor = System.Drawing.Color.White;
            this.TotalScore.Location = new System.Drawing.Point(630, 640);
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.Size = new System.Drawing.Size(193, 42);
            this.TotalScore.TabIndex = 6;
            this.TotalScore.Text = "Total Score";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.White;
            this.Timer.Location = new System.Drawing.Point(645, 238);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(98, 39);
            this.Timer.TabIndex = 7;
            this.Timer.Text = "Timer";
            // 
            // ScoreProgress
            // 
            this.ScoreProgress.AutoSize = true;
            this.ScoreProgress.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreProgress.ForeColor = System.Drawing.Color.White;
            this.ScoreProgress.Location = new System.Drawing.Point(110, 640);
            this.ScoreProgress.Name = "ScoreProgress";
            this.ScoreProgress.Size = new System.Drawing.Size(242, 39);
            this.ScoreProgress.TabIndex = 11;
            this.ScoreProgress.Text = "Score Progress";
            // 
            // scoreBar
            // 
            this.scoreBar.BackColor = System.Drawing.Color.White;
            this.scoreBar.ForeColor = System.Drawing.Color.Lime;
            this.scoreBar.Location = new System.Drawing.Point(116, 708);
            this.scoreBar.Maximum = 80;
            this.scoreBar.Name = "scoreBar";
            this.scoreBar.Size = new System.Drawing.Size(288, 40);
            this.scoreBar.Step = 80;
            this.scoreBar.TabIndex = 10;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(339, 22);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(718, 77);
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
            this.lblMinutes.Location = new System.Drawing.Point(364, 277);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinutes.Size = new System.Drawing.Size(737, 305);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "0 : 00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(589, 115);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(117, 29);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "date/time";
            // 
            // ArrowShotDisp
            // 
            this.ArrowShotDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrowShotDisp.AutoSize = true;
            this.ArrowShotDisp.Font = new System.Drawing.Font("Bahnschrift", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowShotDisp.ForeColor = System.Drawing.Color.White;
            this.ArrowShotDisp.Location = new System.Drawing.Point(1101, 731);
            this.ArrowShotDisp.Name = "ArrowShotDisp";
            this.ArrowShotDisp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ArrowShotDisp.Size = new System.Drawing.Size(126, 96);
            this.ArrowShotDisp.TabIndex = 14;
            this.ArrowShotDisp.Text = "00";
            this.ArrowShotDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArrowShot
            // 
            this.ArrowShot.AutoSize = true;
            this.ArrowShot.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowShot.ForeColor = System.Drawing.Color.White;
            this.ArrowShot.Location = new System.Drawing.Point(1064, 689);
            this.ArrowShot.Name = "ArrowShot";
            this.ArrowShot.Size = new System.Drawing.Size(197, 42);
            this.ArrowShot.TabIndex = 13;
            this.ArrowShot.Text = "Arrow Shot";
            // 
            // statusDisp
            // 
            this.statusDisp.AutoSize = true;
            this.statusDisp.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisp.ForeColor = System.Drawing.Color.White;
            this.statusDisp.Location = new System.Drawing.Point(167, 809);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Size = new System.Drawing.Size(185, 39);
            this.statusDisp.TabIndex = 15;
            this.statusDisp.Text = "Preparation";
            this.statusDisp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(123, 782);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(80, 27);
            this.statusLbl.TabIndex = 16;
            this.statusLbl.Text = "Status:";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.ArrowShotDisp);
            this.Controls.Add(this.ArrowShot);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ScoreProgress);
            this.Controls.Add(this.scoreBar);
            this.Controls.Add(this.TotScoreDisp);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.TotalScore);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.Timer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label ArrowShotDisp;
        private System.Windows.Forms.Label ArrowShot;
        private System.Windows.Forms.Label statusDisp;
        private System.Windows.Forms.Label statusLbl;
    }
}