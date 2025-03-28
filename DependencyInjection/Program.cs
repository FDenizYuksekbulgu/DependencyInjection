using System;
using DependencyInjectionProject.Models;

class Program
{
    static void Main()
    {
        //Burada Teacher nesnesi oluşturulur. Teacher ben :)
        ITeacher teacher = new Teacher("Deniz", "Yuksekbulgu");

        //Burada Classroom nesnesine öğretmen nesnesi enjekte ediliyor.
        Classroom classroom = new Classroom(teacher);

        //Son olarak Öğretmen bilgisi ekrana yazdırılıyor.
        Console.WriteLine(classroom.GetTeacherInfo());
    }
}
