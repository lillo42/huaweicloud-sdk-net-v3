using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dns.V2.Model;

namespace HuaweiCloud.SDK.Dns.V2
{
    public partial class DnsClient : Client
    {
        public static ClientBuilder<DnsClient> NewBuilder()
        {
            return new ClientBuilder<DnsClient>();
        }

        
        /// <summary>
        /// 创建单个自定义线路
        ///
        /// 创建单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCustomLineResponse CreateCustomLine(CreateCustomLineRequest createCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCustomLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 创建线路分组
        ///
        /// 创建一个线路分组。 该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLineGroupResponse CreateLineGroup(CreateLineGroupRequest createLineGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLineGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLineGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除单个自定义线路
        ///
        /// 删除单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCustomLineResponse DeleteCustomLine(DeleteCustomLineRequest deleteCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id" , deleteCustomLineRequest.LineId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCustomLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 删除线路分组
        ///
        /// 删除单个线路分组。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLineGroupResponse DeleteLineGroup(DeleteLineGroupRequest deleteLineGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id" , deleteLineGroupRequest.LinegroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLineGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteLineGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询所有的云解析服务API版本号
        ///
        /// 查询所有的云解析服务API版本号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义线路
        ///
        /// 查询自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCustomLineResponse ListCustomLine(ListCustomLineRequest listCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 查询线路分组列表
        ///
        /// 查询线路分组列表。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLineGroupsResponse ListLineGroups(ListLineGroupsRequest listLineGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLineGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLineGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询名称服务器列表
        ///
        /// 查询名称服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNameServersResponse ListNameServers(ListNameServersRequest listNameServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/nameservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNameServersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNameServersResponse>(response);
        }
        
