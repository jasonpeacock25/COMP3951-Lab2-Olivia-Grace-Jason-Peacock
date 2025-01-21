﻿namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            this.groupBoxMemory = new System.Windows.Forms.GroupBox();
            this.buttonMemoryAdd = new System.Windows.Forms.Button();
            this.buttonMemoryAssign = new System.Windows.Forms.Button();
            this.buttonMemoryRecall = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.panelDigits = new System.Windows.Forms.Panel();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.panelClearButtons = new System.Windows.Forms.Panel();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClearCurrent = new System.Windows.Forms.Button();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBoxMemory.SuspendLayout();
            this.panelDigits.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.panelClearButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Enabled = false;
            this.textBoxCalculation.Location = new System.Drawing.Point(176, 58);
            this.textBoxCalculation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.ReadOnly = true;
            this.textBoxCalculation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCalculation.Size = new System.Drawing.Size(456, 31);
            this.textBoxCalculation.TabIndex = 1;
            this.textBoxCalculation.Text = "0";
            this.textBoxCalculation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxMemory
            // 
            this.groupBoxMemory.Controls.Add(this.buttonMemoryAdd);
            this.groupBoxMemory.Controls.Add(this.buttonMemoryAssign);
            this.groupBoxMemory.Controls.Add(this.buttonMemoryRecall);
            this.groupBoxMemory.Controls.Add(this.buttonMemoryClear);
            this.groupBoxMemory.Location = new System.Drawing.Point(286, 131);
            this.groupBoxMemory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBoxMemory.Name = "groupBoxMemory";
            this.groupBoxMemory.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBoxMemory.Size = new System.Drawing.Size(464, 156);
            this.groupBoxMemory.TabIndex = 2;
            this.groupBoxMemory.TabStop = false;
            this.groupBoxMemory.Text = "Memory Buttons";
            // 
            // buttonMemoryAdd
            // 
            this.buttonMemoryAdd.Enabled = false;
            this.buttonMemoryAdd.Location = new System.Drawing.Point(356, 50);
            this.buttonMemoryAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMemoryAdd.Name = "buttonMemoryAdd";
            this.buttonMemoryAdd.Size = new System.Drawing.Size(76, 69);
            this.buttonMemoryAdd.TabIndex = 3;
            this.buttonMemoryAdd.Text = "M+";
            this.buttonMemoryAdd.UseVisualStyleBackColor = true;
            this.buttonMemoryAdd.Click += new System.EventHandler(this.buttonMemoryAdd_Click);
            // 
            // buttonMemoryAssign
            // 
            this.buttonMemoryAssign.Enabled = false;
            this.buttonMemoryAssign.Location = new System.Drawing.Point(250, 50);
            this.buttonMemoryAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMemoryAssign.Name = "buttonMemoryAssign";
            this.buttonMemoryAssign.Size = new System.Drawing.Size(76, 69);
            this.buttonMemoryAssign.TabIndex = 2;
            this.buttonMemoryAssign.Text = "MS";
            this.buttonMemoryAssign.UseVisualStyleBackColor = true;
            this.buttonMemoryAssign.Click += new System.EventHandler(this.buttonMemoryAssign_Click);
            // 
            // buttonMemoryRecall
            // 
            this.buttonMemoryRecall.Enabled = false;
            this.buttonMemoryRecall.Location = new System.Drawing.Point(142, 50);
            this.buttonMemoryRecall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMemoryRecall.Name = "buttonMemoryRecall";
            this.buttonMemoryRecall.Size = new System.Drawing.Size(76, 69);
            this.buttonMemoryRecall.TabIndex = 1;
            this.buttonMemoryRecall.Text = "MR";
            this.buttonMemoryRecall.UseVisualStyleBackColor = true;
            this.buttonMemoryRecall.Click += new System.EventHandler(this.buttonMemoryRecall_Click);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.Enabled = false;
            this.buttonMemoryClear.Location = new System.Drawing.Point(40, 50);
            this.buttonMemoryClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(76, 69);
            this.buttonMemoryClear.TabIndex = 0;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = true;
            this.buttonMemoryClear.Click += new System.EventHandler(this.buttonMemoryClear_Click);
            // 
            // panelDigits
            // 
            this.panelDigits.Controls.Add(this.buttonPlusMinus);
            this.panelDigits.Controls.Add(this.buttonDecimal);
            this.panelDigits.Controls.Add(this.button0);
            this.panelDigits.Controls.Add(this.button9);
            this.panelDigits.Controls.Add(this.button8);
            this.panelDigits.Controls.Add(this.button7);
            this.panelDigits.Controls.Add(this.button6);
            this.panelDigits.Controls.Add(this.button5);
            this.panelDigits.Controls.Add(this.button4);
            this.panelDigits.Controls.Add(this.button3);
            this.panelDigits.Controls.Add(this.button2);
            this.panelDigits.Controls.Add(this.button1);
            this.panelDigits.Location = new System.Drawing.Point(18, 319);
            this.panelDigits.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelDigits.Name = "panelDigits";
            this.panelDigits.Size = new System.Drawing.Size(340, 412);
            this.panelDigits.TabIndex = 3;
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Enabled = false;
            this.buttonPlusMinus.Location = new System.Drawing.Point(238, 323);
            this.buttonPlusMinus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(76, 69);
            this.buttonPlusMinus.TabIndex = 9;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Enabled = false;
            this.buttonDecimal.Location = new System.Drawing.Point(138, 323);
            this.buttonDecimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(76, 69);
            this.buttonDecimal.TabIndex = 8;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button0
            // 
            this.button0.Enabled = false;
            this.button0.Location = new System.Drawing.Point(38, 323);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 69);
            this.button0.TabIndex = 7;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(238, 231);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 69);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(138, 231);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 69);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(38, 231);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 69);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(238, 133);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 69);
            this.button6.TabIndex = 4;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(136, 131);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 69);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(38, 133);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(238, 38);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(136, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(38, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.buttonSquare);
            this.panelOperations.Controls.Add(this.buttonAdd);
            this.panelOperations.Controls.Add(this.buttonInverse);
            this.panelOperations.Controls.Add(this.buttonSubtract);
            this.panelOperations.Controls.Add(this.buttonPercent);
            this.panelOperations.Controls.Add(this.buttonMultiply);
            this.panelOperations.Controls.Add(this.buttonSquareRoot);
            this.panelOperations.Controls.Add(this.buttonDivide);
            this.panelOperations.Location = new System.Drawing.Point(384, 319);
            this.panelOperations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(208, 406);
            this.panelOperations.TabIndex = 4;
            // 
            // buttonSquare
            // 
            this.buttonSquare.Enabled = false;
            this.buttonSquare.Location = new System.Drawing.Point(116, 317);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(76, 69);
            this.buttonSquare.TabIndex = 7;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(24, 317);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 69);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Enabled = false;
            this.buttonInverse.Location = new System.Drawing.Point(116, 223);
            this.buttonInverse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(76, 69);
            this.buttonInverse.TabIndex = 5;
            this.buttonInverse.Text = "1/x";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Enabled = false;
            this.buttonSubtract.Location = new System.Drawing.Point(24, 223);
            this.buttonSubtract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(76, 69);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Enabled = false;
            this.buttonPercent.Location = new System.Drawing.Point(116, 127);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(76, 69);
            this.buttonPercent.TabIndex = 3;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Enabled = false;
            this.buttonMultiply.Location = new System.Drawing.Point(24, 127);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(76, 69);
            this.buttonMultiply.TabIndex = 2;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Enabled = false;
            this.buttonSquareRoot.Location = new System.Drawing.Point(116, 37);
            this.buttonSquareRoot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(76, 69);
            this.buttonSquareRoot.TabIndex = 1;
            this.buttonSquareRoot.Text = "sqrt";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Enabled = false;
            this.buttonDivide.Location = new System.Drawing.Point(24, 37);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(76, 69);
            this.buttonDivide.TabIndex = 0;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // panelClearButtons
            // 
            this.panelClearButtons.Controls.Add(this.buttonEquals);
            this.panelClearButtons.Controls.Add(this.buttonBackspace);
            this.panelClearButtons.Controls.Add(this.buttonClearAll);
            this.panelClearButtons.Controls.Add(this.buttonClearCurrent);
            this.panelClearButtons.Location = new System.Drawing.Point(620, 319);
            this.panelClearButtons.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelClearButtons.Name = "panelClearButtons";
            this.panelClearButtons.Size = new System.Drawing.Size(132, 406);
            this.panelClearButtons.TabIndex = 5;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Enabled = false;
            this.buttonEquals.Location = new System.Drawing.Point(22, 317);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(76, 69);
            this.buttonEquals.TabIndex = 3;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Enabled = false;
            this.buttonBackspace.Location = new System.Drawing.Point(22, 223);
            this.buttonBackspace.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(76, 69);
            this.buttonBackspace.TabIndex = 2;
            this.buttonBackspace.Text = "<-";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Enabled = false;
            this.buttonClearAll.Location = new System.Drawing.Point(22, 127);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(76, 69);
            this.buttonClearAll.TabIndex = 1;
            this.buttonClearAll.Text = "C";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonClearCurrent
            // 
            this.buttonClearCurrent.Enabled = false;
            this.buttonClearCurrent.Location = new System.Drawing.Point(22, 31);
            this.buttonClearCurrent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClearCurrent.Name = "buttonClearCurrent";
            this.buttonClearCurrent.Size = new System.Drawing.Size(76, 69);
            this.buttonClearCurrent.TabIndex = 0;
            this.buttonClearCurrent.Text = "CE";
            this.buttonClearCurrent.UseVisualStyleBackColor = true;
            this.buttonClearCurrent.Click += new System.EventHandler(this.buttonClearCurrent_Click);
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Location = new System.Drawing.Point(80, 167);
            this.buttonOnOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(76, 69);
            this.buttonOnOff.TabIndex = 6;
            this.buttonOnOff.Text = "On";
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.InitialImage")));
            this.pictureBoxImage.Location = new System.Drawing.Point(126, 804);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(540, 185);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 7;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 1062);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.panelClearButtons);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelDigits);
            this.Controls.Add(this.groupBoxMemory);
            this.Controls.Add(this.textBoxCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBoxMemory.ResumeLayout(false);
            this.panelDigits.ResumeLayout(false);
            this.panelOperations.ResumeLayout(false);
            this.panelClearButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCalculation;
        private System.Windows.Forms.GroupBox groupBoxMemory;
        private System.Windows.Forms.Panel panelDigits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonMemoryRecall;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.Button buttonMemoryAdd;
        private System.Windows.Forms.Button buttonMemoryAssign;
        private System.Windows.Forms.Panel panelClearButtons;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonClearCurrent;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}

