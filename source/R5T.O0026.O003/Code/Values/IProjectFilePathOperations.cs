using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.O0026.O003
{
    [ValuesMarker]
    public partial interface IProjectFilePathOperations : IValuesMarker
    {
        public IEnumerable<IDocumentationXmlFilePath> Get_DocumentationXmlFilePaths(IEnumerable<IProjectFilePath> projectFilePaths)
        {
            var documentationFilePaths = projectFilePaths
                .Select(projectFilePath =>
                    Instances.ProjectPathsOperator.GetDocumentationFilePathForProjectFilePath(projectFilePath.Value))
                .Select(documentationFilePath =>
                    documentationFilePath.ToDocumentationXmlFilePath())
                ;

            return documentationFilePaths;
        }

        public IEnumerable<IDocumentationXmlFilePath> Get_DocumentationXmlFilePaths(params IProjectFilePath[] projectFilePaths)
        {
            return this.Get_DocumentationXmlFilePaths(projectFilePaths.AsEnumerable());
        }

        public IDocumentationXmlFilePath Get_DocumentationXmlFilePath(IProjectFilePath projectFilePath)
        {
            return this.Get_DocumentationXmlFilePaths(projectFilePath).First();
        }
    }
}
