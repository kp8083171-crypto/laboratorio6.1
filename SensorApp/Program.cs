using System;

class Programa
{
    static double Ingresar()
    {
        Console.Write("Ingrese temperatura: ");
        return double.Parse(Console.ReadLine());
    }

    static bool Validar(double temp)
    {
        if (temp < 0)
        {
            Console.WriteLine("Temperatura inválida");
            return false;
        }
        return true;
    }

    static string Evaluar(double temp, double limite)
    {
        if (temp > limite)
            return "ALERTA";
        return "NORMAL";
    }

    static void Mostrar(string resultado)
    {
        Console.WriteLine("Estado: " + resultado);
    }

    static void Main()
    {
        double limite = 80; // ahora el límite es local y controlado

        double temp = Ingresar();

        if (Validar(temp))
        {
            string estado = Evaluar(temp, limite);
            Mostrar(estado);
        }
    }
}

