using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 0;
        string orgStr = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            orgStr = lblStatus.Text;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
            this.pbStatus.Value = 0;
            num = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            num++;
            if(num > 100)
            {
                this.Timer.Enabled = false;
                return;
            }
            this.pbStatus.Value = num;
            this.lblStatus.Text = orgStr + num.ToString() + "%";
        }
    }
}
