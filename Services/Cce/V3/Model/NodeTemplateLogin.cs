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
    public class NodeTemplateLogin 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sshKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SshKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("userPassword", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplateLoginUserPassword UserPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeTemplateLogin {\n");
            sb.Append("  sshKey: ").Append(SshKey).Append("\n");
            sb.Append("  userPassword: ").Append(UserPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeTemplateLogin);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeTemplateLogin input)
        {
            if (input == null) return false;
            if (this.SshKey != input.SshKey || (this.SshKey != null && !this.SshKey.Equals(input.SshKey))) return false;
            if (this.UserPassword != input.UserPassword || (this.UserPassword != null && !this.UserPassword.Equals(input.UserPassword))) return false;

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
                if (this.SshKey != null) hashCode = hashCode * 59 + this.SshKey.GetHashCode();
                if (this.UserPassword != null) hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
