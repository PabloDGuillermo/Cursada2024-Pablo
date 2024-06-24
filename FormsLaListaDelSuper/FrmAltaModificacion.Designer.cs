namespace FormsLaListaDelSuper
{
    partial class FrmAltaModificacion
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtObjeto = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(183, 52);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(121, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 52);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtObjeto
            // 
            txtObjeto.Location = new Point(12, 12);
            txtObjeto.MaxLength = 50;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(424, 23);
            txtObjeto.TabIndex = 2;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // FrmAltaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 82);
            ControlBox = false;
            Controls.Add(txtObjeto);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAltaModificacion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Titulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtObjeto;
    }
}
