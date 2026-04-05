#nullable enable

namespace AvatarTalk.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmotionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AvatarTalk.Emotion?>
    {
        /// <inheritdoc />
        public override global::AvatarTalk.Emotion? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::AvatarTalk.EmotionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AvatarTalk.Emotion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AvatarTalk.Emotion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AvatarTalk.Emotion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AvatarTalk.EmotionExtensions.ToValueString(value.Value));
            }
        }
    }
}
