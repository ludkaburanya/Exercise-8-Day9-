namespace z1
{

    class program
    {
        enum employees
        {
            Director = 100,
            Accountant = 80,
            Engineer = 70,
            Manager = 90
        }

        static string GetPremium(employees worker, int hours)
        {
            if ((int)worker < hours)
            {
                return "Сотрудник отработал больше положенных часов в месяц, ему нужно начислить премию!";
            }

            return "Сотрудник  не отработал больше положенных часов в месяц, не нужно начислять ему премию.";

        }
        static void Main()
        {
            Console.WriteLine("Выберите вашу должность: \n1. Директор \n2. Бухгалтер \n3. Инженер \n4. Менеджер");
            int workNumber = int.Parse(Console.ReadLine());
            var workers = Enum.GetValues(typeof(employees)).Cast<employees>().ToList();
            var worker = workers[workNumber - 1];

            Console.WriteLine("Введите количество рабочих часов");
            int hours = int.Parse(Console.ReadLine());
            var message = GetPremium(worker, hours);
            Console.WriteLine(message);
        }
    }
}