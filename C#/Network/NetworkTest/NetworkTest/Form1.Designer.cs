
namespace NetworkTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ipInputLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ipInputLbl
            // 
            this.ipInputLbl.AutoSize = true;
            this.ipInputLbl.Location = new System.Drawing.Point(13, 45);
            this.ipInputLbl.Name = "ipInputLbl";
            this.ipInputLbl.Size = new System.Drawing.Size(57, 15);
            this.ipInputLbl.TabIndex = 1;
            this.ipInputLbl.Text = "연결할 ip";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(370, 42);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(125, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "연결 시도";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(560, 49);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(71, 15);
            this.statusLbl.TabIndex = 3;
            this.statusLbl.Text = "연결 받는중";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.ipInputLbl);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ipInputLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label statusLbl;
    }
}

