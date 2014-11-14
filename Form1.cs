using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Aaya
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		string[] Nakshatra = {"Ashwini", "Bharani", "Krittika", "Rohini", "Mrigashira", "Aaridra", "Punarvasu", "Pushya", 
					     "Ashlesha", "Makha", "Pubba", "Uttara", "Hastha", "Chitta", "Swati", "Vishakha", "Anuradha", "Jyeshta",
					     "Mula", "Purvashadha", "Uttarashadha", "Shravana", "Dhanishta", "Shatabhisha", "Purvabhadra", "Uttarabhadra", "Revathi"};

		string[] Yoga = {"Vishkambha", "Preethi", "Aayushmaan", "Soubhagya", "Shobhana", "Atiganda",
					"Sukarma", "Dhridhi", "Shula", "Ganda", "Vriddhi", "Dhruva", "Vyaghata", "Harshana",
					"Vajra", "Siddhi", "Vyateepaata", "Variyaan", "Parigha", "Shiva", "Siddha", "Saadhya",
					"Shubha", "Shukla", "Brahma", "Indra", "Vaidhriti"};

		string[] Karana = {"Bava", "Baalava", "Kaulava", "Taitala", "Garaja", "Vanik", "Bhadra", "Shakuni",
					"Chatushpaat", "Nagavaan", "Kimstughna"};

		string[] Tithi = {"Paadya", "Bidige", "Tadige", "Chouti", "Panchami", "Shashti", "Saptami", "Asthami",
					 "Navami", "Dashami", "Ekadashi", "Dwadashi", "Trayodashi", "Chaturdashi", "Poornima", 
					"Paadya", "Bidige", "Tadige", "Chouti", "Panchami", "Shashti", "Saptami", "Asthami",
					 "Navami", "Dashami", "Ekadashi", "Dwadashi", "Trayodashi", "Chaturdashi","Amaavaasye"};

		string[] Lagna = { "Mesha", "Vrishabha", "Mithuna", "Kataka", "Simha", "Kanya", "Tula", "Vrishchika", "Dhanassu", "Makara", "Kumbha", "Meena" };

		string[] Graha = { "Ravi", "Chandra", "Kuja", "Budha", "Guru", "Shukra", "Shani", "Raahu", "Ketu" };

		string[] Aaya = {"Dhwaja", "Dhoomra", "Simha", "Shunaka", "Vrishabha", "Khara", "Gaja", "Kaaka" };

		string[] Kula = { "Brahmana", "Kshatriya", "Vaishya", "Shudra" };

		#region Declarations

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.TextBox txtBreadth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtYogaVarga;
		private System.Windows.Forms.TextBox txtLagnaVarga;
		private System.Windows.Forms.TextBox txtTatwaVarga;
		private System.Windows.Forms.TextBox txtTithiVarga;
		private System.Windows.Forms.TextBox txtVaaraVarga;
		private System.Windows.Forms.TextBox txtRunaVarga;
		private System.Windows.Forms.TextBox txtDhanaVarga;
		private System.Windows.Forms.TextBox txtAayaVarga;
		private System.Windows.Forms.TextBox txtNakshatraVarga;
		private System.Windows.Forms.TextBox txtKalaVarga;
		private System.Windows.Forms.TextBox txtKulaVarga;
		private System.Windows.Forms.TextBox txtGrahaVarga;
		private System.Windows.Forms.TextBox txtAayuVarga;
		private System.Windows.Forms.TextBox txtAmshaVarga;
		private System.Windows.Forms.TextBox txtDikpatiVarga;
		private System.Windows.Forms.Button btnCalculate;

		private int nArea = 0;
		private System.Windows.Forms.TextBox txtKaranaVarga;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Label label19;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#endregion

		#region Constructor and destructor
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#endregion Constructor

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtBreadth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtYogaVarga = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtLagnaVarga = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTatwaVarga = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTithiVarga = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtVaaraVarga = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtRunaVarga = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtDhanaVarga = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtAayaVarga = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNakshatraVarga = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtKalaVarga = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtKulaVarga = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtGrahaVarga = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAayuVarga = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAmshaVarga = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDikpatiVarga = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtKaranaVarga = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Length";
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(112, 24);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(100, 20);
			this.txtLength.TabIndex = 1;
			this.txtLength.Text = "17";
			// 
			// txtBreadth
			// 
			this.txtBreadth.Location = new System.Drawing.Point(112, 56);
			this.txtBreadth.Name = "txtBreadth";
			this.txtBreadth.Size = new System.Drawing.Size(100, 20);
			this.txtBreadth.TabIndex = 3;
			this.txtBreadth.Text = "25";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Breadth";
			// 
			// txtYogaVarga
			// 
			this.txtYogaVarga.Location = new System.Drawing.Point(112, 384);
			this.txtYogaVarga.Name = "txtYogaVarga";
			this.txtYogaVarga.ReadOnly = true;
			this.txtYogaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtYogaVarga.TabIndex = 23;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(16, 384);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 13);
			this.label12.TabIndex = 22;
			this.label12.Text = "YogaVarga";
			// 
			// txtLagnaVarga
			// 
			this.txtLagnaVarga.Location = new System.Drawing.Point(112, 344);
			this.txtLagnaVarga.Name = "txtLagnaVarga";
			this.txtLagnaVarga.ReadOnly = true;
			this.txtLagnaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtLagnaVarga.TabIndex = 25;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(16, 344);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 13);
			this.label13.TabIndex = 24;
			this.label13.Text = "LagnaVarga";
			// 
			// txtTatwaVarga
			// 
			this.txtTatwaVarga.Location = new System.Drawing.Point(112, 304);
			this.txtTatwaVarga.Name = "txtTatwaVarga";
			this.txtTatwaVarga.ReadOnly = true;
			this.txtTatwaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtTatwaVarga.TabIndex = 27;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(16, 304);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 13);
			this.label14.TabIndex = 26;
			this.label14.Text = "TatwaVarga";
			// 
			// txtTithiVarga
			// 
			this.txtTithiVarga.Location = new System.Drawing.Point(112, 264);
			this.txtTithiVarga.Name = "txtTithiVarga";
			this.txtTithiVarga.ReadOnly = true;
			this.txtTithiVarga.Size = new System.Drawing.Size(100, 20);
			this.txtTithiVarga.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(16, 264);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(55, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "TithiVarga";
			// 
			// txtVaaraVarga
			// 
			this.txtVaaraVarga.Location = new System.Drawing.Point(112, 224);
			this.txtVaaraVarga.Name = "txtVaaraVarga";
			this.txtVaaraVarga.ReadOnly = true;
			this.txtVaaraVarga.Size = new System.Drawing.Size(100, 20);
			this.txtVaaraVarga.TabIndex = 31;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(16, 224);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(63, 13);
			this.label16.TabIndex = 30;
			this.label16.Text = "VaaraVarga";
			// 
			// txtRunaVarga
			// 
			this.txtRunaVarga.Location = new System.Drawing.Point(112, 184);
			this.txtRunaVarga.Name = "txtRunaVarga";
			this.txtRunaVarga.ReadOnly = true;
			this.txtRunaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtRunaVarga.TabIndex = 33;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(16, 184);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(61, 13);
			this.label17.TabIndex = 32;
			this.label17.Text = "RunaVarga";
			// 
			// txtDhanaVarga
			// 
			this.txtDhanaVarga.Location = new System.Drawing.Point(112, 144);
			this.txtDhanaVarga.Name = "txtDhanaVarga";
			this.txtDhanaVarga.ReadOnly = true;
			this.txtDhanaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtDhanaVarga.TabIndex = 35;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(16, 144);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(67, 13);
			this.label18.TabIndex = 34;
			this.label18.Text = "DhanaVarga";
			// 
			// txtAayaVarga
			// 
			this.txtAayaVarga.Location = new System.Drawing.Point(344, 264);
			this.txtAayaVarga.Name = "txtAayaVarga";
			this.txtAayaVarga.ReadOnly = true;
			this.txtAayaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtAayaVarga.TabIndex = 37;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(248, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "AayaVarga";
			// 
			// txtNakshatraVarga
			// 
			this.txtNakshatraVarga.Location = new System.Drawing.Point(344, 224);
			this.txtNakshatraVarga.Name = "txtNakshatraVarga";
			this.txtNakshatraVarga.ReadOnly = true;
			this.txtNakshatraVarga.Size = new System.Drawing.Size(100, 20);
			this.txtNakshatraVarga.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(248, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "NakshatraVarga";
			// 
			// txtKalaVarga
			// 
			this.txtKalaVarga.BackColor = System.Drawing.SystemColors.Control;
			this.txtKalaVarga.Location = new System.Drawing.Point(344, 184);
			this.txtKalaVarga.Name = "txtKalaVarga";
			this.txtKalaVarga.ReadOnly = true;
			this.txtKalaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtKalaVarga.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(248, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "KalaVarga";
			// 
			// txtKulaVarga
			// 
			this.txtKulaVarga.Location = new System.Drawing.Point(344, 144);
			this.txtKulaVarga.Name = "txtKulaVarga";
			this.txtKulaVarga.ReadOnly = true;
			this.txtKulaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtKulaVarga.TabIndex = 43;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(248, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "KulaVarga";
			// 
			// txtGrahaVarga
			// 
			this.txtGrahaVarga.Location = new System.Drawing.Point(112, 424);
			this.txtGrahaVarga.Name = "txtGrahaVarga";
			this.txtGrahaVarga.ReadOnly = true;
			this.txtGrahaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtGrahaVarga.TabIndex = 45;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 424);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 44;
			this.label7.Text = "GrahaVarga";
			// 
			// txtAayuVarga
			// 
			this.txtAayuVarga.Location = new System.Drawing.Point(344, 304);
			this.txtAayuVarga.Name = "txtAayuVarga";
			this.txtAayuVarga.ReadOnly = true;
			this.txtAayuVarga.Size = new System.Drawing.Size(100, 20);
			this.txtAayuVarga.TabIndex = 47;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(248, 304);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 13);
			this.label8.TabIndex = 46;
			this.label8.Text = "AayuVarga";
			// 
			// txtAmshaVarga
			// 
			this.txtAmshaVarga.Location = new System.Drawing.Point(344, 344);
			this.txtAmshaVarga.Name = "txtAmshaVarga";
			this.txtAmshaVarga.ReadOnly = true;
			this.txtAmshaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtAmshaVarga.TabIndex = 49;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(248, 344);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "AmshaVarga";
			// 
			// txtDikpatiVarga
			// 
			this.txtDikpatiVarga.Location = new System.Drawing.Point(344, 384);
			this.txtDikpatiVarga.Name = "txtDikpatiVarga";
			this.txtDikpatiVarga.ReadOnly = true;
			this.txtDikpatiVarga.Size = new System.Drawing.Size(100, 20);
			this.txtDikpatiVarga.TabIndex = 51;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(248, 384);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 13);
			this.label10.TabIndex = 50;
			this.label10.Text = "DikpatiVarga";
			// 
			// txtKaranaVarga
			// 
			this.txtKaranaVarga.Location = new System.Drawing.Point(344, 424);
			this.txtKaranaVarga.Name = "txtKaranaVarga";
			this.txtKaranaVarga.ReadOnly = true;
			this.txtKaranaVarga.Size = new System.Drawing.Size(100, 20);
			this.txtKaranaVarga.TabIndex = 53;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(248, 424);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 13);
			this.label11.TabIndex = 52;
			this.label11.Text = "KaranaVarga";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(272, 16);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(136, 56);
			this.btnCalculate.TabIndex = 54;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(112, 104);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(100, 20);
			this.txtArea.TabIndex = 56;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(16, 104);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(29, 13);
			this.label19.TabIndex = 55;
			this.label19.Text = "Area";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 462);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtKaranaVarga);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtDikpatiVarga);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtAmshaVarga);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtAayuVarga);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtGrahaVarga);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtKulaVarga);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtKalaVarga);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNakshatraVarga);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAayaVarga);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDhanaVarga);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtRunaVarga);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtVaaraVarga);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.txtTithiVarga);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtTatwaVarga);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtLagnaVarga);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtYogaVarga);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtBreadth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
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
			Application.Run(new Form1());
		}

		private void btnCalculate_Click(object sender, System.EventArgs e)
		{
			/*nArea = 0;
			string area = txtArea.Text;
			if(area.Length > 0)
				nArea = Convert.ToInt32(area);

			if (nArea <= 0)*/
			
				double fLength = Convert.ToDouble(txtLength.Text);
				double fBreadth = Convert.ToDouble(txtBreadth.Text);
				nArea = (int)Math.Round(fLength * fBreadth);
			

			int nDhanaVarga = GetVarga(8, 12);
			int nRunaVarga = GetVarga(3, 8);
			int nVaaraVarga = GetVarga(9, 7);
			int nTithiVarga = GetVarga(6, 30);
			int nTatwaVarga = GetVarga(3, 5);
			int nLagnaVarga = GetVarga(9, 12);
			int nYogaVarga = GetVarga(4, 27);
			int nGrahaVarga = GetVarga(5, 9);
			int nKulaVarga = GetVarga(9, 4);
			int nKalaVarga = GetVarga(12, 16);
			int nNakshatraVarga = GetVarga(8, 27);
			int nAayaVarga = GetVarga(9, 8);
			int nAayuVarga = GetVarga(9, 120);
			int nAmshaVarga = GetVarga(6, 9);
			int nDikpatiVarga = GetVarga(9, 8);
			int nKaranaVarga = GetVarga(5, 11);

			DayOfWeek dow = (DayOfWeek)(nVaaraVarga % 7);

			txtArea.Text = nArea.ToString();
			txtDhanaVarga.Text = nDhanaVarga.ToString();
			txtRunaVarga.Text = nRunaVarga.ToString();
			txtVaaraVarga.Text = dow.ToString() + "(" + nVaaraVarga.ToString() + ")";
			txtTithiVarga.Text = Tithi[nTithiVarga - 1] + "(" + nTithiVarga.ToString() + ")";
			txtTatwaVarga.Text = nTatwaVarga.ToString();
			txtLagnaVarga.Text = Lagna[nLagnaVarga - 1] + "(" + nLagnaVarga.ToString() + ")";
			txtYogaVarga.Text = Yoga[nYogaVarga - 1] + "(" + nYogaVarga.ToString() + ")";
			txtGrahaVarga.Text = Graha[nGrahaVarga - 1] + "(" + nGrahaVarga.ToString() + ")";
			txtKulaVarga.Text = Kula[nKulaVarga - 1] + "(" + nKulaVarga.ToString() + ")";
			txtKalaVarga.Text = nKalaVarga.ToString();
			txtNakshatraVarga.Text = Nakshatra[nNakshatraVarga - 1] + "(" + nNakshatraVarga.ToString() + ")";
			txtAayaVarga.Text = Aaya[nAayaVarga - 1] + "(" + nAayaVarga.ToString() + ")";
			txtAayuVarga.Text = nAayuVarga.ToString();
			txtAmshaVarga.Text = nAmshaVarga.ToString();
			txtDikpatiVarga.Text = nDikpatiVarga.ToString();
			txtKaranaVarga.Text = Karana[nKaranaVarga - 1] + "(" + nKaranaVarga.ToString() + ")";

			Color goodColor = Color.FromKnownColor(KnownColor.Control);
			Color badColor = Color.Red;
			///Validation.
			if (nDhanaVarga < nRunaVarga)
			{
				txtDhanaVarga.BackColor = badColor;
				txtRunaVarga.BackColor = badColor;
			}
			else
			{
				txtDhanaVarga.BackColor = goodColor;
				txtRunaVarga.BackColor = goodColor;

			}

			//VaaraVarga
			if (nVaaraVarga == 1 || nVaaraVarga == 3 || nVaaraVarga == 0)
			{
				txtVaaraVarga.BackColor = badColor;
			}
			else
			{
				txtVaaraVarga.BackColor = goodColor;
			}

			//TithiVarga

			//AayaVarga
			int[] GoodAayas = {1, 3, 5};
			if (Array.Exists(GoodAayas, element => element == nAayaVarga))
			{
				txtAayaVarga.BackColor = goodColor;
			}
			else
			{
				txtAayaVarga.BackColor = badColor;
			}

			if (nAayuVarga < 50)
			{
				txtAayuVarga.BackColor = badColor;
			}
			else
			{
				txtAayuVarga.BackColor = goodColor;
			}

		}

		private int GetVarga(int nMultiplier, int nDivisor)
		{
			int nVarga = nArea * nMultiplier % nDivisor;

			if(nVarga == 0)
				nVarga = nDivisor;

			return nVarga;
		}
	}
}