#nullable enable

namespace AvatarTalk
{
    public partial interface IAvatarTalkClient
    {
        /// <summary>
        /// Delete a LiveKit avatar session<br/>
        /// Terminates an active LiveKit session and releases associated resources.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AvatarTalk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AvatarTalk.DeleteSessionResponse> DeleteLiveKitSessionAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}