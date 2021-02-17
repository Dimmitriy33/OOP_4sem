
namespace OOP_Lab2
{
    partial class Manufacturer
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
            this.CountryValue = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.ManufacturerNameValue = new System.Windows.Forms.TextBox();
            this.ManufacturerName = new System.Windows.Forms.Label();
            this.ManufacuturerHead = new System.Windows.Forms.Label();
            this.YearOfFoundationValue = new System.Windows.Forms.NumericUpDown();
            this.YearOfFoundation = new System.Windows.Forms.Label();
            this.TypesOfAircraft = new System.Windows.Forms.Label();
            this.TypesOfAircraftList = new System.Windows.Forms.CheckedListBox();
            this.PushInfoAboutManufacturer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearOfFoundationValue)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryValue
            // 
            this.CountryValue.Location = new System.Drawing.Point(109, 102);
            this.CountryValue.Name = "CountryValue";
            this.CountryValue.Size = new System.Drawing.Size(164, 22);
            this.CountryValue.TabIndex = 46;
            this.CountryValue.TextChanged += new System.EventHandler(this.CountryValue_TextChanged);
            this.CountryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters_KeyPress);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(20, 102);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(56, 17);
            this.Country.TabIndex = 45;
            this.Country.Text = "Страна";
            // 
            // ManufacturerNameValue
            // 
            this.ManufacturerNameValue.Location = new System.Drawing.Point(109, 72);
            this.ManufacturerNameValue.Name = "ManufacturerNameValue";
            this.ManufacturerNameValue.Size = new System.Drawing.Size(164, 22);
            this.ManufacturerNameValue.TabIndex = 42;
            this.ManufacturerNameValue.TextChanged += new System.EventHandler(this.ManufacturerNameValue_TextChanged);
            this.ManufacturerNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters_KeyPress);
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.AutoSize = true;
            this.ManufacturerName.Location = new System.Drawing.Point(20, 72);
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.Size = new System.Drawing.Size(72, 17);
            this.ManufacturerName.TabIndex = 41;
            this.ManufacturerName.Text = "Название";
            // 
            // ManufacuturerHead
            // 
            this.ManufacuturerHead.AutoSize = true;
            this.ManufacuturerHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacuturerHead.Location = new System.Drawing.Point(18, 21);
            this.ManufacuturerHead.Name = "ManufacuturerHead";
            this.ManufacuturerHead.Size = new System.Drawing.Size(172, 25);
            this.ManufacuturerHead.TabIndex = 47;
            this.ManufacuturerHead.Text = "Производитель";
            // 
            // YearOfFoundationValue
            // 
            this.YearOfFoundationValue.Location = new System.Drawing.Point(148, 134);
            this.YearOfFoundationValue.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.YearOfFoundationValue.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.YearOfFoundationValue.Name = "YearOfFoundationValue";
            this.YearOfFoundationValue.Size = new System.Drawing.Size(125, 22);
            this.YearOfFoundationValue.TabIndex = 49;
            this.YearOfFoundationValue.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.YearOfFoundationValue.ValueChanged += new System.EventHandler(this.YearOfFoundationValue_ValueChanged);
            // 
            // YearOfFoundation
            // 
            this.YearOfFoundation.AutoSize = true;
            this.YearOfFoundation.Location = new System.Drawing.Point(20, 134);
            this.YearOfFoundation.Name = "YearOfFoundation";
            this.YearOfFoundation.Size = new System.Drawing.Size(106, 17);
            this.YearOfFoundation.TabIndex = 48;
            this.YearOfFoundation.Text = "Год основания";
            // 
            // TypesOfAircraft
            // 
            this.TypesOfAircraft.AutoSize = true;
            this.TypesOfAircraft.Location = new System.Drawing.Point(20, 167);
            this.TypesOfAircraft.Name = "TypesOfAircraft";
            this.TypesOfAircraft.Size = new System.Drawing.Size(216, 17);
            this.TypesOfAircraft.TabIndex = 50;
            this.TypesOfAircraft.Text = "Типы производимых самолетов";
            // 
            // TypesOfAircraftList
            // 
            this.TypesOfAircraftList.FormattingEnabled = true;
            this.TypesOfAircraftList.Items.AddRange(new object[] {
            "поршневые",
            "турбовинтовые",
            "турбореактивные",
            "с ракетными двигателями",
            "с электрическими двигателями"});
            this.TypesOfAircraftList.Location = new System.Drawing.Point(26, 196);
            this.TypesOfAircraftList.Name = "TypesOfAircraftList";
            this.TypesOfAircraftList.Size = new System.Drawing.Size(247, 89);
            this.TypesOfAircraftList.TabIndex = 51;
            this.TypesOfAircraftList.SelectedIndexChanged += new System.EventHandler(this.TypesOfAircraftList_SelectedIndexChanged);
            // 
            // PushInfoAboutManufacturer
            // 
            this.PushInfoAboutManufacturer.BackColor = System.Drawing.Color.LightCoral;
            this.PushInfoAboutManufacturer.Location = new System.Drawing.Point(54, 297);
            this.PushInfoAboutManufacturer.Name = "PushInfoAboutManufacturer";
            this.PushInfoAboutManufacturer.Size = new System.Drawing.Size(182, 56);
            this.PushInfoAboutManufacturer.TabIndex = 52;
            this.PushInfoAboutManufacturer.Text = "Занести информацию о производителе";
            this.PushInfoAboutManufacturer.UseVisualStyleBackColor = false;
            this.PushInfoAboutManufacturer.Click += new System.EventHandler(this.PushInfoAboutManufacturer_Click);
            // 
            // Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 365);
            this.Controls.Add(this.PushInfoAboutManufacturer);
            this.Controls.Add(this.TypesOfAircraftList);
            this.Controls.Add(this.TypesOfAircraft);
            this.Controls.Add(this.YearOfFoundationValue);
            this.Controls.Add(this.YearOfFoundation);
            this.Controls.Add(this.ManufacuturerHead);
            this.Controls.Add(this.CountryValue);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.ManufacturerNameValue);
            this.Controls.Add(this.ManufacturerName);
            this.Name = "Manufacturer";
            ((System.ComponentModel.ISupportInitialize)(this.YearOfFoundationValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountryValue;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox ManufacturerNameValue;
        private System.Windows.Forms.Label ManufacturerName;
        private System.Windows.Forms.Label ManufacuturerHead;
        private System.Windows.Forms.NumericUpDown YearOfFoundationValue;
        private System.Windows.Forms.Label YearOfFoundation;
        private System.Windows.Forms.Label TypesOfAircraft;
        private System.Windows.Forms.CheckedListBox TypesOfAircraftList;
        private System.Windows.Forms.Button PushInfoAboutManufacturer;
    }
}