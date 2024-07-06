
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionRequestTimestampGranularities
    {
        /// <summary>
        /// 
        /// </summary>
        Word,
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionRequestTimestampGranularitiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestTimestampGranularities value)
        {
            return value switch
            {
                CreateTranscriptionRequestTimestampGranularities.Word => "word",
                CreateTranscriptionRequestTimestampGranularities.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestTimestampGranularities? ToEnum(string value)
        {
            return value switch
            {
                "word" => CreateTranscriptionRequestTimestampGranularities.Word,
                "segment" => CreateTranscriptionRequestTimestampGranularities.Segment,
                _ => null,
            };
        }
    }
}