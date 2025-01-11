using WEB._Obj;

namespace WEB.Repository.Intarfaces
{
    public interface IAuthorRepository
    {
        Task<Author> GetAllAsync();


    }
}
