namespace JacobSmetanaTest2A {
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
            this.lblProblem = new System.Windows.Forms.Label();
            this.tbxUserAnswer = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewProblem = new System.Windows.Forms.Button();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProblem
            // 
            this.lblProblem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblem.Location = new System.Drawing.Point(18, 9);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(130, 26);
            this.lblProblem.TabIndex = 0;
            this.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUserAnswer
            // 
            this.tbxUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserAnswer.Location = new System.Drawing.Point(161, 9);
            this.tbxUserAnswer.MaxLength = 5;
            this.tbxUserAnswer.Name = "tbxUserAnswer";
            this.tbxUserAnswer.Size = new System.Drawing.Size(100, 26);
            this.tbxUserAnswer.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewProblem
            // 
            this.btnNewProblem.Location = new System.Drawing.Point(24, 47);
            this.btnNewProblem.Name = "btnNewProblem";
            this.btnNewProblem.Size = new System.Drawing.Size(100, 40);
            this.btnNewProblem.TabIndex = 4;
            this.btnNewProblem.Text = "&New Problem";
            this.btnNewProblem.UseVisualStyleBackColor = true;
            this.btnNewProblem.Click += new System.EventHandler(this.btnNewProblem_Click);
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.Location = new System.Drawing.Point(155, 47);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(100, 40);
            this.btnCheckResult.TabIndex = 5;
            this.btnCheckResult.Text = "Check &Result";
            this.btnCheckResult.UseVisualStyleBackColor = true;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(278, 143);
            this.Controls.Add(this.btnCheckResult);
            this.Controls.Add(this.btnNewProblem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxUserAnswer);
            this.Controls.Add(this.lblProblem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(294, 181);
            this.MinimumSize = new System.Drawing.Size(294, 181);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.TextBox tbxUserAnswer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewProblem;
        private System.Windows.Forms.Button btnCheckResult;
    }
}

