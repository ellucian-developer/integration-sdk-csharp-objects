// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// This converter overrides json.net's default IsoDateTimeConverter when
    /// de-serializing DateTime objects where only the date is needed
    /// </summary>
    public class DateOnlyConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateOnlyConverter" /> class.
        /// </summary>
        public DateOnlyConverter()
        {
            DateTimeFormat = "yyyy'-'MM'-'dd";
        }
    }
}