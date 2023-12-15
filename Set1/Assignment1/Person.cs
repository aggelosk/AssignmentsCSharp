namespace Assignment1
{
    class Person
    {
        public int _age;

        public void setAge(int age){
            _age = age;
        }

        public void Greet(){
            Console.WriteLine("Hello There");
        }

    }

    class Student : Person
    {
        public void Study(){
            Console.WriteLine("I'm studying");
        }

        public void ShowAge(){
            Console.WriteLine($"My age is: {_age} years old");
        }

    }

    class Teacher : Person
    {
        public void Explain(){
            Console.WriteLine("I'm explaining");
        }
    }

    static class StudentProfessorTest
    {
        static void Main()
        {
            Person person = new Person();
            person.Greet();
    
            Student student = new Student();
            student.setAge(19);
            student.Greet();
            student.ShowAge();
    
            Teacher teacher = new Teacher();
            teacher.setAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}