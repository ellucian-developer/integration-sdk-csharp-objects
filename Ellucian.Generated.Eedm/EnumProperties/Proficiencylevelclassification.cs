using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The classifications of the person's proficiency level (e.g. read, write, translate, etc.).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Proficiencylevelclassification
    {
        /// <summary>
        /// Read
        /// </summary>
        [EnumMember(Value = "read")]
        Read,
        /// <summary>
        /// Write.
        /// </summary>
        [EnumMember(Value = "write")]
        Write,
        /// <summary>
        /// Speak
        /// </summary>
        [EnumMember(Value = "speak")]
        Speak,
        /// <summary>
        /// Translate.
        /// </summary>
        [EnumMember(Value = "translate")]
        Translate,
        /// <summary>
        /// Teach
        /// </summary>
        [EnumMember(Value = "teach")]
        Teach,
        /// <summary>
        /// Native Language.
        /// </summary>
        [EnumMember(Value = "nativeLanguage")]
        NativeLanguage
    }
}
