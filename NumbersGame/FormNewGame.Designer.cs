
namespace NumbersGame
{
    partial class FormNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewGame));
            this.lblGameGoal = new System.Windows.Forms.Label();
            this.btnNewGameDialogOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameGoal
            // 
            this.lblGameGoal.AutoSize = true;
            this.lblGameGoal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameGoal.Location = new System.Drawing.Point(19, 9);
            this.lblGameGoal.Name = "lblGameGoal";
            this.lblGameGoal.Size = new System.Drawing.Size(453, 25);
            this.lblGameGoal.TabIndex = 0;
            this.lblGameGoal.Text = "You must get number 100 with minimum 10 operations";
            this.lblGameGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGameDialogOK
            // 
            this.btnNewGameDialogOK.AutoSize = true;
            this.btnNewGameDialogOK.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewGameDialogOK.Location = new System.Drawing.Point(208, 64);
            this.btnNewGameDialogOK.Name = "btnNewGameDialogOK";
            this.btnNewGameDialogOK.Size = new System.Drawing.Size(75, 35);
            this.btnNewGameDialogOK.TabIndex = 1;
            this.btnNewGameDialogOK.Text = "OK";
            this.btnNewGameDialogOK.UseVisualStyleBackColor = true;
            this.btnNewGameDialogOK.Click += new System.EventHandler(this.btnNewGameDialogOK_Click);
            // 
            // FormNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.btnNewGameDialogOK);
            this.Controls.Add(this.lblGameGoal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewGame";
            this.Text = "New Game Goal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewGameDialogOK;
        public System.Windows.Forms.Label lblGameGoal;
    }
}