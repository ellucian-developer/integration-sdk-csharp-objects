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
    /// The associated physical or mailing address of the contact
    /// </summary>
    [DataContract]
    public class PersonGuardianAddressDtoProperty
    {
        /// <summary>
        /// The contact address
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonContactAddressDtoProperty ContactAddress { get; set; }
    }
}
