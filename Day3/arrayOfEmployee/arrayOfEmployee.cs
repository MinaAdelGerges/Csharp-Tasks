using System;


namespace arrayOfEmployee
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
    class arrayOfEmployee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Employees");
            int size = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[size];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter id of emp{i+1}: ");
                employees[i].setId(int.Parse(Console.ReadLine()));

                Console.WriteLine($"Enter Name of emp{i + 1}: ");
                employees[i].setName(Console.ReadLine());

                Console.WriteLine($"Enter age of emp{i + 1}: ");
                employees[i].setAge(int.Parse(Console.ReadLine()));

                Console.WriteLine($"Enter Salary of emp{i + 1}: ");
                employees[i].setSalary(decimal.Parse(Console.ReadLine()));


            }
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Print();
            }

        }
    }
}
