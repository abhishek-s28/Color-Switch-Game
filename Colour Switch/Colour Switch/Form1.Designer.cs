namespace Colour_Switch
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
            this.components = new System.ComponentModel.Container();
            this.gameDisplay = new System.Windows.Forms.Panel();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreList = new System.Windows.Forms.ListBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.gameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDisplay
            // 
            this.gameDisplay.BackColor = System.Drawing.Color.Black;
            this.gameDisplay.Controls.Add(this.block1);
            this.gameDisplay.Controls.Add(this.block2);
            this.gameDisplay.Controls.Add(this.player);
            this.gameDisplay.Location = new System.Drawing.Point(0, 0);
            this.gameDisplay.Name = "gameDisplay";
            this.gameDisplay.Size = new System.Drawing.Size(481, 550);
            this.gameDisplay.TabIndex = 0;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Red;
            this.block1.Location = new System.Drawing.Point(-14, 279);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(528, 30);
            this.block1.TabIndex = 1;
            this.block1.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Aqua;
            this.block2.Location = new System.Drawing.Point(-23, 13);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(524, 30);
            this.block2.TabIndex = 0;
            this.block2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(191, 502);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 40);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore.Location = new System.Drawing.Point(487, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(174, 34);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0 ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(487, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 79);
            this.label2.TabIndex = 2;
            this.label2.Text = "Press Space to change colour\r\nPress R to restart game\r\n";
            // 
            // scoreList
            // 
            this.scoreList.BackColor = System.Drawing.Color.DarkBlue;
            this.scoreList.Enabled = false;
            this.scoreList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreList.ForeColor = System.Drawing.Color.Yellow;
            this.scoreList.FormattingEnabled = true;
            this.scoreList.ItemHeight = 32;
            this.scoreList.Location = new System.Drawing.Point(492, 46);
            this.scoreList.Name = "scoreList";
            this.scoreList.Size = new System.Drawing.Size(238, 324);
            this.scoreList.TabIndex = 3;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerTick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Navy;
            this.btnExit.Enabled = false;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(507, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.scoreList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameDisplay);
            this.Name = "Form1";
            this.Text = "Colour Switch";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyIsPressed);
            this.gameDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameDisplay;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox scoreList;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnExit;
    }
}

