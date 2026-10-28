namespace Proyecto.Juego.PONG
{
    partial class FormJuego
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
            components = new System.ComponentModel.Container();
            tmrJuego = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // tmrJuego
            //
            tmrJuego.Interval = 16;
            tmrJuego.Tick += tmrJuego_Tick;
            //
            // FormJuego
            //
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(680, 470);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PONG";
            FormClosed += FormJuego_FormClosed;
            Shown += FormJuego_Shown;
            Paint += FormJuego_Paint;
            KeyDown += FormJuego_KeyDown;
            KeyUp += FormJuego_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmrJuego;
    }
}