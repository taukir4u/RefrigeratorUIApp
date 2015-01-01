namespace RefrigeratorUIApp
{
    partial class RefrigeratorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.noOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Weight it can take";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight (kg)/Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remaining (Weight)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current (Weight)";
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(166, 32);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(219, 20);
            this.maxWeightTextBox.TabIndex = 5;
            // 
            // noOfItemsTextBox
            // 
            this.noOfItemsTextBox.Location = new System.Drawing.Point(109, 95);
            this.noOfItemsTextBox.Name = "noOfItemsTextBox";
            this.noOfItemsTextBox.Size = new System.Drawing.Size(77, 20);
            this.noOfItemsTextBox.TabIndex = 6;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(300, 95);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(85, 20);
            this.weightTextBox.TabIndex = 7;
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(109, 152);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(77, 20);
            this.currentWeightTextBox.TabIndex = 8;
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(300, 152);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(85, 20);
            this.remainingWeightTextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(392, 31);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(392, 94);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // RefrigeratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 270);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.noOfItemsTextBox);
            this.Controls.Add(this.maxWeightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RefrigeratorUI";
            this.Text = "Refrigerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.TextBox noOfItemsTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button enterButton;
    }
}

