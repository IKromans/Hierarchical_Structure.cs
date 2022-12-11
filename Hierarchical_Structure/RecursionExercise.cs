using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Structure
{
    internal class RecursionExercise
    {
        static public void Main(String[] args)
        {
            CountBranches countBranches = new CountBranches();

            Branch branchKS = new Branch(new List<Branch>());
            Branch branchDH = new Branch(new List<Branch>());
            Branch branchDK = new Branch(new List<Branch>());
            Branch branchGM = new Branch(new List<Branch>());
            Branch branchFG = new Branch(new List<Branch>());
            Branch branchFD = new Branch(new List<Branch>());
            Branch branchFE = new Branch(new List<Branch>());
            Branch branchAF = new Branch(new List<Branch>());
            Branch branchBC = new Branch(new List<Branch>());
            Branch branchAB = new Branch(new List<Branch>());
            Branch branchA = new Branch(new List<Branch>());

            branchDK.GetBranches().Add(branchKS);
            branchFD.GetBranches().Add(branchDK);
            branchFD.GetBranches().Add(branchDH);
            branchFG.GetBranches().Add(branchGM);
            branchAF.GetBranches().Add(branchFG);
            branchAF.GetBranches().Add(branchFD);
            branchAF.GetBranches().Add(branchFE);
            branchAB.GetBranches().Add(branchBC);
            branchA.GetBranches().Add(branchAB);
            branchA.GetBranches().Add(branchAF);


            Console.WriteLine("This structure depth is: " + countBranches.CountNextBranches(branchA) + " levels.");
        }
    }
}
