using System;

using R5T.T0156;


namespace R5T.Y0006
{
    /// <summary>
    /// Strictly platform-specific documentation, across all .NET platform versions.
    /// </summary>
    [DocumentationMarker]
	public static partial class Documentation
	{
        /// <summary>
        /// When equating two reference type instances, if one or both of the instances are null then a simple null check has determined whether the instances are equal.
        /// In the case where one instance is null, but the other isn't, a null check has determined equality and the instances are not equal.
        /// If both are null, then the null check has determined equality and the instances are equal.
        /// Only in the case where both are not null does a null check not determine equality.
        /// </summary>
        public static readonly object NullCheckDeterminesEquality;
    }
}