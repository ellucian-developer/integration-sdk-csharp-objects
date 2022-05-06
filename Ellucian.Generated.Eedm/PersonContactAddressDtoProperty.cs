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
    /// The associated physical ormailing address of the contact.
    /// </summary>
    [DataContract]
    public class PersonContactAddressDtoProperty
    {
        /// <summary>
        /// A type of address for a person. Includes a standard type (e.g. 'home', 'school') and an optional, custom type to further identify the type of address.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonAddressTypeDtoProperty PersonAddressType { get; set; }

        /// <summary>
        /// The address lines e.g., street name and building number, apartment or suite, etc.
        /// </summary>
        [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> AddressLines { get; set; }

        /// <summary>
        /// A country specific postal region.  Postal regions are expressed as a hierarchy of country, region, and sub-region, and as a locality with postal automation codes.
        /// </summary>
        [JsonProperty("place", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AddressCountry MyProperty { get; set; }
    }
}
