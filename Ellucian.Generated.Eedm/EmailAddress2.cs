// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an email address
    /// </summary>
    [DataContract]
    public class EmailAddress2 : BaseModel
    {
        /// <summary>
        /// The <see cref="EmailType">type</see> of email address
        /// </summary>
        [DataMember(Name = "type")]
        public EmailTypesV60 EmailType { get; set; }

        /// <summary>
        /// The <see cref="LifeCycleStatus">status</see> of the Email (Active or Inactive)
        /// </summary>
        [DataMember(Name = "status")]
        public LifeCycleStatus? Status { get; set; }

        /// <summary>
        /// The email address effective start date
        /// </summary>
        [DataMember(Name = "effectiveStart")]
        public DateTime? EffectiveStart { get; set; }

        /// <summary>
        /// The email address effective end date
        /// </summary>
        [DataMember(Name = "effectiveEnd")]
        public DateTime? EffectiveEnd { get; set; }

        /// <summary>
        /// The email address <see cref="ContactPreference">preference </see>
        /// </summary>
        [DataMember(Name = "preference")]
        public ContactPreference? Preference { get; set; }

        /// <summary>
        /// The email address
        /// </summary>
        [DataMember(Name = "address")]
        public string Address { get; set; }
    }
}