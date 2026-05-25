namespace AnimesHub.Forms
{
    partial class HomeControl
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
            pnlLancamentos = new Panel();
            flpLancamentos = new FlowLayoutPanel();
            label1 = new Label();
            pnlAcompanhando = new Panel();
            flpAcompanhando = new FlowLayoutPanel();
            label2 = new Label();
            pnlLancamentos.SuspendLayout();
            pnlAcompanhando.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLancamentos
            // 
            pnlLancamentos.BackColor = Color.Transparent;
            pnlLancamentos.Controls.Add(flpLancamentos);
            pnlLancamentos.Controls.Add(label1);
            pnlLancamentos.Dock = DockStyle.Top;
            pnlLancamentos.Location = new Point(0, 0);
            pnlLancamentos.Name = "pnlLancamentos";
            pnlLancamentos.Size = new Size(707, 350);
            pnlLancamentos.TabIndex = 0;
            // 
            // flpLancamentos
            // 
            flpLancamentos.AutoScroll = true;
            flpLancamentos.Dock = DockStyle.Fill;
            flpLancamentos.Location = new Point(0, 27);
            flpLancamentos.Name = "flpLancamentos";
            flpLancamentos.Size = new Size(707, 323);
            flpLancamentos.TabIndex = 1;
            flpLancamentos.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Lançamentos";
            // 
            // pnlAcompanhando
            // 
            pnlAcompanhando.BackColor = Color.Transparent;
            pnlAcompanhando.Controls.Add(flpAcompanhando);
            pnlAcompanhando.Controls.Add(label2);
            pnlAcompanhando.Dock = DockStyle.Top;
            pnlAcompanhando.Location = new Point(0, 350);
            pnlAcompanhando.Name = "pnlAcompanhando";
            pnlAcompanhando.Size = new Size(707, 350);
            pnlAcompanhando.TabIndex = 2;
            // 
            // flpAcompanhando
            // 
            flpAcompanhando.AutoScroll = true;
            flpAcompanhando.Dock = DockStyle.Fill;
            flpAcompanhando.Location = new Point(0, 27);
            flpAcompanhando.Name = "flpAcompanhando";
            flpAcompanhando.Size = new Size(707, 323);
            flpAcompanhando.TabIndex = 1;
            flpAcompanhando.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 27);
            label2.TabIndex = 0;
            label2.Text = "Acompanhando";
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnlAcompanhando);
            Controls.Add(pnlLancamentos);
            Name = "HomeControl";
            Size = new Size(707, 933);
            Load += HomeControl_Load;
            pnlLancamentos.ResumeLayout(false);
            pnlLancamentos.PerformLayout();
            pnlAcompanhando.ResumeLayout(false);
            pnlAcompanhando.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLancamentos;
        private Label label1;
        private FlowLayoutPanel flpLancamentos;
        private Panel pnlAcompanhando;
        private FlowLayoutPanel flpAcompanhando;
        private Label label2;
    }
}
