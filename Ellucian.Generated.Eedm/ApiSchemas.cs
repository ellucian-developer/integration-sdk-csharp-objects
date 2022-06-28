// Copyright 2016-2021 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Resources API provides a mechanism by which callers can view a list of Ethos resources that are exposed through the server API.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, IsReference = false)]
    public class ApiSchemas
    {
        /// <summary>
        /// The full name of the resource.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// The XMediaType of the resource.  Do not display
        /// </summary>
        
        public string XMediaType { get; set; }

        /// <summary>
        /// AlternativeRepresentation the resource.  Do not display
        /// </summary>

        public string AlternativeRepresentation { get; set; }


        /// <summary>
        /// A collection of representations
        /// </summary>
        //[JsonProperty("representations")]
        public List<SchemaRepresentation> Representations { get; set; }

        
    }

    /// <summary>
    /// SchemaRepresentation
    /// </summary>
    public class SchemaRepresentation
    {
        /// <summary>
        /// X-Media-Type
        /// </summary>
        [JsonProperty("X-Media-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XMediaType { get; set; }

        /// <summary>
        /// Used by the resources controller to determine which versionless route is most current.  
        /// Does not appear in output
        /// </summary>
        [JsonIgnore]
        public string VersionNumber { get; set; }

        /// <summary>
        /// Flag to indicate if the major number route has been added for this mediatype. 
        /// Does not appear in output
        /// </summary>
        [JsonIgnore]
        public bool MajorVersionAdded { get; set; }

        /// <summary>
        /// A collection of schemas
        /// </summary>
        public string Schema { get; set; }

    }
}