using System;

using R5T.T0141;


namespace R5T.O0026.Construction
{
    [DemonstrationsMarker]
    public partial interface IProjectFilePathDemonstrations : IDemonstrationsMarker
    {
        public void Get_BackupProjectFilePath()
        {
            /// Inputs.
            var projectFilePath = Instances.FilePaths.Example_ProjectFilePath;


            // Run.
            var backupProjectFilePath = Instances.ProjectFilePathOperations.Get_VisualStudioGeneratedBackupProjectFilePath(projectFilePath);

            Console.WriteLine($"Backup project file path:\n\t{backupProjectFilePath}\n\nFor project file path:\n\t{projectFilePath}");
        }
    }
}
