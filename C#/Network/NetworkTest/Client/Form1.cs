using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Socket socket; //소켓

        private Thread receiveThread; //대화수신용        
        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void connBtn_Click(object sender, EventArgs e)
        {
            IPAddress ipaddress = IPAddress.Parse(txtIP.Text);

            IPEndPoint endPoint = new IPEndPoint( ipaddress, 7777  );

            //연결 소켓생성
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,  ProtocolType.Tcp    );

            //연결하기
            socket.Connect(endPoint);

            //Receive 스레드 처리(서버 <-> 클라이언트

            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();


        }
        private void Receive()

        {
            while (true)
            {

                //연결된 클라이언트가 보낸 데이터 수신

                byte[] recevieBuffer = new byte[512];
                int length = socket.Receive(  recevieBuffer, recevieBuffer.Length, SocketFlags.None );

                string msg = Encoding.UTF8.GetString(recevieBuffer, 0, length );

                if (this.lblStatus.InvokeRequired == true)
                {
                    this.lblStatus.Invoke((MethodInvoker)delegate
                    {
                        this.lblStatus.Text += msg;
                    });
                }
                else
                {
                    this.lblStatus.Text += msg;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] sendBuffer = Encoding.UTF8.GetBytes(textBox1.Text);

            socket.Send(sendBuffer);
        }
    }
}
