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
            panel1 = new Panel();
            flpLancamentos = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(flpLancamentos);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 350);
            panel1.TabIndex = 0;
            // 
            // flpLancamentos
            // 
            flpLancamentos.AutoScroll = true;
            flpLancamentos.Dock = DockStyle.Fill;
            flpLancamentos.Location = new Point(0, 27);
            flpLancamentos.Name = "flpLancamentos";
            flpLancamentos.Size = new Size(732, 323);
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
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Name = "HomeControl";
            Size = new Size(755, 499);
            Load += HomeControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flpLancamentos;
    }
}
