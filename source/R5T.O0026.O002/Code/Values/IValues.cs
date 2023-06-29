using System;

using R5T.T0131;


namespace R5T.O0026.O002
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public string BackupProjectFileNameFragment => " - Backup";
    }
}
