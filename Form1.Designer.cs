
namespace RegexLearning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.patternLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.matchLabel = new System.Windows.Forms.Label();
            this.IsMatchResultLabel = new System.Windows.Forms.Label();
            this.verbatim = new System.Windows.Forms.Button();
            this.onlyMatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.patternLabel.ForeColor = System.Drawing.Color.Black;
            this.patternLabel.Location = new System.Drawing.Point(85, 40);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(94, 32);
            this.patternLabel.TabIndex = 0;
            this.patternLabel.Text = "Pattern";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputLabel.ForeColor = System.Drawing.Color.Black;
            this.inputLabel.Location = new System.Drawing.Point(85, 198);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(64, 30);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTextBox.Location = new System.Drawing.Point(247, 198);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(452, 145);
            this.inputTextBox.TabIndex = 3;
            // 
            // patternTextBox
            // 
            this.patternTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patternTextBox.ForeColor = System.Drawing.Color.Black;
            this.patternTextBox.Location = new System.Drawing.Point(247, 40);
            this.patternTextBox.Multiline = true;
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(452, 145);
            this.patternTextBox.TabIndex = 4;
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.matchLabel.ForeColor = System.Drawing.Color.Black;
            this.matchLabel.Location = new System.Drawing.Point(85, 391);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(88, 30);
            this.matchLabel.TabIndex = 5;
            this.matchLabel.Text = "IsMatch:";
            // 
            // IsMatchResultLabel
            // 
            this.IsMatchResultLabel.AutoSize = true;
            this.IsMatchResultLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IsMatchResultLabel.Location = new System.Drawing.Point(230, 391);
            this.IsMatchResultLabel.Name = "IsMatchResultLabel";
            this.IsMatchResultLabel.Size = new System.Drawing.Size(0, 30);
            this.IsMatchResultLabel.TabIndex = 6;
            // 
            // verbatim
            // 
            this.verbatim.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verbatim.Location = new System.Drawing.Point(705, 40);
            this.verbatim.Name = "verbatim";
            this.verbatim.Size = new System.Drawing.Size(53, 42);
            this.verbatim.TabIndex = 7;
            this.verbatim.Text = "@";
            this.verbatim.UseVisualStyleBackColor = false;
            this.verbatim.Click += new System.EventHandler(this.verbatim_Click);
            // 
            // onlyMatchButton
            // 
            this.onlyMatchButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.onlyMatchButton.Location = new System.Drawing.Point(705, 143);
            this.onlyMatchButton.Name = "onlyMatchButton";
            this.onlyMatchButton.Size = new System.Drawing.Size(53, 42);
            this.onlyMatchButton.TabIndex = 8;
            this.onlyMatchButton.Text = "^$";
            this.onlyMatchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlyMatchButton.UseVisualStyleBackColor = false;
            this.onlyMatchButton.Click += new System.EventHandler(this.onlyMatchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 436);
            this.Controls.Add(this.onlyMatchButton);
            this.Controls.Add(this.verbatim);
            this.Controls.Add(this.IsMatchResultLabel);
            this.Controls.Add(this.matchLabel);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.patternLabel);
            this.Name = "Form1";
            this.Text = "RegexMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.Label IsMatchResultLabel;
        public System.Windows.Forms.Label patternLabel;
        public System.Windows.Forms.Label inputLabel;
        public System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Button verbatim;
        private System.Windows.Forms.Button onlyMatchButton;
    }
}

