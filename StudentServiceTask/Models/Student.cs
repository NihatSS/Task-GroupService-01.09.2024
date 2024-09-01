namespace StudentServiceTask.Models
{
    internal class Student
    {
        public int code = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, int age)
        {
            code++;
            Name = name;
            Surname = surname;
            Age = age;
        }
        public override string ToString()
        {
            return $"{code} {Name} {Surname} {Age}";
        }

    }
}
