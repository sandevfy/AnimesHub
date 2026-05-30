namespace AnimesHub.Forms.UserControls.HomeUserControls.UcHomePrincipal
{
    partial class PesquisarAnimes
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
            btnBuscarAnime = new Button();
            txtNameAnimeBuscar = new TextBox();
            panel2 = new Panel();
            flpBuscarAnimes = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscarAnime);
            panel1.Controls.Add(txtNameAnimeBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 73);
            panel1.TabIndex = 0;
            // 
            // btnBuscarAnime
            // 
            btnBuscarAnime.Anchor = AnchorStyles.Top;
            btnBuscarAnime.Location = new Point(772, 25);
            btnBuscarAnime.Name = "btnBuscarAnime";
            btnBuscarAnime.Size = new Size(71, 33);
            btnBuscarAnime.TabIndex = 1;
            btnBuscarAnime.Text = "Buscar";
            btnBuscarAnime.UseVisualStyleBackColor = true;
            btnBuscarAnime.Click += btnBuscarAnime_Click;
            // 
            // txtNameAnimeBuscar
            // 
            txtNameAnimeBuscar.Anchor = AnchorStyles.Top;
            txtNameAnimeBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameAnimeBuscar.Location = new Point(340, 25);
            txtNameAnimeBuscar.Name = "txtNameAnimeBuscar";
            txtNameAnimeBuscar.PlaceholderText = "Pesquise pelo nome do anime";
            txtNameAnimeBuscar.Size = new Size(426, 33);
            txtNameAnimeBuscar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(flpBuscarAnimes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(1318, 696);
            panel2.TabIndex = 1;
            // 
            // flpBuscarAnimes
            // 
            flpBuscarAnimes.Dock = DockStyle.Fill;
            flpBuscarAnimes.Location = new Point(0, 0);
            flpBuscarAnimes.Name = "flpBuscarAnimes";
            flpBuscarAnimes.Size = new Size(1318, 696);
            flpBuscarAnimes.TabIndex = 0;
            // 
            // PesquisarAnimes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PesquisarAnimes";
            Size = new Size(1318, 769);
            Load += PesquisarAnimes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBuscarAnime;
        private TextBox txtNameAnimeBuscar;
        private Panel panel2;
        private FlowLayoutPanel flpBuscarAnimes;
    }
}
