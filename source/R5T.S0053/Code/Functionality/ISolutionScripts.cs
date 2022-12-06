using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0053
{
	[FunctionalityMarker]
	public partial interface ISolutionScripts : IFunctionalityMarker
	{
        public async Task AddProjectToSolution_RazorClassLibrary()
        {
            /// Inputs
            var solutionFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0065.Private\source\R5T.E0065.Private.sln";
            var projectName = "R5T.E0065.R002";
            var projectDescription = "An example Razor class library.";


            /// Run.
            await F0087.SolutionOperations.Instance.AddProjectToSolution_RazorClassLibrary(
                solutionFilePath,
                projectName,
                projectDescription);
        }

        public async Task CreateWebStaticRazorComponents()
        {
            /// Inputs.
            var libraryContext =
                Instances.LibraryContexts.Example
                ;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.Create_WebStaticRazorComponents(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task CreateWebBlazorClientAndServer()
        {
            /// Inputs.
            var libraryContext =
                Instances.LibraryContexts.Example
                ;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.Create_WebBlazorClientAndServer(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task CreateConsoleWithLibrarySolution()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.Create_ConsoleWithLibrarySolution(
                libraryContext,
                isPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task CreateRazorClassLibrarySolution()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.Create_RazorClassLibrarySolution(
                libraryContext,
                solutionContext);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task CreateSolution_Console()
		{
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.CreateSolution_Console(
                libraryContext,
                isPrivate,
                repositoryDirectoryPath);

			F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }
	}
}