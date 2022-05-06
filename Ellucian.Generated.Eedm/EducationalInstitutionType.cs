// Copyright 2016-2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// EducationalInstitutionType enumeration 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EducationalInstitutionType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        
        /// <summary>
        /// private
        /// </summary>
        [EnumMember(Value = "secondarySchool")]
        SecondarySchool,

        /// <summary>
        /// public
        /// </summary>
        [EnumMember(Value = "postSecondarySchool")]
        PostSecondarySchool
    }
}