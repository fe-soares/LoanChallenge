using AutoMapper;
using Loan.Business.Models;
using LoanApp.ViewModels;

namespace AppLoanCh.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Client, ClientViewModel>().ReverseMap();
        }
    }
}
