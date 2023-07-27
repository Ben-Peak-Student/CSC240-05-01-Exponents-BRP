namespace Exponents
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
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.UxInputLabel = new System.Windows.Forms.Label();
            this.xOutputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.UxOutPutTextBox = new System.Windows.Forms.TextBox();
            this.UxOutPutcube = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Location = new System.Drawing.Point(89, 43);
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.UxInputTextBox.TabIndex = 0;
            // 
            // UxInputLabel
            // 
            this.UxInputLabel.AutoSize = true;
            this.UxInputLabel.Location = new System.Drawing.Point(95, 27);
            this.UxInputLabel.Name = "UxInputLabel";
            this.UxInputLabel.Size = new System.Drawing.Size(85, 13);
            this.UxInputLabel.TabIndex = 3;
            this.UxInputLabel.Text = "Enter an integer:";
            // 
            // xOutputLabel
            // 
            this.xOutputLabel.AutoSize = true;
            this.xOutputLabel.Location = new System.Drawing.Point(102, 181);
            this.xOutputLabel.Name = "xOutputLabel";
            this.xOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.xOutputLabel.TabIndex = 4;
            this.xOutputLabel.Visible = false;
            // 
            // UxGoButton
            // 
            this.UxGoButton.Location = new System.Drawing.Point(98, 69);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(75, 67);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.Text = "Go!";
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // UxResetButton
            // 
            this.UxResetButton.Location = new System.Drawing.Point(98, 197);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(75, 23);
            this.UxResetButton.TabIndex = 7;
            this.UxResetButton.Text = "Reset";
            this.UxResetButton.UseVisualStyleBackColor = true;
            this.UxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // UxOutPutTextBox
            // 
            this.UxOutPutTextBox.Location = new System.Drawing.Point(89, 142);
            this.UxOutPutTextBox.Name = "UxOutPutTextBox";
            this.UxOutPutTextBox.Size = new System.Drawing.Size(90, 20);
            this.UxOutPutTextBox.TabIndex = 8;
            this.UxOutPutTextBox.Visible = false;
            // 
            // UxOutPutcube
            // 
            this.UxOutPutcube.Location = new System.Drawing.Point(89, 168);
            this.UxOutPutcube.Name = "UxOutPutcube";
            this.UxOutPutcube.Size = new System.Drawing.Size(91, 20);
            this.UxOutPutcube.TabIndex = 9;
            this.UxOutPutcube.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.UxOutPutcube);
            this.Controls.Add(this.UxOutPutTextBox);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.xOutputLabel);
            this.Controls.Add(this.UxInputLabel);
            this.Controls.Add(this.UxInputTextBox);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label UxInputLabel;
        private System.Windows.Forms.Label xOutputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button UxResetButton;
        private System.Windows.Forms.TextBox UxOutPutTextBox;
        private System.Windows.Forms.TextBox UxOutPutcube;
    }
}

