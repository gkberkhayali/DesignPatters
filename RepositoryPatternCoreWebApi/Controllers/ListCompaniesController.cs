using Microsoft.AspNetCore.Mvc;
using RepositoryPatternCoreWebApi.DBModals;
using RepositoryPatternCoreWebApi.GenericModals;
using RepositoryPatternCoreWebApi.Interfaces;
using RepositoryPatternCoreWebApi.RequestModals;

namespace RepositoryPatternCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListCompaniesController : ControllerBase
    {
     
        private readonly ILogger<ListCompaniesController> _logger;
        private readonly ICompaniesRepository _companiesRepository;


        public ListCompaniesController(ILogger<ListCompaniesController> logger, ICompaniesRepository companiesRepository)
        {
            _logger = logger;
            _companiesRepository = companiesRepository;
        }

        [HttpGet(Name = "ListCompanies")]
        public ResponseModal<Company> Get(ListCompaniesRequestModal requestData)
        {
            ResponseModal<Company> result = new ResponseModal<Company>();
            var companies = _companiesRepository.GetCompanies(requestData.IDs);
            result.SetDataList(companies.ToList());

            return result;
        }

        //Sample PostCall
        [HttpPost(Name = "ListCompaniesPost")]
        public ResponseModal<Company> Post(ListCompaniesRequestModal requestData)
        {
            ResponseModal<Company> result = new ResponseModal<Company>();
            var companies = _companiesRepository.GetCompanies(requestData.IDs);
            result.SetDataList(companies.ToList());

            return result;
        }
    }
}
