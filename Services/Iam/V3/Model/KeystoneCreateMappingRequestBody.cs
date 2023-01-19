using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KeystoneCreateMappingRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mapping", NullValueHandling = NullValueHandling.Ignore)]
        public MappingOption Mapping { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneCreateMappingRequestBody {\n");
            sb.Append("  mapping: ").Append(Mapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneCreateMappingRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneCreateMappingRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
                return hashCode;
            }
        }
    }
}
