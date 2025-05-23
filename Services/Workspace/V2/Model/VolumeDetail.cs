using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 磁盘信息。
    /// </summary>
    public class VolumeDetail 
    {

        /// <summary>
        /// 标识磁盘是否加密，如果为1就是加密。
        /// </summary>
        [JsonProperty("encrypt_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptFlag { get; set; }

        /// <summary>
        /// 如果磁盘加密，传递的密钥。
        /// </summary>
        [JsonProperty("kms_key", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKey { get; set; }

        /// <summary>
        /// 如果磁盘加密，传递的密钥。
        /// </summary>
        [JsonProperty("key_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// 桌面数据盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  - SAS：高IO。 - SSD：超高IO。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 磁盘容量，单位GB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 如果磁盘加密，授权ID。
        /// </summary>
        [JsonProperty("kms_grant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsGrantId { get; set; }

        /// <summary>
        /// 挂载目录。
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// 磁盘表唯一标识ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 磁盘ID。
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 磁盘计费资源ID。
        /// </summary>
        [JsonProperty("bill_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillResourceId { get; set; }

        /// <summary>
        /// 磁盘的创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 磁盘名
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的存储池的ID。
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeDetail {\n");
            sb.Append("  encryptFlag: ").Append(EncryptFlag).Append("\n");
            sb.Append("  kmsKey: ").Append(KmsKey).Append("\n");
            sb.Append("  keyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  kmsGrantId: ").Append(KmsGrantId).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  billResourceId: ").Append(BillResourceId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeDetail input)
        {
            if (input == null) return false;
            if (this.EncryptFlag != input.EncryptFlag || (this.EncryptFlag != null && !this.EncryptFlag.Equals(input.EncryptFlag))) return false;
            if (this.KmsKey != input.KmsKey || (this.KmsKey != null && !this.KmsKey.Equals(input.KmsKey))) return false;
            if (this.KeyAlias != input.KeyAlias || (this.KeyAlias != null && !this.KeyAlias.Equals(input.KeyAlias))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.KmsGrantId != input.KmsGrantId || (this.KmsGrantId != null && !this.KmsGrantId.Equals(input.KmsGrantId))) return false;
            if (this.Device != input.Device || (this.Device != null && !this.Device.Equals(input.Device))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.VolumeId != input.VolumeId || (this.VolumeId != null && !this.VolumeId.Equals(input.VolumeId))) return false;
            if (this.BillResourceId != input.BillResourceId || (this.BillResourceId != null && !this.BillResourceId.Equals(input.BillResourceId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;

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
                if (this.EncryptFlag != null) hashCode = hashCode * 59 + this.EncryptFlag.GetHashCode();
                if (this.KmsKey != null) hashCode = hashCode * 59 + this.KmsKey.GetHashCode();
                if (this.KeyAlias != null) hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.KmsGrantId != null) hashCode = hashCode * 59 + this.KmsGrantId.GetHashCode();
                if (this.Device != null) hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VolumeId != null) hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.BillResourceId != null) hashCode = hashCode * 59 + this.BillResourceId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
