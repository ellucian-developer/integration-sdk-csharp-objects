// Copyright 2016-2021 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Resources API provides a mechanism by which callers can view a list of Ethos resources that are exposed through the server API.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, IsReference = false)]
    public class ApiResources
    {
        /// <summary>
        /// The full name of the resource.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A collection of representations
        /// </summary>
        [JsonProperty("representations")]
        public List<Representation> Representations { get; set; }
    }

    /// <summary>
    /// Representation
    /// </summary>
    public class Representation
    {
        /// <summary>
        /// X-Media-Type
        /// </summary>
        [JsonProperty("X-Media-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XMediaType { get; set; }

        /// <summary>
        /// Methods GET, PUT, POST and DELETE
        /// </summary>
        [JsonProperty("methods")]
        public List<string> Methods { get; set; }

        /// <summary>
        /// Array of any supported get all patterns, paging and batch.
        /// </summary>
        [JsonProperty("customizations", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customizations Customizations { get; set; }


        /// <summary>
        /// Array of any supported filters by the API in json dot notation. This is not included if no filters are supported
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Filters { get; set; }

        /// <summary>
        /// Array of any supported get all patterns, paging and batch.
        /// </summary>
        [JsonProperty("getAllPatterns", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GetAllPattern> GetAllPatterns { get; set; }

        /// <summary>
        /// Array of any supported named queries by the API in json dot notation. This is not included if no named queries are supported.
        /// </summary>
        [JsonProperty("namedQueries", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<NamedQuery> NamedQueries { get; set; }

        /// <summary>
        /// Deprecation notice
        /// </summary>
        [JsonProperty("deprecationNotice", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DeprecationNotice DeprecationNotice { get; set; }

        /*
        /// <summary>
        /// PageSize - Used for doc generation only.  Uncomment as needed.
        /// </summary>
         [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
         public int? PageSize { get; set; }
         */

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

    }

    /// <summary>
    /// Information about extensibility and data privacy configuration
    /// </summary>
    public class Customizations
    {
        /// <summary>
        /// If data privacy rules have been defined
        /// </summary>
        [JsonProperty("hasPrivacyRules", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HasPrivacyRules { get; set; }

        /// <summary>
        /// If the resource representation is a full custom/extended/spec driven resource
        /// </summary>
        [JsonProperty("isCustomResource", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsCustomResource { get; set; }

        /// <summary>
        /// If extended properties have been added
        /// </summary>
        [JsonProperty("hasExtendedProperties", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HasExtendedProperties { get; set; }
    }


    /// <summary>
    /// Patterns for GetAll support, Paging or Batch.
    /// </summary>
    public class GetAllPattern
    {
        /// <summary>
        /// paging or batch
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// get or post
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// the custom media type supported
        /// </summary>
        [JsonProperty("X-Media-Type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string XMediaType { get; set; }
    }

    /// <summary>
    /// NamedQuery
    /// </summary>
    public class NamedQuery
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Array of any supported filters by the API in json dot notation. This is not included if no filters are supported
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Filters { get; set; }
    }

    /// <summary>
    /// DeprecationNotice
    /// </summary>
    public class DeprecationNotice
    {
        /// <summary>
        /// Deprecated On
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("deprecatedOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeprecatedOn { get; set; }

        /// <summary>
        /// Sunset On
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("sunsetOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SunsetOn { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}