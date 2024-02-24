using System;


class Program
{
    static void Main(string[] arg)
    {
        
        {
            
            List<Person> persons = new List<Person>();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<NonTeachingStaff> nonTeachingStaff = new List<NonTeachingStaff>();
            SchoolManager schoolManager = new SchoolManager(persons,students,teachers,nonTeachingStaff);

            schoolManager.Start();
            
        
        }
    }    
}