using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using InanToDo.Entities;

namespace InanToDo.Constr
{
    internal class Card
    {
        public string başlık { get; set; }
        public string içerik { get; set; }
        public string kisi { get; set; }
        public EnSize size { get; set; }
        public string line { get; set; }

    }
}
