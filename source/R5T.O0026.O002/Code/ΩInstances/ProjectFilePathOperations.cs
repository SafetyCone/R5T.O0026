using System;


namespace R5T.O0026.O002
{
    public class ProjectFilePathOperations : IProjectFilePathOperations
    {
        #region Infrastructure

        public static IProjectFilePathOperations Instance { get; } = new ProjectFilePathOperations();


        private ProjectFilePathOperations()
        {
        }

        #endregion
    }
}
