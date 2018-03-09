namespace cashRegister
{
    partial class inputDrinks
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
            this.Basic1 = new System.Windows.Forms.Label();
            this.Basic2 = new System.Windows.Forms.Label();
            this.Basic3 = new System.Windows.Forms.Label();
            this.mealSize = new System.Windows.Forms.ComboBox();
            this.inputBurgers = new System.Windows.Forms.TextBox();
            this.inputdrink = new System.Windows.Forms.TextBox();
            this.InputFries = new System.Windows.Forms.TextBox();
            this.calculateTotals = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.errorbox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenderBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Basic1
            // 
            this.Basic1.AutoSize = true;
            this.Basic1.Location = new System.Drawing.Point(9, 28);
            this.Basic1.Name = "Basic1";
            this.Basic1.Size = new System.Drawing.Size(95, 13);
            this.Basic1.TabIndex = 0;
            this.Basic1.Text = "Number of Burgers";
            // 
            // Basic2
            // 
            this.Basic2.AutoSize = true;
            this.Basic2.Location = new System.Drawing.Point(9, 59);
            this.Basic2.Name = "Basic2";
            this.Basic2.Size = new System.Drawing.Size(89, 13);
            this.Basic2.TabIndex = 1;
            this.Basic2.Text = "Number of Drinks";
            // 
            // Basic3
            // 
            this.Basic3.AutoSize = true;
            this.Basic3.Location = new System.Drawing.Point(9, 89);
            this.Basic3.Name = "Basic3";
            this.Basic3.Size = new System.Drawing.Size(81, 13);
            this.Basic3.TabIndex = 2;
            this.Basic3.Text = "Number of Fries";
            // 
            // mealSize
            // 
            this.mealSize.FormattingEnabled = true;
            this.mealSize.Items.AddRange(new object[] {
            "Small - Included",
            "Medium - Add $1",
            "Large - Add $3"});
            this.mealSize.Location = new System.Drawing.Point(12, 117);
            this.mealSize.Name = "mealSize";
            this.mealSize.Size = new System.Drawing.Size(121, 21);
            this.mealSize.TabIndex = 4;
            this.mealSize.Text = "Pick a Meal Size!";
            // 
            // inputBurgers
            // 
            this.inputBurgers.Location = new System.Drawing.Point(110, 25);
            this.inputBurgers.Name = "inputBurgers";
            this.inputBurgers.Size = new System.Drawing.Size(23, 20);
            this.inputBurgers.TabIndex = 5;
            this.inputBurgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputdrink
            // 
            this.inputdrink.Location = new System.Drawing.Point(110, 56);
            this.inputdrink.Name = "inputdrink";
            this.inputdrink.Size = new System.Drawing.Size(23, 20);
            this.inputdrink.TabIndex = 6;
            // 
            // InputFries
            // 
            this.InputFries.Location = new System.Drawing.Point(110, 91);
            this.InputFries.Name = "InputFries";
            this.InputFries.Size = new System.Drawing.Size(23, 20);
            this.InputFries.TabIndex = 7;
            // 
            // calculateTotals
            // 
            this.calculateTotals.Location = new System.Drawing.Point(12, 144);
            this.calculateTotals.Name = "calculateTotals";
            this.calculateTotals.Size = new System.Drawing.Size(121, 23);
            this.calculateTotals.TabIndex = 8;
            this.calculateTotals.Text = "Calculate Totals";
            this.calculateTotals.UseVisualStyleBackColor = true;
            this.calculateTotals.Click += new System.EventHandler(this.calculateTotals_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "BurgerTime! Cash Register";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 182);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 19;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(12, 206);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 20;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 229);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 13);
            this.totalLabel.TabIndex = 21;
            this.totalLabel.Text = "Total:";
            // 
            // errorbox
            // 
            this.errorbox.AutoSize = true;
            this.errorbox.Location = new System.Drawing.Point(13, 7);
            this.errorbox.Name = "errorbox";
            this.errorbox.Size = new System.Drawing.Size(98, 13);
            this.errorbox.TabIndex = 22;
            this.errorbox.Text = "Program Functional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tendered:";
            // 
            // tenderBox
            // 
            this.tenderBox.Location = new System.Drawing.Point(71, 260);
            this.tenderBox.Name = "tenderBox";
            this.tenderBox.Size = new System.Drawing.Size(40, 20);
            this.tenderBox.TabIndex = 24;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 291);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(121, 23);
            this.changeButton.TabIndex = 25;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(16, 331);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(47, 13);
            this.changeLabel.TabIndex = 26;
            this.changeLabel.Text = "Change:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Print Reciept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorbox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateTotals);
            this.Controls.Add(this.InputFries);
            this.Controls.Add(this.inputdrink);
            this.Controls.Add(this.inputBurgers);
            this.Controls.Add(this.mealSize);
            this.Controls.Add(this.Basic3);
            this.Controls.Add(this.Basic2);
            this.Controls.Add(this.Basic1);
            this.Name = "inputDrinks";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Basic1;
        private System.Windows.Forms.Label Basic2;
        private System.Windows.Forms.Label Basic3;
        private System.Windows.Forms.ComboBox mealSize;
        private System.Windows.Forms.TextBox inputBurgers;
        private System.Windows.Forms.TextBox inputdrink;
        private System.Windows.Forms.TextBox InputFries;
        private System.Windows.Forms.Button calculateTotals;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label errorbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenderBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button button1;
    }
}

