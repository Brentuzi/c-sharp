
namespace VK.CSW.Bibl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMagazines = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMagInStock = new System.Windows.Forms.CheckBox();
            this.buttonMagAdds = new System.Windows.Forms.Button();
            this.numericUpDownMagUnitNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMagYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMagNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxMaxAutor = new System.Windows.Forms.TextBox();
            this.textBoxMaxTitle = new System.Windows.Forms.TextBox();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxInStock = new System.Windows.Forms.CheckBox();
            this.checkBoxOnTime = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownUnitNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUsePeriod = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageMagazines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagUnitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagNumber)).BeginInit();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUsePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.Location = new System.Drawing.Point(245, 30);
            this.richTextBoxReport.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.Size = new System.Drawing.Size(323, 253);
            this.richTextBoxReport.TabIndex = 1;
            this.richTextBoxReport.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMagazines);
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 346);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPageMagazines
            // 
            this.tabPageMagazines.Controls.Add(this.label10);
            this.tabPageMagazines.Controls.Add(this.label8);
            this.tabPageMagazines.Controls.Add(this.label6);
            this.tabPageMagazines.Controls.Add(this.label3);
            this.tabPageMagazines.Controls.Add(this.label1);
            this.tabPageMagazines.Controls.Add(this.checkBoxMagInStock);
            this.tabPageMagazines.Controls.Add(this.buttonMagAdds);
            this.tabPageMagazines.Controls.Add(this.numericUpDownMagUnitNumber);
            this.tabPageMagazines.Controls.Add(this.numericUpDownMagYear);
            this.tabPageMagazines.Controls.Add(this.numericUpDownMagNumber);
            this.tabPageMagazines.Controls.Add(this.textBoxMaxAutor);
            this.tabPageMagazines.Controls.Add(this.textBoxMaxTitle);
            this.tabPageMagazines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMagazines.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageMagazines.Name = "tabPageMagazines";
            this.tabPageMagazines.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageMagazines.Size = new System.Drawing.Size(212, 320);
            this.tabPageMagazines.TabIndex = 0;
            this.tabPageMagazines.Text = "Журналы";
            this.tabPageMagazines.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "инвертарный";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Год издания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "издательство";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Название";
            // 
            // checkBoxMagInStock
            // 
            this.checkBoxMagInStock.AutoSize = true;
            this.checkBoxMagInStock.Location = new System.Drawing.Point(26, 236);
            this.checkBoxMagInStock.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMagInStock.Name = "checkBoxMagInStock";
            this.checkBoxMagInStock.Size = new System.Drawing.Size(76, 17);
            this.checkBoxMagInStock.TabIndex = 33;
            this.checkBoxMagInStock.Text = "в наличии";
            this.checkBoxMagInStock.UseVisualStyleBackColor = true;
            // 
            // buttonMagAdds
            // 
            this.buttonMagAdds.Location = new System.Drawing.Point(18, 273);
            this.buttonMagAdds.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMagAdds.Name = "buttonMagAdds";
            this.buttonMagAdds.Size = new System.Drawing.Size(121, 40);
            this.buttonMagAdds.TabIndex = 31;
            this.buttonMagAdds.Text = "Add";
            this.buttonMagAdds.UseVisualStyleBackColor = true;
            this.buttonMagAdds.Click += new System.EventHandler(this.buttonMagAdd_Click);
            // 
            // numericUpDownMagUnitNumber
            // 
            this.numericUpDownMagUnitNumber.Location = new System.Drawing.Point(84, 172);
            this.numericUpDownMagUnitNumber.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMagUnitNumber.Name = "numericUpDownMagUnitNumber";
            this.numericUpDownMagUnitNumber.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMagUnitNumber.TabIndex = 25;
            // 
            // numericUpDownMagYear
            // 
            this.numericUpDownMagYear.Location = new System.Drawing.Point(84, 141);
            this.numericUpDownMagYear.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMagYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownMagYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownMagYear.Name = "numericUpDownMagYear";
            this.numericUpDownMagYear.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMagYear.TabIndex = 24;
            this.numericUpDownMagYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDownMagNumber
            // 
            this.numericUpDownMagNumber.Location = new System.Drawing.Point(84, 109);
            this.numericUpDownMagNumber.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMagNumber.Name = "numericUpDownMagNumber";
            this.numericUpDownMagNumber.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMagNumber.TabIndex = 23;
            // 
            // textBoxMaxAutor
            // 
            this.textBoxMaxAutor.Location = new System.Drawing.Point(79, 42);
            this.textBoxMaxAutor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxAutor.Name = "textBoxMaxAutor";
            this.textBoxMaxAutor.Size = new System.Drawing.Size(129, 20);
            this.textBoxMaxAutor.TabIndex = 20;
            // 
            // textBoxMaxTitle
            // 
            this.textBoxMaxTitle.Location = new System.Drawing.Point(79, 9);
            this.textBoxMaxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxTitle.Name = "textBoxMaxTitle";
            this.textBoxMaxTitle.Size = new System.Drawing.Size(129, 20);
            this.textBoxMaxTitle.TabIndex = 18;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.label12);
            this.tabPageBooks.Controls.Add(this.label11);
            this.tabPageBooks.Controls.Add(this.label9);
            this.tabPageBooks.Controls.Add(this.label7);
            this.tabPageBooks.Controls.Add(this.label5);
            this.tabPageBooks.Controls.Add(this.label4);
            this.tabPageBooks.Controls.Add(this.label2);
            this.tabPageBooks.Controls.Add(this.checkBoxInStock);
            this.tabPageBooks.Controls.Add(this.checkBoxOnTime);
            this.tabPageBooks.Controls.Add(this.buttonAdd);
            this.tabPageBooks.Controls.Add(this.numericUpDownUnitNumber);
            this.tabPageBooks.Controls.Add(this.numericUpDownUsePeriod);
            this.tabPageBooks.Controls.Add(this.numericUpDownDate);
            this.tabPageBooks.Controls.Add(this.numericUpDownPages);
            this.tabPageBooks.Controls.Add(this.textBoxPublisher);
            this.tabPageBooks.Controls.Add(this.textBoxTitle);
            this.tabPageBooks.Controls.Add(this.textBoxAuthor);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBooks.Size = new System.Drawing.Size(212, 320);
            this.tabPageBooks.TabIndex = 1;
            this.tabPageBooks.Text = "книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            this.tabPageBooks.Click += new System.EventHandler(this.tabPageBooks_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "срок пол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "инвертарный";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Год издания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Страниц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Автор";
            // 
            // checkBoxInStock
            // 
            this.checkBoxInStock.AutoSize = true;
            this.checkBoxInStock.Location = new System.Drawing.Point(26, 236);
            this.checkBoxInStock.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInStock.Name = "checkBoxInStock";
            this.checkBoxInStock.Size = new System.Drawing.Size(76, 17);
            this.checkBoxInStock.TabIndex = 33;
            this.checkBoxInStock.Text = "в наличии";
            this.checkBoxInStock.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnTime
            // 
            this.checkBoxOnTime.AutoSize = true;
            this.checkBoxOnTime.Location = new System.Drawing.Point(125, 236);
            this.checkBoxOnTime.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOnTime.Name = "checkBoxOnTime";
            this.checkBoxOnTime.Size = new System.Drawing.Size(85, 17);
            this.checkBoxOnTime.TabIndex = 32;
            this.checkBoxOnTime.Text = "ко времени";
            this.checkBoxOnTime.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 273);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 40);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownUnitNumber
            // 
            this.numericUpDownUnitNumber.Location = new System.Drawing.Point(84, 172);
            this.numericUpDownUnitNumber.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownUnitNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownUnitNumber.Name = "numericUpDownUnitNumber";
            this.numericUpDownUnitNumber.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownUnitNumber.TabIndex = 25;
            // 
            // numericUpDownUsePeriod
            // 
            this.numericUpDownUsePeriod.Location = new System.Drawing.Point(84, 205);
            this.numericUpDownUsePeriod.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownUsePeriod.Name = "numericUpDownUsePeriod";
            this.numericUpDownUsePeriod.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownUsePeriod.TabIndex = 29;
            // 
            // numericUpDownDate
            // 
            this.numericUpDownDate.Location = new System.Drawing.Point(84, 141);
            this.numericUpDownDate.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDate.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownDate.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownDate.Name = "numericUpDownDate";
            this.numericUpDownDate.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownDate.TabIndex = 24;
            this.numericUpDownDate.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Location = new System.Drawing.Point(84, 109);
            this.numericUpDownPages.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownPages.TabIndex = 23;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(79, 72);
            this.textBoxPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(129, 20);
            this.textBoxPublisher.TabIndex = 22;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(79, 33);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(129, 20);
            this.textBoxTitle.TabIndex = 20;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(79, 9);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(129, 20);
            this.textBoxAuthor.TabIndex = 18;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(245, 303);
            this.buttonView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(143, 40);
            this.buttonView.TabIndex = 35;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Location = new System.Drawing.Point(410, 313);
            this.checkBoxSort.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(90, 17);
            this.checkBoxSort.TabIndex = 36;
            this.checkBoxSort.Text = "сортировать";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 366);
            this.Controls.Add(this.checkBoxSort);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBoxReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMagazines.ResumeLayout(false);
            this.tabPageMagazines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagUnitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagNumber)).EndInit();
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUsePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMagazines;
        private System.Windows.Forms.CheckBox checkBoxMagInStock;
        private System.Windows.Forms.Button buttonMagAdds;
        private System.Windows.Forms.NumericUpDown numericUpDownMagYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMagNumber;        
        private System.Windows.Forms.TextBox textBoxMaxAutor;
        private System.Windows.Forms.TextBox textBoxMaxTitle;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.CheckBox checkBoxInStock;
        private System.Windows.Forms.CheckBox checkBoxOnTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownUnitNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownUsePeriod;
        private System.Windows.Forms.NumericUpDown numericUpDownDate;
        private System.Windows.Forms.NumericUpDown numericUpDownPages;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.CheckBox checkBoxSort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMagUnitNumber;
    }
}

