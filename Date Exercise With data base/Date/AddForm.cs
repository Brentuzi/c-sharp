using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                
                nRow[0] = addname.Text;
                nRow[1] = secname.Text;
                nRow[2] = lastname.Text;
                nRow[3] = age.Text;
                nRow[4] = pass.Text;
                nRow[5] = adres.Text;
                nRow[6] = email.Text;
                main.testDataSet.Tables[0].Rows.Add(nRow);
                main.mainTableAdapter.Update(main.testDataSet.main);
                main.testDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
               /* tbName.Text = "";
                tbPhone.Text = "";
                tbMail.Text = "";
                tbPhoto.Text = "";*/
            }
        }
    }
}
