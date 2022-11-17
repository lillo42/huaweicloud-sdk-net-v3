using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// UpdateRuleAclDto
    /// </summary>
    public class UpdateRuleAclDto 
    {
        /// <summary>
        /// 地址类型，0 ipv4,1 ipv6
        /// </summary>
        /// <value>地址类型，0 ipv4,1 ipv6</value>
        [JsonConverter(typeof(EnumClassConverter<AddressTypeEnum>))]
        public class AddressTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_0 = new AddressTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_1 = new AddressTypeEnum(1);

            private static readonly Dictionary<int?, AddressTypeEnum> StaticFields =
            new Dictionary<int?, AddressTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? Value;

            public AddressTypeEnum(int? value)
            {
                Value = value;
            }

            public static AddressTypeEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as AddressTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AddressTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AddressTypeEnum a, AddressTypeEnum b)
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

            public static bool operator !=(AddressTypeEnum a, AddressTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 规则方向
        /// </summary>
        /// <value>规则方向</value>
        [JsonConverter(typeof(EnumClassConverter<DirectionEnum>))]
        public class DirectionEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly DirectionEnum NUMBER_0 = new DirectionEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly DirectionEnum NUMBER_1 = new DirectionEnum(1);

            private static readonly Dictionary<int?, DirectionEnum> StaticFields =
            new Dictionary<int?, DirectionEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? Value;

            public DirectionEnum(int? value)
            {
                Value = value;
            }

            public static DirectionEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as DirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DirectionEnum a, DirectionEnum b)
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

            public static bool operator !=(DirectionEnum a, DirectionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 动作0：permit,1：deny
        /// </summary>
        /// <value>动作0：permit,1：deny</value>
        [JsonConverter(typeof(EnumClassConverter<ActionTypeEnum>))]
        public class ActionTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ActionTypeEnum NUMBER_0 = new ActionTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ActionTypeEnum NUMBER_1 = new ActionTypeEnum(1);

            private static readonly Dictionary<int?, ActionTypeEnum> StaticFields =
            new Dictionary<int?, ActionTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? Value;

            public ActionTypeEnum(int? value)
            {
                Value = value;
            }

            public static ActionTypeEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ActionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionTypeEnum a, ActionTypeEnum b)
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

            public static bool operator !=(ActionTypeEnum a, ActionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否支持长连接，0表示支持，1表示不支持
        /// </summary>
        /// <value>是否支持长连接，0表示支持，1表示不支持</value>
        [JsonConverter(typeof(EnumClassConverter<LongConnectEnableEnum>))]
        public class LongConnectEnableEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly LongConnectEnableEnum NUMBER_0 = new LongConnectEnableEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly LongConnectEnableEnum NUMBER_1 = new LongConnectEnableEnum(1);

            private static readonly Dictionary<int?, LongConnectEnableEnum> StaticFields =
            new Dictionary<int?, LongConnectEnableEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? Value;

            public LongConnectEnableEnum(int? value)
            {
                Value = value;
            }

            public static LongConnectEnableEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as LongConnectEnableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LongConnectEnableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(LongConnectEnableEnum a, LongConnectEnableEnum b)
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

            public static bool operator !=(LongConnectEnableEnum a, LongConnectEnableEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 地址类型，0 ipv4,1 ipv6
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public AddressTypeEnum AddressType { get; set; }
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public OrderRuleAclDto Sequence { get; set; }

        /// <summary>
        /// 规则方向
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 动作0：permit,1：deny
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public ActionTypeEnum ActionType { get; set; }
        /// <summary>
        /// 规则下发状态 0：禁用,1：启用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 长连接时长小时
        /// </summary>
        [JsonProperty("long_connect_time_hour", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeHour { get; set; }

        /// <summary>
        /// 长连接时长分钟
        /// </summary>
        [JsonProperty("long_connect_time_minute", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeMinute { get; set; }

        /// <summary>
        /// 长连接时长秒
        /// </summary>
        [JsonProperty("long_connect_time_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeSecond { get; set; }

        /// <summary>
        /// 长连接时长
        /// </summary>
        [JsonProperty("long_connect_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTime { get; set; }

        /// <summary>
        /// 是否支持长连接，0表示支持，1表示不支持
        /// </summary>
        [JsonProperty("long_connect_enable", NullValueHandling = NullValueHandling.Ignore)]
        public LongConnectEnableEnum LongConnectEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public RuleAddressDto Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public RuleAddressDto Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public RuleServiceDto Service { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRuleAclDto {\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  longConnectTimeHour: ").Append(LongConnectTimeHour).Append("\n");
            sb.Append("  longConnectTimeMinute: ").Append(LongConnectTimeMinute).Append("\n");
            sb.Append("  longConnectTimeSecond: ").Append(LongConnectTimeSecond).Append("\n");
            sb.Append("  longConnectTime: ").Append(LongConnectTime).Append("\n");
            sb.Append("  longConnectEnable: ").Append(LongConnectEnable).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRuleAclDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRuleAclDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LongConnectTimeHour == input.LongConnectTimeHour ||
                    (this.LongConnectTimeHour != null &&
                    this.LongConnectTimeHour.Equals(input.LongConnectTimeHour))
                ) && 
                (
                    this.LongConnectTimeMinute == input.LongConnectTimeMinute ||
                    (this.LongConnectTimeMinute != null &&
                    this.LongConnectTimeMinute.Equals(input.LongConnectTimeMinute))
                ) && 
                (
                    this.LongConnectTimeSecond == input.LongConnectTimeSecond ||
                    (this.LongConnectTimeSecond != null &&
                    this.LongConnectTimeSecond.Equals(input.LongConnectTimeSecond))
                ) && 
                (
                    this.LongConnectTime == input.LongConnectTime ||
                    (this.LongConnectTime != null &&
                    this.LongConnectTime.Equals(input.LongConnectTime))
                ) && 
                (
                    this.LongConnectEnable == input.LongConnectEnable ||
                    (this.LongConnectEnable != null &&
                    this.LongConnectEnable.Equals(input.LongConnectEnable))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
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
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.ActionType != null)
                    hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LongConnectTimeHour != null)
                    hashCode = hashCode * 59 + this.LongConnectTimeHour.GetHashCode();
                if (this.LongConnectTimeMinute != null)
                    hashCode = hashCode * 59 + this.LongConnectTimeMinute.GetHashCode();
                if (this.LongConnectTimeSecond != null)
                    hashCode = hashCode * 59 + this.LongConnectTimeSecond.GetHashCode();
                if (this.LongConnectTime != null)
                    hashCode = hashCode * 59 + this.LongConnectTime.GetHashCode();
                if (this.LongConnectEnable != null)
                    hashCode = hashCode * 59 + this.LongConnectEnable.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                return hashCode;
            }
        }
    }
}
