using System;
using System.Text.RegularExpressions;
using DesafioFeriado;
class MetodoParaDescobrirSeDiaEFeriado
{
    static void Main(string[] args)
    {
        var TesteDataFormato = "[0-9]{2}[/][0-9]{2}[/][0-9]{4}";
        string DataAdquiridaString;

        Console.WriteLine("Digite a data com dd/mm/aa");
        DataAdquiridaString = Console.ReadLine();

        Match resultado1 = Regex.Match(DataAdquiridaString, TesteDataFormato);

        if (resultado1.Success)
        {
            VerSeADataEFeriado DataAdquirida = new VerSeADataEFeriado(DataAdquiridaString);

            if (DataAdquirida.CompararSeEFeriadoFixo())
            {
                Console.WriteLine("É UM FERIADO FIXO");
                return;
            }

            if (DataAdquirida.CompararSeEFeriadoNaoFixo())
            {
                Console.WriteLine("É FERIADO");
                return;
            }

            Console.WriteLine("NÃO É FERIADO");
            return;
        }
        Console.WriteLine("DATA ILEGIVEL");
    }
}



