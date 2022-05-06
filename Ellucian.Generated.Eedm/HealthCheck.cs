using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// API status information.
    /// </summary>
    public class HealthCheck
    {
        /// <summary>
        /// Api status
        /// </summary>
        [JsonProperty("status")]
        public HealthCheckType Status { get; set; }

        /// <summary>
        /// Constructor for ApiStatus
        /// </summary>
        [JsonConstructor]
        public HealthCheck()
        {
        }

        /// <summary>
        /// Constructor for ApiStatus
        /// </summary>
        /// <param name="status">Api status</param>
        public HealthCheck(HealthCheckType status)
        {
            Status = status;
        }
    }
}
