namespace Mod5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заданеи 5.1
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите Ваше имя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for(int i = 0; i < User.Dishes.Length; i++) 
            {
                Console.WriteLine("Введите любимое блюдо номер {0}",i + 1);
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}