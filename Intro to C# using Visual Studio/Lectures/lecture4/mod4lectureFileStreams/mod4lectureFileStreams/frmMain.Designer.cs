namespace mod4lectureFileStreams {
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
            this.lblTotalTeamPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxPlayerPoints = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumPlayers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.tbxPointsScored = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Names";
            // 
            // lblTotalTeamPoints
            // 
            this.lblTotalTeamPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalTeamPoints.Location = new System.Drawing.Point(170, 161);
            this.lblTotalTeamPoints.Name = "lblTotalTeamPoints";
            this.lblTotalTeamPoints.Size = new System.Drawing.Size(106, 26);
            this.lblTotalTeamPoints.TabIndex = 1;
            this.lblTotalTeamPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Team Points:";
            // 
            // lbxPlayerPoints
            // 
            this.lbxPlayerPoints.FormattingEnabled = true;
            this.lbxPlayerPoints.ItemHeight = 16;
            this.lbxPlayerPoints.Location = new System.Drawing.Point(15, 29);
            this.lbxPlayerPoints.Name = "lbxPlayerPoints";
            this.lbxPlayerPoints.Size = new System.Drawing.Size(231, 116);
            this.lbxPlayerPoints.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Players:";
            // 
            // lblNumPlayers
            // 
            this.lblNumPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumPlayers.Location = new System.Drawing.Point(170, 201);
            this.lblNumPlayers.Name = "lblNumPlayers";
            this.lblNumPlayers.Size = new System.Drawing.Size(106, 26);
            this.lblNumPlayers.TabIndex = 5;
            this.lblNumPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Points Scored:";
            // 
            // tbxFullName
            // 
            this.tbxFullName.Location = new System.Drawing.Point(46, 29);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(100, 23);
            this.tbxFullName.TabIndex = 2;
            // 
            // tbxPointsScored
            // 
            this.tbxPointsScored.Location = new System.Drawing.Point(46, 92);
            this.tbxPointsScored.Name = "tbxPointsScored";
            this.tbxPointsScored.Size = new System.Drawing.Size(100, 23);
            this.tbxPointsScored.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbxPointsScored);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxFullName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(328, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 166);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(406, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 344);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxPlayerPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalTeamPoints);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 10F);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalTeamPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxPlayerPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumPlayers;
        private System.Windows.Forms.TextBox tbxPointsScored;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdSave;
    }
}

