using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTrafficMirrorFilterRuleRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_mirror_filter_rule", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTrafficMirrorFilterRuleOption TrafficMirrorFilterRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTrafficMirrorFilterRuleRequestBody {\n");
            sb.Append("  trafficMirrorFilterRule: ").Append(TrafficMirrorFilterRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTrafficMirrorFilterRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrafficMirrorFilterRuleRequestBody input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorFilterRule != input.TrafficMirrorFilterRule || (this.TrafficMirrorFilterRule != null && !this.TrafficMirrorFilterRule.Equals(input.TrafficMirrorFilterRule))) return false;

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
                if (this.TrafficMirrorFilterRule != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
