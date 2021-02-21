
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
            this.SearchManufacturerNameValue = new System.Windows.Forms.TextBox();
            this.SearchManufacturerName = new System.Windows.Forms.Label();
            this.SearchTypeValue = new System.Windows.Forms.TextBox();
            this.SearchType = new System.Windows.Forms.Label();
            this.SearchNumberOfPassengers = new System.Windows.Forms.Label();
            this.SearchNumberOfPassengersValue = new System.Windows.Forms.TextBox();
            this.SearchCarryingValue = new System.Windows.Forms.TextBox();
            this.SearchCarrying = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFullSearch = new System.Windows.Forms.RadioButton();
            this.radioButtonPartillySearch = new System.Windows.Forms.RadioButton();
            this.SearchOut = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchHead
            // 
            this.SearchHead.AutoSize = true;
            this.SearchHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchHead.Location = new System.Drawing.Point(12, 9);
            this.SearchHead.Name = "SearchHead";
            this.SearchHead.Size = new System.Drawing.Size(73, 25);
            this.SearchHead.TabIndex = 35;
            this.SearchHead.Text = "Поиск";
            // 
            // SearchManufacturerNameValue
            // 
            this.SearchManufacturerNameValue.Location = new System.Drawing.Point(131, 43);
            this.SearchManufacturerNameValue.Name = "SearchManufacturerNameValue";
            this.SearchManufacturerNameValue.Size = new System.Drawing.Size(245, 22);
            this.SearchManufacturerNameValue.TabIndex = 44;
            this.SearchManufacturerNameValue.TextChanged += new System.EventHandler(this.SearchManufacturerNameValue_TextChanged);
            // 
            // SearchManufacturerName
            // 
            this.SearchManufacturerName.AutoSize = true;
            this.SearchManufacturerName.Location = new System.Drawing.Point(12, 46);
            this.SearchManufacturerName.Name = "SearchManufacturerName";
            this.SearchManufacturerName.Size = new System.Drawing.Size(110, 17);
            this.SearchManufacturerName.TabIndex = 43;
            this.SearchManufacturerName.Text = "Производитель";
            // 
            // SearchTypeValue
            // 
            this.SearchTypeValue.Location = new System.Drawing.Point(131, 71);
            this.SearchTypeValue.Name = "SearchTypeValue";
            this.SearchTypeValue.Size = new System.Drawing.Size(245, 22);
            this.SearchTypeValue.TabIndex = 46;
            this.SearchTypeValue.TextChanged += new System.EventHandler(this.SearchTypeValue_TextChanged);
            // 
            // SearchType
            // 
            this.SearchType.AutoSize = true;
            this.SearchType.Location = new System.Drawing.Point(12, 74);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(100, 17);
            this.SearchType.TabIndex = 45;
            this.SearchType.Text = "Тип самолета";
            // 
            // SearchNumberOfPassengers
            // 
            this.SearchNumberOfPassengers.AutoSize = true;
            this.SearchNumberOfPassengers.Location = new System.Drawing.Point(12, 99);
            this.SearchNumberOfPassengers.Name = "SearchNumberOfPassengers";
            this.SearchNumberOfPassengers.Size = new System.Drawing.Size(216, 17);
            this.SearchNumberOfPassengers.TabIndex = 47;
            this.SearchNumberOfPassengers.Text = "Количество пассажирских мест";
            // 
            // SearchNumberOfPassengersValue
            // 
            this.SearchNumberOfPassengersValue.Location = new System.Drawing.Point(237, 96);
            this.SearchNumberOfPassengersValue.Name = "SearchNumberOfPassengersValue";
            this.SearchNumberOfPassengersValue.Size = new System.Drawing.Size(139, 22);
            this.SearchNumberOfPassengersValue.TabIndex = 48;
            this.SearchNumberOfPassengersValue.TextChanged += new System.EventHandler(this.SearchNumberOfPassengersValue_TextChanged);
            // 
            // SearchCarryingValue
            // 
            this.SearchCarryingValue.Location = new System.Drawing.Point(154, 123);
            this.SearchCarryingValue.Name = "SearchCarryingValue";
            this.SearchCarryingValue.Size = new System.Drawing.Size(222, 22);
            this.SearchCarryingValue.TabIndex = 50;
            this.SearchCarryingValue.TextChanged += new System.EventHandler(this.SearchCarryingValue_TextChanged);
            // 
            // SearchCarrying
            // 
            this.SearchCarrying.AutoSize = true;
            this.SearchCarrying.Location = new System.Drawing.Point(12, 126);
            this.SearchCarrying.Name = "SearchCarrying";
            this.SearchCarrying.Size = new System.Drawing.Size(133, 17);
            this.SearchCarrying.TabIndex = 49;
            this.SearchCarrying.Text = "Грузоподъемность";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPartillySearch);
            this.groupBox1.Controls.Add(this.radioButtonFullSearch);
            this.groupBox1.Location = new System.Drawing.Point(424, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 102);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по полному выражению";
            // 
            // radioButtonFullSearch
            // 
            this.radioButtonFullSearch.AutoSize = true;
            this.radioButtonFullSearch.Location = new System.Drawing.Point(29, 46);
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
            this.radioButtonPartillySearch.Location = new System.Drawing.Point(29, 73);
            this.radioButtonPartillySearch.Name = "radioButtonPartillySearch";
            this.radioButtonPartillySearch.Size = new System.Drawing.Size(52, 21);
            this.radioButtonPartillySearch.TabIndex = 1;
            this.radioButtonPartillySearch.TabStop = true;
            this.radioButtonPartillySearch.Text = "нет";
            this.radioButtonPartillySearch.UseVisualStyleBackColor = true;
            // 
            // SearchOut
            // 
            this.SearchOut.Location = new System.Drawing.Point(15, 162);
            this.SearchOut.Multiline = true;
            this.SearchOut.Name = "SearchOut";
            this.SearchOut.Size = new System.Drawing.Size(577, 280);
            this.SearchOut.TabIndex = 52;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightGreen;
            this.SearchButton.Location = new System.Drawing.Point(663, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 66);
            this.SearchButton.TabIndex = 53;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchCarryingValue);
            this.Controls.Add(this.SearchCarrying);
            this.Controls.Add(this.SearchNumberOfPassengersValue);
            this.Controls.Add(this.SearchNumberOfPassengers);
            this.Controls.Add(this.SearchTypeValue);
            this.Controls.Add(this.SearchType);
            this.Controls.Add(this.SearchManufacturerNameValue);
            this.Controls.Add(this.SearchManufacturerName);
            this.Controls.Add(this.SearchHead);
            this.Name = "SearchForm";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchHead;
        private System.Windows.Forms.TextBox SearchManufacturerNameValue;
        private System.Windows.Forms.Label SearchManufacturerName;
        private System.Windows.Forms.TextBox SearchTypeValue;
        private System.Windows.Forms.Label SearchType;
        private System.Windows.Forms.Label SearchNumberOfPassengers;
        private System.Windows.Forms.TextBox SearchNumberOfPassengersValue;
        private System.Windows.Forms.TextBox SearchCarryingValue;
        private System.Windows.Forms.Label SearchCarrying;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPartillySearch;
        private System.Windows.Forms.RadioButton radioButtonFullSearch;
        private System.Windows.Forms.TextBox SearchOut;
        private System.Windows.Forms.Button SearchButton;
    }
}