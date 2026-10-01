namespace PruebaEvaluablePerifericosLaraJuanGabriel
{
    partial class Form1
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
            grpTeclado = new GroupBox();
            lblTecladoActivo = new Label();
            lblTipo = new Label();
            lblUltimaTecla = new Label();
            lblCodigoTecla = new Label();
            grpRaton = new GroupBox();
            lblRatonActivo = new Label();
            lblClics = new Label();
            lblUltimoBotonRaton = new Label();
            lblPosicionX = new Label();
            lblPosicionY = new Label();
            lblTitulo = new Label();
            btnReiniciarInterfaz = new Button();
            grpTeclado.SuspendLayout();
            grpRaton.SuspendLayout();
            SuspendLayout();
            // 
            // grpTeclado
            // 
            grpTeclado.Controls.Add(lblTecladoActivo);
            grpTeclado.Controls.Add(lblTipo);
            grpTeclado.Controls.Add(lblUltimaTecla);
            grpTeclado.Controls.Add(lblCodigoTecla);
            grpTeclado.Location = new Point(88, 125);
            grpTeclado.Name = "grpTeclado";
            grpTeclado.Size = new Size(380, 200);
            grpTeclado.TabIndex = 0;
            grpTeclado.TabStop = false;
            grpTeclado.Text = "TECLADO";
            // 
            // lblTecladoActivo
            // 
            lblTecladoActivo.AutoSize = true;
            lblTecladoActivo.Location = new Point(39, 145);
            lblTecladoActivo.Name = "lblTecladoActivo";
            lblTecladoActivo.Size = new Size(97, 15);
            lblTecladoActivo.TabIndex = 6;
            lblTecladoActivo.Text = "Teclado : ACTIVO";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(39, 106);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(74, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo: ninguo";
            // 
            // lblUltimaTecla
            // 
            lblUltimaTecla.AutoSize = true;
            lblUltimaTecla.Location = new Point(39, 49);
            lblUltimaTecla.Name = "lblUltimaTecla";
            lblUltimaTecla.Size = new Size(122, 15);
            lblUltimaTecla.TabIndex = 4;
            lblUltimaTecla.Text = "Última tecla: Ninguna";
            // 
            // lblCodigoTecla
            // 
            lblCodigoTecla.AutoSize = true;
            lblCodigoTecla.Location = new Point(39, 79);
            lblCodigoTecla.Name = "lblCodigoTecla";
            lblCodigoTecla.Size = new Size(58, 15);
            lblCodigoTecla.TabIndex = 3;
            lblCodigoTecla.Text = "Código: 0";
            // 
            // grpRaton
            // 
            grpRaton.Controls.Add(lblRatonActivo);
            grpRaton.Controls.Add(lblClics);
            grpRaton.Controls.Add(lblUltimoBotonRaton);
            grpRaton.Controls.Add(lblPosicionX);
            grpRaton.Controls.Add(lblPosicionY);
            grpRaton.Location = new Point(477, 125);
            grpRaton.Name = "grpRaton";
            grpRaton.Size = new Size(280, 200);
            grpRaton.TabIndex = 1;
            grpRaton.TabStop = false;
            grpRaton.Text = "RATÓN";
            // 
            // lblRatonActivo
            // 
            lblRatonActivo.AutoSize = true;
            lblRatonActivo.Location = new Point(66, 156);
            lblRatonActivo.Name = "lblRatonActivo";
            lblRatonActivo.Size = new Size(88, 15);
            lblRatonActivo.TabIndex = 7;
            lblRatonActivo.Text = "Ratón : ACTIVO";
            // 
            // lblClics
            // 
            lblClics.AutoSize = true;
            lblClics.Location = new Point(66, 130);
            lblClics.Name = "lblClics";
            lblClics.Size = new Size(47, 15);
            lblClics.TabIndex = 6;
            lblClics.Text = "Clics : 0";
            // 
            // lblUltimoBotonRaton
            // 
            lblUltimoBotonRaton.AutoSize = true;
            lblUltimoBotonRaton.Location = new Point(66, 106);
            lblUltimoBotonRaton.Name = "lblUltimoBotonRaton";
            lblUltimoBotonRaton.Size = new Size(131, 15);
            lblUltimoBotonRaton.TabIndex = 5;
            lblUltimoBotonRaton.Text = "Último botón: Ninguno";
            // 
            // lblPosicionX
            // 
            lblPosicionX.AutoSize = true;
            lblPosicionX.Location = new Point(66, 49);
            lblPosicionX.Name = "lblPosicionX";
            lblPosicionX.Size = new Size(74, 15);
            lblPosicionX.TabIndex = 4;
            lblPosicionX.Text = "Posición X: 0";
            // 
            // lblPosicionY
            // 
            lblPosicionY.AutoSize = true;
            lblPosicionY.Location = new Point(66, 79);
            lblPosicionY.Name = "lblPosicionY";
            lblPosicionY.Size = new Size(74, 15);
            lblPosicionY.TabIndex = 3;
            lblPosicionY.Text = "Posición Y: 0";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(318, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Monitor de Periféricos";
            // 
            // btnReiniciarInterfaz
            // 
            btnReiniciarInterfaz.Location = new Point(374, 379);
            btnReiniciarInterfaz.Name = "btnReiniciarInterfaz";
            btnReiniciarInterfaz.Size = new Size(216, 30);
            btnReiniciarInterfaz.TabIndex = 3;
            btnReiniciarInterfaz.Text = "Pulsa aquí para reiniciar la interfaz";
            btnReiniciarInterfaz.UseVisualStyleBackColor = true;
            btnReiniciarInterfaz.Click += btnReiniciarInterfaz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(btnReiniciarInterfaz);
            Controls.Add(lblTitulo);
            Controls.Add(grpRaton);
            Controls.Add(grpTeclado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            grpTeclado.ResumeLayout(false);
            grpTeclado.PerformLayout();
            grpRaton.ResumeLayout(false);
            grpRaton.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTeclado;
        private Label lblUltimaTecla;
        private Label lblCodigoTecla;
        private GroupBox grpRaton;
        private Label lblUltimoBotonRaton;
        private Label lblPosicionX;
        private Label lblPosicionY;
        private Label lblTitulo;
        private Label lblClics;
        private Label lblTipo;
        private Label lblTecladoActivo;
        private Label lblRatonActivo;
        private Button btnReiniciarInterfaz;
    }
}
