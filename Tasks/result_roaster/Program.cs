using System;

namespace result_roaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int numberOfStudents = rng.Next(50, 70);
            int passed = 0;
            int average = 0;
            int failed = 0;
            int[] grades = new int[numberOfStudents];
            for(int i =0; i <numberOfStudents; i++)
            {
                int grade = rng.Next(1,100);
                grades[i] = grade;

                if(grade >= 70)
                {
                    passed += 1;
                }
                else if(grade >=50 )
                {
                    average += 1;
                }
                else
                {
                    failed += 1;
                }
            }
            Console.WriteLine("There are " + numberOfStudents + " students in this class");
            Console.WriteLine(passed + " students passed with 70 and above");
            Console.WriteLine(average + " students had between 50 amd 69");
            Console.WriteLine(failed + " students failed");
            for(int i=0; i<numberOfStudents; i++)
            {
                Console.Write(grades[i]+ ", ");
            }            
        }
    }
}
