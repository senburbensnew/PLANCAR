
using Microsoft.EntityFrameworkCore;
using PLANCAR_DTO.DTO;
using PLANCAR_REPOSITORY.IDAO;

namespace PLANCAR_REPOSITORY.DAOEFC.DAO
{
    public class Departement_DAOEFC : IDAODepartement
    {
        private readonly PlancarContext _context;

        public Departement_DAOEFC(PlancarContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Departement>> GetAllAsync()
        {
            return await _context.Set<Departement>().ToListAsync();
        }

        public async Task<Departement?> GetByIdAsync(int id)
        {
            return await _context.Set<Departement>().FindAsync(id);
        }

        public async Task AddAsync(Departement departement)
        {
            await _context.Set<Departement>().AddAsync(departement);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Departement departement)
        {
            _context.Set<Departement>().Update(departement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var departement = await GetByIdAsync(id);
            if (departement != null)
            {
                _context.Set<Departement>().Remove(departement);
                await _context.SaveChangesAsync();
            }
        }
    }
}
