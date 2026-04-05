
#nullable enable

namespace AvatarTalk
{
    /// <summary>
    /// Language code for text-to-speech. Determines the voice language<br/>
    /// and pronunciation used for generating the avatar's speech.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Language value)
        {
            return value switch
            {
                Language.Ar => "ar",
                Language.Cs => "cs",
                Language.De => "de",
                Language.En => "en",
                Language.Es => "es",
                Language.Fr => "fr",
                Language.Hi => "hi",
                Language.Hu => "hu",
                Language.It => "it",
                Language.Ja => "ja",
                Language.Ko => "ko",
                Language.Nl => "nl",
                Language.Pl => "pl",
                Language.Pt => "pt",
                Language.Ru => "ru",
                Language.Tr => "tr",
                Language.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Language? ToEnum(string value)
        {
            return value switch
            {
                "ar" => Language.Ar,
                "cs" => Language.Cs,
                "de" => Language.De,
                "en" => Language.En,
                "es" => Language.Es,
                "fr" => Language.Fr,
                "hi" => Language.Hi,
                "hu" => Language.Hu,
                "it" => Language.It,
                "ja" => Language.Ja,
                "ko" => Language.Ko,
                "nl" => Language.Nl,
                "pl" => Language.Pl,
                "pt" => Language.Pt,
                "ru" => Language.Ru,
                "tr" => Language.Tr,
                "zh" => Language.Zh,
                _ => null,
            };
        }
    }
}