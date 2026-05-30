namespace AnimesHub.Forms.UserControls.HomeUserControls
{
    partial class HomePrincipal
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
            pnlLançamento = new Panel();
            flpLancamentosHome = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            pnlAcompanhando = new Panel();
            flpAcompanhandoHome = new FlowLayoutPanel();
            panel3 = new Panel();
            label2 = new Label();
            pnlLançamento.SuspendLayout();
            panel2.SuspendLayout();
            pnlAcompanhando.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLançamento
            // 
            pnlLançamento.Controls.Add(flpLancamentosHome);
            pnlLançamento.Controls.Add(panel2);
            pnlLançamento.Dock = DockStyle.Top;
            pnlLançamento.Location = new Point(0, 0);
            pnlLançamento.Name = "pnlLançamento";
            pnlLançamento.Size = new Size(1008, 380);
            pnlLançamento.TabIndex = 1;
            // 
            // flpLancamentosHome
            // 
            flpLancamentosHome.Dock = DockStyle.Fill;
            flpLancamentosHome.Location = new Point(0, 54);
            flpLancamentosHome.Name = "flpLancamentosHome";
            flpLancamentosHome.Size = new Size(1008, 326);
            flpLancamentosHome.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 54);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Knight Souls Personal Use", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(235, 33);
            label1.TabIndex = 0;
            label1.Text = "Lançamento";
            // 
            // pnlAcompanhando
            // 
            pnlAcompanhando.Controls.Add(flpAcompanhandoHome);
            pnlAcompanhando.Controls.Add(panel3);
            pnlAcompanhando.Dock = DockStyle.Top;
            pnlAcompanhando.Location = new Point(0, 380);
            pnlAcompanhando.Name = "pnlAcompanhando";
            pnlAcompanhando.Size = new Size(1008, 380);
            pnlAcompanhando.TabIndex = 2;
            // 
            // flpAcompanhandoHome
            // 
            flpAcompanhandoHome.Dock = DockStyle.Fill;
            flpAcompanhandoHome.Location = new Point(0, 54);
            flpAcompanhandoHome.Name = "flpAcompanhandoHome";
            flpAcompanhandoHome.Size = new Size(1008, 326);
            flpAcompanhandoHome.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 54);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Knight Souls Personal Use", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(16, 17);
            label2.Name = "label2";
            label2.Size = new Size(284, 33);
            label2.TabIndex = 0;
            label2.Text = "Acompanhando";
            // 
            // HomePrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAcompanhando);
            Controls.Add(pnlLançamento);
            Name = "HomePrincipal";
            Size = new Size(1008, 957);
            Load += HomePrincipal_Load;
            pnlLançamento.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlAcompanhando.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLançamento;
        private FlowLayoutPanel flpLancamentosHome;
        private Panel panel2;
        private Label label1;
        private Panel pnlAcompanhando;
        private FlowLayoutPanel flpAcompanhandoHome;
        private Panel panel3;
        private Label label2;
    }
}
