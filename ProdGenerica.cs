using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGuaxi
{
    public class ProdGenerica
    {
        private Random random = new Random();

        public string NomeAtividade { get; set; }
        public string NomeRecurso { get; set; }

        public ProdGenerica(string NomeAtividade, string NomeRecurso)
        {
            this.NomeAtividade = NomeAtividade;
            this.NomeRecurso = NomeRecurso;
        }
        public (int Quantidade, string Mensagem) CalcularProducao()
        {
            int Sorteio = random.Next(1, 6);
            int Quantidade = 0;
            string Mensagem = "";

            switch (NomeAtividade)
            {
                case "Extração de Madeira":
                    if (Sorteio == 1) { Quantidade = 30; Mensagem = "Alguns lenhadores estão doentes. +30 comida. (x_x)"; }
                    else if (Sorteio == 2) { Quantidade = 70; Mensagem = "Lenhadores se distraíram com garotas no lago. +70 Madeiras.(°>°)"; }
                    else if (Sorteio == 3) { Quantidade = 100; Mensagem = "O mundo silenciou, mas o machado cantou! +100 Madeiras."; }
                    else if (Sorteio == 4) { Quantidade = 120; Mensagem = " Lenhadores encontraram algumas madeiras em bom estado no chão. +120 Madeiras."; }
                    else { Quantidade = 150; Mensagem = "Lenhadores encontraram uma floresta intocada! +150 Madeiras."; }
                    break;

                case "Mineração":
                    if (Sorteio == 1) { Quantidade = 30; Mensagem = "Um desmoronamento parcial bloqueou os túneis principais. +30 Ouro (x_x)"; }
                    else if (Sorteio == 2) { Quantidade = 70; Mensagem = "As picaretas quebraram e os mineradores perderam tempo afiando as ferramentas. +70 Ouro."; }
                    else if (Sorteio == 3) { Quantidade = 100; Mensagem = "O eco das picaretas ditou o ritmo nos túneis hoje. +100 Ouro."; }
                    else if (Sorteio == 4) { Quantidade = 120; Mensagem = "Os mineradores encontraram um antigo baú abandonado em um poço desativado!  +120 Ouro."; }
                    else { Quantidade = 150; Mensagem = "Uma veia de ouro puro foi descoberta nas profundezas da rocha! +150 Ouro."; }
                    break;

                case "Plantação":
                    if (Sorteio == 1) { Quantidade = 30; Mensagem = "Uma praga de gafanhotos atacou parte das lavouras. +30 Comida. (x_x)"; }
                    else if (Sorteio == 2) { Quantidade = 70; Mensagem = "O sol escaldante castigou a terra e atrasou o cultivo. +70 Comida."; }
                    else if (Sorteio == 3) { Quantidade = 100; Mensagem = "Os pássaros cantam nas lavouras. +100 Comida."; }
                    else if (Sorteio == 4) { Quantidade = 120; Mensagem = "A chuva caiu na hora certa e o trigo cresceu forte. +120 Comida."; }
                    else { Quantidade = 150; Mensagem = "A colheita deste ano foi histórica! +150 Comida."; }
                    break;

                case "Pomar":
                    if (Sorteio == 1) { Quantidade = 30; Mensagem = "Pássaros e javalis invadiram as cercas e comeram as frutas baixas. +30 Comida. (x_x)"; }
                    else if (Sorteio == 2) { Quantidade = 70; Mensagem = "Muitas frutas ainda estavam verdes e não puderam ser colhidas. +70 Comida.(°>°)"; }
                    else if (Sorteio == 3) { Quantidade = 100; Mensagem = "Os cestos foram preenchidos com maçãs no tempo planejado. +100 Comida."; }
                    else if (Sorteio == 4) { Quantidade = 120; Mensagem = "Os colhedores encontraram árvores silvestres carregadas além dos limites do Pomar. +120 Comida."; }
                    else { Quantidade = 150; Mensagem = "As árvores do pomar vergaram de tão carregadas. +150 Comida."; }
                    break;

                default:
                    Quantidade = 50;
                    Mensagem = $"Trabalho genérico realizado. +{Quantidade} {NomeRecurso}.";
                    break;

                }
                return (Quantidade, Mensagem);
            }
        }
    }
