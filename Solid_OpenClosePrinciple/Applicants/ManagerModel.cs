using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_OpenClosePrinciple
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
