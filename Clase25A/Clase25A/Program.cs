namespace Clase25A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, direccion, telefono;
            Console.Title = "Datos del alumno";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(6, 2);
            Console.Write("Nombre: ");
            Console.SetCursorPosition(6, 4);
            Console.Write("Dirección: ");
            Console.SetCursorPosition(6, 6);
            Console.Write("Teléfono: ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(18, 2);
            nombre = Console.ReadLine();
            Console.SetCursorPosition(18, 4);
            direccion = Console.ReadLine();
            Console.SetCursorPosition(18, 6);
            telefono = Console.ReadLine();

            //Traductor english = new InglesT();
            //Traductor french = new FrancesT();
            //Traductor german = new AlemanT();

            //english.Print();
            //french.Print();
            //german.Print();

            Console.ReadKey();
        }
    }
}