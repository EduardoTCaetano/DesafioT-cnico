using System;

public class StringService
{
    public static string InverterString(string texto)
    {
        string resultado = "";
        for (int i = texto.Length - 1; i >= 0; i--) resultado += texto[i];
        return resultado;
    }
}
