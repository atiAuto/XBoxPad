using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace XBoxM2019
{
    public partial class FormXBoxPad : Form
    {
        XboxPad xbox;
        int mode;
        int submode;

        List<string> listMode = new List<string>();

        private delegate void StringDelegate(Label label, string str);

        private void DelegateFunction(Label label, string str)
        {
            label.Text = str;
        }

        public FormXBoxPad()
        {
            InitializeComponent();
            xbox = new XboxPad();
            xbox.Connect();
            mode = 0;
            submode = 0;

            listMode.Add("MainAxis");
            listMode.Add("Elevator");
            listMode.Add("Tilt_Rotator");
            listMode.Add("Scope_Incubator");

            xbox.JoinEventHandler("BUTTON_START", ChangeModeNext);
            xbox.JoinEventHandler("BUTTON_BACK", ChangeModePrev);
        }

        private void ChangeModeNext(object sender, EventArgs e)
        {
            mode++;
            if (mode > 3) mode = 0;
            this.Invoke(new StringDelegate(DelegateFunction), labelMode, listMode[mode]);

            switch(mode)
            {
                case 0:
                    xbox.JoinEventHandler("AXIS_RIGHT_Right", ArmXRight);
                    xbox.JoinEventHandler("AXIS_RIGHT_Left", ArmXLeft);
                    xbox.JoinEventHandler("AXIS_RIGHT_Up", ArmYBack);
                    xbox.JoinEventHandler("AXIS_RIGHT_Down", ArmYFront);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void ChangeModePrev(object sender, EventArgs e)
        {
            mode--;
            if (mode < 0) mode = 3;
            this.Invoke(new StringDelegate(DelegateFunction), labelMode, listMode[mode]);

            switch (mode)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        /*Stop*/
        private void LeftXStop(object sender, EventArgs e)
        {

        }

        private void LeftXStop(object sender, EventArgs e)
        {

        }

        private void LeftXStop(object sender, EventArgs e)
        {

        }

        /*MainAxix*/
        private void ArmXLeft(object sender, EventArgs e)
        {
            if(xbox!=null)
            {
                /*
                 *if(axisX == null) return;
                 *axisX.ServoOn(true); 
                 * axisX.Jog(-1); or axisX.Jog(+1);
                 */
            }
            Debug.WriteLine("ArmXLeft");
        }
        private void ArmXRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmXRight");
        }
        private void ArmXStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmXStop");
        }

        private void ArmYBack(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmYBack");
        }
        private void ArmYFront(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmYFront");
        }
        private void ArmYStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmYStop");
        }

        /*Gripper*/
        private void ArmGripperZUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmGripperZUp");
        }
        private void ArmGripperZDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmGripperZDown");
        }
        private void ArmGripperZStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmGripperZStop");
        }

        private void ArmGripperRotateRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmGripperRotateRight");
        }
        private void ArmGripperRotateLeft(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmGripperRotateLeft");
        }
        private void ArmGripperRotateStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmGripperRotateStop");
        }

        /*Decapper*/
        private void ArmDecapperZUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmDecapperZUp");
        }
        private void ArmDecapperZDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmDecapperZDown");
        }
        private void ArmDecapperZStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmDecapperZStop");
        }

        private void ArmDecapperRotateLeft(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmDecapperRotateLeft");
        }
        private void ArmDecapperRotateRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmDecapperRotateRight");
        }
        private void ArmDecapperRotateStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmDecapperRotateStop");
        }

        /*Elevator*/
        private void EBox1Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox1Up");
        }
        private void EBox1Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox1Down");
        }
        private void EBox1Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox1Stop");
        }

        private void EBox2Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox2Up");
        }
        private void EBox2Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox2Down");
        }
        private void EBox2Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox2Stop");
        }

        private void EBox3Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox3Up");
        }
        private void EBox3Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox3Down");
        }
        private void EBox3Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox3Stop");
        }

        private void EBox4Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox4Up");
        }
        private void EBox4Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox4Down");
        }
        private void EBox4Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EBox4Stop");
        }

        private void EFlask1Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask1Up");
        }
        private void EFlask1Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask1Down");
        }
        private void EFlask1Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask1Stop");
        }

        private void EFlask2Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask2Up");
        }
        private void EFlask2Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask2Down");
        }
        private void EFlask2Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask2Stop");
        }

        private void EFlask3Up(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask3Up");
        }
        private void EFlask3Down(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask3Down");
        }
        private void EFlask3Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("EFlask3Stop");
        }

        /*Flask Handler*/
        private void FHTilt1North(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHTilt1North");
        }
        private void FHTilt1South(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHTilt1South");
        }
        private void FHTilt1Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHTilt1Stop");
        }

        private void FHRotate1Left(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHRotate1Left");
        }
        private void FHRotate1Right(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHRotate1Right");
        }
        private void FHRotate1Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHRotate1Stop");
        }

        private void FHTilt2North(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHTilt2North");
        }
        private void FHTilt2South(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHTilt2South");
        }
        private void FHTilt2Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHTilt2Stop");
        }

        private void FHRotate2Left(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHRotate2Left");
        }
        private void FHRotate2Right(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHRotate2Right");
        }
        private void FHRotate2Stop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("FHRotate2Stop");
        }

        /*Centrifuge*/
        private void CentrifugeLeft(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("CentrifugeLeft");
        }
        private void CentrifugeRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("CentrifugeRight");
        }
        private void CentrifugeStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("CentrifugeStop");
        }

        /*Microscope*/
        private void MicroscopeXLeft(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeXLeft");
        }
        private void MicroscopeXRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeXRight");
        }
        private void MicroscopeXStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeXStop");
        }

        private void MicroscopeYBack(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeYBack");
        }
        private void MicroscopeYFront(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeYFront");
        }
        private void MicroscopeYStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeYStop");
        }

        private void MicroscopeZUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeZUp");
        }
        private void MicroscopeZDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeZDown");
        }
        private void MicroscopeZStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("MicroscopeZStop");
        }

        /*ArmZ Module*/
        private void ArmZSyringeUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZSyringeUp");
        }
        private void ArmZSyringeDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZSyringeDown");
        }
        private void ArmZSyringeStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZSyringeStop");
        }

        private void ArmZADPUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZADPUp");
        }
        private void ArmZADPDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZADPDown");
        }
        private void ArmZADPStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZADPStop");
        }

        private void ArmZSuctionUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZSuctionUp");
        }
        private void ArmZSuctionDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZSuctionDown");
        }
        private void ArmZSuctionStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZSuctionStop");
        }

        private void ArmZPadUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZPadUp");
        }
        private void ArmZPadDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZPadDown");
        }
        private void ArmZPadStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZPadStop");
        }

        private void ArmZCupUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZCupUp");
        }
        private void ArmZCupDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmXLeft");
        }
        private void ArmZCupDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("ArmZCupStop");
        }

        /*Vision Deck*/
        private void VisionDeckTiltNorth(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("VisionDeckTiltNorth");
        }
        private void VisionDeckTiltSouth(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("VisionDeckTiltSouth");
        }
        private void VisionDeckTiltStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("VisionDeckTiltStop");
        }

        /*Incubator*/
        private void IncubatorArmRotateLeft(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmRotateLeft");
        }
        private void IncubatorArmRotateRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmRotateRight");
        }
        private void IncubatorArmRotateStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmRotateStop");
        }

        private void IncubatorArmZUp(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmZUp");
        }
        private void IncubatorArmZDown(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmZDown");
        }
        private void IncubatorArmZStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmZStop");
        }

        private void IncubatorArmStraightFront(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmStraightFront");
        }
        private void IncubatorArmStraightBack(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmStraightBack");
        }
        private void IncubatorArmStraigtStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorArmStraigtStop");
        }

        private void IncubatorHotelRotateLeft(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorHotelRotateLeft");
        }
        private void IncubatorHotelRotateRight(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorHotelRotateRight");
        }
        private void IncubatorHotelRotateStop(object sender, EventArgs e)
        {
            if (xbox != null)
            {

            }
            Debug.WriteLine("IncubatorHotelRotateStop");
        }
    }
}
