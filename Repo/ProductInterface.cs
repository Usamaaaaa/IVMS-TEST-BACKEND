using Backend.Model;

namespace Backend.Repo
{
    public interface ProductInterface
    {

        Task<List<Products>> GetAll();

        Task<Products> GetById(int id);

        Task<string> Create(Products product);

        Task<string>  Update(Products product, int id);

        Task<string>  Remove(int id);
      
    }
}
