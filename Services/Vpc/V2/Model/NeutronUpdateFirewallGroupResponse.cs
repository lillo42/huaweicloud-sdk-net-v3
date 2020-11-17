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
    /// Response Object
    /// </summary>
    public class NeutronUpdateFirewallGroupResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("firewall_group", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronFirewallGroup FirewallGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFirewallGroupResponse {\n");
            sb.Append("  firewallGroup: ").Append(FirewallGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFirewallGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFirewallGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallGroup == input.FirewallGroup ||
                    (this.FirewallGroup != null &&
                    this.FirewallGroup.Equals(input.FirewallGroup))
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
                if (this.FirewallGroup != null)
                    hashCode = hashCode * 59 + this.FirewallGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
