namespace CIT_195_Lesson_5_Sealed_Class
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }
    sealed class Executive : Employee 
    {
        public string Title { get; set; }
        public int Salary { get; set; }
        public Executive()
        {
            Title = string.Empty;
            Salary = 0;
        }
        public Executive(int Id, string FirstName, string LastName, string title, int salary)
            :base (Id, FirstName, LastName)
        {
            Title = title;
            Salary = salary;
        }
        public override double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee schlub = new Employee(114, "Peter", "Peon");
            double schlubSalary = schlub.Pay();
            Console.WriteLine($"{schlub.Fullname()} makes a paltry {schlubSalary} a week for his efforts.");

            Executive jerk = new Executive(101, "Terry", "Tyrant", "Chief Clueless Officer", 250000);
            Console.WriteLine($"{jerk.Title} {jerk.Fullname()} lives the high life with his {jerk.Salary} annual salary.");
        }
    }
}
