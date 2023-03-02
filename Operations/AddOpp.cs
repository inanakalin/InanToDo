using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InanToDo.Constr;
using InanToDo.Entities;

namespace InanToDo.Operations
{
    internal class AddOpp
    {
        Database ddd = new Database();
        public AddOpp()
        {
            Console.Write(" Başlık Giriniz                                  : ");
            string baslik = Console.ReadLine();
            Console.Write(" İçerik giriniz                                  : ");
            string icerik = Console.ReadLine();
            Console.Write(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            EnSize boyut = (EnSize)int.Parse(Console.ReadLine());
            Console.Write(" Kişi Seçiniz                                    : ");
            int kisi = int.Parse(Console.ReadLine());
            Console.Write(" Board Seçiniz                                   : ");
            string line = Console.ReadLine();
            string kim = null;

            switch (kisi)
            {
                case 1: kim = Database.personlist[1]; break;
                case 2: kim = Database.personlist[2]; break;
                case 3: kim = Database.personlist[3]; break;
                case 4: kim = Database.personlist[4]; break;
                case 5: kim = Database.personlist[5]; break;
                default:
                    Console.WriteLine("Yanlış bir tercih yaptınız");
                    break;
            }

            Database.AddCards(baslik, icerik, kim, boyut, line);
        }
    }
}