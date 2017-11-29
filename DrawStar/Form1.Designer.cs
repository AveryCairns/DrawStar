namespace DrawStar
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
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.xPosLabel = new System.Windows.Forms.Label();
            this.yPosLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(220, 34);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(52, 20);
            this.xInput.TabIndex = 0;
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(220, 78);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(52, 20);
            this.yInput.TabIndex = 1;
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(220, 117);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(52, 20);
            this.sizeInput.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(220, 143);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(52, 26);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // xPosLabel
            // 
            this.xPosLabel.AutoSize = true;
            this.xPosLabel.Location = new System.Drawing.Point(220, 18);
            this.xPosLabel.Name = "xPosLabel";
            this.xPosLabel.Size = new System.Drawing.Size(52, 13);
            this.xPosLabel.TabIndex = 4;
            this.xPosLabel.Text = "x Position";
            // 
            // yPosLabel
            // 
            this.yPosLabel.AutoSize = true;
            this.yPosLabel.Location = new System.Drawing.Point(220, 62);
            this.yPosLabel.Name = "yPosLabel";
            this.yPosLabel.Size = new System.Drawing.Size(52, 13);
            this.yPosLabel.TabIndex = 5;
            this.yPosLabel.Text = "y Position";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(231, 101);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 6;
            this.sizeLabel.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yPosLabel);
            this.Controls.Add(this.xPosLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.xInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label xPosLabel;
        private System.Windows.Forms.Label yPosLabel;
        private System.Windows.Forms.Label sizeLabel;
    }
}

