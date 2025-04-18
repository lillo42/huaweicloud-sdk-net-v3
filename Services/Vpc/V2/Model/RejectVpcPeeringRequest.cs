using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class RejectVpcPeeringRequest 
    {

        /// <summary>
        /// 对等连接ID
        /// </summary>
        [SDKProperty("peering_id", IsPath = true)]
        [JsonProperty("peering_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PeeringId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectVpcPeeringRequest {\n");
            sb.Append("  peeringId: ").Append(PeeringId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RejectVpcPeeringRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RejectVpcPeeringRequest input)
        {
            if (input == null) return false;
            if (this.PeeringId != input.PeeringId || (this.PeeringId != null && !this.PeeringId.Equals(input.PeeringId))) return false;

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
                if (this.PeeringId != null) hashCode = hashCode * 59 + this.PeeringId.GetHashCode();
                return hashCode;
            }
        }
    }
}
