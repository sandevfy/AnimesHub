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
            pnlAcompanhandoHome = new Panel();
            flpAcompanhandoHome = new FlowLayoutPanel();
            label2 = new Label();
            pnlAcompanhandoHome.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAcompanhandoHome
            // 
            pnlAcompanhandoHome.BackColor = Color.Transparent;
            pnlAcompanhandoHome.Controls.Add(flpAcompanhandoHome);
            pnlAcompanhandoHome.Controls.Add(label2);
            pnlAcompanhandoHome.Dock = DockStyle.Top;
            pnlAcompanhandoHome.Location = new Point(0, 0);
            pnlAcompanhandoHome.Name = "pnlAcompanhandoHome";
            pnlAcompanhandoHome.Size = new Size(707, 350);
            pnlAcompanhandoHome.TabIndex = 2;
            // 
            // flpAcompanhandoHome
            // 
            flpAcompanhandoHome.AutoScroll = true;
            flpAcompanhandoHome.Dock = DockStyle.Fill;
            flpAcompanhandoHome.Location = new Point(0, 27);
            flpAcompanhandoHome.Name = "flpAcompanhandoHome";
            flpAcompanhandoHome.Size = new Size(707, 323);
            flpAcompanhandoHome.TabIndex = 1;
            flpAcompanhandoHome.WrapContents = false;
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
            Controls.Add(pnlAcompanhandoHome);
            Name = "HomeControl";
            Size = new Size(707, 933);
            Load += HomeControl_Load;
            pnlAcompanhandoHome.ResumeLayout(false);
            pnlAcompanhandoHome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlAcompanhandoHome;
        private FlowLayoutPanel flpAcompanhandoHome;
        private Label label2;
    }
}
