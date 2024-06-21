namespace _10_I02
{
    partial class Form1
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
            lblKilometros = new Label();
            lblLitros = new Label();
            txbKilometros = new TextBox();
            txbLitros = new TextBox();
            btnCalcular = new Button();
            rtbResultado = new RichTextBox();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(12, 9);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilómetros";
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Location = new Point(12, 53);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(36, 15);
            lblLitros.TabIndex = 1;
            lblLitros.Text = "Litros";
            // 
            // txbKilometros
            // 
            txbKilometros.Location = new Point(12, 27);
            txbKilometros.Name = "txbKilometros";
            txbKilometros.Size = new Size(210, 23);
            txbKilometros.TabIndex = 2;
            // 
            // txbLitros
            // 
            txbLitros.Location = new Point(12, 71);
            txbLitros.Name = "txbLitros";
            txbLitros.Size = new Size(210, 23);
            txbLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 114);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(210, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rtbResultado
            // 
            rtbResultado.Location = new Point(274, 12);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ReadOnly = true;
            rtbResultado.Size = new Size(180, 125);
            rtbResultado.TabIndex = 5;
            rtbResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 158);
            Controls.Add(rtbResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txbLitros);
            Controls.Add(txbKilometros);
            Controls.Add(lblLitros);
            Controls.Add(lblKilometros);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometros;
        private Label lblLitros;
        private TextBox txbKilometros;
        private TextBox txbLitros;
        private Button btnCalcular;
        private RichTextBox rtbResultado;
    }
}