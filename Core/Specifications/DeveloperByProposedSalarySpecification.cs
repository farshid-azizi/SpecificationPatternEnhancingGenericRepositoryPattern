using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
 
    public class DeveloperByProposedSalarySpecification : BaseSpecifcation<Developer>
    {
        public DeveloperByProposedSalarySpecification()
        {
            AddOrderByDescending(x => x.ProposedSalary);
        }
    }
}
