namespace Proyecto.Juego.PONG
{
    public partial class FormJuego : Form
    {
        private const int MARGEN = 20;

        private readonly LogicaPong logica;
        private readonly string nombre1;
        private readonly string nombre2;
        private bool pausado = false;

        private readonly Font fuentePuntos = new Font("Consolas", 32, FontStyle.Bold);
        private readonly Font fuenteTexto = new Font("Consolas", 11);
        private readonly Color colorPuntos = Color.FromArgb(255, 255, 200);

        public FormJuego(LogicaPong logica, string nombre1, string nombre2)
        {
            InitializeComponent();
            this.logica = logica;
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
        }

        private void FormJuego_Shown(object? sender, EventArgs e)
        {
            tmrJuego.Start();
        }

        private void tmrJuego_Tick(object? sender, EventArgs e)
        {
            logica.Actualizar();
            Invalidate();

            if (logica.Terminado)
            {
                tmrJuego.Stop();
                DialogResult = DialogResult.OK;
            }
        }

        private void FormJuego_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                pausado = !pausado;
                tmrJuego.Enabled = !pausado;
                Invalidate();
                return;
            }
            Tecla(e.KeyCode, true);
        }

        private void FormJuego_KeyUp(object? sender, KeyEventArgs e)
        {
            Tecla(e.KeyCode, false);
        }

        private void Tecla(Keys tecla, bool presionada)
        {
            bool individual = logica.Modo == ModoJuego.Individual;
            switch (tecla)
            {
                case Keys.W:
                    logica.Subir1 = presionada;
                    break;
                case Keys.S:
                    logica.Bajar1 = presionada;
                    break;
                case Keys.Up:
                    if (individual) logica.Subir1 = presionada; else logica.Subir2 = presionada;
                    break;
                case Keys.Down:
                    if (individual) logica.Bajar1 = presionada; else logica.Bajar2 = presionada;
                    break;
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down) return true;
            return base.IsInputKey(keyData);
        }

        private void FormJuego_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(MARGEN, MARGEN);

            using (var lapiz = new Pen(Color.White, 4))
            {
                g.DrawRectangle(lapiz, 0, 0, LogicaPong.ANCHO, LogicaPong.ALTO);
            }

            for (int y = 4; y <= LogicaPong.ALTO - 8; y += 16)
                g.FillRectangle(Brushes.White, LogicaPong.ANCHO / 2 - 2, y, 4, 8);

            using (var pincel = new SolidBrush(colorPuntos))
            {
                string izquierda = logica.Puntos1.ToString();
                string derecha = logica.Modo == ModoJuego.Individual ? logica.Vidas.ToString() : logica.Puntos2.ToString();
                float anchoIzq = g.MeasureString(izquierda, fuentePuntos).Width;
                g.DrawString(izquierda, fuentePuntos, pincel, LogicaPong.ANCHO / 2 - 30 - anchoIzq, 10);
                g.DrawString(derecha, fuentePuntos, pincel, LogicaPong.ANCHO / 2 + 30, 10);
            }

            g.FillRectangle(Brushes.White, logica.Paleta1());
            g.FillRectangle(Brushes.White, logica.Paleta2());
            g.FillEllipse(Brushes.White, logica.Pelota());

            string info = $"{nombre1}  vs  {nombre2}     Velocidad {logica.Nivel}     P = pausa";
            if (logica.Modo == ModoJuego.Individual)
                info = $"{nombre1}: puntos (izq) / vidas (der)     Velocidad {logica.Nivel}     P = pausa";
            g.DrawString(info, fuenteTexto, Brushes.Silver, 0, LogicaPong.ALTO + 15);

            if (pausado)
                g.DrawString("PAUSA", fuentePuntos, Brushes.White, LogicaPong.ANCHO / 2 - 60, LogicaPong.ALTO / 2 - 25);
        }

        private void FormJuego_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tmrJuego.Stop();
            fuentePuntos.Dispose();
            fuenteTexto.Dispose();
        }
    }
}
