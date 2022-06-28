﻿
namespace FIleExcelSave
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
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.lvFile = new System.Windows.Forms.ListView();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chData = new System.Windows.Forms.ColumnHeader();
            this.chType = new System.Windows.Forms.ColumnHeader();
            this.chSize = new System.Windows.Forms.ColumnHeader();
            this.chPath = new System.Windows.Forms.ColumnHeader();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(51, 60);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(94, 29);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "파일";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.rbExcel);
            this.gbSave.Controls.Add(this.rbText);
            this.gbSave.Location = new System.Drawing.Point(330, 36);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(283, 81);
            this.gbSave.TabIndex = 2;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "파일 저장";
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(145, 29);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(72, 24);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "EXCEL";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(20, 29);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(55, 24);
            this.rbText.TabIndex = 0;
            this.rbText.TabStop = true;
            this.rbText.Text = "TXT";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chData,
            this.chType,
            this.chSize,
            this.chPath});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(51, 128);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(597, 277);
            this.lvFile.TabIndex = 3;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "모든 파일(*.*)|*.*";
            this.ofdFile.Multiselect = true;
            // 
            // chName
            // 
            this.chName.Name = "chName";
            this.chName.Text = "이름";
            this.chName.Width = 150;
            // 
            // chData
            // 
            this.chData.Name = "chData";
            this.chData.Text = "수정한 날짜";
            this.chData.Width = 100;
            // 
            // chType
            // 
            this.chType.Name = "chType";
            this.chType.Text = "유형";
            this.chType.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Name = "chSize";
            this.chSize.Text = "크기";
            this.chSize.Width = 100;
            // 
            // chPath
            // 
            this.chPath.Name = "chPath";
            this.chPath.Text = "경로";
            this.chPath.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "파일 정보 저장하기";
            this.gbSave.ResumeLayout(false);
            this.gbSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chPath;
    }
}

