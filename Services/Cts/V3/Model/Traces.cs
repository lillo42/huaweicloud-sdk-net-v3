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
    /// 
    /// </summary>
    public class Traces 
    {
        /// <summary>
        /// 标识事件等级，目前有三种：正常（normal），警告（warning），事故（incident）。
        /// </summary>
        /// <value>标识事件等级，目前有三种：正常（normal），警告（warning），事故（incident）。</value>
        [JsonConverter(typeof(EnumClassConverter<TraceRatingEnum>))]
        public class TraceRatingEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly TraceRatingEnum NORMAL = new TraceRatingEnum("normal");

            /// <summary>
            /// Enum WARNING for value: warning
            /// </summary>
            public static readonly TraceRatingEnum WARNING = new TraceRatingEnum("warning");

            /// <summary>
            /// Enum INCIDENT for value: incident
            /// </summary>
            public static readonly TraceRatingEnum INCIDENT = new TraceRatingEnum("incident");

            private static readonly Dictionary<string, TraceRatingEnum> StaticFields =
            new Dictionary<string, TraceRatingEnum>()
            {
                { "normal", NORMAL },
                { "warning", WARNING },
                { "incident", INCIDENT },
            };

            private string _value;

            public TraceRatingEnum()
            {

            }

            public TraceRatingEnum(string value)
            {
                _value = value;
            }

            public static TraceRatingEnum FromValue(string value)
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

                if (this.Equals(obj as TraceRatingEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TraceRatingEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TraceRatingEnum a, TraceRatingEnum b)
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

            public static bool operator !=(TraceRatingEnum a, TraceRatingEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标识事件对应的云服务资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 标识查询事件列表对应的事件名称。由0-9,a-z,A-Z,&#39;-&#39;,&#39;.&#39;,&#39;_&#39;,组成，长度为1～64个字符，且以首字符必须为字母。
        /// </summary>
        [JsonProperty("trace_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceName { get; set; }

        /// <summary>
        /// 标识事件等级，目前有三种：正常（normal），警告（warning），事故（incident）。
        /// </summary>
        [JsonProperty("trace_rating", NullValueHandling = NullValueHandling.Ignore)]
        public TraceRatingEnum TraceRating { get; set; }
        /// <summary>
        /// 标识事件发生源头类型，管理类事件主要包括API调用（ApiCall），Console页面调用（ConsoleAction）和系统间调用（SystemAction）。 数据类事件主要包括ObsSDK，ObsAPI。
        /// </summary>
        [JsonProperty("trace_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceType { get; set; }

        /// <summary>
        /// 标识事件对应接口请求内容，即资源操作请求体。
        /// </summary>
        [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
        public string Request { get; set; }

        /// <summary>
        /// 记录用户请求的响应，标识事件对应接口响应内容，即资源操作结果返回体。
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public string Response { get; set; }

        /// <summary>
        /// 记录用户请求的响应，标识事件对应接口返回的HTTP状态码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 标识事件对应的云服务接口版本。
        /// </summary>
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 标识其他云服务为此条事件添加的备注信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 标识云审计服务记录本次事件的时间戳。
        /// </summary>
        [JsonProperty("record_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecordTime { get; set; }

        /// <summary>
        /// 标识事件的ID，由系统生成的UUID。
        /// </summary>
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// 标识事件产生的时间戳。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo User { get; set; }

        /// <summary>
        /// 标识查询事件列表对应的云服务类型。必须为已对接CTS的云服务的英文缩写，且服务类型一般为大写字母。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 查询事件列表对应的资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 标识触发事件的租户IP。
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 标识事件对应的资源名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 记录本次请求的request id
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 记录本次请求出错后，问题定位所需要的辅助信息。
        /// </summary>
        [JsonProperty("location_info", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationInfo { get; set; }

        /// <summary>
        /// 云资源的详情页面
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 云资源的详情页面的访问链接（不含endpoint）
        /// </summary>
        [JsonProperty("resource_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 标识资源所在的企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 标识资源所在的账号ID。仅在跨租户操作资源时有值。
        /// </summary>
        [JsonProperty("resource_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceAccountId { get; set; }

        /// <summary>
        /// 标识用户请求是不是只读。
        /// </summary>
        [JsonProperty("read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 记录事件对应的操作ID。
        /// </summary>
        [JsonProperty("operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Traces {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  traceName: ").Append(TraceName).Append("\n");
            sb.Append("  traceRating: ").Append(TraceRating).Append("\n");
            sb.Append("  traceType: ").Append(TraceType).Append("\n");
            sb.Append("  request: ").Append(Request).Append("\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  recordTime: ").Append(RecordTime).Append("\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  locationInfo: ").Append(LocationInfo).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  resourceUrl: ").Append(ResourceUrl).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  resourceAccountId: ").Append(ResourceAccountId).Append("\n");
            sb.Append("  readOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  operationId: ").Append(OperationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Traces);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Traces input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.TraceName != input.TraceName || (this.TraceName != null && !this.TraceName.Equals(input.TraceName))) return false;
            if (this.TraceRating != input.TraceRating) return false;
            if (this.TraceType != input.TraceType || (this.TraceType != null && !this.TraceType.Equals(input.TraceType))) return false;
            if (this.Request != input.Request || (this.Request != null && !this.Request.Equals(input.Request))) return false;
            if (this.Response != input.Response || (this.Response != null && !this.Response.Equals(input.Response))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.RecordTime != input.RecordTime || (this.RecordTime != null && !this.RecordTime.Equals(input.RecordTime))) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.SourceIp != input.SourceIp || (this.SourceIp != null && !this.SourceIp.Equals(input.SourceIp))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.LocationInfo != input.LocationInfo || (this.LocationInfo != null && !this.LocationInfo.Equals(input.LocationInfo))) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.ResourceUrl != input.ResourceUrl || (this.ResourceUrl != null && !this.ResourceUrl.Equals(input.ResourceUrl))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ResourceAccountId != input.ResourceAccountId || (this.ResourceAccountId != null && !this.ResourceAccountId.Equals(input.ResourceAccountId))) return false;
            if (this.ReadOnly != input.ReadOnly || (this.ReadOnly != null && !this.ReadOnly.Equals(input.ReadOnly))) return false;
            if (this.OperationId != input.OperationId || (this.OperationId != null && !this.OperationId.Equals(input.OperationId))) return false;

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
                if (this.TraceName != null) hashCode = hashCode * 59 + this.TraceName.GetHashCode();
                hashCode = hashCode * 59 + this.TraceRating.GetHashCode();
                if (this.TraceType != null) hashCode = hashCode * 59 + this.TraceType.GetHashCode();
                if (this.Request != null) hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Response != null) hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.RecordTime != null) hashCode = hashCode * 59 + this.RecordTime.GetHashCode();
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.SourceIp != null) hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.LocationInfo != null) hashCode = hashCode * 59 + this.LocationInfo.GetHashCode();
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.ResourceUrl != null) hashCode = hashCode * 59 + this.ResourceUrl.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ResourceAccountId != null) hashCode = hashCode * 59 + this.ResourceAccountId.GetHashCode();
                if (this.ReadOnly != null) hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.OperationId != null) hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
