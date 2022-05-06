// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible valid reciprocal relationships
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidReciprocalRelationshipCategory
    {
        /// <summary>
        /// Parent
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,

        /// <summary>
        /// Step-Parent
        /// </summary>
        [EnumMember(Value = "stepParent")]
        StepParent,

        /// <summary>
        /// Mother
        /// </summary>
        [EnumMember(Value = "mother")]
        Mother,

        /// <summary>
        /// Step-Mother
        /// </summary>
        [EnumMember(Value = "stepMother")]
        StepMother,

        /// <summary>
        /// Father
        /// </summary>
        [EnumMember(Value = "father")]
        Father,

        /// <summary>
        /// Step-Father
        /// </summary>
        [EnumMember(Value = "stepFather")]
        StepFather,

        /// <summary>
        ///  Child
        /// </summary>
        [EnumMember(Value = "child")]
        Child,

        /// <summary>
        /// Stepchild
        /// </summary>
        [EnumMember(Value = "stepChild")]
        StepChild,

        /// <summary>
        /// Daughter
        /// </summary>
        [EnumMember(Value = "daughter")]
        Daughter,

        /// <summary>
        /// Step-Daughter
        /// </summary>
        [EnumMember(Value = "stepDaughter")]
        StepDaughter,

        /// <summary>
        /// Son
        /// </summary>
        [EnumMember(Value = "son")]
        Son,

        /// <summary>
        /// Step-Son
        /// </summary>
        [EnumMember(Value = "stepSon")]
        StepSon,

        /// <summary>
        /// Sibling
        /// </summary>
        [EnumMember(Value = "sibling")]
        Sibling,

        /// <summary>
        /// Step-Sibling
        /// </summary>
        [EnumMember(Value = "stepSibling")]
        StepSibling,

        /// <summary>
        /// Brother
        /// </summary>
        [EnumMember(Value = "brother")]
        Brother,

        /// <summary>
        /// StepBrother
        /// </summary>
        [EnumMember(Value = "stepBrother")]
        StepBrother,

        /// <summary>
        /// Sister
        /// </summary>
        [EnumMember(Value = "sister")]
        Sister,

        /// <summary>
        /// StepSister
        /// </summary>
        [EnumMember(Value = "stepSister")]
        StepSister,

        /// <summary>
        /// Spouse
        /// </summary>
        [EnumMember(Value = "spouse")]
        Spouse,

        /// <summary>
        /// Wife
        /// </summary>
        [EnumMember(Value = "wife")]
        Wife,

        /// <summary>
        /// Partner
        /// </summary>
        [EnumMember(Value = "partner")]
        Partner,

        /// <summary>
        /// Grandparent
        /// </summary>
        [EnumMember(Value = "grandParent")]
        GrandParent,

        /// <summary>
        /// Grandmother
        /// </summary>
        [EnumMember(Value = "grandMother")]
        GrandMother,

        /// <summary>
        /// Grandfather
        /// </summary>
        [EnumMember(Value = "grandFather")]
        GrandFather,

        /// <summary>
        /// Grandchild
        /// </summary>
        [EnumMember(Value = "grandChild")]
        GrandChild,

        /// <summary>
        /// Granddaughter
        /// </summary>
        [EnumMember(Value = "grandDaughter")]
        GrandDaughter,

        /// <summary>
        /// GrandSon
        /// </summary>
        [EnumMember(Value = "grandSon")]
        GrandSon,

        /// <summary>
        /// Parent-In-Law
        /// </summary>
        [EnumMember(Value = "parentInLaw")]
        ParentInLaw,

        /// <summary>
        /// Mother-In-Law
        /// </summary>
        [EnumMember(Value = "motherInLaw")]
        MotherInLaw,

        /// <summary>
        /// Father-In-Law
        /// </summary>
        [EnumMember(Value = "fatherInLaw")]
        FatherInLaw,

        /// <summary>
        /// Child-In-Law
        /// </summary>
        [EnumMember(Value = "childInLaw")]
        ChildInLaw,

        /// <summary>
        /// Daughter-In-Law
        /// </summary>
        [EnumMember(Value = "daughterInLaw")]
        DaughterInLaw,

        /// <summary>
        /// Son-In-Law
        /// </summary>
        [EnumMember(Value = "sonInLaw")]
        SonInLaw,

        /// <summary>
        /// Sibling-In-Law
        /// </summary>
        [EnumMember(Value = "siblingInLaw")]
        SiblingInLaw,

        /// <summary>
        /// Sister-In-law
        /// </summary>
        [EnumMember(Value = "sisterInLaw")]
        SisterInLaw,

        /// <summary>
        /// Brother-In-Law 
        /// </summary>
        [EnumMember(Value = "brotherInLaw")]
        BrotherInLaw,

        /// <summary>
        /// Sibling Of Parent
        /// </summary>
        [EnumMember(Value = "siblingOfParent")]
        SiblingOfParent,

        /// <summary>
        /// Aunt
        /// </summary>
        [EnumMember(Value = "aunt")]
        Aunt,

        /// <summary>
        /// Uncle
        /// </summary>
        [EnumMember(Value = "uncle")]
        Uncle,

        /// <summary>
        /// Child Of Sibling
        /// </summary>
        [EnumMember(Value = "childOfSibling")]
        ChildOfSibling,

        /// <summary>
        /// Niece
        /// </summary>
        [EnumMember(Value = "niece")]
        Niece,

        /// <summary>
        /// Nephew
        /// </summary>
        [EnumMember(Value = "nephew")]
        Nephew,

        /// <summary>
        /// Cousin
        /// </summary>
        [EnumMember(Value = "cousin")]
        Cousin,

        /// <summary>
        /// Friend
        /// </summary>
        [EnumMember(Value = "friend")]
        Friend,

        /// <summary>
        /// Relative
        /// </summary>
        [EnumMember(Value = "relative")]
        Relative,

        /// <summary>
        /// Coworker
        /// </summary>
        [EnumMember(Value = "coworker")]
        Coworker,

        /// <summary>
        /// Neighbor
        /// </summary>
        [EnumMember(Value = "neighbor")]
        Neighbor,

        /// <summary>
        /// Classmate
        /// </summary>
        [EnumMember(Value = "classmate")]
        Classmate,

        /// <summary>
        /// Caregiver
        /// </summary>
        [EnumMember(Value = "caregiver")]
        Caregiver,


        /// <summary>
        /// Husband
        /// </summary>
        [EnumMember(Value = "husband")]
        Husband,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

    }
}