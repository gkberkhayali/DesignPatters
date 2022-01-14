using RepositoryPatternCoreWebApi.DBModals;

namespace RepositoryPatternCoreWebApi.Interfaces
{
    public interface ICompaniesRepository
    {
        ICollection<Company> GetCompanies(List<int> IDs);
    }
}
