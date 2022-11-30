using System;


namespace R5T.S0053
{
	public class SolutionOperator : ISolutionOperator
	{
		#region Infrastructure

	    public static ISolutionOperator Instance { get; } = new SolutionOperator();

	    private SolutionOperator()
	    {
        }

	    #endregion
	}
}