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

        static public int counter1 = 0, mode1Target = 60, mode2Target = 180, modeVal = 1,
                          countdownTarget = 5, displayCounter = 5, startFlag = 0;
        static public int PotILRedScr, PotIRRedScr, PotIIRedScr, PotIIIRedScr, 
                          PotILBlueScr, PotIRBlueScr, PotIIBlueScr, PotIIIBlueScr;
        static public int totalScore, RetryCountTR, RetryCountAR, ViolationCountTR, ViolationCountAR, twinningCount;
        static bool colourFlag = true, incrementFlag = true;

        bool mode = true;
        string teamName;

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
                timer1.Enabled = false;
                timer2.Enabled = false;
                player.URL = "end.wav";
                player.controls.play();
            }
        }
        private void bttnMode_Click(object sender, EventArgs e)
        {
            mode = !mode;
            if(mode == true)
            {
                mode1Target = 60; countdownTarget = 5;
                Countdown.Text = countdownTarget.ToString();
                modeVal = 1;
                lblModeNum.Text = modeVal.ToString();
            }
            else if(mode == false)
            {
                mode2Target = 180; countdownTarget = 5;
                Countdown.Text = countdownTarget.ToString();
                modeVal = 2;
                lblModeNum.Text = modeVal.ToString();
            }
        }
        private void bttnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            string fileName = "C:\\Windows\\SysWOW64\\config\\systemprofile\\{0}.xls";
            string fileNameInput;

            DateTime now = DateTime.Now;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            timer1.Enabled = false;
            timer2.Enabled = false;

            PotILRedScr = (int)PotILRedNum.Value;
            PotIRRedScr = (int)PotIRRedNum.Value;
            PotIIRedScr = (int)PotIIRedNum.Value;
            PotIIIRedScr = (int)PotIIIRedNum.Value;
            PotILBlueScr = (int)PotILBlueNum.Value;
            PotIRBlueScr = (int)PotIRBlueNum.Value;
            PotIIBlueScr = (int)PotIIBlueNum.Value;
            PotIIIBlueScr = (int)PotIIIBlueNum.Value;
            RetryCountTR = (int)RetryTRNum.Value;
            RetryCountAR = (int)RetryARNum.Value;
            ViolationCountTR = (int)ViolationTRNum.Value;
            ViolationCountAR = (int)ViolationARNum.Value;
            teamName = nameTeam.Text;

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Team:";
            xlWorkSheet.Cells[1, 2] = teamName;
            xlWorkSheet.Cells[1, 3] = "Date/Time:";
            xlWorkSheet.Cells[1, 4] = now;

            xlWorkSheet.Cells[3, 1] = "";
            xlWorkSheet.Cells[3, 2] = "RED";
            xlWorkSheet.Cells[3, 3] = "BLUE";
            xlWorkSheet.Cells[4, 1] = "Pot I L";
            xlWorkSheet.Cells[4, 2] = PotILRedScr;
            xlWorkSheet.Cells[4, 3] = PotILBlueScr;
            xlWorkSheet.Cells[5, 1] = "Pot I R";
            xlWorkSheet.Cells[5, 2] = PotIRRedScr;
            xlWorkSheet.Cells[5, 3] = PotIRBlueScr;
            xlWorkSheet.Cells[6, 1] = "Pot II";
            xlWorkSheet.Cells[6, 2] = PotIIRedScr;
            xlWorkSheet.Cells[6, 3] = PotIIBlueScr;
            xlWorkSheet.Cells[7, 1] = "Pot III";
            xlWorkSheet.Cells[7, 2] = PotIIIRedScr;
            xlWorkSheet.Cells[7, 3] = PotIIIBlueScr;

            xlWorkSheet.Cells[9, 1] = "";
            xlWorkSheet.Cells[9, 2] = "TR";
            xlWorkSheet.Cells[9, 3] = "AR";
            xlWorkSheet.Cells[10, 1] = "Violation";
            xlWorkSheet.Cells[10, 2] = ViolationCountTR;
            xlWorkSheet.Cells[10, 3] = ViolationCountAR;
            xlWorkSheet.Cells[11, 1] = "Retry";
            xlWorkSheet.Cells[11, 2] = RetryCountTR;
            xlWorkSheet.Cells[11, 3] = RetryCountAR;

            xlWorkSheet.Cells[13, 1] = "Time Remaining";
            xlWorkSheet.Cells[13, 2] = "Score";
            xlWorkSheet.Cells[14, 1] = Countdown.Text;
            xlWorkSheet.Cells[14, 2] = TotScoreDisp.Text;

            fileNameInput = txtFileName.Text.ToString();
            fileName = string.Format(fileName, fileNameInput);

            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("File at C:\\Windows\\SysWOW64\\config\\systemprofile\\");

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
            totalScore = 0;
            twinningCount = 0;

            PotILRedScr = (int)PotILRedNum.Value;
            PotIRRedScr = (int)PotIRRedNum.Value;
            PotIIRedScr = (int)PotIIRedNum.Value;
            PotIIIRedScr = (int)PotIIIRedNum.Value;
            PotILBlueScr = (int)PotILBlueNum.Value;
            PotIRBlueScr = (int)PotIRBlueNum.Value;
            PotIIBlueScr = (int)PotIIBlueNum.Value;
            PotIIIBlueScr = (int)PotIIIBlueNum.Value;
            RetryCountTR = (int)RetryTRNum.Value;
            RetryCountAR = (int)RetryARNum.Value;
            ViolationCountTR = (int)ViolationTRNum.Value;
            ViolationCountAR = (int)ViolationARNum.Value;


            totalScore = PotILRedScr + PotIRRedScr + PotIIRedScr + PotIIIRedScr +
                         PotILBlueScr + PotIRBlueScr + PotIIBlueScr + PotIIIBlueScr;

            if (PotILRedScr > 0 && PotILBlueScr > 0)
            {
                while(PotILRedScr != 0 && PotILBlueScr != 0)
                {
                    twinningCount += 1;
                    PotILRedScr -= 1;
                    PotILBlueScr -= 1;
                }
            }
            if (PotIRRedScr > 0 && PotIRBlueScr > 0)
            {
                while (PotIRRedScr != 0 && PotIRBlueScr != 0)
                {
                    twinningCount += 1;
                    PotIRRedScr -= 1;
                    PotIRBlueScr -= 1;
                }
            }
            if (PotIIRedScr > 0 && PotIIBlueScr > 0)
            {
                while (PotIIRedScr != 0 && PotIIBlueScr != 0)
                {
                    twinningCount += 1;
                    PotIIRedScr -= 1;
                    PotIIBlueScr -= 1;
                }
            }
            if (PotIIIRedScr > 0 && PotIIIBlueScr > 0)
            {
                while (PotIIIRedScr != 0 && PotIIIBlueScr != 0)
                {
                    twinningCount += 1;
                    PotIIIRedScr -= 1;
                    PotIIIBlueScr -= 1;
                }
            }

            totalScore += twinningCount * 6;

            TotScoreDisp.Text = totalScore.ToString();
        }
        #endregion

        #region Timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1 += 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mode == true)
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
                if(counter1 <= mode1Target && startFlag == 1)
                {
                    displayCounter = mode1Target - counter1;
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
            else if (mode == false)
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
                if (counter1 <= mode2Target && startFlag == 1)
                {
                    displayCounter = mode2Target - counter1;
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
            counter1 = 0; mode1Target = 60; mode2Target = 180; countdownTarget = 5; displayCounter = 5; startFlag = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            PotILRedNum.Value = 0;
            PotIRRedNum.Value = 0;
            PotIIRedNum.Value = 0;
            PotIIIRedNum.Value = 0;
            PotILBlueNum.Value = 0;
            PotIRBlueNum.Value = 0;
            PotIIBlueNum.Value = 0;
            PotIIIBlueNum.Value = 0;
            RetryARNum.Value = 0;
            ViolationARNum.Value = 0;
            twinningCount = 0;
            totalScore = 0;
            modeVal = 1;
            lblModeNum.Text = modeVal.ToString();
            Countdown.Text = displayCounter.ToString();
            TotScoreDisp.Text = totalScore.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    if(colourFlag == true && incrementFlag == true)
                        PotIIIRedNum.Value += 1;
                    if (colourFlag == false && incrementFlag == true)
                        PotIIIBlueNum.Value += 1;
                    if (colourFlag == true && incrementFlag == false && PotIIIRedNum.Value != 0)
                        PotIIIRedNum.Value -= 1;
                    if (colourFlag == false && incrementFlag == false && PotIIIBlueNum.Value != 0)
                        PotIIIBlueNum.Value -= 1;
                    return true;
                case Keys.Down:
                    if (colourFlag == true && incrementFlag == true)
                        PotIIRedNum.Value += 1;
                    if (colourFlag == false && incrementFlag == true)
                        PotIIBlueNum.Value += 1;
                    if (colourFlag == true && incrementFlag == false && PotIIRedNum.Value != 0)
                        PotIIRedNum.Value -= 1;
                    if (colourFlag == false && incrementFlag == false && PotIIBlueNum.Value != 0)
                        PotIIBlueNum.Value -= 1;
                    return true;
                case Keys.Left:
                    if (colourFlag == true && incrementFlag == true)
                        PotILRedNum.Value += 1;
                    if (colourFlag == false && incrementFlag == true)
                        PotILBlueNum.Value += 1;
                    if (colourFlag == true && incrementFlag == false && PotILRedNum.Value != 0)
                        PotILRedNum.Value -= 1;
                    if (colourFlag == false && incrementFlag == false && PotILBlueNum.Value != 0)
                        PotILBlueNum.Value -= 1;
                    return true;
                case Keys.Right:
                    if (colourFlag == true && incrementFlag == true)
                        PotIRRedNum.Value += 1;
                    if (colourFlag == false && incrementFlag == true)
                        PotIRBlueNum.Value += 1;
                    if (colourFlag == true && incrementFlag == false && PotIRRedNum.Value != 0)
                        PotIRRedNum.Value -= 1;
                    if (colourFlag == false && incrementFlag == false && PotIRBlueNum.Value != 0)
                        PotIRBlueNum.Value -= 1;
                    return true;

                case Keys.D7:
                    if (incrementFlag == true)
                        RetryARNum.Value += 1;
                    if (incrementFlag == false && RetryARNum.Value != 0)
                        RetryARNum.Value -= 1;
                    return true;
                case Keys.D8:
                    if (incrementFlag == true)
                        ViolationARNum.Value += 1;
                    if (incrementFlag == false && ViolationARNum.Value != 0)
                        ViolationARNum.Value -= 1;
                    return true;
                case Keys.D9:
                    if (incrementFlag == true)
                        RetryTRNum.Value += 1;
                    if (incrementFlag == false && RetryTRNum.Value != 0)
                        RetryTRNum.Value -= 1;
                    return true;
                case Keys.D0:
                    if (incrementFlag == true)
                        ViolationTRNum.Value += 1;
                    if (incrementFlag == false && ViolationTRNum.Value != 0)
                        ViolationTRNum.Value -= 1;
                    return true;

                case Keys.End:
                    colourFlag = !colourFlag;
                    if (colourFlag == true)
                        dispColourFlag.Text = "Red";
                    if (colourFlag == false)
                        dispColourFlag.Text = "Blue";
                    return true;
                case Keys.Delete:
                    incrementFlag = !incrementFlag;
                    if (incrementFlag == true)
                        dispIncrementFlag.Text = "+";
                    if (incrementFlag == false)
                        dispIncrementFlag.Text = "-";
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #endregion
    }
}
