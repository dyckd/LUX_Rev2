// Welcome to my application, LightTestApplication
// Creator: Daniel Dyck (Intern)        
// Creation Date: June 15th, 2016
//
// Disclaimer: https://xkcd.com/1513/
//
// Purpose of application: 
//  Serve as a controller for test Chamber 4, allowing a wing tip light to be rotated
//  around a 2pi steradian plane, letting us collect LUX value from various data points.
//
// REV. LOG
// 6/17/16 : Application achieved core functionality - successfully able to control Test Chamber 4
// 6/17/16 : Hastily tried to achieve multithreading - broke code
// 6/20/16 : Fixed code... removed multithreading... had to disable visual studio hosting process
//          http://stackoverflow.com/questions/2690119/visualstudio2010-debugging-the-process-cannot-access-the-file-because-it-i
//         : Added in Coordinate Search Function
// 6/24/16 : Added functionallity to support homing process
//
// TO ADD:
// 1.0 ) Abort button during run test
//
//
// WORK IN PROGRESS: 
// 1.1 ) Coordinate Search function
//       - Reconcile with Stuart that degree input is intutive. 

using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace Daniels_LightTestApplication
{
    public partial class MainForm : Form
    {
        //comport 7 controls interior which response to @1
        //comport 8 controls exterior which responds to @0

        public SerialPort comport7_interior    = new SerialPort();
        public SerialPort comport8_exterior    = new SerialPort();
        public SerialPort comport2_lightsensor = new SerialPort();
        //static SerialPort comport2_lightsensor;

        // Index Var for for loop
        int jjj = 1;

        public MainForm()
        {
            InitializeComponent();
            
        }

        public void OpenComport7()
        {
            if (comport7_interior.IsOpen)
            {
                Output.AppendText("COM Port 7 is already open! \n");
           } 
            else
            {
                comport7_interior.PortName = "COM7";
                comport7_interior.BaudRate = int.Parse("38400");
                comport7_interior.DataBits = int.Parse("8");
                comport7_interior.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1"); 
                comport7_interior.Parity   = (Parity)Enum.Parse(typeof(Parity), "None");
              
                try
                {
                    comport7_interior.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port 7.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (comport7_interior.IsOpen) Output.AppendText("COM Port 7 Succesfully Opened \n");
            }
        }



        public void
        OpenComport8()
        {
            if (comport8_exterior.IsOpen)
            {
                Output.AppendText("COM Port 8 is already open! \n");
            }
            else
            {
                comport8_exterior.PortName = "COM8";
                comport8_exterior.BaudRate = int.Parse("38400");
                comport8_exterior.DataBits = int.Parse("8");
                comport8_exterior.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comport8_exterior.Parity   = (Parity)Enum.Parse(typeof(Parity), "None");
            
                try
                {
                    comport8_exterior.Open();
                    
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port 8.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (comport8_exterior.IsOpen) Output.AppendText("COM Port 8 Succesfully Opened \n");           
            }
        }

        public void
        OpenComport2()
        // Open Comport 2 for any various light sensor

        {
            if (comport2_lightsensor.IsOpen)
            {
                Output.AppendText("COM Port 2 is already open! \n");
            }
            else
            {
                comport2_lightsensor.PortName = lightsensor_comport.Text;
                comport2_lightsensor.BaudRate = int.Parse("9600");
                comport2_lightsensor.DataBits = int.Parse("8");
                comport2_lightsensor.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comport2_lightsensor.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                comport2_lightsensor.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "XOnXOff");
                comport2_lightsensor.ReadBufferSize = 32;
                comport2_lightsensor.ReadTimeout = 5000;
                comport2_lightsensor.WriteTimeout = 5000;

                try
                {
                    comport2_lightsensor.Open();
                    //readThread.Start();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port 2.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (comport8_exterior.IsOpen) Output.AppendText("COM Port 2 Succesfully Opened \n"); 
            }
        }

        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        //Thread readThread = new Thread(Read);

        public void Read()
        {
            byte[] buffer = new byte[16];
            //while (true)
           // {
                try
                {
                    
                    comport2_lightsensor.Read(buffer, 0, 16);

                    byte[] newByte = buffer.Skip(11).Take(4).ToArray();
                    byte[] decimalplace = buffer.Skip(10).Take(1).ToArray();

                    //int D1 = buffer[1]; //LSB
                    //int D2 = buffer[2];
                    //int D3 = buffer[3];
                    //int D4 = buffer[4]; //MSB
                    //int onlynumber = D1 & D2 & D3 & D4;
                    //string onlynumber_s = Convert.ToString(onlynumber);
                    //luxvalue.Text = onlynumber_s;

                    luxvalue.Text = (Encoding.UTF8.GetString(newByte));
                    decimalplace_output.Text = (Encoding.UTF8.GetString(decimalplace));
                    fu_buffer.Text = (Encoding.UTF8.GetString(buffer));
                    

                }
                catch (TimeoutException) { }
           // }
        }





        public int value { get; set; }

        public bool error { get; set; }

        public bool IsOdd(int jjj)
        {
            return value % 2 != 0;
        }

        //************* BUTTONS *************// 

        private void MainForm_Leave(object sender, EventArgs e)
        {
            comport7_interior.Close();
            comport8_exterior.Close();
            comport2_lightsensor.Close();
            
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            if (!comport7_interior.IsOpen || !comport8_exterior.IsOpen)
            {
                Output.AppendText("You have not opened the COM port yet!\n");
                return;
            }
            else
            {
                // May be possible to replace by using the Home command, need to test @H0, vs @H1 before actually using.
                comport7_interior.Write("@1P0\r");
                comport7_interior.Write("@1G\r");
                comport8_exterior.Write("@0P0\r");
                comport8_exterior.Write("@0G\r");
                Output.AppendText("Homing... \n");
            }
        }

        private void comport_dc_Click(object sender, EventArgs e)
        {
            comport7_interior.Close();
            comport8_exterior.Close();
            comport2_lightsensor.Close();
            Output.AppendText("You have closed the COM ports \n");
            return;
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            if (!comport8_exterior.IsOpen)
            {
                Output.AppendText("You have not opened the COM port yet!\n");
                return;
            }
            else
            {
                // go up 5 degrees
                comport8_exterior.Write("@0N178\r");
                comport8_exterior.Write("@0G\r");
                Output.AppendText("Manually Shifting Up \n");
            }   
        }

        private void dwn_btn_Click(object sender, EventArgs e)
        {
            if (!comport8_exterior.IsOpen)
            {
                Output.AppendText("You have not opened the COM port yet!\n");
                return;
            }
            else
            {
                // go down 5 degrees
                comport8_exterior.Write("@0-\r");
                comport8_exterior.Write("@0N178\r");
                comport8_exterior.Write("@0G\r");
                comport8_exterior.Write("@0+\r");
                Output.AppendText("Manually Shifting Down \n");
            }   
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            if (!comport7_interior.IsOpen)
            {
                Output.AppendText("You have not opened the COM port yet!\n");
                return;
            }
            else
            {
                comport7_interior.Write("@1+\r");
                comport7_interior.Write("@1N178\r");
                comport7_interior.Write("@1G\r");
                Output.AppendText("Manually Shifting Right \n");
            }
        }

        private void lft_btn_Click(object sender, EventArgs e)
        {
            if (!comport7_interior.IsOpen)
            {
                Output.AppendText("You have not opened the COM port yet!\n");
                return;
            }
            else
            {
                comport7_interior.Write("@1-\r");
                comport7_interior.Write("@1N178\r");
                comport7_interior.Write("@1G\r");
                comport7_interior.Write("@1+\r");
                Output.AppendText("Manually Shifting Left \n");
            }

        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            OpenComport2();
            OpenComport7();
            OpenComport8();
        }

        /*
        *LOOP THAT DOES AN AUTOMATED TEST COLLECTING ALL DATA POINTS
        */
        public void btn_runtest_Click(object sender, EventArgs e)
        {
            // Exterior Platform Loop
            Output.AppendText("Starting Test \n");

            for (int i = 0; i <= 3200; i += 178)
            {
                // Interior Platform Loop
                for (int ii = 0; i <= 6400; ii += 178)
                {
                    comport7_interior.Write("@1N178\r");   //change to have actual length?
                    comport7_interior.Write("@1G\r");
                    Output.AppendText("Interior shift 5 degrees \n");

                    Thread.Sleep(4000);

                    // ***********************************************************************************
                    // Read data from compart2_lightsensor, Parse byte, store Lux value, store angle (i,ii)
                    // ***********************************************************************************





                }

                comport8_exterior.Write("@0N178\r");
                comport8_exterior.Write("@0G\r");
                Output.AppendText("Exterior shift 5 degrees \n");

               Thread.Sleep(4000);

               //flip direction for internal
               if (IsOdd(jjj))
               {
                   //
                   comport7_interior.Write("@1-\r");
                   Output.AppendText("Interior switching direction to counter clockwise \n");
                }
                else
                {
                    comport7_interior.Write("@1+\r");
                    Output.AppendText("Interior switching direction to clockwise \n");
                }
                jjj = jjj + 1;

                // ***********************************************************************************
                // Read data from compart2_lightsensor, Parse byte, store Lux value, store angle (i,ii)
                // ***********************************************************************************
            }
            Output.AppendText("Loop Ended \n");
            // manually reverse mount direction
            // repeat the whole double for loop
        
        }

        // Delegate system for reading comport data - code taken from Maxim code
        //delegate void delegateDataReceived(object sender, SerialDataReceivedEventArgs e);

        //private void comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new delegateDataReceived(comport_DataReceived), sender, e);
        //    }
        //    else
        //        Output.AppendText(comport2_lightsensor.ReadExisting());
        //}



        private void goto_btn_Click(object sender, EventArgs e)
        {
            if (!comport7_interior.IsOpen && !comport8_exterior.IsOpen)
            {
                Output.AppendText("You have not opened the COM ports yet!\n");
            }
            else
            {
                // reset direction to clockwise "sudo-verify"
                comport7_interior.Write("@1+\r");
                comport8_exterior.Write("@0+\r");

                // convert input deg to 
                int xsteps = int.Parse(xdeg_txt.Text) * (12800/360) *(-1); // -1 to reverse direction so intutive right = positive is true.
                int ysteps = int.Parse(ydeg_txt.Text) * (12800/360) *(-1);

                string xsteps_string = "@1P" + xsteps + "\r";
                string ysteps_string = "@0P" + ysteps + "\r";

                comport7_interior.Write(xsteps_string);
                comport7_interior.Write("@1G\r");
                comport8_exterior.Write(ysteps_string);
                comport8_exterior.Write("@0G\r");

                Output.AppendText("Homing to " + xdeg_txt.Text + "," + ydeg_txt.Text + "\n");
            }
        }

        private void home_interior_clk_Click(object sender, EventArgs e)
        {
            // interior = comport 7, @1
            if (!comport7_interior.IsOpen)
            {
                Output.AppendText("Port is not open! \n");
            }            
            else
            {
                int rotate = int.Parse(home_interior_text.Text) * 12800 / 360;
                string rotate_debugging = rotate.ToString();
                Output.AppendText("Degrees converted to steps is:" + rotate_debugging + "\n");
                string rotate_st = "@1N" + rotate + "\r";
                Output.AppendText("Command string is: " + rotate_st + "\n");

                comport7_interior.Write("@1+\r"); // sets direction
                comport7_interior.Write(rotate_st); // sets number of steps
                comport7_interior.Write("@1G\r"); // goes 
            }
        }

        private void home_interior_counter_Click(object sender, EventArgs e)
        {
            if (!comport7_interior.IsOpen)
            {
                Output.AppendText("Port is not open!\n");
            }
            else
            {
                int rotate = int.Parse(home_interior_text.Text) * 12800 / 360;
                string rotate_debugging = rotate.ToString();
                Output.AppendText("Degrees converted to steps is:" + rotate_debugging + "\n");
                string rotate_st = "@1N" + rotate + "\r";
                Output.AppendText("Command string is: " + rotate_st + "\n");

                comport7_interior.Write("@1-\r"); // sets direction
                comport7_interior.Write(rotate_st); // sets number of steps
                comport7_interior.Write("@1G\r"); // goes 
            }

        }

        private void home_exterior_clock_Click(object sender, EventArgs e)
        {
            if (!comport8_exterior.IsOpen)
            {
                Output.AppendText("Port is not open! \n");
            }
            else
            {
                int rotate = int.Parse(home_exterior_text.Text) * 12800 / 360;
                string rotate_debugging = rotate.ToString();
                Output.AppendText("Degrees converted to steps is:" + rotate_debugging + "\n");
                string rotate_st = "@0N" + rotate + "\r";
                Output.AppendText("Command string is: " + rotate_st + "\n");

                comport8_exterior.Write("@0+\r");
                comport8_exterior.Write(rotate_st);
                comport8_exterior.Write("@0G\r");
            }

        }

        private void home_exterior_counter_Click(object sender, EventArgs e)
        {
            if (!comport8_exterior.IsOpen)
            {
                Output.AppendText("Port is not open! \n");
            }
            else
            {
                int rotate = int.Parse(home_exterior_text.Text) * 12800 / 360;
                string rotate_debugging = rotate.ToString();
                Output.AppendText("Degrees converted to steps is:" + rotate_debugging + "\n");
                string rotate_st = "@0N" + rotate + "\r";
                Output.AppendText("Command string is: " + rotate_st + "\n");

                comport8_exterior.Write("@0-\r");
                comport8_exterior.Write(rotate_st);
                comport8_exterior.Write("@0G\r");
            }
        }

        private void sethome_bt_Click(object sender, EventArgs e)
        {
            comport7_interior.Write("@1Z0\r");
            comport8_exterior.Write("@0Z0\r");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Read();
            
        }

        private void lightsensor_btn_Click(object sender, EventArgs e)
        {
            OpenComport2();
            timer1.Start();
        }


    }
}
