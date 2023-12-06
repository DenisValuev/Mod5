namespace Mod5
{
    internal class Program
    {
        //Задание 5.1.5 Ввод цвета с консоли 
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет красный");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет зеленый");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет бирюзовый");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            return color;
        }
        // Ввывод массива строк на консоль
        static void ShowArrayString(string[] array)
        {
            Console.WriteLine("Массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        // Ввывод массива строк на консоль
        static void ShowArrayInt(int[] array)
        {
            Console.WriteLine("Массив");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        //Задание 5.1.6 Ввод массима с клавиатуры
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        //Сорировка массива
        static int[] SortArray(int[] array) 
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            //Заданеи 5.1.1 Кортеж Имя и массив Блюд
            /*
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите Ваше имя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for(int i = 0; i < User.Dishes.Length; i++) 
            {
                Console.WriteLine("Введите любимое блюдо номер {0}",i + 1);
                User.Dishes[i] = Console.ReadLine();
            }       
            */
            //Задание 5.1.5 Ввод цвета с консоли
            /*
            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }
            
            // Вывод на консоль массив цветов
            ShowArrayString(favcolors);
            */
            //Задание 5.1.6 Ввод элементов массива с клавиатуры, сортировка, вывод на экран
            /*
            var array = new int[5];
            //Ввод массива
            array = GetArrayFromConsole();
            //Сортировка массива
            Console.WriteLine("Массив отсортирован по возрастанию");
            array = SortArray(array);
            //Вывод массива чисел
            ShowArrayInt(array);
            */

        }
    }
}