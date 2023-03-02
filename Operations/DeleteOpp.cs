using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InanToDo.Constr;
using InanToDo.Entities;

namespace InanToDo.Operations
{
    internal class DeleteOpp
    {
        Database db = new Database();
        public DeleteOpp()
        {
            startdelete:

            Console.Write("Silmek istediğiniz Kart Başlığını Yazınız : ");
            string silme = Console.ReadLine();

            foreach (var item in Board.cardsall)
            {
                Console.WriteLine(item.başlık);
                if (item.başlık.ToLower() == silme.ToLower())
                {
                    Board.cardsintodo.Remove(item);
                    break;
                }
                else
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
                        goto startdelete;
                    }

                }
            }
            foreach (var item in Board.cardsintodo)
            {
                Console.WriteLine(item.başlık + " awerrtfasfsdgsdg");
            }
        }
    }
}
