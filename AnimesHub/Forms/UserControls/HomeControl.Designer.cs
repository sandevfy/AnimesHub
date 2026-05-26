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
            pnlAcompanhando = new Panel();
            flpAcompanhando = new FlowLayoutPanel();
            label2 = new Label();
            pnlAcompanhando.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAcompanhando
            // 
            pnlAcompanhando.BackColor = Color.Transparent;
            pnlAcompanhando.Controls.Add(flpAcompanhando);
            pnlAcompanhando.Controls.Add(label2);
            pnlAcompanhando.Dock = DockStyle.Top;
            pnlAcompanhando.Location = new Point(0, 0);
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
            Name = "HomeControl";
            Size = new Size(707, 933);
            Load += HomeControl_Load;
            pnlAcompanhando.ResumeLayout(false);
            pnlAcompanhando.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlAcompanhando;
        private FlowLayoutPanel flpAcompanhando;
        private Label label2;
    }
}
