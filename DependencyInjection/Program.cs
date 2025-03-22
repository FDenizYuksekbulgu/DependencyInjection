using System;
using DependencyInjectionProject.Models;

class Program
{
    static void Main()
    {
        //Burada Teacher nesnesi olu�turulur. Teacher ben :)
        ITeacher teacher = new Teacher("Deniz", "Yuksekbulgu");

        //Burada Classroom nesnesine ��retmen nesnesi enjekte ediliyor.
        Classroom classroom = new Classroom(teacher);

        //Son olarak ��retmen bilgisi ekrana yazd�r�l�yor.
        Console.WriteLine(classroom.GetTeacherInfo());
    }
}
