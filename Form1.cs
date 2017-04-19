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
				button5.Location = new System.Drawing.Point(5, 25);
				button5.Name = "button5";
				button5.Size = new System.Drawing.Size(75, 23);
				button5.TabIndex = 0;
				button5.Text = "button5";
				button5.UseVisualStyleBackColor = true;

				panel1.Controls.Add(button5);
				ResumeLayout(false);
			}
		}
	}
}
