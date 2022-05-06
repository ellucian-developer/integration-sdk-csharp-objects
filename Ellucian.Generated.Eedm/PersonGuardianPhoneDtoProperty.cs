using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The phone at which the contact can be reached.
    /// </summary>
    [DataContract]
    public class PersonGuardianPhoneDtoProperty
    {
        /// <summary>
        /// The guardian contact phone number.
        /// </summary>
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhoneTypes_V6_0 GuardianPhone { get; set; }

        /// <summary>
        /// The country calling code of telephone and/or mobile device when dialing internationally.
        /// </summary>
        [JsonProperty("countryCallingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// The number assigned to the phone.
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The extension used to connect to the phone when multiple phones share the same primary number.
        /// </summary>
        [JsonProperty("extension", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneExtension { get; set; }
    }
}
