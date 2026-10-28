namespace Proyecto.Juego.PONG
{
    public static class Clasificacion
    {
        public const int MAXIMO = 50;

        private static readonly string[] nombres = new string[MAXIMO];
        private static readonly int[] puntajes = new int[MAXIMO];
        private static readonly string[] modos = new string[MAXIMO];
        private static int cantidad = 0;

        public static int TotalRegistros()
        {
            return cantidad;
        }

        public static void Agregar(string nombre, int puntaje, string modo)
        {
            if (cantidad == MAXIMO)
            {
                if (puntaje <= puntajes[MAXIMO - 1]) return;
                cantidad--;
            }

            nombres[cantidad] = nombre;
            puntajes[cantidad] = puntaje;
            modos[cantidad] = modo;
            cantidad++;

            Ordenar();
        }

        private static void Ordenar()
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (puntajes[j] < puntajes[j + 1])
                        Cambiar(j, j + 1);
                }
            }
        }

        private static void Cambiar(int a, int b)
        {
            string tmpNombre = nombres[a];
            nombres[a] = nombres[b];
            nombres[b] = tmpNombre;

            int tmpPuntaje = puntajes[a];
            puntajes[a] = puntajes[b];
            puntajes[b] = tmpPuntaje;

            string tmpModo = modos[a];
            modos[a] = modos[b];
            modos[b] = tmpModo;
        }

        public static int BuscarPuntaje(string nombre)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (string.Equals(nombres[i], nombre, StringComparison.OrdinalIgnoreCase))
                    return puntajes[i];
            }
            return -1;
        }

        public static string[] Lista()
        {
            string[] filas = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
                filas[i] = $"{i + 1}. {nombres[i]} - {puntajes[i]} pts ({modos[i]})";
            return filas;
        }
    }
}