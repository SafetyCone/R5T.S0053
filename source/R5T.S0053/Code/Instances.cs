using System;


namespace R5T.S0053
{
    public static class Instances
    {
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0032.IJsonOperator JsonOperator => F0032.JsonOperator.Instance;
        public static T0153.Z001.ILibraryContexts LibraryContexts => T0153.Z001.LibraryContexts.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static F0084.IProjectOperations ProjectOperations => F0084.ProjectOperations.Instance;
        public static F0089.IProjectContextOperations ProjectContextOperations => F0089.ProjectContextOperations.Instance;
        public static F0089.ISolutionContextOperations SolutionContextOperations => F0089.SolutionContextOperations.Instance;
        public static F0050.ISolutionPathsOperator SolutionPathsOperator => F0050.SolutionPathsOperator.Instance;
    }
}