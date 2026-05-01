using System;

class Programa
{
    static double LIMITE_GLOBAL = 80;

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

    static string Evaluar(double temp)
    {
        if (temp > LIMITE_GLOBAL) return "ALERTA";
        return "NORMAL";
    }

    static void Mostrar(string resultado)
    {
        Console.WriteLine("Estado: " + resultado);
    }

    static void Main()
    {
        double temp = Ingresar();

        if (Validar(temp))
        {
            string estado = Evaluar(temp);
            Mostrar(estado);
        }
    }
}

