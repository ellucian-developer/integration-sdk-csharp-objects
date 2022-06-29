// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// An indication whether the instructor is identified as the primary instructor for the section.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionInstructorsInstructorRole
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,
    }
} 


