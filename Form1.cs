using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2
{
	partial class FormMain
	{
		Button button5;
		public void CreateForm()
		{
			if (!Controls.Contains(button5))
			{
				button5 = new System.Windows.Forms.Button();
				SuspendLayout();

				// button5
				button5.Location = new System.Drawing.Point(5, 5);
				button5.Name = "button5";
				button5.Size = new System.Drawing.Size(75, 23);
				button5.TabIndex = 0;
				button5.Text = "button5";
				button5.UseVisualStyleBackColor = true;
				button5.Click += new EventHandler(button5_Click);

				panel1.Controls.Add(button5);
				ResumeLayout(false);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Text", "message", MessageBoxButtons.OK);
		}
	}
}
