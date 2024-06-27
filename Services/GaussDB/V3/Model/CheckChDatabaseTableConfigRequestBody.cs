using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 表配置校验请求体。
    /// </summary>
    public class CheckChDatabaseTableConfigRequestBody 
    {

        /// <summary>
        /// 源实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 源节点ID。GaussDB(for MySQL)只读节点ID。如为空，则取GaussDB(for MySQL)主节点ID。
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// 源数据库名。
        /// </summary>
        [JsonProperty("source_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// 库配置列表。
        /// </summary>
        [JsonProperty("db_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChDatabaseConfigsInfo> DbConfigs { get; set; }

        /// <summary>
        /// 表配置信息。
        /// </summary>
        [JsonProperty("tables_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChDatabaseTablesConfigsInfo> TablesConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("table_repl_config", NullValueHandling = NullValueHandling.Ignore)]
        public ChDatabaseTableReplConfigInfo TableReplConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckChDatabaseTableConfigRequestBody {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  sourceDatabaseName: ").Append(SourceDatabaseName).Append("\n");
            sb.Append("  dbConfigs: ").Append(DbConfigs).Append("\n");
            sb.Append("  tablesConfigs: ").Append(TablesConfigs).Append("\n");
            sb.Append("  tableReplConfig: ").Append(TableReplConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckChDatabaseTableConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckChDatabaseTableConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceInstanceId == input.SourceInstanceId ||
                    (this.SourceInstanceId != null &&
                    this.SourceInstanceId.Equals(input.SourceInstanceId))
                ) && 
                (
                    this.SourceNodeId == input.SourceNodeId ||
                    (this.SourceNodeId != null &&
                    this.SourceNodeId.Equals(input.SourceNodeId))
                ) && 
                (
                    this.SourceDatabaseName == input.SourceDatabaseName ||
                    (this.SourceDatabaseName != null &&
                    this.SourceDatabaseName.Equals(input.SourceDatabaseName))
                ) && 
                (
                    this.DbConfigs == input.DbConfigs ||
                    this.DbConfigs != null &&
                    input.DbConfigs != null &&
                    this.DbConfigs.SequenceEqual(input.DbConfigs)
                ) && 
                (
                    this.TablesConfigs == input.TablesConfigs ||
                    this.TablesConfigs != null &&
                    input.TablesConfigs != null &&
                    this.TablesConfigs.SequenceEqual(input.TablesConfigs)
                ) && 
                (
                    this.TableReplConfig == input.TableReplConfig ||
                    (this.TableReplConfig != null &&
                    this.TableReplConfig.Equals(input.TableReplConfig))
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
                if (this.SourceInstanceId != null)
                    hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceNodeId != null)
                    hashCode = hashCode * 59 + this.SourceNodeId.GetHashCode();
                if (this.SourceDatabaseName != null)
                    hashCode = hashCode * 59 + this.SourceDatabaseName.GetHashCode();
                if (this.DbConfigs != null)
                    hashCode = hashCode * 59 + this.DbConfigs.GetHashCode();
                if (this.TablesConfigs != null)
                    hashCode = hashCode * 59 + this.TablesConfigs.GetHashCode();
                if (this.TableReplConfig != null)
                    hashCode = hashCode * 59 + this.TableReplConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
