using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
		public class Calc : System.Windows.Forms.Form
    {
        public TextBox txtOutput;
        private System.Windows.Forms.Button btn_sbros;
		private System.Windows.Forms.Button btnChangesign;
		private System.Windows.Forms.Button btnpoint;
		private System.Windows.Forms.Button btn_ravno;
		private System.Windows.Forms.Button btn_delenie;
		private System.Windows.Forms.Button btn_umnojenie;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.ComponentModel.Container components = null;
		/// <summary>
		/// ��������� � �������������� ����������, ������� �����
		///  ��������� �� ������ ��� ������� ��������������� ������.
		/// </summary>
		private const string odin = "1";
		private const string dva = "2";
		private const string tri = "3";
		private const string chetire = "4";
		private const string pyat = "5";
		private const string shest = "6";
		private const string sem = "7";
		private const string vosem = "8";
		private const string devyat = "9";
        private Button btn_kv;
        private Button button1;
        private Button btn_sqrt;
        private Button button2;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        public Button button3;
        private const string nul = "0";

		public Calc()
		{
			InitializeComponent();
			// ��� ������� ���������� �� ������ ����� ����
			txtOutput.Text = "0";
		
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_kv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(32, 64);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(427, 26);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Location = new System.Drawing.Point(238, 120);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(154, 40);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangesign.Location = new System.Drawing.Point(76, 331);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(71, 40);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.UseVisualStyleBackColor = false;
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.BackColor = System.Drawing.SystemColors.Control;
            this.btnpoint.Location = new System.Drawing.Point(238, 331);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(77, 40);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.Location = new System.Drawing.Point(321, 331);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(71, 40);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.Location = new System.Drawing.Point(321, 166);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(71, 40);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.Location = new System.Drawing.Point(321, 205);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(71, 40);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.Location = new System.Drawing.Point(321, 285);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(71, 40);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.Location = new System.Drawing.Point(321, 245);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(71, 40);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.Location = new System.Drawing.Point(153, 331);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 40);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(238, 205);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 40);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(153, 205);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 40);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(75, 205);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 40);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(238, 245);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 40);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(153, 245);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 40);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(75, 245);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 40);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(238, 285);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 40);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(153, 285);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 40);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(75, 285);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 40);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn_kv
            // 
            this.btn_kv.AccessibleName = "plus ";
            this.btn_kv.Location = new System.Drawing.Point(153, 166);
            this.btn_kv.Name = "btn_kv";
            this.btn_kv.Size = new System.Drawing.Size(79, 40);
            this.btn_kv.TabIndex = 61;
            this.btn_kv.Text = "x^2";
            this.btn_kv.Click += new System.EventHandler(this.btn_kv_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "plus ";
            this.button1.Location = new System.Drawing.Point(75, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 40);
            this.button1.TabIndex = 62;
            this.button1.Text = "1/x";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.AccessibleName = "plus ";
            this.btn_sqrt.Location = new System.Drawing.Point(236, 166);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(79, 40);
            this.btn_sqrt.TabIndex = 63;
            this.btn_sqrt.Text = "sqrt";
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "plus ";
            this.button2.Location = new System.Drawing.Point(153, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 40);
            this.button2.TabIndex = 64;
            this.button2.Text = "x^n";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 66;
            this.button3.Text = "�����������";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(502, 421);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kv);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�����������";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Calc());
		}
		/// <summary>
		/// ����������� ��� ������  ���������� � ������ chislonaEkrane ������ mehanizmcalkulyatora
		/// � �������� ��� ���� �� ���������� (odin, dva, tri  � �.�.). ���������, ������������ �������,
		/// �������������  �������� Text ���������� ���� txtOutput.
		/// </summary>

			private void btn1_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (odin);
			}

			private void btn2_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (dva);
			}

			private void btn3_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (tri);
			}

			private void btn4_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (chetire);
			}

			private void btn5_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (pyat);
			}

			private void btn6_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (shest);
			}

			private void btn7_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (sem);
			}

			private void btn8_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (vosem);
			}

			private void btn9_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (devyat);
			}

			private void btn0_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (nul);
			}

			private void btnChangesign_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
			}

			private void btnpoint_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
			}
			/// <summary>
			/// ����������� ������ �������� ������������ �������� 
			/// ������ DeystvieCalculatora ������ mehanizmcalkulyatora ���������� ������������ Deystvie.
			/// </summary>
		
			private void btn_delenie_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Delenie);
			}

			private void btn_umnojenie_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Umnojenie);
			}


			private void btn_minus_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vichitanie);
			}

			private void btn_plus_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Slojenie);
			}

			private void btn_ravno_Click(object sender, System.EventArgs e)
			{
				txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
				mehanizmcalkulyatora.Sbros();
			}

			private void btn_sbros_Click(object sender, System.EventArgs e)
			{
				mehanizmcalkulyatora.Sbros();
				txtOutput.Text = "0";
			}

        private void btn_kv_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.KvChisla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.OdinChisla();
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.PsqrTo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Vsten);
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {
            Application.Run(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form2 newForm = new Form2();
            newForm.Show();
         

        }
    }
    class mehanizmcalkulyatora
	{
	/// <summary>
	///������� ������������ Deystvie, ��� ����������� ������ �� ������� �������� ������������.
	/// </summary>
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            Vsten=5
		}

	/// <summary>
	/// ��������� � �������������� ����������, 
	/// ������� ����� �������������� ��� ����� ����� ��� ������� ������� (+/-)
	/// </summary>

		private static double peremennayaMinus = -1;

        /// <summary>
        /// �������� ����������, ��� ������ ������������:
        /// resultatVichisleniy - ���������� ��� ��������
        ///  �������������� ���������� � ��������� ������������
        ///  resultatOutput - ����������, �������� ������� ����� ��������� � ������ �  ���������� �� ����.
        ///  tekusheeDeystvieCalculatora - �������� ������ �� �������� ������������.
        ///  pervoeChislo - ����������, � ������� ����� ������������ ����� �� ������
        ///   �� ������� �� ���� �� ������� ������ � ���������.
        ///  vtoroeChislo - ������ ����� �� ������.
        ///  dobavlenierazryada ��� ���������� ����������  ������� ��� ���������� ������ �������� true;
        ///  ChislosTochkoy ��� ���������� ����������� ������� (����� �����) ��� ���������� ������ �������� true
        /// </summary>

        public static double resultatVichisleniy;
		public static string resultatOutput;
        public static Deystvie tekusheeDeystvieCalculatora;
        public static double pervoeChislo;
        public static double vtoroeChislo;
        public static bool dobavlenierazryada;
        public static bool ChislosTochkoy;
 
		/// <summary>
		/// � ������������ ������ mehanizmcalkulyatora �������������� ���������� 
		/// ChislosTochkoy � dobavlenierazryada - ��� ������� ������������ �� ������ 
		/// ��� �� �����������, �� ���������� �����.
		/// </summary>

		public mehanizmcalkulyatora ()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}

			
		/// <summary>
		/// � ���� ������ ���������� resultatOutput ���������� - ��� ����� ����� �� �������� ����������������.
		/// </summary>
		

		public static string chislonaEkrane (string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}
		/// <summary>
		/// �����, � ������� ������������ peremenDeystviya - ���� �������� ������������ Deystvie,
		///� ����������� �� ������  ������� +, -, *,  ��� /
		/// </summary>
	
		public static void DeystvieCalculatora (Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble (resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;
				}			
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
			
			}
		}



	/// <summary>
	/// ��� �������  ������ +/- ����� �� ������ - tekusheeChislo ���������� �� -1,
	///  � ����� ��������� ����� ������������� ���������� resultatOutput.
	/// </summary>
	

		public static string ZnakChisla ()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble (resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}
		
			return (resultatOutput);
		}

        public static string KvChisla()
        {
            double tekusheeChislo;

            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(tekusheeChislo * tekusheeChislo);
            }

            return (resultatOutput);
        }
        public static string OdinChisla()
        {
            double tekusheeChislo;

            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(1/ tekusheeChislo);
            }

            return (resultatOutput);
        }
        
public static string PsqrTo()
        {
            double tekusheeChislo;

            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(Math.Sqrt(tekusheeChislo));
            }

            return (resultatOutput);
        }
        /// <summary>
        /// ��� ������� ������ ( , ) ���������� resultatOutput ����������� ������� �����.
        /// </summary>


        public static string ZnakTochki ()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != "")
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

	/// <summary>
	/// ��� ������� ������ ZnakRavno �������������� �������� 
	/// ����������� pervoeChislo � vtoroeChislo, ��������� ������������� ���������� resultatVichisleniy 
	/// �������  ����� ������������� � resultatOutput.
	/// </summary>


		public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble (resultatOutput);
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = pervoeChislo + vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = pervoeChislo / vtoroeChislo;
						proverkaOshibok = true;
						break;
                    case Deystvie.Vsten:
                        resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo) ;
                        proverkaOshibok = true;
                        break;
                    default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (resultatVichisleniy);
			}
			
			return (resultatOutput);
		}

	/// <summary>
	/// ��� ������� ������  � (�����) �������� ���������� ����������.
	/// </summary>

		public static void Sbros ()
		{
			resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;			
		}
	}
}
