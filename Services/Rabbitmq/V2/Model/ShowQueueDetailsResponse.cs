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
    public class ShowQueueDetailsResponse : SdkResponse
    {

        /// <summary>
        /// Queue所属Vhost名称
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// Queue名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否持久化
        /// </summary>
        [JsonProperty("durable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Durable { get; set; }

        /// <summary>
        /// 是否自动删除
        /// </summary>
        [JsonProperty("auto_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDelete { get; set; }

        /// <summary>
        /// 待消费消息数
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? Messages { get; set; }

        /// <summary>
        /// 连接的消费者数
        /// </summary>
        [JsonProperty("consumers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Consumers { get; set; }

        /// <summary>
        /// 策略[（AMQP版本不支持policy，不涉及此参数）](tag:hws,hws_hk)
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public QueueArguments Arguments { get; set; }

        /// <summary>
        /// 订阅该Queue的消费者信息。
        /// </summary>
        [JsonProperty("consumer_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConsumerDetails> ConsumerDetails { get; set; }

        /// <summary>
        /// 以此Queue为目标的绑定信息列表。
        /// </summary>
        [JsonProperty("queue_bindings", NullValueHandling = NullValueHandling.Ignore)]
        public List<BindingsDetails> QueueBindings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQueueDetailsResponse {\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  durable: ").Append(Durable).Append("\n");
            sb.Append("  autoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("  consumers: ").Append(Consumers).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  arguments: ").Append(Arguments).Append("\n");
            sb.Append("  consumerDetails: ").Append(ConsumerDetails).Append("\n");
            sb.Append("  queueBindings: ").Append(QueueBindings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQueueDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQueueDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Vhost != input.Vhost || (this.Vhost != null && !this.Vhost.Equals(input.Vhost))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Durable != input.Durable || (this.Durable != null && !this.Durable.Equals(input.Durable))) return false;
            if (this.AutoDelete != input.AutoDelete || (this.AutoDelete != null && !this.AutoDelete.Equals(input.AutoDelete))) return false;
            if (this.Messages != input.Messages || (this.Messages != null && !this.Messages.Equals(input.Messages))) return false;
            if (this.Consumers != input.Consumers || (this.Consumers != null && !this.Consumers.Equals(input.Consumers))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.Arguments != input.Arguments || (this.Arguments != null && !this.Arguments.Equals(input.Arguments))) return false;
            if (this.ConsumerDetails != input.ConsumerDetails || (this.ConsumerDetails != null && input.ConsumerDetails != null && !this.ConsumerDetails.SequenceEqual(input.ConsumerDetails))) return false;
            if (this.QueueBindings != input.QueueBindings || (this.QueueBindings != null && input.QueueBindings != null && !this.QueueBindings.SequenceEqual(input.QueueBindings))) return false;

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
                if (this.Vhost != null) hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Durable != null) hashCode = hashCode * 59 + this.Durable.GetHashCode();
                if (this.AutoDelete != null) hashCode = hashCode * 59 + this.AutoDelete.GetHashCode();
                if (this.Messages != null) hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Consumers != null) hashCode = hashCode * 59 + this.Consumers.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Arguments != null) hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.ConsumerDetails != null) hashCode = hashCode * 59 + this.ConsumerDetails.GetHashCode();
                if (this.QueueBindings != null) hashCode = hashCode * 59 + this.QueueBindings.GetHashCode();
                return hashCode;
            }
        }
    }
}
