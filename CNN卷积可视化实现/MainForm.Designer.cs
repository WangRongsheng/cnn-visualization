/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2021/2/15
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CNN卷积可视化实现
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonScan = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonNext = new System.Windows.Forms.Button();
			this.buttonBegin = new System.Windows.Forms.Button();
			this.pictureBoxShow = new System.Windows.Forms.PictureBox();
			this.textBoxPicturePath = new System.Windows.Forms.TextBox();
			this.labelPicturePath = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxRed = new System.Windows.Forms.PictureBox();
			this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
			this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
			this.pictureBoxJuanjiRed = new System.Windows.Forms.PictureBox();
			this.pictureBoxJuanjiGreen = new System.Windows.Forms.PictureBox();
			this.pictureBoxJuanjiBlue = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxJuanjiHe = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxbuchang = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBoxJuanjiHebing = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBoxJili = new System.Windows.Forms.PictureBox();
			this.pictureBoxChihua = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxjili = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiHebing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJili)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxChihua)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonScan
			// 
			this.buttonScan.Font = new System.Drawing.Font("宋体", 9F);
			this.buttonScan.Location = new System.Drawing.Point(34, 568);
			this.buttonScan.Name = "buttonScan";
			this.buttonScan.Size = new System.Drawing.Size(75, 25);
			this.buttonScan.TabIndex = 0;
			this.buttonScan.Text = "浏览";
			this.buttonScan.UseVisualStyleBackColor = true;
			this.buttonScan.Click += new System.EventHandler(this.ButtonScanClick);
			// 
			// buttonUp
			// 
			this.buttonUp.Font = new System.Drawing.Font("宋体", 9F);
			this.buttonUp.Location = new System.Drawing.Point(34, 614);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(75, 25);
			this.buttonUp.TabIndex = 1;
			this.buttonUp.Text = "上一张";
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.ButtonUpClick);
			// 
			// buttonNext
			// 
			this.buttonNext.Font = new System.Drawing.Font("宋体", 9F);
			this.buttonNext.Location = new System.Drawing.Point(142, 614);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(75, 25);
			this.buttonNext.TabIndex = 1;
			this.buttonNext.Text = "下一张";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.ButtonNextClick);
			// 
			// buttonBegin
			// 
			this.buttonBegin.Font = new System.Drawing.Font("宋体", 9F);
			this.buttonBegin.Location = new System.Drawing.Point(142, 568);
			this.buttonBegin.Name = "buttonBegin";
			this.buttonBegin.Size = new System.Drawing.Size(75, 25);
			this.buttonBegin.TabIndex = 0;
			this.buttonBegin.Text = "开始";
			this.buttonBegin.UseVisualStyleBackColor = true;
			this.buttonBegin.Click += new System.EventHandler(this.ButtonBeginClick);
			// 
			// pictureBoxShow
			// 
			this.pictureBoxShow.Location = new System.Drawing.Point(18, 301);
			this.pictureBoxShow.Name = "pictureBoxShow";
			this.pictureBoxShow.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxShow.TabIndex = 2;
			this.pictureBoxShow.TabStop = false;
			// 
			// textBoxPicturePath
			// 
			this.textBoxPicturePath.Location = new System.Drawing.Point(18, 80);
			this.textBoxPicturePath.Name = "textBoxPicturePath";
			this.textBoxPicturePath.Size = new System.Drawing.Size(240, 25);
			this.textBoxPicturePath.TabIndex = 3;
			// 
			// labelPicturePath
			// 
			this.labelPicturePath.Font = new System.Drawing.Font("宋体", 9F);
			this.labelPicturePath.Location = new System.Drawing.Point(18, 44);
			this.labelPicturePath.Name = "labelPicturePath";
			this.labelPicturePath.Size = new System.Drawing.Size(240, 33);
			this.labelPicturePath.TabIndex = 4;
			this.labelPicturePath.Text = "图片路径：";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F);
			this.label1.Location = new System.Drawing.Point(91, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 39);
			this.label1.TabIndex = 5;
			this.label1.Text = "输入区";
			// 
			// pictureBoxRed
			// 
			this.pictureBoxRed.Location = new System.Drawing.Point(356, 40);
			this.pictureBoxRed.Name = "pictureBoxRed";
			this.pictureBoxRed.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxRed.TabIndex = 6;
			this.pictureBoxRed.TabStop = false;
			// 
			// pictureBoxGreen
			// 
			this.pictureBoxGreen.Location = new System.Drawing.Point(356, 299);
			this.pictureBoxGreen.Name = "pictureBoxGreen";
			this.pictureBoxGreen.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxGreen.TabIndex = 6;
			this.pictureBoxGreen.TabStop = false;
			// 
			// pictureBoxBlue
			// 
			this.pictureBoxBlue.Location = new System.Drawing.Point(356, 562);
			this.pictureBoxBlue.Name = "pictureBoxBlue";
			this.pictureBoxBlue.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxBlue.TabIndex = 6;
			this.pictureBoxBlue.TabStop = false;
			// 
			// pictureBoxJuanjiRed
			// 
			this.pictureBoxJuanjiRed.Location = new System.Drawing.Point(665, 40);
			this.pictureBoxJuanjiRed.Name = "pictureBoxJuanjiRed";
			this.pictureBoxJuanjiRed.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxJuanjiRed.TabIndex = 6;
			this.pictureBoxJuanjiRed.TabStop = false;
			// 
			// pictureBoxJuanjiGreen
			// 
			this.pictureBoxJuanjiGreen.Location = new System.Drawing.Point(665, 299);
			this.pictureBoxJuanjiGreen.Name = "pictureBoxJuanjiGreen";
			this.pictureBoxJuanjiGreen.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxJuanjiGreen.TabIndex = 6;
			this.pictureBoxJuanjiGreen.TabStop = false;
			// 
			// pictureBoxJuanjiBlue
			// 
			this.pictureBoxJuanjiBlue.Location = new System.Drawing.Point(665, 562);
			this.pictureBoxJuanjiBlue.Name = "pictureBoxJuanjiBlue";
			this.pictureBoxJuanjiBlue.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxJuanjiBlue.TabIndex = 6;
			this.pictureBoxJuanjiBlue.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.Location = new System.Drawing.Point(414, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 28);
			this.label2.TabIndex = 5;
			this.label2.Text = "RGB通道";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 12F);
			this.label3.Location = new System.Drawing.Point(727, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 28);
			this.label3.TabIndex = 5;
			this.label3.Text = "卷积层";
			// 
			// textBoxJuanjiHe
			// 
			this.textBoxJuanjiHe.Location = new System.Drawing.Point(18, 152);
			this.textBoxJuanjiHe.Name = "textBoxJuanjiHe";
			this.textBoxJuanjiHe.Size = new System.Drawing.Size(240, 25);
			this.textBoxJuanjiHe.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 9F);
			this.label4.Location = new System.Drawing.Point(18, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 33);
			this.label4.TabIndex = 4;
			this.label4.Text = "卷积核：";
			// 
			// textBoxbuchang
			// 
			this.textBoxbuchang.Location = new System.Drawing.Point(129, 207);
			this.textBoxbuchang.Name = "textBoxbuchang";
			this.textBoxbuchang.Size = new System.Drawing.Size(129, 25);
			this.textBoxbuchang.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 9F);
			this.label5.Location = new System.Drawing.Point(18, 210);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "步长：";
			// 
			// pictureBoxJuanjiHebing
			// 
			this.pictureBoxJuanjiHebing.Location = new System.Drawing.Point(962, 40);
			this.pictureBoxJuanjiHebing.Name = "pictureBoxJuanjiHebing";
			this.pictureBoxJuanjiHebing.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxJuanjiHebing.TabIndex = 6;
			this.pictureBoxJuanjiHebing.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 12F);
			this.label6.Location = new System.Drawing.Point(1006, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(164, 28);
			this.label6.TabIndex = 5;
			this.label6.Text = "卷积层输出合并";
			// 
			// pictureBoxJili
			// 
			this.pictureBoxJili.Location = new System.Drawing.Point(962, 301);
			this.pictureBoxJili.Name = "pictureBoxJili";
			this.pictureBoxJili.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxJili.TabIndex = 6;
			this.pictureBoxJili.TabStop = false;
			// 
			// pictureBoxChihua
			// 
			this.pictureBoxChihua.Location = new System.Drawing.Point(962, 564);
			this.pictureBoxChihua.Name = "pictureBoxChihua";
			this.pictureBoxChihua.Size = new System.Drawing.Size(240, 240);
			this.pictureBoxChihua.TabIndex = 6;
			this.pictureBoxChihua.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 12F);
			this.label7.Location = new System.Drawing.Point(1220, 260);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 106);
			this.label7.TabIndex = 7;
			this.label7.Text = "激励层";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("宋体", 12F);
			this.label8.Location = new System.Drawing.Point(1220, 514);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 106);
			this.label8.TabIndex = 7;
			this.label8.Text = "池化层";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("宋体", 9F);
			this.label9.Location = new System.Drawing.Point(18, 256);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 33);
			this.label9.TabIndex = 4;
			this.label9.Text = "激励函数：";
			// 
			// comboBoxjili
			// 
			this.comboBoxjili.FormattingEnabled = true;
			this.comboBoxjili.Location = new System.Drawing.Point(129, 253);
			this.comboBoxjili.Name = "comboBoxjili";
			this.comboBoxjili.Size = new System.Drawing.Size(129, 23);
			this.comboBoxjili.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1302, 814);
			this.Controls.Add(this.comboBoxjili);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBoxChihua);
			this.Controls.Add(this.pictureBoxJuanjiBlue);
			this.Controls.Add(this.pictureBoxBlue);
			this.Controls.Add(this.pictureBoxJili);
			this.Controls.Add(this.pictureBoxJuanjiGreen);
			this.Controls.Add(this.pictureBoxJuanjiHebing);
			this.Controls.Add(this.pictureBoxJuanjiRed);
			this.Controls.Add(this.pictureBoxGreen);
			this.Controls.Add(this.pictureBoxRed);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxbuchang);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxJuanjiHe);
			this.Controls.Add(this.labelPicturePath);
			this.Controls.Add(this.textBoxPicturePath);
			this.Controls.Add(this.pictureBoxShow);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonBegin);
			this.Controls.Add(this.buttonScan);
			this.Name = "MainForm";
			this.Text = "CNN卷积可视化实现";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuanjiHebing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJili)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxChihua)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBoxjili;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBoxChihua;
		private System.Windows.Forms.PictureBox pictureBoxJili;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBoxJuanjiHebing;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxbuchang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxJuanjiHe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBoxJuanjiBlue;
		private System.Windows.Forms.PictureBox pictureBoxJuanjiGreen;
		private System.Windows.Forms.PictureBox pictureBoxJuanjiRed;
		private System.Windows.Forms.PictureBox pictureBoxBlue;
		private System.Windows.Forms.PictureBox pictureBoxGreen;
		private System.Windows.Forms.PictureBox pictureBoxRed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelPicturePath;
		private System.Windows.Forms.TextBox textBoxPicturePath;
		private System.Windows.Forms.PictureBox pictureBoxShow;
		private System.Windows.Forms.Button buttonBegin;
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonScan;
	}
}
