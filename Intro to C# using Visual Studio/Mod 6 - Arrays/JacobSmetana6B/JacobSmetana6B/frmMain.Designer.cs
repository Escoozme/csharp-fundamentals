namespace JacobSmetana6B {
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
            if(disposing && (components != null)) {
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
            this.lbxTeams = new System.Windows.Forms.ListBox();
            this.lblWorldSeriesWins = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select one of the following teams:";
            // 
            // lbxTeams
            // 
            this.lbxTeams.FormattingEnabled = true;
            this.lbxTeams.ItemHeight = 16;
            this.lbxTeams.Location = new System.Drawing.Point(12, 29);
            this.lbxTeams.Name = "lbxTeams";
            this.lbxTeams.Size = new System.Drawing.Size(350, 132);
            this.lbxTeams.TabIndex = 1;
            this.lbxTeams.SelectedIndexChanged += new System.EventHandler(this.lbxTeams_SelectedIndexChanged);
            // 
            // lblWorldSeriesWins
            // 
            this.lblWorldSeriesWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorldSeriesWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldSeriesWins.Location = new System.Drawing.Point(12, 164);
            this.lblWorldSeriesWins.Name = "lblWorldSeriesWins";
            this.lblWorldSeriesWins.Size = new System.Drawing.Size(350, 112);
            this.lblWorldSeriesWins.TabIndex = 2;
            this.lblWorldSeriesWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(272, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(374, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWorldSeriesWins);
            this.Controls.Add(this.lbxTeams);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Series Stats";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTeams;
        private System.Windows.Forms.Label lblWorldSeriesWins;
        private System.Windows.Forms.Button btnExit;
    }
}

