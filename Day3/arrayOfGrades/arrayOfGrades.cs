using System;


namespace arrayOfGrades
{
    class arrayOfGrades
    {
        static void Main(string[] args)
        {
            int Sum=0;
            int Avg=0;
            Console.WriteLine("Enter num of student");
            int numOfStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num of subject");
            int studentDegree = int.Parse(Console.ReadLine());
            int[ , ] student = new int[numOfStudent,studentDegree];

            for (int i = 0; i < student.GetLength(0); i++)
            {
                for (int j = 0; j < student.GetLength(1); j++)
                {
                    Console.WriteLine($"enter degree of student {i + 1} in subject{j + 1}");
                    student[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < student.GetLength(0); i++)
            {
                
                for (int j = 0; j < student.GetLength(1); j++)
                {
                    Sum += student[j, i];
                    
                    
                }
                Console.WriteLine($"Sum of student degree : {Sum}");
                Console.WriteLine($"Avg of student grades : {Sum / student.GetLength(0)}");
                Sum = 0;

            }

        }
    }
}
