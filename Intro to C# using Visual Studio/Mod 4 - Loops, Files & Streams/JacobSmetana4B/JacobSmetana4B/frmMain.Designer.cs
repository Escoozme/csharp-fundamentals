namespace JacobSmetana4B {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStartingNumber = new System.Windows.Forms.TextBox();
            this.tbxPercentIncrease = new System.Windows.Forms.TextBox();
            this.tbxDaysToMultiply = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lbxPopulation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting number of organisms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average daily increase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of days to multiply:";
            // 
            // tbxStartingNumber
            // 
            this.tbxStartingNumber.Location = new System.Drawing.Point(217, 10);
            this.tbxStartingNumber.Name = "tbxStartingNumber";
            this.tbxStartingNumber.Size = new System.Drawing.Size(75, 23);
            this.tbxStartingNumber.TabIndex = 3;
            // 
            // tbxPercentIncrease
            // 
            this.tbxPercentIncrease.Location = new System.Drawing.Point(217, 43);
            this.tbxPercentIncrease.Name = "tbxPercentIncrease";
            this.tbxPercentIncrease.Size = new System.Drawing.Size(75, 23);
            this.tbxPercentIncrease.TabIndex = 4;
            this.tbxPercentIncrease.Text = "%";
            // 
            // tbxDaysToMultiply
            // 
            this.tbxDaysToMultiply.Location = new System.Drawing.Point(217, 77);
            this.tbxDaysToMultiply.Name = "tbxDaysToMultiply";
            this.tbxDaysToMultiply.Size = new System.Drawing.Size(75, 23);
            this.tbxDaysToMultiply.TabIndex = 5;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.Honeydew;
            this.btnDisplay.Location = new System.Drawing.Point(202, 106);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(90, 30);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lbxPopulation
            // 
            this.lbxPopulation.FormattingEnabled = true;
            this.lbxPopulation.ItemHeight = 16;
            this.lbxPopulation.Location = new System.Drawing.Point(12, 142);
            this.lbxPopulation.Name = "lbxPopulation";
            this.lbxPopulation.Size = new System.Drawing.Size(280, 148);
            this.lbxPopulation.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(304, 299);
            this.Controls.Add(this.lbxPopulation);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.tbxDaysToMultiply);
            this.Controls.Add(this.tbxPercentIncrease);
            this.Controls.Add(this.tbxStartingNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(320, 337);
            this.MinimumSize = new System.Drawing.Size(320, 337);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStartingNumber;
        private System.Windows.Forms.TextBox tbxPercentIncrease;
        private System.Windows.Forms.TextBox tbxDaysToMultiply;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lbxPopulation;
    }
}

