using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        
        public virtual void Show()
        {
            Console.WriteLine($"Student Id: {Id}, Studen Name: {Name}, Student Age: {Age}");
        }

    }
    class ItiStudent : Student
    {

        public string programName { get; set; }
        public int numOfCourses { get; set; }

        public ItiStudent(string programName, int numOfCourses, int Id, string Name, int Age) : base(Id, Name, Age)
        {

            this.programName = programName;
            this.numOfCourses = numOfCourses;
        }
        public override void Show()
        {
            Console.WriteLine($"Iti Program Name: {programName} ,Iti NumOfCourses: {numOfCourses}, Id:{Id}, Name:{Name} Age: {Age}, Id:{Id}");
        }
    }
    class masterStudent : Student
    {
        public string title { get; set; }
        public string doctorName { get; set; }
        public masterStudent(string title, string doctorName, int Id, string Name, int Age) : base(Id, Name, Age)
        {
            this.title = title;
            this.doctorName = doctorName;
        }
        public new void Show()
        {
            Console.WriteLine($"Master Title: {title} ,Doctor Name: {doctorName}, Student name: {Name}, Age:{Age},Id: {Id}");
        }
    }
    class student
    {
        static void Main(string[] args)
        {
            Student St = new ItiStudent("FullStack", 6, 1, "Mina", 24);
            St.Show();
            ItiStudent Iti_1 = new ItiStudent(".Net fullStack", 7, 2, "Ali", 25);
            Iti_1.Show();
            masterStudent Master_1 = new masterStudent("English", "Mohamed", 3, "Mohamed", 26);
            Master_1.Show();

        }
    }
}
