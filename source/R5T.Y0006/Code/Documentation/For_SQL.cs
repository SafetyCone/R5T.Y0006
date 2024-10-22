using System;

using R5T.T0156;


namespace R5T.Y0006
{
    public partial class Documentation
    {
        [DocumentationMarker]
        public class For_SQL
        {
            /// <summary>
            /// SQL wildcards contain the values:
            /// <list type="bullet">
            /// <item><inheritdoc cref="For_Characters.ForPercent" path="descendant::description"/></item>
            /// <item><inheritdoc cref="For_Characters.ForUnderscore" path="descendant::description"/></item>
            /// </list>
            /// </summary>
            /// <remarks>
            /// <para>
            /// Sources:
            /// <list type="bullet">
            /// <item><inheritdoc cref="Links.SQL_Wildcards" path="descendant::value"/></item>
            /// </list>
            /// </para>
            /// </remarks>
            public static readonly object SQL_WildcardPatterns;

            /// <summary>
            /// SQL wildcard patterns are much more limited than regular expression (regex) patterns.
            /// SQL wildcard patterns only allow '%' (zero or more characters) and '_' (a single character).
            /// Some databases support other wildcards, like
            /// "[]" (any of a selection of characters within the brackets),
            /// '^' (any character NOT in a selection of characters within the bracket),
            /// '-' (any character within a range of characters),
            /// and "{}" escaped characters.
            /// </summary>
            /// <remarks>
            /// <para>Source: <inheritdoc cref="Links.SQL_Wildcards" path="descendant::value"/></para>
            /// </remarks>
            public static readonly object SQL_WildcardPatterns_VsRegexPatterns;
        }
    }
}
