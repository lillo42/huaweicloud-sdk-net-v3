using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 创建通知规则的请求体
    /// </summary>
    public class CreateNotificationRequestBody 
    {
        /// <summary>
        /// 标识操作类型。 目前支持的操作类型有完整类型(complete)和自定义类型(customized)。 完整类型下，CTS发送通知的对象为已对接服务的所有事件，此时不用指定operations和notify_user_list字段。 自定义类型下，CTS发送通知的对象是在operations列表中指定的事件。
        /// </summary>
        /// <value>标识操作类型。 目前支持的操作类型有完整类型(complete)和自定义类型(customized)。 完整类型下，CTS发送通知的对象为已对接服务的所有事件，此时不用指定operations和notify_user_list字段。 自定义类型下，CTS发送通知的对象是在operations列表中指定的事件。</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum COMPLETE for value: complete
            /// </summary>
            public static readonly OperationTypeEnum COMPLETE = new OperationTypeEnum("complete");

            /// <summary>
            /// Enum CUSTOMIZED for value: customized
            /// </summary>
            public static readonly OperationTypeEnum CUSTOMIZED = new OperationTypeEnum("customized");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "complete", COMPLETE },
                { "customized", CUSTOMIZED },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
            }

            public static OperationTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云服务委托名称。 参数值为\&quot;cts_admin_trust\&quot;时，创建关键操作通知时会自动创建一个云服务委托：cts_admin_trust。
        /// </summary>
        /// <value>云服务委托名称。 参数值为\&quot;cts_admin_trust\&quot;时，创建关键操作通知时会自动创建一个云服务委托：cts_admin_trust。</value>
        [JsonConverter(typeof(EnumClassConverter<AgencyNameEnum>))]
        public class AgencyNameEnum
        {
            /// <summary>
            /// Enum CTS_ADMIN_TRUST for value: cts_admin_trust
            /// </summary>
            public static readonly AgencyNameEnum CTS_ADMIN_TRUST = new AgencyNameEnum("cts_admin_trust");

            private static readonly Dictionary<string, AgencyNameEnum> StaticFields =
            new Dictionary<string, AgencyNameEnum>()
            {
                { "cts_admin_trust", CTS_ADMIN_TRUST },
            };

            private string _value;

            public AgencyNameEnum()
            {

            }

            public AgencyNameEnum(string value)
            {
                _value = value;
            }

            public static AgencyNameEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as AgencyNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AgencyNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AgencyNameEnum a, AgencyNameEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AgencyNameEnum a, AgencyNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标识关键操作名称。
        /// </summary>
        [JsonProperty("notification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationName { get; set; }

        /// <summary>
        /// 标识操作类型。 目前支持的操作类型有完整类型(complete)和自定义类型(customized)。 完整类型下，CTS发送通知的对象为已对接服务的所有事件，此时不用指定operations和notify_user_list字段。 自定义类型下，CTS发送通知的对象是在operations列表中指定的事件。
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 云服务委托名称。 参数值为\&quot;cts_admin_trust\&quot;时，创建关键操作通知时会自动创建一个云服务委托：cts_admin_trust。
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyNameEnum AgencyName { get; set; }
        /// <summary>
        /// 操作事件列表。
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Operations> Operations { get; set; }

        /// <summary>
        /// 通知用户列表，目前最多支持对10个用户组和50个用户发起的操作进行配置。
        /// </summary>
        [JsonProperty("notify_user_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotificationUsers> NotifyUserList { get; set; }

        /// <summary>
        /// 消息通知服务的topic_urn或者函数工作流的func_urn。 - 消息通知服务的topic_urn可以通过消息通知服务的查询主题列表API获取，示例：urn:smn:regionId:f96188c7ccaf4ffba0c9aa149ab2bd57:test_topic_v2。 - 函数工作流的func_urn可以通过函数工作流的获取函数列表API获取，示例：urn:fss:xxxxxxxxx:7aad83af3e8d42e99ac194e8419e2c9b:function:default:test。
        /// </summary>
        [JsonProperty("topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNotificationRequestBody {\n");
            sb.Append("  notificationName: ").Append(NotificationName).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  notifyUserList: ").Append(NotifyUserList).Append("\n");
            sb.Append("  topicId: ").Append(TopicId).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNotificationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNotificationRequestBody input)
        {
            if (input == null) return false;
            if (this.NotificationName != input.NotificationName || (this.NotificationName != null && !this.NotificationName.Equals(input.NotificationName))) return false;
            if (this.OperationType != input.OperationType) return false;
            if (this.AgencyName != input.AgencyName) return false;
            if (this.Operations != input.Operations || (this.Operations != null && input.Operations != null && !this.Operations.SequenceEqual(input.Operations))) return false;
            if (this.NotifyUserList != input.NotifyUserList || (this.NotifyUserList != null && input.NotifyUserList != null && !this.NotifyUserList.SequenceEqual(input.NotifyUserList))) return false;
            if (this.TopicId != input.TopicId || (this.TopicId != null && !this.TopicId.Equals(input.TopicId))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;

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
                if (this.NotificationName != null) hashCode = hashCode * 59 + this.NotificationName.GetHashCode();
                hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.Operations != null) hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.NotifyUserList != null) hashCode = hashCode * 59 + this.NotifyUserList.GetHashCode();
                if (this.TopicId != null) hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
