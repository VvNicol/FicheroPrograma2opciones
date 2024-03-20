namespace FicheroPrograma2opciones.Servicios
{
    internal class OperativaImplementacion : OperativaInterface
    {
        static string archivo = "archivo.txt";
        void OperativaInterface.Insertar()
        {
            Console.WriteLine("Ingrese el numero de una linea");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de posicion");
            int numeroPosicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el texto que se va agregar");
            string nuevoTexto = Console.ReadLine();

            string[] leerLineas = File.ReadAllLines(archivo);

            if (numeroLinea >= 1 && numeroLinea < leerLineas.Length)
            {
                string posicionLinea = leerLineas[numeroLinea - 1];

                if (numeroPosicion >= 0 && numeroPosicion < posicionLinea.Length)
                {
                    string nuevaLinea = posicionLinea.Insert(numeroPosicion, nuevoTexto);
                    // Reemplazar la línea original con la línea modificada
                    leerLineas[numeroLinea - 1] = nuevaLinea;
                    // Sobrescribir el archivo con las líneas actualizadas
                    File.WriteAllLines(archivo, leerLineas);
                    Console.WriteLine("El texto se ha escrito correctamente en la posición especificada de la línea.");

                }
                else
                {
                    Console.WriteLine("Fuera de rango");
                }
            }
        }

        void OperativaInterface.ModificarLinea()
        {

            Console.WriteLine("Ingrese el numero de una linea");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo texto");
            string nuevoTexto = Console.ReadLine();
            string[] leerLineas = File.ReadAllLines(archivo);

            if (numeroLinea >= 1 && numeroLinea < leerLineas.Length)
            {
                leerLineas[numeroLinea - 1] = nuevoTexto;
                File.WriteAllLines (archivo, leerLineas);
                Console.WriteLine("El texto se ha escrito correctamente en la linea especificada");
            }
            else
            {
                Console.WriteLine("Fuera de rango");
            }
        }
    }
}