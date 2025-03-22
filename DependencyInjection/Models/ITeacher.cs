
namespace DependencyInjectionProject.Models
{
    //ITeacher arayüzü (interface)
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        //Öğretmen bilgisini döndüren metot
        string GetInfo();
    }
}
