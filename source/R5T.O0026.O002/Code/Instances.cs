using System;


namespace R5T.O0026.O002
{
    public static class Instances
    {
        public static Z0000.ICharacters Characters => Z0000.Characters.Instance;
        public static F0000.IFileExtensionOperator FileExtensionOperator => F0000.FileExtensionOperator.Instance;
        public static F0000.IFileNameOperator FileNameOperator => F0000.FileNameOperator.Instance;
        public static F0129.IProjectPathsOperator ProjectPathsOperator => F0129.ProjectPathsOperator.Instance;
        public static F0000.IStringOperator StringOperator => F0000.StringOperator.Instance;
        public static IValues Values => O002.Values.Instance;
    }
}