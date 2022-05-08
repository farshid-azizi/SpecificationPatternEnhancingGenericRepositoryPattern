using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class DeveloperWithLevelNSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperWithLevelNSpecification(int level) : base(x => x.Level> 3)
        {
            AddOrderByDescending(x => x.ProposedSalary);
        }
    }
}
