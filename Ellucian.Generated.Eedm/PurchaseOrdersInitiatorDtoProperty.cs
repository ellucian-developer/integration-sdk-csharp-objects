// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The initiator of the purchase order
    /// </summary>
    [DataContract]
    public class PurchaseOrdersInitiatorDtoProperty
    {
        /// <summary>
        /// The name of the initiator
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The details of the person who initiated the purchase order
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The email address associated with the initiator
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the initiator
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public PhoneDtoProperty Phone { get; set; }

        /// <summary>
        /// The fax number of the initiator
        /// </summary>
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public PhoneDtoProperty Fax { get; set; }
    }
}