using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EnableDeletionProtectionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 删除保护的标识位，如果不传默认为false，即默认不开启资源栈删除保护（删除保护开启后资源栈不允许被删除）
        /// </summary>
        [JsonProperty("enable_deletion_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDeletionProtection { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableDeletionProtectionPrimitiveTypeHolder {\n");
            sb.Append("  enableDeletionProtection: ").Append(EnableDeletionProtection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableDeletionProtectionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableDeletionProtectionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableDeletionProtection == input.EnableDeletionProtection ||
                    (this.EnableDeletionProtection != null &&
                    this.EnableDeletionProtection.Equals(input.EnableDeletionProtection))
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
                if (this.EnableDeletionProtection != null)
                    hashCode = hashCode * 59 + this.EnableDeletionProtection.GetHashCode();
                return hashCode;
            }
        }
    }
}
