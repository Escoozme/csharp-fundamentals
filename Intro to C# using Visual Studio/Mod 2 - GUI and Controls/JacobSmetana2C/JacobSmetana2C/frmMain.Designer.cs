namespace JacobSmetana2C {
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.pbxApple = new System.Windows.Forms.PictureBox();
            this.pbxBanana = new System.Windows.Forms.PictureBox();
            this.pbxPear = new System.Windows.Forms.PictureBox();
            this.pbxOrange = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrange)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(352, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Calories";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCalories.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalories.Location = new System.Drawing.Point(342, 57);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(120, 40);
            this.lblTotalCalories.TabIndex = 3;
            this.lblTotalCalories.Text = "0";
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxApple
            // 
            this.pbxApple.Image = global::JacobSmetana2C.Properties.Resources.AppleCalories;
            this.pbxApple.Location = new System.Drawing.Point(189, 217);
            this.pbxApple.Name = "pbxApple";
            this.pbxApple.Size = new System.Drawing.Size(128, 155);
            this.pbxApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxApple.TabIndex = 7;
            this.pbxApple.TabStop = false;
            this.pbxApple.Click += new System.EventHandler(this.pbxApple_Click);
            // 
            // pbxBanana
            // 
            this.pbxBanana.Image = global::JacobSmetana2C.Properties.Resources.BananaCalories;
            this.pbxBanana.Location = new System.Drawing.Point(32, 217);
            this.pbxBanana.Name = "pbxBanana";
            this.pbxBanana.Size = new System.Drawing.Size(128, 155);
            this.pbxBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBanana.TabIndex = 6;
            this.pbxBanana.TabStop = false;
            this.pbxBanana.Click += new System.EventHandler(this.pbxBanana_Click);
            // 
            // pbxPear
            // 
            this.pbxPear.Image = global::JacobSmetana2C.Properties.Resources.PearCalories;
            this.pbxPear.Location = new System.Drawing.Point(189, 31);
            this.pbxPear.Name = "pbxPear";
            this.pbxPear.Size = new System.Drawing.Size(128, 155);
            this.pbxPear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPear.TabIndex = 5;
            this.pbxPear.TabStop = false;
            this.pbxPear.Click += new System.EventHandler(this.pbxPear_Click);
            // 
            // pbxOrange
            // 
            this.pbxOrange.Image = global::JacobSmetana2C.Properties.Resources.OrangeCalories;
            this.pbxOrange.Location = new System.Drawing.Point(32, 31);
            this.pbxOrange.Name = "pbxOrange";
            this.pbxOrange.Size = new System.Drawing.Size(128, 155);
            this.pbxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxOrange.TabIndex = 4;
            this.pbxOrange.TabStop = false;
            this.pbxOrange.Click += new System.EventHandler(this.pbxOrange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 401);
            this.Controls.Add(this.pbxApple);
            this.Controls.Add(this.pbxBanana);
            this.Controls.Add(this.pbxPear);
            this.Controls.Add(this.pbxOrange);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(500, 439);
            this.MinimumSize = new System.Drawing.Size(500, 439);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pbxApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.PictureBox pbxOrange;
        private System.Windows.Forms.PictureBox pbxPear;
        private System.Windows.Forms.PictureBox pbxBanana;
        private System.Windows.Forms.PictureBox pbxApple;
    }
}

