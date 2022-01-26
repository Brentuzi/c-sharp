using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK.CSW.Bibl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<MyClass.Item> its = new List<MyClass.Item>();

        public string Author // автор
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }
        public string Title // Название
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBoxPublisher.Text; }
            set { textBoxPublisher.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDownPages.Value; }
            set { numericUpDownPages.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDownDate.Value; }
            set { numericUpDownDate.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDownUnitNumber.Value; }
            set { numericUpDownUnitNumber.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBoxInStock.Checked; }
            set { checkBoxInStock.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBoxSort.Checked; }
            set { checkBoxSort.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBoxOnTime.Checked; }
            set { checkBoxOnTime.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDownUnitNumber.Value; }
            set { numericUpDownUnitNumber.Value = value; }
        }

        public int MagNumber
        {
            get { return (int)numericUpDownMagNumber.Value; }
            set { numericUpDownMagNumber.Value = value; }
        }

        public String MagVolume
        {
            get { return textBoxMaxAutor.Text;  }
            set { textBoxMaxAutor.Text = value; }
        }

        public string MagTitle // Название
        {
            get { return textBoxMaxTitle.Text; }
            set { textBoxMaxTitle.Text = value; }
        }

        public int MagYear // Год издания
        {
            get { return (int)numericUpDownMagYear.Value; }
            set { numericUpDownMagYear.Value = value; }
        }

        public int MagInvNumber // Инвентарный номер
        {
            get { return (int)numericUpDownMagUnitNumber.Value; }
            set { numericUpDownMagUnitNumber.Value = value; }
        }

        public bool MagExistence // Наличие
        {
            get { return checkBoxMagInStock.Checked; }
            set { checkBoxMagInStock.Checked = value; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MyClass.Book b = new MyClass.Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (MyClass.Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBoxReport.Text = sb.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonMagAdd_Click(object sender, EventArgs e)
        {
            MyClass.Magazine m = new MyClass.Magazine(MagVolume, MagNumber, MagTitle, MagYear, MagInvNumber, MagExistence);
           
            its.Add(m);
        }

        private void checkBoxMagSubscribe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPageBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
