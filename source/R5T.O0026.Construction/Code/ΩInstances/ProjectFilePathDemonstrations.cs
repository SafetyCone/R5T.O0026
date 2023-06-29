using System;


namespace R5T.O0026.Construction
{
    public class ProjectFilePathDemonstrations : IProjectFilePathDemonstrations
    {
        #region Infrastructure

        public static IProjectFilePathDemonstrations Instance { get; } = new ProjectFilePathDemonstrations();


        private ProjectFilePathDemonstrations()
        {
        }

        #endregion
    }
}
