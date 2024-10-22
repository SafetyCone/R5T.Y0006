using System;
using System.Xml.Linq;

using R5T.T0156;


namespace R5T.Y0006
{
	public static partial class Documentation
	{
        [DocumentationMarker]
        public static partial class For_Xml
        {
            /// <summary>
            /// Insignificant whitespace is any XText node that contains only whitespace.
            /// See <inheritdoc cref="Links.InsignificantWhitespace" path="/summary"/>.
            /// </summary>
            public static readonly object InsignificantWhitespace;

            /// <summary>
            /// Note that only <see cref="XElement"/>, <see cref="XDocument"/> and <see cref="XAttribute"/> have cloning constructors
            /// (<see cref="XObject"/>, <see cref="XNode"/>, and <see cref="XContainer"/> do not).
            /// </summary>
            public static readonly object WhichXObjectsAreCloneable;
        }
    }
}