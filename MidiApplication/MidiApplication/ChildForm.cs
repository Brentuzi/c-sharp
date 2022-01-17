using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MidiApplication
{
    public partial class ChildForm : MidiApplication.ParentForm
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
