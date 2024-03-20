namespace FicheroPrograma2opciones.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        public int MostrarMenuInicio()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Modificar linea");
            Console.WriteLine("2.Insertar texto en posicion especifica");

            int eleccion = Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }
    }
}