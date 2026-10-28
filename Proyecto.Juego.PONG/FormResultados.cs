namespace Proyecto.Juego.PONG
{
    public partial class FormResultados : Form
    {
        public FormResultados(string mensaje, string nombreJugador, bool despuesDePartida)
        {
            InitializeComponent();

            lblMensaje.Text = mensaje;
            btnOtraVez.Visible = despuesDePartida;
            if (!despuesDePartida) AcceptButton = btnMenu;

            if (Clasificacion.TotalRegistros() == 0)
                lstClasificacion.Items.Add("Aún no hay partidas registradas.");
            else
                lstClasificacion.Items.AddRange(Clasificacion.Lista());

            if (nombreJugador != "")
            {
                int mejor = Clasificacion.BuscarPuntaje(nombreJugador);
                if (mejor >= 0) lblRecord.Text = $"Mejor puntaje de {nombreJugador}: {mejor}";
            }
        }
    }
}
