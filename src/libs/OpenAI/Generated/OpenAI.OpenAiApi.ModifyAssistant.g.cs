
#nullable enable

namespace OpenAI
{
    public partial class OpenAiApi
    {
        /// <summary>
        /// Modifies an assistant.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.AssistantObject> ModifyAssistantAsync(
            string assistantId,
            global::OpenAI.ModifyAssistantRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/assistants/{assistantId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.ModifyAssistantRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.AssistantObject) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Modifies an assistant.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.AssistantObject> ModifyAssistantAsync(
            string assistantId,
            global::System.AnyOf<string?>? model = default,
            string? name = default,
            string? description = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::System.OneOf<global::OpenAI.AssistantToolsCode?, global::OpenAI.AssistantToolsFileSearch?, global::OpenAI.AssistantToolsFunction?>?>? tools = default,
            global::OpenAI.ModifyAssistantRequestToolResources? toolResources = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            global::System.OneOf<global::OpenAI.ModifyAssistantRequestResponseFormat?, global::OpenAI.AssistantsApiResponseFormat?>? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.ModifyAssistantRequest
            {
                Model = model,
                Name = name,
                Description = description,
                Instructions = instructions,
                Tools = tools,
                ToolResources = toolResources,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                ResponseFormat = responseFormat,
            };

            return await ModifyAssistantAsync(
                assistantId: assistantId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}