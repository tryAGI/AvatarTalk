
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AvatarTalk
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::AvatarTalk.JsonConverters.AvatarNameJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.AvatarNameNullableJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.EmotionJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.EmotionNullableJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.LanguageJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.LanguageNullableJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.GenerateVideoStreamJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.GenerateVideoStreamNullableJsonConverter),

            typeof(global::AvatarTalk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.AvatarName), TypeInfoPropertyName = "AvatarName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.Emotion), TypeInfoPropertyName = "Emotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.Language), TypeInfoPropertyName = "Language2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.InferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.InferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.CreateLiveKitSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.LiveKitSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.DeleteSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.LightningTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.LightningInvoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.GenerateLightningVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.PaymentStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.PaymentsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AvatarTalk.PaymentStatusResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.RequestVideoByAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AvatarTalk.GenerateVideoStream), TypeInfoPropertyName = "GenerateVideoStream2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AvatarTalk.PaymentStatusResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}