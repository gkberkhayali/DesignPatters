using RepositoryPatternCoreWebApi.Data;
using RepositoryPatternCoreWebApi.DBModals;
using RepositoryPatternCoreWebApi.Interfaces;
using System.Linq;


namespace RepositoryPatternCoreWebApi.Repository
{
    public class CompaniesRepository : ICompaniesRepository
    {
        //private DataContext _context;

        //public CompaniesRepository(DataContext context)
        //{
        //    _context = context;
        //}

        public ICollection<Company> GetCompanies(List<int> IDs)
        {
            //Normally you should entegrate your db through datacontext class. For the moment I will just return
            //Sample data as it comes from repository. Reason for this is because this is repository design pattern self study. 
            //Important thing here is structure.

            //return _context.Companies.OrderBy( x => x.ID).ToList();

            List<Company> companies = new List<Company>();
            companies.Add(new Company { ID = 1, Name = "Company1" });
            companies.Add(new Company { ID = 2, Name = "Company2" });
            companies.Add(new Company { ID = 3, Name = "Company3" });
            
            if(IDs != null && IDs.Count >0 )
            {
                return companies.FindAll(x => IDs.Contains(x.ID));
            }

            return companies;
    
        }
    }
}
