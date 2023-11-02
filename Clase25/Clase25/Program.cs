namespace Clase25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            // Guardo los correspondientes colores de background y foreground.
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;


            //Muestra todos los colores de primer plano excepto el que coincide con el fondo.
            Console.WriteLine("Todos los colores de primer plano excepto {0}, que coicide con el fondo:",
                              currentBackground);
            foreach (var color in colors)
            {
                if (color == currentBackground) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   El color de primer plano es {0}.", color);
            }
            Console.WriteLine();
            // Restauramos el color de primer plano.
            Console.ForegroundColor = currentForeground;
            // Muestra cada color de fondo excepto el que coincide con el color de primer plano actual.
            Console.WriteLine("Todos los colores de fondo excepto {0}, que coincide con el texto:",
                                  currentForeground);
            foreach (var color in colors)
            {
                if (color == currentForeground) continue;

                Console.BackgroundColor = color;
                Console.WriteLine("   El color de fondo es {0}.", color);
            }

            // Restauramos los colores originales de la consola.
            Console.ResetColor();
            Console.WriteLine("\n\nColores de consola originales restaurados...");
            Console.ReadKey();

        }
    }
}