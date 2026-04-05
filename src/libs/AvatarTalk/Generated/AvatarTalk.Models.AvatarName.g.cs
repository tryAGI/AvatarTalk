
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Available avatar characters. Each avatar represents a different<br/>
    /// person with distinct appearance and demographics.
    /// </summary>
    public enum AvatarName
    {
        /// <summary>
        /// 
        /// </summary>
        AfricanMan,
        /// <summary>
        /// 
        /// </summary>
        AfricanWoman,
        /// <summary>
        /// 
        /// </summary>
        ArabMan,
        /// <summary>
        /// 
        /// </summary>
        ArabWoman,
        /// <summary>
        /// 
        /// </summary>
        ColombianWoman,
        /// <summary>
        /// 
        /// </summary>
        EuropeanMan,
        /// <summary>
        /// 
        /// </summary>
        EuropeanWoman,
        /// <summary>
        /// 
        /// </summary>
        IranianMan,
        /// <summary>
        /// 
        /// </summary>
        JapaneseMan,
        /// <summary>
        /// 
        /// </summary>
        JapaneseWoman,
        /// <summary>
        /// 
        /// </summary>
        MexicanMan,
        /// <summary>
        /// 
        /// </summary>
        MexicanWoman,
        /// <summary>
        /// 
        /// </summary>
        OldEuropeanWoman,
        /// <summary>
        /// 
        /// </summary>
        OldJapaneseMan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AvatarNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AvatarName value)
        {
            return value switch
            {
                AvatarName.AfricanMan => "african_man",
                AvatarName.AfricanWoman => "african_woman",
                AvatarName.ArabMan => "arab_man",
                AvatarName.ArabWoman => "arab_woman",
                AvatarName.ColombianWoman => "colombian_woman",
                AvatarName.EuropeanMan => "european_man",
                AvatarName.EuropeanWoman => "european_woman",
                AvatarName.IranianMan => "iranian_man",
                AvatarName.JapaneseMan => "japanese_man",
                AvatarName.JapaneseWoman => "japanese_woman",
                AvatarName.MexicanMan => "mexican_man",
                AvatarName.MexicanWoman => "mexican_woman",
                AvatarName.OldEuropeanWoman => "old_european_woman",
                AvatarName.OldJapaneseMan => "old_japanese_man",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AvatarName? ToEnum(string value)
        {
            return value switch
            {
                "african_man" => AvatarName.AfricanMan,
                "african_woman" => AvatarName.AfricanWoman,
                "arab_man" => AvatarName.ArabMan,
                "arab_woman" => AvatarName.ArabWoman,
                "colombian_woman" => AvatarName.ColombianWoman,
                "european_man" => AvatarName.EuropeanMan,
                "european_woman" => AvatarName.EuropeanWoman,
                "iranian_man" => AvatarName.IranianMan,
                "japanese_man" => AvatarName.JapaneseMan,
                "japanese_woman" => AvatarName.JapaneseWoman,
                "mexican_man" => AvatarName.MexicanMan,
                "mexican_woman" => AvatarName.MexicanWoman,
                "old_european_woman" => AvatarName.OldEuropeanWoman,
                "old_japanese_man" => AvatarName.OldJapaneseMan,
                _ => null,
            };
        }
    }
}