using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsumerDetailResp 
    {

        /// <summary>
        /// 消费堆积总数
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lag { get; set; }

        /// <summary>
        /// 消息总数
        /// </summary>
        [JsonProperty("max_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxOffset { get; set; }

        /// <summary>
        /// 已消费消息数
        /// </summary>
        [JsonProperty("consumer_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConsumerOffset { get; set; }

        /// <summary>
        /// Topic关联代理（当查询topic消费“详情”才显示此参数）。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Brokers> Brokers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerDetailResp {\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("  maxOffset: ").Append(MaxOffset).Append("\n");
            sb.Append("  consumerOffset: ").Append(ConsumerOffset).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerDetailResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lag == input.Lag ||
                    (this.Lag != null &&
                    this.Lag.Equals(input.Lag))
                ) && 
                (
                    this.MaxOffset == input.MaxOffset ||
                    (this.MaxOffset != null &&
                    this.MaxOffset.Equals(input.MaxOffset))
                ) && 
                (
                    this.ConsumerOffset == input.ConsumerOffset ||
                    (this.ConsumerOffset != null &&
                    this.ConsumerOffset.Equals(input.ConsumerOffset))
                ) && 
                (
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
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
                if (this.Lag != null)
                    hashCode = hashCode * 59 + this.Lag.GetHashCode();
                if (this.MaxOffset != null)
                    hashCode = hashCode * 59 + this.MaxOffset.GetHashCode();
                if (this.ConsumerOffset != null)
                    hashCode = hashCode * 59 + this.ConsumerOffset.GetHashCode();
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                return hashCode;
            }
        }
    }
}
