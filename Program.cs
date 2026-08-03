using System;
using ProjetoGuaxi;

Reino MeuReino = new Reino();
bool Jogando = true;

ProdGenerica ProdMadeira = new ProdGenerica("Extração de Madeira", "Madeira");
ProdGenerica ProdMineracao = new ProdGenerica("Mineração", "Ouro");
ProdGenerica ProdPlantacao = new ProdGenerica("Plantação", "Comida");
ProdGenerica ProdPomar = new ProdGenerica("Pomar", "Comida");

bool LenhadoresTrabalharamHoje = false;
bool MineradoresTrabalharamHoje = false;
bool AgricultoresTrabalharamHoje = false;
bool ColhedoresTrabalharamHoje = false;

while (Jogando)
{
    Console.Clear();
    Console.WriteLine("====================");
    Console.WriteLine("     LORD GUAXI     ");
    Console.WriteLine("====================");

    Console.WriteLine($"Dia: {MeuReino.Dia}");
    Console.WriteLine($"Madeira: {MeuReino.Madeira}");
    Console.WriteLine($"Ouro: {MeuReino.Ouro}");
    Console.WriteLine($"Comida: {MeuReino.Comida}");
    Console.WriteLine($"População: {MeuReino.Populacao}"); 
    Console.WriteLine($"Soldados: {MeuReino.Soldados}");

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
        if (LenhadoresTrabalharamHoje)
        {
            Console.WriteLine("\nVocê já cortou madeira hoje, os lenhadores estão cansados");
        }
        else
        {
            var Resultado = ProdMadeira.CalcularProducao();
            Console.WriteLine($"\n{Resultado.Mensagem}");
            MeuReino.Madeira += Resultado.Quantidade;
            LenhadoresTrabalharamHoje = true;
        }
    }
    else if (escolha == 2)
    {
        if (MineradoresTrabalharamHoje)
        {
            Console.WriteLine("\nOs mineradores já trabalharam duro nos túneis hoje!");
        }
        else
        {
            var resultado = ProdMineracao.CalcularProducao();
            Console.WriteLine($"\n{resultado.Mensagem}");
            MeuReino.Ouro += resultado.Quantidade;
            MineradoresTrabalharamHoje = true;
        }
    }
    else if (escolha == 3)
    {
        if (AgricultoresTrabalharamHoje)
        {
            Console.WriteLine("\nOs agricultores já cuidaram da plantação hoje!");
        }
        else
        {
            var resultado = ProdPlantacao.CalcularProducao();
            Console.WriteLine($"\n{resultado.Mensagem}");
            MeuReino.Comida += resultado.Quantidade;
            AgricultoresTrabalharamHoje = true;
        }
    }
    else if (escolha == 4)
    {
        if (ColhedoresTrabalharamHoje)
        {
            Console.WriteLine("\nAs frutas do pomar já foram colhidas hoje!");
        }
        else
        {
            var resultado = ProdPomar.CalcularProducao();
            Console.WriteLine($"\n{resultado.Mensagem}");
            MeuReino.Comida += resultado.Quantidade;
            ColhedoresTrabalharamHoje = true;
        }
    }
    else if (escolha == 5)
    {
        MeuReino.Dia++;

        LenhadoresTrabalharamHoje = false;
        MineradoresTrabalharamHoje = false;
        AgricultoresTrabalharamHoje = false;
        ColhedoresTrabalharamHoje = false;

        Console.WriteLine($"\nAs sombras crescem longas e escuras conforme o sol se esconde no horizonte...");
    }
    else if (escolha == 6)
    {
        Console.WriteLine($"Dia: {MeuReino.Dia}");
        Console.WriteLine($"Madeira: {MeuReino.Madeira}");
        Console.WriteLine($"Ouro: {MeuReino.Ouro}");
        Console.WriteLine($"Comida: {MeuReino.Comida}");
        Console.WriteLine($"População: {MeuReino.Populacao}");
        Console.WriteLine($"Soldados: {MeuReino.Soldados}");
    }
    else if (escolha == 7)
    {
        Console.WriteLine("\nObrigado por jogar Lord Guaxi!");
        Jogando = false;
    }
    else
    {
        Console.WriteLine("\nOpção inválida! Escolha um número de 1 a 7.");
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}
