/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.6.0-alpha.4
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosSubmitSelfServiceSettingsFlow
    /// </summary>
    [JsonConverter(typeof(KratosSubmitSelfServiceSettingsFlowJsonConverter))]
    [DataContract(Name = "submitSelfServiceSettingsFlow")]
    public partial class KratosSubmitSelfServiceSettingsFlow : AbstractOpenAPISchema, IEquatable<KratosSubmitSelfServiceSettingsFlow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlow" /> class
        /// with the <see cref="KratosSubmitSelfServiceSettingsFlowWithPasswordMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceSettingsFlowWithPasswordMethod.</param>
        public KratosSubmitSelfServiceSettingsFlow(KratosSubmitSelfServiceSettingsFlowWithPasswordMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlow" /> class
        /// with the <see cref="KratosSubmitSelfServiceSettingsFlowWithProfileMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceSettingsFlowWithProfileMethod.</param>
        public KratosSubmitSelfServiceSettingsFlow(KratosSubmitSelfServiceSettingsFlowWithProfileMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(KratosSubmitSelfServiceSettingsFlowWithPasswordMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosSubmitSelfServiceSettingsFlowWithProfileMethod))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosSubmitSelfServiceSettingsFlowWithPasswordMethod, KratosSubmitSelfServiceSettingsFlowWithProfileMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceSettingsFlowWithPasswordMethod`. If the actual instanct is not `KratosSubmitSelfServiceSettingsFlowWithPasswordMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlowWithPasswordMethod</returns>
        public KratosSubmitSelfServiceSettingsFlowWithPasswordMethod GetKratosSubmitSelfServiceSettingsFlowWithPasswordMethod()
        {
            return (KratosSubmitSelfServiceSettingsFlowWithPasswordMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceSettingsFlowWithProfileMethod`. If the actual instanct is not `KratosSubmitSelfServiceSettingsFlowWithProfileMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlowWithProfileMethod</returns>
        public KratosSubmitSelfServiceSettingsFlowWithProfileMethod GetKratosSubmitSelfServiceSettingsFlowWithProfileMethod()
        {
            return (KratosSubmitSelfServiceSettingsFlowWithProfileMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosSubmitSelfServiceSettingsFlow {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KratosSubmitSelfServiceSettingsFlow.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosSubmitSelfServiceSettingsFlow
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosSubmitSelfServiceSettingsFlow</returns>
        public static KratosSubmitSelfServiceSettingsFlow FromJson(string jsonString)
        {
            KratosSubmitSelfServiceSettingsFlow newKratosSubmitSelfServiceSettingsFlow = null;

            if (jsonString == null)
            {
                return newKratosSubmitSelfServiceSettingsFlow;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceSettingsFlowWithPasswordMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceSettingsFlow = new KratosSubmitSelfServiceSettingsFlow(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithPasswordMethod>(jsonString, KratosSubmitSelfServiceSettingsFlow.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceSettingsFlow = new KratosSubmitSelfServiceSettingsFlow(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithPasswordMethod>(jsonString, KratosSubmitSelfServiceSettingsFlow.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceSettingsFlowWithPasswordMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceSettingsFlowWithPasswordMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceSettingsFlowWithProfileMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceSettingsFlow = new KratosSubmitSelfServiceSettingsFlow(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithProfileMethod>(jsonString, KratosSubmitSelfServiceSettingsFlow.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceSettingsFlow = new KratosSubmitSelfServiceSettingsFlow(JsonConvert.DeserializeObject<KratosSubmitSelfServiceSettingsFlowWithProfileMethod>(jsonString, KratosSubmitSelfServiceSettingsFlow.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceSettingsFlowWithProfileMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceSettingsFlowWithProfileMethod: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosSubmitSelfServiceSettingsFlow;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosSubmitSelfServiceSettingsFlow);
        }

        /// <summary>
        /// Returns true if KratosSubmitSelfServiceSettingsFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSubmitSelfServiceSettingsFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSubmitSelfServiceSettingsFlow input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for KratosSubmitSelfServiceSettingsFlow
    /// </summary>
    public class KratosSubmitSelfServiceSettingsFlowJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((String)(typeof(KratosSubmitSelfServiceSettingsFlow).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return KratosSubmitSelfServiceSettingsFlow.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}