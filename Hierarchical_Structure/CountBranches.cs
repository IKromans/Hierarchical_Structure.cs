using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Structure
{
    public class CountBranches
    {
        public int CountNextBranches(Branch branch)
        {
            if (branch.GetBranches() != null)
            {
                int levelCount = 0;
                foreach (Branch branches in branch.GetBranches())
                {
                    int childLevelCount = CountNextBranches(branches);
                    levelCount = Math.Max(levelCount, childLevelCount);
                }
                return levelCount + 1;
            }
            return 0;
        }
    }
}