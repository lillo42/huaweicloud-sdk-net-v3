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
    /// 
    /// </summary>
    public class Packet 
    {

        /// <summary>
        /// 十六进制码
        /// </summary>
        [JsonProperty("hex_index", NullValueHandling = NullValueHandling.Ignore)]
        public string HexIndex { get; set; }

        /// <summary>
        /// utf8字符串
        /// </summary>
        [JsonProperty("utf8_string", NullValueHandling = NullValueHandling.Ignore)]
        public string Utf8String { get; set; }

        /// <summary>
        /// 十六进制单个字节码数组
        /// </summary>
        [JsonProperty("hexs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hexs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Packet {\n");
            sb.Append("  hexIndex: ").Append(HexIndex).Append("\n");
            sb.Append("  utf8String: ").Append(Utf8String).Append("\n");
            sb.Append("  hexs: ").Append(Hexs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Packet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Packet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HexIndex == input.HexIndex ||
                    (this.HexIndex != null &&
                    this.HexIndex.Equals(input.HexIndex))
                ) && 
                (
                    this.Utf8String == input.Utf8String ||
                    (this.Utf8String != null &&
                    this.Utf8String.Equals(input.Utf8String))
                ) && 
                (
                    this.Hexs == input.Hexs ||
                    this.Hexs != null &&
                    input.Hexs != null &&
                    this.Hexs.SequenceEqual(input.Hexs)
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
                if (this.HexIndex != null)
                    hashCode = hashCode * 59 + this.HexIndex.GetHashCode();
                if (this.Utf8String != null)
                    hashCode = hashCode * 59 + this.Utf8String.GetHashCode();
                if (this.Hexs != null)
                    hashCode = hashCode * 59 + this.Hexs.GetHashCode();
                return hashCode;
            }
        }
    }
}
