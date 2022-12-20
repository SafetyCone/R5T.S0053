using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0153;

namespace R5T.S0053
{
	[FunctionalityMarker]
	public partial interface ISolutionScripts : IFunctionalityMarker
	{
        public async Task New_WindowFormsApplication()
        {
            /// Inputs.
            var libraryContext =
                Instances.LibraryContexts.Example
                ;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            // Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_WindowsFormsApplication(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

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

        public async Task AddProjectToSolution_Library()
        {
            /// Inputs
            var solutionFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0028\source\R5T.L0028.Construction.sln";
            var projectName = "R5T.L0028.T001";
            var projectDescription = "Strong types for deployment functionality.";


            /// Run.
            await F0087.SolutionOperations.Instance.AddProjectToSolution_Library(
                solutionFilePath,
                projectName,
                projectDescription);
        }

        public async Task New_WebStaticRazorComponents()
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

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_WebStaticRazorComponents(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_WebBlazorClientAndServer()
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

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_WebBlazorClientAndServer(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_ConsoleWithLibrary()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_ConsoleWithLibrary(
                libraryContext,
                isPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_RazorClassLibrarySolution()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_RazorClassLibrary(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_Console()
		{
            /// Inputs.
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                //Instances.LibraryContexts.Example
                new LibraryContext
                {
                    LibraryName = "R5T.S0060.S003",
                    LibraryDescription = "Send an email."
                }
                ;
            var isPrivate = false;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\"
                ;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            if(deleteSolutionDirectoryForConstruction)
            {
                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_Console(
                libraryContext,
                isPrivate,
                repositoryDirectoryPath);

			F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_DeployScripts()
        {
            /// Inputs.
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                //Instances.LibraryContexts.Example
                new LibraryContext
                {
                    LibraryName = "R5T.S0060.Deploy",
                    LibraryDescription = "Deployment script for R5T.S0060 projects."
                }
                ;
            var targetProjectName = "R5T.S0060";
            var isPrivate = false;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\"
                //@"C:\Code\DEV\Git\GitHub\davidcoats\D8S.C0002.Private\"
                ;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            if(deleteSolutionDirectoryForConstruction)
            {
                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_DeployScripts(
                libraryContext,
                isPrivate,
                repositoryDirectoryPath,
                targetProjectName);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }
    }
}