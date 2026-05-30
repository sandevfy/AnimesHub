namespace AnimesHub.Forms
{
    partial class SolicitarAnime
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
            panel1 = new Panel();
            pnlControleAprovacao = new Panel();
            btnPendenteSlc = new Button();
            btnLimparBuscaSlc = new Button();
            lblStatusUserSlc = new Label();
            lblDtsUserSlc = new Label();
            txtIdBuscarSlc = new TextBox();
            label7 = new Label();
            btnBuscarSlc = new Button();
            lblNameUserSlc = new Label();
            btnRecusadoSlc = new Button();
            btnAprovadoSlc = new Button();
            label5 = new Label();
            btnEnviar = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtObsAnimeSlc = new TextBox();
            txtNameAnimeSlc = new TextBox();
            panel2 = new Panel();
            flpAnimesSolicitados = new FlowLayoutPanel();
            panel4 = new Panel();
            btnBuscarNameAnimeSlc = new Button();
            txtBuscarNameAnimeSlc = new TextBox();
            btnBuscarPendentes = new Button();
            btnBuscarRecusados = new Button();
            btnBuscarAprovados = new Button();
            panel1.SuspendLayout();
            pnlControleAprovacao.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlControleAprovacao);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtObsAnimeSlc);
            panel1.Controls.Add(txtNameAnimeSlc);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 196);
            panel1.TabIndex = 0;
            // 
            // pnlControleAprovacao
            // 
            pnlControleAprovacao.Controls.Add(btnPendenteSlc);
            pnlControleAprovacao.Controls.Add(btnLimparBuscaSlc);
            pnlControleAprovacao.Controls.Add(lblStatusUserSlc);
            pnlControleAprovacao.Controls.Add(lblDtsUserSlc);
            pnlControleAprovacao.Controls.Add(txtIdBuscarSlc);
            pnlControleAprovacao.Controls.Add(label7);
            pnlControleAprovacao.Controls.Add(btnBuscarSlc);
            pnlControleAprovacao.Controls.Add(lblNameUserSlc);
            pnlControleAprovacao.Controls.Add(btnRecusadoSlc);
            pnlControleAprovacao.Controls.Add(btnAprovadoSlc);
            pnlControleAprovacao.Controls.Add(label5);
            pnlControleAprovacao.Dock = DockStyle.Right;
            pnlControleAprovacao.Location = new Point(717, 0);
            pnlControleAprovacao.Name = "pnlControleAprovacao";
            pnlControleAprovacao.Size = new Size(539, 196);
            pnlControleAprovacao.TabIndex = 7;
            // 
            // btnPendenteSlc
            // 
            btnPendenteSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPendenteSlc.Location = new Point(446, 145);
            btnPendenteSlc.Name = "btnPendenteSlc";
            btnPendenteSlc.Size = new Size(75, 23);
            btnPendenteSlc.TabIndex = 16;
            btnPendenteSlc.Text = "Pendente";
            btnPendenteSlc.UseVisualStyleBackColor = true;
            btnPendenteSlc.Click += btnPendenteSlc_Click;
            // 
            // btnLimparBuscaSlc
            // 
            btnLimparBuscaSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimparBuscaSlc.Location = new Point(220, 145);
            btnLimparBuscaSlc.Name = "btnLimparBuscaSlc";
            btnLimparBuscaSlc.Size = new Size(75, 23);
            btnLimparBuscaSlc.TabIndex = 15;
            btnLimparBuscaSlc.Text = "Limpar";
            btnLimparBuscaSlc.UseVisualStyleBackColor = true;
            btnLimparBuscaSlc.Click += btnLimparBuscaSlc_Click;
            // 
            // lblStatusUserSlc
            // 
            lblStatusUserSlc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatusUserSlc.AutoSize = true;
            lblStatusUserSlc.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            lblStatusUserSlc.Location = new Point(14, 106);
            lblStatusUserSlc.Name = "lblStatusUserSlc";
            lblStatusUserSlc.Size = new Size(57, 21);
            lblStatusUserSlc.TabIndex = 14;
            lblStatusUserSlc.Text = "Status";
            // 
            // lblDtsUserSlc
            // 
            lblDtsUserSlc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDtsUserSlc.AutoSize = true;
            lblDtsUserSlc.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            lblDtsUserSlc.Location = new Point(14, 85);
            lblDtsUserSlc.Name = "lblDtsUserSlc";
            lblDtsUserSlc.Size = new Size(45, 21);
            lblDtsUserSlc.TabIndex = 13;
            lblDtsUserSlc.Text = "Data";
            // 
            // txtIdBuscarSlc
            // 
            txtIdBuscarSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtIdBuscarSlc.Location = new Point(42, 146);
            txtIdBuscarSlc.Name = "txtIdBuscarSlc";
            txtIdBuscarSlc.Size = new Size(91, 23);
            txtIdBuscarSlc.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label7.Location = new Point(14, 148);
            label7.Name = "label7";
            label7.Size = new Size(31, 21);
            label7.TabIndex = 12;
            label7.Text = "ID:";
            // 
            // btnBuscarSlc
            // 
            btnBuscarSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscarSlc.Location = new Point(139, 146);
            btnBuscarSlc.Name = "btnBuscarSlc";
            btnBuscarSlc.Size = new Size(75, 23);
            btnBuscarSlc.TabIndex = 11;
            btnBuscarSlc.Text = "Buscar";
            btnBuscarSlc.UseVisualStyleBackColor = true;
            btnBuscarSlc.Click += btnBuscarSlc_Click;
            // 
            // lblNameUserSlc
            // 
            lblNameUserSlc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNameUserSlc.AutoSize = true;
            lblNameUserSlc.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            lblNameUserSlc.Location = new Point(14, 64);
            lblNameUserSlc.Name = "lblNameUserSlc";
            lblNameUserSlc.Size = new Size(53, 21);
            lblNameUserSlc.TabIndex = 8;
            lblNameUserSlc.Text = "Name";
            // 
            // btnRecusadoSlc
            // 
            btnRecusadoSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecusadoSlc.Location = new Point(446, 116);
            btnRecusadoSlc.Name = "btnRecusadoSlc";
            btnRecusadoSlc.Size = new Size(75, 23);
            btnRecusadoSlc.TabIndex = 10;
            btnRecusadoSlc.Text = "Recusado";
            btnRecusadoSlc.UseVisualStyleBackColor = true;
            btnRecusadoSlc.Click += btnRecusadoSlc_Click;
            // 
            // btnAprovadoSlc
            // 
            btnAprovadoSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAprovadoSlc.Location = new Point(446, 87);
            btnAprovadoSlc.Name = "btnAprovadoSlc";
            btnAprovadoSlc.Size = new Size(75, 23);
            btnAprovadoSlc.TabIndex = 9;
            btnAprovadoSlc.Text = "Aprovado";
            btnAprovadoSlc.UseVisualStyleBackColor = true;
            btnAprovadoSlc.Click += btnAprovadoSlc_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Knight Souls Personal Use", 18F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(14, 17);
            label5.Name = "label5";
            label5.Size = new Size(214, 33);
            label5.TabIndex = 8;
            label5.Text = "Aprovação";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(589, 146);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label1.Location = new Point(72, 98);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 5;
            label1.Text = "Observação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans JP", 11.25F, FontStyle.Bold);
            label4.Location = new Point(72, 64);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 4;
            label4.Text = "Nome:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Knight Souls Personal Use", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(36, 17);
            label3.Name = "label3";
            label3.Size = new Size(214, 33);
            label3.TabIndex = 2;
            label3.Text = "Solicitação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 85);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // txtObsAnimeSlc
            // 
            txtObsAnimeSlc.Location = new Point(185, 96);
            txtObsAnimeSlc.Multiline = true;
            txtObsAnimeSlc.Name = "txtObsAnimeSlc";
            txtObsAnimeSlc.PlaceholderText = "Deixe uma observação";
            txtObsAnimeSlc.Size = new Size(388, 73);
            txtObsAnimeSlc.TabIndex = 2;
            // 
            // txtNameAnimeSlc
            // 
            txtNameAnimeSlc.Location = new Point(185, 66);
            txtNameAnimeSlc.Name = "txtNameAnimeSlc";
            txtNameAnimeSlc.PlaceholderText = "Nome do anime";
            txtNameAnimeSlc.Size = new Size(388, 23);
            txtNameAnimeSlc.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(flpAnimesSolicitados);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 613);
            panel2.TabIndex = 1;
            // 
            // flpAnimesSolicitados
            // 
            flpAnimesSolicitados.Dock = DockStyle.Fill;
            flpAnimesSolicitados.Location = new Point(0, 0);
            flpAnimesSolicitados.Name = "flpAnimesSolicitados";
            flpAnimesSolicitados.Size = new Size(1256, 613);
            flpAnimesSolicitados.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBuscarNameAnimeSlc);
            panel4.Controls.Add(txtBuscarNameAnimeSlc);
            panel4.Controls.Add(btnBuscarPendentes);
            panel4.Controls.Add(btnBuscarRecusados);
            panel4.Controls.Add(btnBuscarAprovados);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(1256, 38);
            panel4.TabIndex = 0;
            // 
            // btnBuscarNameAnimeSlc
            // 
            btnBuscarNameAnimeSlc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscarNameAnimeSlc.Location = new Point(369, 7);
            btnBuscarNameAnimeSlc.Name = "btnBuscarNameAnimeSlc";
            btnBuscarNameAnimeSlc.Size = new Size(75, 23);
            btnBuscarNameAnimeSlc.TabIndex = 17;
            btnBuscarNameAnimeSlc.Text = "Buscar";
            btnBuscarNameAnimeSlc.UseVisualStyleBackColor = true;
            btnBuscarNameAnimeSlc.Click += btnBuscarNameAnimeSlc_Click;
            // 
            // txtBuscarNameAnimeSlc
            // 
            txtBuscarNameAnimeSlc.Location = new Point(18, 8);
            txtBuscarNameAnimeSlc.Name = "txtBuscarNameAnimeSlc";
            txtBuscarNameAnimeSlc.Size = new Size(345, 23);
            txtBuscarNameAnimeSlc.TabIndex = 18;
            // 
            // btnBuscarPendentes
            // 
            btnBuscarPendentes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarPendentes.Location = new Point(1162, 6);
            btnBuscarPendentes.Name = "btnBuscarPendentes";
            btnBuscarPendentes.Size = new Size(75, 23);
            btnBuscarPendentes.TabIndex = 17;
            btnBuscarPendentes.Text = "Pendente";
            btnBuscarPendentes.UseVisualStyleBackColor = true;
            btnBuscarPendentes.Click += btnBuscarPendentes_Click;
            // 
            // btnBuscarRecusados
            // 
            btnBuscarRecusados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarRecusados.Location = new Point(1078, 6);
            btnBuscarRecusados.Name = "btnBuscarRecusados";
            btnBuscarRecusados.Size = new Size(75, 23);
            btnBuscarRecusados.TabIndex = 17;
            btnBuscarRecusados.Text = "Recusado";
            btnBuscarRecusados.UseVisualStyleBackColor = true;
            btnBuscarRecusados.Click += btnBuscarRecusados_Click;
            // 
            // btnBuscarAprovados
            // 
            btnBuscarAprovados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarAprovados.Location = new Point(997, 6);
            btnBuscarAprovados.Name = "btnBuscarAprovados";
            btnBuscarAprovados.Size = new Size(75, 23);
            btnBuscarAprovados.TabIndex = 17;
            btnBuscarAprovados.Text = "Aprovado";
            btnBuscarAprovados.UseVisualStyleBackColor = true;
            btnBuscarAprovados.Click += btnBuscarAprovados_Click;
            // 
            // SolicitarAnime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "SolicitarAnime";
            Size = new Size(1256, 847);
            Load += SolicitarAnime_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlControleAprovacao.ResumeLayout(false);
            pnlControleAprovacao.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flpAnimesSolicitados;
        private Label label2;
        private TextBox txtObsAnimeSlc;
        private TextBox txtNameAnimeSlc;
        private Label label3;
        private Label label1;
        private Label label4;
        private Panel pnlControleAprovacao;
        private Button btnEnviar;
        private Button btnAprovadoSlc;
        private Label label5;
        private Button btnRecusadoSlc;
        private TextBox txtIdBuscarSlc;
        private Label label7;
        private Button btnBuscarSlc;
        private Label lblNameUserSlc;
        private Label lblStatusUserSlc;
        private Label lblDtsUserSlc;
        private Button btnLimparBuscaSlc;
        private Button btnPendenteSlc;
        private Panel panel4;
        private Button btnBuscarNameAnimeSlc;
        private TextBox txtBuscarNameAnimeSlc;
        private Button btnBuscarPendentes;
        private Button btnBuscarRecusados;
        private Button btnBuscarAprovados;
    }
}
