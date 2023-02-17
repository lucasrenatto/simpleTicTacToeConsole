using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace testeeeee
{
    class Program
    {
        public static void Main(string[] args)
        {

            string posicoesD = "";
            string tabuleiro = @"_|_|_
_|_|_
 | | ";
            var teste = tabuleiro.ToCharArray();

            bool jogoAcabou = false;

            bool jogadorDois = false;

            List<int> posicaoX = new List<int>()
            {
            };
            List<int> posicaoO = new List<int>()
            {
            };
            List<int> posicaoDisponivel = new List<int>()
           {
                1,2,3,
                4,5,6,
                7,8,9
           };

            while (jogoAcabou == false)
            {
                posicoesD = "";
                Console.WriteLine(tabuleiro);
                Console.WriteLine("Jogador 1, digite a posição que queira marcar X");
                Console.WriteLine("As posições disponíveis são:");
                foreach (var x in posicaoDisponivel)
                {
                    posicoesD = posicoesD + " - " + x.ToString();
                }
                Console.WriteLine(posicoesD);
                int a = Convert.ToInt32(Console.ReadLine());
                var ExistePosicaoDisponivel = posicaoDisponivel.Where(x => x == a).FirstOrDefault();
                if (ExistePosicaoDisponivel == 0)
                {
                    Console.WriteLine("A posição desejada já foi selecionada ou não existe, tente novamente.");
                    continue;
                }
                posicaoDisponivel.RemoveAll(x => x == a);
                posicaoX.Add(a);
                if (a == 1)
                    teste[0] = 'X';
                else if (a == 2)
                    teste[2] = 'X';
                else if (a == 3)
                    teste[4] = 'X';
                else if (a == 4)
                    teste[7] = 'X';
                else if (a == 5)
                    teste[9] = 'X';
                else if (a == 6)
                    teste[11] = 'X';
                else if (a == 7)
                    teste[14] = 'X';
                else if (a == 8)
                    teste[16] = 'X';
                else if (a == 9)
                    teste[18] = 'X';

                if (posicaoX.Count >= 3)
                {
                    if (posicaoX.Contains(1) && posicaoX.Contains(2) && posicaoX.Contains(3))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(1) && posicaoX.Contains(5) && posicaoX.Contains(9))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(1) && posicaoX.Contains(4) && posicaoX.Contains(7))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(2) && posicaoX.Contains(5) && posicaoX.Contains(8))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(3) && posicaoX.Contains(6) && posicaoX.Contains(9))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(4) && posicaoX.Contains(5) && posicaoX.Contains(6))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(7) && posicaoX.Contains(8) && posicaoX.Contains(9))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    else if (posicaoX.Contains(7) && posicaoX.Contains(5) && posicaoX.Contains(3))
                    {
                        Console.WriteLine("Jogador 1 Venceu!!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }

                }
                tabuleiro = new string(teste);
                if (posicaoDisponivel.Count == 0)
                {
                    Console.WriteLine("Velha!");
                    Thread.Sleep(5000);
                    jogoAcabou = true;
                }
                Console.WriteLine(tabuleiro);
                jogadorDois = false;
                if (jogoAcabou == true)
                    continue;
                while (jogadorDois == false)
                {
                    Console.WriteLine("Jogador 2, digite a posição que queira marcar X");
                    Console.WriteLine("As posições disponíveis são:");
                    posicoesD = "";
                    foreach (var v in posicaoDisponivel)
                    {
                        posicoesD = posicoesD + " - " + v.ToString();
                    }
                    Console.WriteLine(posicoesD);
                    int b = Convert.ToInt32(Console.ReadLine());
                    ExistePosicaoDisponivel = posicaoDisponivel.Where(x => x == b).FirstOrDefault();
                    if (ExistePosicaoDisponivel == 0)
                    {
                        jogadorDois = false;
                        Console.WriteLine("A posição desejada já foi selecionada ou não existe, tente novamente.");
                        continue;
                    }
                    jogadorDois = true;
                    posicaoDisponivel.RemoveAll(x => x == b);
                    posicaoO.Add(b);
                    if (b == 1)
                        teste[0] = 'O';
                    else if (b == 2)
                        teste[2] = 'O';
                    else if (b == 3)
                        teste[4] = 'O';
                    else if (b == 4)
                        teste[7] = 'O';
                    else if (b == 5)
                        teste[9] = 'O';
                    else if (b == 6)
                        teste[11] = 'O';
                    else if (b == 7)
                        teste[14] = 'O';
                    else if (b == 8)
                        teste[16] = 'O';
                    else if (b == 9)
                        teste[18] = 'O';
                    tabuleiro = new string(teste);
                    if (posicaoO.Count >= 3)
                    {
                        if (posicaoO.Contains(1) && posicaoO.Contains(2) && posicaoO.Contains(3))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(1) && posicaoO.Contains(5) && posicaoO.Contains(9))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(1) && posicaoO.Contains(4) && posicaoO.Contains(7))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(2) && posicaoO.Contains(5) && posicaoO.Contains(8))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(3) && posicaoO.Contains(6) && posicaoO.Contains(9))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(4) && posicaoO.Contains(5) && posicaoO.Contains(6))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(7) && posicaoO.Contains(8) && posicaoO.Contains(9))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                        else if (posicaoO.Contains(7) && posicaoO.Contains(5) && posicaoO.Contains(3))
                        {
                            Console.WriteLine("Jogador 2 Venceu!!");
                            Thread.Sleep(5000);
                            jogoAcabou = true;
                        }
                    }
                    if (posicaoDisponivel.Count == 0)
                    {
                        Console.WriteLine("Velha!");
                        Thread.Sleep(5000);
                        jogoAcabou = true;
                    }
                    if (jogoAcabou == true)
                        break;
                }

            }
        }
    }
}
