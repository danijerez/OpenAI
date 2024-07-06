
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum RunObjectResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectResponseFormat value)
        {
            return value switch
            {
                RunObjectResponseFormat.None => "none",
                RunObjectResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "none" => RunObjectResponseFormat.None,
                "auto" => RunObjectResponseFormat.Auto,
                _ => null,
            };
        }
    }
}