        /// <summary>
        /// 查询指定的云解析服务API版本号
        ///
        /// 查询指定的云解析服务API版本号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiInfoResponse ShowApiInfo(ShowApiInfoRequest showApiInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showApiInfoRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询单租户在DNS服务下的资源配额，包括公网zone配额、内网zone配额、Record Set配额、PTR Record配额、入站终端节点配额、出站终端节点配额、自定义线路配额、线路分组配额等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainQuotaResponse ShowDomainQuota(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/quotamg/dns/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询线路分组
        ///
        /// 查询线路分组。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLineGroupResponse ShowLineGroup(ShowLineGroupRequest showLineGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id" , showLineGroupRequest.LinegroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLineGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLineGroupResponse>(response);
        }
        
        /// <summary>
        /// 更新单个自定义线路
        ///
        /// 更新单个自定义线路
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCustomLineResponse UpdateCustomLine(UpdateCustomLineRequest updateCustomLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("line_id" , updateCustomLineRequest.LineId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/customlines/{line_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCustomLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCustomLineResponse>(response);
        }
        
        /// <summary>
        /// 更新线路分组
        ///
        /// 更新单个线路分组。该接口部分区域未上线、如需使用请提交工单申请开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLineGroupsResponse UpdateLineGroups(UpdateLineGroupsRequest updateLineGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("linegroup_id" , updateLineGroupsRequest.LinegroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/linegroups/{linegroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLineGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLineGroupsResponse>(response);
        }
        
        /// <summary>
        /// 设置弹性IP的PTR记录
        ///
        /// 设置弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEipRecordSetResponse CreateEipRecordSet(CreateEipRecordSetRequest createEipRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , createEipRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id" , createEipRecordSetRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEipRecordSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<CreateEipRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 查询租户弹性IP的PTR记录列表
        ///
        /// 查询租户弹性IP的PTR记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPtrRecordsResponse ListPtrRecords(ListPtrRecordsRequest listPtrRecordsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPtrRecordsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPtrRecordsResponse>(response);
        }
        
        /// <summary>
        /// 将弹性IP的PTR记录恢复为默认值
        ///
        /// 将弹性IP的PTR记录恢复为默认值
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestorePtrRecordResponse RestorePtrRecord(RestorePtrRecordRequest restorePtrRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , restorePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id" , restorePtrRecordRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restorePtrRecordRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<RestorePtrRecordResponse>(response);
        }
        
        /// <summary>
        /// 查询单个弹性IP的PTR记录
        ///
        /// 查询单个弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPtrRecordSetResponse ShowPtrRecordSet(ShowPtrRecordSetRequest showPtrRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , showPtrRecordSetRequest.Region.ToString());
            urlParam.Add("floatingip_id" , showPtrRecordSetRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPtrRecordSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPtrRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 修改弹性IP的PTR记录
        ///
        /// 修改弹性IP的PTR记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePtrRecordResponse UpdatePtrRecord(UpdatePtrRecordRequest updatePtrRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region" , updatePtrRecordRequest.Region.ToString());
            urlParam.Add("floatingip_id" , updatePtrRecordRequest.FloatingipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/reverse/floatingips/{region}:{floatingip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePtrRecordRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdatePtrRecordResponse>(response);
        }
        
        /// <summary>
        /// Record Set关联健康检查
        ///
        /// Record Set关联健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateHealthCheckResponse AssociateHealthCheck(AssociateHealthCheckRequest associateHealthCheckRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id" , associateHealthCheckRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/associatehealthcheck",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateHealthCheckRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AssociateHealthCheckResponse>(response);
        }
        
        /// <summary>
        /// 批量删除某个Zone下的Record Set资源
        ///
        /// 批量删除某个Zone下的Record Set资源，当删除的资源不存在时，则默认删除成功。
        /// 响应结果中只包含本次实际删除的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteRecordSetWithLineResponse BatchDeleteRecordSetWithLine(BatchDeleteRecordSetWithLineRequest batchDeleteRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , batchDeleteRecordSetWithLineRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRecordSetWithLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 批量修改RecordSet
        ///
        /// 批量修改RecordSet。属于原子性操作，请求Record Set将全部完成修改，或不做任何修改。
        /// 仅公网Zone支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateRecordSetWithLineResponse BatchUpdateRecordSetWithLine(BatchUpdateRecordSetWithLineRequest batchUpdateRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , batchUpdateRecordSetWithLineRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRecordSetWithLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 创建单个Record Set
        ///
        /// 创建单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetResponse CreateRecordSet(CreateRecordSetRequest createRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , createRecordSetRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 批量线路创建RecordSet
        ///
        /// 批量线路创建RecordSet。属于原子性操作，如果存在一个参数校验不通过，则创建失败。仅公网Zone支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetWithBatchLinesResponse CreateRecordSetWithBatchLines(CreateRecordSetWithBatchLinesRequest createRecordSetWithBatchLinesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , createRecordSetWithBatchLinesRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/batch/lines",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithBatchLinesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordSetWithBatchLinesResponse>(response);
        }
        
        /// <summary>
        /// 创建单个Record Set
        ///
        /// 创建单个Record Set，仅适用于公网DNS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordSetWithLineResponse CreateRecordSetWithLine(CreateRecordSetWithLineRequest createRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , createRecordSetWithLineRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRecordSetWithLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 删除单个Record Set
        ///
        /// 删除单个Record Set. 删除有添加智能解析的记录集时、需要用Record Set多线路管理模块中删除接口进行删除.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordSetResponse DeleteRecordSet(DeleteRecordSetRequest deleteRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deleteRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , deleteRecordSetRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 删除单个Record Set
        ///
        /// 删除单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordSetsResponse DeleteRecordSets(DeleteRecordSetsRequest deleteRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deleteRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , deleteRecordSetsRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// Record Set解关联健康检查
        ///
        /// Record Set解关联健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateHealthCheckResponse DisassociateHealthCheck(DisassociateHealthCheckRequest disassociateHealthCheckRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id" , disassociateHealthCheckRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/disassociatehealthcheck",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateHealthCheckRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DisassociateHealthCheckResponse>(response);
        }
        
        /// <summary>
        /// 查询租户Record Set资源列表
        ///
        /// 查询租户Record Set资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsResponse ListRecordSets(ListRecordSetsRequest listRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Zone下Record Set列表
        ///
        /// 查询单个Zone下Record Set列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsByZoneResponse ListRecordSetsByZone(ListRecordSetsByZoneRequest listRecordSetsByZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , listRecordSetsByZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsByZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRecordSetsByZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询租户Record Set资源列表
        ///
        /// 查询租户Record Set资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordSetsWithLineResponse ListRecordSetsWithLine(ListRecordSetsWithLineRequest listRecordSetsWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordSetsWithLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRecordSetsWithLineResponse>(response);
        }
        
        /// <summary>
        /// 设置Record Set状态
        ///
        /// 设置Record Set状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRecordSetsStatusResponse SetRecordSetsStatus(SetRecordSetsStatusRequest setRecordSetsStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("recordset_id" , setRecordSetsStatusRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/recordsets/{recordset_id}/statuses/set",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRecordSetsStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SetRecordSetsStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Record Set
        ///
        /// 查询单个Record Set。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordSetResponse ShowRecordSet(ShowRecordSetRequest showRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , showRecordSetRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Zone下Record Set列表
        ///
        /// 查询单个Zone下Record Set列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordSetByZoneResponse ShowRecordSetByZone(ShowRecordSetByZoneRequest showRecordSetByZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showRecordSetByZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetByZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordSetByZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询单个Record Set
        ///
        /// 查询单个Record Set，仅适用于公网DNS
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordSetWithLineResponse ShowRecordSetWithLine(ShowRecordSetWithLineRequest showRecordSetWithLineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showRecordSetWithLineRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , showRecordSetWithLineRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordSetWithLineRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordSetWithLineResponse>(response);
        }
        
        /// <summary>
        /// 修改单个Record Set
        ///
        /// 修改单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordSetResponse UpdateRecordSet(UpdateRecordSetRequest updateRecordSetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updateRecordSetRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , updateRecordSetRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordSetResponse>(response);
        }
        
        /// <summary>
        /// 修改单个Record Set
        ///
        /// 修改单个Record Set
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordSetsResponse UpdateRecordSets(UpdateRecordSetsRequest updateRecordSetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updateRecordSetsRequest.ZoneId.ToString());
            urlParam.Add("recordset_id" , updateRecordSetsRequest.RecordsetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/zones/{zone_id}/recordsets/{recordset_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRecordSetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordSetsResponse>(response);
        }
        
        /// <summary>
        /// 为指定实例批量添加或删除标签
        ///
        /// 为指定实例批量添加或删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateTagResponse BatchCreateTag(BatchCreateTagRequest batchCreateTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchCreateTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchCreateTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateTagResponse>(response);
        }
        
        /// <summary>
        /// 为指定实例添加标签
        ///
        /// 为指定实例添加标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResponse CreateTag(CreateTagRequest createTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteTagRequest.ResourceId.ToString());
            urlParam.Add("key" , deleteTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }
        
        /// <summary>
        /// 使用标签查询资源实例
        ///
        /// 使用标签查询资源实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagResponse ListTag(ListTagRequest listTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listTagRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListTagResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例类型的所有标签集合
        ///
        /// 查询指定实例类型的所有标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例的标签信息
        ///
        /// 查询指定实例的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceTagResponse ShowResourceTag(ShowResourceTagRequest showResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , showResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , showResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 在内网Zone上关联VPC
        ///
        /// 在内网Zone上关联VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRouterResponse AssociateRouter(AssociateRouterRequest associateRouterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , associateRouterRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/associaterouter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRouterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AssociateRouterResponse>(response);
        }
        
        /// <summary>
        /// 创建单个内网Zone
        ///
        /// 创建单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePrivateZoneResponse CreatePrivateZone(CreatePrivateZoneRequest createPrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPrivateZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 创建单个公网Zone
        ///
        /// 创建单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePublicZoneResponse CreatePublicZone(CreatePublicZoneRequest createPublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPublicZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 删除单个内网Zone
        ///
        /// 删除单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePrivateZoneResponse DeletePrivateZone(DeletePrivateZoneRequest deletePrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deletePrivateZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 删除单个公网Zone
        ///
        /// 删除单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublicZoneResponse DeletePublicZone(DeletePublicZoneRequest deletePublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , deletePublicZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublicZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeletePublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 在内网Zone上解关联VPC
        ///
        /// 在内网Zone上解关联VPC
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateRouterResponse DisassociateRouter(DisassociateRouterRequest disassociateRouterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , disassociateRouterRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/disassociaterouter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateRouterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisassociateRouterResponse>(response);
        }
        
        /// <summary>
        /// 查询内网Zone列表
        ///
        /// 查询内网Zone列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPrivateZonesResponse ListPrivateZones(ListPrivateZonesRequest listPrivateZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询公网Zone列表
        ///
        /// 查询公网Zone列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublicZonesResponse ListPublicZones(ListPublicZonesRequest listPublicZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublicZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPublicZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询单个内网Zone
        ///
        /// 查询单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateZoneResponse ShowPrivateZone(ShowPrivateZoneRequest showPrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPrivateZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询单个内网Zone的名称服务器
        ///
        /// 查询单个内网Zone的名称服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateZoneNameServerResponse ShowPrivateZoneNameServer(ShowPrivateZoneNameServerRequest showPrivateZoneNameServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPrivateZoneNameServerRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateZoneNameServerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateZoneNameServerResponse>(response);
        }
        
        /// <summary>
        /// 查询单个公网Zone
        ///
        /// 查询单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicZoneResponse ShowPublicZone(ShowPublicZoneRequest showPublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPublicZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 查询单个公网Zone的名称服务器
        ///
        /// 查询单个公网Zone的名称服务器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublicZoneNameServerResponse ShowPublicZoneNameServer(ShowPublicZoneNameServerRequest showPublicZoneNameServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , showPublicZoneNameServerRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/nameservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublicZoneNameServerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPublicZoneNameServerResponse>(response);
        }
        
        /// <summary>
        /// 修改单个内网Zone
        ///
        /// 修改单个内网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateZoneResponse UpdatePrivateZone(UpdatePrivateZoneRequest updatePrivateZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updatePrivateZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdatePrivateZoneResponse>(response);
        }
        
        /// <summary>
        /// 修改单个公网Zone
        ///
        /// 修改单个公网Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicZoneResponse UpdatePublicZone(UpdatePublicZoneRequest updatePublicZoneRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updatePublicZoneRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdatePublicZoneResponse>(response);
        }
        
        /// <summary>
        /// 设置单个公网Zone状态
        ///
        /// 设置单个公网Zone状态，支持暂停、启用Zone
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublicZoneStatusResponse UpdatePublicZoneStatus(UpdatePublicZoneStatusRequest updatePublicZoneStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("zone_id" , updatePublicZoneStatusRequest.ZoneId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/zones/{zone_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePublicZoneStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePublicZoneStatusResponse>(response);
        }
        
    }
}