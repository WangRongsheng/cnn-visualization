/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2021/2/15
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace CNN卷积可视化实现
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] path;
		int count=0;
		int height;
		int width;
		int [,] colorRed,colorGreen,colorBlue;
		int [,] juanjicolorRed,juanjicolorGreen,juanjicolorBlue;
		int [,] juanjihe=new int[3,3]{{1,0,-1},{1,0,-1},{1,0,-1}};
		int [] W,B;
		double r=0.02;
		int juanjibuchang=1;
		int juanjiwidth=3;
		int [,] colorchihuaRed,colorchihuaGreen,colorchihuaBlue;
		Bitmap pictureRed,pictureGreen,pictureBlue;
		Bitmap juanjipictureRed,juanjipictureGreen,juanjipictureBlue,juanjihebingpicture;
		Bitmap jilipicture;
		Bitmap chihuapicture;
		public MainForm()
		{
			InitializeComponent();
			comboBoxjili.Items.Add("Relu函数");
			comboBoxjili.Items.Add("Sigmoid函数");
			comboBoxjili.Items.Add("tanh函数");
			comboBoxjili.Items.Add("ELU函数");
		}
		
		void ButtonScanClick(object sender, EventArgs e)
		{
			height=240;
			width=240;
			try{
				path = Directory.GetFiles(@textBoxPicturePath.Text.ToString(), "*.jpg");
				PictureShow();
			}
			catch{
				MessageBox.Show("图片路径错误,重新输入");
			}
			
		}
		void PictureShow()
		{
			Bitmap b=new Bitmap(path[count]);
			b=b.Clone(new Rectangle(0,0,240,240),System.Drawing.Imaging.PixelFormat.DontCare);
			pictureBoxShow.Image=Image.FromHbitmap(b.GetHbitmap());
			GetRGB(b);
		}
		
		void ButtonUpClick(object sender, EventArgs e)
		{
			height=240;
			width=240;
			if(count>0&&count<path.Length)
			{	count--;
				PictureShow();
			}
			else
			{
				MessageBox.Show("这已经是第一张了");
				
			}
		}
		void GetRGB(Bitmap b)
		{
			colorRed=new int[height,width];
			colorGreen=new int[height,width];
			colorBlue = new int[height,width];
			Rectangle rect = new Rectangle(0,0,width,height);
			
			System.Drawing.Imaging.BitmapData bmpData =b.LockBits(rect,System.Drawing.Imaging.ImageLockMode.ReadWrite,b.PixelFormat);
			IntPtr iptr = bmpData.Scan0;
			int iBytes = width*height*3;
			byte[] PixelValues = new byte[iBytes];
			System.Runtime.InteropServices.Marshal.Copy(iptr,PixelValues,0,iBytes);
			
			b.UnlockBits(bmpData);
			pictureRed =new Bitmap(width,height);
			pictureGreen=new Bitmap(width,height);
			pictureBlue= new Bitmap(width,height);
			int ipoint=0;
			for(int i=0;i<width;++i)
			{
				for(int j=0;j<height;++j)
				{
					
					colorRed[i,j] = Convert.ToInt32(PixelValues[ipoint++]);
					pictureRed.SetPixel(j,i,Color.FromArgb(colorRed[i,j],0,0));
					colorGreen[i,j] = Convert.ToInt32(PixelValues[ipoint++]);
					pictureGreen.SetPixel(j,i,Color.FromArgb(0,colorGreen[i,j],0));
					colorBlue[i,j] = Convert.ToInt32(PixelValues[ipoint++]);
					pictureBlue.SetPixel(j,i,Color.FromArgb(0,0,colorBlue[i,j]));
					
				}
			}
			
		}
		
		void ButtonNextClick(object sender, EventArgs e)
		{
			height=240;
			width=240;	
			if(count<path.Length-1)
			{   count++;
				PictureShow();
			}
			else
			{
				MessageBox.Show("这已经是最后一张了");
			}
		}
		
		void ButtonBeginClick(object sender, EventArgs e)
		{
			height=240;
			width=240;
			if(textBoxJuanjiHe.Text!="")
			{
				string[] data=textBoxJuanjiHe.Text.ToString().Split(',');
				if(data.Length!=Math.Sqrt(data.Length)*Math.Sqrt(data.Length))
					MessageBox.Show("卷积核格式错误");
				else{
					juanjihe=new int[(int)Math.Sqrt(data.Length),(int)Math.Sqrt(data.Length)];
					for(int i=0;i<data.Length;++i)
						juanjihe[i/(int)Math.Sqrt(data.Length),i%(int)Math.Sqrt(data.Length)]=Convert.ToInt32(data[i]);
					juanjiwidth=(int)Math.Sqrt(data.Length);
				}
			}
			if(textBoxbuchang.Text!="")
				juanjibuchang=int.Parse(textBoxbuchang.Text.ToString());
			juanjicolorRed=new int[(width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang];
			juanjicolorGreen=new int[(width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang];
			juanjicolorBlue=new int[(width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang];
			juanjipictureRed =new Bitmap((width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang);
			juanjipictureGreen=new Bitmap((width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang);
			juanjipictureBlue= new Bitmap((width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang);
			juanjihebingpicture=new Bitmap((width-juanjiwidth+1)/juanjibuchang,(height-juanjiwidth+1)/juanjibuchang);
			//
			//卷积层
			//
			juanji(colorRed,out juanjicolorRed);
			juanji(colorGreen,out juanjicolorGreen);
			juanji(colorBlue,out juanjicolorBlue);
			width=(width-juanjiwidth+1)/juanjibuchang;
			height=(height-juanjiwidth+1)/juanjibuchang;
			pictureBoxRed.Image=Image.FromHbitmap(pictureRed.GetHbitmap());
			pictureBoxGreen.Image=Image.FromHbitmap(pictureGreen.GetHbitmap());
			pictureBoxBlue.Image=Image.FromHbitmap(pictureBlue.GetHbitmap());
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjipictureRed.SetPixel(j,i,Color.FromArgb(Math.Abs(juanjicolorRed[i,j]%255),0,0));
			}
			pictureBoxJuanjiRed.Image=Image.FromHbitmap(juanjipictureRed.GetHbitmap());
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjipictureGreen.SetPixel(j,i,Color.FromArgb(0,Math.Abs(juanjicolorGreen[i,j]%255),0));
			}
			pictureBoxJuanjiGreen.Image=Image.FromHbitmap(juanjipictureGreen.GetHbitmap());
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjipictureBlue.SetPixel(j,i,Color.FromArgb(0,0,Math.Abs(juanjicolorBlue[i,j]%255)));
			}
			pictureBoxJuanjiBlue.Image=Image.FromHbitmap(juanjipictureBlue.GetHbitmap());
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjihebingpicture.SetPixel(j,i,Color.FromArgb(Math.Abs(juanjicolorRed[i,j]%255),Math.Abs(juanjicolorGreen[i,j]%255),Math.Abs(juanjicolorBlue[i,j]%255)));
			}
			pictureBoxJuanjiHebing.Image=Image.FromHbitmap(juanjihebingpicture.GetHbitmap());
			//
			//激励层
			//
			Random random =new Random();
			W=new int[height];
			B=new int[height];
			for(int i=0;i<height;++i)
			{
				W[i]=random.Next(0,2);
				B[i]=random.Next(0,2);
			}
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjicolorRed[i,j]=juanjicolorRed[i,j]*W[j]+B[j];
				juanjicolorGreen[i,j]=juanjicolorGreen[i,j]*W[j]+B[j];
				juanjicolorBlue[i,j]=juanjicolorBlue[i,j]*W[j]+B[j];
			}
				
			if(comboBoxjili.Text=="ELU函数")
				ELU();
			else if(comboBoxjili.Text=="Sigmoid函数")
				sigmoid();
			else if(comboBoxjili.Text=="tanh函数")
				tanh();
			else Relu();
			jilipicture=new Bitmap(width,height);
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				jilipicture.SetPixel(j,i,Color.FromArgb(Math.Abs(juanjicolorRed[i,j]%255),Math.Abs(juanjicolorGreen[i,j]%255),Math.Abs(juanjicolorBlue[i,j]%255)));
			}
			pictureBoxJili.Image=Image.FromHbitmap(jilipicture.GetHbitmap());
			
			//
			//池化层
			//
			colorchihuaRed=new int[width/2,height/2];
			colorchihuaGreen=new int[width/2,height/2];
			colorchihuaBlue=new int[width/2,height/2];
			for(int i=0;i<width-1;i+=2)
				for(int j=0;j<height-1;j+=2)
			{
				int maxred=juanjicolorRed[i,j];
				int maxgreen=juanjicolorGreen[i,j];
				int maxblue=juanjicolorBlue[i,j];
				maxred=Math.Max(Math.Max(Math.Max(juanjicolorRed[i,j+1],juanjicolorRed[i+1,j]),juanjicolorRed[i+1,j+1]),maxred);
				colorchihuaRed[i/2,j/2]=maxred;
				maxgreen=Math.Max(Math.Max(Math.Max(juanjicolorGreen[i,j+1],juanjicolorGreen[i+1,j]),juanjicolorGreen[i+1,j+1]),maxgreen);
				colorchihuaGreen[i/2,j/2]=maxgreen;
				maxblue=Math.Max(Math.Max(Math.Max(juanjicolorBlue[i,j+1],juanjicolorBlue[i+1,j]),juanjicolorBlue[i+1,j+1]),maxblue);
				colorchihuaBlue[i/2,j/2]=maxblue;
			}
			chihuapicture= new Bitmap(width/2,height/2);
			for(int i=0;i<width/2;++i)
				for(int j=0;j<height/2;++j)
			{
				chihuapicture.SetPixel(j,i,Color.FromArgb(Math.Abs(colorchihuaRed[i,j]%255),Math.Abs(colorchihuaGreen[i,j]%255),Math.Abs(colorchihuaBlue[i,j]%255)));
			}
			pictureBoxChihua.Image=Image.FromHbitmap(chihuapicture.GetHbitmap());
		}
		void Relu()
		{
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				if(juanjicolorRed[i,j]<=0)
					juanjicolorRed[i,j]=(int)r*juanjicolorRed[i,j];
				juanjicolorGreen[i,j]=juanjicolorGreen[i,j]*W[j]+B[j];
				if(juanjicolorGreen[i,j]<=0)
					juanjicolorGreen[i,j]=(int)r*juanjicolorGreen[i,j];
				juanjicolorBlue[i,j]=juanjicolorBlue[i,j]*W[j]+B[j];
				if(juanjicolorBlue[i,j]<=0)
					juanjicolorBlue[i,j]=(int)r*juanjicolorBlue[i,j];
			}
		}
		void sigmoid(){
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjicolorRed[i,j]=(int)(255/(1+Math.Exp(-juanjicolorRed[i,j])));
				juanjicolorGreen[i,j]=(int)(255/(1+Math.Exp(-juanjicolorGreen[i,j])));
				juanjicolorBlue[i,j]=(int)(255/(1+Math.Exp(-juanjicolorBlue[i,j])));
			}
		}
		void tanh()
		{
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				juanjicolorRed[i,j]=(int)((Math.Exp(juanjicolorRed[i,j])-Math.Exp(-juanjicolorRed[i,j]))/(Math.Exp(juanjicolorRed[i,j])+Math.Exp(-juanjicolorRed[i,j]))*255);
				juanjicolorGreen[i,j]=(int)((Math.Exp(juanjicolorGreen[i,j])-Math.Exp(-juanjicolorGreen[i,j]))/(Math.Exp(juanjicolorGreen[i,j])+Math.Exp(-juanjicolorGreen[i,j]))*255);
				juanjicolorBlue[i,j]=(int)((Math.Exp(juanjicolorBlue[i,j])-Math.Exp(-juanjicolorBlue[i,j]))/(Math.Exp(juanjicolorBlue[i,j])+Math.Exp(-juanjicolorBlue[i,j]))*255);
			}
		}
		void ELU(){
			for(int i=0;i<width;++i)
				for(int j=0;j<height;++j)
			{
				if(juanjicolorRed[i,j]<0)
					juanjicolorRed[i,j]=(int)(r*(Math.Exp(juanjicolorRed[i,j])-1));
				if(juanjicolorGreen[i,j]<0)
					juanjicolorGreen[i,j]=(int)(r*(Math.Exp(juanjicolorGreen[i,j])-1));
				if(juanjicolorBlue[i,j]<0)
					juanjicolorBlue[i,j]=(int)(r*(Math.Exp(juanjicolorBlue[i,j])-1));
			}
		}
		void juanji(int [,] b,out int [,] juanjicolor)
		{

			int [,] temp=new int[(width-juanjiwidth+1)/juanjibuchang+1,(height-juanjiwidth+1)/juanjibuchang+1];
			for(int c=0;c<height-juanjiwidth+1;c+=juanjibuchang)
			{
				for(int t=0;t<width-juanjiwidth+1;t+=juanjibuchang)
				{
					int sum=0;
					for(int i=0;i<juanjiwidth;++i)
						for(int j=0;j<juanjiwidth;++j)
					{
						sum+=b[i+c,t+j]*juanjihe[i,j];
					}
					temp[c/juanjibuchang,t/juanjibuchang]=sum;	
				}
			}
			juanjicolor=temp;
		}
		
	}
}
