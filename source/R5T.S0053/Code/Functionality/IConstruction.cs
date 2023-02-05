using System;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using R5T.T0132;


namespace R5T.S0053
{
    [FunctionalityMarker]
    public partial interface IConstruction : IFunctionalityMarker
    {
        public async Task AddTailwindCSSTypography()
        {
            // Add @tailwindcss/typography, 0.5.4 to the package.json file.
            //var packageJsonFilePath = Instances.ProjectPathsOperator.GetPackageJsonFilePath(projectContext.ProjectFilePath);
            var packageJsonFilePath = @"C:\Temp\Solutions\source\Example.Server\package.json";
            var outputPackageJsonFilePath = @"C:\Temp\package.json";

            var packageJson = await Instances.JsonOperator.Deserialize(packageJsonFilePath);

            var devDependencies = packageJson["devDependencies"] as JObject;

            devDependencies.Add("@tailwindcss/typography", "0.5.4");

            Instances.JsonOperator.Serialize_Synchronous(
                outputPackageJsonFilePath,
                packageJson);

            Instances.NotepadPlusPlusOperator.Open(outputPackageJsonFilePath);
        }
    }
}
