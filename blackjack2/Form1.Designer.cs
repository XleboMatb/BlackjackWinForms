namespace blackjack2
{
    partial class mainForm
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
            this.playButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.getACardButton = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.amountOfCardsInDeckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(285, 344);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(248, 94);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScoreLabel.Location = new System.Drawing.Point(12, 412);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(89, 29);
            this.playerScoreLabel.TabIndex = 1;
            this.playerScoreLabel.Text = "Score: ";
            // 
            // getACardButton
            // 
            this.getACardButton.Location = new System.Drawing.Point(620, 205);
            this.getACardButton.Name = "getACardButton";
            this.getACardButton.Size = new System.Drawing.Size(168, 59);
            this.getACardButton.TabIndex = 2;
            this.getACardButton.Text = "ДАЙ МНЕ ЕЩЁ";
            this.getACardButton.UseVisualStyleBackColor = true;
            this.getACardButton.Click += new System.EventHandler(this.getACardButton_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Location = new System.Drawing.Point(12, 205);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(168, 59);
            this.endTurnButton.TabIndex = 3;
            this.endTurnButton.Text = "НЕ ДАВАЙ МНЕ ЕЩЁ";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // amountOfCardsInDeckLabel
            // 
            this.amountOfCardsInDeckLabel.AutoSize = true;
            this.amountOfCardsInDeckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountOfCardsInDeckLabel.Location = new System.Drawing.Point(12, 9);
            this.amountOfCardsInDeckLabel.Name = "amountOfCardsInDeckLabel";
            this.amountOfCardsInDeckLabel.Size = new System.Drawing.Size(228, 24);
            this.amountOfCardsInDeckLabel.TabIndex = 4;
            this.amountOfCardsInDeckLabel.Text = "осталось карт в колоде:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountOfCardsInDeckLabel);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.getACardButton);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.playButton);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Button getACardButton;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Label amountOfCardsInDeckLabel;
    }
}

