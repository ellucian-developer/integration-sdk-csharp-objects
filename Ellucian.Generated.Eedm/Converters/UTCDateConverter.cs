// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// This converter overrides json.net's default IsoDateTimeConverter when
    /// deserializing DateTime objects to UTC format
    /// </summary>
    public class UTCDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UTCDateConverter" /> class.
        /// </summary>
        public UTCDateConverter()
        {
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";
           
        }
    }
}