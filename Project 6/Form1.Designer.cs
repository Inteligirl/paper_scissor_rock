namespace Project_6
{
    partial class rockPaperScissor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rockPaperScissor));
            this.topLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.playerChoiceLabel = new System.Windows.Forms.Label();
            this.submitChoiceButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.submitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(182, -12);
            this.topLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(253, 54);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Paper Scissors Rock Game";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.InitialImage = null;
            this.computerPictureBox.Location = new System.Drawing.Point(441, 45);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(139, 133);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 3;
            this.computerPictureBox.TabStop = false;
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Location = new System.Drawing.Point(435, 181);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(128, 35);
            this.computerLabel.TabIndex = 2;
            this.computerLabel.Text = "Computer Chooses";
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.InitialImage = null;
            this.playerPictureBox.Location = new System.Drawing.Point(12, 48);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(152, 130);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 5;
            this.playerPictureBox.TabStop = false;
            // 
            // playerChoiceLabel
            // 
            this.playerChoiceLabel.AutoSize = true;
            this.playerChoiceLabel.Location = new System.Drawing.Point(35, 185);
            this.playerChoiceLabel.Name = "playerChoiceLabel";
            this.playerChoiceLabel.Size = new System.Drawing.Size(104, 35);
            this.playerChoiceLabel.TabIndex = 0;
            this.playerChoiceLabel.Text = "Player Chooses";
            // 
            // submitChoiceButton
            // 
            this.submitChoiceButton.Location = new System.Drawing.Point(197, 321);
            this.submitChoiceButton.Name = "submitChoiceButton";
            this.submitChoiceButton.Size = new System.Drawing.Size(108, 45);
            this.submitChoiceButton.TabIndex = 7;
            this.submitChoiceButton.Text = "S&ubmit";
            this.submitChoiceButton.UseVisualStyleBackColor = true;
            this.submitChoiceButton.Click += new System.EventHandler(this.submitChoiceButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(310, 321);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 45);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(191, 273);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 38);
            this.rockButton.TabIndex = 4;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(272, 273);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 38);
            this.paperButton.TabIndex = 5;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scissorButton.Location = new System.Drawing.Point(353, 273);
            this.scissorButton.Margin = new System.Windows.Forms.Padding(0);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(82, 35);
            this.scissorButton.TabIndex = 6;
            this.scissorButton.Text = "Scissor";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resultLabel.Location = new System.Drawing.Point(191, 185);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(237, 72);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(25, 273);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(139, 35);
            this.weaponLabel.TabIndex = 9;
            this.weaponLabel.Text = "Choose your weapon:";
            // 
            // submitLabel
            // 
            this.submitLabel.AutoSize = true;
            this.submitLabel.Location = new System.Drawing.Point(31, 321);
            this.submitLabel.Name = "submitLabel";
            this.submitLabel.Size = new System.Drawing.Size(126, 35);
            this.submitLabel.TabIndex = 10;
            this.submitLabel.Text = "Then press submit";
            // 
            // rockPaperScissor
            // 
            this.AcceptButton = this.submitChoiceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(599, 377);
            this.Controls.Add(this.submitLabel);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitChoiceButton);
            this.Controls.Add(this.playerChoiceLabel);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topLabel);
            this.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "rockPaperScissor";
            this.Text = "Rock Paper Scissor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label playerChoiceLabel;
        private System.Windows.Forms.Button submitChoiceButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label submitLabel;
    }
}

