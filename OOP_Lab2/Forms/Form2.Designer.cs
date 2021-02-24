
namespace OOP_Lab2
{
    partial class CrewMemberInfo
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
            this.CrewMemberHead = new System.Windows.Forms.Label();
            this.SurnameValue = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.PatronymicValue = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.Label();
            this.CrewNameValue = new System.Windows.Forms.TextBox();
            this.CrewName = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.PositionList = new System.Windows.Forms.ListBox();
            this.AgeValue = new System.Windows.Forms.NumericUpDown();
            this.Age = new System.Windows.Forms.Label();
            this.ExperienceValue = new System.Windows.Forms.NumericUpDown();
            this.Experience = new System.Windows.Forms.Label();
            this.AddCrewMemberToList = new System.Windows.Forms.Button();
            this.SaveInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceValue)).BeginInit();
            this.SuspendLayout();
            // 
            // CrewMemberHead
            // 
            this.CrewMemberHead.AutoSize = true;
            this.CrewMemberHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrewMemberHead.Location = new System.Drawing.Point(12, 9);
            this.CrewMemberHead.Name = "CrewMemberHead";
            this.CrewMemberHead.Size = new System.Drawing.Size(156, 25);
            this.CrewMemberHead.TabIndex = 34;
            this.CrewMemberHead.Text = "Член экипажа";
            // 
            // SurnameValue
            // 
            this.SurnameValue.Location = new System.Drawing.Point(103, 48);
            this.SurnameValue.Name = "SurnameValue";
            this.SurnameValue.Size = new System.Drawing.Size(164, 22);
            this.SurnameValue.TabIndex = 36;
            this.SurnameValue.TextChanged += new System.EventHandler(this.SurnameValue_TextChanged);
            this.SurnameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters_KeyPress);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(14, 48);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(70, 17);
            this.Surname.TabIndex = 35;
            this.Surname.Text = "Фамилия";
            // 
            // PatronymicValue
            // 
            this.PatronymicValue.Location = new System.Drawing.Point(103, 106);
            this.PatronymicValue.Name = "PatronymicValue";
            this.PatronymicValue.Size = new System.Drawing.Size(164, 22);
            this.PatronymicValue.TabIndex = 38;
            this.PatronymicValue.TextChanged += new System.EventHandler(this.PatronymicValue_TextChanged);
            this.PatronymicValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters_KeyPress);
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Location = new System.Drawing.Point(14, 106);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(71, 17);
            this.Patronymic.TabIndex = 37;
            this.Patronymic.Text = "Отчество";
            // 
            // CrewNameValue
            // 
            this.CrewNameValue.Location = new System.Drawing.Point(103, 78);
            this.CrewNameValue.Name = "CrewNameValue";
            this.CrewNameValue.Size = new System.Drawing.Size(164, 22);
            this.CrewNameValue.TabIndex = 40;
            this.CrewNameValue.TextChanged += new System.EventHandler(this.CrewNameValue_TextChanged);
            this.CrewNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetters_KeyPress);
            // 
            // CrewName
            // 
            this.CrewName.AutoSize = true;
            this.CrewName.Location = new System.Drawing.Point(14, 78);
            this.CrewName.Name = "CrewName";
            this.CrewName.Size = new System.Drawing.Size(35, 17);
            this.CrewName.TabIndex = 39;
            this.CrewName.Text = "Имя";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(14, 160);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(81, 17);
            this.Position.TabIndex = 41;
            this.Position.Text = "Должность";
            // 
            // PositionList
            // 
            this.PositionList.FormattingEnabled = true;
            this.PositionList.ItemHeight = 16;
            this.PositionList.Items.AddRange(new object[] {
            "Пилот",
            "Второй пилот",
            "Стюардесса",
            "Уборщик"});
            this.PositionList.Location = new System.Drawing.Point(103, 160);
            this.PositionList.Name = "PositionList";
            this.PositionList.ScrollAlwaysVisible = true;
            this.PositionList.Size = new System.Drawing.Size(164, 20);
            this.PositionList.TabIndex = 42;
            this.PositionList.SelectedValueChanged += new System.EventHandler(this.PositionList_SelectedValueChanged);
            // 
            // AgeValue
            // 
            this.AgeValue.Location = new System.Drawing.Point(103, 187);
            this.AgeValue.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.AgeValue.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.AgeValue.Name = "AgeValue";
            this.AgeValue.Size = new System.Drawing.Size(164, 22);
            this.AgeValue.TabIndex = 44;
            this.AgeValue.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.AgeValue.ValueChanged += new System.EventHandler(this.AgeValue_ValueChanged);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(14, 187);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(62, 17);
            this.Age.TabIndex = 43;
            this.Age.Text = "Возраст";
            // 
            // ExperienceValue
            // 
            this.ExperienceValue.Location = new System.Drawing.Point(103, 220);
            this.ExperienceValue.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.ExperienceValue.Name = "ExperienceValue";
            this.ExperienceValue.Size = new System.Drawing.Size(164, 22);
            this.ExperienceValue.TabIndex = 46;
            this.ExperienceValue.ValueChanged += new System.EventHandler(this.ExperienceValue_ValueChanged);
            // 
            // Experience
            // 
            this.Experience.AutoSize = true;
            this.Experience.Location = new System.Drawing.Point(14, 220);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(74, 17);
            this.Experience.TabIndex = 45;
            this.Experience.Text = "Стаж(лет)";
            // 
            // AddCrewMemberToList
            // 
            this.AddCrewMemberToList.BackColor = System.Drawing.Color.LightCoral;
            this.AddCrewMemberToList.Location = new System.Drawing.Point(12, 264);
            this.AddCrewMemberToList.Name = "AddCrewMemberToList";
            this.AddCrewMemberToList.Size = new System.Drawing.Size(140, 77);
            this.AddCrewMemberToList.TabIndex = 47;
            this.AddCrewMemberToList.Text = "Занести информацию о члене экипажа";
            this.AddCrewMemberToList.UseVisualStyleBackColor = false;
            this.AddCrewMemberToList.Click += new System.EventHandler(this.AddCrewMemberToList_Click);
            // 
            // SaveInfoButton
            // 
            this.SaveInfoButton.BackColor = System.Drawing.Color.LightGreen;
            this.SaveInfoButton.Location = new System.Drawing.Point(169, 264);
            this.SaveInfoButton.Name = "SaveInfoButton";
            this.SaveInfoButton.Size = new System.Drawing.Size(140, 77);
            this.SaveInfoButton.TabIndex = 48;
            this.SaveInfoButton.Text = "Сохранить информацию";
            this.SaveInfoButton.UseVisualStyleBackColor = false;
            this.SaveInfoButton.Click += new System.EventHandler(this.SaveInfoButton_Click);
            // 
            // CrewMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 366);
            this.Controls.Add(this.SaveInfoButton);
            this.Controls.Add(this.AddCrewMemberToList);
            this.Controls.Add(this.ExperienceValue);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.AgeValue);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.PositionList);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.CrewNameValue);
            this.Controls.Add(this.CrewName);
            this.Controls.Add(this.PatronymicValue);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.SurnameValue);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.CrewMemberHead);
            this.Name = "CrewMemberInfo";
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CrewMemberHead;
        private System.Windows.Forms.TextBox SurnameValue;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox PatronymicValue;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.TextBox CrewNameValue;
        private System.Windows.Forms.Label CrewName;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.ListBox PositionList;
        private System.Windows.Forms.NumericUpDown AgeValue;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.NumericUpDown ExperienceValue;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.Button AddCrewMemberToList;
        private System.Windows.Forms.Button SaveInfoButton;
    }
}