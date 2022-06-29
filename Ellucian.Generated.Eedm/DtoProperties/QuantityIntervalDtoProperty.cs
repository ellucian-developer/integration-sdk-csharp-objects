// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The quantity and interval
    /// </summary>
    [DataContract]
    public class QuantityIntervalDtoProperty
    {
        /// <summary>
        /// The quantity.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal? Quantity { get; set; }
        
        /// <summary>
        /// The time interval 
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public IntervalTypes? Interval { get; set; }
    }
}