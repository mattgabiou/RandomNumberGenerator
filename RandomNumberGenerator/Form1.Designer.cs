namespace RandomNumberGenerator
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
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoopCount = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelLoops = new System.Windows.Forms.Label();
            this.buttonLoopUntil = new System.Windows.Forms.Button();
            this.textBoxLoopUntil = new System.Windows.Forms.TextBox();
            this.labelLoopUntil = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLow
            // 
            this.textBoxLow.Location = new System.Drawing.Point(9, 64);
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(100, 20);
            this.textBoxLow.TabIndex = 0;
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(157, 64);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(100, 20);
            this.textBoxHigh.TabIndex = 1;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(3, 23);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(186, 13);
            this.labelInstructions.TabIndex = 2;
            this.labelInstructions.Text = "Enter the range of the random number";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(36, 48);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(27, 13);
            this.labelLow.TabIndex = 3;
            this.labelLow.Text = "Low";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(183, 48);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(29, 13);
            this.labelHigh.TabIndex = 4;
            this.labelHigh.Text = "High";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelLoopCount);
            this.panel1.Controls.Add(this.labelInstructions);
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Controls.Add(this.labelLoops);
            this.panel1.Controls.Add(this.textBoxHigh);
            this.panel1.Controls.Add(this.buttonLoopUntil);
            this.panel1.Controls.Add(this.labelHigh);
            this.panel1.Controls.Add(this.textBoxLoopUntil);
            this.panel1.Controls.Add(this.textBoxLow);
            this.panel1.Controls.Add(this.labelLoopUntil);
            this.panel1.Controls.Add(this.labelLow);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 267);
            this.panel1.TabIndex = 5;
            // 
            // labelLoopCount
            // 
            this.labelLoopCount.AutoSize = true;
            this.labelLoopCount.Location = new System.Drawing.Point(55, 222);
            this.labelLoopCount.Name = "labelLoopCount";
            this.labelLoopCount.Size = new System.Drawing.Size(13, 13);
            this.labelLoopCount.TabIndex = 10;
            this.labelLoopCount.Text = "0";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(82, 90);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(107, 23);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate Number";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelLoops
            // 
            this.labelLoops.AutoSize = true;
            this.labelLoops.Location = new System.Drawing.Point(13, 222);
            this.labelLoops.Name = "labelLoops";
            this.labelLoops.Size = new System.Drawing.Size(36, 13);
            this.labelLoops.TabIndex = 9;
            this.labelLoops.Text = "Loops";
            // 
            // buttonLoopUntil
            // 
            this.buttonLoopUntil.Location = new System.Drawing.Point(144, 183);
            this.buttonLoopUntil.Name = "buttonLoopUntil";
            this.buttonLoopUntil.Size = new System.Drawing.Size(75, 23);
            this.buttonLoopUntil.TabIndex = 8;
            this.buttonLoopUntil.Text = "Start";
            this.buttonLoopUntil.UseVisualStyleBackColor = true;
            this.buttonLoopUntil.Click += new System.EventHandler(this.buttonLoopUntil_Click);
            // 
            // textBoxLoopUntil
            // 
            this.textBoxLoopUntil.Location = new System.Drawing.Point(16, 185);
            this.textBoxLoopUntil.Name = "textBoxLoopUntil";
            this.textBoxLoopUntil.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoopUntil.TabIndex = 7;
            // 
            // labelLoopUntil
            // 
            this.labelLoopUntil.AutoSize = true;
            this.labelLoopUntil.Location = new System.Drawing.Point(13, 157);
            this.labelLoopUntil.Name = "labelLoopUntil";
            this.labelLoopUntil.Size = new System.Drawing.Size(213, 13);
            this.labelLoopUntil.TabIndex = 6;
            this.labelLoopUntil.Text = "Loops until the following number is reached:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Numbers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLow;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelLoopUntil;
        private System.Windows.Forms.TextBox textBoxLoopUntil;
        private System.Windows.Forms.Button buttonLoopUntil;
        private System.Windows.Forms.Label labelLoops;
        private System.Windows.Forms.Label labelLoopCount;
    }
}

