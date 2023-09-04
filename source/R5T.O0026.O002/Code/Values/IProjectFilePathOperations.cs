using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.O0026.O002
{
    [ValuesMarker]
    public partial interface IProjectFilePathOperations : IValuesMarker
    {
        /// <summary>
        /// <para>Gets the "R5T - Backup.O0025.O001.csproj" file path for "R5T.O0025.O001.csproj" file path.</para>
        /// Visual Studio has a bad habit of just generating a backup project file whenever the project has been changed in VS, but the project file was then changed outside of VS.
        /// (This happens, for example, while adding project references within VS, but then running some code that also adds project references to the project file.)
        /// Visual Studio should not generate the backup project file, but instead ask how you want to handle the situation. (Or even merge the changes! That would be nice.)
        /// This method is useful for identifying if there a backup project file exists for a given project file.
        /// </summary>
        public IProjectFilePath Get_VisualStudioGeneratedBackupProjectFilePath(IProjectFilePath projectFilePath)
        {
            var projectDirectoryPath = Instances.ProjectPathsOperator.Get_ProjectDirectoryPath(projectFilePath);
            var projectFileName = Instances.ProjectPathsOperator.Get_ProjectFileName(projectFilePath);

            var fileExtensionSeparatorCharacter = Instances.FileExtensionOperator.Get_FileExtensionSeparator_Character();

            var hasIndexOfFirstFileExtensionsSeparator = Instances.StringOperator.IndexOf(
                fileExtensionSeparatorCharacter,
                projectFileName.Value);

            if(hasIndexOfFirstFileExtensionsSeparator)
            {
                var newProjectFileName = projectFileName.Value.Insert(
                    hasIndexOfFirstFileExtensionsSeparator.Result,
                    Instances.Values.BackupProjectFileNameFragment)
                    .ToProjectFileName();

                var newProjectFilePath = Instances.ProjectPathsOperator.Get_ProjectFilePath(
                    projectDirectoryPath,
                    newProjectFileName);

                return newProjectFilePath;
            }
            else
            {
                // Throw an exception.
                throw new Exception($"No file extension separator ('{fileExtensionSeparatorCharacter}') found in project file name:\n\t{projectFileName}.");
            }
        }

        /// <inheritdoc cref="Get_VisualStudioGeneratedBackupProjectFilePath(IProjectFilePath)"/>
        public IProjectFilePath Get_VisualStudioGeneratedBackupProjectFilePath(string projectFilePath)
        {
            var stronglyTypedProjectFilePath = projectFilePath.ToProjectFilePath();

            var output = this.Get_VisualStudioGeneratedBackupProjectFilePath(stronglyTypedProjectFilePath);
            return output;
        }
    }
}
