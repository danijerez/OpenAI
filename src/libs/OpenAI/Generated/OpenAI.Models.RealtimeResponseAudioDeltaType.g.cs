
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.audio.delta".<br/>
    /// Example: response.audio.delta
    /// </summary>
    public enum RealtimeResponseAudioDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseAudioDeltaType value)
        {
            return value switch
            {
                RealtimeResponseAudioDeltaType.ResponseAudioDelta => "response.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.delta" => RealtimeResponseAudioDeltaType.ResponseAudioDelta,
                _ => null,
            };
        }
    }
}