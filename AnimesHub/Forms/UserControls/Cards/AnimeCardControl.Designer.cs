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
            components = new System.ComponentModel.Container();
            picCapaAnimCard = new PictureBox();
            lblNomeAnimeCard = new Label();
            lblDescAnimeCard = new Label();
            lblAnoAnimeCard = new Label();
            btnMenuStrip = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiAcompanhando = new ToolStripMenuItem();
            tsmiParaAssisitr = new ToolStripMenuItem();
            tsmiAssistindo = new ToolStripMenuItem();
            tsmiAssistido = new ToolStripMenuItem();
            cbFavoritos = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picCapaAnimCard).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // picCapaAnimCard
            // 
            picCapaAnimCard.BackgroundImage = Properties.Resources.CapaAnimeTeste;
            picCapaAnimCard.BackgroundImageLayout = ImageLayout.Stretch;
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
            lblNomeAnimeCard.Location = new Point(10, 213);
            lblNomeAnimeCard.Name = "lblNomeAnimeCard";
            lblNomeAnimeCard.Size = new Size(149, 15);
            lblNomeAnimeCard.TabIndex = 1;
            lblNomeAnimeCard.Text = "Naruto";
            lblNomeAnimeCard.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescAnimeCard
            // 
            lblDescAnimeCard.Location = new Point(10, 230);
            lblDescAnimeCard.Name = "lblDescAnimeCard";
            lblDescAnimeCard.Size = new Size(160, 50);
            lblDescAnimeCard.TabIndex = 2;
            lblDescAnimeCard.Text = "Um Ninja querendo ser Hokage";
            lblDescAnimeCard.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAnoAnimeCard
            // 
            lblAnoAnimeCard.Location = new Point(10, 278);
            lblAnoAnimeCard.Margin = new Padding(10);
            lblAnoAnimeCard.Name = "lblAnoAnimeCard";
            lblAnoAnimeCard.Padding = new Padding(5);
            lblAnoAnimeCard.Size = new Size(138, 22);
            lblAnoAnimeCard.TabIndex = 3;
            lblAnoAnimeCard.Text = "2000";
            lblAnoAnimeCard.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnMenuStrip
            // 
            btnMenuStrip.Location = new Point(152, 278);
            btnMenuStrip.Name = "btnMenuStrip";
            btnMenuStrip.Size = new Size(28, 23);
            btnMenuStrip.TabIndex = 4;
            btnMenuStrip.Text = "+";
            btnMenuStrip.UseVisualStyleBackColor = true;
            btnMenuStrip.Click += btnMenuStrip_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmiAcompanhando, tsmiParaAssisitr, tsmiAssistindo, tsmiAssistido });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 92);
            // 
            // tsmiAcompanhando
            // 
            tsmiAcompanhando.Name = "tsmiAcompanhando";
            tsmiAcompanhando.Size = new Size(160, 22);
            tsmiAcompanhando.Text = "Acompanhando";
            tsmiAcompanhando.Click += tsmiAcompanhando_Click;
            // 
            // tsmiParaAssisitr
            // 
            tsmiParaAssisitr.Name = "tsmiParaAssisitr";
            tsmiParaAssisitr.Size = new Size(160, 22);
            tsmiParaAssisitr.Text = "ParaAssistir";
            tsmiParaAssisitr.Click += tsmiParaAssisitr_Click;
            // 
            // tsmiAssistindo
            // 
            tsmiAssistindo.Name = "tsmiAssistindo";
            tsmiAssistindo.Size = new Size(160, 22);
            tsmiAssistindo.Text = "Assistindo";
            tsmiAssistindo.Click += tsmiAssistindo_Click;
            // 
            // tsmiAssistido
            // 
            tsmiAssistido.Name = "tsmiAssistido";
            tsmiAssistido.Size = new Size(160, 22);
            tsmiAssistido.Text = "Assistido";
            tsmiAssistido.Click += tsmiAssistido_Click;
            // 
            // cbFavoritos
            // 
            cbFavoritos.AutoSize = true;
            cbFavoritos.Location = new Point(165, 213);
            cbFavoritos.Name = "cbFavoritos";
            cbFavoritos.Size = new Size(15, 14);
            cbFavoritos.TabIndex = 5;
            cbFavoritos.UseVisualStyleBackColor = true;
            cbFavoritos.CheckedChanged += cbFavoritos_CheckedChanged;
            // 
            // AnimeCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbFavoritos);
            Controls.Add(btnMenuStrip);
            Controls.Add(lblAnoAnimeCard);
            Controls.Add(lblDescAnimeCard);
            Controls.Add(lblNomeAnimeCard);
            Controls.Add(picCapaAnimCard);
            Name = "AnimeCardControl";
            Size = new Size(180, 300);
            Load += AnimeCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)picCapaAnimCard).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCapaAnimCard;
        private Label lblNomeAnimeCard;
        private Label lblDescAnimeCard;
        private Label lblAnoAnimeCard;
        private Button btnMenuStrip;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiParaAssisitr;
        private ToolStripMenuItem tsmiAssistindo;
        private ToolStripMenuItem tsmiAcompanhando;
        private ToolStripMenuItem tsmiAssistido;
        private CheckBox cbFavoritos;
    }
}
