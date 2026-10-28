namespace Proyecto.Juego.PONG
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
            lblTitulo = new Label();
            grpModo = new GroupBox();
            rbDosJugadores = new RadioButton();
            rbIndividual = new RadioButton();
            lblJugador1 = new Label();
            txtJugador1 = new TextBox();
            lblJugador2 = new Label();
            txtJugador2 = new TextBox();
            lblLimite = new Label();
            txtLimite = new TextBox();
            lblVelocidad = new Label();
            txtVelocidad = new TextBox();
            lblControles = new Label();
            btnJugar = new Button();
            btnClasificacion = new Button();
            btnSalir = new Button();
            grpModo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(457, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PONG";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpModo
            // 
            grpModo.Controls.Add(rbDosJugadores);
            grpModo.Controls.Add(rbIndividual);
            grpModo.ForeColor = Color.White;
            grpModo.Location = new Point(34, 107);
            grpModo.Margin = new Padding(3, 4, 3, 4);
            grpModo.Name = "grpModo";
            grpModo.Padding = new Padding(3, 4, 3, 4);
            grpModo.Size = new Size(416, 80);
            grpModo.TabIndex = 1;
            grpModo.TabStop = false;
            grpModo.Text = "Modo de juego";
            // 
            // rbDosJugadores
            // 
            rbDosJugadores.AutoSize = true;
            rbDosJugadores.Location = new Point(217, 33);
            rbDosJugadores.Margin = new Padding(3, 4, 3, 4);
            rbDosJugadores.Name = "rbDosJugadores";
            rbDosJugadores.Size = new Size(126, 24);
            rbDosJugadores.TabIndex = 1;
            rbDosJugadores.Text = "Dos jugadores";
            rbDosJugadores.CheckedChanged += rbModo_CheckedChanged;
            // 
            // rbIndividual
            // 
            rbIndividual.AutoSize = true;
            rbIndividual.Checked = true;
            rbIndividual.Location = new Point(17, 33);
            rbIndividual.Margin = new Padding(3, 4, 3, 4);
            rbIndividual.Name = "rbIndividual";
            rbIndividual.Size = new Size(153, 24);
            rbIndividual.TabIndex = 0;
            rbIndividual.TabStop = true;
            rbIndividual.Text = "Individual (vs CPU)";
            rbIndividual.CheckedChanged += rbModo_CheckedChanged;
            // 
            // lblJugador1
            // 
            lblJugador1.AutoSize = true;
            lblJugador1.ForeColor = Color.White;
            lblJugador1.Location = new Point(34, 211);
            lblJugador1.Name = "lblJugador1";
            lblJugador1.Size = new Size(77, 20);
            lblJugador1.TabIndex = 2;
            lblJugador1.Text = "Jugador 1:";
            // 
            // txtJugador1
            // 
            txtJugador1.Location = new Point(206, 207);
            txtJugador1.Margin = new Padding(3, 4, 3, 4);
            txtJugador1.MaxLength = 15;
            txtJugador1.Name = "txtJugador1";
            txtJugador1.Size = new Size(244, 27);
            txtJugador1.TabIndex = 1;
            // 
            // lblJugador2
            // 
            lblJugador2.AutoSize = true;
            lblJugador2.ForeColor = Color.White;
            lblJugador2.Location = new Point(34, 257);
            lblJugador2.Name = "lblJugador2";
            lblJugador2.Size = new Size(77, 20);
            lblJugador2.TabIndex = 3;
            lblJugador2.Text = "Jugador 2:";
            // 
            // txtJugador2
            // 
            txtJugador2.Enabled = false;
            txtJugador2.Location = new Point(206, 253);
            txtJugador2.Margin = new Padding(3, 4, 3, 4);
            txtJugador2.MaxLength = 15;
            txtJugador2.Name = "txtJugador2";
            txtJugador2.Size = new Size(244, 27);
            txtJugador2.TabIndex = 2;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.ForeColor = Color.White;
            lblLimite.Location = new Point(34, 304);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(92, 20);
            lblLimite.TabIndex = 4;
            lblLimite.Text = "Vidas (1-20):";
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(382, 297);
            txtLimite.Margin = new Padding(3, 4, 3, 4);
            txtLimite.MaxLength = 3;
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(68, 27);
            txtLimite.TabIndex = 3;
            txtLimite.Text = "3";
            //
            // lblVelocidad
            //
            lblVelocidad.AutoSize = true;
            lblVelocidad.ForeColor = Color.White;
            lblVelocidad.Location = new Point(34, 345);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(170, 20);
            lblVelocidad.TabIndex = 7;
            lblVelocidad.Text = "Velocidad inicial (1-10):";
            //
            // txtVelocidad
            //
            txtVelocidad.Location = new Point(382, 338);
            txtVelocidad.Margin = new Padding(3, 4, 3, 4);
            txtVelocidad.MaxLength = 2;
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(68, 27);
            txtVelocidad.TabIndex = 3;
            txtVelocidad.Text = "1";
            //
            // lblControles
            //
            lblControles.ForeColor = Color.Silver;
            lblControles.Location = new Point(34, 385);
            lblControles.Name = "lblControles";
            lblControles.Size = new Size(416, 67);
            lblControles.TabIndex = 5;
            lblControles.Text = "Jugador 1: W / S    Jugador 2: Flechas\r\nP = pausa.  La pelota acelera con cada punto.";
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(34, 462);
            btnJugar.Margin = new Padding(3, 4, 3, 4);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(126, 47);
            btnJugar.TabIndex = 4;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnClasificacion
            // 
            btnClasificacion.Location = new Point(179, 462);
            btnClasificacion.Margin = new Padding(3, 4, 3, 4);
            btnClasificacion.Name = "btnClasificacion";
            btnClasificacion.Size = new Size(126, 47);
            btnClasificacion.TabIndex = 5;
            btnClasificacion.Text = "Clasificación";
            btnClasificacion.UseVisualStyleBackColor = true;
            btnClasificacion.Click += btnClasificacion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(325, 462);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 47);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AcceptButton = btnJugar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(485, 535);
            Controls.Add(lblTitulo);
            Controls.Add(grpModo);
            Controls.Add(lblJugador1);
            Controls.Add(txtJugador1);
            Controls.Add(lblJugador2);
            Controls.Add(txtJugador2);
            Controls.Add(lblLimite);
            Controls.Add(txtLimite);
            Controls.Add(lblVelocidad);
            Controls.Add(txtVelocidad);
            Controls.Add(lblControles);
            Controls.Add(btnJugar);
            Controls.Add(btnClasificacion);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PONG - Inicio";
            grpModo.ResumeLayout(false);
            grpModo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpModo;
        private RadioButton rbIndividual;
        private RadioButton rbDosJugadores;
        private Label lblJugador1;
        private TextBox txtJugador1;
        private Label lblJugador2;
        private TextBox txtJugador2;
        private Label lblLimite;
        private TextBox txtLimite;
        private Label lblVelocidad;
        private TextBox txtVelocidad;
        private Label lblControles;
        private Button btnJugar;
        private Button btnClasificacion;
        private Button btnSalir;
    }
}