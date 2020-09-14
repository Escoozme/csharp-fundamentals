namespace Mod8LectureStarter
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
            this.gbxInventoryForNewCars = new System.Windows.Forms.GroupBox();
            this.lblListCar = new System.Windows.Forms.Label();
            this.lbxCarInventory = new System.Windows.Forms.ListBox();
            this.gbxEnterCarDetails2 = new System.Windows.Forms.GroupBox();
            this.btnEnterInv = new System.Windows.Forms.Button();
            this.tbxPrice2 = new System.Windows.Forms.TextBox();
            this.tbxModel2 = new System.Windows.Forms.TextBox();
            this.tbxMake2 = new System.Windows.Forms.TextBox();
            this.lblPromptPrice2 = new System.Windows.Forms.Label();
            this.lblPromptModel2 = new System.Windows.Forms.Label();
            this.lblPromptMake2 = new System.Windows.Forms.Label();
            this.gbxBuyingANewCar = new System.Windows.Forms.GroupBox();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.gbxObjectProperties = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblOutputPrice = new System.Windows.Forms.Label();
            this.lblOutputModel = new System.Windows.Forms.Label();
            this.lblOutputMake = new System.Windows.Forms.Label();
            this.gbxEnterCarDetails = new System.Windows.Forms.GroupBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxMake = new System.Windows.Forms.TextBox();
            this.lblPromptPrice = new System.Windows.Forms.Label();
            this.lblPromptModel = new System.Windows.Forms.Label();
            this.lblPromptMake = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxCoinTossClass = new System.Windows.Forms.GroupBox();
            this.btnToss = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.gbxInventoryForNewCars.SuspendLayout();
            this.gbxEnterCarDetails2.SuspendLayout();
            this.gbxBuyingANewCar.SuspendLayout();
            this.gbxObjectProperties.SuspendLayout();
            this.gbxEnterCarDetails.SuspendLayout();
            this.gbxCoinTossClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInventoryForNewCars
            // 
            this.gbxInventoryForNewCars.BackColor = System.Drawing.Color.Aqua;
            this.gbxInventoryForNewCars.Controls.Add(this.lblListCar);
            this.gbxInventoryForNewCars.Controls.Add(this.lbxCarInventory);
            this.gbxInventoryForNewCars.Controls.Add(this.gbxEnterCarDetails2);
            this.gbxInventoryForNewCars.Location = new System.Drawing.Point(550, 21);
            this.gbxInventoryForNewCars.Name = "gbxInventoryForNewCars";
            this.gbxInventoryForNewCars.Size = new System.Drawing.Size(233, 378);
            this.gbxInventoryForNewCars.TabIndex = 17;
            this.gbxInventoryForNewCars.TabStop = false;
            this.gbxInventoryForNewCars.Text = "Inventory for New Cars";
            // 
            // lblListCar
            // 
            this.lblListCar.AutoSize = true;
            this.lblListCar.Location = new System.Drawing.Point(86, 202);
            this.lblListCar.Name = "lblListCar";
            this.lblListCar.Size = new System.Drawing.Size(65, 13);
            this.lblListCar.TabIndex = 11;
            this.lblListCar.Text = "Select a Car";
            // 
            // lbxCarInventory
            // 
            this.lbxCarInventory.FormattingEnabled = true;
            this.lbxCarInventory.Location = new System.Drawing.Point(27, 218);
            this.lbxCarInventory.Name = "lbxCarInventory";
            this.lbxCarInventory.Size = new System.Drawing.Size(186, 147);
            this.lbxCarInventory.TabIndex = 10;
            this.lbxCarInventory.SelectedIndexChanged += new System.EventHandler(this.lbxCarInventory_SelectedIndexChanged);
            // 
            // gbxEnterCarDetails2
            // 
            this.gbxEnterCarDetails2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbxEnterCarDetails2.Controls.Add(this.btnEnterInv);
            this.gbxEnterCarDetails2.Controls.Add(this.tbxPrice2);
            this.gbxEnterCarDetails2.Controls.Add(this.tbxModel2);
            this.gbxEnterCarDetails2.Controls.Add(this.tbxMake2);
            this.gbxEnterCarDetails2.Controls.Add(this.lblPromptPrice2);
            this.gbxEnterCarDetails2.Controls.Add(this.lblPromptModel2);
            this.gbxEnterCarDetails2.Controls.Add(this.lblPromptMake2);
            this.gbxEnterCarDetails2.Location = new System.Drawing.Point(27, 36);
            this.gbxEnterCarDetails2.Name = "gbxEnterCarDetails2";
            this.gbxEnterCarDetails2.Size = new System.Drawing.Size(186, 148);
            this.gbxEnterCarDetails2.TabIndex = 9;
            this.gbxEnterCarDetails2.TabStop = false;
            this.gbxEnterCarDetails2.Text = "Enter Car Details";
            // 
            // btnEnterInv
            // 
            this.btnEnterInv.Location = new System.Drawing.Point(62, 116);
            this.btnEnterInv.Name = "btnEnterInv";
            this.btnEnterInv.Size = new System.Drawing.Size(75, 23);
            this.btnEnterInv.TabIndex = 11;
            this.btnEnterInv.Text = "Enter Car";
            this.btnEnterInv.UseVisualStyleBackColor = true;
            this.btnEnterInv.Click += new System.EventHandler(this.btnEnterInv_Click);
            // 
            // tbxPrice2
            // 
            this.tbxPrice2.Location = new System.Drawing.Point(62, 74);
            this.tbxPrice2.Name = "tbxPrice2";
            this.tbxPrice2.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice2.TabIndex = 5;
            // 
            // tbxModel2
            // 
            this.tbxModel2.Location = new System.Drawing.Point(62, 48);
            this.tbxModel2.Name = "tbxModel2";
            this.tbxModel2.Size = new System.Drawing.Size(100, 20);
            this.tbxModel2.TabIndex = 4;
            // 
            // tbxMake2
            // 
            this.tbxMake2.Location = new System.Drawing.Point(62, 22);
            this.tbxMake2.Name = "tbxMake2";
            this.tbxMake2.Size = new System.Drawing.Size(100, 20);
            this.tbxMake2.TabIndex = 3;
            // 
            // lblPromptPrice2
            // 
            this.lblPromptPrice2.AutoSize = true;
            this.lblPromptPrice2.Location = new System.Drawing.Point(22, 77);
            this.lblPromptPrice2.Name = "lblPromptPrice2";
            this.lblPromptPrice2.Size = new System.Drawing.Size(34, 13);
            this.lblPromptPrice2.TabIndex = 2;
            this.lblPromptPrice2.Text = "Price:";
            // 
            // lblPromptModel2
            // 
            this.lblPromptModel2.AutoSize = true;
            this.lblPromptModel2.Location = new System.Drawing.Point(17, 52);
            this.lblPromptModel2.Name = "lblPromptModel2";
            this.lblPromptModel2.Size = new System.Drawing.Size(39, 13);
            this.lblPromptModel2.TabIndex = 1;
            this.lblPromptModel2.Text = "Model:";
            // 
            // lblPromptMake2
            // 
            this.lblPromptMake2.AutoSize = true;
            this.lblPromptMake2.Location = new System.Drawing.Point(18, 25);
            this.lblPromptMake2.Name = "lblPromptMake2";
            this.lblPromptMake2.Size = new System.Drawing.Size(37, 13);
            this.lblPromptMake2.TabIndex = 0;
            this.lblPromptMake2.Text = "Make:";
            // 
            // gbxBuyingANewCar
            // 
            this.gbxBuyingANewCar.BackColor = System.Drawing.Color.Lime;
            this.gbxBuyingANewCar.Controls.Add(this.btnCreateObject);
            this.gbxBuyingANewCar.Controls.Add(this.gbxObjectProperties);
            this.gbxBuyingANewCar.Controls.Add(this.gbxEnterCarDetails);
            this.gbxBuyingANewCar.Location = new System.Drawing.Point(243, 21);
            this.gbxBuyingANewCar.Name = "gbxBuyingANewCar";
            this.gbxBuyingANewCar.Size = new System.Drawing.Size(269, 341);
            this.gbxBuyingANewCar.TabIndex = 16;
            this.gbxBuyingANewCar.TabStop = false;
            this.gbxBuyingANewCar.Text = "Buying a New Car";
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(105, 281);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(75, 41);
            this.btnCreateObject.TabIndex = 10;
            this.btnCreateObject.Text = "Create Object";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // gbxObjectProperties
            // 
            this.gbxObjectProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxObjectProperties.Controls.Add(this.lblPrice);
            this.gbxObjectProperties.Controls.Add(this.lblModel);
            this.gbxObjectProperties.Controls.Add(this.lblMake);
            this.gbxObjectProperties.Controls.Add(this.lblOutputPrice);
            this.gbxObjectProperties.Controls.Add(this.lblOutputModel);
            this.gbxObjectProperties.Controls.Add(this.lblOutputMake);
            this.gbxObjectProperties.Location = new System.Drawing.Point(43, 142);
            this.gbxObjectProperties.Name = "gbxObjectProperties";
            this.gbxObjectProperties.Size = new System.Drawing.Size(186, 124);
            this.gbxObjectProperties.TabIndex = 9;
            this.gbxObjectProperties.TabStop = false;
            this.gbxObjectProperties.Text = "Object Properties";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(59, 85);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModel.Location = new System.Drawing.Point(59, 55);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(100, 23);
            this.lblModel.TabIndex = 6;
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMake
            // 
            this.lblMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMake.Location = new System.Drawing.Point(59, 25);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(100, 23);
            this.lblMake.TabIndex = 4;
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputPrice
            // 
            this.lblOutputPrice.AutoSize = true;
            this.lblOutputPrice.Location = new System.Drawing.Point(22, 90);
            this.lblOutputPrice.Name = "lblOutputPrice";
            this.lblOutputPrice.Size = new System.Drawing.Size(34, 13);
            this.lblOutputPrice.TabIndex = 5;
            this.lblOutputPrice.Text = "Price:";
            // 
            // lblOutputModel
            // 
            this.lblOutputModel.AutoSize = true;
            this.lblOutputModel.Location = new System.Drawing.Point(17, 60);
            this.lblOutputModel.Name = "lblOutputModel";
            this.lblOutputModel.Size = new System.Drawing.Size(39, 13);
            this.lblOutputModel.TabIndex = 4;
            this.lblOutputModel.Text = "Model:";
            // 
            // lblOutputMake
            // 
            this.lblOutputMake.AutoSize = true;
            this.lblOutputMake.Location = new System.Drawing.Point(18, 29);
            this.lblOutputMake.Name = "lblOutputMake";
            this.lblOutputMake.Size = new System.Drawing.Size(37, 13);
            this.lblOutputMake.TabIndex = 3;
            this.lblOutputMake.Text = "Make:";
            // 
            // gbxEnterCarDetails
            // 
            this.gbxEnterCarDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxEnterCarDetails.Controls.Add(this.tbxPrice);
            this.gbxEnterCarDetails.Controls.Add(this.tbxModel);
            this.gbxEnterCarDetails.Controls.Add(this.tbxMake);
            this.gbxEnterCarDetails.Controls.Add(this.lblPromptPrice);
            this.gbxEnterCarDetails.Controls.Add(this.lblPromptModel);
            this.gbxEnterCarDetails.Controls.Add(this.lblPromptMake);
            this.gbxEnterCarDetails.Location = new System.Drawing.Point(43, 36);
            this.gbxEnterCarDetails.Name = "gbxEnterCarDetails";
            this.gbxEnterCarDetails.Size = new System.Drawing.Size(186, 100);
            this.gbxEnterCarDetails.TabIndex = 8;
            this.gbxEnterCarDetails.TabStop = false;
            this.gbxEnterCarDetails.Text = "Enter Car Details";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(62, 74);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 5;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(62, 48);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 4;
            // 
            // tbxMake
            // 
            this.tbxMake.Location = new System.Drawing.Point(62, 22);
            this.tbxMake.Name = "tbxMake";
            this.tbxMake.Size = new System.Drawing.Size(100, 20);
            this.tbxMake.TabIndex = 3;
            // 
            // lblPromptPrice
            // 
            this.lblPromptPrice.AutoSize = true;
            this.lblPromptPrice.Location = new System.Drawing.Point(22, 77);
            this.lblPromptPrice.Name = "lblPromptPrice";
            this.lblPromptPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPromptPrice.TabIndex = 2;
            this.lblPromptPrice.Text = "Price:";
            // 
            // lblPromptModel
            // 
            this.lblPromptModel.AutoSize = true;
            this.lblPromptModel.Location = new System.Drawing.Point(17, 52);
            this.lblPromptModel.Name = "lblPromptModel";
            this.lblPromptModel.Size = new System.Drawing.Size(39, 13);
            this.lblPromptModel.TabIndex = 1;
            this.lblPromptModel.Text = "Model:";
            // 
            // lblPromptMake
            // 
            this.lblPromptMake.AutoSize = true;
            this.lblPromptMake.Location = new System.Drawing.Point(18, 25);
            this.lblPromptMake.Name = "lblPromptMake";
            this.lblPromptMake.Size = new System.Drawing.Size(37, 13);
            this.lblPromptMake.TabIndex = 0;
            this.lblPromptMake.Text = "Make:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(708, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxCoinTossClass
            // 
            this.gbxCoinTossClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxCoinTossClass.Controls.Add(this.btnToss);
            this.gbxCoinTossClass.Controls.Add(this.lbxOutput);
            this.gbxCoinTossClass.Location = new System.Drawing.Point(12, 21);
            this.gbxCoinTossClass.Name = "gbxCoinTossClass";
            this.gbxCoinTossClass.Size = new System.Drawing.Size(199, 193);
            this.gbxCoinTossClass.TabIndex = 14;
            this.gbxCoinTossClass.TabStop = false;
            this.gbxCoinTossClass.Text = "Coin Toss Class";
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(56, 130);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 39);
            this.btnToss.TabIndex = 4;
            this.btnToss.Text = "Toss Five Times";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(38, 29);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(120, 95);
            this.lbxOutput.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 486);
            this.Controls.Add(this.gbxInventoryForNewCars);
            this.Controls.Add(this.gbxBuyingANewCar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxCoinTossClass);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Various Classes";
            this.gbxInventoryForNewCars.ResumeLayout(false);
            this.gbxInventoryForNewCars.PerformLayout();
            this.gbxEnterCarDetails2.ResumeLayout(false);
            this.gbxEnterCarDetails2.PerformLayout();
            this.gbxBuyingANewCar.ResumeLayout(false);
            this.gbxObjectProperties.ResumeLayout(false);
            this.gbxObjectProperties.PerformLayout();
            this.gbxEnterCarDetails.ResumeLayout(false);
            this.gbxEnterCarDetails.PerformLayout();
            this.gbxCoinTossClass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInventoryForNewCars;
        private System.Windows.Forms.Label lblListCar;
        private System.Windows.Forms.ListBox lbxCarInventory;
        private System.Windows.Forms.GroupBox gbxEnterCarDetails2;
        private System.Windows.Forms.Button btnEnterInv;
        private System.Windows.Forms.TextBox tbxPrice2;
        private System.Windows.Forms.TextBox tbxModel2;
        private System.Windows.Forms.TextBox tbxMake2;
        private System.Windows.Forms.Label lblPromptPrice2;
        private System.Windows.Forms.Label lblPromptModel2;
        private System.Windows.Forms.Label lblPromptMake2;
        private System.Windows.Forms.GroupBox gbxBuyingANewCar;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.GroupBox gbxObjectProperties;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblOutputPrice;
        private System.Windows.Forms.Label lblOutputModel;
        private System.Windows.Forms.Label lblOutputMake;
        private System.Windows.Forms.GroupBox gbxEnterCarDetails;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxMake;
        private System.Windows.Forms.Label lblPromptPrice;
        private System.Windows.Forms.Label lblPromptModel;
        private System.Windows.Forms.Label lblPromptMake;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxCoinTossClass;
        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.ListBox lbxOutput;
    }
}

