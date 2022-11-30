using System;


namespace R5T.S0053
{
    public static class Instances
    {
        public static F0084.IProjectOperations ProjectOperations { get; set; } = F0084.ProjectOperations.Instance;
        public static F0050.ISolutionPathsOperator SolutionPathsOperator { get; set; } = F0050.SolutionPathsOperator.Instance;
    }
}