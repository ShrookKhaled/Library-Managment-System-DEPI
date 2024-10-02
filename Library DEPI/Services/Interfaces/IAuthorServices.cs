using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace Library_DEPI.Services.Interfaces
{
    public interface IAuthorServices
    {
        IEnumerable<Author> GetAll();
        IEnumerable<SelectListItem> SelectedItems();
        Author GetOne(int id);
        bool ExistsByName(string name, int? excludeId = null);
        bool create(Author author); 
        bool Update(int id, Author author);
        bool Delete(int id);
        bool IsExist(int id);
    }
}
