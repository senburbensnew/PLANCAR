using PLANCAR_DAO.Models;

namespace PLANCAR_DAO.IDAO
{
    public interface IDepartementDAO
    {
        Task<IEnumerable<Departement>> GetAllAsync();
        Task<Departement?> GetByIdAsync(int id);
        Task AddAsync(Departement product);
        Task UpdateAsync(Departement product);
        Task DeleteAsync(int id);
    }
}
