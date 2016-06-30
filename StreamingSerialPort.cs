//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO.Ports;

//namespace Daniels_LightTestApplication
//{
//    public abstract class StreamingSerialPort : SerialPort
//    {
//        protected Queue<byte> inQ;



//        /// <summary>
//        /// Default constructor
//        /// </summary>
//        /// <param name="config">SerialConfig instance specifying the internal settings of the serial port</param>
//        public StreamingSerialPort(): base()
//        {
//            inQ = new Queue<byte>();
//            this.DataReceived += new SerialDataReceivedEventHandler(StreamReceiver);

//           // comport2_lightsensor.Open();
//            this.Open();
//        }


//        /// <summary>
//        /// Internal processing function which receives data from the internal serial port and
//        /// fills the internal buffer queue.
//        /// </summary>
//        /// <param name="sender">Generic object form of the serial port which triggered the event</param>
//        /// <param name="e">Event arguments of the sender</param>
//        private void StreamReceiver(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
//        {
//            SerialPort sp = (SerialPort)sender;
//            if (e == SerialDataReceivedEventArgs.Empty) return;

//            int bytesAvail = sp.BytesToRead;
//            byte[] serialBuf = new byte[bytesAvail];
//            try
//            {
//                int bytesRead = sp.Read(serialBuf, 0, bytesAvail);
//                DataProcessingCallback(serialBuf, bytesRead);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//            }
//        }

//        /// <summary>
//        /// Delegate template to receive from the serial port to the internal buffer for processing.
//        /// </summary>
//        /// <param name="serialBuf">Byte array buffer read from the serial port</param>
//        /// <param name="numBytes">Number of bytes in serialBuf</param>
//        private delegate void DataProcessingDelegate(byte[] serialBuf, int numBytes);

//        /// <summary>
//        /// Queues serial data into the internal processing buffer queue.
//        /// </summary>
//        /// <param name="inBuf">Buffer read from the serial port</param>
//        /// <param name="numBytes">Number of bytes in the buffer</param>
//        private void DataProcessingCallback(byte[] inBuf, int numBytes)
//        {
//            foreach (byte b in inBuf)
//            {
//                inQ.Enqueue(b);
//            }
//        }

//        /// <summary>
//        /// Clears the internal buffer queue.
//        /// </summary>
//        protected void ClearBuffer()
//        {
//            if (this.IsOpen)
//            {
//                try
//                {
//                    this.DiscardOutBuffer();
//                    this.DiscardInBuffer();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.ToString());
//                }
//            }
//            inQ.Clear();
//        }
//    }
//}
