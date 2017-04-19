using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("text", "Name", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Button button1;
			button1 = new Button();
			button1.Font = new Font("Open Sans", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
			button1.ForeColor = Color.FromArgb(80, 80, 80);
			button1.Location = new Point(10, 10);
			button1.Name = "button1";
			button1.Size = new Size(467, 90);
			button1.TabIndex = 1;
			button1.Text = "Я хочу стать зрителем";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new EventHandler(button1_Click);
			Controls.Add(button1);
		}
		public class MeButton1 : UserControl
		{

		}
	}
}