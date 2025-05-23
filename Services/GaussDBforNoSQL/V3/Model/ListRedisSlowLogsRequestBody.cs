using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListRedisSlowLogsRequestBody 
    {

        /// <summary>
        /// 开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。注：开始时间不得早于当前时间30天。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。注：结束时间不能晚于当前时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 表示每次查询的日志条数，最大限制100条。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 日志单行序列号，第一次查询时不需要此参数，下一次查询时需要使用，可从上一次查询的返回信息中获取。 说明：当次查询从line_num的下一条日志开始查询，不包含当前line_num日志。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 语句类型，取空值，表示查询所有语句类型。支持查询的所有语句类型如下（以\&quot;|\&quot;分割）： set|get|del|incr|incrby|incrbyfloat|decr|decrby|getset|append|mget|keys|setnx|setex|psetex|delvx|mset| msetnx|getrange|substr|setrange|strlen|exists|expire|pexpire|expireat|pexpireat|ttl|pttl|persist|type| scanx|pksetexat|sort|hdel|hset|hget|hgetall|hexists|hincrby|hincrbyfloat|hkeys|hlen|hmget|hmset|hsetnx| hstrlen|hvals|hscan|hscanx|pkhscanrange|pkhrscanrange|lindex|linsert|llen|lpop|lpush|lpushx|lrange|lrem| lset|ltrim|rpop|rpoplpush|rpush|rpushx|zadd|zcard|zscan|zincrby|zrange|zrevrange|zrangebyscore| zrevrangebyscore|zcount|zrem|zunionstore|zinterstore|zrank|zrevrank|zscore|zrangebylex|zrevrangebylex| zlexcount|zremrangebyrank|zremrangebyscore|zremrangebylex|zpopmax|zpopmin|sadd|spop|scard|smembers|sscan| srem|sunion|sunionstore|sinter|sinterstore|sismember|sdiff|sdiffstore|smove|srandmember|bitset|bitget| bitcount|bitpos|bitop|bitfield|pfadd|pfcount|pfmerge|geoadd|georadiusbymember|georadius|geohash|geodist| geopos|xadd|xack|xgroup|xdel|xtrim|xlen|xrange|xrevrange|xclaim|xpending|xinfo|xread|xreadgroup|
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 节点ID，取空值，表示查询实例下所有允许查询的节点。 具体取值请参考查询实例列表和详情接口\&quot;ListInstances\&quot;中nodes字段数据结构说明的“id”。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 根据多个关键字搜索日志全文，表示同时匹配所有关键字。 - 最多支持10个关键字。 - 每个关键字最大长度不超过512个字符。
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 支持根据最大执行时间范围查找日志。单位：ms
        /// </summary>
        [JsonProperty("max_cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxCostTime { get; set; }

        /// <summary>
        /// 支持根据最小执行时间范围查找日志。单位：ms
        /// </summary>
        [JsonProperty("min_cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinCostTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRedisSlowLogsRequestBody {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  maxCostTime: ").Append(MaxCostTime).Append("\n");
            sb.Append("  minCostTime: ").Append(MinCostTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRedisSlowLogsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRedisSlowLogsRequestBody input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;
            if (this.OperateType != input.OperateType || (this.OperateType != null && !this.OperateType.Equals(input.OperateType))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;
            if (this.MaxCostTime != input.MaxCostTime || (this.MaxCostTime != null && !this.MaxCostTime.Equals(input.MaxCostTime))) return false;
            if (this.MinCostTime != input.MinCostTime || (this.MinCostTime != null && !this.MinCostTime.Equals(input.MinCostTime))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.OperateType != null) hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.MaxCostTime != null) hashCode = hashCode * 59 + this.MaxCostTime.GetHashCode();
                if (this.MinCostTime != null) hashCode = hashCode * 59 + this.MinCostTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
