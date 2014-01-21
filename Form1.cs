using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SocketClient_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] m_dataBuffer = new byte[10];
        IAsyncResult m_result;
        public AsyncCallback m_pfnCallBack;
        public Socket m_clientSocket;
        delegate void SetReceivedMessageCallback(string text);

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            // See if we have text on the IP and Port text fields
            if (txtipaddress.Text == "" || txtport.Text == "")
            {
                MessageBox.Show("IP Address and Port Number are required to connect to the Server\n");
                return;
            }
            try
            {
                UpdateControls(false);
                // Create the socket instance
                m_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Cet the remote IP address
                IPAddress ip = IPAddress.Parse(txtipaddress.Text);
                int iPortNo = System.Convert.ToInt32(txtport.Text);
                // Create the end point 
                IPEndPoint ipEnd = new IPEndPoint(ip, iPortNo);
                // Connect to the remote host
                m_clientSocket.Connect(ipEnd);
                if (m_clientSocket.Connected)
                {

                    UpdateControls(true);
                    //Wait for data asynchronously 
                    WaitForData();
                }
            }
            catch (SocketException se)
            {
                string str;
                str = "\nConnection failed, is the server running?\n" + se.Message;
                MessageBox.Show(str);
                UpdateControls(false);
            }
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            if (m_clientSocket != null)
            {
                m_clientSocket.Close();
                m_clientSocket = null;
                UpdateControls(false);
            }
        }

        private void sendMessage(string msg2send)
        {
            try
            {
                Object objData = msg2send;
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(objData.ToString());
                if (m_clientSocket != null)
                {
                    m_clientSocket.Send(byData);
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (m_clientSocket != null)
            {
                m_clientSocket.Close();
                m_clientSocket = null;
            }
            Close();
        }

        public void WaitForData()
        {
            try
            {
                if (m_pfnCallBack == null)
                {
                    m_pfnCallBack = new AsyncCallback(OnDataReceived);
                }
                SocketPacket theSocPkt = new SocketPacket();
                theSocPkt.thisSocket = m_clientSocket;
                // Start listening to the data asynchronously
                m_result = m_clientSocket.BeginReceive(theSocPkt.dataBuffer,
                                                        0, theSocPkt.dataBuffer.Length,
                                                        SocketFlags.None,
                                                        m_pfnCallBack,
                                                        theSocPkt);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        public class SocketPacket
        {
            public System.Net.Sockets.Socket thisSocket;
            public byte[] dataBuffer = new byte[22];
        }

        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                SocketPacket theSockId = (SocketPacket)asyn.AsyncState;
                int iRx = theSockId.thisSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(theSockId.dataBuffer, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                SetReceivedMessageText(szData);
                WaitForData();
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        //---------------------------------------------------------------------------------------
        private void SetReceivedMessageText(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.receivedmessageListbox.InvokeRequired)
            {
                SetReceivedMessageCallback d = new SetReceivedMessageCallback(SetReceivedMessageText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                receivedmessageListbox.Items.Add(text);

                manageServerMessage(text);

                ListBoxAutoScroll();
            }
        }


        Player player = new Player();

        // player.table

        public void manageServerMessage(string text)
        {

            if (text.Substring(0, 1) == "S")
            {
               player.turn++;
            }
            else if (text.Substring(0, 1) == "R")
            {
                player.turn--;
            }
            else if (text.Substring(0, 1) == "T" || text.Substring(0, 1) == "I")
            {
                player.turn--;
            }


            string regexBracket = @"\[([0-9]),([0-9]|1[0-4]),([0-9]),([0-9]|1[0-4])]";

            Regex r = new Regex(regexBracket, RegexOptions.IgnoreCase);

            Match m = r.Match(text);

            if (m.Success)
            {
                //move[0] = Convert.ToInt16(m.Groups[1].ToString());
                //move[1] = Convert.ToInt16(m.Groups[2].ToString());
                //move[2] = Convert.ToInt16(m.Groups[3].ToString());
                //move[3] = Convert.ToInt16(m.Groups[4].ToString());

                player.setMove.move[0] = Convert.ToInt16(m.Groups[1].ToString());
                player.setMove.move[1] = Convert.ToInt16(m.Groups[2].ToString());
                player.setMove.move[2] = Convert.ToInt16(m.Groups[3].ToString());
                player.setMove.move[3] = Convert.ToInt16(m.Groups[4].ToString());
            }

            string bonusRegex = @"Bonus\(\+([1-2]),[A-B]\)";

            Regex r1 = new Regex(bonusRegex, RegexOptions.IgnoreCase);

            Match m1 = r1.Match(text);

            if (m1.Success)
            {
                int count;

                count = Convert.ToInt16(m1.Groups[1].ToString());

                if (m1.Groups[3] == null)
                    player.turn = count;
                else
                    player.turn = -count + 1;

            }


            //Console.WriteLine("turn:");
            //Console.WriteLine(turn.ToString());
            //Console.WriteLine("");

            //Console.WriteLine("move:");
            //Console.WriteLine(string.Join(",", move));
            //Console.WriteLine("");



            
            MessageBox.Show(player.turn.ToString());
            //if (player.turn > 0)
            //{
              //  sendMessage(player.getNextMove());
            //}
        }

        //----------------------------------------------------------------------------------------
        // This is a helper function used (for convenience) to 
        // get the IP address of the local machine
        //----------------------------------------------------
        String GetIP()
        {
            String strHostName = System.Net.Dns.GetHostName();

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Grab the first IP addresses
            String IPStr = "";
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                IPStr = ipaddress.ToString();
                return IPStr;
            }
            return IPStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtipaddress.Text = GetIP();
        }
        private void UpdateControls(bool connected)
        {
            btnconnect.Enabled = !connected;
            btndisconnect.Enabled = connected;
            string connectStatus = connected ? "Connected" : "Not Connected";
            lblstatusmessage.Text = connectStatus;
        }


        public void ListBoxAutoScroll()
        {
            int visibleItems = receivedmessageListbox.ClientSize.Height / receivedmessageListbox.ItemHeight;
            receivedmessageListbox.TopIndex = Math.Max(receivedmessageListbox.Items.Count - visibleItems + 1, 0);
        }
    }
}
