namespace CardIdentifier
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
            title = new Label();
            exitButton = new Button();
            threeOfClubs = new PictureBox();
            sevenOfHearts = new PictureBox();
            aceOfSpades = new PictureBox();
            kingOfHearts = new PictureBox();
            jackOfDiamonds = new PictureBox();
            cardNameOut = new Label();
            ((System.ComponentModel.ISupportInitialize)threeOfClubs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sevenOfHearts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aceOfSpades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kingOfHearts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jackOfDiamonds).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(157, 9);
            title.Name = "title";
            title.Size = new Size(284, 25);
            title.TabIndex = 0;
            title.Text = "Click on a card to see its name!";
            title.Click += label1_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(262, 217);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 25);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // threeOfClubs
            // 
            threeOfClubs.Image = Properties.Resources._3_Clubs;
            threeOfClubs.Location = new Point(16, 45);
            threeOfClubs.Name = "threeOfClubs";
            threeOfClubs.Size = new Size(90, 126);
            threeOfClubs.SizeMode = PictureBoxSizeMode.Zoom;
            threeOfClubs.TabIndex = 2;
            threeOfClubs.TabStop = false;
            threeOfClubs.Click += pictureBox1_Click;
            // 
            // sevenOfHearts
            // 
            sevenOfHearts.Image = Properties.Resources._7_Hearts;
            sevenOfHearts.Location = new Point(131, 45);
            sevenOfHearts.Name = "sevenOfHearts";
            sevenOfHearts.Size = new Size(90, 126);
            sevenOfHearts.SizeMode = PictureBoxSizeMode.Zoom;
            sevenOfHearts.TabIndex = 3;
            sevenOfHearts.TabStop = false;
            sevenOfHearts.Click += sevenOfHearts_Click;
            // 
            // aceOfSpades
            // 
            aceOfSpades.Image = Properties.Resources.Ace_Spades;
            aceOfSpades.Location = new Point(246, 45);
            aceOfSpades.Name = "aceOfSpades";
            aceOfSpades.Size = new Size(90, 126);
            aceOfSpades.SizeMode = PictureBoxSizeMode.Zoom;
            aceOfSpades.TabIndex = 4;
            aceOfSpades.TabStop = false;
            aceOfSpades.Click += pictureBox2_Click;
            // 
            // kingOfHearts
            // 
            kingOfHearts.Image = Properties.Resources.King_Hearts;
            kingOfHearts.Location = new Point(476, 45);
            kingOfHearts.Name = "kingOfHearts";
            kingOfHearts.Size = new Size(90, 126);
            kingOfHearts.SizeMode = PictureBoxSizeMode.Zoom;
            kingOfHearts.TabIndex = 5;
            kingOfHearts.TabStop = false;
            kingOfHearts.Click += kingOfHearts_Click;
            // 
            // jackOfDiamonds
            // 
            jackOfDiamonds.Image = Properties.Resources.Jack_Diamonds;
            jackOfDiamonds.Location = new Point(361, 45);
            jackOfDiamonds.Name = "jackOfDiamonds";
            jackOfDiamonds.Size = new Size(90, 126);
            jackOfDiamonds.SizeMode = PictureBoxSizeMode.Zoom;
            jackOfDiamonds.TabIndex = 6;
            jackOfDiamonds.TabStop = false;
            jackOfDiamonds.Click += pictureBox1_Click_1;
            // 
            // cardNameOut
            // 
            cardNameOut.BorderStyle = BorderStyle.FixedSingle;
            cardNameOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardNameOut.Location = new Point(181, 185);
            cardNameOut.Name = "cardNameOut";
            cardNameOut.Size = new Size(236, 27);
            cardNameOut.TabIndex = 7;
            cardNameOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 249);
            Controls.Add(cardNameOut);
            Controls.Add(jackOfDiamonds);
            Controls.Add(kingOfHearts);
            Controls.Add(aceOfSpades);
            Controls.Add(sevenOfHearts);
            Controls.Add(threeOfClubs);
            Controls.Add(exitButton);
            Controls.Add(title);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Card Identifier";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)threeOfClubs).EndInit();
            ((System.ComponentModel.ISupportInitialize)sevenOfHearts).EndInit();
            ((System.ComponentModel.ISupportInitialize)aceOfSpades).EndInit();
            ((System.ComponentModel.ISupportInitialize)kingOfHearts).EndInit();
            ((System.ComponentModel.ISupportInitialize)jackOfDiamonds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button exitButton;
        private PictureBox threeOfClubs;
        private PictureBox sevenOfHearts;
        private PictureBox aceOfSpades;
        private PictureBox kingOfHearts;
        private PictureBox jackOfDiamonds;
        private Label cardNameOut;
    }
}
