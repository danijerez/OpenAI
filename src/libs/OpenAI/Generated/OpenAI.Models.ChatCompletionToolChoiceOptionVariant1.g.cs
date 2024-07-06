
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
    /// </summary>
    public enum ChatCompletionToolChoiceOptionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolChoiceOptionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolChoiceOptionVariant1 value)
        {
            return value switch
            {
                ChatCompletionToolChoiceOptionVariant1.None => "none",
                ChatCompletionToolChoiceOptionVariant1.Auto => "auto",
                ChatCompletionToolChoiceOptionVariant1.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolChoiceOptionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "none" => ChatCompletionToolChoiceOptionVariant1.None,
                "auto" => ChatCompletionToolChoiceOptionVariant1.Auto,
                "required" => ChatCompletionToolChoiceOptionVariant1.Required,
                _ => null,
            };
        }
    }
}