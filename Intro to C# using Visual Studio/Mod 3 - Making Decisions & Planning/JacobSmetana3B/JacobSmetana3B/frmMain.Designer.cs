namespace JacobSmetana3B {
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
            this.tbxBooks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPointsEarned = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of books purchased this month:";
            // 
            // tbxBooks
            // 
            this.tbxBooks.Location = new System.Drawing.Point(322, 6);
            this.tbxBooks.MaxLength = 5;
            this.tbxBooks.Name = "tbxBooks";
            this.tbxBooks.Size = new System.Drawing.Size(50, 23);
            this.tbxBooks.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Points earned:";
            // 
            // lblPointsEarned
            // 
            this.lblPointsEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPointsEarned.Location = new System.Drawing.Point(147, 43);
            this.lblPointsEarned.Name = "lblPointsEarned";
            this.lblPointsEarned.Size = new System.Drawing.Size(90, 30);
            this.lblPointsEarned.TabIndex = 3;
            this.lblPointsEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(266, 43);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 30);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 82);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblPointsEarned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBooks);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 120);
            this.MinimumSize = new System.Drawing.Size(400, 120);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPointsEarned;
        private System.Windows.Forms.Button btnCheck;
    }
}

