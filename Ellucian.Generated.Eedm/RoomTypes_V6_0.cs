//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using Ellucian.Generated.Eedm;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace Ellucian.Generated.Eedm.RoomTypes_V6_0
{
    using System = global::System;

    

    /// <summary>
    /// A list of custom room types.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoomTypes_V6_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// A globally unique identifier of a room type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of a room type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The description of a room type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// The type or style of a of room's layout. For example, "Classroom" or "Banquet" style.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomTypes_V6_0Type Type { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum RoomTypes_V6_0Type
    {

        [System.Runtime.Serialization.EnumMember(Value = @"residencehallroom")]
        Residencehallroom = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"residentialsingleroom")]
        Residentialsingleroom = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"residentialdoubleroom")]
        Residentialdoubleroom = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"residentialtripleroom")]
        Residentialtripleroom = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"residentialsuiteroom")]
        Residentialsuiteroom = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"apartment")]
        Apartment = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"house")]
        House = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"classroom")]
        Classroom = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"lecturehall")]
        Lecturehall = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"seminarroom")]
        Seminarroom = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"conferenceroom")]
        Conferenceroom = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"sciencelaboratory")]
        Sciencelaboratory = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"computerlaboratory")]
        Computerlaboratory = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"mechanicslab")]
        Mechanicslab = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"audiovisuallab")]
        Audiovisuallab = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"artstudio")]
        Artstudio = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"musicroom")]
        Musicroom = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"performingartsstudio")]
        Performingartsstudio = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"ballroom")]
        Ballroom = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"office")]
        Office = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"studyfacility")]
        Studyfacility = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"clinic")]
        Clinic = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"animalquarters")]
        Animalquarters = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"greenhouse")]
        Greenhouse = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"specialusefacility")]
        Specialusefacility = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"generalusefacility")]
        Generalusefacility = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"foodfacility")]
        Foodfacility = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"daycare")]
        Daycare = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"lounge")]
        Lounge = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"merchandisingroom")]
        Merchandisingroom = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"supportfacility")]
        Supportfacility = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"healthcarefacility")]
        Healthcarefacility = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"atrium")]
        Atrium = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"amphitheater")]
        Amphitheater = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"auditorium")]
        Auditorium = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"booth")]
        Booth = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 36,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603