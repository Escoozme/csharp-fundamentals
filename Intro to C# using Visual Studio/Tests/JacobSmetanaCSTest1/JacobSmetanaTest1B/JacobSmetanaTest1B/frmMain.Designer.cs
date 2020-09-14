namespace JacobSmetanaTest1B {
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
            this.gbxNames = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.gbxCalculator = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFirstNumber = new System.Windows.Forms.TextBox();
            this.tbxSecondNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbxOperators = new System.Windows.Forms.GroupBox();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radSubtract = new System.Windows.Forms.RadioButton();
            this.radMultiply = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxNames.SuspendLayout();
            this.gbxCalculator.SuspendLayout();
            this.gbxOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNames
            // 
            this.gbxNames.Controls.Add(this.btnName);
            this.gbxNames.Controls.Add(this.tbxLastName);
            this.gbxNames.Controls.Add(this.tbxFirstName);
            this.gbxNames.Controls.Add(this.label2);
            this.gbxNames.Controls.Add(this.label1);
            this.gbxNames.Location = new System.Drawing.Point(12, 12);
            this.gbxNames.Name = "gbxNames";
            this.gbxNames.Size = new System.Drawing.Size(350, 150);
            this.gbxNames.TabIndex = 0;
            this.gbxNames.TabStop = false;
            this.gbxNames.Text = "Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(124, 28);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(200, 23);
            this.tbxFirstName.TabIndex = 2;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(124, 66);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(200, 23);
            this.tbxLastName.TabIndex = 3;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(234, 103);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(90, 30);
            this.btnName.TabIndex = 4;
            this.btnName.Text = "&Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // gbxCalculator
            // 
            this.gbxCalculator.Controls.Add(this.btnCalculate);
            this.gbxCalculator.Controls.Add(this.gbxOperators);
            this.gbxCalculator.Controls.Add(this.lblResult);
            this.gbxCalculator.Controls.Add(this.label5);
            this.gbxCalculator.Controls.Add(this.tbxSecondNumber);
            this.gbxCalculator.Controls.Add(this.tbxFirstNumber);
            this.gbxCalculator.Controls.Add(this.label4);
            this.gbxCalculator.Controls.Add(this.label3);
            this.gbxCalculator.Location = new System.Drawing.Point(18, 178);
            this.gbxCalculator.Name = "gbxCalculator";
            this.gbxCalculator.Size = new System.Drawing.Size(339, 239);
            this.gbxCalculator.TabIndex = 1;
            this.gbxCalculator.TabStop = false;
            this.gbxCalculator.Text = "Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "1st Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "2nd Number";
            // 
            // tbxFirstNumber
            // 
            this.tbxFirstNumber.Location = new System.Drawing.Point(16, 51);
            this.tbxFirstNumber.Name = "tbxFirstNumber";
            this.tbxFirstNumber.Size = new System.Drawing.Size(100, 23);
            this.tbxFirstNumber.TabIndex = 2;
            // 
            // tbxSecondNumber
            // 
            this.tbxSecondNumber.Location = new System.Drawing.Point(222, 51);
            this.tbxSecondNumber.Name = "tbxSecondNumber";
            this.tbxSecondNumber.Size = new System.Drawing.Size(100, 23);
            this.tbxSecondNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblResult.Location = new System.Drawing.Point(94, 154);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 30);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxOperators
            // 
            this.gbxOperators.Controls.Add(this.radMultiply);
            this.gbxOperators.Controls.Add(this.radAdd);
            this.gbxOperators.Controls.Add(this.radSubtract);
            this.gbxOperators.Location = new System.Drawing.Point(122, 22);
            this.gbxOperators.Name = "gbxOperators";
            this.gbxOperators.Size = new System.Drawing.Size(94, 100);
            this.gbxOperators.TabIndex = 6;
            this.gbxOperators.TabStop = false;
            this.gbxOperators.Text = "Operators";
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(30, 22);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(34, 21);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "+";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // radSubtract
            // 
            this.radSubtract.AutoSize = true;
            this.radSubtract.Location = new System.Drawing.Point(30, 47);
            this.radSubtract.Name = "radSubtract";
            this.radSubtract.Size = new System.Drawing.Size(34, 21);
            this.radSubtract.TabIndex = 1;
            this.radSubtract.TabStop = true;
            this.radSubtract.Text = "-";
            this.radSubtract.UseVisualStyleBackColor = true;
            // 
            // radMultiply
            // 
            this.radMultiply.AutoSize = true;
            this.radMultiply.Location = new System.Drawing.Point(30, 72);
            this.radMultiply.Name = "radMultiply";
            this.radMultiply.Size = new System.Drawing.Size(34, 21);
            this.radMultiply.TabIndex = 2;
            this.radMultiply.TabStop = true;
            this.radMultiply.Text = "*";
            this.radMultiply.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(124, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxCalculator);
            this.Controls.Add(this.gbxNames);
            this.Font = new System.Drawing.Font("Courier New", 10F);
            this.MaximumSize = new System.Drawing.Size(390, 508);
            this.MinimumSize = new System.Drawing.Size(390, 508);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Names and Calculator";
            this.gbxNames.ResumeLayout(false);
            this.gbxNames.PerformLayout();
            this.gbxCalculator.ResumeLayout(false);
            this.gbxCalculator.PerformLayout();
            this.gbxOperators.ResumeLayout(false);
            this.gbxOperators.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNames;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCalculator;
        private System.Windows.Forms.TextBox tbxSecondNumber;
        private System.Windows.Forms.TextBox tbxFirstNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxOperators;
        private System.Windows.Forms.RadioButton radMultiply;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radSubtract;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

