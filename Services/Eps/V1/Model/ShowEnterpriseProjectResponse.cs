using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEnterpriseProjectResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enterprise_project", NullValueHandling = NullValueHandling.Ignore)]
        public EpDetail EnterpriseProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEnterpriseProjectResponse {\n");
            sb.Append("  enterpriseProject: ").Append(EnterpriseProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEnterpriseProjectResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEnterpriseProjectResponse input)
        {
            if (input == null) return false;
            if (this.EnterpriseProject != input.EnterpriseProject || (this.EnterpriseProject != null && !this.EnterpriseProject.Equals(input.EnterpriseProject))) return false;

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
                if (this.EnterpriseProject != null) hashCode = hashCode * 59 + this.EnterpriseProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
