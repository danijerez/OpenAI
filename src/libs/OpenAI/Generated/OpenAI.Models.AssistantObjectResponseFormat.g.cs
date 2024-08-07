
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum AssistantObjectResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantObjectResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantObjectResponseFormat value)
        {
            return value switch
            {
                AssistantObjectResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantObjectResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AssistantObjectResponseFormat.Auto,
                _ => null,
            };
        }
    }
}