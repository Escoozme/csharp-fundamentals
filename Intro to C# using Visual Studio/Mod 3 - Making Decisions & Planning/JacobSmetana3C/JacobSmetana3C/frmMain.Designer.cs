namespace JacobSmetana3C {
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
            this.lbxWorkshop = new System.Windows.Forms.ListBox();
            this.lbxLocation = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxWorkshop
            // 
            this.lbxWorkshop.FormattingEnabled = true;
            this.lbxWorkshop.ItemHeight = 16;
            this.lbxWorkshop.Items.AddRange(new object[] {
            "Handling Stress        3          $1,000",
            "Time Management        3          $800",
            "Supervision Skills     3          $1,500",
            "Negotiation            5          $1,300",
            "How to Interview       1          $500"});
            this.lbxWorkshop.Location = new System.Drawing.Point(12, 29);
            this.lbxWorkshop.Name = "lbxWorkshop";
            this.lbxWorkshop.Size = new System.Drawing.Size(336, 84);
            this.lbxWorkshop.TabIndex = 0;
            // 
            // lbxLocation
            // 
            this.lbxLocation.FormattingEnabled = true;
            this.lbxLocation.ItemHeight = 16;
            this.lbxLocation.Items.AddRange(new object[] {
            "Austin\t      $150",
            "Chicago\t      $225",
            "Dallas\t      $175",
            "Orlando\t      $300",
            "Phoenix\t      $175",
            "Raleigh\t      $150"});
            this.lbxLocation.Location = new System.Drawing.Point(374, 29);
            this.lbxLocation.Name = "lbxLocation";
            this.lbxLocation.Size = new System.Drawing.Size(193, 84);
            this.lbxLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Workshop          No. of Days    Reg. Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location   Lodging Fees";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(420, 165);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(420, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Font = new System.Drawing.Font("Courier New", 16F);
            this.lblTotalCost.Location = new System.Drawing.Point(12, 135);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(336, 168);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 314);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxLocation);
            this.Controls.Add(this.lbxWorkshop);
            this.Font = new System.Drawing.Font("Courier New", 10F);
            this.MaximumSize = new System.Drawing.Size(596, 352);
            this.MinimumSize = new System.Drawing.Size(596, 352);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkshop;
        private System.Windows.Forms.ListBox lbxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

