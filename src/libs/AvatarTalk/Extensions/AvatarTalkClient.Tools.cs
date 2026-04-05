#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace AvatarTalk;

/// <summary>
/// Extensions for using AvatarTalkClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class AvatarTalkClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that generates a lip-synced avatar video from text.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateVideoTool(this AvatarTalkClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The text for the avatar to speak")] string text,
                   [Description("Avatar name: japanese_man, old_european_woman, european_woman, european_man, african_man, african_woman, japanese_woman, iranian_man, mexican_man, mexican_woman, colombian_woman, old_japanese_man, arab_man, arab_woman")] string avatar,
                   [Description("Emotion: happy, neutral, or serious")] string emotion,
                   [Description("Language code: en, es, fr, de, it, pt, pl, tr, ru, nl, cs, ar, zh, ja, hu, ko, hi. Defaults to en.")] string? language,
                   CancellationToken cancellationToken) =>
            {
                var avatarEnum = AvatarNameExtensions.ToEnum(avatar) ?? AvatarName.EuropeanMan;
                var emotionEnum = EmotionExtensions.ToEnum(emotion) ?? Emotion.Neutral;
                var languageEnum = language is not null ? LanguageExtensions.ToEnum(language) : Language.En;

                var response = await client.GenerateVideoAsync(
                    text: text,
                    avatar: avatarEnum,
                    emotion: emotionEnum,
                    language: languageEnum,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Status,
                    response.Text,
                    response.Avatar,
                    response.Emotion,
                    response.Language,
                    response.CreditsConsumed,
                    response.VideoDurationSeconds,
                    response.Mp4Url,
                    response.HtmlUrl,
                };
            },
            name: "AvatarTalk_GenerateVideo",
            description: "Generate a lip-synced avatar video from text. Returns video URLs, duration, and credits consumed. Supports 14 avatars, 3 emotions, and 17 languages.");
    }

    /// <summary>
    /// Creates an AIFunction tool that creates a LiveKit session for real-time avatar interaction.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsCreateLiveKitSessionTool(this AvatarTalkClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Avatar name: japanese_man, old_european_woman, european_woman, european_man, african_man, african_woman, japanese_woman, iranian_man, mexican_man, mexican_woman, colombian_woman, old_japanese_man, arab_man, arab_woman")] string avatar,
                   [Description("Emotion: happy, neutral, or serious. Optional.")] string? emotion,
                   [Description("Language code (e.g., en, es, fr). Optional.")] string? language,
                   CancellationToken cancellationToken) =>
            {
                var avatarEnum = AvatarNameExtensions.ToEnum(avatar) ?? AvatarName.EuropeanMan;
                var emotionEnum = emotion is not null ? EmotionExtensions.ToEnum(emotion) : null;
                var languageEnum = language is not null ? LanguageExtensions.ToEnum(language) : null;

                var response = await client.CreateLiveKitSessionAsync(
                    avatar: avatarEnum,
                    emotion: emotionEnum,
                    language: languageEnum,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.TaskId,
                    response.ParticipantToken,
                    response.ServerUrl,
                    response.Status,
                };
            },
            name: "AvatarTalk_CreateLiveKitSession",
            description: "Create a LiveKit session for real-time avatar interaction. Returns a participant token and server URL for joining the LiveKit room.");
    }

    /// <summary>
    /// Creates an AIFunction tool that deletes an active LiveKit session.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsDeleteLiveKitSessionTool(this AvatarTalkClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The task ID of the LiveKit session to delete")] string taskId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.DeleteLiveKitSessionAsync(
                    taskId: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    response.TaskId,
                };
            },
            name: "AvatarTalk_DeleteLiveKitSession",
            description: "Delete an active LiveKit avatar session and release associated resources.");
    }

    /// <summary>
    /// Creates an AIFunction tool that checks a Lightning Network payment status.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGetPaymentStatusTool(this AvatarTalkClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("The Lightning invoice string to check")] string invoice,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetPaymentStatusAsync(
                    invoice: invoice,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Invoice,
                    response.Paid,
                    response.AmountSats,
                    response.CreatedAt,
                };
            },
            name: "AvatarTalk_GetPaymentStatus",
            description: "Check the payment status of a Lightning Network invoice for avatar video generation.");
    }
}
