namespace AnimesHub.Forms.UserControls
{
    partial class AdicionarAnimes
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
            pictureBox1 = new PictureBox();
            btnCarregarCapaAnime = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCriarAnimesSinopse = new TextBox();
            txtCriarAnimesNome = new TextBox();
            txtCriarAnimesEpisodios = new TextBox();
            txtCriarAnimesTemporadas = new TextBox();
            txtCriarAnimesGenero = new TextBox();
            txtCriarAnimesStudio = new TextBox();
            btnCriarAnime = new Button();
            btnLimparCamposCriarAnime = new Button();
            dtCriarAnimesDateLancamento = new DateTimePicker();
            pnlCadastrarAnime = new Panel();
            label8 = new Label();
            txtIdBuscarAnimeAdd = new TextBox();
            btnExcluirAnimeAdd = new Button();
            btnLimparLista = new Button();
            btnListarAnimes = new Button();
            pnlListarAnime = new Panel();
            dgvListarAnimes = new DataGridView();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCadastrarAnime.SuspendLayout();
            pnlListarAnime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarAnimes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.CapaAnimeTeste;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(18, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCarregarCapaAnime
            // 
            btnCarregarCapaAnime.Location = new Point(153, 397);
            btnCarregarCapaAnime.Name = "btnCarregarCapaAnime";
            btnCarregarCapaAnime.Size = new Size(115, 27);
            btnCarregarCapaAnime.TabIndex = 1;
            btnCarregarCapaAnime.Text = "Carregar Capa";
            btnCarregarCapaAnime.UseVisualStyleBackColor = true;
            btnCarregarCapaAnime.Click += btnCarregarCapaAnime_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label1.Location = new Point(283, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label2.Location = new Point(283, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 3;
            label2.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label3.Location = new Point(283, 126);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = "Temporadas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label4.Location = new Point(283, 165);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 5;
            label4.Text = "Episodios:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label5.Location = new Point(283, 202);
            label5.Name = "label5";
            label5.Size = new Size(168, 21);
            label5.TabIndex = 6;
            label5.Text = "Data de Lançamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label6.Location = new Point(283, 238);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 7;
            label6.Text = "Sinopse:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label7.Location = new Point(283, 52);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 8;
            label7.Text = "Studio:";
            // 
            // txtCriarAnimesSinopse
            // 
            txtCriarAnimesSinopse.Location = new Point(457, 238);
            txtCriarAnimesSinopse.Multiline = true;
            txtCriarAnimesSinopse.Name = "txtCriarAnimesSinopse";
            txtCriarAnimesSinopse.ScrollBars = ScrollBars.Vertical;
            txtCriarAnimesSinopse.Size = new Size(344, 100);
            txtCriarAnimesSinopse.TabIndex = 9;
            // 
            // txtCriarAnimesNome
            // 
            txtCriarAnimesNome.Location = new Point(457, 16);
            txtCriarAnimesNome.Name = "txtCriarAnimesNome";
            txtCriarAnimesNome.Size = new Size(344, 23);
            txtCriarAnimesNome.TabIndex = 10;
            // 
            // txtCriarAnimesEpisodios
            // 
            txtCriarAnimesEpisodios.Location = new Point(457, 163);
            txtCriarAnimesEpisodios.Name = "txtCriarAnimesEpisodios";
            txtCriarAnimesEpisodios.Size = new Size(344, 23);
            txtCriarAnimesEpisodios.TabIndex = 12;
            // 
            // txtCriarAnimesTemporadas
            // 
            txtCriarAnimesTemporadas.Location = new Point(457, 124);
            txtCriarAnimesTemporadas.Name = "txtCriarAnimesTemporadas";
            txtCriarAnimesTemporadas.Size = new Size(344, 23);
            txtCriarAnimesTemporadas.TabIndex = 13;
            // 
            // txtCriarAnimesGenero
            // 
            txtCriarAnimesGenero.Location = new Point(457, 86);
            txtCriarAnimesGenero.Name = "txtCriarAnimesGenero";
            txtCriarAnimesGenero.Size = new Size(344, 23);
            txtCriarAnimesGenero.TabIndex = 14;
            // 
            // txtCriarAnimesStudio
            // 
            txtCriarAnimesStudio.Location = new Point(457, 50);
            txtCriarAnimesStudio.Name = "txtCriarAnimesStudio";
            txtCriarAnimesStudio.Size = new Size(344, 23);
            txtCriarAnimesStudio.TabIndex = 15;
            // 
            // btnCriarAnime
            // 
            btnCriarAnime.Location = new Point(645, 344);
            btnCriarAnime.Name = "btnCriarAnime";
            btnCriarAnime.Size = new Size(75, 23);
            btnCriarAnime.TabIndex = 16;
            btnCriarAnime.Text = "Salvar";
            btnCriarAnime.UseVisualStyleBackColor = true;
            btnCriarAnime.Click += btnCriarAnime_Click;
            // 
            // btnLimparCamposCriarAnime
            // 
            btnLimparCamposCriarAnime.Location = new Point(726, 344);
            btnLimparCamposCriarAnime.Name = "btnLimparCamposCriarAnime";
            btnLimparCamposCriarAnime.Size = new Size(75, 23);
            btnLimparCamposCriarAnime.TabIndex = 18;
            btnLimparCamposCriarAnime.Text = "Limpar";
            btnLimparCamposCriarAnime.UseVisualStyleBackColor = true;
            btnLimparCamposCriarAnime.Click += btnLimparCamposCriarAnime_Click;
            // 
            // dtCriarAnimesDateLancamento
            // 
            dtCriarAnimesDateLancamento.Format = DateTimePickerFormat.Short;
            dtCriarAnimesDateLancamento.Location = new Point(457, 201);
            dtCriarAnimesDateLancamento.Name = "dtCriarAnimesDateLancamento";
            dtCriarAnimesDateLancamento.Size = new Size(98, 23);
            dtCriarAnimesDateLancamento.TabIndex = 19;
            // 
            // pnlCadastrarAnime
            // 
            pnlCadastrarAnime.Controls.Add(btnEditar);
            pnlCadastrarAnime.Controls.Add(label8);
            pnlCadastrarAnime.Controls.Add(txtIdBuscarAnimeAdd);
            pnlCadastrarAnime.Controls.Add(btnExcluirAnimeAdd);
            pnlCadastrarAnime.Controls.Add(btnLimparLista);
            pnlCadastrarAnime.Controls.Add(btnListarAnimes);
            pnlCadastrarAnime.Controls.Add(dtCriarAnimesDateLancamento);
            pnlCadastrarAnime.Controls.Add(btnLimparCamposCriarAnime);
            pnlCadastrarAnime.Controls.Add(btnCriarAnime);
            pnlCadastrarAnime.Controls.Add(txtCriarAnimesStudio);
            pnlCadastrarAnime.Controls.Add(txtCriarAnimesGenero);
            pnlCadastrarAnime.Controls.Add(txtCriarAnimesTemporadas);
            pnlCadastrarAnime.Controls.Add(txtCriarAnimesEpisodios);
            pnlCadastrarAnime.Controls.Add(txtCriarAnimesNome);
            pnlCadastrarAnime.Controls.Add(txtCriarAnimesSinopse);
            pnlCadastrarAnime.Controls.Add(label7);
            pnlCadastrarAnime.Controls.Add(label6);
            pnlCadastrarAnime.Controls.Add(label5);
            pnlCadastrarAnime.Controls.Add(label4);
            pnlCadastrarAnime.Controls.Add(label3);
            pnlCadastrarAnime.Controls.Add(label2);
            pnlCadastrarAnime.Controls.Add(label1);
            pnlCadastrarAnime.Controls.Add(btnCarregarCapaAnime);
            pnlCadastrarAnime.Controls.Add(pictureBox1);
            pnlCadastrarAnime.Dock = DockStyle.Left;
            pnlCadastrarAnime.Location = new Point(0, 0);
            pnlCadastrarAnime.Name = "pnlCadastrarAnime";
            pnlCadastrarAnime.Size = new Size(895, 826);
            pnlCadastrarAnime.TabIndex = 20;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label8.Location = new Point(37, 724);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 24;
            label8.Text = "ID:";
            // 
            // txtIdBuscarAnimeAdd
            // 
            txtIdBuscarAnimeAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtIdBuscarAnimeAdd.Location = new Point(37, 748);
            txtIdBuscarAnimeAdd.Name = "txtIdBuscarAnimeAdd";
            txtIdBuscarAnimeAdd.Size = new Size(106, 23);
            txtIdBuscarAnimeAdd.TabIndex = 23;
            // 
            // btnExcluirAnimeAdd
            // 
            btnExcluirAnimeAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluirAnimeAdd.Location = new Point(234, 748);
            btnExcluirAnimeAdd.Name = "btnExcluirAnimeAdd";
            btnExcluirAnimeAdd.Size = new Size(75, 23);
            btnExcluirAnimeAdd.TabIndex = 22;
            btnExcluirAnimeAdd.Text = "Excluir";
            btnExcluirAnimeAdd.UseVisualStyleBackColor = true;
            btnExcluirAnimeAdd.Click += btnExcluirAnimeAdd_Click;
            // 
            // btnLimparLista
            // 
            btnLimparLista.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimparLista.Location = new Point(153, 777);
            btnLimparLista.Name = "btnLimparLista";
            btnLimparLista.Size = new Size(75, 23);
            btnLimparLista.TabIndex = 21;
            btnLimparLista.Text = "Limpar";
            btnLimparLista.UseVisualStyleBackColor = true;
            btnLimparLista.Click += btnLimparLista_Click;
            // 
            // btnListarAnimes
            // 
            btnListarAnimes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListarAnimes.Location = new Point(37, 777);
            btnListarAnimes.Name = "btnListarAnimes";
            btnListarAnimes.Size = new Size(106, 23);
            btnListarAnimes.TabIndex = 20;
            btnListarAnimes.Text = "Listar Animes";
            btnListarAnimes.UseVisualStyleBackColor = true;
            btnListarAnimes.Click += btnListarAnimes_Click;
            // 
            // pnlListarAnime
            // 
            pnlListarAnime.Controls.Add(dgvListarAnimes);
            pnlListarAnime.Dock = DockStyle.Fill;
            pnlListarAnime.Location = new Point(895, 0);
            pnlListarAnime.Name = "pnlListarAnime";
            pnlListarAnime.Size = new Size(428, 826);
            pnlListarAnime.TabIndex = 21;
            // 
            // dgvListarAnimes
            // 
            dgvListarAnimes.BackgroundColor = SystemColors.Control;
            dgvListarAnimes.BorderStyle = BorderStyle.None;
            dgvListarAnimes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarAnimes.Dock = DockStyle.Fill;
            dgvListarAnimes.Location = new Point(0, 0);
            dgvListarAnimes.Name = "dgvListarAnimes";
            dgvListarAnimes.Size = new Size(428, 826);
            dgvListarAnimes.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(153, 748);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // AdicionarAnimes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlListarAnime);
            Controls.Add(pnlCadastrarAnime);
            Name = "AdicionarAnimes";
            Size = new Size(1323, 826);
            Load += AdicionarAnimes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCadastrarAnime.ResumeLayout(false);
            pnlCadastrarAnime.PerformLayout();
            pnlListarAnime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarAnimes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCarregarCapaAnime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCriarAnimesSinopse;
        private TextBox txtCriarAnimesNome;
        private TextBox s;
        private TextBox txtCriarAnimesEpisodios;
        private TextBox txtCriarAnimesTemporadas;
        private TextBox txtCriarAnimesGenero;
        private TextBox txtCriarAnimesStudio;
        private Button btnCriarAnime;
        private Button btnLimparCamposCriarAnime;
        private DateTimePicker dtCriarAnimesDateLancamento;
        private Panel pnlCadastrarAnime;
        private Panel pnlListarAnime;
        private DataGridView dgvListarAnimes;
        private Button btnListarAnimes;
        private Button btnLimparLista;
        private TextBox txtIdBuscarAnimeAdd;
        private Button btnExcluirAnimeAdd;
        private Label label8;
        private Button btnEditar;
    }
}
