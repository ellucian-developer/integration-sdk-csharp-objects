// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// when deserializing a primitive type, it will convert the primitive JSON value to the target c# type whenever possible
    /// </summary>
    public class IntegerConverter : JsonConverter
    {
        readonly JsonSerializer defaultSerializer = new JsonSerializer();

        /// <summary>
        /// CanConvert
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public override bool CanConvert(Type type)
        {
            // return objectType.IsIntegerType();
            type = Nullable.GetUnderlyingType(type) ?? type;
            /*if (type == typeof(long)
                || type == typeof(ulong)
                || type == typeof(int)
                || type == typeof(uint)
                || type == typeof(short)
                || type == typeof(ushort)
                || type == typeof(byte)
                || type == typeof(sbyte)
                )*/
            if(type == typeof(string))
                return true;
            return false;
        }

        /// <summary>
        /// ReadJson
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float: // Accepts numbers like 4.00
                case JsonToken.Null:
                    //return defaultSerializer.Deserialize(reader, objectType);
                    throw new JsonSerializationException(string.Format("Token \"{0}\" of type {1} is a JSON integer.  Expected string", reader.Value, reader.TokenType));
                default:
                    //throw new JsonSerializationException(string.Format("Token \"{0}\" of type {1} was not a JSON integer", reader.Value, reader.TokenType));
                    return defaultSerializer.Deserialize(reader, objectType);
            }
        }

        /// <summary>
        /// CanWrite
        /// </summary>
        public override bool CanWrite { get { return false; } }

        /// <summary>
        /// WriteJson
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}