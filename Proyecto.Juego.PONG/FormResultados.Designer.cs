namespace Proyecto.Juego.PONG
{
    partial class FormResultados
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
            lblMensaje = new Label();
            lblTabla = new Label();
            lstClasificacion = new ListBox();
            lblRecord = new Label();
            btnOtraVez = new Button();
            btnMenu = new Button();
            SuspendLayout();
            //
            // lblMensaje
            //
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(12, 9);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(400, 55);
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTabla
            //
            lblTabla.AutoSize = true;
            lblTabla.ForeColor = Color.White;
            lblTabla.Location = new Point(12, 72);
            lblTabla.Name = "lblTabla";
            lblTabla.Text = "Tabla de clasificación (mayor a menor):";
            //
            // lstClasificacion
            //
            lstClasificacion.Font = new Font("Consolas", 10F);
            lstClasificacion.Location = new Point(12, 92);
            lstClasificacion.Name = "lstClasificacion";
            lstClasificacion.Size = new Size(400, 200);
            lstClasificacion.TabIndex = 2;
            //
            // lblRecord
            //
            lblRecord.ForeColor = Color.Khaki;
            lblRecord.Location = new Point(12, 298);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(400, 20);
            //
            // btnOtraVez
            //
            btnOtraVez.DialogResult = DialogResult.Retry;
            btnOtraVez.Location = new Point(92, 325);
            btnOtraVez.Name = "btnOtraVez";
            btnOtraVez.Size = new Size(110, 35);
            btnOtraVez.TabIndex = 0;
            btnOtraVez.Text = "Jugar otra vez";
            btnOtraVez.UseVisualStyleBackColor = true;
            //
            // btnMenu
            //
            btnMenu.DialogResult = DialogResult.Cancel;
            btnMenu.Location = new Point(222, 325);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(110, 35);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            //
            // FormResultados
            //
            AcceptButton = btnOtraVez;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            CancelButton = btnMenu;
            ClientSize = new Size(424, 375);
            Controls.Add(lblMensaje);
            Controls.Add(lblTabla);
            Controls.Add(lstClasificacion);
            Controls.Add(lblRecord);
            Controls.Add(btnOtraVez);
            Controls.Add(btnMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormResultados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PONG - Resultados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblTabla;
        private ListBox lstClasificacion;
        private Label lblRecord;
        private Button btnOtraVez;
        private Button btnMenu;
    }
}