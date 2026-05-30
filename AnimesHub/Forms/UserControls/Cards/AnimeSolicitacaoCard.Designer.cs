namespace AnimesHub.Forms.UserControls.Cards
{
    partial class AnimeSolicitacaoCard
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
            label1 = new Label();
            lblNomeAnimeSlc = new Label();
            lblObsAnimeSlc = new Label();
            label4 = new Label();
            txtStatusSlc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(207, 21);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNomeAnimeSlc
            // 
            lblNomeAnimeSlc.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            lblNomeAnimeSlc.Location = new Point(14, 42);
            lblNomeAnimeSlc.Name = "lblNomeAnimeSlc";
            lblNomeAnimeSlc.Size = new Size(207, 63);
            lblNomeAnimeSlc.TabIndex = 4;
            lblNomeAnimeSlc.Text = "NOME LOUCO DO ANIME QUE PEDIRAM AQUI";
            lblNomeAnimeSlc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblObsAnimeSlc
            // 
            lblObsAnimeSlc.BorderStyle = BorderStyle.FixedSingle;
            lblObsAnimeSlc.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            lblObsAnimeSlc.Location = new Point(15, 139);
            lblObsAnimeSlc.Name = "lblObsAnimeSlc";
            lblObsAnimeSlc.Size = new Size(207, 132);
            lblObsAnimeSlc.TabIndex = 5;
            lblObsAnimeSlc.Text = "DESCRIÇÂO LOUCO DO ANIME QUE PEDIRAM AQUI";
            lblObsAnimeSlc.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 105);
            label4.Name = "label4";
            label4.Size = new Size(207, 21);
            label4.TabIndex = 6;
            label4.Text = "Observação";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtStatusSlc
            // 
            txtStatusSlc.Enabled = false;
            txtStatusSlc.Location = new Point(15, 280);
            txtStatusSlc.Name = "txtStatusSlc";
            txtStatusSlc.Size = new Size(206, 23);
            txtStatusSlc.TabIndex = 7;
            txtStatusSlc.TextAlign = HorizontalAlignment.Center;
            // 
            // AnimeSolicitacaoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtStatusSlc);
            Controls.Add(label4);
            Controls.Add(lblObsAnimeSlc);
            Controls.Add(lblNomeAnimeSlc);
            Controls.Add(label1);
            Name = "AnimeSolicitacaoCard";
            Size = new Size(237, 313);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNomeAnimeSlc;
        private Label lblObsAnimeSlc;
        private Label label4;
        private TextBox txtStatusSlc;
    }
}
