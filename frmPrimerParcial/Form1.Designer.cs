﻿namespace frmPrimerParcial
{
    partial class RPP_Guillermo_Pablo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbAppInstaladas = new RichTextBox();
            rtbAppNoInstaladas = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            rtbAppInstaladas.BackColor = Color.Black;
            rtbAppInstaladas.ForeColor = Color.White;
            rtbAppInstaladas.Location = new Point(12, 12);
            rtbAppInstaladas.Name = "rtbAppInstaladas";
            rtbAppInstaladas.Size = new Size(255, 426);
            rtbAppInstaladas.TabIndex = 0;
            rtbAppInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            rtbAppNoInstaladas.BackColor = Color.Black;
            rtbAppNoInstaladas.ForeColor = Color.White;
            rtbAppNoInstaladas.Location = new Point(340, 12);
            rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            rtbAppNoInstaladas.Size = new Size(255, 426);
            rtbAppNoInstaladas.TabIndex = 1;
            rtbAppNoInstaladas.Text = "";
            // 
            // RPP_Guillermo_Pablo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(607, 450);
            Controls.Add(rtbAppNoInstaladas);
            Controls.Add(rtbAppInstaladas);
            Name = "RPP_Guillermo_Pablo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primer parcial: El dispositivo";
            Load += RPP_Guillermo_Pablo_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbAppInstaladas;
        private RichTextBox rtbAppNoInstaladas;
    }
}
