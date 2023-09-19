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
    /// Response Object
    /// </summary>
    public class ShowNotificationTemplateResponse : SdkResponse
    {
        /// <summary>
        /// 语言，必填，目前可填zh-cn和en-us
        /// </summary>
        /// <value>语言，必填，目前可填zh-cn和en-us</value>
        [JsonConverter(typeof(EnumClassConverter<LocaleEnum>))]
        public class LocaleEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly LocaleEnum ZH_CN = new LocaleEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly LocaleEnum EN_US = new LocaleEnum("en-us");

            private static readonly Dictionary<string, LocaleEnum> StaticFields =
            new Dictionary<string, LocaleEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
            };

            private string _value;

            public LocaleEnum()
            {

            }

            public LocaleEnum(string value)
            {
                _value = value;
            }

            public static LocaleEnum FromValue(string value)
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

                if (this.Equals(obj as LocaleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LocaleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LocaleEnum a, LocaleEnum b)
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

            public static bool operator !=(LocaleEnum a, LocaleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通知规则名称，必填，只含有汉字、数字、字母、下划线、中划线，不能以下划线等特殊符号开头和结尾，长度为 1 - 100，创建后不可修改
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 保留字段，非必填，只支持sms（短信），dingding（钉钉），wechat（企业微信），email（邮件）和webhook（网络钩子）
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 模板描述，必填，只含有汉字、数字、字母、下划线不能以下划线开头和结尾，长度为0- -1024
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 模板来源，目前必填为LTS，否则会筛选不出来
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 语言，必填，目前可填zh-cn和en-us
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public LocaleEnum Locale { get; set; }
        /// <summary>
        /// 模板正文，为一个数组
        /// </summary>
        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubTemplate> Templates { get; set; }

        /// <summary>
        /// 创建时间，为毫秒时间戳
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间，为毫秒时间戳
        /// </summary>
        [JsonProperty("modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// 项目ID，获取方式请参见：获取账号ID、项目ID、日志组ID、日志流ID（https://support.huaweicloud.com/api-lts/lts_api_0006.html）。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNotificationTemplateResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  locale: ").Append(Locale).Append("\n");
            sb.Append("  templates: ").Append(Templates).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  modifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNotificationTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNotificationTemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    input.Type != null &&
                    this.Type.SequenceEqual(input.Type)
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ModifyTime == input.ModifyTime ||
                    (this.ModifyTime != null &&
                    this.ModifyTime.Equals(input.ModifyTime))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Desc != null)
                    hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null)
                    hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
