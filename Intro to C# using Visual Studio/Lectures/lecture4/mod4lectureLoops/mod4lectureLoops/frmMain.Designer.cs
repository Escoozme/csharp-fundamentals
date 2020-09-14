namespace mod4lectureLoops {
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
            this.lbxLoops = new System.Windows.Forms.ListBox();
            this.btnWhileLoop = new System.Windows.Forms.Button();
            this.btnDoWhileLoop = new System.Windows.Forms.Button();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnForEachLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxLoops
            // 
            this.lbxLoops.FormattingEnabled = true;
            this.lbxLoops.ItemHeight = 16;
            this.lbxLoops.Location = new System.Drawing.Point(37, 29);
            this.lbxLoops.Name = "lbxLoops";
            this.lbxLoops.Size = new System.Drawing.Size(240, 148);
            this.lbxLoops.TabIndex = 0;
            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new System.Drawing.Point(37, 210);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new System.Drawing.Size(99, 29);
            this.btnWhileLoop.TabIndex = 1;
            this.btnWhileLoop.Text = "While";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new System.EventHandler(this.btnWhileLoop_Click);
            // 
            // btnDoWhileLoop
            // 
            this.btnDoWhileLoop.Location = new System.Drawing.Point(178, 210);
            this.btnDoWhileLoop.Name = "btnDoWhileLoop";
            this.btnDoWhileLoop.Size = new System.Drawing.Size(99, 29);
            this.btnDoWhileLoop.TabIndex = 2;
            this.btnDoWhileLoop.Text = "Do...While";
            this.btnDoWhileLoop.UseVisualStyleBackColor = true;
            this.btnDoWhileLoop.Click += new System.EventHandler(this.btnDoWhileLoop_Click);
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(37, 270);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(99, 29);
            this.btnForLoop.TabIndex = 3;
            this.btnForLoop.Text = "For";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // btnForEachLoop
            // 
            this.btnForEachLoop.Location = new System.Drawing.Point(178, 270);
            this.btnForEachLoop.Name = "btnForEachLoop";
            this.btnForEachLoop.Size = new System.Drawing.Size(99, 29);
            this.btnForEachLoop.TabIndex = 4;
            this.btnForEachLoop.Text = "For Each";
            this.btnForEachLoop.UseVisualStyleBackColor = true;
            this.btnForEachLoop.Click += new System.EventHandler(this.btnForEachLoop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 331);
            this.Controls.Add(this.btnForEachLoop);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.btnDoWhileLoop);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.lbxLoops);
            this.Font = new System.Drawing.Font("Courier New", 10F);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loops";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLoops;
        private System.Windows.Forms.Button btnWhileLoop;
        private System.Windows.Forms.Button btnDoWhileLoop;
        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Button btnForEachLoop;
    }
}

