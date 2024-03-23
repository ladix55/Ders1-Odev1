using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2024.Entities
{
    public class IndividualCustomer:BaseCustomer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }

    }
}
