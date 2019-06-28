using System;


namespace structEmployee
{
    struct Employee
    {
        int id;
        string name;
        int age;
        decimal salary;

        public Employee(int _id, int _age, string _name, decimal _salary)
        {
            id = _id;
            age = _age;
            salary = _salary;
            name = _name;
            
        }

        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            id = _id;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int _age)
        {
            age = _age;
        }
        public decimal getSalary()
        {
            return salary;
        }
        public void setSalary(decimal _salary)
        {
            salary = _salary;
        }
        public void Print()
        {
            Console.WriteLine($"name:{name} , salary: {salary} id:{id},age:{age}");
        }
    }
    class structEmployee
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee(1,24,"Mina",5000);
            //emp1.Print();

            Employee emp2 = new Employee();
            Console.WriteLine("Enter Emp Id: ");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Emp age: ");
            int empAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Emp name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Emp salary: ");
            int empSalary = int.Parse(Console.ReadLine());
            emp2.setId(empId);
            emp2.setName(empName);
            emp2.setAge(empAge);
            emp2.setSalary(empSalary);
            emp2.Print();

        }
    }
}
