#nullable enable

namespace OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Returns a list of messages for a given thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ListMessagesResponse> ListMessagesAsync(
            string threadId,
            int limit = 20,
            global::OpenAI.ListMessagesOrder? order = global::OpenAI.ListMessagesOrder.Desc,
            string? after = default,
            string? before = default,
            string? runId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}