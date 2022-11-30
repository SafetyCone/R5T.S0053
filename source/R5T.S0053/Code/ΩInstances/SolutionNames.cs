using System;


namespace R5T.S0053
{
	public class SolutionNames : ISolutionNames
	{
		#region Infrastructure

	    public static ISolutionNames Instance { get; } = new SolutionNames();

	    private SolutionNames()
	    {
        }

	    #endregion
	}
}