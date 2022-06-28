// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a type of location for a person
    /// </summary>

    [DataContract]
    public class PersonLocationType
    {
        /// <summary>
        /// The <see cref="PersonLocationTypeList">type</see> of location for a person
        /// </summary>
        [DataMember(Name = "locationType")]
        public PersonLocationTypeList PersonLocationTypeList { get; set; }
   }
}