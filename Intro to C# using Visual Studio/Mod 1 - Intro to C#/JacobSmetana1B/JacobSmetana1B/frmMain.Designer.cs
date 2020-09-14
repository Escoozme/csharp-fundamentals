namespace JacobSmetana1B
{
    partial class frmMain
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
            this.lblJoke = new System.Windows.Forms.Label();
            this.btnJoke = new System.Windows.Forms.Button();
            this.btnPunchLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoke
            // 
            this.lblJoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoke.Location = new System.Drawing.Point(12, 9);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(336, 56);
            this.lblJoke.TabIndex = 0;
            this.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJoke
            // 
            this.btnJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoke.Location = new System.Drawing.Point(40, 85);
            this.btnJoke.Name = "btnJoke";
            this.btnJoke.Size = new System.Drawing.Size(100, 30);
            this.btnJoke.TabIndex = 1;
            this.btnJoke.Text = "&Joke";
            this.btnJoke.UseVisualStyleBackColor = true;
            this.btnJoke.Click += new System.EventHandler(this.btnJoke_Click);
            // 
            // btnPunchLine
            // 
            this.btnPunchLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunchLine.Location = new System.Drawing.Point(221, 85);
            this.btnPunchLine.Name = "btnPunchLine";
            this.btnPunchLine.Size = new System.Drawing.Size(100, 30);
            this.btnPunchLine.TabIndex = 2;
            this.btnPunchLine.Text = "&Punch Line";
            this.btnPunchLine.UseVisualStyleBackColor = true;
            this.btnPunchLine.Click += new System.EventHandler(this.btnPunchLine_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 133);
            this.Controls.Add(this.btnPunchLine);
            this.Controls.Add(this.btnJoke);
            this.Controls.Add(this.lblJoke);
            this.MaximumSize = new System.Drawing.Size(376, 171);
            this.MinimumSize = new System.Drawing.Size(376, 171);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Great Joke";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Button btnJoke;
        private System.Windows.Forms.Button btnPunchLine;
    }
}

