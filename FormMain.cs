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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CreateForm();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CreateForm(2);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
		}
	}
}
