
namespace OOP_Lab2
{
    partial class AirplaneInfo
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
            this.Number = new System.Windows.Forms.Label();
            this.NumberValue = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.TypeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.TypeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.TypeRadioButton3 = new System.Windows.Forms.RadioButton();
            this.Model = new System.Windows.Forms.Label();
            this.ModelValue = new System.Windows.Forms.TextBox();
            this.DateOfTheLatestMaintenance = new System.Windows.Forms.Label();
            this.CarryingValue = new System.Windows.Forms.NumericUpDown();
            this.Carrying = new System.Windows.Forms.Label();
            this.YearOfIssueValue = new System.Windows.Forms.NumericUpDown();
            this.YearOfIssue = new System.Windows.Forms.Label();
            this.NumberOfPassengersValue = new System.Windows.Forms.NumericUpDown();
            this.NumberOfPassengers = new System.Windows.Forms.Label();
            this.CrewMemberLinkButton = new System.Windows.Forms.Button();
            this.AirplaneHead = new System.Windows.Forms.Label();
            this.AirplaneManufacturerLinkButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Push_Info_button = new System.Windows.Forms.Button();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.ShowInfoAboutAirplanes_Button = new System.Windows.Forms.Button();
            this.OutTextValue = new System.Windows.Forms.TextBox();
            this.OutText = new System.Windows.Forms.Label();
            this.WriteInfoAboutAirplanes_Button = new System.Windows.Forms.Button();
            this.CreateAirportInfrastructure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarryingValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearOfIssueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPassengersValue)).BeginInit();
            this.groupType.SuspendLayout();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(7, 183);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(118, 17);
            this.Number.TabIndex = 0;
            this.Number.Text = "Номер самолета";
            // 
            // NumberValue
            // 
            this.NumberValue.Location = new System.Drawing.Point(10, 203);
            this.NumberValue.Name = "NumberValue";
            this.NumberValue.Size = new System.Drawing.Size(110, 22);
            this.NumberValue.TabIndex = 1;
            this.NumberValue.TextChanged += new System.EventHandler(this.NumberValue_TextChanged);
            this.NumberValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberValue_KeyPress);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(6, 15);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 17);
            this.Type.TabIndex = 2;
            this.Type.Text = "Тип самолета";
            // 
            // TypeRadioButton1
            // 
            this.TypeRadioButton1.AutoSize = true;
            this.TypeRadioButton1.Location = new System.Drawing.Point(6, 38);
            this.TypeRadioButton1.Name = "TypeRadioButton1";
            this.TypeRadioButton1.Size = new System.Drawing.Size(122, 21);
            this.TypeRadioButton1.TabIndex = 3;
            this.TypeRadioButton1.TabStop = true;
            this.TypeRadioButton1.Text = "пассажирский";
            this.TypeRadioButton1.UseVisualStyleBackColor = true;
            this.TypeRadioButton1.CheckedChanged += new System.EventHandler(this.TypeRadioButtons_CheckedChanged);
            // 
            // TypeRadioButton2
            // 
            this.TypeRadioButton2.AutoSize = true;
            this.TypeRadioButton2.Location = new System.Drawing.Point(6, 63);
            this.TypeRadioButton2.Name = "TypeRadioButton2";
            this.TypeRadioButton2.Size = new System.Drawing.Size(87, 21);
            this.TypeRadioButton2.TabIndex = 4;
            this.TypeRadioButton2.TabStop = true;
            this.TypeRadioButton2.Text = "грузовой";
            this.TypeRadioButton2.UseVisualStyleBackColor = true;
            this.TypeRadioButton2.CheckedChanged += new System.EventHandler(this.TypeRadioButtons_CheckedChanged);
            // 
            // TypeRadioButton3
            // 
            this.TypeRadioButton3.AutoSize = true;
            this.TypeRadioButton3.Location = new System.Drawing.Point(6, 88);
            this.TypeRadioButton3.Name = "TypeRadioButton3";
            this.TypeRadioButton3.Size = new System.Drawing.Size(86, 21);
            this.TypeRadioButton3.TabIndex = 5;
            this.TypeRadioButton3.TabStop = true;
            this.TypeRadioButton3.Text = "военный";
            this.TypeRadioButton3.UseVisualStyleBackColor = true;
            this.TypeRadioButton3.CheckedChanged += new System.EventHandler(this.TypeRadioButtons_CheckedChanged);
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(7, 240);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(125, 17);
            this.Model.TabIndex = 6;
            this.Model.Text = "Модель самолета";
            // 
            // ModelValue
            // 
            this.ModelValue.Location = new System.Drawing.Point(10, 260);
            this.ModelValue.Name = "ModelValue";
            this.ModelValue.Size = new System.Drawing.Size(110, 22);
            this.ModelValue.TabIndex = 7;
            this.ModelValue.TextChanged += new System.EventHandler(this.ModelValue_TextChanged);
            this.ModelValue.Validating += new System.ComponentModel.CancelEventHandler(this.ModelValue_Validating);
            // 
            // DateOfTheLatestMaintenance
            // 
            this.DateOfTheLatestMaintenance.AutoSize = true;
            this.DateOfTheLatestMaintenance.Location = new System.Drawing.Point(157, 238);
            this.DateOfTheLatestMaintenance.Name = "DateOfTheLatestMaintenance";
            this.DateOfTheLatestMaintenance.Size = new System.Drawing.Size(249, 17);
            this.DateOfTheLatestMaintenance.TabIndex = 30;
            this.DateOfTheLatestMaintenance.Text = "Дата последнего тех. обслуживания";
            // 
            // CarryingValue
            // 
            this.CarryingValue.Location = new System.Drawing.Point(160, 209);
            this.CarryingValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CarryingValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CarryingValue.Name = "CarryingValue";
            this.CarryingValue.Size = new System.Drawing.Size(109, 22);
            this.CarryingValue.TabIndex = 29;
            this.CarryingValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CarryingValue.ValueChanged += new System.EventHandler(this.CarryingValue_ValueChanged);
            // 
            // Carrying
            // 
            this.Carrying.AutoSize = true;
            this.Carrying.Location = new System.Drawing.Point(157, 189);
            this.Carrying.Name = "Carrying";
            this.Carrying.Size = new System.Drawing.Size(133, 17);
            this.Carrying.TabIndex = 28;
            this.Carrying.Text = "Грузоподъемность";
            // 
            // YearOfIssueValue
            // 
            this.YearOfIssueValue.Location = new System.Drawing.Point(160, 155);
            this.YearOfIssueValue.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.YearOfIssueValue.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.YearOfIssueValue.Name = "YearOfIssueValue";
            this.YearOfIssueValue.Size = new System.Drawing.Size(109, 22);
            this.YearOfIssueValue.TabIndex = 27;
            this.YearOfIssueValue.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.YearOfIssueValue.ValueChanged += new System.EventHandler(this.YearOfIssueValue_ValueChanged);
            // 
            // YearOfIssue
            // 
            this.YearOfIssue.AutoSize = true;
            this.YearOfIssue.Location = new System.Drawing.Point(157, 135);
            this.YearOfIssue.Name = "YearOfIssue";
            this.YearOfIssue.Size = new System.Drawing.Size(90, 17);
            this.YearOfIssue.TabIndex = 26;
            this.YearOfIssue.Text = "Год выпуска";
            // 
            // NumberOfPassengersValue
            // 
            this.NumberOfPassengersValue.Location = new System.Drawing.Point(160, 101);
            this.NumberOfPassengersValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberOfPassengersValue.Name = "NumberOfPassengersValue";
            this.NumberOfPassengersValue.Size = new System.Drawing.Size(109, 22);
            this.NumberOfPassengersValue.TabIndex = 25;
            this.NumberOfPassengersValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPassengersValue.ValueChanged += new System.EventHandler(this.NumberOfPassengersValue_ValueChanged);
            // 
            // NumberOfPassengers
            // 
            this.NumberOfPassengers.AutoSize = true;
            this.NumberOfPassengers.Location = new System.Drawing.Point(157, 81);
            this.NumberOfPassengers.Name = "NumberOfPassengers";
            this.NumberOfPassengers.Size = new System.Drawing.Size(216, 17);
            this.NumberOfPassengers.TabIndex = 24;
            this.NumberOfPassengers.Text = "Количество пассажирских мест";
            // 
            // CrewMemberLinkButton
            // 
            this.CrewMemberLinkButton.Location = new System.Drawing.Point(12, 313);
            this.CrewMemberLinkButton.Name = "CrewMemberLinkButton";
            this.CrewMemberLinkButton.Size = new System.Drawing.Size(124, 56);
            this.CrewMemberLinkButton.TabIndex = 32;
            this.CrewMemberLinkButton.Text = "Информация о членах экипажа";
            this.CrewMemberLinkButton.UseVisualStyleBackColor = true;
            this.CrewMemberLinkButton.Click += new System.EventHandler(this.CrewMemberLinkButton_Click);
            // 
            // AirplaneHead
            // 
            this.AirplaneHead.AutoSize = true;
            this.AirplaneHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirplaneHead.Location = new System.Drawing.Point(5, 9);
            this.AirplaneHead.Name = "AirplaneHead";
            this.AirplaneHead.Size = new System.Drawing.Size(105, 25);
            this.AirplaneHead.TabIndex = 33;
            this.AirplaneHead.Text = "Самолет";
            // 
            // AirplaneManufacturerLinkButton
            // 
            this.AirplaneManufacturerLinkButton.Location = new System.Drawing.Point(12, 385);
            this.AirplaneManufacturerLinkButton.Name = "AirplaneManufacturerLinkButton";
            this.AirplaneManufacturerLinkButton.Size = new System.Drawing.Size(124, 56);
            this.AirplaneManufacturerLinkButton.TabIndex = 34;
            this.AirplaneManufacturerLinkButton.Text = "Информация о производителе";
            this.AirplaneManufacturerLinkButton.UseVisualStyleBackColor = true;
            this.AirplaneManufacturerLinkButton.Click += new System.EventHandler(this.AirplaneManufacturerLinkButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 258);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Push_Info_button
            // 
            this.Push_Info_button.BackColor = System.Drawing.Color.LightCoral;
            this.Push_Info_button.Location = new System.Drawing.Point(202, 313);
            this.Push_Info_button.Name = "Push_Info_button";
            this.Push_Info_button.Size = new System.Drawing.Size(167, 56);
            this.Push_Info_button.TabIndex = 36;
            this.Push_Info_button.Text = "Занести информацию о самолете";
            this.Push_Info_button.UseVisualStyleBackColor = false;
            this.Push_Info_button.Click += new System.EventHandler(this.Push_Info_button_Click);
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.TypeRadioButton2);
            this.groupType.Controls.Add(this.TypeRadioButton1);
            this.groupType.Controls.Add(this.Type);
            this.groupType.Controls.Add(this.TypeRadioButton3);
            this.groupType.Location = new System.Drawing.Point(12, 43);
            this.groupType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupType.Name = "groupType";
            this.groupType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupType.Size = new System.Drawing.Size(131, 115);
            this.groupType.TabIndex = 37;
            this.groupType.TabStop = false;
            // 
            // ShowInfoAboutAirplanes_Button
            // 
            this.ShowInfoAboutAirplanes_Button.BackColor = System.Drawing.Color.LightGreen;
            this.ShowInfoAboutAirplanes_Button.Location = new System.Drawing.Point(287, 385);
            this.ShowInfoAboutAirplanes_Button.Name = "ShowInfoAboutAirplanes_Button";
            this.ShowInfoAboutAirplanes_Button.Size = new System.Drawing.Size(131, 65);
            this.ShowInfoAboutAirplanes_Button.TabIndex = 38;
            this.ShowInfoAboutAirplanes_Button.Text = "Вывод информации о самолетах";
            this.ShowInfoAboutAirplanes_Button.UseVisualStyleBackColor = false;
            this.ShowInfoAboutAirplanes_Button.Click += new System.EventHandler(this.ShowInfoAboutAirplanes_Button_Click);
            // 
            // OutTextValue
            // 
            this.OutTextValue.Location = new System.Drawing.Point(444, 63);
            this.OutTextValue.Multiline = true;
            this.OutTextValue.Name = "OutTextValue";
            this.OutTextValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutTextValue.Size = new System.Drawing.Size(528, 400);
            this.OutTextValue.TabIndex = 39;
            // 
            // OutText
            // 
            this.OutText.AutoSize = true;
            this.OutText.Location = new System.Drawing.Point(441, 43);
            this.OutText.Name = "OutText";
            this.OutText.Size = new System.Drawing.Size(138, 17);
            this.OutText.TabIndex = 40;
            this.OutText.Text = "Вывод информации";
            // 
            // WriteInfoAboutAirplanes_Button
            // 
            this.WriteInfoAboutAirplanes_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.WriteInfoAboutAirplanes_Button.Location = new System.Drawing.Point(150, 385);
            this.WriteInfoAboutAirplanes_Button.Name = "WriteInfoAboutAirplanes_Button";
            this.WriteInfoAboutAirplanes_Button.Size = new System.Drawing.Size(131, 65);
            this.WriteInfoAboutAirplanes_Button.TabIndex = 41;
            this.WriteInfoAboutAirplanes_Button.Text = "Запись информации о самолетах";
            this.WriteInfoAboutAirplanes_Button.UseVisualStyleBackColor = false;
            this.WriteInfoAboutAirplanes_Button.Click += new System.EventHandler(this.WriteInfoAboutAirplanes_Button_Click);
            // 
            // CreateAirportInfrastructure
            // 
            this.CreateAirportInfrastructure.BackColor = System.Drawing.Color.DarkSalmon;
            this.CreateAirportInfrastructure.Location = new System.Drawing.Point(150, 4);
            this.CreateAirportInfrastructure.Name = "CreateAirportInfrastructure";
            this.CreateAirportInfrastructure.Size = new System.Drawing.Size(191, 56);
            this.CreateAirportInfrastructure.TabIndex = 42;
            this.CreateAirportInfrastructure.Text = "Создать инфраструктуру аэропорта";
            this.CreateAirportInfrastructure.UseVisualStyleBackColor = false;
            this.CreateAirportInfrastructure.Click += new System.EventHandler(this.CreateAirportInfrastructure_Click);
            // 
            // AirplaneInfo
            // 
            this.ClientSize = new System.Drawing.Size(988, 471);
            this.Controls.Add(this.CreateAirportInfrastructure);
            this.Controls.Add(this.WriteInfoAboutAirplanes_Button);
            this.Controls.Add(this.OutText);
            this.Controls.Add(this.OutTextValue);
            this.Controls.Add(this.ShowInfoAboutAirplanes_Button);
            this.Controls.Add(this.groupType);
            this.Controls.Add(this.Push_Info_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AirplaneManufacturerLinkButton);
            this.Controls.Add(this.AirplaneHead);
            this.Controls.Add(this.CrewMemberLinkButton);
            this.Controls.Add(this.DateOfTheLatestMaintenance);
            this.Controls.Add(this.CarryingValue);
            this.Controls.Add(this.Carrying);
            this.Controls.Add(this.YearOfIssueValue);
            this.Controls.Add(this.YearOfIssue);
            this.Controls.Add(this.NumberOfPassengersValue);
            this.Controls.Add(this.NumberOfPassengers);
            this.Controls.Add(this.ModelValue);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.NumberValue);
            this.Controls.Add(this.Number);
            this.Name = "AirplaneInfo";
            this.Load += new System.EventHandler(this.AirplaneInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarryingValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearOfIssueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPassengersValue)).EndInit();
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox NumberValue;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.RadioButton TypeRadioButton1;
        private System.Windows.Forms.RadioButton TypeRadioButton2;
        private System.Windows.Forms.RadioButton TypeRadioButton3;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.TextBox ModelValue;
        private System.Windows.Forms.Label DateOfTheLatestMaintenance;
        private System.Windows.Forms.NumericUpDown CarryingValue;
        private System.Windows.Forms.Label Carrying;
        private System.Windows.Forms.NumericUpDown YearOfIssueValue;
        private System.Windows.Forms.Label YearOfIssue;
        private System.Windows.Forms.NumericUpDown NumberOfPassengersValue;
        private System.Windows.Forms.Label NumberOfPassengers;
        private System.Windows.Forms.Button CrewMemberLinkButton;
        private System.Windows.Forms.Label AirplaneHead;
        private System.Windows.Forms.Button AirplaneManufacturerLinkButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Push_Info_button;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.Button ShowInfoAboutAirplanes_Button;
        private System.Windows.Forms.TextBox OutTextValue;
        private System.Windows.Forms.Label OutText;
        private System.Windows.Forms.Button WriteInfoAboutAirplanes_Button;
        private System.Windows.Forms.Button CreateAirportInfrastructure;
    }
}

