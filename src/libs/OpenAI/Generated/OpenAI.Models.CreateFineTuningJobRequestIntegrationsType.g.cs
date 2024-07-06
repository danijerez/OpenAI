
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTuningJobRequestIntegrationsType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFineTuningJobRequestIntegrationsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFineTuningJobRequestIntegrationsType value)
        {
            return value switch
            {
                CreateFineTuningJobRequestIntegrationsType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTuningJobRequestIntegrationsType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => CreateFineTuningJobRequestIntegrationsType.Wandb,
                _ => null,
            };
        }
    }
}