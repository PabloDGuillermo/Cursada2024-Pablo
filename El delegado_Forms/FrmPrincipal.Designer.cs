namespace El_delegado_Forms
{
    partial class FrmPrincipal
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
            mnuPrincipal = new MenuStrip();
            mnuAlta = new ToolStripMenuItem();
            smnuTestDelegados = new ToolStripMenuItem();
            smnuAlumno = new ToolStripMenuItem();
            mnuMostrar = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuAlta, mnuMostrar });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(562, 24);
            mnuPrincipal.TabIndex = 1;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuAlta
            // 
            mnuAlta.DropDownItems.AddRange(new ToolStripItem[] { smnuTestDelegados, smnuAlumno });
            mnuAlta.Name = "mnuAlta";
            mnuAlta.Size = new Size(40, 20);
            mnuAlta.Text = "Alta";
            // 
            // smnuTestDelegados
            // 
            smnuTestDelegados.Name = "smnuTestDelegados";
            smnuTestDelegados.Size = new Size(180, 22);
            smnuTestDelegados.Text = "Test Delegados";
            smnuTestDelegados.Click += smnuTestDelegados_Click;
            // 
            // smnuAlumno
            // 
            smnuAlumno.Name = "smnuAlumno";
            smnuAlumno.Size = new Size(180, 22);
            smnuAlumno.Text = "Alumno";
            // 
            // mnuMostrar
            // 
            mnuMostrar.Name = "mnuMostrar";
            mnuMostrar.Size = new Size(60, 20);
            mnuMostrar.Text = "Mostrar";
            mnuMostrar.Click += mnuMostrar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 157);
            Controls.Add(mnuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = mnuPrincipal;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem mnuAlta;
        private ToolStripMenuItem smnuTestDelegados;
        private ToolStripMenuItem smnuAlumno;
        private ToolStripMenuItem mnuMostrar;
    }
}