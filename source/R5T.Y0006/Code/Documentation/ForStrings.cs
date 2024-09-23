using System;

using R5T.T0156;


namespace R5T.Y0006
{
	public static partial class Documentation
	{
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// * No terminating periods (allows inheritdoc use of path="/summary" in sentences).
        /// </remarks>
        [DocumentationMarker]
        public static partial class ForStrings
        {
            /// <summary>
            /// "*", asterix
            /// </summary>
            public static readonly object ForAsterix;

            /// <summary>
            /// <description>",", comma</description>
            /// </summary>
            public static readonly object ForComma;

            /// <summary>
            /// ", " - Comma and then a space.
            /// For use in comma-separated lists where you also want a space after each comma.
            /// </summary>
            public static readonly object ForCommaSeparatedListSpacedSeparator;

            /// <summary>
            /// <description>"..", two periods</description>
            /// </summary>
            public static readonly object ForDoubleDot;

            /// <summary>
            /// <description>"  ", two spaces</description>
            /// </summary>
            public static readonly object ForDoubleSpaces;

            /// <summary>
            /// <description>"...", the ellipsis (three periods)</description>
            /// </summary>
            public static readonly object For_Ellipsis;

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
            /// <description>"=", the equals sign</description>
            /// </summary>
            public static readonly object ForEquals;

            /// <summary>
            /// <para><value>"false"</value></para>
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
            /// <description>"-", hyphen (or dash)</description>
            /// </summary>
            public static readonly object ForHyphen;

            /// <summary>
            /// "\n", new line
            /// </summary>
            public static readonly object ForNewLine;

            /// <summary>
            /// "\r\n", carriage return and new line (carriage return and line feed, or CRLF)
            /// </summary>
            public static readonly object ForNewLine_Windows;

            /// <summary>
            /// <description><value>"."</value>, period (or dot)</description>
            /// </summary>
            public static readonly object For_Period;

            /// <summary>
            /// "|", pipe
            /// </summary>
            public static readonly object ForPipe;

            /// <summary>
            /// "?", question mark
            /// </summary>
            public static readonly object ForQuestionMark;

            /// <summary>
            /// """, quote mark
            /// </summary>
            public static readonly object ForQuote;

            /// <summary>
            /// ";", semicolon
            /// </summary>
            public static readonly object ForSemicolon;

            /// <summary>
            /// " ", space
            /// </summary>
            public static readonly object ForSpace;

            /// <summary>
            /// "/", slash
            /// </summary>
            public static readonly object ForSlash;

            /// <summary>
            /// "\t", tab
            /// </summary>
            public static readonly object ForTab;

            /// <summary>
            /// "\s\s\s\s", tab implemeted as four spaces
            /// </summary>
            public static readonly object ForTab_AsFourSpaces;

            /// <summary>
            /// "///"
            /// </summary>
            public static readonly object ForTripleSlashes;

            /// <summary>
            /// <para><value>"true"</value></para>
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