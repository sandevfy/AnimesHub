namespace AnimesHub.Forms.UserControls
{
    partial class Assistidos
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
            label1 = new Label();
            panel2 = new Panel();
            flpAssistidos = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Knight Souls Personal Use", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 1;
            label1.Text = "Assistidos";
            // 
            // panel2
            // 
            panel2.Controls.Add(flpAssistidos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 711);
            panel2.TabIndex = 1;
            // 
            // flpAssistidos
            // 
            flpAssistidos.Dock = DockStyle.Fill;
            flpAssistidos.Location = new Point(0, 0);
            flpAssistidos.Name = "flpAssistidos";
            flpAssistidos.Size = new Size(1184, 711);
            flpAssistidos.TabIndex = 0;
            // 
            // Assistidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Assistidos";
            Size = new Size(1184, 772);
            Load += Assistidos_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flpAssistidos;
    }
}
