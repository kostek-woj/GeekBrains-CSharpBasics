
namespace GuessingGame
{
    partial class FormGuess
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuess));
            this.tbPlayerNumber = new System.Windows.Forms.TextBox();
            this.lblGuessPrompt = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlayerNumber
            // 
            this.tbPlayerNumber.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPlayerNumber.Location = new System.Drawing.Point(20, 49);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(100, 31);
            this.tbPlayerNumber.TabIndex = 0;
            this.tbPlayerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuessPrompt
            // 
            this.lblGuessPrompt.AutoSize = true;
            this.lblGuessPrompt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuessPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblGuessPrompt.Name = "lblGuessPrompt";
            this.lblGuessPrompt.Size = new System.Drawing.Size(115, 25);
            this.lblGuessPrompt.TabIndex = 1;
            this.lblGuessPrompt.Text = "Take a guess:";
            // 
            // btnGuess
            // 
            this.btnGuess.AutoSize = true;
            this.btnGuess.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuess.Location = new System.Drawing.Point(33, 100);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 35);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // FormGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 151);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessPrompt);
            this.Controls.Add(this.tbPlayerNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGuess";
            this.Text = "Take a Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGuessPrompt;
        private System.Windows.Forms.Button btnGuess;
        public System.Windows.Forms.TextBox tbPlayerNumber;
    }
}