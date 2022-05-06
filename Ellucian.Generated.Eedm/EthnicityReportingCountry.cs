using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Race reporting items
    /// </summary>
    [DataContract]
    public class EthnicityReportingCountry
    {
        /// <summary>
        /// The country code for the United States of America.",
        /// </summary>
        [DataMember(Name = "code")]
        public CountryCodeType CountryCode { get; set; }

        /// <summary>
        /// The global category of ethnic origin to which a person belongs.
        /// </summary>
        [DataMember(Name = "ethnicCategory", EmitDefaultValue = false)]
        public EthnicityType2? EthnicCategory { get; set; }
    }
}
