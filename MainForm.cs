/*
 * Created by SharpDevelop.
 * User: Pc
 * Date: 27/02/2022
 * Time: 00:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculadora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
int x1,x2,x3;
x1= int.Parse(textBox1.Text);
x2= int.Parse(textBox2.Text);
x3= x1 + x2;
textBox3.Text=x3.ToString();

		}
		
		void Button2Click(object sender, EventArgs e)
		{
int x1,x2,x3;
x1= int.Parse(textBox1.Text);
x2= int.Parse(textBox2.Text);
x3= x1 - x2;
textBox3.Text=x3.ToString();
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
int x1,x2,x3;
x1= int.Parse(textBox1.Text);
x2= int.Parse(textBox2.Text);
x3= x1 * x2;
textBox3.Text=x3.ToString();
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
float x1,x2,x3;
x1= float.Parse(textBox1.Text);
x2= float.Parse(textBox2.Text);
x3= x1 / x2;
textBox3.Text=x3.ToString();
			
		}
	}
}
