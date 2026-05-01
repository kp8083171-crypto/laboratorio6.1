using System;

class Programa
{
    static int LIMITE_GLOBAL = 80;

    static bool ValidarTemperatura(double temp)
    {
        if (temp < 0)
        {
            Console.WriteLine("Error: valor inválido");
            return false;
        }
        return true;
    }

    static string EvaluarTemperatura(double temp)
    {
        if (temp > LIMITE_GLOBAL)
            return "ALERTA";
        return "NORMAL";
    }

    static void Main()
    {
        Console.Write("Ingrese temperatura: ");
        double temp = double.Parse(Console.ReadLine());

        if (ValidarTemperatura(temp))
        {
            string estado = EvaluarTemperatura(temp);
            Console.WriteLine("Estado: " + estado);
        }
    }
}
