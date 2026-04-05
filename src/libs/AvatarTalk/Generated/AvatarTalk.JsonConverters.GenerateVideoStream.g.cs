#nullable enable

namespace AvatarTalk.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateVideoStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AvatarTalk.GenerateVideoStream>
    {
        /// <inheritdoc />
        public override global::AvatarTalk.GenerateVideoStream Read(
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
                        return global::AvatarTalk.GenerateVideoStreamExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AvatarTalk.GenerateVideoStream)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AvatarTalk.GenerateVideoStream);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AvatarTalk.GenerateVideoStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AvatarTalk.GenerateVideoStreamExtensions.ToValueString(value));
        }
    }
}
