using System;

using R5T.T0131;


namespace R5T.S0053
{
	[ValuesMarker]
	public partial interface ISolutionDescriptions : IValuesMarker
	{
		public string Example => "An example solution.";
	}
}