string reino = "Guaxiland";

int dia = 1;

int madeira = 0;

int ouro = 500;

int comida = 300;

int populacao = 40;

int soldados = 8;

bool jogando = true;
bool lenhadorestrabalharamhoje = false;
Random random = new Random();

while (jogando)
{
    Console.Clear();
    Console.WriteLine("====================");
    Console.WriteLine("     LORD GUAXI     ");
    Console.WriteLine("====================");

    Console.WriteLine($"Reino:{reino}");
    Console.WriteLine($"Dia: {dia}");
    Console.WriteLine($"Madeira: {madeira}");
    Console.WriteLine($"Ouro: {ouro}");
    Console.WriteLine($"Comida: {comida}");
    Console.WriteLine($"População: {populacao}"); 
    Console.WriteLine($"Soldados: {soldados}");

    Console.WriteLine();
    Console.WriteLine("1 = Cortar madeira");
    Console.WriteLine("2 = Passar o dia");
    Console.WriteLine("3 = Mostrar reino");
    Console.WriteLine("4 = Sair");

    Console.Write("Escolha: ");
    int escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        if (lenhadorestrabalharamhoje == true)
        {
            Console.WriteLine("Você já cortou madeira hoje, lenhadores estão cansados!");
        }
        else
        {
            int quantidademadeira = 0;
            int producao = random.Next(1, 6);
            
            if (producao == 1)
            {
                quantidademadeira = 30;
                Console.WriteLine("Alguns lenhadores estão doentes +30. (x_x)");
            }
            else if (producao == 2)
            {
                quantidademadeira = 70;
                Console.WriteLine("Lenhadores se distrairam com garotas no lago +70 (°>°)");
            }
            else if (producao == 3)
            {
                quantidademadeira = 100;
                Console.WriteLine("O mundo silenciou, mas o machado cantou +100");
            }
            else if (producao == 4)
            {
                quantidademadeira = 120;
                Console.WriteLine("Lenhadores encontraram algumas madeiras em bom estado no chão +120.");
            }
            else
            {
                quantidademadeira = 150;
                Console.WriteLine("Lenhadores encontraram uma floresta intocada! +150");
            }
            madeira += quantidademadeira;
            lenhadorestrabalharamhoje = true;
            

        }
    }

    else if (escolha == 2)
    {
        dia++;
        lenhadorestrabalharamhoje = false;
        Console.WriteLine($"\nAs sombras crescem longas e escuras conforme o sol se esconde no horizonte...");
    }
    else if (escolha == 3)
    {
        Console.WriteLine($"Dia: {dia}");
        Console.WriteLine($"Madeira: {madeira}");
        Console.WriteLine($"Ouro: {ouro}");
        Console.WriteLine($"Comida: {comida}");
        Console.WriteLine($"População: {populacao}");
        Console.WriteLine($"Soldados: {soldados}");
    }
    else if (escolha == 4)
    {
        Console.WriteLine("\nObrigado por jogar Lord Guaxi!");
        jogando = false;
    }
    Console.ReadKey();
}
