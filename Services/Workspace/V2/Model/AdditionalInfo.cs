using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 告警记录额外字段，仅针对事件监控告警场景所产生的告警记录信息。
    /// </summary>
    public class AdditionalInfo 
    {

        /// <summary>
        /// 该条告警记录对应的资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 该条告警记录对应的资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 该条告警记录对应的事件监控ID，资源所产生的事件
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalInfo {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdditionalInfo input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                return hashCode;
            }
        }
    }
}
