using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hierarchical_Structure
{
    public class Branch
    {
        private readonly List<Branch> branches;

        public Branch(List<Branch> branches)
        {
            this.branches = branches;
        }

        public List<Branch> GetBranches()
        {
            return branches;
        }
    }
}
