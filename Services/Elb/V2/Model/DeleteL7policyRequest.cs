using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteL7policyRequest 
    {

        /// <summary>
        /// 转发策略id
        /// </summary>
        [SDKProperty("l7policy_id", IsPath = true)]
        [JsonProperty("l7policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7policyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteL7policyRequest {\n");
            sb.Append("  l7policyId: ").Append(L7policyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteL7policyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteL7policyRequest input)
        {
            if (input == null) return false;
            if (this.L7policyId != input.L7policyId || (this.L7policyId != null && !this.L7policyId.Equals(input.L7policyId))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.L7policyId != null) hashCode = hashCode * 59 + this.L7policyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
