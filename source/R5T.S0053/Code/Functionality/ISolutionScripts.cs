using System;
using System.Threading.Tasks;

using LibGit2Sharp;

using R5T.T0132;
using R5T.T0153;


namespace R5T.S0053
{
	[FunctionalityMarker]
	public partial interface ISolutionScripts : IFunctionalityMarker
	{
        /// <summary>
        /// Generates a blog web application solution.
        /// A blog is a web application using:
        /// * Razor components, that are statically rendered on the server.
        /// * Blog post text cacheing, the text of each blog post is only rendered once per application run.
        /// * An external library containing blog post content as Razor components.
        /// * Use the Tailwind CSS typography package.
        /// </summary>
        public async Task New_Blog()
        {
            /// Inputs.
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                //Instances.LibraryContexts.Example
                new LibraryContext
                {
                    LibraryName = "D8S.W0003",
                    LibraryDescription = "A private repo for a remake of David Coats’s technical blog.",
                }
                ;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\davidcoats\D8S.W0003.Private"
                ;


            /// Run.
            if(deleteSolutionDirectoryForConstruction)
            {
                var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                    repositoryDirectoryPath);

                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_Blog(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_WindowFormsApplication()
        {
            /// Inputs.
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                Instances.LibraryContexts.Example
                ;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath = DirectoryPaths.Instance.TemporarySolutionParent;


            // Run.
            if(deleteSolutionDirectoryForConstruction)
            {
                var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                    repositoryDirectoryPath);

                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_WindowsFormsApplication(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task AddProjectToSolution_RazorClassLibrary()
        {
            /// Inputs
            var solutionFilePath = @"C:\Code\DEV\Git\GitHub\davidcoats\D8S.W0004.Private\source\D8S.W0004.Private.sln";
            var projectName = "R5T.W0004.R000";
            var projectDescription = "Razor components library for David Coats's personal blog project.";


            /// Run.
            await F0087.SolutionOperations.Instance.AddProjectToSolution_RazorClassLibrary(
                solutionFilePath,
                projectName,
                projectDescription);
        }

        public async Task AddProjectToSolution_Library()
        {
            /// Inputs
            var solutionFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0063.Private\source\R5T.S0063.Private.sln";
            var projectName = "R5T.S0063.F000";
            var projectDescription = "Common functionality for the R5T.S0063 Fresno (instances survey) script.";


            /// Run.
            await F0087.SolutionOperations.Instance.AddProjectToSolution_Library(
                solutionFilePath,
                projectName,
                projectDescription);
        }

        public async Task New_WebStaticRazorComponents()
        {
            /// Inputs.
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                //Instances.LibraryContexts.Example
                new LibraryContext
                {
                    LibraryName = "D8S.W0004",
                    LibraryDescription = "David Coats's personal blog."
                }
                ;
            var isRepositoryPrivate = true;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\davidcoats\D8S.W0004.Private\"
                ;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            if(deleteSolutionDirectoryForConstruction)
            {
                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

            var createSolutionResult = await F0087.SolutionOperations.Instance.NewSolution_WebStaticRazorComponents(
                libraryContext,
                isRepositoryPrivate,
                repositoryDirectoryPath);

            F0088.VisualStudioOperator.Instance.OpenSolutionFile(createSolutionResult.SolutionContext.SolutionFilePath);
        }

        public async Task New_WebBlazorClientAndServer()
        {
            /// Inputs.
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                //Instances.LibraryContexts.Example
                new LibraryContext
                {
                    LibraryName = "R5T.W0004",
                    LibraryDescription = "A functionality search website.",
                }
                ;
            var isRepositoryPrivate =
                true
                //false
                ;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.W0004.Private"
                ;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            if(deleteSolutionDirectoryForConstruction)
            {
                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

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
            var deleteSolutionDirectoryForConstruction = false;
            var libraryContext =
                //Instances.LibraryContexts.Example
                new LibraryContext
                {
                    LibraryName = "D8S.R0003",
                    LibraryDescription = "Generally useful links as Razor components."
                }
                ;
            var isRepositoryPrivate =
                //true
                false
                ;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\davidcoats\D8S.R0003"
                ;


            /// Run.
            var solutionDirectoryPath = Instances.SolutionContextOperations.GetSolutionDirectoryPath(
                repositoryDirectoryPath);

            if(deleteSolutionDirectoryForConstruction)
            {
                await Instances.FileSystemOperator.ClearDirectory(solutionDirectoryPath);
            }

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
                    LibraryName = "R5T.T0167.Deploy",
                    LibraryDescription = "Deployment script for the R5T.T0167 types library containing all marker attribute types."
                }
                ;
            var targetProjectName = "R5T.T0167";
            var isPrivate =
                //true
                false
                ;
            var repositoryDirectoryPath =
                //DirectoryPaths.Instance.TemporarySolutionParent
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0167\"
                //@"C:\Code\DEV\Git\GitHub\davidcoats\D8S.W0003.Private\"
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