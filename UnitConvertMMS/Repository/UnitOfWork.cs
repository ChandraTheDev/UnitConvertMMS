using UnitConvertMMS.Data;
using UnitConvertMMS.IRepository;

namespace UnitConvertMMS.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<UnitCategory> _unitCategories { get; }
        private IGenericRepository<UnitRate> _unitRates { get; }
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<UnitCategory> UnitCategories => _unitCategories != null ? _unitCategories : new GenericRepository<UnitCategory>(_context);

        public IGenericRepository<UnitRate> UnitRates => _unitRates != null ? _unitRates : new GenericRepository<UnitRate>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
