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
		Panel panel2;
		Label label1;
		ComboBox comboBox1;
		CheckBox checkBox1;
		
		public void CreateForm(int i)
		{
			if(!Controls.Contains(hScrollBar1))
			{
				hScrollBar1 = new System.Windows.Forms.HScrollBar();
				panel2 = new System.Windows.Forms.Panel();
				label1 = new System.Windows.Forms.Label();
				comboBox1 = new System.Windows.Forms.ComboBox();
				checkBox1 = new System.Windows.Forms.CheckBox();
				SuspendLayout();

				// hScrollBar1
				hScrollBar1.Location = new System.Drawing.Point(5, 25);
				hScrollBar1.Name = "hScrollBar1";
				hScrollBar1.Size = new System.Drawing.Size(180, 17);
				hScrollBar1.TabIndex = 0;

				// 
				// checkBox1
				// 
				checkBox1.AutoSize = true;
				checkBox1.Location = new System.Drawing.Point(4, 56);
				checkBox1.Name = "checkBox1";
				checkBox1.Size = new System.Drawing.Size(80, 17);
				checkBox1.TabIndex = 0;
				checkBox1.Text = "checkBox1";
				checkBox1.UseVisualStyleBackColor = true;
				// 
				// comboBox1
				// 
				comboBox1.FormattingEnabled = true;
				comboBox1.Location = new System.Drawing.Point(90, 52);
				comboBox1.Name = "comboBox1";
				comboBox1.Size = new System.Drawing.Size(106, 21);
				comboBox1.TabIndex = 1;
				// 
				// label1
				// 
				label1.AutoSize = true;
				label1.Location = new System.Drawing.Point(4, 80);
				label1.Name = "label1";
				label1.Size = new System.Drawing.Size(35, 13);
				label1.TabIndex = 2;
				label1.Text = "label1";
				// 
				// panel2
				// 
				panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
				panel2.Location = new System.Drawing.Point(46, 80);
				panel2.Name = "panel2";
				panel2.Size = new System.Drawing.Size(127, 12);
				panel2.TabIndex = 3;

				panel1.Controls.Add(hScrollBar1);
				panel1.Controls.Add(panel2);
				panel1.Controls.Add(label1);
				panel1.Controls.Add(comboBox1);
				panel1.Controls.Add(checkBox1);

				ResumeLayout(false);
			}
		}
	}
}
