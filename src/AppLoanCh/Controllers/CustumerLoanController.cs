using AutoMapper;
using Loan.Business.Interfaces.IServices;
using Loan.Business.Models;
using Loan.Business.ResponseModel;
using LoanApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoanApp.Controllers
{
    [ApiController]
    [Route("custumer-loan")]
    public class CustumerLoanController : ControllerBase
    {
        private readonly ILoanService _loanService;

        private readonly ILogger<CustumerLoanController> _logger;
        private readonly IMapper _mapper;

        public CustumerLoanController(ILogger<CustumerLoanController> logger, ILoanService loanService, IMapper mapper)
        {
            _logger = logger;
            _loanService = loanService;
            _mapper = mapper;
        }

        [HttpPost(Name = "loanTypeByClient")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<ResponseServiceCustumerLoan>> Post(ClientViewModel clientViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            return _loanService.GetAllLoansForClient(_mapper.Map<Client>(clientViewModel));
        }
    }
}