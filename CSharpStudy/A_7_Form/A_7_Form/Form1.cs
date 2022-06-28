using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_7_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRPath_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtRPath.Text = this.ofdFile.FileName;
            }
        }
        private void btnRARead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false) 
                return; 
            if (File.Exists(this.txtRPath.Text)) 
            { 
                using (StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default)) 
                {
                    this.txtRView.Text = sr.ReadToEnd();
                } 
            }
            else
            { 
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnRLRead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false) 
                return; 
            this.txtRView.Clear();
            if (File.Exists(this.txtRPath.Text)) 
            { 
                using (StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default)) { 
                    string line = null;
                    while ((line = sr.ReadLine()) != null) 
                    { 
                        this.txtRView.AppendText(line + "\r\n"); 
                    } 
                } 
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnWPath_Click(object sender, EventArgs e)
        {
            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtWPath.Text = this.sfdFile.FileName;
            }
        }
        private void btnWASave_Click(object sender, EventArgs e)
        {
            try
            { 
                //using 키워드
                //using(메모리를 할당받는 객체의 선언)
                //{실행코드}
                //using 키워드로 객체를 감싸주면 using문을 빠져나오는 시점에 메모리를 해제시킴으로써 안전하게 메모리를 할당하고 코드를 실행 할 수있다.

                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text)) 
                {
                    sw.WriteLine(this.txtWView.Text);
                } 
            }
            catch 
            {
                return; 
            }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWLSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    foreach (var str in this.txtWView.Lines) 
                    {
                        sw.WriteLine(str); 
                    } 
                }
            }
            catch 
            { 
                return; 
            }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    

        private bool txtCheck()
        {
            if (this.txtRPath.Text == "") return false;
            else
                return true;
        }
    }
}
