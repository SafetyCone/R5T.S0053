using System;
using System.Threading.Tasks;


namespace R5T.S0053
{
    class Program
    {
        static async Task Main()
        {
            //await SolutionScripts.Instance.CreateConsoleSolution();
            //await SolutionScripts.Instance.CreateConsoleWithLibrarySolution();
            //await SolutionScripts.Instance.CreateWebBlazorClientAndServer();
            await SolutionScripts.Instance.CreateWebStaticRazorComponents();
            //await SolutionScripts.Instance.CreateRazorClassLibrarySolution();
            //await SolutionScripts.Instance.AddProjectToSolution_RazorClassLibrary();
        }
    }
}