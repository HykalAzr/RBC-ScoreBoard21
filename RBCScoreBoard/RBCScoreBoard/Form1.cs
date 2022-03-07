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

        static public int counter1 = 0, mode1Target = 120, mode2Target = 180, modeVal = 1,
                          countdownTarget = 5, displayCounter = 60, startFlag = 0;
        static public int PotILRedScr, PotILRedScrMissed, PotIRRedScr, PotIRRedScrMissed, PotIIRedScr, PotIIRedScrMissed, PotIIRedScrII, PotIIRedScrIIMissed, PotIIIRedScr, PotIIIRedScrMissed,
                          PotILBlueScr, PotILBlueScrMissed, PotIRBlueScr, PotIRBlueScrMissed, PotIIBlueScr, PotIIBlueScrMissed, PotIIBlueScrII, PotIIBlueScrIIMissed, PotIIIBlueScr, PotIIIBlueScrMissed,
                          PotILRedScr2, PotILRedScrMissed2, PotIRRedScr2, PotIRRedScrMissed2, PotIIRedScr2, PotIIRedScrMissed2, PotIIRedScrII2, PotIIRedScrIIMissed2, PotIIIRedScr2, PotIIIRedScrMissed2,
                          PotILBlueScr2, PotILBlueScrMissed2, PotIRBlueScr2, PotIRBlueScrMissed2, PotIIBlueScr2, PotIIBlueScrMissed2, PotIIBlueScrII2, PotIIBlueScrIIMissed2, PotIIIBlueScr2, PotIIIBlueScrMissed2;

        static private bool isTR = false;
        static private bool isAR = false;
        static private bool isMiss = false;
        static private bool isDecre = false;
        static private bool isCmd = false;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q) isTR = false;
            if (e.KeyData == Keys.W) isAR = false;
            if (e.KeyData == Keys.Space) isMiss = false;
            if (e.KeyData == Keys.E) isDecre = false;
            if (e.KeyData == Keys.Escape) isCmd = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q) isTR = true;
            if (e.KeyData == Keys.W) isAR = true;
            if (e.KeyData == Keys.Space) isMiss = true;
            if (e.KeyData == Keys.E) isDecre = true;
            if (e.KeyData == Keys.Escape) isCmd = true;
        }

        static public int totalScore, totalScrILB, totalScrIRB, totalScrILR, totalScrIRR, totalScrIIB, totalScrIIR, totalScrIIIB, totalScrIIIR, totalScrIIB2, totalScrIIR2, 
                          totalArrowShot, RetryCountAR, ViolationCountAR, PickUpCountAR, ArrowDropCountAR, ArrowLoadCountAR, RetryCountTR, ViolationCountTR, ArrowDropCountTR, ArrowLoadCountTR, twinningCount;

        static public string statusDispText = "Preparation";

        int mode = 0;
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
                mode2Target = 180;
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
                mode1Target = 120;
                counter1 = 0;
                startFlag = 0;
                Countdown.Text = mode1Target.ToString();
                displayCounter = mode1Target;
                modeVal = 1;
                lblModeNum.Text = modeVal.ToString();
                statusDispText = "Idle";
            }
            else if(mode == 1)
            {
                mode2Target = 180;
                counter1 = 0;
                startFlag = 0;
                Countdown.Text = mode2Target.ToString();
                displayCounter = mode2Target;
                modeVal = 2;
                lblModeNum.Text = modeVal.ToString();
                statusDispText = "Idle";
            }
            else if (mode == 2)
            {
                mode2Target = 180; countdownTarget = 5;
                counter1 = 0;
                startFlag = 0;
                Countdown.Text = countdownTarget.ToString();
                displayCounter = countdownTarget;
                modeVal = 3;
                lblModeNum.Text = modeVal.ToString();
                statusDispText = "Game";
            }
        }
        private void bttnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            string fileName = "C:\\Users\\ASUS tuf Gamer\\Documents\\Visual Studio 2019\\Projects\\RBCScoreBoard\\Exported\\{0}.xls";
            string fileNameInput;

            DateTime now = DateTime.Now;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            timer1.Enabled = false;
            timer2.Enabled = false;

            if(checkTeam.Checked == true)
            {
                PotILRedScr = (int)PotILRedNum.Value;
                PotILRedScrMissed = (int)PotILRedNumMissed.Value;
                PotIRRedScr = (int)PotIRRedNum.Value;
                PotIRRedScrMissed = (int)PotIRRedNumMissed.Value;
                PotILBlueScr = (int)PotILBlueNum.Value;
                PotILBlueScrMissed = (int)PotILBlueNumMissed.Value;
                PotIRBlueScr = (int)PotIRBlueNum.Value;
                PotIRBlueScrMissed = (int)PotIRBlueNumMissed.Value;

                PotIIRedScr = (int)PotIIRedNum.Value;
                PotIIRedScrMissed = (int)PotIIRedNumMissed.Value;
                PotIIBlueScr = (int)PotIIBlueNum.Value;
                PotIIBlueScrMissed = (int)PotIIBlueNumMissed.Value;

                PotILRedScr2 = (int)PotILRedNum2.Value;
                PotILRedScrMissed2 = (int)PotILRedNumMissed2.Value;
                PotIRRedScr2 = (int)PotIRRedNum2.Value;
                PotIRRedScrMissed2 = (int)PotIRRedNumMissed2.Value;
                PotILBlueScr2 = (int)PotILBlueNum2.Value;
                PotILBlueScrMissed2 = (int)PotILBlueNumMissed2.Value;
                PotIRBlueScr2 = (int)PotIRBlueNum2.Value;
                PotIRBlueScrMissed2 = (int)PotIRBlueNumMissed2.Value;

                PotIIRedScr2 = (int)PotIIRedNum2.Value;
                PotIIRedScrMissed2 = (int)PotIIRedNumMissed2.Value;
                PotIIBlueScr2 = (int)PotIIBlueNum2.Value;
                PotIIBlueScrMissed2 = (int)PotIIBlueNumMissed2.Value;
            }
            else if (checkTeam.Checked == false)
            {
                PotILRedScr = (int)PotIRRedNum.Value;
                PotILRedScrMissed = (int)PotIRRedNumMissed.Value;
                PotIRRedScr = (int)PotILRedNum.Value;
                PotIRRedScrMissed = (int)PotILRedNumMissed.Value;
                PotILBlueScr = (int)PotIRBlueNum.Value;
                PotILBlueScrMissed = (int)PotIRBlueNumMissed.Value;
                PotIRBlueScr = (int)PotILBlueNum.Value;
                PotIRBlueScrMissed = (int)PotILBlueNumMissed.Value;

                PotIIRedScr = (int)PotIIRedNumII.Value;
                PotIIRedScrMissed = (int)PotIIRedNumIIMissed.Value;
                PotIIBlueScrII = (int)PotIIBlueNumII.Value;
                PotIIBlueScrIIMissed = (int)PotIIBlueNumIIMissed.Value;

                PotILRedScr2 = (int)PotIRRedNum2.Value;
                PotILRedScrMissed2 = (int)PotIRRedNumMissed2.Value;
                PotIRRedScr2 = (int)PotILRedNum2.Value;
                PotIRRedScrMissed2 = (int)PotILRedNumMissed2.Value;
                PotILBlueScr2 = (int)PotIRBlueNum2.Value;
                PotILBlueScrMissed2 = (int)PotIRBlueNumMissed2.Value;
                PotIRBlueScr2 = (int)PotILBlueNum2.Value;
                PotIRBlueScrMissed2 = (int)PotILBlueNumMissed2.Value;

                PotIIRedScr2 = (int)PotIIRedNumII2.Value;
                PotIIRedScrMissed2 = (int)PotIIRedNumIIMissed2.Value;
                PotIIBlueScrII2 = (int)PotIIBlueNumII2.Value;
                PotIIBlueScrIIMissed2 = (int)PotIIBlueNumIIMissed2.Value;
            }

            PotIIIRedScr = (int)PotIIIRedNum.Value;
            PotIIIRedScrMissed = (int)PotIIIRedNumMissed.Value;
            PotIIIBlueScr = (int)PotIIIBlueNum.Value;
            PotIIIBlueScrMissed = (int)PotIIIBlueNumMissed.Value;

            PotIIIRedScr2 = (int)PotIIIRedNum2.Value;
            PotIIIRedScrMissed2 = (int)PotIIIRedNumMissed2.Value;
            PotIIIBlueScr2 = (int)PotIIIBlueNum2.Value;
            PotIIIBlueScrMissed2 = (int)PotIIIBlueNumMissed2.Value;

            RetryCountTR = (int)RetryTRNum.Value;
            ViolationCountTR = (int)ViolationTRNum.Value;
            ArrowDropCountTR = (int)ArrowDropTRNum.Value;
            ArrowLoadCountTR = (int)ArrowLoadTRNum.Value;

            RetryCountAR = (int)RetryARNum.Value;
            ViolationCountAR = (int)ViolationARNum.Value;
            PickUpCountAR = (int)PickUpARNum.Value;
            ArrowDropCountAR = (int)ArrowDropARNum.Value;
            ArrowLoadCountAR = (int)ArrowLoadARNum.Value;

            teamName = txtFileName.Text.ToString();

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
            xlWorkSheet.Cells[3, 2] = "SUCCESS TOT";
            xlWorkSheet.Cells[3, 3] = "MISSED TOT";
            xlWorkSheet.Cells[4, 1] = "I L BLUE";
            xlWorkSheet.Cells[4, 2] = PotILBlueScr + PotILBlueScr2;
            xlWorkSheet.Cells[4, 3] = PotILBlueScrMissed + PotILBlueScrMissed2;
            xlWorkSheet.Cells[5, 1] = "I R BLUE";
            xlWorkSheet.Cells[5, 2] = PotIRBlueScr + PotIRBlueScr2;
            xlWorkSheet.Cells[5, 3] = PotIRBlueScrMissed + PotIRBlueScrMissed2;
            xlWorkSheet.Cells[6, 1] = "II BLUE";
            xlWorkSheet.Cells[6, 2] = PotIIBlueScr + PotIIBlueScr2;
            xlWorkSheet.Cells[6, 3] = PotIIBlueScrMissed + PotIIBlueScrMissed2;
            xlWorkSheet.Cells[7, 1] = "III BLUE";
            xlWorkSheet.Cells[7, 2] = PotIIIBlueScr + PotIIIBlueScr2;
            xlWorkSheet.Cells[7, 3] = PotIIIBlueScrMissed + PotIIIBlueScrMissed2;
            xlWorkSheet.Cells[8, 1] = "I L RED";
            xlWorkSheet.Cells[8, 2] = PotILRedScr + PotILRedScr2;
            xlWorkSheet.Cells[8, 3] = PotILRedScrMissed + PotILRedScrMissed2;
            xlWorkSheet.Cells[9, 1] = "I R RED";
            xlWorkSheet.Cells[9, 2] = PotIRRedScr + PotIRRedScr2;
            xlWorkSheet.Cells[9, 3] = PotIRRedScrMissed + PotIRRedScrMissed2;
            xlWorkSheet.Cells[10, 1] = "II RED";
            xlWorkSheet.Cells[10, 2] = PotIIRedScr + PotIIRedScr2;
            xlWorkSheet.Cells[10, 3] = PotIIRedScrMissed + PotIIRedScrMissed2;
            xlWorkSheet.Cells[11, 1] = "III RED";
            xlWorkSheet.Cells[11, 2] = PotIIIRedScr + PotIIIRedScr2;
            xlWorkSheet.Cells[11, 3] = PotIIIRedScrMissed + PotIIIRedScrMissed2;

            xlWorkSheet.Cells[3, 5] = "";
            xlWorkSheet.Cells[3, 6] = "SUCCESS TR";
            xlWorkSheet.Cells[3, 7] = "MISSED TR";
            xlWorkSheet.Cells[4, 5] = "I L BLUE";
            xlWorkSheet.Cells[4, 6] = PotILBlueScr2;
            xlWorkSheet.Cells[4, 7] = PotILBlueScrMissed2;
            xlWorkSheet.Cells[5, 5] = "I R BLUE";
            xlWorkSheet.Cells[5, 6] = PotIRBlueScr2;
            xlWorkSheet.Cells[5, 7] = PotIRBlueScrMissed2;
            xlWorkSheet.Cells[6, 5] = "II BLUE";
            xlWorkSheet.Cells[6, 6] = PotIIBlueScr2;
            xlWorkSheet.Cells[6, 7] = PotIIBlueScrMissed2;
            xlWorkSheet.Cells[7, 5] = "III BLUE";
            xlWorkSheet.Cells[7, 6] = PotIIIBlueScr2;
            xlWorkSheet.Cells[7, 7] = PotIIIBlueScrMissed2;
            xlWorkSheet.Cells[8, 5] = "I L RED";
            xlWorkSheet.Cells[8, 6] = PotILRedScr2;
            xlWorkSheet.Cells[8, 7] = PotILRedScrMissed2;
            xlWorkSheet.Cells[9, 5] = "I R RED";
            xlWorkSheet.Cells[9, 6] = PotIRRedScr2;
            xlWorkSheet.Cells[9, 7] = PotIRRedScrMissed2;
            xlWorkSheet.Cells[10, 5] = "II RED";
            xlWorkSheet.Cells[10, 6] = PotIIRedScr2;
            xlWorkSheet.Cells[10, 7] = PotIIRedScrMissed2;
            xlWorkSheet.Cells[11, 5] = "III RED";
            xlWorkSheet.Cells[11, 6] = PotIIIRedScr2;
            xlWorkSheet.Cells[11, 7] = PotIIIRedScrMissed2;

            xlWorkSheet.Cells[3, 9] = "";
            xlWorkSheet.Cells[3, 10] = "SUCCESS AR";
            xlWorkSheet.Cells[3, 11] = "MISSED AR";
            xlWorkSheet.Cells[4, 9] = "I L BLUE";
            xlWorkSheet.Cells[4, 10] = PotILBlueScr;
            xlWorkSheet.Cells[4, 11] = PotILBlueScrMissed;
            xlWorkSheet.Cells[5, 9] = "I R BLUE";
            xlWorkSheet.Cells[5, 10] = PotIRBlueScr;
            xlWorkSheet.Cells[5, 11] = PotIRBlueScrMissed;
            xlWorkSheet.Cells[6, 9] = "II BLUE";
            xlWorkSheet.Cells[6, 10] = PotIIBlueScr;
            xlWorkSheet.Cells[6, 11] = PotIIBlueScrMissed;
            xlWorkSheet.Cells[7, 9] = "III BLUE";
            xlWorkSheet.Cells[7, 10] = PotIIIBlueScr;
            xlWorkSheet.Cells[7, 11] = PotIIIBlueScrMissed;
            xlWorkSheet.Cells[8, 9] = "I L RED";
            xlWorkSheet.Cells[8, 10] = PotILRedScr;
            xlWorkSheet.Cells[8, 11] = PotILRedScrMissed;
            xlWorkSheet.Cells[9, 9] = "I R RED";
            xlWorkSheet.Cells[9, 10] = PotIRRedScr;
            xlWorkSheet.Cells[9, 11] = PotIRRedScrMissed;
            xlWorkSheet.Cells[10, 9] = "II RED";
            xlWorkSheet.Cells[10, 10] = PotIIRedScr;
            xlWorkSheet.Cells[10, 11] = PotIIRedScrMissed;
            xlWorkSheet.Cells[11, 9] = "III RED";
            xlWorkSheet.Cells[11, 10] = PotIIIRedScr;
            xlWorkSheet.Cells[11, 11] = PotIIIRedScrMissed;

            xlWorkSheet.Cells[13, 1] = "";
            xlWorkSheet.Cells[13, 2] = "TOTAL";
            xlWorkSheet.Cells[13, 3] = "TR";
            xlWorkSheet.Cells[13, 4] = "AR";
            xlWorkSheet.Cells[14, 1] = "Arrow Load";
            xlWorkSheet.Cells[14, 2] = ArrowLoadCountTR + ArrowLoadCountAR;
            xlWorkSheet.Cells[14, 3] = ArrowLoadCountTR;
            xlWorkSheet.Cells[14, 4] = ArrowLoadCountAR;
            xlWorkSheet.Cells[15, 1] = "Arrow Drop";
            xlWorkSheet.Cells[15, 2] = ArrowDropCountTR + ArrowDropCountAR;
            xlWorkSheet.Cells[15, 3] = ArrowDropCountTR;
            xlWorkSheet.Cells[15, 4] = ArrowDropCountAR;
            xlWorkSheet.Cells[16, 1] = "Retry";
            xlWorkSheet.Cells[16, 2] = RetryCountTR + RetryCountAR;
            xlWorkSheet.Cells[16, 3] = RetryCountTR;
            xlWorkSheet.Cells[16, 4] = RetryCountAR;
            xlWorkSheet.Cells[17, 1] = "Violation";
            xlWorkSheet.Cells[17, 2] = ViolationCountTR + ViolationCountAR;
            xlWorkSheet.Cells[17, 3] = ViolationCountTR;
            xlWorkSheet.Cells[17, 4] = ViolationCountAR;
            xlWorkSheet.Cells[18, 1] = "Pick Up";
            xlWorkSheet.Cells[18, 4] = PickUpCountAR;

            xlWorkSheet.Cells[19, 1] = "Time Remaining";
            xlWorkSheet.Cells[19, 2] = Countdown.Text;
            xlWorkSheet.Cells[20, 1] = "Score";
            xlWorkSheet.Cells[20, 2] = TotScoreDisp.Text;

            fileNameInput = txtFileName.Text.ToString();

            if (fileNameInput != "")
            {
                fileName = string.Format(fileName, fileNameInput);

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                MessageBox.Show("File at C:\\Users\\ASUS tuf Gamer\\Documents\\Visual Studio 2019\\Projects\\RBCScoreBoard\\Exported");
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
            totalScore = 0;
            twinningCount = 0;

            if (checkTeam.Checked == true)
            {
                PotILRedScr = (int)PotILRedNum.Value;
                PotILRedScrMissed = (int)PotILRedNumMissed.Value;
                PotIRRedScr = (int)PotIRRedNum.Value;
                PotIRRedScrMissed = (int)PotIRRedNumMissed.Value;
                PotILBlueScr = (int)PotILBlueNum.Value;
                PotILBlueScrMissed = (int)PotILBlueNumMissed.Value;
                PotIRBlueScr = (int)PotIRBlueNum.Value;
                PotIRBlueScrMissed = (int)PotIRBlueNumMissed.Value;

                PotIIRedScr = (int)PotIIRedNum.Value;
                PotIIRedScrMissed = (int)PotIIRedNumMissed.Value;
                PotIIBlueScr = (int)PotIIBlueNum.Value;
                PotIIBlueScrMissed = (int)PotIIBlueNumMissed.Value;

                PotILRedScr2 = (int)PotILRedNum2.Value;
                PotILRedScrMissed2 = (int)PotILRedNumMissed2.Value;
                PotIRRedScr2 = (int)PotIRRedNum2.Value;
                PotIRRedScrMissed2 = (int)PotIRRedNumMissed2.Value;
                PotILBlueScr2 = (int)PotILBlueNum2.Value;
                PotILBlueScrMissed2 = (int)PotILBlueNumMissed2.Value;
                PotIRBlueScr2 = (int)PotIRBlueNum2.Value;
                PotIRBlueScrMissed2 = (int)PotIRBlueNumMissed2.Value;

                PotIIRedScr2 = (int)PotIIRedNum2.Value;
                PotIIRedScrMissed2 = (int)PotIIRedNumMissed2.Value;
                PotIIBlueScr2 = (int)PotIIBlueNum2.Value;
                PotIIBlueScrMissed2 = (int)PotIIBlueNumMissed2.Value;
            }
            else if (checkTeam.Checked == false)
            {
                PotILRedScr = (int)PotIRRedNum.Value;
                PotILRedScrMissed = (int)PotIRRedNumMissed.Value;
                PotIRRedScr = (int)PotILRedNum.Value;
                PotIRRedScrMissed = (int)PotILRedNumMissed.Value;
                PotILBlueScr = (int)PotIRBlueNum.Value;
                PotILBlueScrMissed = (int)PotIRBlueNumMissed.Value;
                PotIRBlueScr = (int)PotILBlueNum.Value;
                PotIRBlueScrMissed = (int)PotILBlueNumMissed.Value;

                PotIIRedScr = (int)PotIIRedNumII.Value;
                PotIIRedScrMissed = (int)PotIIRedNumIIMissed.Value;
                PotIIBlueScr = (int)PotIIBlueNumII.Value;
                PotIIBlueScrMissed = (int)PotIIBlueNumIIMissed.Value;

                PotILRedScr2 = (int)PotIRRedNum2.Value;
                PotILRedScrMissed2 = (int)PotIRRedNumMissed2.Value;
                PotIRRedScr2 = (int)PotILRedNum2.Value;
                PotIRRedScrMissed2 = (int)PotILRedNumMissed2.Value;
                PotILBlueScr2 = (int)PotIRBlueNum2.Value;
                PotILBlueScrMissed2 = (int)PotIRBlueNumMissed2.Value;
                PotIRBlueScr2 = (int)PotILBlueNum2.Value;
                PotIRBlueScrMissed2 = (int)PotILBlueNumMissed2.Value;

                PotIIRedScr2 = (int)PotIIRedNumII2.Value;
                PotIIRedScrMissed2 = (int)PotIIRedNumIIMissed2.Value;
                PotIIBlueScr2 = (int)PotIIBlueNumII2.Value;
                PotIIBlueScrMissed2 = (int)PotIIBlueNumIIMissed2.Value;
            }

            PotIIIRedScr = (int)PotIIIRedNum.Value;
            PotIIIRedScrMissed = (int)PotIIIRedNumMissed.Value;
            PotIIIBlueScr = (int)PotIIIBlueNum.Value;
            PotIIIBlueScrMissed = (int)PotIIIBlueNumMissed.Value;

            PotIIIRedScr2 = (int)PotIIIRedNum2.Value;
            PotIIIRedScrMissed2 = (int)PotIIIRedNumMissed2.Value;
            PotIIIBlueScr2 = (int)PotIIIBlueNum2.Value;
            PotIIIBlueScrMissed2 = (int)PotIIIBlueNumMissed2.Value;

            RetryCountTR = (int)RetryTRNum.Value;
            RetryCountAR = (int)RetryARNum.Value;
            ViolationCountTR = (int)ViolationTRNum.Value;
            ViolationCountAR = (int)ViolationARNum.Value;

            totalScrILB = PotILBlueScr + PotILBlueScr2;
            totalScrIRB = PotIRBlueScr + PotIRBlueScr2;
            totalScrILR = PotILRedScr + PotILRedScr2;
            totalScrIRR = PotIRRedScr + PotIRRedScr2;
            totalScrIIB = PotIIBlueScr + PotIIBlueScr2;
            totalScrIIR = PotIIRedScr + PotIIRedScr2;
            totalScrIIIB = PotIIIBlueScr + PotIIIBlueScr2;
            totalScrIIIR = PotIIIRedScr + PotIIIRedScr2;

            totalScore = totalScrILB + totalScrIRB + totalScrILR + totalScrIRR + totalScrIIB + totalScrIIR + totalScrIIIB + totalScrIIIR;

            totalArrowShot = PotILRedScr + PotILRedScrMissed + PotIRRedScr + PotIRRedScrMissed + PotIIRedScr + PotIIRedScrMissed + PotIIIRedScr + PotIIIRedScrMissed +
                             PotILBlueScr + PotILBlueScrMissed + PotIRBlueScr + PotIRBlueScrMissed + PotIIBlueScr + PotIIBlueScrMissed + PotIIIBlueScr + PotIIIBlueScrMissed +
                             PotILRedScr2 + PotILRedScrMissed2 + PotIRRedScr2 + PotIRRedScrMissed2 + PotIIRedScr2 + PotIIRedScrMissed2 + PotIIIRedScr2 + PotIIIRedScrMissed2 +
                             PotILBlueScr2 + PotILBlueScrMissed2 + PotIRBlueScr2 + PotIRBlueScrMissed2 + PotIIBlueScr2 + PotIIBlueScrMissed2 + PotIIIBlueScr2 + PotIIIBlueScrMissed2;

            if (totalScrILR > 0 && totalScrILB > 0)
            {
                while(totalScrILR != 0 && totalScrILB != 0)
                {
                    twinningCount += 1;
                    totalScrILR -= 1;
                    totalScrILB -= 1;
                }
            }
            if (totalScrIRR > 0 && totalScrIRB > 0)
            {
                while (totalScrIRR != 0 && totalScrIRB != 0)
                {
                    twinningCount += 1;
                    totalScrIRR -= 1;
                    totalScrIRB -= 1;
                }
            }
            if (totalScrIIR > 0 && totalScrIIB > 0)
            {
                while (totalScrIIR != 0 && totalScrIIB != 0)
                {
                    twinningCount += 1;
                    totalScrIIR -= 1;
                    totalScrIIB -= 1;
                }
            }
            if (totalScrIIIR > 0 && totalScrIIIB > 0)
            {
                while (totalScrIIIR != 0 && totalScrIIIB != 0)
                {
                    twinningCount += 1;
                    totalScrIIIR -= 1;
                    totalScrIIIB -= 1;
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
            if (mode == 0)
            {
                if(counter1 <= mode1Target && startFlag == 0)
                {
                    displayCounter = mode1Target - counter1;
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
            else if (mode == 1)
            {
                if (counter1 <= mode2Target && startFlag == 0)
                {
                    displayCounter = mode2Target - counter1;
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
            else if (mode == 2)
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
            counter1 = 0; mode1Target = 120; mode2Target = 180; countdownTarget = 5; startFlag = 0; displayCounter = 60;
            timer1.Enabled = false;
            timer2.Enabled = false;

            PotILRedNum.Value = 0;
            PotILRedNumMissed.Value = 0;
            PotIRRedNum.Value = 0;
            PotIRRedNumMissed.Value = 0;
            PotIIRedNum.Value = 0;
            PotIIRedNumMissed.Value = 0;
            PotIIIRedNum.Value = 0;
            PotIIIRedNumMissed.Value = 0;
            PotILBlueNum.Value = 0;
            PotILBlueNumMissed.Value = 0;
            PotIRBlueNum.Value = 0;
            PotIRBlueNumMissed.Value = 0;
            PotIIBlueNum.Value = 0;
            PotIIBlueNumMissed.Value = 0;
            PotIIIBlueNum.Value = 0;
            PotIIIBlueNumMissed.Value = 0;

            PotILRedNum2.Value = 0;
            PotILRedNumMissed2.Value = 0;
            PotIRRedNum2.Value = 0;
            PotIRRedNumMissed2.Value = 0;
            PotIIRedNum2.Value = 0;
            PotIIRedNumMissed2.Value = 0;
            PotIIIRedNum2.Value = 0;
            PotIIIRedNumMissed2.Value = 0;
            PotILBlueNum2.Value = 0;
            PotILBlueNumMissed2.Value = 0;
            PotIRBlueNum2.Value = 0;
            PotIRBlueNumMissed2.Value = 0;
            PotIIBlueNum2.Value = 0;
            PotIIBlueNumMissed2.Value = 0;
            PotIIIBlueNum2.Value = 0;
            PotIIIBlueNumMissed2.Value = 0;

            PotIIRedNumII.Value = 0;
            PotIIRedNumIIMissed.Value = 0;
            PotIIBlueNumII.Value = 0;
            PotIIBlueNumIIMissed.Value = 0;
            PotIIRedNumII2.Value = 0;
            PotIIRedNumIIMissed2.Value = 0;
            PotIIBlueNumII2.Value = 0;
            PotIIBlueNumIIMissed2.Value = 0;

            totalScrILB = 0;
            totalScrIRB = 0;
            totalScrILR = 0;
            totalScrIRR = 0;
            totalScrIIB = 0;
            totalScrIIR = 0;
            totalScrIIIB = 0;
            totalScrIIIR = 0;

            totalArrowShot = 0;

            RetryARNum.Value = 0;
            ViolationARNum.Value = 0;
            PickUpARNum.Value = 0;
            ArrowDropARNum.Value = 0;
            ArrowLoadARNum.Value = 0;

            RetryTRNum.Value = 0;
            ViolationTRNum.Value = 0;
            ArrowDropTRNum.Value = 0;
            ArrowLoadTRNum.Value = 0;

            twinningCount = 0;
            totalScore = 0;

            mode = 0;
            modeVal = 1;

            lblModeNum.Text = modeVal.ToString();
            Countdown.Text = displayCounter.ToString();
            TotScoreDisp.Text = totalScore.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys Keys_H = Keys.I;
            Keys Keys_Y = Keys.K;
            Keys Keys_U = Keys.J;
            Keys Keys_J = Keys.U;
            Keys Keys_I = Keys.H;
            Keys Keys_K = Keys.Y;
            Keys Keys_M = Keys.D9;
            Keys Keys_Oemcomma = Keys.D8;
            Keys Keys_D8 = Keys.Oemcomma;
            Keys Keys_D9 = Keys.M;
            Keys Keys_L = Keys.L;
            Keys Keys_P = Keys.P;
            Keys Keys_D = Keys.D;
            Keys Keys_V = Keys.V;
            Keys Keys_R = Keys.R;
            Keys Keys_Enter = Keys.Enter;
            Keys Keys_Mode = Keys.M;
            Keys Keys_Start = Keys.Enter;
            Keys Keys_Reset = Keys.R;
            if (keyData == Keys_Enter)
            {
                bttnFinish.PerformClick();
            }
            if (isCmd)
            {
                if (keyData == Keys_Start)
                {
                    bttnStart.PerformClick();
                } else if (keyData == Keys_Mode)
                {
                    bttnMode.PerformClick();
                } else if (keyData == Keys_Reset)
                {
                    bttnReset.PerformClick();
                }
            }
            try
            {
                if (!isDecre)
                {
                    if (keyData == Keys_H)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIRedNumIIMissed2.Value++; } else { PotIIRedNumII2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIIRedNumIIMissed.Value++; } else { PotIIRedNumII.Value++; } }
                    }
                    if (keyData == Keys_Y)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIBlueNumIIMissed2.Value++; } else { PotIIBlueNumII2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIIBlueNumIIMissed.Value++; } else { PotIIBlueNumII.Value++; } }
                    }
                    if (keyData == Keys_J)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIIRedNumMissed2.Value++; } else { PotIIIRedNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIIIRedNumMissed.Value++; } else { PotIIIRedNum.Value++; } }
                    }
                    if (keyData == Keys_U)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIIBlueNumMissed2.Value++; } else { PotIIIBlueNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIIIBlueNumMissed.Value++; } else { PotIIIBlueNum.Value++; } }
                    }
                    if (keyData == Keys_K)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIBlueNumMissed2.Value++; } else { PotIIBlueNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIIBlueNumMissed.Value++; } else { PotIIBlueNum.Value++; } }
                    }
                    if (keyData == Keys_I)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIRedNumMissed2.Value++; } else { PotIIRedNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIIRedNumMissed.Value++; } else { PotIIRedNum.Value++; } }
                    }
                    if (keyData == Keys_D9)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIRBlueNumMissed2.Value++; } else { PotIRBlueNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIRBlueNumMissed.Value++; } else { PotIRBlueNum.Value++; } }
                    }
                    if (keyData == Keys_D8)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIRRedNumMissed2.Value++; } else { PotIRRedNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotIRRedNumMissed.Value++; } else { PotIRRedNum.Value++; } }
                    }
                    if (keyData == Keys_Oemcomma)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotILBlueNumMissed2.Value++; } else { PotILBlueNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotILBlueNumMissed.Value++; } else { PotILBlueNum.Value++; } }
                    }
                    if (keyData == Keys_M)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotILRedNumMissed2.Value++; } else { PotILRedNum2.Value++; }
                        }
                        else if (isAR) { if (isMiss) { PotILRedNumMissed.Value++; } else { PotILRedNum.Value++; } }
                    }

                    if (keyData == Keys_V) // Violation
                    {
                        if (isTR)
                        {
                            ViolationTRNum.Value++;
                        }
                        else if (isAR) { ViolationARNum.Value++; }
                    }
                    if (keyData == Keys_R) // Retry
                    {
                        if (isTR)
                        {
                            RetryTRNum.Value++;
                        }
                        else if (isAR) { RetryARNum.Value++; }
                    }
                    if (keyData == Keys_D) // ArrowDrop
                    {
                        if (isTR)
                        {
                            ArrowDropTRNum.Value++;
                        }
                        else if (isAR) { ArrowDropARNum.Value++; }
                    }
                    if (keyData == Keys_L) // ArrowLoad
                    {
                        if (isTR)
                        {
                            ArrowLoadTRNum.Value++;
                        }
                        else if (isAR) { ArrowLoadARNum.Value++; }
                    }
                    if (keyData == Keys_P) // PickUp
                    {
                        if (isAR) { PickUpARNum.Value++; }
                    }
                }
                else
                {
                    if (keyData == Keys_H)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIRedNumIIMissed2.Value--; } else { PotIIRedNumII2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIIRedNumIIMissed.Value--; } else { PotIIRedNumII.Value--; } }
                    }
                    if (keyData == Keys_Y)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIBlueNumIIMissed2.Value--; } else { PotIIBlueNumII2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIIBlueNumIIMissed.Value--; } else { PotIIBlueNumII.Value--; } }
                    }
                    if (keyData == Keys_J)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIIRedNumMissed2.Value--; } else { PotIIIRedNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIIIRedNumMissed.Value--; } else { PotIIIRedNum.Value--; } }
                    }
                    if (keyData == Keys_U)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIIBlueNumMissed2.Value--; } else { PotIIIBlueNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIIIBlueNumMissed.Value--; } else { PotIIIBlueNum.Value--; } }
                    }
                    if (keyData == Keys_K)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIBlueNumMissed2.Value--; } else { PotIIBlueNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIIBlueNumMissed.Value--; } else { PotIIBlueNum.Value--; } }
                    }
                    if (keyData == Keys_I)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIIRedNumMissed2.Value--; } else { PotIIRedNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIIRedNumMissed.Value--; } else { PotIIRedNum.Value--; } }
                    }
                    if (keyData == Keys_D9)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIRBlueNumMissed2.Value--; } else { PotIRBlueNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIRBlueNumMissed.Value--; } else { PotIRBlueNum.Value--; } }
                    }
                    if (keyData == Keys_D8)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotIRRedNumMissed2.Value--; } else { PotIRRedNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotIRRedNumMissed.Value--; } else { PotIRRedNum.Value--; } }
                    }
                    if (keyData == Keys_Oemcomma)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotILBlueNumMissed2.Value--; } else { PotILBlueNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotILBlueNumMissed.Value--; } else { PotILBlueNum.Value--; } }
                    }
                    if (keyData == Keys_M)
                    {
                        if (isTR)
                        {
                            if (isMiss) { PotILRedNumMissed2.Value--; } else { PotILRedNum2.Value--; }
                        }
                        else if (isAR) { if (isMiss) { PotILRedNumMissed.Value--; } else { PotILRedNum.Value--; } }
                    }

                    if (keyData == Keys_V) // Violation
                    {
                        if (isTR)
                        {
                            ViolationTRNum.Value--;
                        }
                        else if (isAR) { ViolationARNum.Value--; }
                    }
                    if (keyData == Keys_R) // Retry
                    {
                        if (isTR)
                        {
                            RetryTRNum.Value--;
                        }
                        else if (isAR) { RetryARNum.Value--; }
                    }
                    if (keyData == Keys_D) // ArrowDrop
                    {
                        if (isTR)
                        {
                            ArrowDropTRNum.Value--;
                        }
                        else if (isAR) { ArrowDropARNum.Value--; }
                    }
                    if (keyData == Keys_L) // ArrowLoad
                    {
                        if (isTR)
                        {
                            ArrowLoadTRNum.Value--;
                        }
                        else if (isAR) { ArrowLoadARNum.Value--; }
                    }
                    if (keyData == Keys_P) // PickUp
                    {
                        if (isAR) { PickUpARNum.Value--; }
                    }
                }
            } catch (Exception e)
            {

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /*protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
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

                case Keys.D8:
                    if (incrementFlag == true)
                        RetryARNum.Value += 1;
                    if (incrementFlag == false && RetryARNum.Value != 0)
                        RetryARNum.Value -= 1;
                    return true;
                case Keys.D9:
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
                        dispTeam.Text = "Red";
                    if (colourFlag == false)
                        dispTeam.Text = "Blue";
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }*/
        #endregion
    }
}
