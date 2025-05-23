using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 日志转储信息
    /// </summary>
    public class CreateTransferRequestBodyLogTransferInfo 
    {
        /// <summary>
        /// 日志转储方式。cycle是指周期性转储，realTime是指实时转储。OBS转储只支持\&quot;cycle\&quot;，DIS转储和DMS转储只支持\&quot;realTime\&quot;。
        /// </summary>
        /// <value>日志转储方式。cycle是指周期性转储，realTime是指实时转储。OBS转储只支持\&quot;cycle\&quot;，DIS转储和DMS转储只支持\&quot;realTime\&quot;。</value>
        [JsonConverter(typeof(EnumClassConverter<LogTransferModeEnum>))]
        public class LogTransferModeEnum
        {
            /// <summary>
            /// Enum CYCLE for value: cycle
            /// </summary>
            public static readonly LogTransferModeEnum CYCLE = new LogTransferModeEnum("cycle");

            /// <summary>
            /// Enum REALTIME for value: realTime
            /// </summary>
            public static readonly LogTransferModeEnum REALTIME = new LogTransferModeEnum("realTime");

            private static readonly Dictionary<string, LogTransferModeEnum> StaticFields =
            new Dictionary<string, LogTransferModeEnum>()
            {
                { "cycle", CYCLE },
                { "realTime", REALTIME },
            };

            private string _value;

            public LogTransferModeEnum()
            {

            }

            public LogTransferModeEnum(string value)
            {
                _value = value;
            }

            public static LogTransferModeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTransferModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTransferModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTransferModeEnum a, LogTransferModeEnum b)
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

            public static bool operator !=(LogTransferModeEnum a, LogTransferModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 日志转储格式。只支持\&quot;RAW\&quot;, \&quot;JSON\&quot;。RAW是指原始日志格式，JSON是指JSON日志格式。OBS转储和DIS转储支持JSON和RAW，DMS转储仅支持RAW
        /// </summary>
        /// <value>日志转储格式。只支持\&quot;RAW\&quot;, \&quot;JSON\&quot;。RAW是指原始日志格式，JSON是指JSON日志格式。OBS转储和DIS转储支持JSON和RAW，DMS转储仅支持RAW</value>
        [JsonConverter(typeof(EnumClassConverter<LogStorageFormatEnum>))]
        public class LogStorageFormatEnum
        {
            /// <summary>
            /// Enum JSON for value: JSON
            /// </summary>
            public static readonly LogStorageFormatEnum JSON = new LogStorageFormatEnum("JSON");

            /// <summary>
            /// Enum RAW for value: RAW
            /// </summary>
            public static readonly LogStorageFormatEnum RAW = new LogStorageFormatEnum("RAW");

            private static readonly Dictionary<string, LogStorageFormatEnum> StaticFields =
            new Dictionary<string, LogStorageFormatEnum>()
            {
                { "JSON", JSON },
                { "RAW", RAW },
            };

            private string _value;

            public LogStorageFormatEnum()
            {

            }

            public LogStorageFormatEnum(string value)
            {
                _value = value;
            }

            public static LogStorageFormatEnum FromValue(string value)
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

                if (this.Equals(obj as LogStorageFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogStorageFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogStorageFormatEnum a, LogStorageFormatEnum b)
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

            public static bool operator !=(LogStorageFormatEnum a, LogStorageFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 日志转储状态，只支持\&quot;ENABLE\&quot;,\&quot;DISABLE\&quot;,\&quot;EXCEPTION\&quot;。ENABLE是指日志转储开启状态，DISABLE是指日志转储关闭状态，EXCEPTION是指日志转储异常状态
        /// </summary>
        /// <value>日志转储状态，只支持\&quot;ENABLE\&quot;,\&quot;DISABLE\&quot;,\&quot;EXCEPTION\&quot;。ENABLE是指日志转储开启状态，DISABLE是指日志转储关闭状态，EXCEPTION是指日志转储异常状态</value>
        [JsonConverter(typeof(EnumClassConverter<LogTransferStatusEnum>))]
        public class LogTransferStatusEnum
        {
            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly LogTransferStatusEnum ENABLE = new LogTransferStatusEnum("ENABLE");

            /// <summary>
            /// Enum DISABLE for value: DISABLE
            /// </summary>
            public static readonly LogTransferStatusEnum DISABLE = new LogTransferStatusEnum("DISABLE");

            /// <summary>
            /// Enum EXCEPTION for value: EXCEPTION
            /// </summary>
            public static readonly LogTransferStatusEnum EXCEPTION = new LogTransferStatusEnum("EXCEPTION");

            private static readonly Dictionary<string, LogTransferStatusEnum> StaticFields =
            new Dictionary<string, LogTransferStatusEnum>()
            {
                { "ENABLE", ENABLE },
                { "DISABLE", DISABLE },
                { "EXCEPTION", EXCEPTION },
            };

            private string _value;

            public LogTransferStatusEnum()
            {

            }

            public LogTransferStatusEnum(string value)
            {
                _value = value;
            }

            public static LogTransferStatusEnum FromValue(string value)
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

                if (this.Equals(obj as LogTransferStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTransferStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTransferStatusEnum a, LogTransferStatusEnum b)
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

            public static bool operator !=(LogTransferStatusEnum a, LogTransferStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 日志转储类型。OBS指OBS日志转储，DIS指DIS日志转储，DMS指DMS日志转储
        /// </summary>
        [JsonProperty("log_transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTransferType { get; set; }

        /// <summary>
        /// 日志转储方式。cycle是指周期性转储，realTime是指实时转储。OBS转储只支持\&quot;cycle\&quot;，DIS转储和DMS转储只支持\&quot;realTime\&quot;。
        /// </summary>
        [JsonProperty("log_transfer_mode", NullValueHandling = NullValueHandling.Ignore)]
        public LogTransferModeEnum LogTransferMode { get; set; }
        /// <summary>
        /// 日志转储格式。只支持\&quot;RAW\&quot;, \&quot;JSON\&quot;。RAW是指原始日志格式，JSON是指JSON日志格式。OBS转储和DIS转储支持JSON和RAW，DMS转储仅支持RAW
        /// </summary>
        [JsonProperty("log_storage_format", NullValueHandling = NullValueHandling.Ignore)]
        public LogStorageFormatEnum LogStorageFormat { get; set; }
        /// <summary>
        /// 日志转储状态，只支持\&quot;ENABLE\&quot;,\&quot;DISABLE\&quot;,\&quot;EXCEPTION\&quot;。ENABLE是指日志转储开启状态，DISABLE是指日志转储关闭状态，EXCEPTION是指日志转储异常状态
        /// </summary>
        [JsonProperty("log_transfer_status", NullValueHandling = NullValueHandling.Ignore)]
        public LogTransferStatusEnum LogTransferStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_agency_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTransferRequestBodyLogTransferInfoLogAgencyTransfer LogAgencyTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_transfer_detail", NullValueHandling = NullValueHandling.Ignore)]
        public TransferDetail LogTransferDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransferRequestBodyLogTransferInfo {\n");
            sb.Append("  logTransferType: ").Append(LogTransferType).Append("\n");
            sb.Append("  logTransferMode: ").Append(LogTransferMode).Append("\n");
            sb.Append("  logStorageFormat: ").Append(LogStorageFormat).Append("\n");
            sb.Append("  logTransferStatus: ").Append(LogTransferStatus).Append("\n");
            sb.Append("  logAgencyTransfer: ").Append(LogAgencyTransfer).Append("\n");
            sb.Append("  logTransferDetail: ").Append(LogTransferDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTransferRequestBodyLogTransferInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTransferRequestBodyLogTransferInfo input)
        {
            if (input == null) return false;
            if (this.LogTransferType != input.LogTransferType || (this.LogTransferType != null && !this.LogTransferType.Equals(input.LogTransferType))) return false;
            if (this.LogTransferMode != input.LogTransferMode) return false;
            if (this.LogStorageFormat != input.LogStorageFormat) return false;
            if (this.LogTransferStatus != input.LogTransferStatus) return false;
            if (this.LogAgencyTransfer != input.LogAgencyTransfer || (this.LogAgencyTransfer != null && !this.LogAgencyTransfer.Equals(input.LogAgencyTransfer))) return false;
            if (this.LogTransferDetail != input.LogTransferDetail || (this.LogTransferDetail != null && !this.LogTransferDetail.Equals(input.LogTransferDetail))) return false;

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
                if (this.LogTransferType != null) hashCode = hashCode * 59 + this.LogTransferType.GetHashCode();
                hashCode = hashCode * 59 + this.LogTransferMode.GetHashCode();
                hashCode = hashCode * 59 + this.LogStorageFormat.GetHashCode();
                hashCode = hashCode * 59 + this.LogTransferStatus.GetHashCode();
                if (this.LogAgencyTransfer != null) hashCode = hashCode * 59 + this.LogAgencyTransfer.GetHashCode();
                if (this.LogTransferDetail != null) hashCode = hashCode * 59 + this.LogTransferDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
