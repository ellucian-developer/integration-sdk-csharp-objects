using Ellucian.Generated.Eedm;
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
    public class RaceReportingCountry
    {
        /// <summary>
        /// The country code for the United States of America.",
        /// </summary>
        [DataMember(Name = "code")]
        public CountryCodeType CountryCode { get; set; }

        /// <summary>
        /// Properties required for governmental or other reporting."
        /// </summary>
        [DataMember(Name = "racialCategory", EmitDefaultValue = false)]
        public ReportingRacialCategory? ReportingRacialCategory { get; set; }
    }
}
