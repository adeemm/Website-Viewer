using System.IO;
using System.Windows.Forms;

namespace Website_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bypass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "________________________________________________________";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(3, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(210, 20);
            this.urlBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(219, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = ": Website URL";
            // 
            // bypass
            // 
            this.bypass.FormattingEnabled = true;
            this.bypass.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "AmericanSamoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "AntiguaAndBarbuda",
            "Argentina",
            "Armenia",
            "AscensionIsland",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "BosniaAndHerzegovina",
            "Botswana",
            "Brazil",
            "BritishIndianOceanTerritory",
            "BritishVirginIslands",
            "Brunei",
            "Bulgaria",
            "BurkinaFaso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "CapeVerde",
            "CatalanCountries",
            "CentralAfricanRepublic",
            "Chad",
            "Chile",
            "China",
            "CocosIslands",
            "Colombia",
            "CookIslands",
            "CostaRica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "CzechRepublic",
            "DemocraticRepublicCongo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "DominicanRepublic",
            "Ecuador",
            "Egypt",
            "ElSalvador",
            "Estonia",
            "Ethiopia",
            "FederatedStatesofMicronesia",
            "Fiji",
            "Finland",
            "France",
            "FrenchGuiana",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Guadeloupe",
            "Guatemala",
            "Guernsey",
            "Guyana",
            "Haiti",
            "Honduras",
            "HongKong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "IsleofMan",
            "Israel",
            "Italy",
            "IvoryCoast",
            "Jamaica",
            "Japan",
            "Jersey",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Mauritius",
            "Mexico",
            "Moldova",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "NewZealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "NorfolkIsland",
            "Normal",
            "Norway",
            "Oman",
            "Pakistan",
            "Palestine",
            "Panama",
            "PapuaNewGuinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "PitcairnIslands",
            "Poland",
            "Portugal",
            "PuertoRico",
            "Qatar",
            "RepublicCongo",
            "Romania",
            "Russia",
            "Rwanda",
            "SaintHelenaAndTristanDaCunha",
            "SaintLucia",
            "SaintVincentAndGrenadines",
            "Samoa",
            "SanMarino",
            "SãoToméAndPríncipe",
            "SaudiArabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "SierraLeone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "SolomonIslands",
            "Somalia",
            "SouthAfrica",
            "SouthKorea",
            "Spain",
            "SriLanka",
            "Sweden",
            "Switzerland",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "TimorLeste",
            "Togo",
            "Tokelau",
            "Tonga",
            "TrinidadAndTobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Uganda",
            "Ukraine",
            "UnitedArabEmirates",
            "UnitedKingdom",
            "UnitedStates",
            "UnitedStatesVirginIslands",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Zambia",
            "Zimbabwe"});
            this.bypass.Location = new System.Drawing.Point(3, 60);
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(195, 21);
            this.bypass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(204, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = ": Bypass Method";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelX1.Location = new System.Drawing.Point(12, 169);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(303, 30);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Created By TotalCurryMan";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonX1.Location = new System.Drawing.Point(105, 107);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(122, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "Visit Website";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 194);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bypass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bypass;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}

