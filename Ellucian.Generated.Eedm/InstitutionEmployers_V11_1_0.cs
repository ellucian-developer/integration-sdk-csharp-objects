//Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A detailed description of the job at an institution. 
    /// </summary>
    [DataContract]
    public class InstitutionEmployers_V11_1_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the institution employer.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// A code that may be used to identify the institution employer.
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Code { get; set; }

        /// <summary>
        /// The physical address associated with the institution employer.
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InstitutionEmployersAddress Address { get; set; }   

        /// <summary>
        /// The phone number associated with the employer.
        /// </summary>
        [JsonProperty("phoneNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneNumber { get; set; }
    }
}
