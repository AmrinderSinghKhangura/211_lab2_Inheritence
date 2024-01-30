namespace _211Lab2Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employees = File.ReadAllLines("C:\\Users\\amrin\\Desktop\\CPRG_211_F\\211Lab2Inheritence\\211Lab2Inheritence\\res\\employees (1).txt");
            List<Employee> employeesList = new List<Employee>();
            foreach (string employee in employees)
            {
                string[] s  = employee.Split(':');
                string x = s[0];
                int y = x[0] - '0';
                if (y < 5) 
                {
                    Salaried n = new Salaried(s[0], s[1], s[2], s[3], long.Parse(s[4]), s[5], s[6], double.Parse(s[7]));
                    employeesList.Add(n);
                }
                else if (y < 8) 
                {
                    Wages n = new Wages(s[0], s[1], s[2], s[3], long.Parse(s[4]), s[5], s[6], double.Parse(s[7]), double.Parse(s[8]));
                    employeesList.Add(n);
                } else
                {
                    PartTime n = new PartTime(s[0], s[1], s[2], s[3], long.Parse(s[4]), s[5], s[6], double.Parse(s[7]), double.Parse(s[8]));
                    employeesList.Add(n);
                }
            
            }
            double total = 0;
            foreach (Employee n in employeesList)
            {
                total += (n.GetPay());
            }
            double average = total/employeesList.Count;
            Console.WriteLine($"Average weekly pay: {average}");

            double max = 0;
            string name = "";
            foreach (Employee n in employeesList)
            {
                if (n is Wages)
                {
                    if (n.GetPay() > max) 
                    {
                        max = n.GetPay();
                        name = n.GetName();
                    }
                }
            }
            Console.WriteLine($"{name} has the highest weekly  wage pay of {max}");

            double min = 9999999999999999999999999999999.0;
            foreach (Employee n in employeesList)
            {
                if (n is Salaried)
                {
                    if (n.GetPay() < min)
                    {
                        min = n.GetPay();
                        name = n.GetName();
                    }
                }
            }
            Console.WriteLine($"{name} has the lowest weekly salary of {min}");
            double salCounter = 0;
            double wageCounter = 0;
            double partCounter = 0;
            foreach (Employee n in employeesList)
            {
                if (n is Salaried) { salCounter++; }
                else if (n is Wages) { wageCounter++; }
                else if(n is PartTime) { partCounter++; }
            }
            Console.WriteLine($"{salCounter / employeesList.Count * 100}% of people are salaried.\n" +
                $"{wageCounter / employeesList.Count * 100}% of people on wage.\n" +
                $"{partCounter / employeesList.Count * 100}% of people are part time.");
            
            Console.ReadLine();
        }
    }
}
