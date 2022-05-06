using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Ethnicity reporting
    /// </summary>
    [DataContract]
    public class EthnicityReporting
    {
        /// <summary>
        /// The ethnicity country with specific reporting requirements.
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public EthnicityReportingCountry EthnicityReportingCountry { get; set; }  
    }
}
