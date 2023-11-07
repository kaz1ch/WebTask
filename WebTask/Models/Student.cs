using Microsoft.AspNetCore.Mvc;

namespace WebTask.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patr { get; set; }
        public int Age { get; set; }
        public double Rating { get; set; }
        public int GroupId { get; set; }


        public Student()
        {
            LastName = "Иванов";
            Name = "Иван";
            Patr = "Иванович";
            Rating = 0.0;
            Id = 0;
        }

        public Student(int ID, string Last, string First, string Patronymic, double rating, int age, int groupId)
        {
            Id = ID;
            LastName = Last;
            Name = First;
            Patr = Patronymic;
            Rating = rating;
            Age = age;
            GroupId = groupId;
        }

        public void Deconstruct(out string Last, out string First, out string Patronymic)
        {
            Last = LastName;
            First = Name;
            Patronymic = Patr;
        }
    }
}
