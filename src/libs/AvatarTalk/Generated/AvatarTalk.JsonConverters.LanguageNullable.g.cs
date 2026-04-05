#nullable enable

namespace AvatarTalk.JsonConverters
{
    /// <inheritdoc />
    public sealed class LanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AvatarTalk.Language?>
    {
        /// <inheritdoc />
        public override global::AvatarTalk.Language? Read(
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
                        return global::AvatarTalk.LanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AvatarTalk.Language)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AvatarTalk.Language?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AvatarTalk.Language? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AvatarTalk.LanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
