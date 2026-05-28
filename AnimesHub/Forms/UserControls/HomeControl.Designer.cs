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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnCategoriaStrip = new Button();
            button2 = new Button();
            btnNovidadesHome = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            explorarTudoDeAZToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            generosToolStripMenuItem = new ToolStripMenuItem();
            generosToolStripMenuItem1 = new ToolStripMenuItem();
            açãoToolStripMenuItem = new ToolStripMenuItem();
            aventuraToolStripMenuItem = new ToolStripMenuItem();
            comédiaToolStripMenuItem = new ToolStripMenuItem();
            fantasiaToolStripMenuItem = new ToolStripMenuItem();
            dramaToolStripMenuItem1 = new ToolStripMenuItem();
            dramaToolStripMenuItem = new ToolStripMenuItem();
            pnlConteudo = new Panel();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCategoriaStrip);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnNovidadesHome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 59);
            panel1.TabIndex = 0;
            // 
            // btnCategoriaStrip
            // 
            btnCategoriaStrip.Location = new Point(533, 7);
            btnCategoriaStrip.Name = "btnCategoriaStrip";
            btnCategoriaStrip.Size = new Size(135, 44);
            btnCategoriaStrip.TabIndex = 3;
            btnCategoriaStrip.Text = "Categorias";
            btnCategoriaStrip.UseVisualStyleBackColor = true;
            btnCategoriaStrip.Click += btnCategoriaStrip_Click;
            // 
            // button2
            // 
            button2.Location = new Point(382, 7);
            button2.Name = "button2";
            button2.Size = new Size(135, 44);
            button2.TabIndex = 2;
            button2.Text = "Populares";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnNovidadesHome
            // 
            btnNovidadesHome.Location = new Point(231, 7);
            btnNovidadesHome.Name = "btnNovidadesHome";
            btnNovidadesHome.Size = new Size(135, 44);
            btnNovidadesHome.TabIndex = 1;
            btnNovidadesHome.Text = "Novidades";
            btnNovidadesHome.UseVisualStyleBackColor = true;
            btnNovidadesHome.Click += btnNovidadesHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP Black", 22F, FontStyle.Bold);
            label1.Location = new Point(19, 7);
            label1.Name = "label1";
            label1.Size = new Size(206, 44);
            label1.TabIndex = 0;
            label1.Text = "Animes HUB";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { explorarTudoDeAZToolStripMenuItem, toolStripSeparator1, generosToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(184, 54);
            // 
            // explorarTudoDeAZToolStripMenuItem
            // 
            explorarTudoDeAZToolStripMenuItem.Name = "explorarTudoDeAZToolStripMenuItem";
            explorarTudoDeAZToolStripMenuItem.Size = new Size(183, 22);
            explorarTudoDeAZToolStripMenuItem.Text = "Explorar tudo de A-Z";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(180, 6);
            // 
            // generosToolStripMenuItem
            // 
            generosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generosToolStripMenuItem1, açãoToolStripMenuItem, aventuraToolStripMenuItem, comédiaToolStripMenuItem, fantasiaToolStripMenuItem, dramaToolStripMenuItem1 });
            generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            generosToolStripMenuItem.Size = new Size(183, 22);
            generosToolStripMenuItem.Text = "Generos";
            // 
            // generosToolStripMenuItem1
            // 
            generosToolStripMenuItem1.Enabled = false;
            generosToolStripMenuItem1.Name = "generosToolStripMenuItem1";
            generosToolStripMenuItem1.Size = new Size(122, 22);
            generosToolStripMenuItem1.Text = "Generos";
            // 
            // açãoToolStripMenuItem
            // 
            açãoToolStripMenuItem.Name = "açãoToolStripMenuItem";
            açãoToolStripMenuItem.Size = new Size(122, 22);
            açãoToolStripMenuItem.Text = "Ação";
            // 
            // aventuraToolStripMenuItem
            // 
            aventuraToolStripMenuItem.Name = "aventuraToolStripMenuItem";
            aventuraToolStripMenuItem.Size = new Size(122, 22);
            aventuraToolStripMenuItem.Text = "Aventura";
            // 
            // comédiaToolStripMenuItem
            // 
            comédiaToolStripMenuItem.Name = "comédiaToolStripMenuItem";
            comédiaToolStripMenuItem.Size = new Size(122, 22);
            comédiaToolStripMenuItem.Text = "Comédia";
            // 
            // fantasiaToolStripMenuItem
            // 
            fantasiaToolStripMenuItem.Name = "fantasiaToolStripMenuItem";
            fantasiaToolStripMenuItem.Size = new Size(122, 22);
            fantasiaToolStripMenuItem.Text = "Fantasia";
            // 
            // dramaToolStripMenuItem1
            // 
            dramaToolStripMenuItem1.Name = "dramaToolStripMenuItem1";
            dramaToolStripMenuItem1.Size = new Size(122, 22);
            dramaToolStripMenuItem1.Text = "Drama";
            // 
            // dramaToolStripMenuItem
            // 
            dramaToolStripMenuItem.Name = "dramaToolStripMenuItem";
            dramaToolStripMenuItem.Size = new Size(180, 22);
            dramaToolStripMenuItem.Text = "Drama";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 59);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1227, 446);
            pnlConteudo.TabIndex = 1;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnlConteudo);
            Controls.Add(panel1);
            Name = "HomeControl";
            Size = new Size(1227, 505);
            Load += HomeControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCategoriaStrip;
        private Button button2;
        private Button btnNovidadesHome;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem explorarTudoDeAZToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem generosToolStripMenuItem;
        private ToolStripMenuItem generosToolStripMenuItem1;
        private ToolStripMenuItem açãoToolStripMenuItem;
        private ToolStripMenuItem aventuraToolStripMenuItem;
        private ToolStripMenuItem comédiaToolStripMenuItem;
        private ToolStripMenuItem fantasiaToolStripMenuItem;
        private ToolStripMenuItem dramaToolStripMenuItem1;
        private ToolStripMenuItem dramaToolStripMenuItem;
        private Panel pnlConteudo;
    }
}
