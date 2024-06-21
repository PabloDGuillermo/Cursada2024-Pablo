namespace _14_I03
{
    partial class frmNotepad
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
            mnuArchivo = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslCaracteres = new ToolStripStatusLabel();
            rtbNotepad = new RichTextBox();
            mnuArchivo.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuArchivo
            // 
            mnuArchivo.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mnuArchivo.Location = new Point(0, 0);
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(519, 24);
            mnuArchivo.TabIndex = 0;
            mnuArchivo.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            abrirToolStripMenuItem.Size = new Size(269, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(269, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            guardarComoToolStripMenuItem.Size = new Size(269, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como...";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslCaracteres });
            statusStrip1.Location = new Point(0, 354);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(519, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslCaracteres
            // 
            tsslCaracteres.Name = "tsslCaracteres";
            tsslCaracteres.Size = new Size(0, 17);
            // 
            // rtbNotepad
            // 
            rtbNotepad.Dock = DockStyle.Fill;
            rtbNotepad.Location = new Point(0, 24);
            rtbNotepad.Name = "rtbNotepad";
            rtbNotepad.Size = new Size(519, 330);
            rtbNotepad.TabIndex = 2;
            rtbNotepad.Text = "";
            rtbNotepad.TextChanged += rtbNotepad_TextChanged;
            // 
            // frmNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 376);
            Controls.Add(rtbNotepad);
            Controls.Add(statusStrip1);
            Controls.Add(mnuArchivo);
            MainMenuStrip = mnuArchivo;
            Name = "frmNotepad";
            Text = "Notepad";
            mnuArchivo.ResumeLayout(false);
            mnuArchivo.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuArchivo;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslCaracteres;
        private RichTextBox rtbNotepad;
    }
}
