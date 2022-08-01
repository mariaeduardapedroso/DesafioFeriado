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
                Console.WriteLine(DataAdquiridaString + " É UM FERIADO FIXO BORA DESCANSAR");
                Thread.Sleep(4000);
                GracinhaParaEncerrarPrograma();
                return;
            }

            if (DataAdquirida.CompararSeEFeriadoNaoFixo())
            {
                Console.WriteLine(DataAdquiridaString + " É FERIADO BORA DESCANSAR");
                Thread.Sleep(4000);
                GracinhaParaEncerrarPrograma();
                return;
            }

            Console.WriteLine(DataAdquiridaString + " NÃO É FERIADO BORA TRABALHAR");
            Thread.Sleep(4000);
            GracinhaParaEncerrarPrograma();
            return;
        }
        Console.WriteLine(DataAdquiridaString + " É UMA DATA ILEGIVEL");
        Thread.Sleep(4000);
        GracinhaParaEncerrarPrograma();

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

    private static void GracinhaParaEncerrarPrograma()
    {
        for (int contador = 5; contador >= 0; contador--)
        {
            Console.Clear();
            Console.WriteLine("ENCERRANDO O PROGRAMA EM " + contador);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("OBRIGADA POR USAR");
    }
}








/*
private static bool VerSeQuerMaisDatas()
{
    Console.WriteLine("GOSTARIA DE SABER ALGUMA OUTRA DATA (SIM NAO)");
    string resposta = Console.ReadLine();

    if (resposta.Equals("sim", StringComparison.OrdinalIgnoreCase))
    {
        GracinhaParaEncerrarPrograma();
        return false;
    }
    if (resposta.Equals("nao", StringComparison.OrdinalIgnoreCase))
    {
        Console.Clear();
        return true;
    }
    Console.WriteLine("VALOR INVÁLIDO VOU ENCERRAR O PROGRAMA");
    Thread.Sleep(4000);
    GracinhaParaEncerrarPrograma();
    return false;
}
*/