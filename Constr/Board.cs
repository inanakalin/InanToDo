using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InanToDo.Constr
{
    internal class Board
    {
        public static List<Card> cardsinprogg = new List<Card>(); // böyle yapınca stackowerflow hatası almıyorum ama proprty olunca alıyorum ?
        public static List<Card> cardsintodo = new List<Card>();
        public static List<Card> cardsindone = new List<Card>();
        public static List<Card> cardsall = new List<Card>();



    }
}
