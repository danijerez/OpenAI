
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    public enum CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType value)
        {
            return value switch
            {
                CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.Auto,
                _ => null,
            };
        }
    }
}