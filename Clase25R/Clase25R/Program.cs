namespace Clase25R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new DeriveClass();
            double r = bc.InteresMensual(12);
            Console.WriteLine("El interés es de: " + r);
            double ct = bc.CantidadTotal(10, 5);
            Console.WriteLine("La cantidad total mensual es de: " + ct);
            double area = bc.Area(6);
            Console.WriteLine("El área es de: " + area);

            DeriveClass b = new DeriveClass();
            double a = b.Area(3);
            Console.WriteLine("El área de la clase derivada es: " + a);
            double e = b.InteresMensual(12);
            Console.WriteLine("El interés generado en la clase derivada es: " + e);


            Console.ReadKey();
        }
    }
}