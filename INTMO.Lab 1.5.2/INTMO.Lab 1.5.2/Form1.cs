using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Lab01_Ex05._02
{
	public partial class ParentForm : Form
	{
		public ParentForm()
		{
			InitializeComponent();
		}

		private void ParentForm_Load(object sender, EventArgs e)
		{
			System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
			myPath.AddPolygon(new Point[] { 
											new Point(0, this.Width/2), 
											new Point(this.Height/2, 0), 
											new Point(this.Height, this.Width/2),
											new Point(this.Height/2, this.Width)});
			Region myRegion = new Region(myPath);
			this.Region = myRegion;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
