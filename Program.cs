internal class Program
{   private static void Main(string[] args)
    {
        double mon = 0, salar, salario, total;
        int empleado1 = 0, empleado2 = 0, num, faltas;
        string nom;

        Console.Write("Ingrese el número de empleados: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Empleado {i+ 1}:");
            Console.WriteLine("Nombre: ");
            nom = Console.ReadLine();
            Console.WriteLine("Salario mensual: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de faltas: ");
            faltas = int.Parse(Console.ReadLine());
            salario = salario / 30;
            total = salario - (faltas * salario);
            mon += total;
            if (total >= 2500 && total <= 3500)
                empleado1++;
            if (total < 1000 || total > 4000)
                empleado2++;

            Console.WriteLine($"Sueldo final de {nom}: {total}");
        }
        Console.WriteLine($"Monto total de sueldos: {mon}");
        Console.WriteLine($"Número de empleados que ganan entre 2500 y 3500: {empleado1}");
        Console.WriteLine($"Número de empleados que ganan menos de 1000 o más de 4000: {empleado2}");
    }
}