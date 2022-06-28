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

namespace NetworkTest
{
    public partial class Form1 : Form
    {
        private string ip = "0.0.0.0";

        private int port = 7777;

        private Thread listenThread; //Accept()가 블럭

        private Thread recevieThread; //Recevie() 작업

        private Socket clientSocket; //연결된 클라이언트 소켓

        
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }
        private void Listen()
        {

            //종단점

            IPAddress ipaddress = IPAddress.Parse(ip);
            IPEndPoint endPoint = new IPEndPoint(ipaddress, port);
            //소켓생성
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            //바인드
            listenSocket.Bind(endPoint);
            //준비
            listenSocket.Listen(10);
            //수신대기

            // - 여기서 블럭이 걸려야 하지만 스레드로 따로 뺏기때문에 다른 작업이가능        
            clientSocket = listenSocket.Accept();
            if (this.statusLbl.InvokeRequired == true)
            {
                this.statusLbl.Invoke((MethodInvoker)delegate
                {
                    this.statusLbl.Text += " 연결성공";
                });
            }
            else
            {
                this.statusLbl.Text += "연결성공";
            }
            
            //Receive 스레드 호출
            recevieThread = new Thread(new ThreadStart(Receive));
            recevieThread.IsBackground = true;
            recevieThread.Start(); //Receive() 호출

        }

        private void Receive()

        {

            while (true)

            {

                //연결된 클라이언트가 보낸 데이터 수신

                byte[] receiveBuffer = new byte[512];

                int length = clientSocket.Receive( receiveBuffer, receiveBuffer.Length, SocketFlags.None );
                //디코딩

                string msg = Encoding.UTF8.GetString(receiveBuffer);
                this.statusLbl.Invoke((MethodInvoker)delegate
                {
                    this.statusLbl.Text += msg;
                });                                                           
                //엔터처리

                //richTextBox1.AppendText(msg);

              

            }

        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text == "시작")
            {
                startBtn.Text = "멈춤";
                //Listen스레드 처리

                listenThread = new Thread(new ThreadStart(Listen));
                listenThread.IsBackground = true;
                listenThread.Start();

            }
            else
            {

                startBtn.Text = "시작";

            
            }

            
           
        }
    }
}
