using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Business.Models
{
    public class Client
    {
        public int Age { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public double Income { get; set; }
        public string Location { get; set; }
    }
}
