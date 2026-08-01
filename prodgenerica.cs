using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGuaxi
{
    public class prodgenerica
    {
        private Random random = new Random();

        public string Nomeatividade { get; set; }
        public string Nomerecurso { get; set; }

        public prodgenerica(string Nomeatividade, string Nomerecurso)
        {
            this.Nomeatividade = Nomeatividade;
            this.Nomerecurso = Nomerecurso;
        }
        public (int quantidade, string mensagem) Calcularproducao()
        {
            int sorteio = random.Next(1, 6);
            int quantidade = 0;
            string mensagem = "";

            switch (Nomeatividade)
            {
                case "Extração de Madeira":
                    if (sorteio == 1) { quantidade = 30; mensagem = "Alguns lenhadores estão doentes. +30 comida. (x_x)"; }
                    else if (sorteio == 2) { quantidade = 70; mensagem = "Lenhadores se distraíram com garotas no lago. +70 Madeiras.(°>°)"; }
                    else if (sorteio == 3) { quantidade = 100; mensagem = "O mundo silenciou, mas o machado cantou! +100 Madeiras."; }
                    else if (sorteio == 4) { quantidade = 120; mensagem = " Lenhadores encontraram algumas madeiras em bom estado no chão. +120 Madeiras."; }
                    else { quantidade = 150; mensagem = "Lenhadores encontraram uma floresta intocada! +150 Madeiras."; }
                    break;

                case "Mineração":
                    if (sorteio == 1) { quantidade = 30; mensagem = "Um desmoronamento parcial bloqueou os túneis principais. +30 Ouro (x_x)"; }
                    else if (sorteio == 2) { quantidade = 70; mensagem = "As picaretas quebraram e os mineradores perderam tempo afiando as ferramentas. +70 Ouro."; }
                    else if (sorteio == 3) { quantidade = 100; mensagem = "O eco das picaretas ditou o ritmo nos túneis hoje. +100 Ouro."; }
                    else if (sorteio == 4) { quantidade = 120; mensagem = "Os mineradores encontraram um antigo baú abandonado em um poço desativado!  +120 Ouro."; }
                    else { quantidade = 150; mensagem = "Uma veia de ouro puro foi descoberta nas profundezas da rocha! +150 Ouro."; }
                    break;

                case "Plantação":
                    if (sorteio == 1) { quantidade = 30; mensagem = "Uma praga de gafanhotos atacou parte das lavouras. +30 Comida. (x_x)"; }
                    else if (sorteio == 2) { quantidade = 70; mensagem = "O sol escaldante castigou a terra e atrasou o cultivo. +70 Comida."; }
                    else if (sorteio == 3) { quantidade = 100; mensagem = "Os pássaros cantam nas lavouras. +100 Comida."; }
                    else if (sorteio == 4) { quantidade = 120; mensagem = "A chuva caiu na hora certa e o trigo cresceu forte. +120 Comida."; }
                    else { quantidade = 150; mensagem = "A colheita deste ano foi histórica! +150 Comida."; }
                    break;

                case "Pomar":
                    if (sorteio == 1) { quantidade = 30; mensagem = "Pássaros e javalis invadiram as cercas e comeram as frutas baixas. +30 Comida. (x_x)"; }
                    else if (sorteio == 2) { quantidade = 70; mensagem = "Muitas frutas ainda estavam verdes e não puderam ser colhidas. +70 Comida.(°>°)"; }
                    else if (sorteio == 3) { quantidade = 100; mensagem = "Os cestos foram preenchidos com maçãs no tempo planejado. +100 Comida."; }
                    else if (sorteio == 4) { quantidade = 120; mensagem = "Os colhedores encontraram árvores silvestres carregadas além dos limites do Pomar. +120 Comida."; }
                    else { quantidade = 150; mensagem = "As árvores do pomar vergaram de tão carregadas. +150 Comida."; }
                    break;

                default:
                    quantidade = 50;
                    mensagem = $"Trabalho genérico realizado. +{quantidade} {Nomerecurso}.";
                    break;

                }
                return (quantidade, mensagem);
            }
        }
    }
