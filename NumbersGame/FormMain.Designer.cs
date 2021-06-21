
namespace NumbersGame
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTimePlayed = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnMultiplyByTwo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblCommands = new System.Windows.Forms.Label();
            this.lblTargetNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.imglSmileys = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame,
            this.toolStripMenuItem2,
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.Size = new System.Drawing.Size(131, 22);
            this.tsmiNewGame.Text = "New game";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(131, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBoutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aBoutToolStripMenuItem
            // 
            this.aBoutToolStripMenuItem.Name = "aBoutToolStripMenuItem";
            this.aBoutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aBoutToolStripMenuItem.Text = "About...";
            this.aBoutToolStripMenuItem.Click += new System.EventHandler(this.tsmiAbout);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTimePlayed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 30);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTimePlayed
            // 
            this.tsslTimePlayed.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsslTimePlayed.Name = "tsslTimePlayed";
            this.tsslTimePlayed.Size = new System.Drawing.Size(128, 25);
            this.tsslTimePlayed.Text = "tsslTimePlayed";
            // 
            // btnAddOne
            // 
            this.btnAddOne.AutoSize = true;
            this.btnAddOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddOne.Enabled = false;
            this.btnAddOne.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddOne.Location = new System.Drawing.Point(87, 137);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(61, 48);
            this.btnAddOne.TabIndex = 1;
            this.btnAddOne.Text = "+1";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnMultiplyByTwo
            // 
            this.btnMultiplyByTwo.AutoSize = true;
            this.btnMultiplyByTwo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMultiplyByTwo.Enabled = false;
            this.btnMultiplyByTwo.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplyByTwo.Location = new System.Drawing.Point(172, 137);
            this.btnMultiplyByTwo.Name = "btnMultiplyByTwo";
            this.btnMultiplyByTwo.Size = new System.Drawing.Size(61, 48);
            this.btnMultiplyByTwo.TabIndex = 2;
            this.btnMultiplyByTwo.Text = "×2";
            this.btnMultiplyByTwo.UseVisualStyleBackColor = true;
            this.btnMultiplyByTwo.Click += new System.EventHandler(this.btnMultiplyByTwo_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(257, 137);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 48);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Step Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(424, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Target Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.lblSteps);
            this.gbStatistics.Controls.Add(this.lblCommands);
            this.gbStatistics.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbStatistics.Location = new System.Drawing.Point(12, 242);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(476, 101);
            this.gbStatistics.TabIndex = 9;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Game Statistics";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSteps.Location = new System.Drawing.Point(22, 64);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(59, 25);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.Text = "Steps:";
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCommands.Location = new System.Drawing.Point(22, 30);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(108, 25);
            this.lblCommands.TabIndex = 1;
            this.lblCommands.Text = "Commands:";
            // 
            // lblTargetNumber
            // 
            this.lblTargetNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetNumber.Font = new System.Drawing.Font("Segoe UI", 49F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetNumber.Location = new System.Drawing.Point(260, 45);
            this.lblTargetNumber.Name = "lblTargetNumber";
            this.lblTargetNumber.Size = new System.Drawing.Size(228, 82);
            this.lblTargetNumber.TabIndex = 0;
            this.lblTargetNumber.Text = "–";
            this.lblTargetNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Segoe UI", 49F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerNumber.Location = new System.Drawing.Point(12, 45);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(219, 82);
            this.lblPlayerNumber.TabIndex = 11;
            this.lblPlayerNumber.Text = "–";
            this.lblPlayerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imglSmileys
            // 
            this.imglSmileys.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imglSmileys.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglSmileys.ImageStream")));
            this.imglSmileys.TransparentColor = System.Drawing.Color.Transparent;
            this.imglSmileys.Images.SetKeyName(0, "smileys_lose.png");
            this.imglSmileys.Images.SetKeyName(1, "smileys_playing.png");
            this.imglSmileys.Images.SetKeyName(2, "smileys_win.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnMultiplyByTwo);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTargetNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Numbers Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbStatistics.ResumeLayout(false);
            this.gbStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnMultiplyByTwo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStatistics;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblCommands;
        private System.Windows.Forms.Label lblTargetNumber;
        private System.Windows.Forms.ToolStripStatusLabel tsslTimePlayed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.ImageList imglSmileys;
    }
}

