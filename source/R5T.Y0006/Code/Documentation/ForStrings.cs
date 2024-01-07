using System;
using System.Xml.Linq;

using R5T.T0156;


namespace R5T.Y0006
{
	public static partial class Documentation
	{
        [DocumentationMarker]
        public static partial class ForStrings
        {
            /// <summary>
            /// ", " - Comma and then a space.
            /// For use in comma-separated lists where you also want a space after each comma.
            /// </summary>
            public static readonly object ForCommaSeparatedListSpacedSeparator;

            /// <summary>
            /// <description>"  ", two spaces</description>
            /// </summary>
            public static readonly object ForDoubleSpaces;

            /// <summary>
            /// <description>"", the empty string</description>
            /// Constant, as opposed to <see cref="String.Empty"/>, which is readonly. Only constants can be used as default parameter values.
            /// </summary>
            public static readonly object ForEmpty_Constant;

            /// <summary>
            /// <inheritdoc cref="ForEmpty_Constant" path="/summary/description"/>
            /// </summary>
            public static readonly object ForEmpty;

            /// <summary>
            /// "false"
            /// </summary>
            public static readonly object ForFalse_Lowercase;

            /// <summary>
            /// "False"
            /// </summary>
            public static readonly object ForFalse_PascalCase;

            /// <summary>
            /// "FALSE"
            /// </summary>
            public static readonly object ForFalse_Uppercase;

            /// <summary>
            /// "\n", new line
            /// </summary>
            public static readonly object ForNewLine;

            /// <summary>
            /// "\r\n", carriage return and new line (carriage return and line feed, or CRLF).
            /// </summary>
            public static readonly object ForNewLine_Windows;

            /// <summary>
            /// ".", period
            /// </summary>
            public static readonly object ForPeriod;

            /// <summary>
            /// " ", space
            /// </summary>
            public static readonly object ForSpace;

            /// <summary>
            /// "\t", tab
            /// </summary>
            public static readonly object ForTab;

            /// <summary>
            /// "\s\s\s\s", tab implemeted as four spaces
            /// </summary>
            public static readonly object ForTab_AsFourSpaces;

            /// <summary>
            /// "true"
            /// </summary>
            public static readonly object ForTrue_Lowercase;

            /// <summary>
            /// "True"
            /// </summary>
            public static readonly object ForTrue_PascalCase;

            /// <summary>
            /// "TRUE"
            /// </summary>
            public static readonly object ForTrue_Uppercase;
        }
    }
}