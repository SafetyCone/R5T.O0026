using System;

using R5T.T0131;


namespace R5T.O0026
{
    [ValuesMarker]
    public partial interface IProjectFilePathOperations : IValuesMarker,
        O001.IProjectFilePathOperations,
        O002.IProjectFilePathOperations
    {
    }
}
