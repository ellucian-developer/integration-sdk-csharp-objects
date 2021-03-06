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

namespace Ellucian.Generated.Eedm.PersonalRelationshipTypes_V6_0
{
    using System = global::System;

    

    /// <summary>
    /// A type of relationship between people.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonalRelationshipTypes_V6_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the personal relationship type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of the personal relationship type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The full description of the personal  relationship type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Type of relationships between two people
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relationshipType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PersonalRelationshipTypes_V6_0RelationshipType RelationshipType { get; set; } = default!;

        /// <summary>
        /// Valid reciprocal relationships that a direct relationship of a person can have.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validReciprocalRelationships", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ValidReciprocalRelationships>? ValidReciprocalRelationships { get; set; } = default!;

        /// <summary>
        /// The code of the personal  relationship type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PersonalRelationshipTypes_V6_0RelationshipType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"parent")]
        Parent = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"stepParent")]
        StepParent = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"mother")]
        Mother = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"stepMother")]
        StepMother = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"father")]
        Father = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"stepFather")]
        StepFather = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"child")]
        Child = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"stepChild")]
        StepChild = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"daughter")]
        Daughter = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"stepDaughter")]
        StepDaughter = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"son")]
        Son = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"stepSon")]
        StepSon = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"sibling")]
        Sibling = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"stepSibling")]
        StepSibling = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"brother")]
        Brother = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"stepBrother")]
        StepBrother = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"sister")]
        Sister = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"stepSister")]
        StepSister = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"spouse")]
        Spouse = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"wife")]
        Wife = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"partner")]
        Partner = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"grandParent")]
        GrandParent = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"grandMother")]
        GrandMother = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"grandFather")]
        GrandFather = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"grandChild")]
        GrandChild = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"grandDaughter")]
        GrandDaughter = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"grandSon")]
        GrandSon = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"parentInLaw")]
        ParentInLaw = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"motherInLaw")]
        MotherInLaw = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"fatherInLaw")]
        FatherInLaw = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"childInLaw")]
        ChildInLaw = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"daughterInLaw")]
        DaughterInLaw = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"sonInLaw")]
        SonInLaw = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"siblingInLaw")]
        SiblingInLaw = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"sisterInLaw")]
        SisterInLaw = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"brotherInLaw")]
        BrotherInLaw = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"siblingOfParent")]
        SiblingOfParent = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"aunt")]
        Aunt = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"uncle")]
        Uncle = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"childOfSibling")]
        ChildOfSibling = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"niece")]
        Niece = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"nephew")]
        Nephew = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"cousin")]
        Cousin = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"friend")]
        Friend = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"relative")]
        Relative = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"coworker")]
        Coworker = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"neighbor")]
        Neighbor = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"classmate")]
        Classmate = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"caregiver")]
        Caregiver = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"husband")]
        Husband = 50,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ValidReciprocalRelationships
    {
        /// <summary>
        /// The type of the reciprocal relationship.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ValidReciprocalRelationshipsType? Type { get; set; } = default!;

        /// <summary>
        /// The extension to the type of the reciprocal relationship.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Detail? Detail { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ValidReciprocalRelationshipsType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"parent")]
        Parent = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"stepParent")]
        StepParent = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"mother")]
        Mother = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"stepMother")]
        StepMother = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"father")]
        Father = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"stepFather")]
        StepFather = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"child")]
        Child = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"stepChild")]
        StepChild = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"daughter")]
        Daughter = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"stepDaughter")]
        StepDaughter = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"son")]
        Son = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"stepSon")]
        StepSon = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"sibling")]
        Sibling = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"stepSibling")]
        StepSibling = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"brother")]
        Brother = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"stepBrother")]
        StepBrother = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"sister")]
        Sister = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"stepSister")]
        StepSister = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"spouse")]
        Spouse = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"wife")]
        Wife = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"partner")]
        Partner = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"grandParent")]
        GrandParent = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"grandMother")]
        GrandMother = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"grandFather")]
        GrandFather = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"grandChild")]
        GrandChild = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"grandDaughter")]
        GrandDaughter = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"grandSon")]
        GrandSon = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"parentInLaw")]
        ParentInLaw = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"motherInLaw")]
        MotherInLaw = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"fatherInLaw")]
        FatherInLaw = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"childInLaw")]
        ChildInLaw = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"daughterInLaw")]
        DaughterInLaw = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"sonInLaw")]
        SonInLaw = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"siblingInLaw")]
        SiblingInLaw = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"sisterInLaw")]
        SisterInLaw = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"brotherInLaw")]
        BrotherInLaw = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"siblingOfParent")]
        SiblingOfParent = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"aunt")]
        Aunt = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"uncle")]
        Uncle = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"childOfSibling")]
        ChildOfSibling = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"niece")]
        Niece = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"nephew")]
        Nephew = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"cousin")]
        Cousin = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"friend")]
        Friend = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"relative")]
        Relative = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"coworker")]
        Coworker = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"neighbor")]
        Neighbor = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"classmate")]
        Classmate = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"caregiver")]
        Caregiver = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"husband")]
        Husband = 50,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Detail
    {
        /// <summary>
        /// The global identifier for the Detail.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603