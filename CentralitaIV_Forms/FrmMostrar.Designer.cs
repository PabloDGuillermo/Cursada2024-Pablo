namespace FormCentralita
{
    partial class FrmMostrar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbInfoLlamadas = new RichTextBox();
            SuspendLayout();
            // 
            // rtbInfoLlamadas
            // 
            rtbInfoLlamadas.Location = new Point(12, 12);
            rtbInfoLlamadas.Name = "rtbInfoLlamadas";
            rtbInfoLlamadas.Size = new Size(324, 252);
            rtbInfoLlamadas.TabIndex = 0;
            rtbInfoLlamadas.Text = "";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 276);
            Controls.Add(rtbInfoLlamadas);
            Name = "FrmMostrar";
            Text = "FrmMostrar";
            Load += FrmMostrar_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbInfoLlamadas;
    }
}