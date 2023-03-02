using InanToDo.Entities;
using InanToDo.Operations;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
        Console.WriteLine("*****************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Taşımak");
        Console.WriteLine("(5) Çıkış");


        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                ListOpp list = new ListOpp();
                break;
           
            case 2:
                AddOpp add = new AddOpp();
                break;
            
            case 3:
                DeleteOpp del = new();
                break;
           
            case 4:
                MoveOpp move = new MoveOpp();
                break;

            default:
                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                break;
        }
    }
}