namespace Proyecto.Juego.PONG
{
    public enum ModoJuego
    {
        Individual,
        DosJugadores
    }

    public class LogicaPong
    {
        public const int ANCHO = 640;
        public const int ALTO = 400;
        public const int PALETA_ANCHO = 12;
        public const int PALETA_ALTO = 60;
        public const int PALETA_MARGEN = 10;
        public const int PELOTA_TAM = 10;
        private const float VELOCIDAD_PALETA = 7;
        private const float VELOCIDAD_CPU = 4;
        private const float VELOCIDAD_BASE = 4;
        private const float AUMENTO_POR_NIVEL = 1.2f;
        public const int NIVEL_MAXIMO = 10;
        public ModoJuego Modo { get; }
        public int Limite { get; }
        public float Paleta1Y { get; private set; }
        public float Paleta2Y { get; private set; }
        public float PelotaX { get; private set; }
        public float PelotaY { get; private set; }
        private float velX;
        private float velY;
        public int Puntos1 { get; private set; }
        public int Puntos2 { get; private set; }
        public int Golpes1 { get; private set; }
        public int Golpes2 { get; private set; }
        public int Vidas { get; private set; }
        public int NivelInicial { get; }
        public int Nivel { get; private set; }
        public bool Terminado { get; private set; }
        public bool Subir1 { get; set; }
        public bool Bajar1 { get; set; }
        public bool Subir2 { get; set; }
        public bool Bajar2 { get; set; }
        private bool saqueHaciaDerecha = true;
        private readonly Random azar = new Random();

        public LogicaPong(ModoJuego modo, int limite, int nivelInicial)
        {
            Modo = modo;
            Limite = limite;
            NivelInicial = nivelInicial;
            Nivel = nivelInicial;
            Vidas = modo == ModoJuego.Individual ? limite : 0;
            Paleta1Y = (ALTO - PALETA_ALTO) / 2f;
            Paleta2Y = Paleta1Y;
            Sacar();
        }

        public float Velocidad()
        {
            return VELOCIDAD_BASE + (Nivel - 1) * AUMENTO_POR_NIVEL;
        }

        public RectangleF Paleta1()
        {
            return new RectangleF(PALETA_MARGEN, Paleta1Y, PALETA_ANCHO, PALETA_ALTO);
        }

        public RectangleF Paleta2()
        {
            return new RectangleF(ANCHO - PALETA_MARGEN - PALETA_ANCHO, Paleta2Y, PALETA_ANCHO, PALETA_ALTO);
        }

        public RectangleF Pelota()
        {
            return new RectangleF(PelotaX, PelotaY, PELOTA_TAM, PELOTA_TAM);
        }

        public void Actualizar()
        {
            if (Terminado) return;

            MoverPaletas();

            PelotaX += velX;
            PelotaY += velY;

            if (PelotaY <= 0)
            {
                PelotaY = 0;
                velY = Math.Abs(velY);
            }
            else if (PelotaY + PELOTA_TAM >= ALTO)
            {
                PelotaY = ALTO - PELOTA_TAM;
                velY = -Math.Abs(velY);
            }

            if (velX < 0 && Pelota().IntersectsWith(Paleta1()))
            {
                Golpes1++;
                velX = Velocidad();
                velY = Rebote(Paleta1Y);
            }
            else if (velX > 0 && Pelota().IntersectsWith(Paleta2()))
            {
                Golpes2++;
                velX = -Velocidad();
                velY = Rebote(Paleta2Y);
            }

            if (PelotaX + PELOTA_TAM < 0)
                Anotar(2);
            else if (PelotaX > ANCHO)
                Anotar(1);
        }

        private void MoverPaletas()
        {
            if (Subir1) Paleta1Y -= VELOCIDAD_PALETA;
            if (Bajar1) Paleta1Y += VELOCIDAD_PALETA;

            if (Modo == ModoJuego.DosJugadores)
            {
                if (Subir2) Paleta2Y -= VELOCIDAD_PALETA;
                if (Bajar2) Paleta2Y += VELOCIDAD_PALETA;
            }
            else
            {
                MoverCPU();
            }

            Paleta1Y = Limitar(Paleta1Y);
            Paleta2Y = Limitar(Paleta2Y);
        }

        private void MoverCPU()
        {
            if (velX <= 0 || PelotaX < ANCHO / 2) return;
            float centroPaleta = Paleta2Y + PALETA_ALTO / 2f;
            float centroPelota = PelotaY + PELOTA_TAM / 2f;
            if (centroPelota < centroPaleta - 5)
                Paleta2Y -= VELOCIDAD_CPU;
            else if (centroPelota > centroPaleta + 5)
                Paleta2Y += VELOCIDAD_CPU;
        }

        private static float Limitar(float y)
        {
            if (y < 0) return 0;
            if (y > ALTO - PALETA_ALTO) return ALTO - PALETA_ALTO;
            return y;
        }

        private float Rebote(float paletaY)
        {
            float centroPaleta = paletaY + PALETA_ALTO / 2f;
            float centroPelota = PelotaY + PELOTA_TAM / 2f;
            float relativo = (centroPelota - centroPaleta) / (PALETA_ALTO / 2f);
            return relativo * Velocidad() * 0.8f;
        }

        private void Anotar(int jugador)
        {
            if (Modo == ModoJuego.Individual)
            {
                if (jugador == 1)
                {
                    Puntos1++;
                }
                else
                {
                    Vidas--;
                    if (Vidas <= 0) Terminado = true;
                }
            }
            else
            {
                if (jugador == 1) Puntos1++; else Puntos2++;
                if (Puntos1 >= Limite || Puntos2 >= Limite) Terminado = true;
            }

            ActualizarNivel();

            saqueHaciaDerecha = jugador == 1;
            if (!Terminado) Sacar();
        }

        private void ActualizarNivel()
        {
            Nivel = NivelInicial + Puntos1 + Puntos2;
            if (Nivel > NIVEL_MAXIMO) Nivel = NIVEL_MAXIMO;
        }

        private void Sacar()
        {
            PelotaX = (ANCHO - PELOTA_TAM) / 2f;
            PelotaY = (ALTO - PELOTA_TAM) / 2f;
            velX = saqueHaciaDerecha ? Velocidad() : -Velocidad();
            velY = (float)(azar.NextDouble() * 4 - 2);
        }
    }
}