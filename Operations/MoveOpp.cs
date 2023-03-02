using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InanToDo.Constr;

namespace InanToDo.Operations
{
    internal class MoveOpp
    {
        public MoveOpp()
        {
            startmove:

            Console.Write("Taşımak istediğiniz Kart Başlığını Yazınız : ");
            string move = Console.ReadLine();

            foreach (var item in Board.cardsall)
            {
                if (move.ToLower() != item.başlık.ToLower())
                {
                    Console.WriteLine("Aradığınız Kritere Uygun Kart board'da bulunamadı.");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("*Yeniden denemek için (2)");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    if (input1 == 1)
                    {
                        Console.WriteLine("Çıkış Yapılıyor.");
                        break;
                    }
                    else
                    {
                        goto startmove;
                    }
                }
                else if (move.ToLower() == item.başlık.ToLower())
                {
                    Console.WriteLine("Bulunan Kart Bigileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık     : " + item.başlık);
                    Console.WriteLine("İçerik     : " + item.içerik);
                    Console.WriteLine("Atanan Kişi: " + item.kisi);
                    Console.WriteLine("Büyüklük   : " + item.size);
                    Console.WriteLine("Line       : " + item.line);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşıman istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    switch (input2)
                    {
                        case 1:
                            item.line = "1";
                            Board.cardsintodo.Add(item);                            
                            break;
                        case 2:
                            item.line = "2";
                            Board.cardsinprogg.Add(item);
                            break;
                        case 3:
                            item.line = "3";
                            Board.cardsindone.Add(item);
                            break;
                                                default:
                            break;
                    }
                }

            }
        }
    }
}
