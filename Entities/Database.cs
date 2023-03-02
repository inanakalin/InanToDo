using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using InanToDo.Constr;

namespace InanToDo.Entities
{
    internal class Database
    {
        public static Dictionary<int, string> personlist = new Dictionary<int, string>();
        public Database()
        {
            personlist.Add(1, "İnan Akalın");
            personlist.Add(2, "Fırat Sağ");
            personlist.Add(3, "Nazlı Nazlıcan Akalın");
            personlist.Add(4, "Ebrar Bilican");
            personlist.Add(5, "Leyla Lili");

            AddCards("Toplantı", "Haftalık genel", personlist[5], EnSize.XS, "2");
            AddCards("Ev Kiralama", "fiyat analizi", personlist[2], EnSize.L, "1");
            AddCards("Alışveriş", "Mutfak Alışverişi", personlist[3], EnSize.M, "3");
        }
        public static void AddCards(string title, string content, string member, EnSize size, string line)
        {
            Card card1 = new Card();
            card1.başlık = title;
            card1.içerik = content;
            card1.kisi = member;
            card1.size = size;
            card1.line = line;

            Board.cardsall.Add(card1);

            foreach (var linesorgu in Board.cardsall)
            {
                if (linesorgu.line == "3" || linesorgu.line.ToLower() == "done")
                {
                    Board.cardsindone.Add(linesorgu);
                    Board.cardsall.Remove(linesorgu);
                    break;
                }
                else if (linesorgu.line == "2" || linesorgu.line.ToLower() == "inprog")
                {
                    Board.cardsinprogg.Add(linesorgu);
                    Board.cardsall.Remove(linesorgu);
                    break;
                }
                else if (linesorgu.line == "1" || linesorgu.line.ToLower() == "todo")
                {
                    Board.cardsintodo.Add(linesorgu);
                    Board.cardsall.Remove(linesorgu);
                    break;
                }
                else if (linesorgu.line == null)
                {
                    Console.WriteLine("line is null");
                }
                else
                {
                    Console.WriteLine("Line yazımında bir yanlış var");
                }
            }
        }
    }
}
