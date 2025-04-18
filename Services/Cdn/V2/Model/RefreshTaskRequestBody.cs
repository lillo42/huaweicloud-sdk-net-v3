using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RefreshTaskRequestBody 
    {
        /// <summary>
        /// 刷新的类型，其值可以为file：文件，或directory：目录，默认为file。
        /// </summary>
        /// <value>刷新的类型，其值可以为file：文件，或directory：目录，默认为file。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum FILE for value: file
            /// </summary>
            public static readonly TypeEnum FILE = new TypeEnum("file");

            /// <summary>
            /// Enum DIRECTORY for value: directory
            /// </summary>
            public static readonly TypeEnum DIRECTORY = new TypeEnum("directory");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "file", FILE },
                { "directory", DIRECTORY },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 目录刷新方式，all：刷新目录下全部资源；detect_modify_refresh：刷新目录下已变更的资源，默认值为all。
        /// </summary>
        /// <value>目录刷新方式，all：刷新目录下全部资源；detect_modify_refresh：刷新目录下已变更的资源，默认值为all。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ModeEnum ALL = new ModeEnum("all");

            /// <summary>
            /// Enum DETECT_MODIFY_REFRESH for value: detect_modify_refresh
            /// </summary>
            public static readonly ModeEnum DETECT_MODIFY_REFRESH = new ModeEnum("detect_modify_refresh");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "all", ALL },
                { "detect_modify_refresh", DETECT_MODIFY_REFRESH },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 刷新的类型，其值可以为file：文件，或directory：目录，默认为file。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 目录刷新方式，all：刷新目录下全部资源；detect_modify_refresh：刷新目录下已变更的资源，默认值为all。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 是否对url中的中文字符进行编码后刷新，false代表不开启，true代表开启，开启后仅刷新转码后的URL。
        /// </summary>
        [JsonProperty("zh_url_encode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZhUrlEncode { get; set; }

        /// <summary>
        /// 需要刷新的URL必须带有“http://”或“https://”，多个URL用逗号分隔（\&quot;url1\&quot;, \&quot;url2\&quot;），单个url的长度限制为4096字符，单次最多输入1000个url，如果输入的是目录，支持100个目录刷新。   &gt; - 如果您需要刷新的URL中有中文，请同时刷新中文URL（输入中文URL且不开启zh_url_encode）和转码后的URL（输入中文URL且开启zh_url_encode）。   &gt; - 如果您的URL中带有空格，请自行转码后输入，且不要开启URL Encode。 
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshTaskRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  zhUrlEncode: ").Append(ZhUrlEncode).Append("\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefreshTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefreshTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Mode != input.Mode) return false;
            if (this.ZhUrlEncode != input.ZhUrlEncode || (this.ZhUrlEncode != null && !this.ZhUrlEncode.Equals(input.ZhUrlEncode))) return false;
            if (this.Urls != input.Urls || (this.Urls != null && input.Urls != null && !this.Urls.SequenceEqual(input.Urls))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.ZhUrlEncode != null) hashCode = hashCode * 59 + this.ZhUrlEncode.GetHashCode();
                if (this.Urls != null) hashCode = hashCode * 59 + this.Urls.GetHashCode();
                return hashCode;
            }
        }
    }
}
