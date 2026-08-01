using System;
using ProjetoGuaxi;

Reino meureino = new Reino();
bool jogando = true;

prodgenerica prodmadeira = new prodgenerica("Extração de Madeira", "Madeira");
prodgenerica prodmineracao = new prodgenerica("Mineração", "Ouro");
prodgenerica prodplantacao = new prodgenerica("Plantação", "Comida");
prodgenerica prodpomar = new prodgenerica("Pomar", "Comida");

bool lenhadorestrabalharamhoje = false;
bool mineradorestrabalharamhoje = false;
bool agricultorestrabalharamhoje = false;
bool colhedorestrabalharamhoje = false;

while (jogando)
{
    Console.Clear();
    Console.WriteLine("====================");
    Console.WriteLine("     LORD GUAXI     ");
    Console.WriteLine("====================");

    Console.WriteLine($"Dia: {meureino.dia}");
    Console.WriteLine($"Madeira: {meureino.madeira}");
    Console.WriteLine($"Ouro: {meureino.ouro}");
    Console.WriteLine($"Comida: {meureino.comida}");
    Console.WriteLine($"População: {meureino.populacao}"); 
    Console.WriteLine($"Soldados: {meureino.soldados}");

    Console.WriteLine();
    Console.WriteLine("1 = Cortar madeira");
    Console.WriteLine("2 = Minerar Ouro");
    Console.WriteLine("3 = Cuidar da Plantação");
    Console.WriteLine("4 = Colher no Pomar");
    Console.WriteLine("5 = Passar o dia");
    Console.WriteLine("6 = Mostrar reino");
    Console.WriteLine("7 = Sair");

    Console.Write("\nEscolha: ");
    if (!int.TryParse(Console.ReadLine(), out int escolha))
    {
        Console.WriteLine("\nPor favor, digite um número válido!");
    }
    if (escolha == 1)
    {
        if (lenhadorestrabalharamhoje)
        {
            Console.WriteLine("\nVocê já cortou madeira hoje, os lenhadores estão cansados");
        }
        else
        {
            var resultado = prodmadeira.Calcularproducao();
            Console.WriteLine($"\n{resultado.mensagem}");
            meureino.madeira += resultado.quantidade;
            lenhadorestrabalharamhoje = true;
        }
    }
    else if (escolha == 2)
    {
        if (mineradorestrabalharamhoje)
        {
            Console.WriteLine("\nOs mineradores já trabalharam duro nos túneis hoje!");
        }
        else
        {
            var resultado = prodmineracao.Calcularproducao();
            Console.WriteLine($"\n{resultado.mensagem}");
            meureino.ouro += resultado.quantidade;
            mineradorestrabalharamhoje = true;
        }
    }
    else if (escolha == 3)
    {
        if (agricultorestrabalharamhoje)
        {
            Console.WriteLine("\nOs agricultores já cuidaram da plantação hoje!");
        }
        else
        {
            var resultado = prodplantacao.Calcularproducao();
            Console.WriteLine($"\n{resultado.mensagem}");
            meureino.comida += resultado.quantidade;
            agricultorestrabalharamhoje = true;
        }
    }
    else if (escolha == 4)
    {
        if (colhedorestrabalharamhoje)
        {
            Console.WriteLine("\nAs frutas do pomar já foram colhidas hoje!");
        }
        else
        {
            var resultado = prodpomar.Calcularproducao();
            Console.WriteLine($"\n{resultado.mensagem}");
            meureino.comida += resultado.quantidade;
            colhedorestrabalharamhoje = true;
        }
    }
    else if (escolha == 5)
    {
        meureino.dia++;

        lenhadorestrabalharamhoje = false;
        mineradorestrabalharamhoje = false;
        agricultorestrabalharamhoje = false;
        colhedorestrabalharamhoje = false;

        Console.WriteLine($"\nAs sombras crescem longas e escuras conforme o sol se esconde no horizonte...");
    }
    else if (escolha == 6)
    {
        Console.WriteLine($"Dia: {meureino.dia}");
        Console.WriteLine($"Madeira: {meureino.madeira}");
        Console.WriteLine($"Ouro: {meureino.ouro}");
        Console.WriteLine($"Comida: {meureino.comida}");
        Console.WriteLine($"População: {meureino.populacao}");
        Console.WriteLine($"Soldados: {meureino.soldados}");
    }
    else if (escolha == 7)
    {
        Console.WriteLine("\nObrigado por jogar Lord Guaxi!");
        jogando = false;
    }
    else
    {
        Console.WriteLine("\nOpção inválida! Escolha um número de 1 a 7.");
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}
