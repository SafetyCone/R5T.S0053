using System;

using R5T.T0131;


namespace R5T.S0053
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker
	{
        public string TemporarySolutionParent => @"C:\Temp\Solutions";
    }
}