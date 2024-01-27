// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/speech-to-text
/// </summary>
public readonly partial record struct SpeechToTextModel
{
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and
    /// the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    internal const string Whisper1Id = "whisper-1";
    
    /// <inheritdoc cref="Whisper1Id"/>
    public static SpeechToTextModel Whisper1 { get; } = new(
        Id: Whisper1Id,
        PricePerMinuteInUsd: 0.006);
}