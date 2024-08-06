using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tool and instead generates a message.<br/>
    /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools.<br/>
    /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
    /// `none` is the default when no tools are present. `auto` is the default if tools are present.
    /// </summary>
    public readonly partial struct ChatCompletionToolChoiceOption : global::System.IEquatable<ChatCompletionToolChoiceOption>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionToolChoiceOptionVariant1? Value1 { get; init; }
#else
        public global::OpenAI.ChatCompletionToolChoiceOptionVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::OpenAI.ChatCompletionToolChoiceOptionVariant1 value) => new ChatCompletionToolChoiceOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionToolChoiceOptionVariant1?(ChatCompletionToolChoiceOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::OpenAI.ChatCompletionToolChoiceOptionVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionNamedToolChoice? Value2 { get; init; }
#else
        public global::OpenAI.ChatCompletionNamedToolChoice? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::OpenAI.ChatCompletionNamedToolChoice value) => new ChatCompletionToolChoiceOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionNamedToolChoice?(ChatCompletionToolChoiceOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::OpenAI.ChatCompletionNamedToolChoice? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(
            global::OpenAI.ChatCompletionToolChoiceOptionVariant1? value1,
            global::OpenAI.ChatCompletionNamedToolChoice? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::OpenAI.ChatCompletionToolChoiceOptionVariant1),
                Value2,
                typeof(global::OpenAI.ChatCompletionNamedToolChoice),
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
        public bool Equals(ChatCompletionToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionToolChoiceOptionVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionNamedToolChoice?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionToolChoiceOption o && Equals(o);
        }
    }
}
