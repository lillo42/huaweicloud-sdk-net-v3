using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRepositoryTagsRequest 
    {
        /// <summary>
        /// 排序类型，可设置为desc（降序）、asc（升序） 
        /// </summary>
        /// <value>排序类型，可设置为desc（降序）、asc（升序） </value>
        [JsonConverter(typeof(EnumClassConverter<OrderTypeEnum>))]
        public class OrderTypeEnum
        {
            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderTypeEnum DESC = new OrderTypeEnum("desc");

            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderTypeEnum ASC = new OrderTypeEnum("asc");

            private static readonly Dictionary<string, OrderTypeEnum> StaticFields =
            new Dictionary<string, OrderTypeEnum>()
            {
                { "desc", DESC },
                { "asc", ASC },
            };

            private string Value;

            public OrderTypeEnum(string value)
            {
                Value = value;
            }

            public static OrderTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OrderTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OrderTypeEnum a, OrderTypeEnum b)
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

            public static bool operator !=(OrderTypeEnum a, OrderTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 组织名称。小写字母开头，后面跟小写字母、数字、小数点、下划线或中划线（其中下划线最多允许连续两个，小数点、下划线、中划线不能直接相连），小写字母或数字结尾，1-64个字符。
        /// </summary>
        [SDKProperty("namespace", IsPath = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 镜像仓库名称
        /// </summary>
        [SDKProperty("repository", IsPath = true)]
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public string Repository { get; set; }

        /// <summary>
        /// 起始索引。**注意：offset和limit参数需要配套使用** 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 返回条数。**注意：offset和limit参数需要配套使用* 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 按列排序，可设置为updated_at（按更新时间排序） 
        /// </summary>
        [SDKProperty("order_column", IsQuery = true)]
        [JsonProperty("order_column", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// 排序类型，可设置为desc（降序）、asc（升序） 
        /// </summary>
        [SDKProperty("order_type", IsQuery = true)]
        [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public OrderTypeEnum OrderType { get; set; }
        /// <summary>
        /// 镜像版本名
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryTagsRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orderColumn: ").Append(OrderColumn).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryTagsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Repository == input.Repository ||
                    (this.Repository != null &&
                    this.Repository.Equals(input.Repository))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.OrderColumn == input.OrderColumn ||
                    (this.OrderColumn != null &&
                    this.OrderColumn.Equals(input.OrderColumn))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Repository != null)
                    hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.OrderColumn != null)
                    hashCode = hashCode * 59 + this.OrderColumn.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
