namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controls

        private System.Windows.Forms.GroupBox groupBoxOilAndLube;
        private System.Windows.Forms.CheckBox checkBoxOilChange;
        private System.Windows.Forms.CheckBox checkBoxLube;

        private System.Windows.Forms.GroupBox groupBoxCleaning;
        private System.Windows.Forms.CheckBox checkBoxRadiator;
        private System.Windows.Forms.CheckBox checkBoxFuelSystem;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.CheckBox checkBoxMuffler;
        private System.Windows.Forms.CheckBox checkBoxTire;

        private System.Windows.Forms.GroupBox groupBoxPartsAndLabor;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox textBoxHours;

        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelServiceLabor;                 // 欄位標題
        private System.Windows.Forms.Label labelServiceLaborValue;           // 顯示值（改用 Label）
        private System.Windows.Forms.Label labelPartsCost;
        private System.Windows.Forms.Label labelPartsCostValue;
        private System.Windows.Forms.Label labelPartsTax;
        private System.Windows.Forms.Label labelPartsTaxValue;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalValue;

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;

        #endregion

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOilAndLube = new GroupBox();
            checkBoxOilChange = new CheckBox();
            checkBoxLube = new CheckBox();
            groupBoxCleaning = new GroupBox();
            checkBoxRadiator = new CheckBox();
            checkBoxFuelSystem = new CheckBox();
            groupBoxOther = new GroupBox();
            checkBoxInspection = new CheckBox();
            checkBoxMuffler = new CheckBox();
            checkBoxTire = new CheckBox();
            groupBoxPartsAndLabor = new GroupBox();
            labelParts = new Label();
            textBoxParts = new TextBox();
            labelHours = new Label();
            textBoxHours = new TextBox();
            groupBoxSummary = new GroupBox();
            labelServiceLabor = new Label();
            labelServiceLaborValue = new Label();
            labelPartsCost = new Label();
            labelPartsCostValue = new Label();
            labelPartsTax = new Label();
            labelPartsTaxValue = new Label();
            labelTotal = new Label();
            labelTotalValue = new Label();
            buttonCalculate = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            groupBoxOilAndLube.SuspendLayout();
            groupBoxCleaning.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBoxPartsAndLabor.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOilAndLube
            // 
            groupBoxOilAndLube.Controls.Add(checkBoxOilChange);
            groupBoxOilAndLube.Controls.Add(checkBoxLube);
            groupBoxOilAndLube.Location = new Point(12, 12);
            groupBoxOilAndLube.Name = "groupBoxOilAndLube";
            groupBoxOilAndLube.Size = new Size(240, 90);
            groupBoxOilAndLube.TabIndex = 0;
            groupBoxOilAndLube.TabStop = false;
            groupBoxOilAndLube.Text = "機油和潤滑";
            // 
            // checkBoxOilChange
            // 
            checkBoxOilChange.AutoSize = true;
            checkBoxOilChange.Location = new Point(12, 24);
            checkBoxOilChange.Name = "checkBoxOilChange";
            checkBoxOilChange.Size = new Size(190, 27);
            checkBoxOilChange.TabIndex = 0;
            checkBoxOilChange.Text = "更換機油 (NT$780)";
            // 
            // checkBoxLube
            // 
            checkBoxLube.AutoSize = true;
            checkBoxLube.Location = new Point(12, 50);
            checkBoxLube.Name = "checkBoxLube";
            checkBoxLube.Size = new Size(190, 27);
            checkBoxLube.TabIndex = 1;
            checkBoxLube.Text = "潤滑保養 (NT$540)";
            // 
            // groupBoxCleaning
            // 
            groupBoxCleaning.Controls.Add(checkBoxRadiator);
            groupBoxCleaning.Controls.Add(checkBoxFuelSystem);
            groupBoxCleaning.Location = new Point(270, 12);
            groupBoxCleaning.Name = "groupBoxCleaning";
            groupBoxCleaning.Size = new Size(260, 90);
            groupBoxCleaning.TabIndex = 1;
            groupBoxCleaning.TabStop = false;
            groupBoxCleaning.Text = "清洗服務";
            // 
            // checkBoxRadiator
            // 
            checkBoxRadiator.AutoSize = true;
            checkBoxRadiator.Location = new Point(12, 24);
            checkBoxRadiator.Name = "checkBoxRadiator";
            checkBoxRadiator.Size = new Size(190, 27);
            checkBoxRadiator.TabIndex = 0;
            checkBoxRadiator.Text = "水箱清洗 (NT$900)";
            // 
            // checkBoxFuelSystem
            // 
            checkBoxFuelSystem.AutoSize = true;
            checkBoxFuelSystem.Location = new Point(12, 50);
            checkBoxFuelSystem.Name = "checkBoxFuelSystem";
            checkBoxFuelSystem.Size = new Size(240, 27);
            checkBoxFuelSystem.TabIndex = 1;
            checkBoxFuelSystem.Text = "燃油系統清洗 (NT$2,400)";
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(checkBoxInspection);
            groupBoxOther.Controls.Add(checkBoxMuffler);
            groupBoxOther.Controls.Add(checkBoxTire);
            groupBoxOther.Location = new Point(12, 110);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(240, 120);
            groupBoxOther.TabIndex = 2;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "其他服務";
            // 
            // checkBoxInspection
            // 
            checkBoxInspection.AutoSize = true;
            checkBoxInspection.Location = new Point(12, 24);
            checkBoxInspection.Name = "checkBoxInspection";
            checkBoxInspection.Size = new Size(154, 27);
            checkBoxInspection.TabIndex = 0;
            checkBoxInspection.Text = "檢驗 (NT$450)";
            // 
            // checkBoxMuffler
            // 
            checkBoxMuffler.AutoSize = true;
            checkBoxMuffler.Location = new Point(12, 50);
            checkBoxMuffler.Name = "checkBoxMuffler";
            checkBoxMuffler.Size = new Size(222, 27);
            checkBoxMuffler.TabIndex = 1;
            checkBoxMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // checkBoxTire
            // 
            checkBoxTire.AutoSize = true;
            checkBoxTire.Location = new Point(12, 76);
            checkBoxTire.Name = "checkBoxTire";
            checkBoxTire.Size = new Size(190, 27);
            checkBoxTire.TabIndex = 2;
            checkBoxTire.Text = "輪胎定位 (NT$600)";
            // 
            // groupBoxPartsAndLabor
            // 
            groupBoxPartsAndLabor.Controls.Add(labelParts);
            groupBoxPartsAndLabor.Controls.Add(textBoxParts);
            groupBoxPartsAndLabor.Controls.Add(labelHours);
            groupBoxPartsAndLabor.Controls.Add(textBoxHours);
            groupBoxPartsAndLabor.Location = new Point(270, 110);
            groupBoxPartsAndLabor.Name = "groupBoxPartsAndLabor";
            groupBoxPartsAndLabor.Size = new Size(260, 120);
            groupBoxPartsAndLabor.TabIndex = 3;
            groupBoxPartsAndLabor.TabStop = false;
            groupBoxPartsAndLabor.Text = "零件和工時";
            // 
            // labelParts
            // 
            labelParts.AutoSize = true;
            labelParts.Location = new Point(12, 30);
            labelParts.Name = "labelParts";
            labelParts.Size = new Size(98, 23);
            labelParts.TabIndex = 0;
            labelParts.Text = "零件 (NT$)";
            // 
            // textBoxParts
            // 
            textBoxParts.Location = new Point(130, 27);
            textBoxParts.Name = "textBoxParts";
            textBoxParts.Size = new Size(110, 30);
            textBoxParts.TabIndex = 1;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(12, 70);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(117, 23);
            labelHours.TabIndex = 2;
            labelHours.Text = "工時數 (小時)";
            // 
            // textBoxHours
            // 
            textBoxHours.Location = new Point(130, 67);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.Size = new Size(110, 30);
            textBoxHours.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(labelServiceLabor);
            groupBoxSummary.Controls.Add(labelServiceLaborValue);
            groupBoxSummary.Controls.Add(labelPartsCost);
            groupBoxSummary.Controls.Add(labelPartsCostValue);
            groupBoxSummary.Controls.Add(labelPartsTax);
            groupBoxSummary.Controls.Add(labelPartsTaxValue);
            groupBoxSummary.Controls.Add(labelTotal);
            groupBoxSummary.Controls.Add(labelTotalValue);
            groupBoxSummary.Location = new Point(12, 245);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(518, 95);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "費用摘要";
            // 
            // labelServiceLabor
            // 
            labelServiceLabor.AutoSize = true;
            labelServiceLabor.Location = new Point(12, 24);
            labelServiceLabor.Name = "labelServiceLabor";
            labelServiceLabor.Size = new Size(100, 23);
            labelServiceLabor.TabIndex = 0;
            labelServiceLabor.Text = "服務與工資";
            // 
            // labelServiceLaborValue
            // 
            labelServiceLaborValue.BorderStyle = BorderStyle.Fixed3D;
            labelServiceLaborValue.Location = new Point(110, 20);
            labelServiceLaborValue.Name = "labelServiceLaborValue";
            labelServiceLaborValue.Size = new Size(140, 23);
            labelServiceLaborValue.TabIndex = 1;
            labelServiceLaborValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPartsCost
            // 
            labelPartsCost.AutoSize = true;
            labelPartsCost.Location = new Point(270, 24);
            labelPartsCost.Name = "labelPartsCost";
            labelPartsCost.Size = new Size(46, 23);
            labelPartsCost.TabIndex = 2;
            labelPartsCost.Text = "零件";
            // 
            // labelPartsCostValue
            // 
            labelPartsCostValue.BorderStyle = BorderStyle.Fixed3D;
            labelPartsCostValue.Location = new Point(320, 20);
            labelPartsCostValue.Name = "labelPartsCostValue";
            labelPartsCostValue.Size = new Size(160, 23);
            labelPartsCostValue.TabIndex = 3;
            labelPartsCostValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPartsTax
            // 
            labelPartsTax.AutoSize = true;
            labelPartsTax.Location = new Point(12, 58);
            labelPartsTax.Name = "labelPartsTax";
            labelPartsTax.Size = new Size(99, 23);
            labelPartsTax.TabIndex = 4;
            labelPartsTax.Text = "稅金 (零件)";
            // 
            // labelPartsTaxValue
            // 
            labelPartsTaxValue.BorderStyle = BorderStyle.Fixed3D;
            labelPartsTaxValue.Location = new Point(110, 54);
            labelPartsTaxValue.Name = "labelPartsTaxValue";
            labelPartsTaxValue.Size = new Size(140, 23);
            labelPartsTaxValue.TabIndex = 5;
            labelPartsTaxValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(270, 58);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(64, 23);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "總費用";
            // 
            // labelTotalValue
            // 
            labelTotalValue.BorderStyle = BorderStyle.Fixed3D;
            labelTotalValue.Location = new Point(320, 54);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(160, 23);
            labelTotalValue.TabIndex = 7;
            labelTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(120, 350);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 30);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "計算總額";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(230, 350);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 30);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "清除";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(340, 350);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(100, 30);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "離開";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 400);
            Controls.Add(groupBoxOilAndLube);
            Controls.Add(groupBoxCleaning);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxPartsAndLabor);
            Controls.Add(groupBoxSummary);
            Controls.Add(buttonCalculate);
            Controls.Add(buttonClear);
            Controls.Add(buttonExit);
            Name = "Form1";
            Text = "汽車維修服務";
            groupBoxOilAndLube.ResumeLayout(false);
            groupBoxOilAndLube.PerformLayout();
            groupBoxCleaning.ResumeLayout(false);
            groupBoxCleaning.PerformLayout();
            groupBoxOther.ResumeLayout(false);
            groupBoxOther.PerformLayout();
            groupBoxPartsAndLabor.ResumeLayout(false);
            groupBoxPartsAndLabor.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
