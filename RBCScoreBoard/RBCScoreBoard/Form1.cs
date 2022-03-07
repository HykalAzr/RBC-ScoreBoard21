using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;
using Excel = Microsoft.Office.Interop.Excel;

namespace RBCScoreBoard
{
    public partial class Form1 : Form
    {
        #region Variables
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        static public int counter1 = 0, preparationTarget = 60, gameTarget = 120,
                          countdownTarget = 5, displayCounter = 60, startFlag = 0, endBttnFlag = 0;

        static public int totalScore, totalBallShot, totalLaghoriShot, totalLaghoriPickUp,
                          RetryCountR1, ViolationCountR1, RetryCountR2, ViolationCountR2;

        static public string statusDispText = "Preparation";

        int mode = 0;
        string teamName;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllips
            );
        #endregion

        public Form1()
        {
            InitializeComponent();
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Form2 secondForm = new Form2();
            int numofMon = Screen.AllScreens.Length;
            if(numofMon > 1)
                secondForm.Location = Screen.AllScreens[1].WorkingArea.Location;
            secondForm.Show();
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 50, 50));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 50, 50));
        }



        #region ButtonClickEvent

        private void bttnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void bttnFinish_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true || timer2.Enabled == true)
            {
                prevRoundDurationTime.Text = counter1.ToString();
                timer1.Enabled = false;
                timer2.Enabled = false;
                player.URL = "end.wav";
                player.controls.play();
                gameTarget = 120;
                endBttnFlag = 0;
            }
        }
        private void bttnMode_Click(object sender, EventArgs e)
        {
            if(mode < 2)
            {
                mode++;
            }
            else
            {
                mode = 0;
            }

            if(mode == 0)
            {
                endBttnFlag = 0;
                preparationTarget = 60;
                TotScoreDisp.Text = "00";
                prevRoundDurationTime.Text = "00";
                counter1 = 0;
                startFlag = 0;
                Countdown.Text = preparationTarget.ToString();
                displayCounter = preparationTarget;
                lblRoundName.Text = "Preparation";
                statusDispText = "Preparation";
            }
            else if(mode == 1)
            {
                endBttnFlag = 0;
                gameTarget = 120; countdownTarget = 5;
                TotScoreDisp.Text = "00";
                prevRoundDurationTime.Text = "00";
                counter1 = 0;
                startFlag = 0;
                Countdown.Text = countdownTarget.ToString();
                displayCounter = countdownTarget;
                lblRoundName.Text ="Seeker";
                statusDispText = "Seeker";
            }
            else if (mode == 2)
            {
                endBttnFlag = 0;
                gameTarget = 120; countdownTarget = 5;
                TotScoreDisp.Text = "00";
                prevRoundDurationTime.Text = "00";
                counter1 = 0;
                startFlag = 0;
                Countdown.Text = countdownTarget.ToString();
                displayCounter = countdownTarget;
                lblRoundName.Text ="Hitter";
                statusDispText = "Seeker";
            }
        }
        private void bttnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            string fileName = "C:\\Users\\Helio\\source\\repos\\RBCScoreBoard\\RBCScoreBoard\\Exported\\{0}.xls";
            string fileNameInput;

            DateTime now = DateTime.Now;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            timer1.Enabled = false;
            timer2.Enabled = false;


            teamName = now.ToString();

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Team:";
            xlWorkSheet.Cells[1, 2] = teamName;
            xlWorkSheet.Cells[1, 3] = "Date/Time:";
            xlWorkSheet.Cells[1, 4] = now;

            fileNameInput = "Test";

            if (fileNameInput != "")
            {
                fileName = string.Format(fileName, fileNameInput);

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                MessageBox.Show("File at C:\\Users\\Helio\\source\\repos\\RBCScoreBoard\\RBCScoreBoard\\Exported");
            }
            else
            {
                MessageBox.Show("Please put file name");
            }
            
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
        private void bttnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void bttnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Scroll_ValueChanged(object sender, EventArgs e)
        {

            if (totalLaghoriShot < 5)
                totalLaghoriShot = (int)laghoriShotNum.Value;
            else { 
                breakShotDurationTime.Text = counter1.ToString();
                endBttnFlag = 1;
            }

            totalLaghoriPickUp = (int)laghoriPickUpNum.Value;
            totalScore = totalLaghoriShot * 5 + totalLaghoriPickUp * 10;

            TotScoreDisp.Text = totalScore.ToString();
        }

        private void bttnBreakShotEnd_Click(object sender, EventArgs e)
        {
            if (endBttnFlag == 0)
            {
                breakShotDurationTime.Text = counter1.ToString();
                endBttnFlag = 1;
            }
        }

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1 += 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                if(counter1 <= preparationTarget && startFlag == 0)
                {
                    displayCounter = preparationTarget - counter1;
                    if (displayCounter == 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        startFlag = 0;
                        counter1 = 0;
                        player.URL = "end.wav";
                        player.controls.play();
                    }
                    Countdown.Text = displayCounter.ToString();
                }
            }
            else if (mode == 1 || mode == 2)
            {
                if (counter1 <= countdownTarget && startFlag == 0)
                {
                    displayCounter = countdownTarget - counter1;
                    if (displayCounter == 3)
                    {
                        player.URL = "count_3.wav";
                        player.controls.play();
                    }
                    if (displayCounter == 2)
                    {
                        player.URL = "count_2.wav";
                        player.controls.play();
                    }
                    if (displayCounter == 1)
                    {
                        player.URL = "count_1.wav";
                        player.controls.play();
                    }
                    if (displayCounter == 0)
                    {
                        player.URL = "go_beep.wav";
                        player.controls.play();
                    }
                    Countdown.Text = displayCounter.ToString();
                }
                if (displayCounter == 0)
                {
                    counter1 = 0;
                    startFlag = 1;
                }
                if (counter1 <= gameTarget && startFlag == 1)
                {
                    displayCounter = gameTarget - counter1;
                    if (endBttnFlag == 0 && counter1 == 30)
                    {
                        breakShotDurationTime.Text = counter1.ToString();
                        endBttnFlag = 1;
                    }
                    if (displayCounter < 6)
                    {
                        player.URL = "beep_5s.wav";
                        player.controls.play();
                    }
                    if (displayCounter == 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        startFlag = 0;
                        counter1 = 0;
                        player.URL = "end.wav";
                        player.controls.play();
                    }
                    Countdown.Text = displayCounter.ToString();
                }
            }
        }

        #endregion

        #region Other Objects
        private void Reset()
        {
            counter1 = 0; preparationTarget = 60; gameTarget = 120; 
            countdownTarget = 5; startFlag = 0; displayCounter = 60;
            breakShotDurationTime.Text = "00";
            prevRoundDurationTime.Text = "00";

            timer1.Enabled = false;
            timer2.Enabled = false;

            laghoriPickUpNum.Value = 0;
            laghoriShotNum.Value = 0;

            R1RetryNum.Value = 0;
            R1ViolationNum.Value = 0;
            R2RetryNum.Value = 0;
            R2ViolationNum.Value = 0;

            totalScore = 0;

            mode = 0;

            lblRoundName.Text = "Preparation";
            Countdown.Text = displayCounter.ToString();
            TotScoreDisp.Text = totalScore.ToString();
        }

       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.F1 | Keys.Up):
                    laghoriShotNum.Value += 1;
                    return true;
                case (Keys.F2 | Keys.Up):
                    R1RetryNum.Value += 1;
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #endregion
    }
}
