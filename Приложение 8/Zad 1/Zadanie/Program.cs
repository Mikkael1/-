using System;

namespace EmployeeBonus
{
    enum Post
    {
        Manager = 160,
        Programmer = 180,
        Developer = 180,
        Designer = 200
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();

            Post manager = Post.Manager;
            Console.Write("Введите количество отработанных часов менеджера: ");
            int managerHours = Convert.ToInt32(Console.ReadLine());
            bool managerBonus = accountant.AskForBonus(manager, managerHours);
            Console.WriteLine($"Менеджер отработал {managerHours} часов{(managerBonus ? ", ему положена премия" : ", ему не положена премия")}");

            Post programmer = Post.Programmer;
            Console.Write("Введите количество отработанных часов программиста: ");
            int programmerHours = Convert.ToInt32(Console.ReadLine());
            bool programmerBonus = accountant.AskForBonus(programmer, programmerHours);
            Console.WriteLine($"Программист отработал {programmerHours} часов{(programmerBonus ? ", ему положена премия" : ", ему не положена премия")}");

            Post designer = Post.Designer;
            Console.Write("Введите количество отработанных часов дизайнера: ");
            int designerHours = Convert.ToInt32(Console.ReadLine());
            bool designerBonus = accountant.AskForBonus(designer, designerHours);
            Console.WriteLine($"Дизайнер отработал {designerHours} часов{(designerBonus ? ", ему положена премия" : ", ему не положена премия")}");

            Post developer = Post.Manager;
            Console.Write("Введите количество отработанных часов разработчика: ");
            int developerHours = Convert.ToInt32(Console.ReadLine());
            bool developerBonus = accountant.AskForBonus(developer, developerHours);
            Console.WriteLine($"Разработчик отработал {developerHours} часов{(developerBonus ? ", ему положена премия" : ", ему не положена премия")}");

            Console.ReadKey();
        }
    }
}