using System;

namespace Test2
{
    abstract class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int Id,string Name,int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public abstract void Show();
        //public virtual void Show()
        //{
        //    Console.WriteLine($"Student Id: {Id}, Studen Name: {Name}, Student Age: {Age}");
        //}
   
    }
    class ItiStudent:Student
    {

        public string programName { get; set; }
        public int numOfCourses { get; set; }

        public ItiStudent(string programName, int numOfCourses,int Id,string Name,int Age):base(Id,Name,Age)
        {
            
            this.programName = programName;
            this.numOfCourses = numOfCourses;
        }
        public override void Show()
        {
            Console.WriteLine($"Iti Program Name: {programName} ,Iti NumOfCourses: {numOfCourses}");
        }
    }
    class masterStudent : Student
    {
        public string title { get; set; } 
        public string doctorName { get; set; }
        public masterStudent(string title, string doctorName ,int Id,string Name,int Age):base(Id,Name,Age)
        {
            this.title = title;
            this.doctorName = doctorName;
        }
        public override void Show()
        {
            Console.WriteLine($"Master Title: {title} ,Doctor Name: {doctorName}");
        }
    }

    class Test2
    {
        static void Main(string[] args)
        {

            Student St = new ItiStudent("FullStack", 8, 5, "Mina", 24);
            St.Show();
            ItiStudent Iti_1 = new ItiStudent("fullStack",7,1,"Mina",24);
            Iti_1.Show();
            masterStudent Master_1 = new masterStudent("English","Mohamed",3,"Mina",25);
            Master_1.Show();

 
        }
    }
}
