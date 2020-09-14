namespace JacobSmetana5B {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxLubeJob = new System.Windows.Forms.CheckBox();
            this.cbxOilChange = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.cbxTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxInspection = new System.Windows.Forms.CheckBox();
            this.cbxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.cbxTireRotation = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxLabor = new System.Windows.Forms.TextBox();
            this.tbxPartsCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTaxOnParts = new System.Windows.Forms.Label();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.lblServicesAndLabor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxLubeJob);
            this.groupBox1.Controls.Add(this.cbxOilChange);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // cbxLubeJob
            // 
            this.cbxLubeJob.AutoSize = true;
            this.cbxLubeJob.Location = new System.Drawing.Point(6, 49);
            this.cbxLubeJob.Name = "cbxLubeJob";
            this.cbxLubeJob.Size = new System.Drawing.Size(144, 21);
            this.cbxLubeJob.TabIndex = 1;
            this.cbxLubeJob.Text = "Lube Job ($18.00)";
            this.cbxLubeJob.UseVisualStyleBackColor = true;
            // 
            // cbxOilChange
            // 
            this.cbxOilChange.AutoSize = true;
            this.cbxOilChange.Location = new System.Drawing.Point(6, 22);
            this.cbxOilChange.Name = "cbxOilChange";
            this.cbxOilChange.Size = new System.Drawing.Size(155, 21);
            this.cbxOilChange.TabIndex = 0;
            this.cbxOilChange.Text = "Oil Change ($26.00)";
            this.cbxOilChange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxRadiatorFlush);
            this.groupBox2.Controls.Add(this.cbxTransmissionFlush);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // cbxRadiatorFlush
            // 
            this.cbxRadiatorFlush.AutoSize = true;
            this.cbxRadiatorFlush.Location = new System.Drawing.Point(6, 22);
            this.cbxRadiatorFlush.Name = "cbxRadiatorFlush";
            this.cbxRadiatorFlush.Size = new System.Drawing.Size(177, 21);
            this.cbxRadiatorFlush.TabIndex = 2;
            this.cbxRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.cbxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // cbxTransmissionFlush
            // 
            this.cbxTransmissionFlush.AutoSize = true;
            this.cbxTransmissionFlush.Location = new System.Drawing.Point(6, 49);
            this.cbxTransmissionFlush.Name = "cbxTransmissionFlush";
            this.cbxTransmissionFlush.Size = new System.Drawing.Size(207, 21);
            this.cbxTransmissionFlush.TabIndex = 3;
            this.cbxTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.cbxTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxInspection);
            this.groupBox3.Controls.Add(this.cbxReplaceMuffler);
            this.groupBox3.Controls.Add(this.cbxTireRotation);
            this.groupBox3.Location = new System.Drawing.Point(12, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 105);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // cbxInspection
            // 
            this.cbxInspection.AutoSize = true;
            this.cbxInspection.Location = new System.Drawing.Point(6, 22);
            this.cbxInspection.Name = "cbxInspection";
            this.cbxInspection.Size = new System.Drawing.Size(149, 21);
            this.cbxInspection.TabIndex = 4;
            this.cbxInspection.Text = "Inspection ($15.00)";
            this.cbxInspection.UseVisualStyleBackColor = true;
            // 
            // cbxReplaceMuffler
            // 
            this.cbxReplaceMuffler.AutoSize = true;
            this.cbxReplaceMuffler.Location = new System.Drawing.Point(6, 49);
            this.cbxReplaceMuffler.Name = "cbxReplaceMuffler";
            this.cbxReplaceMuffler.Size = new System.Drawing.Size(192, 21);
            this.cbxReplaceMuffler.TabIndex = 5;
            this.cbxReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.cbxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // cbxTireRotation
            // 
            this.cbxTireRotation.AutoSize = true;
            this.cbxTireRotation.Location = new System.Drawing.Point(6, 76);
            this.cbxTireRotation.Name = "cbxTireRotation";
            this.cbxTireRotation.Size = new System.Drawing.Size(167, 21);
            this.cbxTireRotation.TabIndex = 6;
            this.cbxTireRotation.Text = "Tire Rotation ($20.00)";
            this.cbxTireRotation.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxLabor);
            this.groupBox4.Controls.Add(this.tbxPartsCost);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(238, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // tbxLabor
            // 
            this.tbxLabor.Location = new System.Drawing.Point(96, 65);
            this.tbxLabor.Name = "tbxLabor";
            this.tbxLabor.Size = new System.Drawing.Size(75, 23);
            this.tbxLabor.TabIndex = 3;
            this.tbxLabor.Text = "0";
            // 
            // tbxPartsCost
            // 
            this.tbxPartsCost.Location = new System.Drawing.Point(96, 27);
            this.tbxPartsCost.Name = "tbxPartsCost";
            this.tbxPartsCost.Size = new System.Drawing.Size(75, 23);
            this.tbxPartsCost.TabIndex = 2;
            this.tbxPartsCost.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalFees);
            this.groupBox5.Controls.Add(this.lblTaxOnParts);
            this.groupBox5.Controls.Add(this.lblPartsCost);
            this.groupBox5.Controls.Add(this.lblServicesAndLabor);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(12, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 157);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(173, 124);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(100, 23);
            this.lblTotalFees.TabIndex = 7;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxOnParts
            // 
            this.lblTaxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxOnParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxOnParts.Location = new System.Drawing.Point(173, 89);
            this.lblTaxOnParts.Name = "lblTaxOnParts";
            this.lblTaxOnParts.Size = new System.Drawing.Size(100, 23);
            this.lblTaxOnParts.TabIndex = 6;
            this.lblTaxOnParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsCost.Location = new System.Drawing.Point(173, 54);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(100, 23);
            this.lblPartsCost.TabIndex = 5;
            this.lblPartsCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicesAndLabor
            // 
            this.lblServicesAndLabor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServicesAndLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicesAndLabor.Location = new System.Drawing.Point(173, 19);
            this.lblServicesAndLabor.Name = "lblServicesAndLabor";
            this.lblServicesAndLabor.Size = new System.Drawing.Size(100, 23);
            this.lblServicesAndLabor.TabIndex = 4;
            this.lblServicesAndLabor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Services and Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(82, 379);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(190, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(298, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(486, 459);
            this.MinimumSize = new System.Drawing.Size(486, 459);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxLubeJob;
        private System.Windows.Forms.CheckBox cbxOilChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxRadiatorFlush;
        private System.Windows.Forms.CheckBox cbxTransmissionFlush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxInspection;
        private System.Windows.Forms.CheckBox cbxReplaceMuffler;
        private System.Windows.Forms.CheckBox cbxTireRotation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbxLabor;
        private System.Windows.Forms.TextBox tbxPartsCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblTaxOnParts;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.Label lblServicesAndLabor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

