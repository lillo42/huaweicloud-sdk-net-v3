using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageGroups 
    {

        /// <summary>
        /// storageGroups的名字，作为虚拟存储组的名字，因此各个group名字不能重复。 &gt; - 当cceManaged&#x3D;ture时，name必须为：vgpass。 &gt; - 当数据盘作为临时存储卷时：name必须为：vg-everest-localvolume-ephemeral。 &gt; - 当数据盘作为持久存储卷时：name必须为：vg-everest-localvolume-persistent。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// k8s及runtime所属存储空间。有且仅有一个group被设置为true，不填默认false。
        /// </summary>
        [JsonProperty("cceManaged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CceManaged { get; set; }

        /// <summary>
        /// 对应storageSelectors中的name，一个group可选择多个selector；但一个selector只能被一个group选择。
        /// </summary>
        [JsonProperty("selectorNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SelectorNames { get; set; }

        /// <summary>
        /// group中空间配置的详细管理。
        /// </summary>
        [JsonProperty("virtualSpaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<VirtualSpace> VirtualSpaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageGroups {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cceManaged: ").Append(CceManaged).Append("\n");
            sb.Append("  selectorNames: ").Append(SelectorNames).Append("\n");
            sb.Append("  virtualSpaces: ").Append(VirtualSpaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageGroups input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CceManaged != input.CceManaged || (this.CceManaged != null && !this.CceManaged.Equals(input.CceManaged))) return false;
            if (this.SelectorNames != input.SelectorNames || (this.SelectorNames != null && input.SelectorNames != null && !this.SelectorNames.SequenceEqual(input.SelectorNames))) return false;
            if (this.VirtualSpaces != input.VirtualSpaces || (this.VirtualSpaces != null && input.VirtualSpaces != null && !this.VirtualSpaces.SequenceEqual(input.VirtualSpaces))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CceManaged != null) hashCode = hashCode * 59 + this.CceManaged.GetHashCode();
                if (this.SelectorNames != null) hashCode = hashCode * 59 + this.SelectorNames.GetHashCode();
                if (this.VirtualSpaces != null) hashCode = hashCode * 59 + this.VirtualSpaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
