namespace Lecture_5
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
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSingleValue = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnVariable = new System.Windows.Forms.Button();
            this.btnByValue = new System.Windows.Forms.Button();
            this.btnByRef = new System.Windows.Forms.Button();
            this.btnOutputParm = new System.Windows.Forms.Button();
            this.btnValRetMethod = new System.Windows.Forms.Button();
            this.tbxNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(24, 85);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 50);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "C&hange Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter either 1 or 2";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(24, 59);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(88, 20);
            this.tbxNumber.TabIndex = 2;
            this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSingleValue
            // 
            this.btnSingleValue.Location = new System.Drawing.Point(170, 36);
            this.btnSingleValue.Name = "btnSingleValue";
            this.btnSingleValue.Size = new System.Drawing.Size(54, 41);
            this.btnSingleValue.TabIndex = 4;
            this.btnSingleValue.Text = "&Single Value";
            this.btnSingleValue.UseVisualStyleBackColor = true;
            this.btnSingleValue.Click += new System.EventHandler(this.btnSingleValue_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(170, 107);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(54, 42);
            this.btnAddValue.TabIndex = 5;
            this.btnAddValue.Text = "&Adding Values";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnVariable
            // 
            this.btnVariable.Location = new System.Drawing.Point(170, 179);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(54, 42);
            this.btnVariable.TabIndex = 6;
            this.btnVariable.Text = "Varia&ble";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // btnByValue
            // 
            this.btnByValue.Location = new System.Drawing.Point(261, 34);
            this.btnByValue.Name = "btnByValue";
            this.btnByValue.Size = new System.Drawing.Size(73, 53);
            this.btnByValue.TabIndex = 7;
            this.btnByValue.Text = "Passing By &Value";
            this.btnByValue.UseVisualStyleBackColor = true;
            this.btnByValue.Click += new System.EventHandler(this.btnByValue_Click);
            // 
            // btnByRef
            // 
            this.btnByRef.Location = new System.Drawing.Point(261, 102);
            this.btnByRef.Name = "btnByRef";
            this.btnByRef.Size = new System.Drawing.Size(73, 53);
            this.btnByRef.TabIndex = 8;
            this.btnByRef.Text = "Passing By &Reference";
            this.btnByRef.UseVisualStyleBackColor = true;
            this.btnByRef.Click += new System.EventHandler(this.btnByRef_Click);
            // 
            // btnOutputParm
            // 
            this.btnOutputParm.Location = new System.Drawing.Point(261, 170);
            this.btnOutputParm.Name = "btnOutputParm";
            this.btnOutputParm.Size = new System.Drawing.Size(73, 53);
            this.btnOutputParm.TabIndex = 9;
            this.btnOutputParm.Text = "&Output Parameters";
            this.btnOutputParm.UseVisualStyleBackColor = true;
            this.btnOutputParm.Click += new System.EventHandler(this.btnOutputParm_Click);
            // 
            // btnValRetMethod
            // 
            this.btnValRetMethod.Location = new System.Drawing.Point(367, 102);
            this.btnValRetMethod.Name = "btnValRetMethod";
            this.btnValRetMethod.Size = new System.Drawing.Size(98, 53);
            this.btnValRetMethod.TabIndex = 10;
            this.btnValRetMethod.Text = "Va&lue-Returning Method";
            this.btnValRetMethod.UseVisualStyleBackColor = true;
            this.btnValRetMethod.Click += new System.EventHandler(this.btnValRetMethod_Click);
            // 
            // tbxNumber2
            // 
            this.tbxNumber2.Location = new System.Drawing.Point(367, 67);
            this.tbxNumber2.Name = "tbxNumber2";
            this.tbxNumber2.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter a number\r\nbetween 1-10.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNumber2);
            this.Controls.Add(this.btnValRetMethod);
            this.Controls.Add(this.btnOutputParm);
            this.Controls.Add(this.btnByRef);
            this.Controls.Add(this.btnByValue);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.btnSingleValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColor);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 5 Lecture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSingleValue;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.Button btnByValue;
        private System.Windows.Forms.Button btnByRef;
        private System.Windows.Forms.Button btnOutputParm;
        private System.Windows.Forms.Button btnValRetMethod;
        private System.Windows.Forms.TextBox tbxNumber2;
        private System.Windows.Forms.Label label2;
    }
}

