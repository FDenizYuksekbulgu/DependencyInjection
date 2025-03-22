using System;
using DependencyInjectionProject.Models;

class Program
{
    static void Main()
    {
        //Burada Teacher nesnesi oluþturulur. Teacher ben :)
        ITeacher teacher = new Teacher("Deniz", "Yuksekbulgu");

        //Burada Classroom nesnesine öðretmen nesnesi enjekte ediliyor.
        Classroom classroom = new Classroom(teacher);

        //Son olarak Öðretmen bilgisi ekrana yazdýrýlýyor.
        Console.WriteLine(classroom.GetTeacherInfo());
    }
}
