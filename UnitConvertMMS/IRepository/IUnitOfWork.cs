using UnitConvertMMS.Data;

namespace UnitConvertMMS.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<UnitCategory> UnitCategories { get; }
        IGenericRepository<UnitRate> UnitRates { get; }
        Task Save();
    }
}
