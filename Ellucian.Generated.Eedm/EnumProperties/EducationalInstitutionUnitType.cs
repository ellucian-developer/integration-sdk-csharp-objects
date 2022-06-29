// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of the unit (e.g., school, division, department, etc.)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EducationalInstitutionUnitType
    {
        /// <summary>
        /// Default value
        /// </summary>
        NotSet = 0,

        /// <summary> 
        /// College 
        /// </summary> 
        [EnumMember(Value = "college")]
        College,

        /// <summary> 
        /// School 
        /// </summary> 
        [EnumMember(Value = "school")]
        School,

        /// <summary> 
        /// Division
        /// </summary> 
        [EnumMember(Value = "division")]
        Division,

        /// <summary> 
        /// Department 
        /// </summary> 
        [EnumMember(Value = "department")]
        Department,

        /// <summary> 
        /// Institute 
        /// </summary> 
        [EnumMember(Value = "institute")]
        Institute,

        /// <summary> 
        /// Facility 
        /// </summary> 
        [EnumMember(Value = "facility")]
        Facility,

        /// <summary> 
        /// Office 
        /// </summary> 
        [EnumMember(Value = "office")]
        Office
    }
}