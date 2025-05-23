using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListScalingV2PoliciesResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNumber { get; set; }

        /// <summary>
        /// 查询的起始行号。
        /// </summary>
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 伸缩策略列表
        /// </summary>
        [JsonProperty("scaling_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingPoliciesV2> ScalingPolicies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingV2PoliciesResponse {\n");
            sb.Append("  totalNumber: ").Append(TotalNumber).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  scalingPolicies: ").Append(ScalingPolicies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingV2PoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingV2PoliciesResponse input)
        {
            if (input == null) return false;
            if (this.TotalNumber != input.TotalNumber || (this.TotalNumber != null && !this.TotalNumber.Equals(input.TotalNumber))) return false;
            if (this.StartNumber != input.StartNumber || (this.StartNumber != null && !this.StartNumber.Equals(input.StartNumber))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ScalingPolicies != input.ScalingPolicies || (this.ScalingPolicies != null && input.ScalingPolicies != null && !this.ScalingPolicies.SequenceEqual(input.ScalingPolicies))) return false;

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
                if (this.TotalNumber != null) hashCode = hashCode * 59 + this.TotalNumber.GetHashCode();
                if (this.StartNumber != null) hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ScalingPolicies != null) hashCode = hashCode * 59 + this.ScalingPolicies.GetHashCode();
                return hashCode;
            }
        }
    }
}
