using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestAssistantMessageContentPart : global::System.IEquatable<ChatCompletionRequestAssistantMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionRequestMessageContentPartText? Text { get; init; }
#else
        public global::OpenAI.ChatCompletionRequestMessageContentPartText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestAssistantMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? Refusal { get; init; }
#else
        public global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartRefusal value) => new ChatCompletionRequestAssistantMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionRequestMessageContentPartRefusal?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(
            global::OpenAI.ChatCompletionRequestMessageContentPartText? text,
            global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? refusal
            )
        {
            Text = text;
            Refusal = refusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refusal as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsRefusal || !IsText && IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText),
                Refusal,
                typeof(global::OpenAI.ChatCompletionRequestMessageContentPartRefusal),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChatCompletionRequestAssistantMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionRequestMessageContentPartRefusal?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestAssistantMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestAssistantMessageContentPart o && Equals(o);
        }
    }
}
