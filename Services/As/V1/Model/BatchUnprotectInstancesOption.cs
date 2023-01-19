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
    /// 批量取消实例保护
    /// </summary>
    public class BatchUnprotectInstancesOption 
    {
        /// <summary>
        /// 从伸缩组中移出实例时，是否删除云服务器。默认为no；可选值为yes或no。只有action为REMOVE时，这个字段才生效。
        /// </summary>
        /// <value>从伸缩组中移出实例时，是否删除云服务器。默认为no；可选值为yes或no。只有action为REMOVE时，这个字段才生效。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceDeleteEnum>))]
        public class InstanceDeleteEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly InstanceDeleteEnum YES = new InstanceDeleteEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly InstanceDeleteEnum NO = new InstanceDeleteEnum("no");

            private static readonly Dictionary<string, InstanceDeleteEnum> StaticFields =
            new Dictionary<string, InstanceDeleteEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string _value;

            public InstanceDeleteEnum()
            {

            }

            public InstanceDeleteEnum(string value)
            {
                _value = value;
            }

            public static InstanceDeleteEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceDeleteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceDeleteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceDeleteEnum a, InstanceDeleteEnum b)
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

            public static bool operator !=(InstanceDeleteEnum a, InstanceDeleteEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 批量操作实例action标识：添加：ADD  移除： REMOVE  设置实例保护： PROTECT  取消实例保护： UNPROTECT；转入备用状态：ENTER_STANDBY 移出备用状态:EXIT_STANDBY
        /// </summary>
        /// <value>批量操作实例action标识：添加：ADD  移除： REMOVE  设置实例保护： PROTECT  取消实例保护： UNPROTECT；转入备用状态：ENTER_STANDBY 移出备用状态:EXIT_STANDBY</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum UNPROTECT for value: UNPROTECT
            /// </summary>
            public static readonly ActionEnum UNPROTECT = new ActionEnum("UNPROTECT");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "UNPROTECT", UNPROTECT },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 将实例移入备用状态时，是否补充新的云服务器。取值如下：no：不补充新的实例，默认情况为no。yes：补充新的实例。只有action为ENTER_STANDBY时，这个字段才生效。
        /// </summary>
        /// <value>将实例移入备用状态时，是否补充新的云服务器。取值如下：no：不补充新的实例，默认情况为no。yes：补充新的实例。只有action为ENTER_STANDBY时，这个字段才生效。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceAppendEnum>))]
        public class InstanceAppendEnum
        {
            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly InstanceAppendEnum NO = new InstanceAppendEnum("no");

            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly InstanceAppendEnum YES = new InstanceAppendEnum("yes");

            private static readonly Dictionary<string, InstanceAppendEnum> StaticFields =
            new Dictionary<string, InstanceAppendEnum>()
            {
                { "no", NO },
                { "yes", YES },
            };

            private string _value;

            public InstanceAppendEnum()
            {

            }

            public InstanceAppendEnum(string value)
            {
                _value = value;
            }

            public static InstanceAppendEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceAppendEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceAppendEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceAppendEnum a, InstanceAppendEnum b)
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

            public static bool operator !=(InstanceAppendEnum a, InstanceAppendEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器ID。
        /// </summary>
        [JsonProperty("instances_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstancesId { get; set; }

        /// <summary>
        /// 从伸缩组中移出实例时，是否删除云服务器。默认为no；可选值为yes或no。只有action为REMOVE时，这个字段才生效。
        /// </summary>
        [JsonProperty("instance_delete", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceDeleteEnum InstanceDelete { get; set; }
        /// <summary>
        /// 批量操作实例action标识：添加：ADD  移除： REMOVE  设置实例保护： PROTECT  取消实例保护： UNPROTECT；转入备用状态：ENTER_STANDBY 移出备用状态:EXIT_STANDBY
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 将实例移入备用状态时，是否补充新的云服务器。取值如下：no：不补充新的实例，默认情况为no。yes：补充新的实例。只有action为ENTER_STANDBY时，这个字段才生效。
        /// </summary>
        [JsonProperty("instance_append", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceAppendEnum InstanceAppend { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUnprotectInstancesOption {\n");
            sb.Append("  instancesId: ").Append(InstancesId).Append("\n");
            sb.Append("  instanceDelete: ").Append(InstanceDelete).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  instanceAppend: ").Append(InstanceAppend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUnprotectInstancesOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUnprotectInstancesOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstancesId == input.InstancesId ||
                    this.InstancesId != null &&
                    input.InstancesId != null &&
                    this.InstancesId.SequenceEqual(input.InstancesId)
                ) && 
                (
                    this.InstanceDelete == input.InstanceDelete ||
                    (this.InstanceDelete != null &&
                    this.InstanceDelete.Equals(input.InstanceDelete))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.InstanceAppend == input.InstanceAppend ||
                    (this.InstanceAppend != null &&
                    this.InstanceAppend.Equals(input.InstanceAppend))
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
                if (this.InstancesId != null)
                    hashCode = hashCode * 59 + this.InstancesId.GetHashCode();
                if (this.InstanceDelete != null)
                    hashCode = hashCode * 59 + this.InstanceDelete.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.InstanceAppend != null)
                    hashCode = hashCode * 59 + this.InstanceAppend.GetHashCode();
                return hashCode;
            }
        }
    }
}
