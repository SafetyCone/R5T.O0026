using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0172;


namespace R5T.O0026.O001
{
    [ValuesMarker]
    public partial interface IProjectFilePathOperations : IValuesMarker
    {
        public Task<bool> Is_InPrivateGitHubRepository(IProjectFilePath projectFilePath)
        {
            var output = Instances.GitHubRepositoryOperations.Is_Private(projectFilePath);
            return output;
        }
    }
}
