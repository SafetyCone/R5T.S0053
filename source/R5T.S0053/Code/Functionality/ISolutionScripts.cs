using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0053
{
	[FunctionalityMarker]
	public partial interface ISolutionScripts : IFunctionalityMarker
	{
		public async Task CreateWebBlazorClientAndServer()
		{
            /// Inputs.
            var solutionName =
                SolutionNames.Instance.Example
                ;

            var solutionDescription =
                SolutionDescriptions.Instance.Example
                ;


			/// Run.
            var solutionFileContext = await SolutionOperator.Instance.InClearedSolutionDirectoryPathInformationContext(
                DirectoryPaths.Instance.TemporarySolutionParent,
                solutionName,
                async solutionFileContext =>
                {
                    await F0085.SolutionFileOperations.Instance.CreateNew_VS2022(
                        solutionFileContext.SolutionFilePath);

                    // Create the console project.
                    var consoleProjectName = F0055.ProjectNameOperator.Instance.GetConsoleProjectName_FromSolutionName(solutionName);
                    var consoleProjectDescription = F0055.ProjectDescriptionOperator.Instance.GetConsoleProjectDescription_FromSolutionDescription(solutionDescription);

                    var projectFilePath = F0052.ProjectPathsOperator.Instance.GetProjectFilePath_FromSolutionDirectoryPath(
                        solutionFileContext.SolutionDirectoryPath,
                        consoleProjectName);

                    await Instances.ProjectOperations.CreateNewProject_Console(
                        projectFilePath,
                        solutionDescription);

                    F0024.SolutionFileOperator.Instance.AddProject(
                        solutionFileContext.SolutionFilePath,
                        projectFilePath);

                    // Add all dependency projects.
                    await F0063.SolutionOperations.Instance.AddMissingDependencies(
                        solutionFileContext.SolutionFilePath);
                });

            await F0088.VisualStudioOperator.Instance.OpenSolutionFile(solutionFileContext.SolutionFilePath);
        }

		public async Task CreateConsoleSolution()
		{
			/// Inputs.
			var solutionName =
				SolutionNames.Instance.Example
				;

			var solutionDescription =
				SolutionDescriptions.Instance.Example
				;


			/// Run.
			var solutionFileContext = await SolutionOperator.Instance.InClearedSolutionDirectoryPathInformationContext(
				DirectoryPaths.Instance.TemporarySolutionParent,
				solutionName,
				async solutionFileContext =>
				{
					await F0085.SolutionFileOperations.Instance.CreateNew_VS2022(
						solutionFileContext.SolutionFilePath);

					// Create the console project.
					var consoleProjectName = F0055.ProjectNameOperator.Instance.GetConsoleProjectName_FromSolutionName(solutionName);
					var consoleProjectDescription = F0055.ProjectDescriptionOperator.Instance.GetConsoleProjectDescription_FromSolutionDescription(solutionDescription);

					var projectFilePath = F0052.ProjectPathsOperator.Instance.GetProjectFilePath_FromSolutionDirectoryPath(
						solutionFileContext.SolutionDirectoryPath,
						consoleProjectName);

					await Instances.ProjectOperations.CreateNewProject_Console(
						projectFilePath,
						solutionDescription);

					F0024.SolutionFileOperator.Instance.AddProject(
						solutionFileContext.SolutionFilePath,
						projectFilePath);

					// Add all dependency projects.
					await F0063.SolutionOperations.Instance.AddMissingDependencies(
						solutionFileContext.SolutionFilePath);
				});

			await F0088.VisualStudioOperator.Instance.OpenSolutionFile(solutionFileContext.SolutionFilePath);
        }
	}
}