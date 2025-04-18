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
    /// 
    /// </summary>
    public class CreateScheduledTaskOption 
    {

        /// <summary>
        /// 计划任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduled_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledTaskPolicy ScheduledPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public IntegerRange InstanceNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduledTaskOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  scheduledPolicy: ").Append(ScheduledPolicy).Append("\n");
            sb.Append("  instanceNumber: ").Append(InstanceNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScheduledTaskOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScheduledTaskOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ScheduledPolicy != input.ScheduledPolicy || (this.ScheduledPolicy != null && !this.ScheduledPolicy.Equals(input.ScheduledPolicy))) return false;
            if (this.InstanceNumber != input.InstanceNumber || (this.InstanceNumber != null && !this.InstanceNumber.Equals(input.InstanceNumber))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ScheduledPolicy != null) hashCode = hashCode * 59 + this.ScheduledPolicy.GetHashCode();
                if (this.InstanceNumber != null) hashCode = hashCode * 59 + this.InstanceNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
