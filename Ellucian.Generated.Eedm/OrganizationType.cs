// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of organization.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganizationType
    {
        /// <summary>
        /// Educational institution or establishment that can stand alone or exist within a university
        /// </summary>
        College, 

        /// <summary>
        /// Segment of a division dealing with a specific subject or area of activity
        /// </summary>
        Department, 

        /// <summary>
        /// Segment of an school
        /// </summary>
        Division,
 
        /// <summary>
        /// Segment of faculty members within a department
        /// </summary>
        Faculty,
 
        /// <summary>
        /// Segment of an institution dealing with a specific discipline within an institution
        /// </summary>
        School, 

        /// <summary>
        /// Higher education institution 
        /// </summary>
        University
    }
}