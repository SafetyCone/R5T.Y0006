using System;
using System.Xml.Linq;

using R5T.T0156;


namespace R5T.Y0006
{
	public static partial class Documentation
	{
        [DocumentationMarker]
        public static partial class ForCharacters
        {
            /// <summary>
            /// <description>'\', back-slash</description>
            /// </summary>
            public static readonly object ForBackslash;

            /// <summary>
            /// '©', copyright character.
            /// </summary>
            public static readonly object ForCopyright;

            /// <summary>
            /// <description>'\n', new line</description>
            /// </summary>
            public static readonly object ForNewLine;

            /// <summary>
            /// <description>';', semi-colon</description>
            /// </summary>
            public static readonly object ForSemicolon;

            /// <summary>
            /// <description>'/', slash</description>
            /// </summary>
            public static readonly object ForSlash;
        }
    }
}