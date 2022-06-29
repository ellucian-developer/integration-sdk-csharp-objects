//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person or organization who is designated to receive the financial benefit.
    /// </summary>
    [DataContract]
    public class PersonBeneficiariesBeneficiary
    {
        
        /// <summary>
        /// The person who is designated to receive the financial benefit.
        /// </summary>

        [DataMember(Name = "person", EmitDefaultValue = false)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The organization who is designated to receive the financial benefit.
        /// </summary>

        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public GuidObject2 Organization { get; set; }

        /// <summary>
        /// The name of the person or organization who is designated to receive the financial benefit.
        /// </summary>

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The institution who is designated to receive the financial benefit.
        /// </summary>

        [DataMember(Name = "institution", EmitDefaultValue = false)]
        public GuidObject2 Institution { get; set; }

    }
}
