namespace AnimesHub.Forms.UserControls
{
    partial class AnimeCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCapaAnimCard = new PictureBox();
            lblNomeAnimeCard = new Label();
            lblDescAnimeCard = new Label();
            lblAnoAnimeCard = new Label();
            ((System.ComponentModel.ISupportInitialize)picCapaAnimCard).BeginInit();
            SuspendLayout();
            // 
            // picCapaAnimCard
            // 
            picCapaAnimCard.BorderStyle = BorderStyle.FixedSingle;
            picCapaAnimCard.Location = new Point(10, 7);
            picCapaAnimCard.Name = "picCapaAnimCard";
            picCapaAnimCard.Size = new Size(160, 200);
            picCapaAnimCard.SizeMode = PictureBoxSizeMode.StretchImage;
            picCapaAnimCard.TabIndex = 0;
            picCapaAnimCard.TabStop = false;
            // 
            // lblNomeAnimeCard
            // 
            lblNomeAnimeCard.AutoSize = true;
            lblNomeAnimeCard.Location = new Point(61, 213);
            lblNomeAnimeCard.Name = "lblNomeAnimeCard";
            lblNomeAnimeCard.Size = new Size(44, 15);
            lblNomeAnimeCard.TabIndex = 1;
            lblNomeAnimeCard.Text = "Naruto";
            // 
            // lblDescAnimeCard
            // 
            lblDescAnimeCard.Location = new Point(10, 230);
            lblDescAnimeCard.Name = "lblDescAnimeCard";
            lblDescAnimeCard.Size = new Size(160, 50);
            lblDescAnimeCard.TabIndex = 2;
            lblDescAnimeCard.Text = "Um Ninja querendo ser Hokage";
            // 
            // lblAnoAnimeCard
            // 
            lblAnoAnimeCard.AutoSize = true;
            lblAnoAnimeCard.Location = new Point(64, 278);
            lblAnoAnimeCard.Margin = new Padding(10);
            lblAnoAnimeCard.Name = "lblAnoAnimeCard";
            lblAnoAnimeCard.Padding = new Padding(5);
            lblAnoAnimeCard.Size = new Size(41, 25);
            lblAnoAnimeCard.TabIndex = 3;
            lblAnoAnimeCard.Text = "2000";
            // 
            // AnimeCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAnoAnimeCard);
            Controls.Add(lblDescAnimeCard);
            Controls.Add(lblNomeAnimeCard);
            Controls.Add(picCapaAnimCard);
            Name = "AnimeCardControl";
            Size = new Size(180, 300);
            Load += AnimeCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)picCapaAnimCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCapaAnimCard;
        private Label lblNomeAnimeCard;
        private Label lblDescAnimeCard;
        private Label lblAnoAnimeCard;
    }
}
