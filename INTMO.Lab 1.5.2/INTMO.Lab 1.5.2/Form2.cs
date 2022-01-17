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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void OpenForm1_Click(object sender, EventArgs e)
		{
			ParentForm f2 = new ParentForm();
			f2.ShowDialog();
		}

		private void CloseForm1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm f2 = new ParentForm();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
