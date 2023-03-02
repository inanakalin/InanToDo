using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InanToDo.Constr;
using InanToDo.Entities;

namespace InanToDo.Operations
{
    internal class ListOpp
    {
        Database db = new Database();   
        public ListOpp()
        {
            Console.WriteLine("****** TODO Line ****** \n" );
            foreach (var item in Board.cardsintodo)
            {
                Console.WriteLine("Başlık     : " + item.başlık);
                Console.WriteLine("İçerik     : " + item.içerik);
                Console.WriteLine("Atanan Kişi: " + item.kisi);
                Console.WriteLine("Büyüklük   : " + item.size);
                Console.WriteLine("-");
            }

            Console.WriteLine("****** INPROGRESS Line ****** \n ");
            foreach (var item in Board.cardsinprogg)
            {
                Console.WriteLine("Başlık     : " + item.başlık);
                Console.WriteLine("İçerik     : " + item.içerik);
                Console.WriteLine("Atanan Kişi: " + item.kisi);
                Console.WriteLine("Büyüklük   : " + item.size);
                Console.WriteLine("-");
            }
            Console.WriteLine("****** DONE Line ****** \n");
            foreach (var item in Board.cardsindone)
            {
                Console.WriteLine("Başlık     : " + item.başlık);
                Console.WriteLine("İçerik     : " + item.içerik);
                Console.WriteLine("Atanan Kişi: " + item.kisi);
                Console.WriteLine("Büyüklük   : " + item.size);
                Console.WriteLine("-");
            }

        }
    }
}
