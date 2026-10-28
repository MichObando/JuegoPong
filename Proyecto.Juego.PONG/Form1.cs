namespace Proyecto.Juego.PONG
{
    public partial class Form1 : Form
    {
        private const int LIMITE_MINIMO = 1;
        private const int LIMITE_MAXIMO = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbModo_CheckedChanged(object? sender, EventArgs e)
        {
            bool dos = rbDosJugadores.Checked;
            txtJugador2.Enabled = dos;
            lblLimite.Text = dos ? "Puntos para ganar (1-20):" : "Vidas (1-20):";
            txtLimite.Text = dos ? "5" : "3";
        }

        private void btnJugar_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtLimite.Text.Trim(), out int limite) ||
                limite < LIMITE_MINIMO || limite > LIMITE_MAXIMO)
            {
                MessageBox.Show($"Escribe un número entero entre {LIMITE_MINIMO} y {LIMITE_MAXIMO}.",
                                "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimite.Focus();
                txtLimite.SelectAll();
                return;
            }

            if (!int.TryParse(txtVelocidad.Text.Trim(), out int velocidad) ||
                velocidad < 1 || velocidad > LogicaPong.NIVEL_MAXIMO)
            {
                MessageBox.Show($"La velocidad debe ser un número entero entre 1 y {LogicaPong.NIVEL_MAXIMO}.",
                                "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVelocidad.Focus();
                txtVelocidad.SelectAll();
                return;
            }

            ModoJuego modo = rbDosJugadores.Checked ? ModoJuego.DosJugadores : ModoJuego.Individual;
            string nombre1 = LeerNombre(txtJugador1, "Jugador 1");
            string nombre2 = modo == ModoJuego.DosJugadores ? LeerNombre(txtJugador2, "Jugador 2") : "CPU";

            Hide();
            bool otraVez;
            do
            {
                otraVez = Jugar(modo, limite, velocidad, nombre1, nombre2);
            } while (otraVez);
            Show();
        }

        private static string LeerNombre(TextBox caja, string porDefecto)
        {
            string nombre = caja.Text.Trim();
            if (nombre == "") nombre = porDefecto;
            caja.Text = nombre;
            return nombre;
        }

        private static bool Jugar(ModoJuego modo, int limite, int velocidad, string nombre1, string nombre2)
        {
            var logica = new LogicaPong(modo, limite, velocidad);

            using (var juego = new FormJuego(logica, nombre1, nombre2))
            {
                if (juego.ShowDialog() != DialogResult.OK) return false;
            }

            string mensaje;
            if (modo == ModoJuego.Individual)
            {
                Clasificacion.Agregar(nombre1, logica.Puntos1, "Individual");
                mensaje = $"{nombre1} se quedó sin vidas.\r\n" +
                          $"Puntaje: {logica.Puntos1}   Golpes: {logica.Golpes1}   Velocidad alcanzada: {logica.Nivel}";
            }
            else
            {
                Clasificacion.Agregar(nombre1, logica.Puntos1, "2 jugadores");
                Clasificacion.Agregar(nombre2, logica.Puntos2, "2 jugadores");
                string ganador = logica.Puntos1 > logica.Puntos2 ? nombre1 : nombre2;
                mensaje = $"¡Gana {ganador}!  {logica.Puntos1} - {logica.Puntos2}\r\n" +
                          $"Golpes: {nombre1} {logica.Golpes1}  |  {nombre2} {logica.Golpes2}   Velocidad: {logica.Nivel}";
            }

            using (var resultados = new FormResultados(mensaje, nombre1, true))
            {
                return resultados.ShowDialog() == DialogResult.Retry;
            }
        }

        private void btnClasificacion_Click(object? sender, EventArgs e)
        {
            using (var resultados = new FormResultados("Clasificación de la sesión", txtJugador1.Text.Trim(), false))
            {
                resultados.ShowDialog();
            }
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
