// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModel
{
    /// <summary>
    /// Snapshot of gpt-4 from June 13th 2023 with improved function calling support. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 8,192 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt4_0613Id = "gpt-4-0613";
    
    /// <inheritdoc cref="Gpt4_0613Id"/>
    /// <remarks>Alias - Currently points to gpt-4-0613.</remarks>
    internal const string Gpt4Id = "gpt-4";
    
    /// <inheritdoc cref="Gpt4_0613Id"/>
    public static ChatModel Gpt4_0613 { get; } = new(
        Id: Gpt4_0613Id,
        ContextLength: 8_192,
        PricePerInputTokenInUsd: 0.0300 * 0.001,
        PricePerOutputTokenInUsd: 0.0600 * 0.001);
    
    /// <inheritdoc cref="Gpt4Id"/>
    public static ChatModel Gpt4 { get; } = Gpt4_0613 with
    {
        Id = Gpt4Id,
    };
}