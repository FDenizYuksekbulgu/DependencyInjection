
namespace DependencyInjectionProject.Models
{
    //Classroom, içinde bir öğretmen nesnesi barındırır.
    public class Classroom
    {
        private readonly ITeacher _teacher; //Dependency Injection için bağımlılık yaratalım.

        //Yapıcı metot ile bağımlılığı enjekte ediyoruz. (Constructor Injection)
        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        //Öğretmen bilgisini döndüren metot
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
