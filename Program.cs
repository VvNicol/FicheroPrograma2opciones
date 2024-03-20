using FicheroPrograma2opciones.Servicios;

namespace FicheroPrograma2opciones
{
    internal class Program
    {
        static string archivo = "archivo.txt";
        static void Main(string[] args)
        {
            using(StreamWriter sw = new StreamWriter(archivo))
            {
                sw.WriteLine(
                    "Linea 1\n" +
                    "Linea 2\n" +
                    "Linea 3\n" +
                    "Linea 4\n" +
                    "Linea 5\n" +
                    "Linea 6\n" );
            }

            MenuInterface mi = new MenuImplementacion();
            OperativaInterface oi = new OperativaImplementacion();

            int opcionSeleccionada;
            bool esCerrado = false;

            try
            {
                do
                {
                    opcionSeleccionada = mi.MostrarMenuInicio();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("El menu se ha cerrado");
                            esCerrado = true;
                            break;
                        case 1:
                            oi.ModificarLinea();
                            break;
                        case 2:
                            oi.Insertar();
                            break;
                    }

                } while (!esCerrado);
            }catch (IOException e)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
            }
        }
    }
}
