using System;
using System.Threading.Tasks;

using R5T.F0085;
using R5T.F0085.T001;
using R5T.T0132;


namespace R5T.S0053
{
	[FunctionalityMarker]
	public partial interface ISolutionOperator : IFunctionalityMarker
	{
        public async Task<SolutionFileContext> InClearedSolutionDirectoryPathInformationContext(
            string solutionDirectoryPath,
            string solutionName,
            Func<SolutionFileContext, Task> solutionFileContextAction)
        {
            SolutionFileContext solutionFileContext = default;

            async Task Internal(string solutionDirectoryPath)
            {
                var solutionFilePath = F0050.SolutionPathsOperator.Instance.Get_SolutionFilePath(
                    solutionDirectoryPath,
                    solutionName);

                solutionFileContext = new SolutionFileContext
                {
                    SolutionDirectoryPath = solutionDirectoryPath,
                    SolutionFilePath = solutionFilePath,
                };

                await solutionFileContextAction(solutionFileContext);
            }

            await F0000.FileSystemOperator.Instance.InClearedDirectoryContext(
                solutionDirectoryPath,
                Internal);

            return solutionFileContext;
        }

        public async Task<SolutionFileContext> InClearedSolutionDirectoryPathInformationContext_UsingSolutionName(
            string parentDirectoryPath,
            string solutionName,
            Func<SolutionFileContext, Task> solutionFileContextAction)
        {
            var solutionDirectoryName = F0050.DirectoryNames.Instance.Source;

            var solutionDirectoryPath = F0002.PathOperator.Instance.Get_DirectoryPath(
                parentDirectoryPath,
                solutionDirectoryName);

            SolutionFileContext solutionFileContext = default;

            async Task Internal(string solutionDirectoryPath)
            {
                var solutionFilePath = F0050.SolutionPathsOperator.Instance.Get_SolutionFilePath(
                    solutionDirectoryPath,
                    solutionName);

                solutionFileContext = new SolutionFileContext
                {
                    SolutionDirectoryPath = solutionDirectoryPath,
                    SolutionFilePath = solutionFilePath,
                };

                await solutionFileContextAction(solutionFileContext);
            }

            await F0000.FileSystemOperator.Instance.InClearedDirectoryContext(
                solutionDirectoryPath,
                Internal);

            return solutionFileContext;
        }
    }
}