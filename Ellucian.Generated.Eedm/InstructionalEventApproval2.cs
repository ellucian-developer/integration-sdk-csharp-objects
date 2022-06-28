﻿// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An approval pertaining to an instructional event
    /// </summary>
    [JsonObject("approvals")]
    public class InstructionalEventApproval2
    {
        /// <summary>
        /// Approval type
        /// </summary>
        [JsonProperty("approvalType")]
        public InstructionalEventApprovalType2? Type { get; set; }

        /// <summary>
        /// Approval entity
        /// </summary>
        [JsonProperty("approvalEntity")]
        public InstructionalEventApprovalEntity2? ApprovingEntity { get; set; }
    }
}
