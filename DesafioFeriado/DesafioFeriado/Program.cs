using System;
using System.Text.RegularExpressions;
using DesafioFeriado;
class MetodoParaDescobrirSeDiaEFeriado
{
    static void Main(string[] args)
    {
        var TesteDataFormato = "[0-9]{2}[/][0-9]{2}[/][0-9]{4}";
        string DataAdquiridaString;

        Console.WriteLine("----BEM VINDO AO GURU DAS DATAS ME DIGA UMA DATA E MOSTRAREI SE É FERIADO OU NÃO----");
        Console.WriteLine("Digite a data com dd/mm/aa");
        DataAdquiridaString = Console.ReadLine();
        GracinhaParaMostrarOResultado();

        Match resultado1 = Regex.Match(DataAdquiridaString, TesteDataFormato);

        if (resultado1.Success)
        {
            VerSeADataEFeriado DataAdquirida = new VerSeADataEFeriado(DataAdquiridaString);

            if (DataAdquirida.CompararSeEFeriadoFixo())
            {
                Console.WriteLine(DataAdquiridaString + " É UM FERIADO FIXO BORA DESCANAR");
                return;
            }

            if (DataAdquirida.CompararSeEFeriadoNaoFixo())
            {
                Console.WriteLine(DataAdquiridaString + " É FERIADO BORA DESCANSAR");
                return;
            }

            Console.WriteLine(DataAdquiridaString + " NÃO É FERIADO BORA TRABALHAR");
            return;
        }
        Console.WriteLine(DataAdquiridaString + " É UMA DATA ILEGIVEL");
    }

    private static void GracinhaParaMostrarOResultado()
    {
        Console.Clear();
        Console.WriteLine("UM SEGUNDO ESTAMOS VERIFICANDO");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("UM SEGUNDO ESTAMOS VERIFICANDO.");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("UM SEGUNDO ESTAMOS VERIFICANDO..");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("UM SEGUNDO ESTAMOS VERIFICANDO...");
        Thread.Sleep(1000);
        Console.Clear();
    }
}