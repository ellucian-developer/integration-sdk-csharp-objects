// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// JSON converter for OrganizationRoleType enum - the automation
    /// people want to get a sensible message back on garbage input for enums.
    /// </summary>
    public class PersonPhoneTypeCategoryEnumConverter : StringEnumConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        /// 
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            try
            {
                return Enum.Parse(typeof(PersonPhoneTypeCategory), enumString, true);
            }
            catch
            {
                if (enumString == null) { enumString = "null"; }
                throw new ArgumentException("Person Phone Type", "Error converting supplied value '" + enumString + "' to a valid person phone type.");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
