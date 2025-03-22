
namespace DependencyInjectionProject.Models
{
    //Teacher sınıfı ITeacher interface'ini uygular.
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor (Yapıcı Metot)
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //Öğretmenin adını ve soyadını döndüren metot
        public string GetInfo()
        {
            return $"Teacher: {FirstName} {LastName}";
        }
    }
}
