using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateBindingResponse : SdkResponse
    {

        /// <summary>
        /// 绑定对象
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 绑定Exchange或者Queue
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }

        /// <summary>
        /// 要投递的Exchange或Queue名称
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 绑定键值，用于告知Exchange应该将消息投递到哪些Queue中
        /// </summary>
        [JsonProperty("routing_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutingKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBindingResponse {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  routingKey: ").Append(RoutingKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBindingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBindingResponse input)
        {
            if (input == null) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.DestinationType != input.DestinationType || (this.DestinationType != null && !this.DestinationType.Equals(input.DestinationType))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.RoutingKey != input.RoutingKey || (this.RoutingKey != null && !this.RoutingKey.Equals(input.RoutingKey))) return false;

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
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.DestinationType != null) hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.RoutingKey != null) hashCode = hashCode * 59 + this.RoutingKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
