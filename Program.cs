using System;

namespace Unit5_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data(UserInfo());
            
        }

        static bool Check(string num, out int correctNum) 
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum > 0) 
                { 
                    correctNum = intnum;
                    return false;
                }
                
            }
            {
                Console.WriteLine("Вы ввели неверное значение! Попробуйте ещё раз.");
                correctNum = 0;
                return true;
            }

        }

        static void Data((string name, string surname, int age, bool havepet, int colorNum) data)
        {
            Console.WriteLine("\nВаше имя - {0}", data.name);
            Console.WriteLine("Ваша фамилия - {0}", data.surname);
            Console.WriteLine("Ваш возраст - {0}", data.age);
            Console.WriteLine("Есть ли у вас питомец? - {0}", data.havepet);
            Console.WriteLine("Количество ваших любимых цветов - {0}", data.colorNum);
        }

        static (string name, string surname, int age, bool havePet, int colorNum) UserInfo()
        {
            (string name, string surname, int age, bool havePet, int colorNum) User;

            Console.Write("Введите ваше имя: ");
            User.name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            User.surname = Console.ReadLine();

            
            string age;
            int intAge;
            do
            {
                Console.Write("Сколько вам лет? Введите ответ цифрами. ");
                age = Console.ReadLine();
            } while (Check(age, out intAge));

            User.age = intAge;

            Console.Write("Есть ли у вас питомец? Да или Нет. ");
            var result = Console.ReadLine();

            string petNum;
            int intpetNum;
            if (result == "да")
            {
                User.havePet = true;
                do 
                { 
                    Console.Write("Сколько у вас питомцев?  ");
                    petNum = Console.ReadLine();
                }
                while (Check(petNum, out intpetNum));
                PetName(intpetNum);
            }
            else User.havePet = false;

            string colorNum;
            int intcolorNum;
            do
            {
                Console.Write("Сколько у вас любимых цветов? ");
                colorNum = Console.ReadLine();
            }
            while (Check(colorNum, out intcolorNum));
            User.colorNum = intcolorNum;
            FavColors(intcolorNum);

            return User;
        }

        static string[] FavColors(int num)
        {
            string[] colors = new string[num];
            Console.WriteLine("Введите {0} ваших любимых цвета: ", num);
            for (int i = 0; i < num; i++)
            {
                colors[i] = Console.ReadLine();

            }
            return colors;
        }

        static string[] PetName(int num) {
            string[] pets = new string[num];
            Console.WriteLine("Введите клички ваших питомцев: ");
            for (int i = 0; i < num; i++)
            {
                pets[i] = Console.ReadLine();
            }
            return pets;
        }
    }
}
