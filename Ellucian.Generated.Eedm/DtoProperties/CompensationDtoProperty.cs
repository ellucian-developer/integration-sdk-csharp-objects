// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The salary or wages awarded for the position.
    /// </summary>
    [DataContract]
    public class CompensationDtoProperty
    {
        /// <summary>
        /// The type of compensation awarded (e.g. salary, wages, etc.)
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public CompensationType Type { get; set; }

        /// <summary>
        /// The range of compensation awarded for the position.
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        public CompensationRangeDtoProperty Range { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CompensationDtoProperty()
        {          
        }
    }
}
