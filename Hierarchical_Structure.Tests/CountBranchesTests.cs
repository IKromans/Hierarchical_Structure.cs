using Hierarchical_Structure;

namespace Tests
{
    public class CountBranchesTests
    {
        private CountBranches countBranches = new CountBranches();

        [Fact]
        void TestWhenNextBranchIsNull()
        {
            Branch branch = new(null);
            int expected = 0;
            int actual = countBranches.CountNextBranches(branch);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void TestWhenOnlyTwoChildBranches()
        {
            Branch branchBE = new(new List<Branch>());
            Branch branchBC = new (new List<Branch>());
            Branch branchAB = new (new List<Branch>());
            Branch branchAF = new (new List<Branch>());
            Branch branch = new (new List<Branch>());
            branchAB.GetBranches().Add(branchBE);
            branchAB.GetBranches().Add(branchBC);
            branch.GetBranches().Add(branchAB);
            branch.GetBranches().Add(branchAF);
            int expected = 3;
            int actual = countBranches.CountNextBranches(branch);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void TestWhenMoreThanTwoChildBranches()
        {
            Branch branchAC = new (new List<Branch>());
            Branch branchAE = new (new List<Branch>());
            Branch branchAB = new (new List<Branch>());
            Branch branchAF = new (new List<Branch>());
            Branch branch = new (new List<Branch>());
            branch.GetBranches().Add(branchAE);
            branch.GetBranches().Add(branchAC);
            branch.GetBranches().Add(branchAB);
            branch.GetBranches().Add(branchAF);
            int expected = 2;
            int actual = countBranches.CountNextBranches(branch);
            Assert.Equal(expected, actual);
        }
    }
}