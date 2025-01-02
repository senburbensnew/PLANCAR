
using PLANCAR_DTO.DTO;

namespace PLANCAR_REPOSITORY.IDAO
{
    public interface IDAODepartement
    {
        Task<IEnumerable<Departement>> GetAllAsync();
        Task<Departement?> GetByIdAsync(int id);
        Task AddAsync(Departement product);
        Task UpdateAsync(Departement product);
        Task DeleteAsync(int id);
    }
}
