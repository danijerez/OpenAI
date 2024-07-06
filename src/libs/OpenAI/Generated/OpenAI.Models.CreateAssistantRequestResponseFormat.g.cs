
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum CreateAssistantRequestResponseFormat
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
    public static class CreateAssistantRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestResponseFormat value)
        {
            return value switch
            {
                CreateAssistantRequestResponseFormat.None => "none",
                CreateAssistantRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateAssistantRequestResponseFormat.None,
                "auto" => CreateAssistantRequestResponseFormat.Auto,
                _ => null,
            };
        }
    }
}