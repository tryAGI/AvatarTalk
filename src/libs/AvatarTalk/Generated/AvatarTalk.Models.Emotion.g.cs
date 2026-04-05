
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Emotion state for the avatar. Controls facial expression during speech.
    /// </summary>
    public enum Emotion
    {
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Serious,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Emotion value)
        {
            return value switch
            {
                Emotion.Happy => "happy",
                Emotion.Neutral => "neutral",
                Emotion.Serious => "serious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Emotion? ToEnum(string value)
        {
            return value switch
            {
                "happy" => Emotion.Happy,
                "neutral" => Emotion.Neutral,
                "serious" => Emotion.Serious,
                _ => null,
            };
        }
    }
}