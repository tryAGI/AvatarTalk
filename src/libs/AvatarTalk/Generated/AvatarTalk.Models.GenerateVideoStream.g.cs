
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateVideoStream
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateVideoStreamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateVideoStream value)
        {
            return value switch
            {
                GenerateVideoStream.False => "false",
                GenerateVideoStream.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateVideoStream? ToEnum(string value)
        {
            return value switch
            {
                "false" => GenerateVideoStream.False,
                "true" => GenerateVideoStream.True,
                _ => null,
            };
        }
    }
}