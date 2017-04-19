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
		ScrollBar hScrollBar1;
		public void CreateForm(int number)
		{
			if(!Controls.Contains(hScrollBar1))
			{
				hScrollBar1 = new System.Windows.Forms.HScrollBar();
				SuspendLayout();

				// hScrollBar1
				hScrollBar1.Location = new System.Drawing.Point(4, 4);
				hScrollBar1.Name = "hScrollBar1";
				hScrollBar1.Size = new System.Drawing.Size(80, 17);
				hScrollBar1.TabIndex = 0;

				panel1.Controls.Add(hScrollBar1);

				ResumeLayout(false);
			}
		}
	}
}
