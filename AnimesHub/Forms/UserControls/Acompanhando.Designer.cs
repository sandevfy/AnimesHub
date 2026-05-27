namespace AnimesHub.Forms.UserControls
{
    partial class Acompanhando
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
            flpAcompanhando = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpAcompanhando
            // 
            flpAcompanhando.AutoScroll = true;
            flpAcompanhando.Dock = DockStyle.Fill;
            flpAcompanhando.Location = new Point(0, 100);
            flpAcompanhando.Name = "flpAcompanhando";
            flpAcompanhando.Size = new Size(1255, 706);
            flpAcompanhando.TabIndex = 0;
            flpAcompanhando.Paint += flpAcompanhando_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1255, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Noto Sans JP Black", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(452, 29);
            label1.Name = "label1";
            label1.Size = new Size(296, 51);
            label1.TabIndex = 0;
            label1.Text = "Acompanhando";
            // 
            // Acompanhando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpAcompanhando);
            Controls.Add(panel1);
            Name = "Acompanhando";
            Size = new Size(1255, 806);
            Load += Acompanhando_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAcompanhando;
        private Panel panel1;
        private Label label1;
    }
}
