
namespace OOP_Lab2
{
    partial class SearchForm
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
            this.SearchHead = new System.Windows.Forms.Label();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchType = new System.Windows.Forms.Label();
            this.SearchNumberOfPassengers = new System.Windows.Forms.Label();
            this.SearchCarrying = new System.Windows.Forms.Label();
            this.SearchManufacturerName = new System.Windows.Forms.Label();
            this.SearchTypeValue = new System.Windows.Forms.TextBox();
            this.SearchNumberOfPassengersValue = new System.Windows.Forms.TextBox();
            this.SearchCarryingValue = new System.Windows.Forms.TextBox();
            this.SearchManufacturerNameValue = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchResult = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioButtonFullSearch = new System.Windows.Forms.RadioButton();
            this.radioButtonPartillySearch = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchHead
            // 
            this.SearchHead.AutoSize = true;
            this.SearchHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchHead.Location = new System.Drawing.Point(12, 9);
            this.SearchHead.Name = "SearchHead";
            this.SearchHead.Size = new System.Drawing.Size(73, 25);
            this.SearchHead.TabIndex = 34;
            this.SearchHead.Text = "Поиск";
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(14, 44);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(130, 17);
            this.SearchByLabel.TabIndex = 35;
            this.SearchByLabel.Text = "Критерии поиска: ";
            // 
            // SearchType
            // 
            this.SearchType.AutoSize = true;
            this.SearchType.Location = new System.Drawing.Point(14, 76);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(100, 17);
            this.SearchType.TabIndex = 36;
            this.SearchType.Text = "Тип самолета";
            // 
            // SearchNumberOfPassengers
            // 
            this.SearchNumberOfPassengers.AutoSize = true;
            this.SearchNumberOfPassengers.Location = new System.Drawing.Point(14, 103);
            this.SearchNumberOfPassengers.Name = "SearchNumberOfPassengers";
            this.SearchNumberOfPassengers.Size = new System.Drawing.Size(216, 17);
            this.SearchNumberOfPassengers.TabIndex = 37;
            this.SearchNumberOfPassengers.Text = "Количество пассажирских мест";
            // 
            // SearchCarrying
            // 
            this.SearchCarrying.AutoSize = true;
            this.SearchCarrying.Location = new System.Drawing.Point(14, 131);
            this.SearchCarrying.Name = "SearchCarrying";
            this.SearchCarrying.Size = new System.Drawing.Size(133, 17);
            this.SearchCarrying.TabIndex = 38;
            this.SearchCarrying.Text = "Грузоподъемность";
            // 
            // SearchManufacturerName
            // 
            this.SearchManufacturerName.AutoSize = true;
            this.SearchManufacturerName.Location = new System.Drawing.Point(14, 160);
            this.SearchManufacturerName.Name = "SearchManufacturerName";
            this.SearchManufacturerName.Size = new System.Drawing.Size(110, 17);
            this.SearchManufacturerName.TabIndex = 42;
            this.SearchManufacturerName.Text = "Производитель";
            // 
            // SearchTypeValue
            // 
            this.SearchTypeValue.Location = new System.Drawing.Point(236, 71);
            this.SearchTypeValue.Name = "SearchTypeValue";
            this.SearchTypeValue.Size = new System.Drawing.Size(196, 22);
            this.SearchTypeValue.TabIndex = 43;
            this.SearchTypeValue.TextChanged += new System.EventHandler(this.SearchTypeValue_TextChanged);
            // 
            // SearchNumberOfPassengersValue
            // 
            this.SearchNumberOfPassengersValue.Location = new System.Drawing.Point(236, 100);
            this.SearchNumberOfPassengersValue.Name = "SearchNumberOfPassengersValue";
            this.SearchNumberOfPassengersValue.Size = new System.Drawing.Size(196, 22);
            this.SearchNumberOfPassengersValue.TabIndex = 44;
            this.SearchNumberOfPassengersValue.TextChanged += new System.EventHandler(this.SearchNumberOfPassengersValue_TextChanged);
            // 
            // SearchCarryingValue
            // 
            this.SearchCarryingValue.Location = new System.Drawing.Point(236, 132);
            this.SearchCarryingValue.Name = "SearchCarryingValue";
            this.SearchCarryingValue.Size = new System.Drawing.Size(196, 22);
            this.SearchCarryingValue.TabIndex = 45;
            this.SearchCarryingValue.TextChanged += new System.EventHandler(this.SearchCarryingValue_TextChanged);
            // 
            // SearchManufacturerNameValue
            // 
            this.SearchManufacturerNameValue.Location = new System.Drawing.Point(236, 160);
            this.SearchManufacturerNameValue.Name = "SearchManufacturerNameValue";
            this.SearchManufacturerNameValue.Size = new System.Drawing.Size(196, 22);
            this.SearchManufacturerNameValue.TabIndex = 46;
            this.SearchManufacturerNameValue.TextChanged += new System.EventHandler(this.SearchManufacturerNameValue_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Thistle;
            this.SearchButton.Location = new System.Drawing.Point(577, 200);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(129, 50);
            this.SearchButton.TabIndex = 47;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchResult
            // 
            this.SearchResult.Location = new System.Drawing.Point(41, 200);
            this.SearchResult.Multiline = true;
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(471, 336);
            this.SearchResult.TabIndex = 48;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.radioButtonPartillySearch);
            this.groupBoxSearch.Controls.Add(this.radioButtonFullSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(496, 60);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(219, 75);
            this.groupBoxSearch.TabIndex = 49;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Полное соответствие данных";
            // 
            // radioButtonFullSearch
            // 
            this.radioButtonFullSearch.AutoSize = true;
            this.radioButtonFullSearch.Location = new System.Drawing.Point(6, 21);
            this.radioButtonFullSearch.Name = "radioButtonFullSearch";
            this.radioButtonFullSearch.Size = new System.Drawing.Size(45, 21);
            this.radioButtonFullSearch.TabIndex = 0;
            this.radioButtonFullSearch.TabStop = true;
            this.radioButtonFullSearch.Text = "да";
            this.radioButtonFullSearch.UseVisualStyleBackColor = true;
            // 
            // radioButtonPartillySearch
            // 
            this.radioButtonPartillySearch.AutoSize = true;
            this.radioButtonPartillySearch.Location = new System.Drawing.Point(6, 48);
            this.radioButtonPartillySearch.Name = "radioButtonPartillySearch";
            this.radioButtonPartillySearch.Size = new System.Drawing.Size(52, 21);
            this.radioButtonPartillySearch.TabIndex = 1;
            this.radioButtonPartillySearch.TabStop = true;
            this.radioButtonPartillySearch.Text = "нет";
            this.radioButtonPartillySearch.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 548);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.SearchResult);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchManufacturerNameValue);
            this.Controls.Add(this.SearchCarryingValue);
            this.Controls.Add(this.SearchNumberOfPassengersValue);
            this.Controls.Add(this.SearchTypeValue);
            this.Controls.Add(this.SearchManufacturerName);
            this.Controls.Add(this.SearchCarrying);
            this.Controls.Add(this.SearchNumberOfPassengers);
            this.Controls.Add(this.SearchType);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.SearchHead);
            this.Name = "SearchForm";
            this.Text = "Form4";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchHead;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Label SearchType;
        private System.Windows.Forms.Label SearchNumberOfPassengers;
        private System.Windows.Forms.Label SearchCarrying;
        private System.Windows.Forms.Label SearchManufacturerName;
        private System.Windows.Forms.TextBox SearchTypeValue;
        private System.Windows.Forms.TextBox SearchNumberOfPassengersValue;
        private System.Windows.Forms.TextBox SearchCarryingValue;
        private System.Windows.Forms.TextBox SearchManufacturerNameValue;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchResult;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonPartillySearch;
        private System.Windows.Forms.RadioButton radioButtonFullSearch;
    }
}