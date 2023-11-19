using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Physics_Website
{
    public partial class PhysicsCalculator : Form
    {
        Random rnd = new Random();
        //Array to save Number
        decimal[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public PhysicsCalculator()
        {
            InitializeComponent();
        }

        //Home Menu
        private void PbMain_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabMain;
            Reset();
        }

        //HSC Search
        private void BtnHSCSearch_Click(object sender, EventArgs e)
        {
            Process.Start("https://hscsearch.com/");
        }

        //Reset all textbox
        public void Reset()
        {
            //Sig Fig Reset
            tbInput.Clear();
            tbSigFig.Clear();
            tbPower.Clear();

            //Covert Mass reset 
            cbMassFrom.SelectedIndex = -1;
            cbMassTo.SelectedIndex = -1;
            lbMassFrom.Text = null;
            lbMassTo.Text = null;
            tbMassFrom.Clear();
            tbMassTo.Clear();
            tbMassWorkingOut.Clear();
            lbMassPower.Text = null;

            //Convert Weight reset
            tbWMass.Clear();
            tbWWeight.Clear();
            tbWeightWorkingOut.Clear();
            gbWeightSaveResult.Visible = false;
            lbWMassPower.Text = null;
            lbWWeightPower.Text = null;

            //Convert Length reset
            cbLengthFrom.SelectedIndex = -1;
            cbLengthTo.SelectedIndex = -1;
            lbLengthFrom.Text = null;
            lbLengthTo.Text = null;
            tbLengthFrom.Clear();
            tbLengthTo.Clear();
            tbLengthWorkingOut.Clear();
            lbLengthPower.Text = null;


            //Convert Time reset
            tbHour.Clear();
            tbMinute.Clear();
            tbSecond.Clear();
            tbDisplayHour.Clear();
            tbDisplayMinute.Clear();
            tbDisplaySecond.Clear();
            tbTimeWorkingOut.Clear();

            //Kinematics reset
            tbKAcceleration.Clear();
            tbKFVelocity.Clear();
            tbKIVelocity.Clear();
            tbKTime.Clear();
            tbKDisplacement.Clear();
            gbKSaveResult.Visible = false;
            tbKWorkingOut.Clear();
            lbKAccelerationPower.Text = null;
            lbKDisplacementPower.Text = null;
            lbKFVelocityPower.Text = null;
            lbKIVelocityPower.Text = null;
            lbKTimePower.Text = null;

            //Dynamics
            gbDynamics.Visible = false;

            //Dynamics - Forces reset
            tbFNForce.Clear();
            tbFForce.Clear();
            tbFMass.Clear();
            tbFAcceleration.Clear();
            tbFMu.Clear();
            tbFFForce.Clear();
            gbFSave.Visible = false;
            tbFWorkingOut.Clear();
            lbFAccelerationPower.Text = null;
            lbFFForcePower.Text = null;
            lbFForcePower.Text = null;
            lbFMassPower.Text = null;
            lbFMuPower.Text = null;
            lbFNForcePower.Text = null;

            //Dynamics - Energy reset
            tbEDisplacement.Clear();
            tbEForce.Clear();
            tbEHeight.Clear();
            tbEKinetic.Clear();
            tbEMass.Clear();
            tbEPotential.Clear();
            tbEVelocity.Clear();
            tbEWork.Clear();
            gbESave.Visible = false;
            tbEWorkingOut.Clear();
            lbEDisplacementPower.Text = null;
            lbEForcePower.Text = null;
            lbEHeightPower.Text = null;
            lbEKineticPower.Text = null;
            lbEMassPower.Text = null;
            lbEPotentialPower.Text = null;
            lbEVelocityPower.Text = null;
            lbEWorkPower.Text = null;

            //Wave
            gbWave.Visible = false;

            //Wave - Wave Properties
            tbPropertiesWorkingOut.Clear();
            tbPropertiesFrequency.Clear();
            tbPropertiesLander.Clear();
            tbPropertiesTime.Clear();
            tbPropertiesVelocity.Clear();
            tbPropertiesWaveNumber.Clear();
            gbPropertiesSave.Visible = false;
            lbPropertiesFrequencyPower.Text = null;
            lbPropertiesLanderPower.Text = null;
            lbPropertiesTimePower.Text = null;
            lbPropertiesVelocityPower.Text = null;
            lbPropertiesWaveNumberPower.Text = null;

            //Wave - Sound
            tbDisplay1.Clear();
            tbDisplay2.Clear();
            tbDisplay3.Clear();
            tbDisplay4.Clear();
            tbDisplay5.Clear();
            tbDisplay1.Visible = false;
            tbDisplay2.Visible = false;
            tbDisplay3.Visible = false;
            tbDisplay4.Visible = false;
            tbDisplay5.Visible = false;
            tbSoundWorkingOut.Clear();
            lbDisplay1.Text = null;
            lbDisplay2.Text = null;
            lbDisplay3.Text = null;
            lbDisplay4.Text = null;
            lbDisplay5.Text = null;
            btnSCalculate.Visible = false;
            btnSReset.Visible = false;
            btnSHelp.Visible = false;
            btnSSave.Visible = false;
            btnSMedium.Visible = false;
            pbDopplerEffectOption.Visible = false;
            pbBeatsOption.Visible = false;
            btnSoundPrintSave.Visible = false;
            tbSoundWorkingOut.Visible = false;
            gbSSave.Visible = false;
            lbDisplay1Power.Text = null;
            lbDisplay2Power.Text = null;
            lbDisplay3Power.Text = null;
            lbDisplay4Power.Text = null;
            lbDisplay5Power.Text = null;
            
            //Wave - Intensity
            tbIIntensity.Clear();
            tbIPower.Clear();
            tbIRadis.Clear();
            tbIntensityWorkingOut.Clear();
            lbIIntensityPower.Text = null;
            lbIPowerPower.Text = null;
            lbIRadisPower.Text = null;

            //Wave - Light
            rdAir.Checked = false;
            rdIce.Checked = false;
            rdWater.Checked = false;
            tbLCritical.Clear();
            tbLRIndex.Clear();
            tbLVelocity.Clear();
            tbLIghtWorkingOut.Clear();
            lbLIndexPower.Text = null;
            lbLVelocityPower.Text = null;
            lbLCriticalPower.Text = null;

            //Thermodynamics
            tbTCapacity.Clear();
            tbTHeat.Clear();
            tbThermodynamicsWorkingOut.Clear();
            tbTLatent.Clear();
            tbTTemperature.Clear();
            tbTCapacity.Clear();
            tbTMass.Clear();
            lbTCapacityPower.Text = null;
            lbTHeatPower.Text = null;
            lbTLatentPower.Text = null;
            lbTMassPower.Text = null;
            lbTTemperaturePower.Text = null;
            lbPropertiesTimePower.Text = null;

            //Electricity 
            gbElectricity.Visible = false;

            //Electricity Field 
            tbEFDisplacement.Clear();
            tbEFEField.Clear();
            tbEFForce.Clear();
            tbEFVolt.Clear();
            tbEFWork.Clear();
            tbFieldWorkingOut.Clear();
            gbEFSave.Visible = false;
            rdElectron.Checked = false;
            rdProtron.Checked = false;
            lbEFDisplacementPower.Text = null;
            lbEFEFieldPower.Text = null;
            lbEFForcePower.Text = null;
            lbEFVoltPower.Text = null;
            lbEFWorkPower.Text = null;

            //Electric Circuit
            tbECCurrent.Clear();
            tbECPower.Clear();
            tbECResistance.Clear();
            tbECTime.Clear();
            tbECVolt.Clear();
            tbECWork.Clear();
            tbECWorkingOut.Clear();
            gbECSave.Visible = false;
            lbECCurrentPower.Text = null;
            lbECPowerPower.Text = null;
            lbECResistancePower.Text = null;
            lbECTimePower.Text = null;
            lbECVoltPower.Text = null;
            lbECWorkPower.Text = null;
            

            //Question
            gbQuestion12.Visible = false;
            gbQuestion34.Visible = false;
            gbQuestion56.Visible = false;
            gbQuestion78.Visible = false;
            gbQuestion910.Visible = false;
            gbQuestion1112.Visible = false;
            gbQuestion1314.Visible = false;
            gbQuestion1516.Visible = false;
            gbQuestion1718.Visible = false;
            gbQuestion1920.Visible = false;
            gbQuestion2122.Visible = false;
            gbQuestion2324.Visible = false;
            gbQuestion2526.Visible = false;

            //X10
            label98.Visible = false;
            label101.Visible = false;
            label99.Visible = false;
            label100.Visible = false;
            label102.Visible = false;
            label108.Visible = false;
            label110.Visible = false;
            label106.Visible = false;
            label104.Visible = false;
            label113.Visible = false;
            label111.Visible = false;
            label117.Visible = false;
            label115.Visible = false;
            label107.Visible = false;
            label103.Visible = false;
            label119.Visible = false;
            label116.Visible = false;
            label112.Visible = false;
            label105.Visible = false;
            label123.Visible = false;
            label121.Visible = false;
            label127.Visible = false;
            label125.Visible = false;
            label126.Visible = false;
            label122.Visible = false;
            label118.Visible = false;
            label109.Visible = false;
            label129.Visible = false;
            label110.Visible = false;
            label120.Visible = false;
            label130.Visible = false;
            label140.Visible = false;
            label150.Visible = false;
            label130.Visible = false;
            label114.Visible = false;
            label124.Visible = false;
            label133.Visible = false;
            label120.Visible = false;
            label131.Visible = false;
            label140.Visible = false;
            label128.Visible = false;
            label134.Visible = false;
            label136.Visible = false;
            label138.Visible = false;
            label143.Visible = false;
            label141.Visible = false;
            label137.Visible = false;
            label132.Visible = false;
            label145.Visible = false;
            label148.Visible = false;
            label146.Visible = false;
            label142.Visible = false;
            label135.Visible = false;
            label152.Visible = false;
            label150.Visible = false;
        }

        //Save Working Out
        public void Save(string WorkingOut, string Name)
        {
            string writeText = Name + Environment.NewLine + WorkingOut;
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = Name + ".txt";
            string filePath = Path.Combine(fileLocation, fileName);
            MessageBox.Show("Working Out Saved", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                File.WriteAllText(filePath, writeText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem Printing Receipt: " + ex.Message);
            }
        }


        //Convert Sig Page


        private void BtnConvertSig_Click(object sender, EventArgs e)
        {
            decimal Text = 0m;
            Decimal.TryParse(tbInput.Text, out Text);
            String Input = Text.ToString();

            if (Input[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Input);
                tbSigFig.Text = sigFigStruct.Output.ToString();
                tbPower.Text = sigFigStruct.Power.ToString();
            }
            else if (Input[0].ToString() == "-")
            {
                decimal number = decimal.Parse(Input) * -1;
                if (Input[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbSigFig.Text = "-" + sigFigStruct.Output.ToString();
                    tbPower.Text = sigFigStruct.Power.ToString();
                }
                else if (Input[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbSigFig.Text = "-" + sigFigStruct.Output.ToString();
                    tbPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else if (Input[0].ToString() != "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Input);
                tbSigFig.Text = sigFigStruct.Output.ToString();
                tbPower.Text = sigFigStruct.Power.ToString();
            }
        }

        //Reset Sig Page
        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Help Option
        private void BtnSigHelp_Click(object sender, EventArgs e)
        {
            SigHelp sigHelp = new SigHelp();
            sigHelp.ShowDialog();
        }

        //Convrt number in Sig Figure
        static SigFigStruct SigFigReturnNegativeStruct(String Input)
        {
            SigFigStruct sigFigStruct = new SigFigStruct();
            //Setting Varriables
            decimal number = decimal.Parse(Input);
            int currentPosition = 1;
            char currentNumber = Input[0];
            int num_in_a_row = 1;
            for (int i = currentPosition + 1; i < Input.Length; i++)
            {
                if (Input[i] == currentNumber)
                {
                    num_in_a_row++;
                }
                else
                {
                    break;
                }
            }
            //Getting the power 
            sigFigStruct.Power = (num_in_a_row) * -1;

            //Displaying Number
            sigFigStruct.Answer = (number) / (decimal)Math.Pow(10, (double)sigFigStruct.Power);
            sigFigStruct.Output = Math.Round(sigFigStruct.Answer, 5);
            return sigFigStruct;
        }

        //Convrt number in Sig Figure
        static SigFigStruct SigFigReturnPostiveStruct(String Input)
        {
            SigFigStruct sigFigStruct = new SigFigStruct();
            //Setting Varriables
            decimal number = Decimal.Parse(Input);
            int num_in_a_row = 1;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].ToString() != ".")
                {
                    num_in_a_row++;
                }
                else
                {
                    break;
                }
            }
            //Getting the power 
            sigFigStruct.Power = num_in_a_row - 2;

            //Displaying Number
            sigFigStruct.Answer = (number) / (decimal)Math.Pow(10, (double)sigFigStruct.Power);
            sigFigStruct.Output = Math.Round(sigFigStruct.Answer, 5);
            return sigFigStruct;
        }

        //Convrt number in Sig Figure
        static SigFigStruct SigFigReturnOrginalStruct(String Input, decimal Power)
        {
            SigFigStruct sigFigStruct = new SigFigStruct();
            //Setting Varriables
            decimal number = decimal.Parse(Input);
            //Calculating
            sigFigStruct.Orginal = number * (decimal)Math.Pow(10, (double)Power);
            return sigFigStruct;
        }

        //Convert negative number in Sig firgue
        static SigFigStruct SigFigReturnNegativeWholeStruct(String Input)
        {
            SigFigStruct sigFigStruct = new SigFigStruct();
            //Setting Varriables
            decimal number = Decimal.Parse(Input);
            int num_in_a_row = 1;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].ToString() != ".")
                {
                    num_in_a_row++;
                }
                else
                {
                    break;
                }
            }
            //Getting the power 
            sigFigStruct.Power = num_in_a_row - 2;

            //Displaying Number
            sigFigStruct.Answer = (number) / (decimal)Math.Pow(10, (double)sigFigStruct.Power);
            sigFigStruct.Output = Math.Round(sigFigStruct.Answer, 5);
            return sigFigStruct;
        }

        //Varriable for Sig Figure
        struct SigFigStruct
        {
            public decimal Power;
            public decimal Answer;
            public decimal Output;
            public decimal Orginal;
        }


        //Question


        //Start Quiz
        private void BtnMainQuestion_Click(object sender, EventArgs e)
        {
            Quiz();
        }
        
        //Help Option
        private void BtnQuestionHelp_Click(object sender, EventArgs e)
        {
            QuestionHelp questionHelp = new QuestionHelp();
            questionHelp.ShowDialog();
        }

        //Picking Question
        public void Quiz()
        {
            int Question = rnd.Next(1, 27);
            if (Question == 1)
            {
                PhysicsTab.SelectedTab = tabConvertMass;
                Reset();
                gbQuestion12.Visible = true;
                pbCorrect12.Visible = false;
                pbWrong12.Visible = false;
                lbQuestion1.Visible = true;
                lbQuestion2.Visible = false;
            }
            else if (Question == 2)
            {
                PhysicsTab.SelectedTab = tabConvertMass;
                Reset();
                gbQuestion12.Visible = true;
                pbCorrect12.Visible = false;
                pbWrong12.Visible = false;
                lbQuestion1.Visible = false;
                lbQuestion2.Visible = true;
            }
            else if (Question == 3)
            {
                PhysicsTab.SelectedTab = tabConvertWeight;
                Reset();
                gbQuestion34.Visible = true;
                pbCorrect34.Visible = false;
                pbWrong34.Visible = false;
                lbQuestion3.Visible = true;
                lbQuestion4.Visible = false;
            }
            else if (Question == 4)
            {
                PhysicsTab.SelectedTab = tabConvertWeight;
                Reset();
                gbQuestion34.Visible = true;
                pbCorrect34.Visible = false;
                pbWrong34.Visible = false;
                lbQuestion3.Visible = false;
                lbQuestion4.Visible = true;
            }
            else if (Question == 5)
            {
                PhysicsTab.SelectedTab = tabConvertLength;
                Reset();
                gbQuestion56.Visible = true;
                pbCorrect56.Visible = false;
                pbWrong56.Visible = false;
                lbQuestion5.Visible = true;
                lbQuestion6.Visible = false;
            }
            else if (Question == 6)
            {
                PhysicsTab.SelectedTab = tabConvertLength;
                Reset();
                gbQuestion56.Visible = true;
                pbCorrect56.Visible = false;
                pbWrong56.Visible = false;
                lbQuestion5.Visible = false;
                lbQuestion6.Visible = true;
            }
            else if (Question == 7)
            {
                PhysicsTab.SelectedTab = tabConvertTime;
                Reset();
                gbQuestion78.Visible = true;
                pbCorrect78.Visible = false;
                pbWrong78.Visible = false;
                lbQuestion7.Visible = true;
                lbQuestion8.Visible = false;
            }
            else if (Question == 8)
            {
                PhysicsTab.SelectedTab = tabConvertTime;
                Reset();
                gbQuestion78.Visible = true;
                pbCorrect78.Visible = false;
                pbWrong78.Visible = false;
                lbQuestion7.Visible = false;
                lbQuestion8.Visible = true;
            }
            else if (Question == 9)
            {
                PhysicsTab.SelectedTab = tabKinematics;
                Reset();
                gbQuestion910.Visible = true;
                pbCorrect910.Visible = false;
                pbWrong910.Visible = false;
                lbQuestion9.Visible = true;
                lbQuestion10.Visible = false;
            }
            else if (Question == 10)
            {
                PhysicsTab.SelectedTab = tabKinematics;
                Reset();
                gbQuestion910.Visible = true;
                pbCorrect910.Visible = false;
                pbWrong910.Visible = false;
                lbQuestion9.Visible = false;
                lbQuestion10.Visible = true;
            }
            else if (Question == 11)
            {
                PhysicsTab.SelectedTab = tabForces;
                Reset();
                gbQuestion1112.Visible = true;
                pbCorrect1112.Visible = false;
                pbWrong1112.Visible = false;
                lbQuestion11.Visible = true;
                lbQuestion12.Visible = false;
            }
            else if (Question == 12)
            {
                PhysicsTab.SelectedTab = tabForces;
                Reset();
                gbQuestion1112.Visible = true;
                pbCorrect1112.Visible = false;
                pbWrong1112.Visible = false;
                lbQuestion11.Visible = false;
                lbQuestion12.Visible = true;
            }
            else if (Question == 13)
            {
                PhysicsTab.SelectedTab = tabEnergy;
                Reset();
                gbQuestion1314.Visible = true;
                pbCorrect1314.Visible = false;
                pbWrong1314.Visible = false;
                lbQuestion13.Visible = true;
                lbQuestion14.Visible = false;
            }
            else if (Question == 14)
            {
                PhysicsTab.SelectedTab = tabEnergy;
                Reset();
                gbQuestion1314.Visible = true;
                pbCorrect1314.Visible = false;
                pbWrong1314.Visible = false;
                lbQuestion13.Visible = false;
                lbQuestion14.Visible = true;
            }
            else if (Question == 15)
            {
                PhysicsTab.SelectedTab = tabWaveProperties;
                Reset();
                gbQuestion1516.Visible = true;
                pbCorrect1516.Visible = false;
                pbWrong1516.Visible = false;
                lbQuestion15.Visible = true;
                lbQuestion16.Visible = false;
            }
            else if (Question == 16)
            {
                PhysicsTab.SelectedTab = tabWaveProperties;
                Reset();
                gbQuestion1516.Visible = true;
                pbCorrect1516.Visible = false;
                pbWrong1516.Visible = false;
                lbQuestion15.Visible = false;
                lbQuestion16.Visible = true;
            }
            else if (Question == 17)
            {
                PhysicsTab.SelectedTab = tabIntensity;
                Reset();
                gbQuestion1718.Visible = true;
                pbCorrect1718.Visible = false;
                pbWrong1718.Visible = false;
                lbQuestion17.Visible = true;
                lbQuestion18.Visible = false;
            }
            else if (Question == 18)
            {
                PhysicsTab.SelectedTab = tabIntensity;
                Reset();
                gbQuestion1718.Visible = true;
                pbCorrect1718.Visible = false;
                pbWrong1718.Visible = false;
                lbQuestion17.Visible = false;
                lbQuestion18.Visible = true;
            }
            else if (Question == 19)
            {
                PhysicsTab.SelectedTab = tabLight;
                Reset();
                gbQuestion1920.Visible = true;
                pbCorrect1920.Visible = false;
                pbWrong1920.Visible = false;
                lbQuestion19.Visible = true;
                lbQuestion20.Visible = false;
            }
            else if (Question == 20)
            {
                PhysicsTab.SelectedTab = tabLight;
                Reset();
                gbQuestion1920.Visible = true;
                pbCorrect1920.Visible = false;
                pbWrong1920.Visible = false;
                lbQuestion19.Visible = false;
                lbQuestion20.Visible = true;
            }
            else if (Question == 21)
            {
                PhysicsTab.SelectedTab = tabThermodynamics;
                Reset();
                gbQuestion2122.Visible = true;
                pbCorrect2122.Visible = false;
                pbWrong2122.Visible = false;
                lbQuestion21.Visible = true;
                lbQuestion22.Visible = false;
            }
            else if (Question == 22)
            {
                PhysicsTab.SelectedTab = tabThermodynamics;
                Reset();
                gbQuestion2122.Visible = true;
                pbCorrect2122.Visible = false;
                pbWrong2122.Visible = false;
                lbQuestion21.Visible = false;
                lbQuestion22.Visible = true;
            }
            else if (Question == 23)
            {
                PhysicsTab.SelectedTab = tabElectricField;
                Reset();
                gbQuestion2324.Visible = true;
                pbCorrect2324.Visible = false;
                pbWrong2324.Visible = false;
                lbQuestion23.Visible = true;
                lbQuestion24.Visible = false;
            }
            else if (Question == 24)
            {
                PhysicsTab.SelectedTab = tabElectricField;
                Reset();
                gbQuestion2324.Visible = true;
                pbCorrect2324.Visible = false;
                pbWrong2324.Visible = false;
                lbQuestion23.Visible = false;
                lbQuestion24.Visible = true;
            }
            else if (Question == 25)
            {
                PhysicsTab.SelectedTab = tabElectricCircuit;
                Reset();
                gbQuestion2526.Visible = true;
                pbCorrect2526.Visible = false;
                pbWrong2526.Visible = false;
                lbQuestion25.Visible = true;
                lbQuestion26.Visible = false;
            }
            else if (Question == 26)
            {
                PhysicsTab.SelectedTab = tabElectricCircuit;
                Reset();
                gbQuestion2526.Visible = true;
                pbCorrect2526.Visible = false;
                pbWrong2526.Visible = false;
                lbQuestion25.Visible = false;
                lbQuestion26.Visible = true;
            }
        }

        //Question 1 and 2
        private void BtnMassQuestion12_Click(object sender, EventArgs e)
        {
            if (lbQuestion1.Visible == true)
            {
                if (tbMassTo.Text == "2.3" & lbMassPower.Text == "-1")
                {
                    pbCorrect12.Visible = true;
                    pbWrong12.Visible = false;
                }
                else
                {
                    pbWrong12.Visible = true;
                    pbCorrect12.Visible = false;
                }
            }
            else if (lbQuestion2.Visible == true)
            {
                if (tbMassTo.Text == "1.473" & lbMassPower.Text == "-2")
                {
                    pbCorrect12.Visible = true;
                    pbWrong12.Visible = false;
                }
                else
                {
                    pbWrong12.Visible = true;
                    pbCorrect12.Visible = false;
                }
            }
        }
        private void BtnMassSQuestion12_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnMassNQuestion12_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }
        
        //Question 3 and 4
        private void BtnQuestion34_Click(object sender, EventArgs e)
        {
            if (lbQuestion3.Visible == true)
            {
                if (tbWMass.Text == "1.02041" & lbWMassPower.Text == "1")
                {
                    pbCorrect34.Visible = true;
                    pbWrong34.Visible = false;
                }
                else
                {
                    pbWrong34.Visible = true;
                    pbCorrect34.Visible = false;
                }
            }
            else if (lbQuestion4.Visible == true)
            {
                if (tbWWeight.Text == "2.94" & lbWWeightPower.Text == "3")
                {
                    pbCorrect34.Visible = true;
                    pbWrong34.Visible = false;
                }
                else
                {
                    pbWrong34.Visible = true;
                    pbCorrect34.Visible = false;
                }
            }
        }
        private void BtnSQuestion34_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion34_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 5 and 6
        private void BtnQuestion56_Click(object sender, EventArgs e)
        {
            if (lbQuestion5.Visible == true)
            {
                if (tbLengthTo.Text == "1" & lbLengthPower.Text == "4")
                {
                    pbCorrect56.Visible = true;
                    pbWrong56.Visible = false;
                }
                else
                {
                    pbWrong56.Visible = true;
                    pbCorrect56.Visible = false;
                }
            }
            else if (lbQuestion6.Visible == true)
            {
                if (tbLengthTo.Text == "1.23353" & lbLengthPower.Text == "0")
                {
                    pbCorrect56.Visible = true;
                    pbWrong56.Visible = false;
                }
                else
                {
                    pbWrong56.Visible = true;
                    pbCorrect56.Visible = false;
                }
            }
        }
        private void BtnSQuestion56_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion56_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 7 and 8
        private void BtnQuestion78_Click(object sender, EventArgs e)
        {
            if (lbQuestion7.Visible == true)
            {
                if (tbDisplaySecond.Text == "604800")
                {
                    pbCorrect78.Visible = true;
                    pbWrong78.Visible = false;
                }
                else
                {
                    pbWrong78.Visible = true;
                    pbCorrect78.Visible = false;
                }
            }
            else if (lbQuestion8.Visible == true)
            {
                if (tbDisplaySecond.Text == "13080")
                {
                    pbCorrect78.Visible = true;
                    pbWrong78.Visible = false;
                }
                else
                {
                    pbWrong78.Visible = true;
                    pbCorrect78.Visible = false;
                }
            }
        }
        private void BtnSQuestion78_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion78_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 9 and 10
        private void BtnQuestion910_Click(object sender, EventArgs e)
        {
            if (lbQuestion9.Visible == true)
            {
                if (tbKDisplacement.Text == "4" & lbKDisplacementPower.Text == "1")
                {
                    pbCorrect910.Visible = true;
                    pbWrong910.Visible = false;
                }
                else
                {
                    pbWrong910.Visible = true;
                    pbCorrect910.Visible = false;
                }
            }
            else if (lbQuestion10.Visible == true)
            {
                if (tbKAcceleration.Text == "5" & lbKAccelerationPower.Text == "-1")
                {
                    pbCorrect910.Visible = true;
                    pbWrong910.Visible = false;
                }
                else
                {
                    pbWrong910.Visible = true;
                    pbCorrect910.Visible = false;
                }
            }
        }
        private void BtnNQuestion910_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }
        private void BtnSQuestion910_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Question 11 and 12
        private void BtnQuestion1112_Click(object sender, EventArgs e)
        {
            if (lbQuestion11.Visible == true)
            {
                if (tbFMu.Text == "2.94985" & lbFMuPower.Text == "-2")
                {
                    pbCorrect1112.Visible = true;
                    pbWrong1112.Visible = false;
                }
                else
                {
                    pbWrong1112.Visible = true;
                    pbCorrect1112.Visible = false;
                }
            }
            else if (lbQuestion12.Visible == true)
            {
                if (tbFForce.Text == "1.32653" & lbFForcePower.Text == "2")
                {
                    pbCorrect1112.Visible = true;
                    pbWrong1112.Visible = false;
                }
                else
                {
                    pbWrong1112.Visible = true;
                    pbCorrect1112.Visible = false;
                }
            }
        }
        private void BtnSQuestion1112_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion1112_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 13 and 14
        private void BtnQuestion1314_Click(object sender, EventArgs e)
        {
            if (lbQuestion13.Visible == true)
            {
                if (tbEKinetic.Text == "3.75" & lbEKineticPower.Text == "1")
                {
                    pbCorrect1314.Visible = true;
                    pbWrong1314.Visible = false;
                }
                else
                {
                    pbWrong1314.Visible = true;
                    pbCorrect1314.Visible = false;
                }
            }
            else if (lbQuestion14.Visible == true)
            {
                if (tbEPotential.Text == "1.764" & lbEPotentialPower.Text == "2")
                {
                    pbCorrect1314.Visible = true;
                    pbWrong1314.Visible = false;
                }
                else
                {
                    pbWrong1314.Visible = true;
                    pbCorrect1314.Visible = false;
                }
            }
        }
        private void BtnSQuestion1314_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion1314_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 15 and 16
        private void BtnQuestion1516_Click(object sender, EventArgs e)
        {
            if (lbQuestion15.Visible == true)
            {
                if (tbPropertiesFrequency.Text == "1" & lbPropertiesFrequencyPower.Text == "0")
                {
                    pbCorrect1516.Visible = true;
                    pbWrong1516.Visible = false;
                }
                else
                {
                    pbWrong1516.Visible = true;
                    pbCorrect1516.Visible = false;
                }
            }
            else if (lbQuestion16.Visible == true)
            {
                if (tbPropertiesLander.Text == "3.14159" & lbPropertiesFrequencyPower.Text == "-1")
                {
                    pbCorrect1516.Visible = true;
                    pbWrong1516.Visible = false;
                }
                else
                {
                    pbWrong1516.Visible = true;
                    pbCorrect1516.Visible = false;
                }
            }
        }
        private void BtnSQuestion1516_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion1516_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 17 and 18
        private void BtnQuestion1718_Click(object sender, EventArgs e)
        {
            if (lbQuestion17.Visible == true)
            {
                if (tbIIntensity.Text == "1" & lbIIntensityPower.Text == "-2")
                {
                    pbCorrect1718.Visible = true;
                    pbWrong1718.Visible = false;
                }
                else
                {
                    pbWrong1718.Visible = true;
                    pbCorrect1718.Visible = false;
                }
            }
            else if (lbQuestion18.Visible == true)
            {
                if (tbIPower.Text == "1.25664" & lbIPowerPower.Text == "1")
                {
                    pbCorrect1718.Visible = true;
                    pbWrong1718.Visible = false;
                }
                else
                {
                    pbWrong1718.Visible = true;
                    pbCorrect1718.Visible = false;
                }
            }
        }
        private void BtnNQuestion1718_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }
        private void BtnSQuestion1718_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Question 19 and 20
        private void BtnQuestion1920_Click(object sender, EventArgs e)
        {
            if (lbQuestion19.Visible == true)
            {
                if (tbLRIndex.Text == "1.18421" & lbLIndexPower.Text == "7")
                {
                    pbCorrect1920.Visible = true;
                    pbWrong1920.Visible = false;
                }
                else
                {
                    pbWrong1920.Visible = true;
                    pbCorrect1920.Visible = false;
                }
            }
            else if (lbQuestion20.Visible == true)
            {
                if (tbLVelocity.Text == "6.66667" & lbLVelocityPower.Text == "7")
                {
                    pbCorrect1920.Visible = true;
                    pbWrong1920.Visible = false;
                }
                else
                {
                    pbWrong1920.Visible = true;
                    pbCorrect1920.Visible = false;
                }
            }
        }
        private void BtnNQuestion1920_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }
        private void BtnSQuestion1920_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Question 21 and 22
        private void BtnQuestion2122_Click(object sender, EventArgs e)
        {
            if (lbQuestion21.Visible == true)
            {
                if (tbTHeat.Text == "4" & lbTHeatPower.Text == "1")
                {
                    pbCorrect2122.Visible = true;
                    pbWrong2122.Visible = false;
                }
                else
                {
                    pbWrong2122.Visible = true;
                    pbCorrect2122.Visible = false;
                }
            }
            else if (lbQuestion22.Visible == true)
            {
                if (tbTLatent.Text == "6.66667" & lbTLatentPower.Text == "0")
                {
                    pbCorrect2122.Visible = true;
                    pbWrong2122.Visible = false;
                }
                else
                {
                    pbWrong2122.Visible = true;
                    pbCorrect2122.Visible = false;
                }
            }
        }
        private void BtnSQuestion2122_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion2122_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }

        //Question 23 and 24
        private void BtnQuestion2324_Click(object sender, EventArgs e)
        {
            if (lbQuestion23.Visible == true)
            {
                if (tbEFWork.Text == "2.704" & lbEFWorkPower.Text == "-17")
                {
                    pbCorrect2324.Visible = true;
                    pbWrong2324.Visible = false;
                }
                else
                {
                    pbWrong2324.Visible = true;
                    pbCorrect2324.Visible = false;
                }
            }
            else if (lbQuestion24.Visible == true)
            {
                if (tbEFForce.Text == "3.0000" & lbEFForcePower.Text == "-19")
                {
                    pbCorrect2324.Visible = true;
                    pbWrong2324.Visible = false;
                }
                else
                {
                    pbWrong2324.Visible = true;
                    pbCorrect2324.Visible = false;
                }
            }
        }
        private void BtnNQuestion2324_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }
        private void BtnSQuestion2324_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Question 25 and 26
        private void BtnQuestion2526_Click(object sender, EventArgs e)
        {
            if (lbQuestion25.Visible == true)
            {
                if (tbECWork.Text == "5.1200" & lbECWorkPower.Text == "-18")
                {
                    pbCorrect2526.Visible = true;
                    pbWrong2526.Visible = false;
                }
                else
                {
                    pbWrong2526.Visible = true;
                    pbCorrect2526.Visible = false;
                }
            }
            else if (lbQuestion26.Visible == true)
            {
                if (tbECPower.Text == "2.29333" & lbECPowerPower.Text == "-19")
                {
                    pbCorrect2526.Visible = true;
                    pbWrong2526.Visible = false;
                }
                else
                {
                    pbWrong2526.Visible = true;
                    pbCorrect2526.Visible = false;
                }
            }
        }
        private void BtnSQuestion2526_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnNQuestion2526_Click(object sender, EventArgs e)
        {
            Reset();
            Quiz();
        }


        //Convert Mass Page


        //Oppening Mass tab and reset previous result
        private void BtnMass_Click(object sender, EventArgs e)
        {
            Reset();
            PhysicsTab.SelectedTab = tabConvertMass;
            gbDynamics.Visible = false;
            gbWave.Visible = false;
        }

        //Displaying and reset units
        private void CbMassFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMassFrom.Text = null;
            tbMassFrom.Text = null;
            lbMassPower.Text = null;
            string FromUnits = cbMassFrom.Text;
            string Symbol = "";
            string DisplayForm = "From";
            MassUnits(FromUnits, Symbol, DisplayForm);
            label98.Visible = false;
        }

        //Displaying and reset units
        private void CbMassTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMassTo.Text = null;
            tbMassTo.Text = null;
            lbMassPower.Text = null;
            label98.Visible = false;
            string ToUnits = cbMassTo.Text;
            string Symbol = "";
            string DisplayTo = "To";
            MassUnits(ToUnits, Symbol, DisplayTo);
        }

        //Print or Save working out
        private void BtnMassPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentMass;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentMass.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbMassWorkingOut.Text, "Mass");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentMass_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbMassWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculating Mass Page
        private void BtnMassConvert_Click(object sender, EventArgs e)
        {
            //check if used save number
            decimal FromMass = 0;
            if (tbMassFrom.Text == "Mass")
            {
                FromMass = array[0];
            }
            else
            {
                Decimal.TryParse(tbMassFrom.Text, out FromMass);
            }

            //setting varriables
            decimal ToMass = 0;
            string Operation = "";
            string FromUnits = cbMassFrom.Text;
            string ToUnits = cbMassTo.Text;

            //Calculating for Converting Mass
            //Microgram
            if (FromUnits == "Microgram")
            {
                if (ToUnits == "Microgram")
                {
                    ToMass = FromMass;
                    Operation = " ";
                }
                else if (ToUnits == "Milligram")
                {
                    ToMass = FromMass / 1000;
                    Operation = " / 1000";
                }
                else if (ToUnits == "Gram")
                {
                    ToMass = FromMass / 1000000;
                    Operation = " / 1000000";
                }

                else if (ToUnits == "Kilogram")
                {
                    ToMass = FromMass / 1000000000;
                    Operation = " / 1000000000";
                }

            }
            //Milligram
            else if (FromUnits == "Milligram")
            {
                if (ToUnits == "Microgram")
                {
                    ToMass = FromMass * 1000;
                    Operation = " * 1000";
                }
                else if (ToUnits == "Milligram")
                {
                    ToMass = FromMass;
                    Operation = " ";
                }
                else if (ToUnits == "Gram")
                {
                    ToMass = FromMass / 1000;
                    Operation = " / 1000";
                }
                else if (ToUnits == "Kilogram")
                {
                    ToMass = FromMass / 1000000;
                    Operation = " / 1000000";
                }

            }
            //Gram
            else if (FromUnits == "Gram")
            {
                if (ToUnits == "Microgram")
                {
                    ToMass = FromMass * 1000000;
                    Operation = " * 1000000";
                }
                else if (ToUnits == "Milligram")
                {
                    ToMass = FromMass * 1000;
                    Operation = " * 1000";
                }
                else if (ToUnits == "Gram")
                {
                    ToMass = FromMass;
                    Operation = " ";
                }
                else if (ToUnits == "Kilogram")
                {
                    ToMass = FromMass / 1000;
                    Operation = " / 1000";
                }

            }
            //Kilogram
            else if (FromUnits == "Kilogram")
            {
                if (ToUnits == "Microgram")
                {
                    ToMass = FromMass * 1000000000;
                    Operation = " * 1000000000";
                }
                else if (ToUnits == "Milligram")
                {
                    ToMass = FromMass * 1000000;
                    Operation = " * 1000000";
                }
                else if (ToUnits == "Gram")
                {
                    ToMass = FromMass * 1000;
                    Operation = " * 1000";
                }
                else if (ToUnits == "Kilogram")
                {
                    ToMass = FromMass;
                    Operation = " ";
                }

            }

            //Displaying result
            tbMassWorkingOut.Text = ToUnits + " = " + FromMass + Operation + Environment.NewLine + ToUnits + " = " + ToMass;
            tbWeightWorkingOut.TextAlign = HorizontalAlignment.Center;
            label98.Visible = true;

            string ShowMass = ToMass.ToString();
            if (ShowMass[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(ToMass.ToString());
                tbMassTo.Text = sigFigStruct.Output.ToString();
                lbMassPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowMass[0].ToString() != "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(ToMass.ToString());
                tbMassTo.Text = sigFigStruct.Output.ToString();
                lbMassPower.Text = sigFigStruct.Power.ToString();
            }
        }

        //Dispalying the units for each mass
        public void MassUnits(string Group, string Symbol, string Display)
        {
            //Setting rights units
            if (Group == "Microgram")
            {
                Symbol = " (μg)";
            }
            else if (Group == "Milligram")
            {
                Symbol = " (mg)";
            }
            else if (Group == "Gram")
            {
                Symbol = " (g)";
            }
            else if (Group == "Kilogram")
            {
                Symbol = " (kg)";
            }

            //Displaying in right place
            if (Display == "From")
            {
                lbMassFrom.Text = Group + Symbol;
            }
            else if (Display == "To")
            {
                lbMassTo.Text = Group + Symbol;
            }
        }

        //Saving Number
        private void BtnSaveMass_Click(object sender, EventArgs e)
        {
            SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbMassTo.Text, decimal.Parse(lbMassPower.Text));
            array[0] = sigFigStruct.Orginal;
            MessageBox.Show("The Mass that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Mass'");
        }

        //Help Option
        private void BtnMassQuestion_Click(object sender, EventArgs e)
        {
            MassHelp massHelp = new MassHelp();
            massHelp.ShowDialog();
        }


        //Convert Weight Page


        //Oppening Weight tab and reset previous result
        private void BtnWeight_Click(object sender, EventArgs e)
        {
            Reset();
            PhysicsTab.SelectedTab = tabConvertWeight;
            gbDynamics.Visible = false;
            gbWave.Visible = false;
        }

        //Reset Vaule
        private void BtnWeightReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save WorkingOut
        private void BtnWeightPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentWeight;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentWeight.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbWeightWorkingOut.Text, "Weight");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentWeight_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbWeightWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculat Weight Convert
        private void BtnWeightConvert_Click(object sender, EventArgs e)
        {
            //Disable Save 
            gbWeightSaveResult.Visible = false;

            //check if used save number / setting varriables
            const decimal Gravity = 9.8m;
            decimal Weight = 0M;
            decimal Mass = 0M;

            //Mass
            if (string.IsNullOrWhiteSpace(tbWMass.Text))
            {
                Mass = 0M;
            }
            else if (tbWMass.Text == "Mass")
            {
                Mass = array[0];
            }
            else
            {
                Decimal.TryParse(tbWMass.Text, out Mass);
            }
            //Weight
            if (string.IsNullOrWhiteSpace(tbWWeight.Text))
            {
                Weight = 0M;
            }
            else if (tbWWeight.Text == "Force")
            {
                Weight = array[5];
            }
            else
            {
                Decimal.TryParse(tbWWeight.Text, out Weight);
            }

            //Calculating for Mass
            if (Mass == 0)
            {
                Mass = Weight / Gravity;

                tbWeightWorkingOut.Text = "Mass = " + Gravity + " / " + Weight + Environment.NewLine + "Mass = " + Mass + "kg";
                tbWeightWorkingOut.TextAlign = HorizontalAlignment.Center;
            }
            //Calculating for Weight
            else if (Weight == 0)
            {
                Weight = Mass * Gravity;
            
                tbWeightWorkingOut.Text = "Weight = " + Gravity + " * " + Mass + Environment.NewLine + "Weight = " + Weight + "N";
                tbWeightWorkingOut.TextAlign = HorizontalAlignment.Center;
            }

            //Display Weight
            string ShowWeight = Weight.ToString();
            if (ShowWeight[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Weight.ToString());
                tbWWeight.Text = sigFigStruct.Output.ToString();
                lbWWeightPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Weight.ToString());
                tbWWeight.Text = sigFigStruct.Output.ToString();
                lbWWeightPower.Text = sigFigStruct.Power.ToString();
            }
            //Display Mass
            string ShowMass = Mass.ToString();
            if (ShowMass[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Mass.ToString());
                tbWMass.Text = sigFigStruct.Output.ToString();
                lbWMassPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Mass.ToString());
                tbWMass.Text = sigFigStruct.Output.ToString();
                lbWMassPower.Text = sigFigStruct.Power.ToString();
            }

            label101.Visible = true;
            label99.Visible = true;
        }

        //Save Number
        private void BtnSaveResult_Click(object sender, EventArgs e)
        {
            gbWeightSaveResult.Visible = true;
        }

        //Save Mass
        private void BtnRecordMass_Click(object sender, EventArgs e)
        {
            if (tbWMass.Text != "Mass")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbWMass.Text, decimal.Parse(lbWMassPower.Text));
                array[0] = sigFigStruct.Orginal;
                MessageBox.Show("The Mass that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Mass'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbWeightSaveResult.Visible = false;
        }

        //Save Weight
        private void BtnSaveWeight_Click(object sender, EventArgs e)
        {
            if (tbWWeight.Text != "Force")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbWWeight.Text, decimal.Parse(lbWWeightPower.Text));
                array[5] = sigFigStruct.Orginal;
                MessageBox.Show("The Weight that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Force'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbWeightSaveResult.Visible = false;
        }

        //Help Option
        private void BtnMassHelp_Click(object sender, EventArgs e)
        {
            WeightHelp weightHelp = new WeightHelp();
            weightHelp.ShowDialog();
        }

        
        //Convert Length


        //Oppening Length tab and reset previous reult
        private void BtnLength_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabConvertLength;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
        }

        //Displaying and reset units
        private void CbLengthFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLengthFrom.Text = null;
            tbLengthFrom.Text = null;
            lbLengthPower.Text = null;
            label100.Visible = false;
            string FromUnits = cbLengthFrom.Text;
            string Symbol = "";
            string DisplayForm = "From";
            LengthUnits(FromUnits, Symbol, DisplayForm);
        }

        //Displaying and reset units
        private void CbLengthTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLengthTo.Text = null;
            tbLengthTo.Text = null;
            lbLengthPower.Text = null;
            label100.Visible = false;
            string ToUnits = cbLengthTo.Text;
            string Symbol = "";
            string DisplayTo = "To";
            LengthUnits(ToUnits, Symbol, DisplayTo);
        }

        //Print and Save
        private void BtnLengthPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentLength;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentLength.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbLengthWorkingOut.Text, "Length");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentLength_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbLengthWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Length Convert
        private void BtnLengthConvert_Click(object sender, EventArgs e)
        {
            //Check if use save number
            decimal FromLength = 0;
            if (tbLengthFrom.Text == ("Length"))
            {
                FromLength = array[2];
            }
            else
            {
                Decimal.TryParse(tbLengthFrom.Text, out FromLength);
            }

            //Setting Varriables
            decimal ToLength = 0M;
            string Operation = "";
            string FromUnits = cbLengthFrom.Text;
            string ToUnits = cbLengthTo.Text;

            //Calculating for Convert Length
            //Kilometer
            if (FromUnits == "Kilometer")
            {
                if (ToUnits == "Kilometer")
                {
                    ToLength = FromLength;
                    Operation = " ";
                }
                else if (ToUnits == "Meter")
                {
                    ToLength = FromLength * 1000;
                    Operation = " * 1000";
                }
                else if (ToUnits == "Centimeter")
                {
                    ToLength = FromLength * 100000;
                    Operation = " * 100000";
                }

                else if (ToUnits == "Millimeter")
                {
                    ToLength = FromLength * 1000000;
                    Operation = " * 1000000";
                }
            }
            //Meter
            else if (FromUnits == "Meter")
            {
                if (ToUnits == "Kilometer")
                {
                    ToLength = FromLength / 1000;
                    Operation = " / 1000";
                }
                else if (ToUnits == "Meter")
                {
                    ToLength = FromLength;
                    Operation = " ";
                }
                else if (ToUnits == "Centimeter")
                {
                    ToLength = FromLength * 100;
                    Operation = " * 1000";
                }
                else if (ToUnits == "Millimeter")
                {
                    ToLength = FromLength * 1000;
                    Operation = " * 10000";
                }
            }
            //Centimeter
            else if (FromUnits == "Centimeter")
            {
                if (ToUnits == "Kilometer")
                {
                    ToLength = FromLength / 100000;
                    Operation = " / 100000";
                }
                else if (ToUnits == "Meter")
                {
                    ToLength = FromLength / 100;
                    Operation = " / 100";
                }
                else if (ToUnits == "Centimeter")
                {
                    ToLength = FromLength;
                    Operation = " ";
                }
                else if (ToUnits == "Millimeter")
                {
                    ToLength = FromLength * 10;
                    Operation = " * 10";
                }
            }
            //Millimeter
            else if (FromUnits == "Millimeter")
            {
                if (ToUnits == "Kilometer")
                {
                    ToLength = FromLength / 1000000;
                    Operation = " / 1000000";
                }
                else if (ToUnits == "Meter")
                {
                    ToLength = FromLength / 1000;
                    Operation = " / 1000";
                }
                else if (ToUnits == "Centimeter")
                {
                    ToLength = FromLength / 10;
                    Operation = " / 10";
                }
                else if (ToUnits == "Millimeter")
                {
                    ToLength = FromLength;
                    Operation = " ";
                }
            }

            //Displaying  result
            string ShowLength = ToLength.ToString();
            if (ShowLength[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(ToLength.ToString());
                tbLengthTo.Text = sigFigStruct.Output.ToString();
                lbLengthPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(ToLength.ToString());
                tbLengthTo.Text = sigFigStruct.Output.ToString();
                lbLengthPower.Text = sigFigStruct.Power.ToString();
            }

            tbLengthWorkingOut.Text = ToUnits + " = " + FromUnits + Operation + Environment.NewLine + ToUnits + " = " + ToLength;
            tbLengthWorkingOut.TextAlign = HorizontalAlignment.Center;
            label100.Visible = true;
        }

        //Displaying the units for each length
        public void LengthUnits(string Group, string Symbol, string Display)
        {
            //Setting rights units
            if (Group == "Kilometer")
            {
                Symbol = " (km)";
            }
            else if (Group == "Meter")
            {
                Symbol = " (m)";
            }
            else if (Group == "Centimeter")
            {
                Symbol = " (cm)";
            }
            else if (Group == "Millimeter")
            {
                Symbol = " (mm)";
            }

            //Displayinig in right place
            if (Display == "From")
            {
                lbLengthFrom.Text = Group + Symbol;
            }
            else if (Display == "To")
            {
                lbLengthTo.Text = Group + Symbol;
            }
        }

        //Saving Number
        private void BtnSaveLength_Click(object sender, EventArgs e)
        {
            SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbLengthTo.Text, decimal.Parse(lbLengthPower.Text));
            array[2] = sigFigStruct.Orginal;
            MessageBox.Show("The Length that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
        }

        //Help Option
        private void BtnLengthQuestion_Click(object sender, EventArgs e)
        {
            LengthHelp lengthHelp = new LengthHelp();
            lengthHelp.ShowDialog();
        }
        

        //Convert Time


        //Oppening Time tab and reset previous result
        private void BtnTime_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabConvertTime;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
        }

        private void BtnTimeReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save
        private void BtnTimePrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentTime;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentTime.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbTimeWorkingOut.Text, "Time");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentTime_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbTimeWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Time Convert
        private void BtnConvertTime_Click(object sender, EventArgs e)
        {
            //check if used save number
            decimal Second;
            if (tbSecond.Text == ("Time"))
            {
                Second = array[3];
            }
            else if (string.IsNullOrWhiteSpace(tbSecond.Text))
            {
                Second = 0;
            }
            else
            {
                Decimal.TryParse(tbSecond.Text, out Second);
            }

            //setting varriables
            decimal Hour;
            decimal Minute;

            //Hour
            if (string.IsNullOrWhiteSpace(tbHour.Text))
            {
                Hour = 0;
            }
            else
            {
                Decimal.TryParse(tbHour.Text, out Hour);
            }

            //Minute
            if (string.IsNullOrWhiteSpace(tbMinute.Text))
            {
                Minute = 0;
            }
            else
            {
                Decimal.TryParse(tbMinute.Text, out Minute);
            }

            //if (Minute >= )
            //Calculating for Convert Time
            //Hour
            //Setting Varriables
            decimal HourMinute = 0;
            decimal HourSecond = 0;
            string DisplayHour = "";
            //Calculating
            HourMinute = Minute / 60;
            HourSecond = Second / 3600;
            //Displaying
            DisplayHour = (Hour + HourMinute + HourSecond).ToString("#.##");

            //Minute
            //Setting Varriables
            decimal MinuteHour = 0;
            decimal MinuteSecond = 0;
            string DisplayMinute = "";
            //Calculating
            MinuteHour = Hour * 60;
            MinuteSecond = Second / 60;
            //Displaying
            DisplayMinute = (Minute + MinuteSecond + MinuteHour).ToString("#.##");

            //Second
            //Setting Varriables
            decimal SecondHour = 0;
            decimal SecondMinute = 0;
            string DisplaySecond = "";
            //Calculating
            SecondHour = Hour * 3600;
            SecondMinute = Minute * 60;
            //Displaying
            DisplaySecond = (Second + SecondMinute + SecondHour).ToString("#.##");

            //Displaying 
            tbTimeWorkingOut.Text = "Hours:" + Environment.NewLine + "Hours = " + Hour + " + (" + Minute + " / 60)" + " + (" + Second + " / 3600)" + Environment.NewLine + "Hours: " + DisplayHour + Environment.NewLine + Environment.NewLine + "Minutes:" + Environment.NewLine + "Minutes = (" + Hour + " * 60) " + " + " + Minute + " + (" + Second + " / 60)" + Environment.NewLine + "Minutes: " + DisplayMinute + Environment.NewLine + Environment.NewLine + "Seconds:" + Environment.NewLine + "Seconds = (" + Hour + " * 3600) " + " + (" + Minute + " * 60)" + " + " + Second + Environment.NewLine + "Seconds: " + DisplaySecond + Environment.NewLine + Environment.NewLine;
            tbTimeWorkingOut.TextAlign = HorizontalAlignment.Center;

            tbDisplayHour.Text = DisplayHour;
            tbDisplayMinute.Text = DisplayMinute;
            tbDisplaySecond.Text = DisplaySecond;
        }

        //Saving Numbers
        private void BtnTimeSave_Click(object sender, EventArgs e)
        {
            if (tbSecond.Text != "Time")
            {
                decimal SaveVaule = decimal.Parse(tbDisplaySecond.Text);
                array[3] = SaveVaule;
                MessageBox.Show("The Time that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Time'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }
        }

        //Help Option
        private void BtnTimeQuestion_Click(object sender, EventArgs e)
        {
            TimeHelp timeHelp = new TimeHelp();
            timeHelp.ShowDialog();
        }


        //Kinematics 


        //Oppening Kinematics tab and reset previous result
        private void BtnKinematics_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabKinematics;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
        }

        //Reset Vaule
        private void BtnKReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save
        private void BtnKinematicPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentKinematic;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentKinematic.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbKWorkingOut.Text, "Kinematic");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentKinematic_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbKWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Kinematics
        private void BtnKCalculate_Click(object sender, EventArgs e)
        {
            //Disable Save 
            gbKSaveResult.Visible = false;

            // Setting Varriables / check if used save number
            decimal Acceleration = 0;
            decimal FVelocity = 0;
            decimal IVelocity = 0;
            decimal Time = 0;
            decimal Displacement = 0;

            //Substitution Vaule
            //Acceleration
            if (tbKAcceleration.Text == "Acceleration")
            {
                Acceleration = array[1];
            }
            else if (string.IsNullOrWhiteSpace(tbKAcceleration.Text))
            {
                Acceleration = 0;
            }
            else
            {
                Decimal.TryParse(tbKAcceleration.Text, out Acceleration);
            }

            //FVelocity
            if (tbKFVelocity.Text == "Velocity")
            {
                FVelocity = array[4];
            }
            else if (string.IsNullOrWhiteSpace(tbKFVelocity.Text))
            {
                FVelocity = 0;
            }
            else
            {
                Decimal.TryParse(tbKFVelocity.Text, out FVelocity);
            }

            //IVelcoity
            if (tbKIVelocity.Text == "Veloicty")
            {
            }
            else if (string.IsNullOrWhiteSpace(tbKIVelocity.Text))
            {
                IVelocity = 0;
            }
            else
            {
                Decimal.TryParse(tbKIVelocity.Text, out IVelocity);
            }

            //Time
            if (tbKTime.Text == "Time")
            {
                Time = array[3];
            }
            else if (string.IsNullOrWhiteSpace(tbKTime.Text))
            {
                Time = 0;
            }
            else
            {
                Decimal.TryParse(tbKTime.Text, out Time);
            }

            //Displacement
            if (tbKDisplacement.Text == "Length")
            {
                Displacement = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbKDisplacement.Text))
            {
                Displacement = 0;
            }
            else
            {
                Decimal.TryParse(tbKDisplacement.Text, out Displacement);
            }
                        
            //Calculating Kinematics            
            //Caluclating Acceleration
            //Setting Varriables
            string AccelerationWorkingOut = "";

            //Acceleration is enter
            if (Acceleration != 0)
            {
            }
            else
            {
                if (FVelocity != 0 & Time != 0)
                {
                    Acceleration = FVelocity / Time;
                    //Displaying
                    AccelerationWorkingOut = "Acceleration:" + Environment.NewLine + "Acceleration = " + FVelocity + " / " + Time + Environment.NewLine + Environment.NewLine + "Acceleration = " + Acceleration + Environment.NewLine + Environment.NewLine;
                }
                else if (IVelocity != 0 & Time != 0)
                {
                    Acceleration = IVelocity / Time;
                    //Displaying
                    AccelerationWorkingOut = "Acceleration:" + Environment.NewLine + "Acceleration = " + IVelocity + " / " + Time + Environment.NewLine + Environment.NewLine + "Acceleration = " + Acceleration + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & Time != 0)
                {
                    Acceleration = (2 * Displacement) / (decimal)Math.Pow((double)Time, 2);
                    //Displaying
                    AccelerationWorkingOut = "Acceleration:" + Environment.NewLine + "Acceleration = 2 * " + Displacement + " / " + Time + "^2" + Environment.NewLine + Environment.NewLine + "Acceleration = " + Acceleration + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & IVelocity != 0)
                {
                    Acceleration = (decimal)Math.Pow((double)IVelocity, 2) / -(2 * Displacement);
                    //Displaying
                    AccelerationWorkingOut = "Acceleration:" + Environment.NewLine + "Acceleration = -" + IVelocity + " ^ 2 / " + Displacement + Environment.NewLine + Environment.NewLine + "Acceleration = " + Acceleration + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & FVelocity != 0 )
                {
                    Acceleration = (decimal)Math.Pow((double)FVelocity, 2) / (2 * Displacement);
                    //Displaying
                    AccelerationWorkingOut = "Acceleration:" + Environment.NewLine + "Acceleration = " + FVelocity + " ^ 2 / " + Displacement + Environment.NewLine + Environment.NewLine + "Acceleration = " + Acceleration + Environment.NewLine + Environment.NewLine;
                }
            }

            //Calculating Intiail Velocity
            //Setting Varriables
            string IVelocityWorkingOut = "";

            //Initial Velocity enter
            if (IVelocity != 0)
            {
            }
            else
            {
                if (Time != 0 & Acceleration != 0)
                {
                    IVelocity = Acceleration * Time;
                    //Displaying
                    IVelocityWorkingOut = "Initial Velocity" + Environment.NewLine + "Initila Velocity = " + Acceleration + " * " + Time + Environment.NewLine + "Initial Velocity = " + IVelocity + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & Acceleration != 0)
                {
                    IVelocity = -2 * Acceleration * Displacement;
                    //Displaying
                    IVelocityWorkingOut = "Initial Velocity" + Environment.NewLine + "Initila Velocity = -2 * " + Acceleration + " * " + Displacement + Environment.NewLine + "Initial Velocity = " + IVelocity + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & Time != 0)
                {
                    IVelocity = Displacement / Time;
                    //Displaying
                    IVelocityWorkingOut = "Initial Velocity:" + Environment.NewLine + "Initial Velocity = " + Displacement + " / " + Time + Environment.NewLine + "Initial Veloicty = " + IVelocity + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Time
            //Setting Varriables
            string TimeWorkingOut = "";

            //One or Five vaule are inputed
            if (Time != 0)
            {
            }
            else
            {
                if (IVelocity != 0 & Acceleration != 0)
                {
                    Time = IVelocity / Acceleration;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + IVelocity + " / " + Acceleration + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (FVelocity != 0 & Acceleration != 0)
                {
                    Time = FVelocity / Acceleration;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + FVelocity + " / " + Acceleration + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & Acceleration != 0)
                {
                    decimal discriminant  = (2 * Displacement) / Acceleration;
                    if (discriminant  <= 0)
                    {
                        Time = 0;
                    }
                    else
                    {
                        Time = (decimal)Math.Sqrt((double)discriminant );
                    }
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = √(" + "(2 * " + Displacement + " ) /  " + Acceleration + ")" + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (FVelocity != 0 & Displacement != 0)
                {
                    Time = Displacement / FVelocity;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + Displacement + " / " + FVelocity + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & IVelocity != 0)
                {
                    Time = Displacement / IVelocity;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + Displacement + " / " + IVelocity + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Displacement
            //Setting Varriables
            string DisplacementWorkingOut = "";

            //Displacement is enter
            if (Displacement != 0)
            {
            }
            else
            {
                if (IVelocity != 0 & Time != 0)
                {
                    Displacement = IVelocity * Time;
                    //Displaying
                    DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = " + IVelocity + " * " + Time + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
                }
                else if (Acceleration != 0 & Time != 0)
                {
                    Displacement = (decimal)Math.Pow((double)IVelocity, 2) * 0.5m * Acceleration;
                    //Displaying
                    DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = " + "0.5" + " * " + Acceleration + " * " + Time + " ^ 2" + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
                }
                else if (Acceleration != 0 & IVelocity != 0)
                {
                    Displacement = (decimal)Math.Pow((double)IVelocity, 2) / (-2 * Acceleration);
                    //Displaying
                    DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = ( - " + IVelocity + " ^ 2 ) / 2 * " + Acceleration + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
                }
                else if (Acceleration != 0 & FVelocity != 0)
                {
                    Displacement = (decimal)Math.Pow((double)FVelocity, 2) / (2 * Acceleration);
                    //Displaying
                    DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = (" + FVelocity + " ^ 2 ) / 2 * " + Acceleration + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Final Velocity
            //Setting Varriables
            string FVelocityWorkingOut = "";

            //Final Velocity Enter
            if (FVelocity != 0)
            {
            }
            else
            {
                if (Acceleration != 0 & Time != 0)
                {
                    FVelocity = Acceleration * Time;
                    //Displaying
                    FVelocityWorkingOut = "Final Velocity:" + Environment.NewLine + "Final Velocity = " + Acceleration + " * " + Time + Environment.NewLine + "Final Velocity = " + FVelocity + Environment.NewLine + Environment.NewLine;
                }
                else if (Acceleration != 0 & Displacement != 0)
                {
                    FVelocity = 2 * Acceleration * Displacement;
                    //Displaying
                    FVelocityWorkingOut = "Final Velocity:" + Environment.NewLine + "Final Velocity = 2 * " + Acceleration + " * " + Displacement + Environment.NewLine + "Final Velocity = " + FVelocity + Environment.NewLine + Environment.NewLine;
                }
                else if (Displacement != 0 & Time != 0)
                {
                    FVelocity = Displacement / Time;
                    //Displaying
                    FVelocityWorkingOut = "Final Velocity:" + Environment.NewLine + "Final Velocity = " + Displacement + " / " + Time + Environment.NewLine + "Final Velocity = " + FVelocity + Environment.NewLine + Environment.NewLine;
                }
            }

            //Displaying
            //Acceleration
            string ShowAcceleration = Acceleration.ToString();
            if (ShowAcceleration[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Acceleration.ToString());
                tbKAcceleration.Text = sigFigStruct.Output.ToString();
                lbKAccelerationPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowAcceleration[0].ToString() == "-")
            {
                decimal number = Acceleration * -1;
                if (ShowAcceleration[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbKAcceleration.Text = "-" + sigFigStruct.Output.ToString();
                    lbKAccelerationPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowAcceleration[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbKAcceleration.Text = "-" + sigFigStruct.Output.ToString();
                    lbKAccelerationPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else if (ShowAcceleration[0].ToString() != "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Acceleration.ToString());
                tbKAcceleration.Text = sigFigStruct.Output.ToString();
                lbKAccelerationPower.Text = sigFigStruct.Power.ToString();
            }
            //Final Velocity
            string ShowFVelocity = FVelocity.ToString();
            if (ShowFVelocity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(FVelocity.ToString());
                tbKFVelocity.Text = sigFigStruct.Output.ToString();
                lbKFVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowFVelocity[0].ToString() == "-")
            {
                decimal number = FVelocity * -1;
                if (ShowFVelocity[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbKFVelocity.Text = "-" + sigFigStruct.Output.ToString();
                    lbKFVelocityPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowFVelocity[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbKFVelocity.Text = "-" + sigFigStruct.Output.ToString();
                    lbKFVelocityPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else 
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(FVelocity.ToString());
                tbKFVelocity.Text = sigFigStruct.Output.ToString();
                lbKFVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            //Initial Velocity
            string ShowIVelocity = IVelocity.ToString();
            if (ShowIVelocity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(IVelocity.ToString());
                tbKIVelocity.Text = sigFigStruct.Output.ToString();
                lbKIVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowIVelocity[0].ToString() == "-")
            {
                decimal number = IVelocity * -1;
                if (ShowIVelocity[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbKIVelocity.Text = "-" + sigFigStruct.Output.ToString();
                    lbKIVelocityPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowIVelocity[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbKIVelocity.Text = "-" + sigFigStruct.Output.ToString();
                    lbKIVelocityPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else if (ShowIVelocity[0].ToString() != "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(IVelocity.ToString());
                tbKIVelocity.Text = sigFigStruct.Output.ToString();
                lbKIVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            //Time
            string ShowTime = Time.ToString();
            if (ShowTime[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Time.ToString());
                tbKTime.Text = sigFigStruct.Output.ToString();
                lbKTimePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Time.ToString());
                tbKTime.Text = sigFigStruct.Output.ToString();
                lbKTimePower.Text = sigFigStruct.Power.ToString();
            }
            //Displacement
            string ShowDisplacement = Displacement.ToString();
            if (ShowDisplacement[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Displacement.ToString());
                tbKDisplacement.Text = sigFigStruct.Output.ToString();
                lbKDisplacementPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowDisplacement[0].ToString() == "-")
            {
                decimal number = Displacement * -1;
                if (ShowDisplacement[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbKDisplacement.Text = "-" + sigFigStruct.Output.ToString();
                    lbKDisplacementPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowDisplacement[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbKDisplacement.Text = "-" + sigFigStruct.Output.ToString();
                    lbKDisplacementPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else if (ShowDisplacement[0].ToString() != "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Displacement.ToString());
                tbKDisplacement.Text = sigFigStruct.Output.ToString();
                lbKDisplacementPower.Text = sigFigStruct.Power.ToString();
            }
            //Working Out
            tbKWorkingOut.Text = AccelerationWorkingOut + FVelocityWorkingOut + IVelocityWorkingOut + TimeWorkingOut + DisplacementWorkingOut;
            tbKWorkingOut.TextAlign = HorizontalAlignment.Center;

            label102.Visible = true;
            label108.Visible = true;
            label110.Visible = true;
            label106.Visible = true;
            label104.Visible = true;
        }

        //Save Number
        private void BtnKSaveResult_Click(object sender, EventArgs e)
        {
            gbKSaveResult.Visible = true;
        }

        //Save Displacement
        private void BtnKSaveDisplacement_Click(object sender, EventArgs e)
        {
            if (tbKDisplacement.Text != "Length")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbKDisplacement.Text, decimal.Parse(lbKDisplacementPower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Displacement that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbKSaveResult.Visible = false;
        }

        //Save FVelocity
        private void BtnKSaveFVelocity_Click(object sender, EventArgs e)
        {
            if (tbKFVelocity.Text != "Velocity")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbKFVelocity.Text, decimal.Parse(lbKFVelocityPower.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbKSaveResult.Visible = false;
        }

        //Save IVelocity
        private void BtnKSaveIVelocity_Click(object sender, EventArgs e)
        {
            if (tbKFVelocity.Text != "Velocity")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbKIVelocity.Text, decimal.Parse(lbKIVelocityPower.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbKSaveResult.Visible = false;
        }

        //Save Time
        private void BtnKSaveTime_Click(object sender, EventArgs e)
        {
            if (tbKTime.Text != "Time")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbKTime.Text, decimal.Parse(lbKTimePower.Text));
                array[3] = sigFigStruct.Orginal;
                MessageBox.Show("The Time that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Time'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbKSaveResult.Visible = false;
        }

        //Save Acceleration
        private void BtnKSaveAcceleration_Click(object sender, EventArgs e)
        {
            if (tbKAcceleration.Text != "Acceleration")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbKAcceleration.Text, decimal.Parse(lbKAccelerationPower.Text));
                array[1] = sigFigStruct.Orginal;
                MessageBox.Show("The Acceleration that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Acceleration'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbKSaveResult.Visible = false;
        }

        //Help Option
        private void BtnKHelp_Click(object sender, EventArgs e)
        {
            KinematicHelp kinematicHelp = new KinematicHelp();
            kinematicHelp.ShowDialog();

            //Disable Save 
            gbKSaveResult.Visible = false;
        }


        //Dynamimcs


        //Displaying  Option
        private void BtnDynamics_Click(object sender, EventArgs e)
        {
            gbDynamics.Visible = true;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Removing Option
        private void GbMain_MouseHover(object sender, EventArgs e)
        {
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }


        //Forces


        //Oppening Force Tab and reset previous result
        private void BtnForce_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabForces;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnFReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //If No Friction is applied
        private void BtnFNo_Click(object sender, EventArgs e)
        {
            tbFMu.Text = "No Friction";
            tbFFForce.Text = "No Friction";

            //Disable Save 
            gbFSave.Visible = false;
        }

        //Print and Save WorkingOut
        private void BtnForcePrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentForce;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentForce.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbFWorkingOut.Text, "Force");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentForce_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbFWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }
        
        //Calculate Force Page
        private void BtnFCalculate_Click(object sender, EventArgs e)
        {
            //Disable Save 
            gbFSave.Visible = false;

            //Setting Varriable / check if used save number
            decimal NForce = 0;
            decimal Force = 0;
            decimal Mass = 0;
            decimal Acceleration = 0;
            decimal Mu = 0;
            decimal FForce = 0;
            const decimal Gravity = 9.8m;

            //Substitution Vaule
            //Normal/Weight force
            if (tbFNForce.Text == "Force")
            {
                NForce = array[5];
            }
            else if (string.IsNullOrWhiteSpace(tbFNForce.Text))
            {
                NForce = 0;
            }
            else
            {
                Decimal.TryParse(tbFNForce.Text, out NForce);
            }

            //Force
            if (tbFForce.Text == "Force")
            {
                Force = array[5];
            }
            else if (string.IsNullOrWhiteSpace(tbFForce.Text))
            {
                Force = 0;
            }
            else
            {
                Decimal.TryParse(tbFForce.Text, out Force);
            }

            //Mass
            if (tbFMass.Text == "Mass")
            {
                Mass = array[0];
            }
            else if (string.IsNullOrWhiteSpace(tbFMass.Text))
            {
                Mass = 0;
            }
            else
            {
                Decimal.TryParse(tbFMass.Text, out Mass);
            }

            //Acceleration
            if (tbFAcceleration.Text == "Acceleration")
            {
                Acceleration = array[1];
            }
            else if (string.IsNullOrWhiteSpace(tbFAcceleration.Text))
            {
                Acceleration = 0;
            }
            else
            {
                Decimal.TryParse(tbFAcceleration.Text, out Acceleration);
            }

            //Mu
            //if there is no fiction applied
            if (tbFMu.Text == "No Friction")
            {
                Mu = 0;
            }
            else if (string.IsNullOrWhiteSpace(tbFMu.Text))
            {
                Mu = 0;
            }
            else
            {
                Decimal.TryParse(tbFMu.Text, out Mu);
            }

            //Friction Force
            //if there is no fiction applied
            if (tbFFForce.Text == "No Friction")
            {
                FForce = 0;
            }
            else if (string.IsNullOrWhiteSpace(tbFFForce.Text))
            {
                FForce = 0;
            }
            else
            {
                Decimal.TryParse(tbFFForce.Text, out FForce);
            }


            //Calculating Force
            //Calulcating Normal/Weight Force
            //Setting Varriables
            string NForceWorkingOut = "";

            //Normal/Weight Force is enter
            if (NForce != 0)
            {
            }
            else
            {
                if (Mass != 0)
                {
                    NForce = Gravity * Mass;
                    //Displaying
                    NForceWorkingOut = "Normal Force:" + Environment.NewLine + "Normal Force = 9.8 * " + Mass + Environment.NewLine + "Normal Force = " + NForce + Environment.NewLine + Environment.NewLine;
                }
                else if (Mu != 0 & FForce != 0)
                {
                    NForce = FForce / Mu;
                    //Displaying
                    NForceWorkingOut = "Normal Force:" + Environment.NewLine + "Normal Force = " + FForce + " / " + Mu + Environment.NewLine + "Normal Force = " + NForce + Environment.NewLine + Environment.NewLine;
                }
                else if (Force != 0 & Acceleration != 0)
                {
                    decimal sum = Force * Gravity;
                    NForce = sum / Acceleration;
                    //Displaying
                    NForceWorkingOut = "Normal Force:" + Environment.NewLine + "Normal Force = (" + Force + " * 9.8) / " + Acceleration + Environment.NewLine + "Normal Force = " + NForce + Environment.NewLine + Environment.NewLine;
                }
            }


            //Calculating Friction Force
            //Setting Varriables
            string FForceWorkingOut = "";

            //Calculating Friction Force
            if (tbFFForce.Text == "No Friction")
            {
            }
            else if (FForce == 0 & Mu != 0 & NForce != 0)
            {
                FForce = Mu * NForce;
                //Displaying
                string ShowFForce = FForce.ToString();
                if (ShowFForce[0].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(FForce.ToString());
                    tbFFForce.Text = sigFigStruct.Output.ToString();
                    lbFFForcePower.Text = sigFigStruct.Power.ToString();
                }
                else
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(FForce.ToString());
                    tbFFForce.Text = sigFigStruct.Output.ToString();
                    lbFFForcePower.Text = sigFigStruct.Power.ToString();
                }
                FForceWorkingOut = "Friction Force:" + Environment.NewLine + "Friction Force = " + Mu + " * " + NForce + Environment.NewLine + "Friction Force = " + FForce + Environment.NewLine + Environment.NewLine;
            }


            //Calculating Mass
            //Setting Varriables
            string MassWorkingOut = "";

            //Calculating Mass
            if (Mass == 0)
            {
                if (Force != 0 & Acceleration != 0)
                {
                    Mass = Force / Acceleration;
                    //Displaying
                    MassWorkingOut = "Mass:" + Environment.NewLine + "Mass = " + Force + " / " + Acceleration + Environment.NewLine + "Mass = " + Mass + Environment.NewLine + Environment.NewLine;
                }
                else if (NForce != 0)
                {
                    Mass = NForce / Gravity;
                    //Displaying
                    MassWorkingOut = "Mass:" + Environment.NewLine + "Mass = " + NForce + " / 9.8" + Environment.NewLine + "Mass = " + Mass + Environment.NewLine + Environment.NewLine;
                }
            }


            //Calculating Acceleration
            //Setting Varriables
            string AccelerationWorkingOut = "";

            //Calculating Acceleration
            if (Acceleration == 0 & Force != 0 & Mass != 0)
            {
                Acceleration = Force / Mass;
                //Displaying
                MassWorkingOut = "Acceleration:" + Environment.NewLine + "Acceleration = " + Force + " / " + Mass + Environment.NewLine + "Acceleration = " + Acceleration + Environment.NewLine + Environment.NewLine;
            }


            //Calculating Mu
            //Setting Varriables
            string MuWorkingOut = "";

            //Calculating Mu
            if (tbFMu.Text == "No Friction")
            {
            }
            else if (Mu == 0 & FForce != 0 & NForce != 0)
            {
                Mu = FForce / NForce;
                //Displaying
                string ShowMu = Mu.ToString();
                if (ShowMu[0].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Mu.ToString());
                    tbFMu.Text = sigFigStruct.Output.ToString();
                    lbFMuPower.Text = sigFigStruct.Power.ToString();
                }
                else
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Mu.ToString());
                    tbFMu.Text = sigFigStruct.Output.ToString();
                    lbFMuPower.Text = sigFigStruct.Power.ToString();
                }
                MuWorkingOut = "μ:" + Environment.NewLine + "μ = " + FForce + " / " + NForce + Environment.NewLine + "μ = " + Mu + Environment.NewLine + Environment.NewLine;
            }


            //Calculating Force
            //Setting Varriables
            string ForceWorkingOut = "";

            //Calculating Force
            if (Force == 0)
            {
                if (Mass != 0 & Acceleration != 0)
                {
                    Force = Mass * Acceleration;
                    //Displaying
                    ForceWorkingOut = "Force: " + Environment.NewLine + "Force = " + Mass + " * " + Acceleration + Environment.NewLine + "Force = " + Force + Environment.NewLine + Environment.NewLine;
                }
                else if (FForce != 0 & Acceleration == 0)
                {
                    Force = FForce;
                    //Displaying
                    ForceWorkingOut = "Force:" + Environment.NewLine + "Force = " + Force + Environment.NewLine + Environment.NewLine;
                }
            }


            //Displaying
            //Normal Force
            string ShowFNForce = NForce.ToString();
            if (ShowFNForce[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(NForce.ToString());
                tbFNForce.Text = sigFigStruct.Output.ToString();
                lbFNForcePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(NForce.ToString());
                tbFNForce.Text = sigFigStruct.Output.ToString();
                lbFNForcePower.Text = sigFigStruct.Power.ToString();
            }
            //Force
            string ShowForce = Force.ToString();
            if (ShowForce[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Force.ToString());
                tbFForce.Text = sigFigStruct.Output.ToString();
                lbFForcePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Force.ToString());
                tbFForce.Text = sigFigStruct.Output.ToString();
                lbFForcePower.Text = sigFigStruct.Power.ToString();
            }
            //Mass
            string ShowMass = Mass.ToString();
            if (ShowMass[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Mass.ToString());
                tbFMass.Text = sigFigStruct.Output.ToString();
                lbFMassPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Mass.ToString());
                tbFMass.Text = sigFigStruct.Output.ToString();
                lbFMassPower.Text = sigFigStruct.Power.ToString();
            }
            //Acceleration
            string ShowAcceleration = Acceleration.ToString();
            if (ShowAcceleration[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Acceleration.ToString());
                tbFAcceleration.Text = sigFigStruct.Output.ToString();
                lbFAccelerationPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowAcceleration[0].ToString() == "-")
            {
                decimal number = Acceleration * -1;
                if (ShowAcceleration[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbFAcceleration.Text = "-" + sigFigStruct.Output.ToString();
                    lbFAccelerationPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowAcceleration[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbFAcceleration.Text = "-" + sigFigStruct.Output.ToString();
                    lbFAccelerationPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else if (ShowAcceleration[0].ToString() != "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Acceleration.ToString());
                tbFAcceleration.Text = sigFigStruct.Output.ToString();
                lbFAccelerationPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbFWorkingOut.Text = NForceWorkingOut + ForceWorkingOut + MassWorkingOut + AccelerationWorkingOut + MuWorkingOut + FForceWorkingOut;
            tbFWorkingOut.TextAlign = HorizontalAlignment.Center;

            label113.Visible = true;
            label111.Visible = true;
            label117.Visible = true;
            label115.Visible = true;
            label107.Visible = true;
            label103.Visible = true;
        }

        //Save Number       
        private void BtnFSave_Click(object sender, EventArgs e)
        {
            gbFSave.Visible = true;
        }

        //Save Acceleration
        private void BtnFSaveAcceleration_Click(object sender, EventArgs e)
        {
            if (tbFAcceleration.Text != "Acceleration")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbFAcceleration.Text, decimal.Parse(lbFAccelerationPower.Text));
                array[1] = sigFigStruct.Orginal;
                MessageBox.Show("The Acceleration that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Acceleration'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbFSave.Visible = false;
        }

        //Save Force
        private void BtnFSaveForce_Click(object sender, EventArgs e)
        {
            if (tbFForce.Text != "Force")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbFForce.Text, decimal.Parse(lbFForcePower.Text));
                array[5] = sigFigStruct.Orginal;
                MessageBox.Show("The Force that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Force'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbFSave.Visible = false;
        }

        //Save Mass
        private void BtnFSaveMass_Click(object sender, EventArgs e)
        {
            if (tbFMass.Text != "Mass")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbFMass.Text, decimal.Parse(lbFMassPower.Text));
                array[0] = sigFigStruct.Orginal;
                MessageBox.Show("The Mass that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Mass'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbFSave.Visible = false;
        }

        //Save Normal Force
        private void BtnFSaveNForce_Click(object sender, EventArgs e)
        {
            if (tbFNForce.Text != "Force")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbFNForce.Text, decimal.Parse(lbFNForcePower.Text));
                array[5] = sigFigStruct.Orginal;
                MessageBox.Show("The Normal/Weight Force that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Force'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save 
            gbFSave.Visible = false;
        }

        //Displaying if used the right units
        private void BtnFQuestion_Click(object sender, EventArgs e)
        {
            ForceHelp forceHelp = new ForceHelp();
            forceHelp.ShowDialog();

            //Disable Save 
            gbFSave.Visible = false;
        }


        //Energy


        //Oppening Energy Tab and reset previous result
        private void BtnEnergy_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabEnergy;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnEReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save
        private void BtnEnergyPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentEnergy;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentEnergy.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbEWorkingOut.Text, "Energy");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentEnergy_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbEWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Energy Page
        private void BtnECalculate_Click(object sender, EventArgs e)
        {
            //Disable Save
            gbESave.Visible = false;

            //Setting Varraibles / check if number saved
            decimal Work;
            decimal Force;
            decimal Displacement;
            decimal Kinetic;
            decimal Mass;
            decimal Velocity;
            decimal Potential;
            const decimal Gravity = 9.8m;
            decimal Height;

            //Substitution Vaule
            //Displacement
            if (tbEDisplacement.Text == "Length")
            {
                Displacement = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbEDisplacement.Text))
            {
                Displacement = 0;
            }
            else
            {
                Decimal.TryParse(tbEDisplacement.Text, out Displacement);
            }

            //Force
            if (tbEForce.Text == "Force")
            {
                Force = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbEForce.Text))
            {
                Force = 0;
            }
            else
            {
                Decimal.TryParse(tbEForce.Text, out Force);
            }

            //Height
            if (tbEHeight.Text == "Length")
            {
                Height = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbEHeight.Text))
            {
                Height = 0;
            }
            else
            {
                Decimal.TryParse(tbEHeight.Text, out Height);
            }

            //Kinetic
            if (string.IsNullOrWhiteSpace(tbEKinetic.Text))
            {
                Kinetic = 0;
            }
            else
            {
                Decimal.TryParse(tbEKinetic.Text, out Kinetic);
            }

            //Mass
            if (tbEMass.Text == "Mass")
            {
                Mass = array[0];
            }
            else if (string.IsNullOrWhiteSpace(tbEMass.Text))
            {
                Mass = 0;
            }
            else
            {
                Decimal.TryParse(tbEMass.Text, out Mass);
            }

            //Potential
            if (string.IsNullOrWhiteSpace(tbEPotential.Text))
            {
                Potential = 0;
            }
            else
            {
                Decimal.TryParse(tbEPotential.Text, out Potential);
            }

            //Velocity
            if (tbEVelocity.Text == "Velocity")
            {
                Velocity = array[4];
            }
            else if (string.IsNullOrWhiteSpace(tbEVelocity.Text))
            {
                Velocity = 0;
            }
            else
            {
                Decimal.TryParse(tbEVelocity.Text, out Velocity);
            }

            //Work
            if (tbEVelocity.Text == "Work")
            {
                Work = array[7];
            }
            else if (string.IsNullOrWhiteSpace(tbEWork.Text))
            {
                Work = 0;
            }
            else
            {
                Decimal.TryParse(tbEVelocity.Text, out Work);
            }
            
            //Calculating Energy
            //Calculating Kinetic
            //Setting Varaibles
            string KineticWorkingOut = "";

            //Calculating Kinetic
            if (Kinetic == 0 & Velocity != 0)
            {
                if (Mass != 0)
                {
                    Kinetic = (decimal)0.5 * Mass * (decimal)Math.Pow((double)Velocity, 2);
                    //Displaying
                    KineticWorkingOut = "Kinetic:" + Environment.NewLine + "Kinetic = 0.5 * " + Mass + " * " + Velocity + " ^ 2 " + Environment.NewLine + "Kinetic = " + Kinetic + Environment.NewLine + Environment.NewLine;
                }
                else if (Potential != 0 & Height != 0)
                {
                    decimal sum = Potential * (decimal)Math.Pow((double)Velocity, 2);
                    Kinetic = sum / (2 * Gravity * Height);
                    //Displaying
                    KineticWorkingOut = "Kinetic:" + Environment.NewLine + "Kinetic = (" + Potential + " * " + Velocity + " ^ 2 ) / ( 2 * 9.8 * " + Height + ")" + Environment.NewLine + "Kinetic = " + Kinetic + Environment.NewLine + Environment.NewLine;
                }
            }

            //Calculating Potential
            //Setting Varriables
            string PotentialWorkingOut = "";

            //Calculating Potential
            if (Potential == 0 & Height != 0)
            {
                if (Mass != 0)
                {
                    Potential = Mass * Gravity * Height;
                    //Displaying
                    PotentialWorkingOut = "Potential:" + Environment.NewLine + "Potential = " + Mass + " * 9.8 * " + Height + Environment.NewLine + "Potential = " + Potential + Environment.NewLine + Environment.NewLine;
                }
                else if (Kinetic != 0 & Velocity != 0)
                {
                    decimal sum = 2 * Kinetic * Gravity * Height;
                    Potential = sum / (decimal)Math.Pow((double)Velocity, 2);
                    //Displaying
                    PotentialWorkingOut = "Potential:" + Environment.NewLine + "Potential = ( 2 * " + Kinetic + " * 9.8 * " + Height + " )/ " + Velocity + " ^ 2" + Environment.NewLine + "Potential = " + Potential + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Mass
            //Setting Varriables
            string MassWorkingOut = "";

            //Calculating Mass
            if (Mass == 0)
            {
                if (Kinetic != 0 & Velocity != 0)
                {
                    decimal sum = 2 * Kinetic;
                    Mass = sum / (decimal)Math.Pow((double)Velocity, 2);
                    //Displaying
                    MassWorkingOut = "Mass:" + Environment.NewLine + "Mass = (2 * " + Kinetic + ") / " + Velocity + " ^ 2 " + Environment.NewLine + "Mass = " + Mass + Environment.NewLine + Environment.NewLine;
                }
                else if (Potential != 0 & Height != 0)
                {
                    Mass = Potential / (Gravity * Height);
                    //Displaying
                    MassWorkingOut = "Mass:" + Environment.NewLine + "Mass = " + Potential + " / (9.8 * " + Height + ")" + Environment.NewLine + "Mass = " + Mass + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Velocity
            //setting varriables
            string VelocityWorkingOut = "";

            //Calculating Veloicty
            if (Velocity == 0 & Kinetic != 0 & Mass != 0)
            {
                decimal sum = 2 * Kinetic;
                decimal discriminant  = sum / Mass;

                if (discriminant  <= 0)
                {
                    Velocity = 0;
                }
                else
                {
                    Velocity = (decimal)Math.Sqrt((double)discriminant );
                }

                //Displaying
                VelocityWorkingOut = "Velocity:" + Environment.NewLine + "Velocity = √((2 * " + Kinetic + ") / " + Mass + ")" + Environment.NewLine + "Velocity = " + Velocity + Environment.NewLine + Environment.NewLine;
            }
            
            //Caluclating  Height
            //Setting Varriables
            string HeightWorkingOut = "";

            //Calculating Height
            if (Height == 0 & Potential != 0 & Mass != 0)
            {
                Height = Potential / (Mass * Gravity);
                //Displaying
                HeightWorkingOut = "Height:" + Environment.NewLine + "Height = " + Potential + " / (9.8 * " + Mass + ")" + Environment.NewLine + "Height = " + Height + Environment.NewLine + Environment.NewLine;
            }
            
            //Calculating Work
            //Setting Varriables
            string WorkWorkingOut = "";

            //Calculating Work
            if (Work == 0)
            {
                if (Force != 0 & Displacement != 0)
                {
                    Work = Force * Displacement;
                    //Displaying
                    WorkWorkingOut = "Work:" + Environment.NewLine + "Work = " + Force + " * " + Displacement + Environment.NewLine + "Work = " + Work + Environment.NewLine + Environment.NewLine;
                }
                else if (Potential != 0)
                {
                    Work = Potential;
                }
                else if (Kinetic != 0)
                {
                    Work = Kinetic;
                }
            }
            
            //Calculating Force
            //Setting Varriables
            string ForceWorkingOut = "";

            //Calculating Force
            if (Force == 0 & Displacement != 0 & Work != 0)
            {
                Force = Work / Displacement;
                //Displaying
                ForceWorkingOut = "Force:" + Environment.NewLine + "Force = " + Work + " / " + Displacement + Environment.NewLine + "Force = " + Force + Environment.NewLine + Environment.NewLine;
            }
            
            //Calculating Displacement
            //Setting Varriables
            string DisplacementWorkingOut = "";

            //Calculating Displacement
            if (Displacement == 0 & Work != 0 & Force != 0)
            {
                Displacement = Work / Force;
                //Displaying
                DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = " + Work + " / " + Force + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
            }


            //Displaying
            //Displacement
            string ShowDisplacement = Displacement.ToString();
            if (ShowDisplacement[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Displacement.ToString());
                tbEDisplacement.Text = sigFigStruct.Output.ToString();
                lbEDisplacementPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Displacement.ToString());
                tbEDisplacement.Text = sigFigStruct.Output.ToString();
                lbEDisplacementPower.Text = sigFigStruct.Power.ToString();
            }
            //Force
            string ShowForce = Force.ToString();
            if (ShowForce[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Force.ToString());
                tbEForce.Text = sigFigStruct.Output.ToString();
                lbEForcePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Force.ToString());
                tbEForce.Text = sigFigStruct.Output.ToString();
                lbEForcePower.Text = sigFigStruct.Power.ToString();
            }
            //Height
            string ShowHeight = Height.ToString();
            if (ShowHeight[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Height.ToString());
                tbEHeight.Text = sigFigStruct.Output.ToString();
                lbEHeightPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Height.ToString());
                tbEHeight.Text = sigFigStruct.Output.ToString();
                lbEHeightPower.Text = sigFigStruct.Power.ToString();
            }
            //Kinetic
            string ShowKinetic = Kinetic.ToString();
            if (ShowKinetic[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Kinetic.ToString());
                tbEKinetic.Text = sigFigStruct.Output.ToString();
                lbEKineticPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Kinetic.ToString());
                tbEKinetic.Text = sigFigStruct.Output.ToString();
                lbEKineticPower.Text = sigFigStruct.Power.ToString();
            }
            //Mass
            string ShowMass = Mass.ToString();
            if (ShowMass[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Mass.ToString());
                tbEMass.Text = sigFigStruct.Output.ToString();
                lbEMassPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Mass.ToString());
                tbEMass.Text = sigFigStruct.Output.ToString();
                lbEMassPower.Text = sigFigStruct.Power.ToString();
            }
            //Potential
            string ShowPotential = Potential.ToString();
            if (ShowPotential[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Potential.ToString());
                tbEPotential.Text = sigFigStruct.Output.ToString();
                lbEPotentialPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Potential.ToString());
                tbEPotential.Text = sigFigStruct.Output.ToString();
                lbEPotentialPower.Text = sigFigStruct.Power.ToString();
            }
            //Velocity
            string ShowVelocity = Velocity.ToString();
            if (ShowVelocity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Velocity.ToString());
                tbEVelocity.Text = sigFigStruct.Output.ToString();
                lbEVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Velocity.ToString());
                tbEVelocity.Text = sigFigStruct.Output.ToString();
                lbEVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            //Work
            string ShowWork = Work.ToString();
            if (ShowWork[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Work.ToString());
                tbEWork.Text = sigFigStruct.Output.ToString();
                lbEWorkPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Work.ToString());
                tbEWork.Text = sigFigStruct.Output.ToString();
                lbEWorkPower.Text = sigFigStruct.Power.ToString();
            }
            //Working Out
            tbEWorkingOut.Text = KineticWorkingOut + PotentialWorkingOut + MassWorkingOut + VelocityWorkingOut + HeightWorkingOut + ForceWorkingOut + DisplacementWorkingOut;
            tbEWorkingOut.TextAlign = HorizontalAlignment.Center;

            label119.Visible = true;
            label116.Visible = true;
            label112.Visible = true;
            label105.Visible = true;
            label123.Visible = true;
            label121.Visible = true;
            label127.Visible = true;
            label125.Visible = true;
        }

        //Save Number
        private void BtnESaveNumber_Click(object sender, EventArgs e)
        {
            gbESave.Visible = true;
        }

        //Save Height
        private void BtnEHeightSave_Click(object sender, EventArgs e)
        {
            if (tbEHeight.Text != "Length")
            { 
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEHeight.Text, decimal.Parse(lbEHeightPower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Height that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbESave.Visible = false;
        }

        //Save Displacement
        private void BtnEDisplacementSave_Click(object sender, EventArgs e)
        {
            if (tbEDisplacement.Text != "Length")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEDisplacement.Text, decimal.Parse(lbEDisplacementPower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Displacement that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbESave.Visible = false;
        }

        //Save Mass
        private void BtnEMassSave_Click(object sender, EventArgs e)
        {
            if (tbEMass.Text != "Mass")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEMass.Text, decimal.Parse(lbEMassPower.Text));
                array[0] = sigFigStruct.Orginal;
                MessageBox.Show("The Mass that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Mass'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbESave.Visible = false;
        }

        //Save Velocity
        private void BtnEVelocitySave_Click(object sender, EventArgs e)
        {
            if (tbEVelocity.Text != "Velocity")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEVelocity.Text, decimal.Parse(lbEVelocityPower.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbESave.Visible = false;
        }

        //Save Force
        private void BtnEForceSave_Click(object sender, EventArgs e)
        {
            if (tbEForce.Text != "Force")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEForce.Text, decimal.Parse(lbEForcePower.Text));
                array[5] = sigFigStruct.Orginal;
                MessageBox.Show("The Force that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Force'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbESave.Visible = false;
        }

        //Save Work
        private void BtnEWorkSave_Click(object sender, EventArgs e)
        {
            if (tbEWork.Text != "Work")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEWork.Text, decimal.Parse(lbEWorkPower.Text));
                array[7] = sigFigStruct.Orginal;
                MessageBox.Show("The Work that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Work'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbESave.Visible = false;
        }

        //Help Option
        private void BtnESI_Click(object sender, EventArgs e)
        {
            EnergyHelp energyHelp = new EnergyHelp();
            energyHelp.ShowDialog();

            //Disable Save
            gbESave.Visible = false;
        }


        //Wave


        //Displaying Option
        private void BtnWave_Click(object sender, EventArgs e)
        {
            gbWave.Visible = true;
            gbDynamics.Visible = false;
        }


        //Wave Properties


        //Oppening Wave Properties and reset previous result
        private void BtnWaveProperties_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabWaveProperties;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnWReset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        //Print and Save Working Out
        private void BtnPropertiesPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentProperties;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentProperties.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbPropertiesWorkingOut.Text, "Properties");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentProperties_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbPropertiesWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Wave Properties Page
        private void BtnWCalculate_Click(object sender, EventArgs e)
        {
            //Disable Save
            gbPropertiesSave.Visible = false;

            //Setting Varraibles / check if number saved
            decimal WaveNumber;
            decimal Lander;
            decimal Time;
            decimal Frequency;
            decimal Velocity;

            //Substitution Vaule
            //WaveNumber
            if (string.IsNullOrWhiteSpace(tbPropertiesWaveNumber.Text))
            {
                WaveNumber = 0;
            }
            else
            {
                Decimal.TryParse(tbPropertiesWaveNumber.Text, out WaveNumber);
            }

            //Lander
            if (tbPropertiesLander.Text == "Length")
            {
                Lander = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbPropertiesLander.Text))
            {
                Lander = 0;
            }
            else
            {
                Decimal.TryParse(tbPropertiesLander.Text, out Lander);
            }

            //Time
            if (tbPropertiesTime.Text == "Time")
            {
                Time = array[3];
            }
            else if (string.IsNullOrWhiteSpace(tbPropertiesTime.Text))
            {
                Time = 0;
            }
            else
            {
                Decimal.TryParse(tbPropertiesTime.Text, out Time);
            }

            //Frequency
            if (tbPropertiesFrequency.Text == "Frequency")
            {
                Frequency = array[6];
            }
            else if (string.IsNullOrWhiteSpace(tbPropertiesFrequency.Text))
            {
                Frequency = 0;
            }
            else
            {
                Decimal.TryParse(tbPropertiesFrequency.Text, out Frequency);
            }

            //Velocity
            if (tbPropertiesVelocity.Text == "Velocity")
            {
                Velocity = array[4];
            }
            else if (string.IsNullOrWhiteSpace(tbPropertiesVelocity.Text))
            {
                Velocity = 0;
            }
            else
            {
                Decimal.TryParse(tbPropertiesVelocity.Text, out Velocity);
            }
            
            //Calculating Wave Properties
            //Calculating Wave Number
            //Setting Varaibles
            string WaveNumberWorkingOut = "";

            //Calculating Wave Number
            if (WaveNumber == 0)
            {
                if (Lander != 0)
                {
                    decimal sum = 2 * (decimal)Math.PI;
                    WaveNumber = sum / Lander;
                    //Displaying
                    WaveNumberWorkingOut = "Wave Number:" + Environment.NewLine + "Wave Number = (2 * π) / " + Lander + Environment.NewLine + "Wave Number = " + WaveNumber + Environment.NewLine + Environment.NewLine;
                }
                else if (Frequency != 0 & Velocity != 0)
                {
                    decimal sum = 2 * (decimal)Math.PI * Frequency;
                    WaveNumber = sum / Velocity;
                    //Displaying
                    WaveNumberWorkingOut = "Wave Number:" + Environment.NewLine + "Wave Number = (2 * π * " + Frequency + ") / " + Velocity + Environment.NewLine + "Wave Number = " + WaveNumber + Environment.NewLine + Environment.NewLine;
                }
                else if (Time != 0 & Velocity != 0)
                {
                    decimal sum = 2 * (decimal)Math.PI * Velocity;
                    WaveNumber = sum / Time;
                    //Displaying
                    WaveNumberWorkingOut = "Wave Number:" + Environment.NewLine + "Wave Number = (2 * π * " + Velocity + ") / " + Time + Environment.NewLine + "Wave Number = " + WaveNumber + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Time
            //Setting Varaibles
            string TimeWorkingOut = "";

            //Calculating Time
            if (Time == 0)
            {
                if (Frequency != 0)
                {
                    Time = 1 / Frequency;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = 1 / " + Frequency + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (Lander != 0 & Velocity != 0)
                {
                    Time = Lander / Velocity;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + Lander + " / " + Frequency + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (WaveNumber != 0 & Velocity != 0)
                {
                    decimal sum = 2 * (decimal)Math.PI;
                    Time = sum / (WaveNumber * Velocity);
                    //Displaying
                    WaveNumberWorkingOut = "Wave Number:" + Environment.NewLine + "Wave Number = (2 * π * ) / (" + WaveNumber + " * " + Velocity + ")" + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Lander
            //Setting Varaibles
            string LanderWorkingOut = "";

            //Calculating Lander
            if (Lander == 0)
            {
                if (WaveNumber != 0)
                {
                    decimal sum = 2 * (decimal)Math.PI;
                    Lander = sum / WaveNumber;
                    //Displaying
                    LanderWorkingOut = "Lander:" + Environment.NewLine + "Lander = (2 * π) / " + WaveNumber + Environment.NewLine + "Lander = " + Lander + Environment.NewLine + Environment.NewLine;
                }
                else if (Velocity != 0 & Frequency != 0)
                {
                    Lander = Velocity / Frequency;
                    //Displaying
                    LanderWorkingOut = "Lander:" + Environment.NewLine + "Lander = " + Velocity + " / " + Frequency + Environment.NewLine + "Lander = " + Lander + Environment.NewLine + Environment.NewLine;
                }
                else if (Time != 0 & Velocity != 0)
                {
                    Lander = Time * Velocity;
                    //Displaying
                    LanderWorkingOut = "Lander:" + Environment.NewLine + "Lander = " + Time + " * " + Velocity + Environment.NewLine + "Lander = " + Lander + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Frequency
            //Setting Varaibles
            string FrequencyWorkingOut = "";

            //Calculating Frequency
            if (Frequency == 0)
            {
                if (Time != 0)
                {
                    Frequency = 1 / Time;
                    //Displaying
                    FrequencyWorkingOut = "Frequency:" + Environment.NewLine + "Frequency = 1 / " + Time + Environment.NewLine + "Frequency = " + Frequency + Environment.NewLine + Environment.NewLine;
                }
                else if (Velocity != 0 & Lander != 0)
                {
                    Frequency = Velocity / Lander;
                    //Displaying
                    FrequencyWorkingOut = "Frequency:" + Environment.NewLine + "Frequency = " + Velocity + " / " + Lander + Environment.NewLine + "Frequency = " + Frequency + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Velocity
            //Setting Varaibles
            string VelocityWorkingOut = "";

            //Calculating Velocity
            if (Velocity == 0 & Frequency != 0 & Lander != 0)
            {
                Velocity = Frequency * Lander;
                //Displaying
                VelocityWorkingOut = "Velocity:" + Environment.NewLine + "Velocity = " + Frequency + " * " + Lander + Environment.NewLine + "Velocity = " + Velocity + Environment.NewLine + Environment.NewLine;
            }

            //Displaying
            //Frequency
            string ShowFrequency = Frequency.ToString();
            if (ShowFrequency[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Frequency.ToString());
                tbPropertiesFrequency.Text = sigFigStruct.Output.ToString();
                lbPropertiesFrequencyPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Frequency.ToString());
                tbPropertiesFrequency.Text = sigFigStruct.Output.ToString();
                lbPropertiesFrequencyPower.Text = sigFigStruct.Power.ToString();
            }
            //Lander
            string ShowLander = Lander.ToString();
            if (ShowLander[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Lander.ToString());
                tbPropertiesLander.Text = sigFigStruct.Output.ToString();
                lbPropertiesLanderPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Lander.ToString());
                tbPropertiesLander.Text = sigFigStruct.Output.ToString();
                lbPropertiesLanderPower.Text = sigFigStruct.Power.ToString();
            }
            //Time
            string ShowTime = Time.ToString();
            if (ShowTime[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Time.ToString());
                tbPropertiesTime.Text = sigFigStruct.Output.ToString();
                lbPropertiesTimePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Time.ToString());
                tbPropertiesTime.Text = sigFigStruct.Output.ToString();
                lbPropertiesTimePower.Text = sigFigStruct.Power.ToString();
            }
            //Velocity
            string ShowVelocity = Velocity.ToString();
            if (ShowVelocity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Velocity.ToString());
                tbPropertiesVelocity.Text = sigFigStruct.Output.ToString();
                lbPropertiesVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Velocity.ToString());
                tbPropertiesVelocity.Text = sigFigStruct.Output.ToString();
                lbPropertiesVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            //Wave Number
            string ShowWaveNumber = WaveNumber.ToString();
            if (ShowWaveNumber[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(WaveNumber.ToString());
                tbPropertiesWaveNumber.Text = sigFigStruct.Output.ToString();
                lbPropertiesWaveNumberPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(WaveNumber.ToString());
                tbPropertiesWaveNumber.Text = sigFigStruct.Output.ToString();
                lbPropertiesWaveNumberPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbPropertiesWorkingOut.Text = WaveNumberWorkingOut + TimeWorkingOut + LanderWorkingOut + FrequencyWorkingOut + VelocityWorkingOut;
            tbPropertiesWorkingOut.TextAlign = HorizontalAlignment.Center;

            label126.Visible = true;
            label122.Visible = true;
            label118.Visible = true;
            label109.Visible = true;
            label129.Visible = true;
        }

        //Save Number
        private void BtnWSave_Click(object sender, EventArgs e)
        {
            gbPropertiesSave.Visible = true;
        }

        //Save Velocity
        private void BtnWVelocitySave_Click(object sender, EventArgs e)
        {
            if (tbPropertiesVelocity.Text != "Velocity")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbPropertiesVelocity.Text, decimal.Parse(lbPropertiesVelocityPower.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbPropertiesSave.Visible = false;
        }

        //Save Lander
        private void BtnWLanderSave_Click(object sender, EventArgs e)
        {
            if (tbPropertiesLander.Text != "Length")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbPropertiesLander.Text, decimal.Parse(lbPropertiesLanderPower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Lander that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbPropertiesSave.Visible = false;
        }

        //Save Time
        private void BtnWTimeSave_Click(object sender, EventArgs e)
        {
            if (tbPropertiesTime.Text != "Time")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbPropertiesTime.Text, decimal.Parse(lbPropertiesTimePower.Text));
                array[3] = sigFigStruct.Orginal;
                MessageBox.Show("The Time that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Time'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbPropertiesSave.Visible = false;
        }

        //Save Frequency
        private void BtnWFrequencySave_Click(object sender, EventArgs e)
        {
            if (tbPropertiesFrequency.Text != "Frequency")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbPropertiesFrequency.Text, decimal.Parse(lbPropertiesFrequencyPower.Text));
                array[6] = sigFigStruct.Orginal;
                MessageBox.Show("The Frequency that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Frequency'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbPropertiesSave.Visible = false;
        }

        //Help Option
        private void BtnWSI_Click(object sender, EventArgs e)
        {
            PropertiesHelp propertiesHelp = new PropertiesHelp();
            propertiesHelp.Show();

            //Disable Save
            gbPropertiesSave.Visible = false;
        }


        //Sound 


        //Oppening Sound tab and reset previous result
        private void BtnSound_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabSound;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
            pbDopplerEffectMain.Visible = true;
            pbBeatsMain.Visible = true;
        }

        private void PbBeatsMain_Click(object sender, EventArgs e)
        {
            Reset();
            label110.Visible = false;
            label120.Visible = false;
            label130.Visible = false;
            label140.Visible = false;
            label150.Visible = false;

            //Setting Lable and Textbox for Beats
            lbDisplay1.Visible = true;
            lbDisplay2.Visible = true;
            lbDisplay3.Visible = true;
            lbSOption.Visible = true;

            lbDisplay1.Text = "Frequency Beat";
            lbDisplay2.Text = "Frequency 1";
            lbDisplay3.Text = "Frequency 2";
            lbSOption.Text = "Beats";

            tbDisplay1.Visible = true;
            tbDisplay2.Visible = true;
            tbDisplay3.Visible = true;
            tbSoundWorkingOut.Visible = true;

            btnSHelp.Visible = true;
            btnSReset.Visible = true;
            btnSCalculate.Visible = true;
            btnSSave.Visible = true;

            lbDisplay4.Visible = false;
            lbDisplay5.Visible = false;
            tbDisplay4.Visible = false;
            tbDisplay5.Visible = false;
            btnSMedium.Visible = false;
            btnSoundPrintSave.Visible = true;

            lbDisplay1Power.Visible = true;
            lbDisplay2Power.Visible = true;
            lbDisplay3Power.Visible = true;
            lbDisplay4Power.Visible = false;
            lbDisplay5Power.Visible = false;

            lbDisplay110.Visible = true;
            lbDisplay120.Visible = true;
            lbDisplay130.Visible = true;
            lbDisplay140.Visible = false;
            lbDisplay150.Visible = false;

            pbBeatsOption.Visible = true;
            pbDopplerEffectOption.Visible = false;

            //Disable Save
            gbSSave.Visible = false;
            label110.Visible = false;
            label120.Visible = false;
            label130.Visible = false;
            label140.Visible = false;
            label150.Visible = false;
        }

        private void PbDopplerEffectMain_Click(object sender, EventArgs e)
        {
            Reset();
            label110.Visible = false;
            label120.Visible = false;
            label130.Visible = false;
            label140.Visible = false;
            label150.Visible = false;

            //Setting Lable and Textbox for Doppler Effect
            lbDisplay1.Visible = true;
            lbDisplay2.Visible = true;
            lbDisplay3.Visible = true;
            lbDisplay4.Visible = true;
            lbDisplay5.Visible = true;
            lbSOption.Visible = true;


            lbDisplay1.Text = "Observed Frequency";
            lbDisplay2.Text = "Frequency";
            lbDisplay3.Text = "Velocity Wave";
            lbDisplay4.Text = "Veloicty Observer";
            lbDisplay5.Text = "Velocity Source";
            lbSOption.Text = "Doppler";


            tbDisplay1.Visible = true;
            tbDisplay2.Visible = true;
            tbDisplay3.Visible = true;
            tbDisplay4.Visible = true;
            tbDisplay5.Visible = true;
            tbSoundWorkingOut.Visible = true;

            btnSHelp.Visible = true;
            btnSReset.Visible = true;
            btnSCalculate.Visible = true;
            btnSSave.Visible = true;
            btnSMedium.Visible = true;
            btnSoundPrintSave.Visible = true;

            lbDisplay1Power.Visible = true;
            lbDisplay2Power.Visible = true;
            lbDisplay3Power.Visible = true;
            lbDisplay4Power.Visible = true;
            lbDisplay5Power.Visible = true;

            lbDisplay110.Visible = true;
            lbDisplay120.Visible = true;
            lbDisplay130.Visible = true;
            lbDisplay140.Visible = true;
            lbDisplay150.Visible = true;

            pbDopplerEffectOption.Visible = true;
            pbBeatsOption.Visible = false;

            //Disable Save
            gbSSave.Visible = false;
            label110.Visible = false;
            label120.Visible = false;
            label130.Visible = false;
            label140.Visible = false;
            label150.Visible = false;
        }

        //Reset Vaule
        private void BtnSReset_Click(object sender, EventArgs e)
        {
            tbDisplay1.Text = null;
            tbDisplay2.Text = null;
            tbDisplay3.Text = null;
            tbDisplay4.Text = null;
            tbDisplay5.Text = null;
            lbDisplay1Power.Text = null;
            lbDisplay2Power.Text = null;
            lbDisplay3Power.Text = null;
            lbDisplay4Power.Text = null;
            lbDisplay5Power.Text = null;
            tbSoundWorkingOut.Text = null;
            gbSSave.Visible = false;
            label110.Visible = false;
            label120.Visible = false;
            label130.Visible = false;
            label140.Visible = false;
            label150.Visible = false;
        }

        //If user wants speed of sound
        private void BtnSMedium_Click(object sender, EventArgs e)
        {
            tbDisplay3.Text = "Speed of sound.";
        }

        //Print and Save
        private void BtnSoundPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentSound;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentSound.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbSoundWorkingOut.Text, "Sound");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentSound_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbSoundWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        private void BtnSCalculate_Click(object sender, EventArgs e)
        {
            //Disable Save
            gbSSave.Visible = false;
            label110.Visible = true;
            label120.Visible = true;
            label130.Visible = true;
            label140.Visible = true;
            label150.Visible = true;

            //Setting Varriable / check if used save number
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal num4 = 0;
            decimal num5 = 0;

            //Setting Varriable / check if used save number for Doppler Effect
            if (lbSOption.Text == "Doppler")
            {
                //num1
                if (string.IsNullOrWhiteSpace(tbDisplay1.Text))
                {
                    num1 = 0;
                }
                else if (tbDisplay1.Text == "Frequency")
                {
                    num1 = array[6];
                }
                else
                {
                    Decimal.TryParse(tbDisplay1.Text, out num1);
                }

                //num2
                if (string.IsNullOrWhiteSpace(tbDisplay2.Text))
                {
                    num2 = 0;
                }
                else if (tbDisplay2.Text == "Frequency")
                {
                    num2 = array[6];
                }
                else
                {
                    Decimal.TryParse(tbDisplay2.Text, out num2);
                }

                //num3
                if (string.IsNullOrWhiteSpace(tbDisplay3.Text))
                {
                    num3 = 0;
                }
                else if (tbDisplay3.Text == "Speed of sound.")
                {
                    num3 = 340;
                }
                else if (tbDisplay3.Text == "Velocity")
                {
                    num3 = array[4];
                }
                else
                {
                    Decimal.TryParse(tbDisplay3.Text, out num3);
                }

                //num4
                if (string.IsNullOrWhiteSpace(tbDisplay4.Text))
                {
                    num4 = 0;
                }
                else if (tbDisplay4.Text == "Velocity")
                {
                    num4 = array[4];
                }
                else
                {
                    Decimal.TryParse(tbDisplay4.Text, out num4);
                }

                //num5
                if (string.IsNullOrWhiteSpace(tbDisplay5.Text))
                {
                    num5 = 0;
                }
                else if (tbDisplay5.Text == "Velocity")
                {
                    num5 = array[4];
                }
                else
                {
                    Decimal.TryParse(tbDisplay5.Text, out num5);
                }

                //Calculating Doppler effect and Displaying
                DopplerEffect(num1, num2, num3, num4, num5);
            }
            //Setting Varriable / check if used save number for Beats
            else if (lbSOption.Text == "Beats")
            {
                //num1
                if (string.IsNullOrWhiteSpace(tbDisplay1.Text))
                {
                    num1 = 0;
                }
                else if (tbDisplay1.Text == "Frequency")
                {
                    num1 = array[6];
                }
                else
                {
                    Decimal.TryParse(tbDisplay1.Text, out num1);
                }

                //num2
                if (string.IsNullOrWhiteSpace(tbDisplay2.Text))
                {
                    num2 = 0;
                }
                else if (tbDisplay2.Text == "Frequency")
                {
                    num2 = array[6];
                }
                else
                {
                    Decimal.TryParse(tbDisplay2.Text, out num2);
                }

                //num3
                if (string.IsNullOrWhiteSpace(tbDisplay3.Text))
                {
                    num3 = 0;
                }
                else if (tbDisplay3.Text == "Frequency")
                {
                    num3 = array[6];
                }
                else
                {
                    Decimal.TryParse(tbDisplay3.Text, out num3);
                }

                //Calculating Beats and Displaying
                Beats(num1, num2, num3);
            }
        }


        //Doppler Effect 


        public void DopplerEffect(decimal ObservedFrequency, decimal Frequency, decimal VWave, decimal VObserved, decimal VSource)
        {
            //Calculating Doppler Effect
            //Calculating Observed Frequency
            //Setting Varriables
            string OFrequencyWorkingOut = "";

            //Calculating Observed Frequency
            if (ObservedFrequency == 0)
            {
                decimal fraction = (VWave + VObserved) / (VWave - VSource);
                ObservedFrequency = Frequency * fraction;
                //Displaying
                OFrequencyWorkingOut = "Observed Frequency:" + Environment.NewLine + "Observed Frequency = " + Frequency + " * ((" + VWave + " + " + VObserved + ") / (" + VWave + " - " + VSource + "))" + Environment.NewLine + "Observed Frequency = " + ObservedFrequency + Environment.NewLine + Environment.NewLine;
            }


            //Caluclating Frequency
            //Setting Varriables
            string FrequencyWorkingOut = "";

            //Caluclating Frequency
            if (Frequency == 0)
            {
                decimal fraction = (VWave - VSource) / (VWave + VObserved);
                Frequency = ObservedFrequency * fraction;
                //Displaying
                FrequencyWorkingOut = "Frequency:" + Environment.NewLine + "Frequency = " + ObservedFrequency + " * ((" + VWave + " - " + VSource + ") / (" + VWave + " + " + VObserved + "))" + Environment.NewLine + "Frequency = " + Frequency + Environment.NewLine + Environment.NewLine;
            }

            //Calculating Velocity Wave
            //Setting Varriables
            string VWaveWorkingOut = "";

            //Calculating Velocity Wave
            if (VWave == 0)
            {
                decimal sum = ObservedFrequency * VSource + Frequency * VObserved;
                VWave = sum / (ObservedFrequency - Frequency);
                //Displaying
                VWaveWorkingOut = "Velocity Wave:" + Environment.NewLine + "Velocity Wave = " + " * ((" + ObservedFrequency + " * " + VSource + " + " + Frequency + " * " + VObserved + ") / (" + ObservedFrequency + " + " + Frequency + "))" + Environment.NewLine + "Velocity Wave = " + VWave + Environment.NewLine + Environment.NewLine;
            }

            //Calculating Velocity Observed
            //Setting Varriables
            string VObservedWorkingOut = "";

            //Calculating Velocity Observed
            if (VObserved == 0)
            {
                decimal sum = ObservedFrequency * (VWave - VSource);
                decimal fraction = sum / Frequency;
                VObserved = fraction - VWave;
                //Displaying
                VObservedWorkingOut = "Velocity Observed:" + Environment.NewLine + "Velocity Observed = " + " * ((" + ObservedFrequency + " * (" + VWave + " - " + VSource + ") / " + Frequency + ") - " + VWave + Environment.NewLine + "Velocity Observed = " + VObserved + Environment.NewLine + Environment.NewLine;
            }

            //Calculating Velocity Source
            //Setting Varriables
            string VSourceWorkingOut = "";

            //Calculating Velocity Source
            if (VSource == 0)
            {
                decimal sum = ObservedFrequency * VWave - Frequency * (VWave + VObserved);
                VSource = sum / ObservedFrequency;
                //Displaying
                VSourceWorkingOut = "Velocity Source:" + Environment.NewLine + "Velocity Source = (" + ObservedFrequency + " * " + VWave + " -" + Frequency + " * (" + VWave + " + " + VObserved + ")) / " + ObservedFrequency + Environment.NewLine + "Velocity Source = " + VSource + Environment.NewLine + Environment.NewLine;
            }

            //Displaying
            //Display 1
            string ShowDisplay1 = ObservedFrequency.ToString();
            if (ShowDisplay1[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(ObservedFrequency.ToString());
                tbDisplay1.Text = sigFigStruct.Output.ToString();
                lbDisplay1Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(ObservedFrequency.ToString());
                tbDisplay1.Text = sigFigStruct.Output.ToString();
                lbDisplay1Power.Text = sigFigStruct.Power.ToString();
            }
            //Display 2
            string ShowDisplay2 = Frequency.ToString();
            if (ShowDisplay2[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Frequency.ToString());
                tbDisplay2.Text = sigFigStruct.Output.ToString();
                lbDisplay2Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Frequency.ToString());
                tbDisplay2.Text = sigFigStruct.Output.ToString();
                lbDisplay2Power.Text = sigFigStruct.Power.ToString();
            }
            //Display 3
            string ShowDisplay3 = VWave.ToString();
            if (ShowDisplay3[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(VWave.ToString());
                tbDisplay3.Text = sigFigStruct.Output.ToString();
                lbDisplay3Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(VWave.ToString());
                tbDisplay3.Text = sigFigStruct.Output.ToString();
                lbDisplay3Power.Text = sigFigStruct.Power.ToString();
            }
            //Display 4
            string ShowDisplay4 = VObserved.ToString();
            if (ShowDisplay4[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(VObserved.ToString());
                tbDisplay4.Text = sigFigStruct.Output.ToString();
                lbDisplay4Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(VObserved.ToString());
                tbDisplay4.Text = sigFigStruct.Output.ToString();
                lbDisplay4Power.Text = sigFigStruct.Power.ToString();
            }
            //Display 4
            string ShowDisplay5 = VSource.ToString();
            if (ShowDisplay5[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(VSource.ToString());
                tbDisplay5.Text = sigFigStruct.Output.ToString();
                lbDisplay5Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(VSource.ToString());
                tbDisplay5.Text = sigFigStruct.Output.ToString();
                lbDisplay5Power.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbSoundWorkingOut.Text = OFrequencyWorkingOut + FrequencyWorkingOut + VWaveWorkingOut + VObservedWorkingOut + VSourceWorkingOut;
            tbSoundWorkingOut.TextAlign = HorizontalAlignment.Center;
        }


        //Beats


        public void Beats(decimal BeatFrequency, decimal Frequency1, decimal Frequency2)
        {
            //Calculating Beats
            //Calculating Beat Frequency
            //Setting Varriables
            string BFrequencyWorkingOut = "";

            //Calculating Beat Frequency
            if (BeatFrequency == 0)
            {
                BeatFrequency = Math.Abs(Frequency1 - Frequency2);
                //Displaying
                BFrequencyWorkingOut = "Beat Frequency:" + Environment.NewLine + "Beat Frequency = |" + Frequency1 + " - " + Frequency2 + "|" + Environment.NewLine + "Beat Frequency = " + BeatFrequency + Environment.NewLine + Environment.NewLine;
            }

            //Calculating Frequency 1
            //Setting Varriables
            string Frequency1WorkingOut = "";

            //Calculating Frequency 1
            if (Frequency1 == 0)
            {
                Frequency1 = BeatFrequency + Frequency2;
                //Displaying
                Frequency1WorkingOut = "Frequency 1:" + Environment.NewLine + "Postive Frequency 1:" + Environment.NewLine + "Frequency 1 = " + BeatFrequency + " + " + Frequency2 + "Frequency 1 = " + Frequency1 + Environment.NewLine + Environment.NewLine;
            }

            //Calculating Frequency 2
            //Setting Varriables
            string Frequency2WorkingOut = "";

            //Calculating Frequency 2
            if (Frequency2 == 0)
            {
                Frequency2 = BeatFrequency - Frequency1;
                //Displaying
                Frequency2WorkingOut = "Frequency 2:" + Environment.NewLine + "Postive Frequency 2:" + Environment.NewLine + "Frequency 2 = " + BeatFrequency + " - " + Frequency1 + Environment.NewLine + "Frequency 2 = " + Frequency2 + Environment.NewLine + Environment.NewLine;
            }


            //Displaying
            //Display 1
            string ShowDisplay1 = BeatFrequency.ToString();
            if (ShowDisplay1[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(BeatFrequency.ToString());
                tbDisplay1.Text = sigFigStruct.Output.ToString();
                lbDisplay1Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(BeatFrequency.ToString());
                tbDisplay1.Text = sigFigStruct.Output.ToString();
                lbDisplay1Power.Text = sigFigStruct.Power.ToString();
            }
            //Display 2
            string ShowDisplay2 = Frequency1.ToString();
            if (ShowDisplay2[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Frequency1.ToString());
                tbDisplay2.Text = sigFigStruct.Output.ToString();
                lbDisplay2Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Frequency1.ToString());
                tbDisplay2.Text = sigFigStruct.Output.ToString();
                lbDisplay2Power.Text = sigFigStruct.Power.ToString();
            }
            //Display 3
            string ShowDisplay3 = Frequency2.ToString();
            if (ShowDisplay3[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Frequency2.ToString());
                tbDisplay3.Text = sigFigStruct.Output.ToString();
                lbDisplay3Power.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Frequency2.ToString());
                tbDisplay3.Text = sigFigStruct.Output.ToString();
                lbDisplay3Power.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbSoundWorkingOut.Text = BFrequencyWorkingOut + Frequency1WorkingOut + Frequency2WorkingOut;
            tbSoundWorkingOut.TextAlign = HorizontalAlignment.Center;
        }

        //Save For both Doppler Effect and Beats
        private void BtnSSave_Click(object sender, EventArgs e)
        {
            gbSSave.Visible = true;

            //Doppler Effect
            if (lbSOption.Text == "Doppler")
            {
                btnDisplay1.Visible = true;
                btnDisplay2.Visible = true;
                btnDisplay3.Visible = true;
                btnDisplay4.Visible = true;
                btnDisplay5.Visible = true;

                btnDisplay1.Text = "Observed Frequency";
                btnDisplay2.Text = "Frequency";
                btnDisplay3.Text = "Velocity Wave";
                btnDisplay4.Text = "Velocity Observed";
                btnDisplay5.Text = "Velocity Source";
            }
            //Beats
            else if (lbSOption.Text == "Beats")
            {
                btnDisplay1.Visible = true;
                btnDisplay2.Visible = true;
                btnDisplay3.Visible = true;
                btnDisplay4.Visible = false;
                btnDisplay5.Visible = false;

                btnDisplay1.Text = "Beats Frequency";
                btnDisplay2.Text = "Frequency 1";
                btnDisplay3.Text = "Frequency 2";
            }
        }

        //Save Display1
        private void BtnDisplay1_Click(object sender, EventArgs e)
        {
            //Save Doppler Effect - Observed Frequency
            if (lbSOption.Text == "Doppler")
            {
                if (tbDisplay1.Text != "Frequency")
                {
                    SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay1.Text, decimal.Parse(lbDisplay1Power.Text));
                    array[6] = sigFigStruct.Orginal;
                    MessageBox.Show("The Frequency that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Frequency'");
                }
                else
                {
                    MessageBox.Show("Number already saved.");
                }
            }
            //Save Beats - Beats Frequency
            else if (lbSOption.Text == "Beats")
            {
                if (tbDisplay1.Text != "Frequency")
                {
                    SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay1.Text, decimal.Parse(lbDisplay1Power.Text));
                    array[6] = sigFigStruct.Orginal;
                    MessageBox.Show("The Frequency that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Frequency'");
                }
                else
                {
                    MessageBox.Show("Number already saved.");
                }
            }

            //Disable Save
            gbSSave.Visible = false;
        }

        //Save Display2
        private void BtnDisplay2_Click(object sender, EventArgs e)
        {
            //Save Doppler Effect - Frequency
            if (lbSOption.Text == "Doppler")
            {
                if (tbDisplay2.Text != "Frequency")
                {
                    SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay2.Text, decimal.Parse(lbDisplay2Power.Text));
                    array[6] = sigFigStruct.Orginal;
                    MessageBox.Show("The Frequency that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Frequency'");
                }
                else
                {
                    MessageBox.Show("Number already saved.");
                }
            }
            //Save Beats - Frequency1
            else if (lbSOption.Text == "Beats")
            {
                if (tbDisplay2.Text != "Frequency")
                {
                    SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay2.Text, decimal.Parse(lbDisplay2Power.Text));
                    array[6] = sigFigStruct.Orginal;
                    MessageBox.Show("The Frequency that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Frequency'");
                }
                else
                {
                    MessageBox.Show("Number already saved.");
                }
            }

            //Disable Save
            gbSSave.Visible = false;
        }

        //Save Display3
        private void BtnDisplay3_Click(object sender, EventArgs e)
        {
            //Save Doppler Effect - Velocity Wave
            if (lbSOption.Text == "Doppler")
            {
                if (tbDisplay3.Text != "Velocity")
                {
                    SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay3.Text, decimal.Parse(lbDisplay3Power.Text));
                    array[4] = sigFigStruct.Orginal;
                    MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
                }
                else
                {
                    MessageBox.Show("Number already saved.");
                }
            }
            //Save Beats - Frequency2
            else if (lbSOption.Text == "Beats")
            {
                if (tbDisplay3.Text != "Frequency")
                {
                    SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay3.Text, decimal.Parse(lbDisplay3Power.Text));
                    array[6] = sigFigStruct.Orginal;
                    MessageBox.Show("The Frequency that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Frequency'");
                }
                else
                {
                    MessageBox.Show("Number already saved.");
                }
            }

            //Disable Save
            gbSSave.Visible = false;
        }

        //Save Display4
        private void BtnDisplay4_Click(object sender, EventArgs e)
        {
            //Save Doppler Effect - Velocity Observed
            if (tbDisplay4.Text != "Velocity")
            {;
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay4.Text, decimal.Parse(lbDisplay4Power.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbSSave.Visible = false;
        }

        //Save Display5
        private void BtnDisplay5_Click(object sender, EventArgs e)
        {
            //Save Doppler Effect - Velocity Source
            if (tbDisplay5.Text != "Velocity")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbDisplay5.Text, decimal.Parse(lbDisplay5Power.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbSSave.Visible = false;
        }

        //DHelp Option
        private void BtnSSI_Click(object sender, EventArgs e)
        {
            //Doppler Effect
            if (lbSOption.Text == "Doppler")
            {
                DopplerEffectHelp dopplerEffectHelp = new DopplerEffectHelp();
                dopplerEffectHelp.ShowDialog();
            }
            //Beats
            else if (lbSOption.Text == "Beats")
            {
                BeatsHelp beatsHelp = new BeatsHelp();
                beatsHelp.ShowDialog();
            }

            //Disable Save
            gbSSave.Visible = false;
        }


        //Intensity


        //Oppening Intenisty Tabe and reset previous result
        private void BtnIntensity_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabIntensity;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnIReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save WorkingOut
        private void BtnIntensityPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentIntensity;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentIntensity.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbIntensityWorkingOut.Text, "Intenisty");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentIntensity_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbIntensityWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Intenisty Page
        private void BtnICalculate_Click(object sender, EventArgs e)
        {
            //Disable Save
            gbISave.Visible = false;

            //Setting Varriable / check if used save number
            decimal Intensity = 0;
            decimal Power = 0;
            decimal Radis = 0;

            //Substitution Vaule
            //Intensity
            if (string.IsNullOrWhiteSpace(tbIIntensity.Text))
            {
                Intensity = 0;
            }
            else
            {
                Decimal.TryParse(tbIIntensity.Text, out Intensity);
            }

            //Power
            if (tbIPower.Text == "Power")
            {
                Power = array[9];
            }
            else if (string.IsNullOrWhiteSpace(tbIPower.Text))
            {
                Power = 0;
            }
            else
            {
                Decimal.TryParse(tbIPower.Text, out Power);
            }

            //Radis
            if (tbIRadis.Text == "Length")
            {
                Radis = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbIRadis.Text))
            {
                Radis = 0;
            }
            else
            {
                Decimal.TryParse(tbIRadis.Text, out Radis);
            }
            
            //Calculating Intensity
            //Calculating Intensity
            //Setting Varaibles
            string IntensityWorkingOut = "";

            //Calculating Intensity
            if (Intensity == 0 & Radis != 0)
            {
                Intensity = 1 / (decimal)Math.Pow((double)Radis, 2);
                //Displaying
                IntensityWorkingOut = "Intensity:" + Environment.NewLine + "Intenisty = " + "1 / " + Radis + " ^ 2" + Environment.NewLine + "Intenisty = " + Intensity + Environment.NewLine + Environment.NewLine;
            }

            //Calculating Radis
            //Setting Varaibles
            string RadisWorkingOut = "";

            //Calculating Radis
            if (Radis == 0 & Intensity != 0)
            {
                decimal discriminant  = 1 / Intensity;

                if (discriminant  <= 0)
                {
                    Radis = 0;
                }
                else
                {
                    Radis = (decimal)Math.Sqrt((double)discriminant );
                }

                //Displaying
                RadisWorkingOut = "Radis:" + Environment.NewLine + "Radis = √(1 / " + Intensity + ")" + Environment.NewLine + "Radis = " + Radis + Environment.NewLine + Environment.NewLine;
                
            }

            //Calculating Power
            //Setting Varaibles
            string PowerWorkingOut = "";

            //Calculating Power
            if (Power == 0 & Intensity != 0 & Radis != 0)
            {
                Power = Intensity * (decimal)4 * (decimal)Math.PI * (decimal)Math.Pow((double)Radis, 2);
                //Displaying
                PowerWorkingOut = "Power:" + Environment.NewLine + "Power = " + Intensity + " * 4 * π * " + Radis + " ^ 2" + Environment.NewLine + "Power = " + Power + Environment.NewLine + Environment.NewLine;
            }
                       
            //Displaying
            //Intensity
            string ShowIntensity = Intensity.ToString();
            if (ShowIntensity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Intensity.ToString());
                tbIIntensity.Text = sigFigStruct.Output.ToString();
                lbIIntensityPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Intensity.ToString());
                tbIIntensity.Text = sigFigStruct.Output.ToString();
                lbIIntensityPower.Text = sigFigStruct.Power.ToString();
            }
            //Power
            string ShowPower = Power.ToString();
            if (ShowPower[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Power.ToString());
                tbIPower.Text = sigFigStruct.Output.ToString();
                lbIPowerPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Power.ToString());
                tbIPower.Text = sigFigStruct.Output.ToString();
                lbIPowerPower.Text = sigFigStruct.Power.ToString();
            }
            //Radis
            string ShowRadis = Radis.ToString();
            if (ShowRadis[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Radis.ToString());
                tbIRadis.Text = sigFigStruct.Output.ToString();
                lbIRadisPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Radis.ToString());
                tbIRadis.Text = sigFigStruct.Output.ToString();
                lbIRadisPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbIntensityWorkingOut.Text = IntensityWorkingOut + PowerWorkingOut + RadisWorkingOut;
            tbIntensityWorkingOut.TextAlign = HorizontalAlignment.Center;

            label130.Visible = true;
            label114.Visible = true;
            label124.Visible = true;
        }

        //Save Number
        private void BtnISave_Click(object sender, EventArgs e)
        {
            gbISave.Visible = true;
        }

        //Save Radis
        private void BtnIRadisSave_Click(object sender, EventArgs e)
        {
            if (tbIRadis.Text != "Length")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbIRadis.Text, decimal.Parse(lbIRadisPower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Radis that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbISave.Visible = false;
        }

        //Save Power
        private void BtnIPowerSave_Click(object sender, EventArgs e)
        {
            if (tbIPower.Text != "Power")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbIPower.Text, decimal.Parse(lbIPowerPower.Text));
                array[8] = sigFigStruct.Orginal;
                MessageBox.Show("The Power that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Power'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbISave.Visible = false;
        }

        //Help Option
        private void BtnISI_Click(object sender, EventArgs e)
        {
            IntensityHelp intensityHelp = new IntensityHelp();
            intensityHelp.ShowDialog();

            //Disable Save
            gbISave.Visible = false;
        }


        //Light


        //Oppening Light Tab and reset previous result
        private void BtnLight_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabLight;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnLReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save WorkingOut
        private void BtnLightRayPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentLightRay;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentLightRay.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbLIghtWorkingOut.Text, "Light Ray");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentLightRay_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbLIghtWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Light page
        private void BtnLCalculate_Click(object sender, EventArgs e)
        {
            //Setting Varriable / check if used save number
            decimal Index = 0;
            decimal Velocity = 0;
            decimal Critical = 0;
            decimal Light = 0;


            //Substitution Vaule
            //Index
            if (string.IsNullOrWhiteSpace(tbLRIndex.Text))
            {
                Index = 0;
            }
            else
            {
                Decimal.TryParse(tbLRIndex.Text, out Index);
            }

            //Velocity
            if (tbLVelocity.Text == "Velocity")
            {
                Velocity = array[4];
            }
            else if (string.IsNullOrWhiteSpace(tbLVelocity.Text))
            {
                Velocity = 0;
            }
            else
            {
                Decimal.TryParse(tbLVelocity.Text, out Velocity);
            }

            //Critical
            if (string.IsNullOrWhiteSpace(tbLCritical.Text))
            {
                Critical = 0;
            }
            else
            {
                Decimal.TryParse(tbLCritical.Text, out Critical);
            }

            //Speed of Light
            if (rdAir.Checked == true)
            {
                Light = 300000000;
            }
            else if (rdWater.Checked == true)
            {
                Light = 225000000;
            }
            else if (rdIce.Checked == true)
            {
                Light = 229000000;
            }
            else
            {
                Light = 300000000;
            }


            //Calculating Light
            //Calculating Index
            //Setting Varaibles
            string IndexWorkingOut = "";

            //Calculating Index
            if (Index == 0)
            {
                if (Velocity != 0)
                {
                    Index = Light / Velocity;
                    //Displaying
                    IndexWorkingOut = "Reflective Index:" + Environment.NewLine + "Reflective Index = " + Light + " / " + Velocity + Environment.NewLine + "Reflective Index = " + Index + Environment.NewLine + Environment.NewLine;
                }
                else if (Critical != 0)
                {
                    Index = 1 / (decimal)Math.Sin((double)Critical);
                    //Displaying
                    IndexWorkingOut = "Reflective Index:" + Environment.NewLine + "Reflective Index = 1 / sin" + Critical + Environment.NewLine + "Reflective Index = " + Index + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Velocity
            //Setting Varaibles
            string VelocityWorkingOut = "";

            //Calculating Velocity
            if (Velocity == 0 & Index != 0)
            {
                Velocity = Light / Index;
                //Displaying
                VelocityWorkingOut = "Velocity:" + Environment.NewLine + "Velocity = " + Light + " / " + Index + Environment.NewLine + "Velocity = " + Velocity + Environment.NewLine + Environment.NewLine;
            }
            
            //Calculating Critical Angle
            //Setting Varaibles
            string CriticalWorkingOut = "";

            if (Critical == 0 & Index != 0)
            {
                Critical = (decimal)Math.Asin((double)(1 / Index));
                //Displaying
                CriticalWorkingOut = "Critical Angle:" + Environment.NewLine + "Critical Angle = sin^1( 1 / " + Index + ")" + Environment.NewLine + "Critical Angle = " + Critical + Environment.NewLine + Environment.NewLine;
            }

            //Displaying
            //Index
            string ShowIndex = Index.ToString();
            if (ShowIndex[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Index.ToString());
                tbLRIndex.Text = sigFigStruct.Output.ToString();
                lbLIndexPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Index.ToString());
                tbLRIndex.Text = sigFigStruct.Output.ToString();
                lbLIndexPower.Text = sigFigStruct.Power.ToString();
            }
            //Velocity
            string ShowVelocity = Velocity.ToString();
            if (ShowVelocity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Velocity.ToString());
                tbLVelocity.Text = sigFigStruct.Output.ToString();
                lbLVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Velocity.ToString());
                tbLVelocity.Text = sigFigStruct.Output.ToString();
                lbLVelocityPower.Text = sigFigStruct.Power.ToString();
            }
            //Critical
            string ShowCritical = Critical.ToString();
            if (ShowCritical[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Critical.ToString());
                tbLCritical.Text = sigFigStruct.Output.ToString();
                lbLCriticalPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Critical.ToString());
                tbLCritical.Text = sigFigStruct.Output.ToString();
                lbLCriticalPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbLIghtWorkingOut.Text = IndexWorkingOut + VelocityWorkingOut + CriticalWorkingOut;
            tbLIghtWorkingOut.TextAlign = HorizontalAlignment.Center;

            label133.Visible = true;
            label120.Visible = true;
            label131.Visible = true;
        }

        //Save Velocity
        private void BtnLSave_Click(object sender, EventArgs e)
        {
            if (tbLVelocity.Text != "Velocity")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbLVelocity.Text, decimal.Parse(lbLVelocityPower.Text));
                array[4] = sigFigStruct.Orginal;
                MessageBox.Show("The Velocity that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Velocity'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }
        }

        //DHelp Option
        private void BtnLSI_Click(object sender, EventArgs e)
        {
            LightHelp lightHelp = new LightHelp();
            lightHelp.ShowDialog();
        }


        //Thermodynamics


        //Oppening Thermodynamics tab and reset previous result
        private void BtnThermodynamics_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabThermodynamics;
            Reset();
        }

        //Reset Vaule
        private void BtnTReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save WorkingOut
        private void BtnThermodynamicPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentThermodynamic;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentThermodynamic.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbThermodynamicsWorkingOut.Text, "Thermodynamic");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentThermodynamic_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbThermodynamicsWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Thermodynamics Page
        private void BtnTCalculate_Click(object sender, EventArgs e)
        {
            //Setting Varriables / check if saved number used
            decimal Heat = 0;
            decimal Mass = 0;
            decimal Capacity = 0;
            decimal Temperature = 0;
            decimal Latent = 0;

            //Substitution Vaule
            //Heat
            if (string.IsNullOrWhiteSpace(tbTHeat.Text))
            {
                Heat = 0;
            }
            else
            {
                Decimal.TryParse(tbTHeat.Text, out Heat);
            }

            //Mass
            if (tbTMass.Text == "Mass")
            {
                Mass = array[0];
            }
            else if (string.IsNullOrWhiteSpace(tbTMass.Text))
            {
                Mass = 0;
            }
            else
            {
                Decimal.TryParse(tbTMass.Text, out Mass);
            }

            //Capacity
            if (string.IsNullOrWhiteSpace(tbTCapacity.Text))
            {
                Capacity = 0;
            }
            else
            {
                Decimal.TryParse(tbTCapacity.Text, out Capacity);
            }

            //Temperature
            if (string.IsNullOrWhiteSpace(tbTTemperature.Text))
            {
                Temperature = 0;
            }
            else
            {
                Decimal.TryParse(tbTTemperature.Text, out Temperature);
            }

            //Latent
            if (string.IsNullOrWhiteSpace(tbTLatent.Text))
            {
                Latent = 0;
            }
            else
            {
                Decimal.TryParse(tbTLatent.Text, out Latent);
            }
            
            //Calculating Thermodynamics
            //Calculating Heat Energy
            //Setting Varaibles
            string HeatWworkingOut = "";

            //Calculating Heat Energy
            if (Heat == 0 & Mass != 0)
            {
                if (Capacity != 0 & Temperature != 0)
                {
                    Heat = Mass * Capacity * Temperature;
                    //Displaying
                    HeatWworkingOut = "Heat Energy:" + Environment.NewLine + "Heat Energy = " + Mass + " * " + Capacity + " * " + Temperature + Environment.NewLine + "Heat Energy = " + Heat + Environment.NewLine + Environment.NewLine;
                }
                else if (Latent != 0)
                {
                    Heat = Mass * Latent;
                    //Displaying
                    HeatWworkingOut = "Heat Energy:" + Environment.NewLine + "Heat Energy = " + Mass + " * " + Latent + Environment.NewLine + "Heat Energy = " + Heat + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Mass
            //Setting Varaibles
            string MassWorkingOut = "";

            //Calculating Mass
            if (Mass == 0 & Heat != 0)
            {
                if (Capacity != 0 & Temperature != 0)
                {
                    Mass = Heat / (Capacity * Temperature);
                    //Displaying
                    MassWorkingOut = "Mass:" + Environment.NewLine + "Mass = " + Heat + " / (" + Capacity + " * " + Temperature + ")" + Environment.NewLine + "Mass = " + Mass + Environment.NewLine + Environment.NewLine;
                }
                else if (Latent != 0)
                {
                    Mass = Heat / Latent;
                    //Displaying
                    MassWorkingOut = "Mass:" + Environment.NewLine + "Mass = " + Heat + " / " + Latent + Environment.NewLine + "Mass = " + Mass + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Specfic Heat Capacity
            //Setting Varaibles
            string CapacityWorkingOut = "";

            //Calculating Specfic Heat Capacity
            if (Capacity == 0 & Heat != 0 & Mass != 0 & Temperature != 0)
            {
                Capacity = Heat / (Mass * Temperature);
                //Displaying
                CapacityWorkingOut = "Specfic Heat Capacity:" + Environment.NewLine + "Specfic Heat Capacity = " + Heat + " / (" + Mass + " * " + Temperature + ")" + Environment.NewLine + "Specfic Heat Capacity = " + Capacity + Environment.NewLine + Environment.NewLine;
            }
            
            //Calculating Temperature
            //Setting Varaibles
            string TemperatureWorkingOut = "";

            //Calculating Temperature
            if (Temperature == 0 & Heat != 0 & Mass != 0 & Capacity != 0)
            {
                Temperature = Heat / (Mass * Capacity);
                //Displaying
                TemperatureWorkingOut = "Temperature:" + Environment.NewLine + "Temperature = " + Heat + " / (" + Mass + " * " + Capacity + ")" + Environment.NewLine + "Temperature = " + Temperature + Environment.NewLine + Environment.NewLine;
            }
            
            //Calculating Specfic Latent Heat
            //Setting Varaibles
            string LatentWorkingOut = "";

            //Calculating Specfic Latent Heat
            if (Latent == 0 & Heat != 0 & Mass != 0)
            {
                Latent = Heat / Mass;
                //Displaying
                LatentWorkingOut = "Specfic Latent Heat:" + Environment.NewLine + "Specfic Latent Heat = " + Heat + " / " + Mass + Environment.NewLine + "Specfic Latent Heat = " + Latent + Environment.NewLine + Environment.NewLine;
            }

            //Displaying
            //Heat
            string ShowHeat = Heat.ToString();
            if (ShowHeat[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Heat.ToString());
                tbTHeat.Text = sigFigStruct.Output.ToString();
                lbTHeatPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Heat.ToString());
                tbTHeat.Text = sigFigStruct.Output.ToString();
                lbTHeatPower.Text = sigFigStruct.Power.ToString();
            }
            //Mass
            string ShowMass = Mass.ToString();
            if (ShowMass[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Mass.ToString());
                tbTMass.Text = sigFigStruct.Output.ToString();
                lbTMassPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Mass.ToString());
                tbTMass.Text = sigFigStruct.Output.ToString();
                lbTMassPower.Text = sigFigStruct.Power.ToString();
            }
            //Capacity
            string ShowCapacity = Capacity.ToString();
            if (ShowCapacity[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Capacity.ToString());
                tbTCapacity.Text = sigFigStruct.Output.ToString();
                lbTCapacityPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Capacity.ToString());
                tbTCapacity.Text = sigFigStruct.Output.ToString();
                lbTCapacityPower.Text = sigFigStruct.Power.ToString();
            }
            //Temperature
            string ShowTemperature = Temperature.ToString();
            if (ShowTemperature[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Temperature.ToString());
                tbTTemperature.Text = sigFigStruct.Output.ToString();
                lbTTemperaturePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Temperature.ToString());
                tbTTemperature.Text = sigFigStruct.Output.ToString();
                lbTTemperaturePower.Text = sigFigStruct.Power.ToString();
            }
            //Latent
            string ShowLatent = Latent.ToString();
            if (ShowLatent[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Latent.ToString());
                tbTLatent.Text = sigFigStruct.Output.ToString();
                lbTLatentPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Latent.ToString());
                tbTLatent.Text = sigFigStruct.Output.ToString();
                lbTLatentPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbThermodynamicsWorkingOut.Text = HeatWworkingOut + MassWorkingOut + CapacityWorkingOut + TemperatureWorkingOut + LatentWorkingOut;
            tbThermodynamicsWorkingOut.TextAlign = HorizontalAlignment.Center;

            label140.Visible = true;
            label128.Visible = true;
            label134.Visible = true;
            label136.Visible = true;
            label138.Visible = true;
        }

        //Save Mass
        private void BtnTSave_Click(object sender, EventArgs e)
        {
            if (tbTMass.Text != "Mass")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbTMass.Text, decimal.Parse(lbTMassPower.Text));
                array[0] = sigFigStruct.Orginal;
                MessageBox.Show("The Mass that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Mass'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }
        }

        //Help Option
        private void BtnTSi_Click(object sender, EventArgs e)
        {
            ThermodynamicHelp thermodynamicHelp = new ThermodynamicHelp();
            thermodynamicHelp.ShowDialog();
        }

        
        //Electricity and Magnetism


        //Displaying Option
        private void BtnElectricity_Click(object sender, EventArgs e)
        {
            gbElectricity.Visible = true;
            gbDynamics.Visible = false;
            gbWave.Visible = false;
        }


        //Electric Field


        //Oppening Electric Field Tab and reset previous result
        private void BtnField_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabElectricField;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnEFReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save WorkingOut
        private void BtnFieldPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentField;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentField.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbFieldWorkingOut.Text, "Field");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentField_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbFieldWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculating Field Page
        private void BtnEFCalculate_Click(object sender, EventArgs e)
        {
            //Disable Save
            gbEFSave.Visible = false;

            //Setting Varriables / check if save number used
            decimal Force = 0;
            decimal ElectricField = 0;
            decimal Volt = 0;
            decimal Work = 0;
            decimal Displacement = 0;
            decimal Charge = 0;

            //Substitution Vaule
            //Force
            if (tbEFForce.Text == "Force")
            {
                Force = array[5];
            }
            else if (string.IsNullOrWhiteSpace(tbEFForce.Text))
            {
                Force = 0;
            }
            else
            {
                Decimal.TryParse(tbEFForce.Text, out Force);
            }

            //Electric Field
            if (string.IsNullOrWhiteSpace(tbEFEField.Text))
            {
                ElectricField = 0;
            }
            else
            {
                Decimal.TryParse(tbEFEField.Text, out ElectricField);
            }

            //Volt
            if (tbEFVolt.Text == "Volt")
            {
                Volt = array[9];
            }
            else if (string.IsNullOrWhiteSpace(tbEFVolt.Text))
            {
                Volt = 0;
            }
            else
            {
                Decimal.TryParse(tbEFVolt.Text, out Volt);
            }

            //Work
            if (tbEFWork.Text == "Work")
            {
                Work = array[7];
            }
            else if (string.IsNullOrWhiteSpace(tbEFWork.Text))
            {
                Work = 0;
            }
            else
            {
                Decimal.TryParse(tbEFWork.Text, out Work);
            }

            //Displacement
            if (tbEFDisplacement.Text == "Length")
            {
                Displacement = array[2];
            }
            else if (string.IsNullOrWhiteSpace(tbEFDisplacement.Text))
            {
                Displacement = 0;
            }
            else
            {
                Decimal.TryParse(tbEFDisplacement.Text, out Displacement);
            }

            //Charge
            if (rdElectron.Checked == true)
            {
                Charge = -0.00000000000000000016m;
            }
            else if (rdProtron.Checked == true)
            {
                Charge = 0.00000000000000000016m;
            }
            else
            {
                Charge = 0.00000000000000000016m;
            }
            
            //Calculating Electric Field
            //Calculating Electric Field
            //Setting Varaibles
            string FieldWorkingOut = "";

            //Calculating Electric Field
            if (ElectricField == 0)
            {
                if (Force != 0)
                {
                    ElectricField = Force / Charge;
                    //Displaying
                    FieldWorkingOut = "Electric Field:" + Environment.NewLine + "Electric Field = " + Force + " / " + Charge + Environment.NewLine + "Electric Field = " + ElectricField + Environment.NewLine + Environment.NewLine;
                }
                else if (Volt != 0 & Displacement != 0)
                {
                    ElectricField = (Volt / Displacement);
                    //Displaying
                    FieldWorkingOut = "Electric Field:" + Environment.NewLine + "Electric Field = " + Volt + " / " + Displacement + Environment.NewLine + "Electric Field = " + ElectricField + Environment.NewLine + Environment.NewLine;
                }
                else if (Work != 0 & Displacement != 0)
                {
                    ElectricField = Work / (Charge * Displacement);
                    //Displaying
                    FieldWorkingOut = "Electric Field:" + Environment.NewLine + "Electric Field = " + Work + " / (" + Charge + " * " + Displacement + ")" + Environment.NewLine + "Electric Field = " + ElectricField + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Work
            //Setting Varaibles
            string WorkWorkingOut = "";

            //Calculating Work
            if (Work == 0)
            {
                if (Volt != 0)
                {
                    Work = Volt * Charge;
                    //Displaying
                    WorkWorkingOut = "Work:" + Environment.NewLine + "Work = " + Volt + " * " + Charge + Environment.NewLine + "Work = " + Work + Environment.NewLine + Environment.NewLine;
                }
                else if (ElectricField != 0 & Displacement != 0)
                {
                    Work = Charge * ElectricField * Displacement;
                    //Displaying
                    WorkWorkingOut = "Work:" + Environment.NewLine + "Work = " + Charge + " * " + ElectricField + " * " + Displacement + Environment.NewLine + "Work = " + Work + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Volt
            //Setting Varaibles
            string VoltWorkingOut = "";

            //Calculating Volt
            if (Volt == 0)
            {
                if (Work != 0)
                {
                    Volt = Work / Charge;
                    //Displaying
                    VoltWorkingOut = "Volt:" + Environment.NewLine + "Volt = " + Work + " / " + Charge + Environment.NewLine + "Volt = " + Volt + Environment.NewLine + Environment.NewLine;
                }
                else if (ElectricField != 0 & Displacement != 0)
                {
                    Volt = ElectricField * Displacement;
                    //Displaying
                    VoltWorkingOut = "Volt:" + Environment.NewLine + "Volt = " + ElectricField + " * " + Displacement + Environment.NewLine + "Volt = " + Volt + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Displacement
            //Setting Varaibles
            string DisplacementWorkingOut = "";

            //Calculating Displacement
            if (Displacement == 0)
            {
                if (ElectricField != 0 & Volt != 0)
                {
                    Displacement = ElectricField * Volt;
                    //Displaying
                    DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = " + ElectricField + " * " + Volt + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
                }
                else if (Work != 0 & ElectricField != 0)
                {
                    Displacement = Work / (Charge * ElectricField);
                    //Displaying
                    DisplacementWorkingOut = "Displacement:" + Environment.NewLine + "Displacement = " + Work + " / (" + Charge + " * " + ElectricField + ")" + Environment.NewLine + "Displacement = " + Displacement + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Force
            //Setting Varaibles
            string ForceWorkingOut = "";

            //Calculating Force
            if (Force == 0 & ElectricField != 0)
            {
                Force = ElectricField * Charge;
                //Displaying
                ForceWorkingOut = "Force:" + Environment.NewLine + "Force = " + ElectricField + " * " + Charge + Environment.NewLine + "Force = " + Force + Environment.NewLine + Environment.NewLine;
            }

            //Displaying
            //Displacement
            string ShowDisplacement = Displacement.ToString();
            if (ShowDisplacement[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Displacement.ToString());
                tbEFDisplacement.Text = sigFigStruct.Output.ToString();
                lbEFDisplacementPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowDisplacement[0].ToString() == "-")
            {
                decimal number = Displacement * -1;
                if (ShowDisplacement[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbEFDisplacement.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFDisplacementPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowDisplacement[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbEFDisplacement.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFDisplacementPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Displacement.ToString());
                tbEFDisplacement.Text = sigFigStruct.Output.ToString();
                lbEFDisplacementPower.Text = sigFigStruct.Power.ToString();
            }
            //Electric Field
            string ShowElectricField = ElectricField.ToString();
            if (ShowElectricField[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(ElectricField.ToString());
                tbEFEField.Text = sigFigStruct.Output.ToString();
                lbEFEFieldPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowElectricField[0].ToString() == "-")
            {
                decimal number = ElectricField * -1;
                if (ShowElectricField[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbEFEField.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFEFieldPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowElectricField[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbEFEField.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFEFieldPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(ElectricField.ToString());
                tbEFEField.Text = sigFigStruct.Output.ToString();
                lbEFEFieldPower.Text = sigFigStruct.Power.ToString();
            }
            //Force
            string ShowForce = Force.ToString();
            if (ShowForce[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Force.ToString());
                tbEFForce.Text = sigFigStruct.Output.ToString();
                lbEFForcePower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowForce[0].ToString() == "-")
            {
                decimal number = Force * -1;
                if (ShowForce[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbEFForce.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFForcePower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowForce[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbEFForce.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFForcePower.Text = sigFigStruct.Power.ToString();
                }
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Force.ToString());
                tbEFForce.Text = sigFigStruct.Output.ToString();
                lbEFForcePower.Text = sigFigStruct.Power.ToString();
            }
            //Volt
            string ShowVolt = Volt.ToString();
            if (ShowVolt[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Volt.ToString());
                tbEFVolt.Text = sigFigStruct.Output.ToString();
                lbEFVoltPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowVolt[0].ToString() == "-")
            {
                decimal number = Volt * -1;
                if (ShowVolt[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbEFVolt.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFVoltPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowVolt[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbEFVolt.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFVoltPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Volt.ToString());
                tbEFVolt.Text = sigFigStruct.Output.ToString();
                lbEFVoltPower.Text = sigFigStruct.Power.ToString();
            }
            //Work
            string ShowWork = Work.ToString();
            if (ShowWork[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Work.ToString());
                tbEFWork.Text = sigFigStruct.Output.ToString();
                lbEFWorkPower.Text = sigFigStruct.Power.ToString();
            }
            else if (ShowWork[0].ToString() == "-")
            {
                decimal number = Work * -1;
                if (ShowWork[1].ToString() == "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(number.ToString());
                    tbEFWork.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFWorkPower.Text = sigFigStruct.Power.ToString();
                }
                else if (ShowWork[1].ToString() != "0")
                {
                    SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(number.ToString());
                    tbEFWork.Text = "-" + sigFigStruct.Output.ToString();
                    lbEFWorkPower.Text = sigFigStruct.Power.ToString();
                }
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Work.ToString());
                tbEFWork.Text = sigFigStruct.Output.ToString();
                lbEFWorkPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbFieldWorkingOut.Text = FieldWorkingOut + WorkWorkingOut + VoltWorkingOut + DisplacementWorkingOut + ForceWorkingOut;
            tbFieldWorkingOut.TextAlign = HorizontalAlignment.Center;

            label143.Visible = true;
            label141.Visible = true;
            label137.Visible = true;
            label132.Visible = true;
            label145.Visible = true;
        }

        //Save Number
        private void BtnEFSave_Click(object sender, EventArgs e)
        {
            gbEFSave.Visible = true;
        }

        //Save Volt
        private void BtnEFVoltSave_Click(object sender, EventArgs e)
        {
            if (tbEFVolt.Text != "Volt")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEFVolt.Text, decimal.Parse(lbEFVoltPower.Text));
                array[9] = sigFigStruct.Orginal;
                MessageBox.Show("The Volt that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Volt'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbEFSave.Visible = false;
        }

        //Save Force
        private void BtnEFForceSave_Click(object sender, EventArgs e)
        {
            if (tbEFForce.Text != "Length")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEFForce.Text, decimal.Parse(lbEFForcePower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Force that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Force'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbEFSave.Visible = false;
        }

        //Save Work
        private void BtnEFWorkSave_Click(object sender, EventArgs e)
        {
            if (tbEFWork.Text != "Work")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEFWork.Text, decimal.Parse(lbEFWorkPower.Text));
                array[7] = sigFigStruct.Orginal;
                MessageBox.Show("The Work that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Work'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbEFSave.Visible = false;
        }

        //Save Displacement
        private void BtnEFDisplacementSave_Click(object sender, EventArgs e)
        {
            if (tbEFDisplacement.Text != "Length")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbEFDisplacement.Text, decimal.Parse(lbEFDisplacementPower.Text));
                array[2] = sigFigStruct.Orginal;
                MessageBox.Show("The Displacement that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Length'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbEFSave.Visible = false;
        }

        //Help Option
        private void BtnEFSI_Click(object sender, EventArgs e)
        {
            FieldHelp fieldHelp = new FieldHelp();
            fieldHelp.ShowDialog();

            //Disable Save
            gbEFSave.Visible = false;
        }

        
        //Electric Circuit


        //Oppening Electric Field Tab and reset previous result
        private void BtnCircuit_Click(object sender, EventArgs e)
        {
            PhysicsTab.SelectedTab = tabElectricCircuit;
            Reset();
            gbDynamics.Visible = false;
            gbWave.Visible = false;
            gbElectricity.Visible = false;
        }

        //Reset Vaule
        private void BtnECReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Print and Save WorkingOut
        private void BtnCircuitPrintSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Print Working Out?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                printPhysicsCalculate.Document = printDocumentCircuit;
                if (printPhysicsCalculate.ShowDialog() == DialogResult.OK)
                {
                    printDocumentCircuit.Print();
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Save Working Out?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Save(tbECWorkingOut.Text, "Circuit");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        //Print Document
        private void PrintDocumentCircuit_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbECWorkingOut.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
        }

        //Calculate Circuit Page
        private void BtnECCalculate_Click(object sender, EventArgs e)
        {
            //Disable Save
            gbECSave.Visible = false;

            //Setting Varriables / check if save number used
            decimal Current = 0;
            decimal Time = 0;
            decimal Work = 0;
            decimal Volt = 0;
            decimal Power = 0;
            decimal Resistance = 0;
            decimal Charge = 0.00000000000000000016m;

            //Substitution Vaule
            //Current
            if (string.IsNullOrWhiteSpace(tbECCurrent.Text))
            {
                Current = 0;
            }
            else
            {
                Decimal.TryParse(tbECCurrent.Text, out Current);
            }

            //Time
            if (tbECTime.Text == "Time")
            {
                Time = array[3];
            }
            else if (string.IsNullOrWhiteSpace(tbECTime.Text))
            {
                Time = 0;
            }
            else
            {
                Decimal.TryParse(tbECTime.Text, out Time);
            }

            //Work
            if (tbECWork.Text == "Work")
            {
                Work = array[7];
            }
            else if (string.IsNullOrWhiteSpace(tbECWork.Text))
            {
                Work = 0;
            }
            else
            {
                Decimal.TryParse(tbECWork.Text, out Work);
            }

            //Volt
            if (tbECVolt.Text == "Volt")
            {
                Volt = array[9];
            }
            else if (string.IsNullOrWhiteSpace(tbECVolt.Text))
            {
                Volt = 0;
            }
            else
            {
                Decimal.TryParse(tbECVolt.Text, out Volt);
            }

            //Power
            if (tbECPower.Text == "Power")
            {
                Power = array[8];
            }
            else if (string.IsNullOrWhiteSpace(tbECPower.Text))
            {
                Power = 0;
            }
            else
            {
                Decimal.TryParse(tbECPower.Text, out Power);
            }

            //Resistance
            if (string.IsNullOrWhiteSpace(tbECResistance.Text))
            {
                Resistance = 0;
            }
            else
            {
                Decimal.TryParse(tbECResistance.Text, out Resistance);
            }
            
            //Calculating Electric Circuit
            //Calculating Current
            //Setting Varaibles
            string CurrentWorkingOut = "";

            //Calculating Current
            if (Current == 0)
            {
                if (Time != 0)
                {
                    Current = Charge / Time;
                    //Displaying
                    CurrentWorkingOut = "Current:" + Environment.NewLine + "Current = " + Charge + " / " + Time + Environment.NewLine + "Current = " + Current + Environment.NewLine + Environment.NewLine;
                }
                else if (Power != 0 & Volt != 0)
                {
                    Current = Power / Volt;
                    //Displaying
                    CurrentWorkingOut = "Current:" + Environment.NewLine + "Current = " + Power + " / " + Volt + Environment.NewLine + "Current = " + Current + Environment.NewLine + Environment.NewLine;
                }
                else if (Volt != 0 & Resistance != 0)
                {
                    Current = Volt / Resistance;
                    //Displaying
                    CurrentWorkingOut = "Current:" + Environment.NewLine + "Current = " + Volt + " / " + Resistance + Environment.NewLine + "Current = " + Current + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Volt
            //Setting Varaibles
            string VoltWokingOut = "";

            //Calculating Volt
            if (Volt == 0 & Current != 0)
            {
                if (Work != 0 & Time != 0)
                {
                    Volt = Work / (Current * Time);
                    //Displaying
                    VoltWokingOut = "Volt:" + Environment.NewLine + "Volt = " + Work + " / (" + Current + " * " + Time + ")" + Environment.NewLine + "Volt = " + Volt + Environment.NewLine + Environment.NewLine;
                }
                else if (Power != 0)
                {
                    Volt = Power / Current;
                    //Displaying
                    VoltWokingOut = "Volt:" + Environment.NewLine + "Volt = " + Power + " / " + Current + Environment.NewLine + "Volt = " + Volt + Environment.NewLine + Environment.NewLine;

                }
                else if (Resistance != 0)
                {
                    Volt = Current * Resistance;
                    //Displaying
                    VoltWokingOut = "Volt:" + Environment.NewLine + "Volt = " + Current + " * " + Resistance + Environment.NewLine + "Volt = " + Volt + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Time
            //Setting Varaibles
            string TimeWorkingOut = "";

            //Calculating Time
            if (Time == 0 & Current != 0)
            {
                if (Charge != 0)
                {
                    Time = Charge / Current;
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + Charge + " / " + Current + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
                else if (Work != 0 & Volt != 0)
                {
                    Time = Work / (Volt * Current);
                    //Displaying
                    TimeWorkingOut = "Time:" + Environment.NewLine + "Time = " + Work + " / (" + Volt + " * " + Current + ")" + Environment.NewLine + "Time = " + Time + Environment.NewLine + Environment.NewLine;
                }
            }
            
            //Calculating Work
            //Setting Varaibles
            string WorkWorkingOut = "";

            //Calculating Work
            if (Work == 0 & Time != 0 & Current != 0 & Volt != 0)
            {
                Work = Time * Volt * Current;
                //Displaying
                WorkWorkingOut = "Work:" + Environment.NewLine + "Work = " + Volt + " * " + Current + " * " + Time + Environment.NewLine + "Work = " + Work + Environment.NewLine + Environment.NewLine;
            }
            
            //Calculating Power
            //Setting Varaibles
            string PowerWorkingOut = "";

            //Calculating Power
            if (Power == 0 & Volt != 0 & Current != 0)
            {
                Power = Volt * Current;
                //Displaying
                PowerWorkingOut = "Power:" + Environment.NewLine + "Power = " + Volt + " * " + Current + Environment.NewLine + "Power = " + Power + Environment.NewLine + Environment.NewLine;

            }
            
            //Calculating Resistance
            //Setting Varaibles
            string ResistanceWorkingOut = "";

            if (Volt != 0 & Resistance == 0 & Current != 0)
            {
                Resistance = Volt / Current;
                //Displaying
                ResistanceWorkingOut = "Resistance:" + Environment.NewLine + "Resistance = " + Volt + " / " + Current + Environment.NewLine + "Resistance = " + Resistance + Environment.NewLine + Environment.NewLine;
            }

            //Displaying
            //Current
            string ShowCurrent = Current.ToString();
            if (ShowCurrent[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Current.ToString());
                tbECCurrent.Text = sigFigStruct.Output.ToString();
                lbECCurrentPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Current.ToString());
                tbECCurrent.Text = sigFigStruct.Output.ToString();
                lbECCurrentPower.Text = sigFigStruct.Power.ToString();
            }
            //Power
            string ShowPower = Power.ToString();
            if (ShowPower[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Power.ToString());
                tbECPower.Text = sigFigStruct.Output.ToString();
                lbECPowerPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Power.ToString());
                tbECPower.Text = sigFigStruct.Output.ToString();
                lbECPowerPower.Text = sigFigStruct.Power.ToString();
            }
            //Resistance
            string ShowResistance = Resistance.ToString();
            if (ShowResistance[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Resistance.ToString());
                tbECResistance.Text = sigFigStruct.Output.ToString();
                lbECResistancePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Resistance.ToString());
                tbECResistance.Text = sigFigStruct.Output.ToString();
                lbECResistancePower.Text = sigFigStruct.Power.ToString();
            }
            //Time
            string ShowTime = Time.ToString();
            if (ShowTime[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Time.ToString());
                tbECTime.Text = sigFigStruct.Output.ToString();
                lbECTimePower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Time.ToString());
                tbECTime.Text = sigFigStruct.Output.ToString();
                lbECTimePower.Text = sigFigStruct.Power.ToString();
            }
            //Volt
            string ShowVolt = Volt.ToString();
            if (ShowVolt[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Volt.ToString());
                tbECVolt.Text = sigFigStruct.Output.ToString();
                lbECVoltPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Volt.ToString());
                tbECVolt.Text = sigFigStruct.Output.ToString();
                lbECVoltPower.Text = sigFigStruct.Power.ToString();
            }
            //Work
            string ShowWork = Work.ToString();
            if (ShowWork[0].ToString() == "0")
            {
                SigFigStruct sigFigStruct = SigFigReturnNegativeStruct(Work.ToString());
                tbECWork.Text = sigFigStruct.Output.ToString();
                lbECWorkPower.Text = sigFigStruct.Power.ToString();
            }
            else
            {
                SigFigStruct sigFigStruct = SigFigReturnPostiveStruct(Work.ToString());
                tbECWork.Text = sigFigStruct.Output.ToString();
                lbECWorkPower.Text = sigFigStruct.Power.ToString();
            }
            //WorkingOut
            tbECWorkingOut.Text = CurrentWorkingOut + PowerWorkingOut + ResistanceWorkingOut + TimeWorkingOut + VoltWokingOut + WorkWorkingOut;
            tbECWorkingOut.TextAlign = HorizontalAlignment.Center;

            label148.Visible = true;
            label146.Visible = true;
            label142.Visible = true;
            label135.Visible = true;
            label152.Visible = true;
            label150.Visible = true;
        }

        //Save Number
        private void BtnECSave_Click(object sender, EventArgs e)
        {
            gbECSave.Visible = true;
        }

        //Save Time
        private void BtnECTimeSave_Click(object sender, EventArgs e)
        {
            if (tbECTime.Text != "Time")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbECTime.Text, decimal.Parse(lbECTimePower.Text));
                array[3] = sigFigStruct.Orginal;
                MessageBox.Show("The Time that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Time'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbECSave.Visible = false;
        }

        //Save Work
        private void BtnECWorkSave_Click(object sender, EventArgs e)
        {
            if (tbECWork.Text != "Work")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbECWork.Text, decimal.Parse(lbECWorkPower.Text));
                array[7] = sigFigStruct.Orginal;
                MessageBox.Show("The Work that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Work'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbECSave.Visible = false;
        }

        //Save Power
        private void BtnECPowerSave_Click(object sender, EventArgs e)
        {
            if (tbECPower.Text != "Power")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbECPower.Text, decimal.Parse(lbECPowerPower.Text));
                array[8] = sigFigStruct.Orginal;
                MessageBox.Show("The Power that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Power'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbECSave.Visible = false;
        }

        //Save Volt
        private void BtnECVoltSave_Click(object sender, EventArgs e)
        {
            if (tbECVolt.Text != "Volt")
            {
                SigFigStruct sigFigStruct = SigFigReturnOrginalStruct(tbECVolt.Text, decimal.Parse(lbECVoltPower.Text));
                array[9] = sigFigStruct.Orginal;
                MessageBox.Show("The Volt that was calculated is now saved, when ever you want to use this vaule, in the textbox type 'Volt'");
            }
            else
            {
                MessageBox.Show("Number already saved.");
            }

            //Disable Save
            gbECSave.Visible = false;
        }

        //Help Option
        private void BtnECQuestion_Click(object sender, EventArgs e)
        {
            CircuitHelp circuitHelp = new CircuitHelp();
            circuitHelp.ShowDialog();

            //Disable Save
            gbECSave.Visible = false;
        }
    }
}
