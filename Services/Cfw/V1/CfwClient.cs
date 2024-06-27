using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cfw.V1.Model;

namespace HuaweiCloud.SDK.Cfw.V1
{
    public partial class CfwClient : Client
    {
        public static ClientBuilder<CfwClient> NewBuilder()
        {
            return new ClientBuilder<CfwClient>();
        }

        
        /// <summary>
        /// 添加地址组成员
        ///
        /// 添加地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAddressItemResponse AddAddressItem(AddAddressItemRequest addAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAddressItemResponse>(response);
        }

        public SyncInvoker<AddAddressItemResponse> AddAddressItemInvoker(AddAddressItemRequest addAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressItemRequest);
            return new SyncInvoker<AddAddressItemResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAddressItemResponse>);
        }
        
        /// <summary>
        /// 添加地址组
        ///
        /// 添加地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAddressSetResponse AddAddressSet(AddAddressSetRequest addAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAddressSetResponse>(response);
        }

        public SyncInvoker<AddAddressSetResponse> AddAddressSetInvoker(AddAddressSetRequest addAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAddressSetRequest);
            return new SyncInvoker<AddAddressSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAddressSetResponse>);
        }
        
        /// <summary>
        /// 创建黑白名单规则
        ///
        /// 创建黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddBlackWhiteListResponse AddBlackWhiteList(AddBlackWhiteListRequest addBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddBlackWhiteListResponse>(response);
        }

        public SyncInvoker<AddBlackWhiteListResponse> AddBlackWhiteListInvoker(AddBlackWhiteListRequest addBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addBlackWhiteListRequest);
            return new SyncInvoker<AddBlackWhiteListResponse>(this, "POST", request, JsonUtils.DeSerialize<AddBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 添加域名组
        ///
        /// 添加域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDomainSetResponse AddDomainSet(AddDomainSetRequest addDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDomainSetResponse>(response);
        }

        public SyncInvoker<AddDomainSetResponse> AddDomainSetInvoker(AddDomainSetRequest addDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainSetRequest);
            return new SyncInvoker<AddDomainSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainSetResponse>);
        }
        
        /// <summary>
        /// 添加域名列表
        ///
        /// 添加域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDomainsResponse AddDomains(AddDomainsRequest addDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", addDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDomainsResponse>(response);
        }

        public SyncInvoker<AddDomainsResponse> AddDomainsInvoker(AddDomainsRequest addDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", addDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainsRequest);
            return new SyncInvoker<AddDomainsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainsResponse>);
        }
        
        /// <summary>
        /// 创建日志配置
        ///
        /// 创建日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddLogConfigResponse AddLogConfig(AddLogConfigRequest addLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addLogConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddLogConfigResponse>(response);
        }

        public SyncInvoker<AddLogConfigResponse> AddLogConfigInvoker(AddLogConfigRequest addLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addLogConfigRequest);
            return new SyncInvoker<AddLogConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<AddLogConfigResponse>);
        }
        
        /// <summary>
        /// 新建服务成员
        ///
        /// 批量添加服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddServiceItemsResponse AddServiceItems(AddServiceItemsRequest addServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddServiceItemsResponse>(response);
        }

        public SyncInvoker<AddServiceItemsResponse> AddServiceItemsInvoker(AddServiceItemsRequest addServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceItemsRequest);
            return new SyncInvoker<AddServiceItemsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServiceItemsResponse>);
        }
        
        /// <summary>
        /// 新建服务组
        ///
        /// 创建服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddServiceSetResponse AddServiceSet(AddServiceSetRequest addServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddServiceSetResponse>(response);
        }

        public SyncInvoker<AddServiceSetResponse> AddServiceSetInvoker(AddServiceSetRequest addServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addServiceSetRequest);
            return new SyncInvoker<AddServiceSetResponse>(this, "POST", request, JsonUtils.DeSerialize<AddServiceSetResponse>);
        }
        
        /// <summary>
        /// 批量删除地址组成员
        ///
        /// 批量删除地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAddressItemsResponse BatchDeleteAddressItems(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>(response);
        }

        public SyncInvoker<BatchDeleteAddressItemsResponse> BatchDeleteAddressItemsInvoker(BatchDeleteAddressItemsRequest batchDeleteAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAddressItemsRequest);
            return new SyncInvoker<BatchDeleteAddressItemsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteAddressItemsResponse>);
        }
        
        /// <summary>
        /// 批量删除服务组成员信息
        ///
        /// 批量删除服务组成员信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteServiceItemsResponse BatchDeleteServiceItems(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>(response);
        }

        public SyncInvoker<BatchDeleteServiceItemsResponse> BatchDeleteServiceItemsInvoker(BatchDeleteServiceItemsRequest batchDeleteServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServiceItemsRequest);
            return new SyncInvoker<BatchDeleteServiceItemsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteServiceItemsResponse>);
        }
        
        /// <summary>
        /// 取消抓包任务
        ///
        /// 取消抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelCaptureTaskResponse CancelCaptureTask(CancelCaptureTaskRequest cancelCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCaptureTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CancelCaptureTaskResponse>(response);
        }

        public SyncInvoker<CancelCaptureTaskResponse> CancelCaptureTaskInvoker(CancelCaptureTaskRequest cancelCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelCaptureTaskRequest);
            return new SyncInvoker<CancelCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 修改东西向防火墙防护状态
        ///
        /// 东西向防护资源防护开启/关闭
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeEastWestFirewallStatusResponse ChangeEastWestFirewallStatus(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>(response);
        }

        public SyncInvoker<ChangeEastWestFirewallStatusResponse> ChangeEastWestFirewallStatusInvoker(ChangeEastWestFirewallStatusRequest changeEastWestFirewallStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEastWestFirewallStatusRequest);
            return new SyncInvoker<ChangeEastWestFirewallStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeEastWestFirewallStatusResponse>);
        }
        
        /// <summary>
        /// 创建抓包任务
        ///
        /// 创建抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCaptureTaskResponse CreateCaptureTask(CreateCaptureTaskRequest createCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCaptureTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCaptureTaskResponse>(response);
        }

        public SyncInvoker<CreateCaptureTaskResponse> CreateCaptureTaskInvoker(CreateCaptureTaskRequest createCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCaptureTaskRequest);
            return new SyncInvoker<CreateCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 创建东西向防火墙
        ///
        /// 创建东西向防火墙
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEastWestFirewallResponse CreateEastWestFirewall(CreateEastWestFirewallRequest createEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEastWestFirewallRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEastWestFirewallResponse>(response);
        }

        public SyncInvoker<CreateEastWestFirewallResponse> CreateEastWestFirewallInvoker(CreateEastWestFirewallRequest createEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEastWestFirewallRequest);
            return new SyncInvoker<CreateEastWestFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEastWestFirewallResponse>);
        }
        
        /// <summary>
        /// 创建防火墙
        ///
        /// 创建防火墙
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFirewallResponse CreateFirewall(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFirewallResponse>(response);
        }

        public SyncInvoker<CreateFirewallResponse> CreateFirewallInvoker(CreateFirewallRequest createFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFirewallRequest);
            return new SyncInvoker<CreateFirewallResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFirewallResponse>);
        }
        
        /// <summary>
        /// 标签创建接口
        ///
        /// 创建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResponse CreateTag(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", createTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public SyncInvoker<CreateTagResponse> CreateTagInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", createTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new SyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除地址组成员
        ///
        /// 删除地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddressItemResponse DeleteAddressItem(DeleteAddressItemRequest deleteAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteAddressItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddressItemResponse>(response);
        }

        public SyncInvoker<DeleteAddressItemResponse> DeleteAddressItemInvoker(DeleteAddressItemRequest deleteAddressItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteAddressItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressItemRequest);
            return new SyncInvoker<DeleteAddressItemResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddressItemResponse>);
        }
        
        /// <summary>
        /// 删除地址组
        ///
        /// 删除地址组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAddressSetResponse DeleteAddressSet(DeleteAddressSetRequest deleteAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAddressSetResponse>(response);
        }

        public SyncInvoker<DeleteAddressSetResponse> DeleteAddressSetInvoker(DeleteAddressSetRequest deleteAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressSetRequest);
            return new SyncInvoker<DeleteAddressSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAddressSetResponse>);
        }
        
        /// <summary>
        /// 删除黑白名单规则
        ///
        /// 删除黑白名单规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBlackWhiteListResponse DeleteBlackWhiteList(DeleteBlackWhiteListRequest deleteBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", deleteBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>(response);
        }

        public SyncInvoker<DeleteBlackWhiteListResponse> DeleteBlackWhiteListInvoker(DeleteBlackWhiteListRequest deleteBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", deleteBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBlackWhiteListRequest);
            return new SyncInvoker<DeleteBlackWhiteListResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 删除抓包任务
        ///
        /// 删除抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCaptureTaskResponse DeleteCaptureTask(DeleteCaptureTaskRequest deleteCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCaptureTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteCaptureTaskResponse>(response);
        }

        public SyncInvoker<DeleteCaptureTaskResponse> DeleteCaptureTaskInvoker(DeleteCaptureTaskRequest deleteCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCaptureTaskRequest);
            return new SyncInvoker<DeleteCaptureTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 删除域名组
        ///
        /// 删除域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainSetResponse DeleteDomainSet(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainSetResponse>(response);
        }

        public SyncInvoker<DeleteDomainSetResponse> DeleteDomainSetInvoker(DeleteDomainSetRequest deleteDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainSetRequest);
            return new SyncInvoker<DeleteDomainSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainSetResponse>);
        }
        
        /// <summary>
        /// 删除域名列表
        ///
        /// 删除域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainsResponse DeleteDomains(DeleteDomainsRequest deleteDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainsResponse>(response);
        }

        public SyncInvoker<DeleteDomainsResponse> DeleteDomainsInvoker(DeleteDomainsRequest deleteDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteDomainsRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainsRequest);
            return new SyncInvoker<DeleteDomainsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainsResponse>);
        }
        
        /// <summary>
        /// 删除防火墙
        ///
        /// 删除防火墙，仅按需生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFirewallResponse DeleteFirewall(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteFirewallRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFirewallResponse>(response);
        }

        public SyncInvoker<DeleteFirewallResponse> DeleteFirewallInvoker(DeleteFirewallRequest deleteFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteFirewallRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/firewall/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFirewallRequest);
            return new SyncInvoker<DeleteFirewallResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFirewallResponse>);
        }
        
        /// <summary>
        /// 删除服务成员
        ///
        /// 删除服务组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceItemResponse DeleteServiceItem(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteServiceItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceItemResponse>(response);
        }

        public SyncInvoker<DeleteServiceItemResponse> DeleteServiceItemInvoker(DeleteServiceItemRequest deleteServiceItemRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("item_id", deleteServiceItemRequest.ItemId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items/{item_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceItemRequest);
            return new SyncInvoker<DeleteServiceItemResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceItemResponse>);
        }
        
        /// <summary>
        /// 删除服务组
        ///
        /// 删除服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServiceSetResponse DeleteServiceSet(DeleteServiceSetRequest deleteServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServiceSetResponse>(response);
        }

        public SyncInvoker<DeleteServiceSetResponse> DeleteServiceSetInvoker(DeleteServiceSetRequest deleteServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", deleteServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServiceSetRequest);
            return new SyncInvoker<DeleteServiceSetResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServiceSetResponse>);
        }
        
        /// <summary>
        /// 删除标签
        ///
        /// 删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", deleteTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public SyncInvoker<DeleteTagResponse> DeleteTagInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fw_instance_id", deleteTagRequest.FwInstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-cfw/{fw_instance_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new SyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 查询访问控制日志
        ///
        /// 查询访问控制日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessControlLogsResponse ListAccessControlLogs(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessControlLogsResponse>(response);
        }

        public SyncInvoker<ListAccessControlLogsResponse> ListAccessControlLogsInvoker(ListAccessControlLogsRequest listAccessControlLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/access-control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlLogsRequest);
            return new SyncInvoker<ListAccessControlLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessControlLogsResponse>);
        }
        
        /// <summary>
        /// 查询地址组成员
        ///
        /// 查询地址组成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressItemsResponse ListAddressItems(ListAddressItemsRequest listAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressItemsResponse>(response);
        }

        public SyncInvoker<ListAddressItemsResponse> ListAddressItemsInvoker(ListAddressItemsRequest listAddressItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressItemsRequest);
            return new SyncInvoker<ListAddressItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressItemsResponse>);
        }
        
        /// <summary>
        /// 查询地址组详细信息
        ///
        /// 查询地址组详细
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressSetDetailResponse ListAddressSetDetail(ListAddressSetDetailRequest listAddressSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listAddressSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressSetDetailResponse>(response);
        }

        public SyncInvoker<ListAddressSetDetailResponse> ListAddressSetDetailInvoker(ListAddressSetDetailRequest listAddressSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listAddressSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetDetailRequest);
            return new SyncInvoker<ListAddressSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressSetDetailResponse>);
        }
        
        /// <summary>
        /// 查询地址组列表
        ///
        /// 查询地址组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAddressSetsResponse ListAddressSets(ListAddressSetsRequest listAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAddressSetsResponse>(response);
        }

        public SyncInvoker<ListAddressSetsResponse> ListAddressSetsInvoker(ListAddressSetsRequest listAddressSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressSetsRequest);
            return new SyncInvoker<ListAddressSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAddressSetsResponse>);
        }
        
        /// <summary>
        /// 查询攻击日志
        ///
        /// 查询攻击日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttackLogsResponse ListAttackLogs(ListAttackLogsRequest listAttackLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttackLogsResponse>(response);
        }

        public SyncInvoker<ListAttackLogsResponse> ListAttackLogsInvoker(ListAttackLogsRequest listAttackLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/attack", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttackLogsRequest);
            return new SyncInvoker<ListAttackLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttackLogsResponse>);
        }
        
        /// <summary>
        /// 查询黑白名单列表
        ///
        /// 查询黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBlackWhiteListsResponse ListBlackWhiteLists(ListBlackWhiteListsRequest listBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBlackWhiteListsResponse>(response);
        }

        public SyncInvoker<ListBlackWhiteListsResponse> ListBlackWhiteListsInvoker(ListBlackWhiteListsRequest listBlackWhiteListsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-lists", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBlackWhiteListsRequest);
            return new SyncInvoker<ListBlackWhiteListsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBlackWhiteListsResponse>);
        }
        
        /// <summary>
        /// 获取抓包任务结果
        ///
        /// 获取抓包任务结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCaptureResultResponse ListCaptureResult(ListCaptureResultRequest listCaptureResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/capture-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCaptureResultResponse>(response);
        }

        public SyncInvoker<ListCaptureResultResponse> ListCaptureResultInvoker(ListCaptureResultRequest listCaptureResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task/capture-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureResultRequest);
            return new SyncInvoker<ListCaptureResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCaptureResultResponse>);
        }
        
        /// <summary>
        /// 查询抓包任务
        ///
        /// 查询抓包任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCaptureTaskResponse ListCaptureTask(ListCaptureTaskRequest listCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCaptureTaskResponse>(response);
        }

        public SyncInvoker<ListCaptureTaskResponse> ListCaptureTaskInvoker(ListCaptureTaskRequest listCaptureTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/capture-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCaptureTaskRequest);
            return new SyncInvoker<ListCaptureTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCaptureTaskResponse>);
        }
        
        /// <summary>
        /// 查询dns服务器列表
        ///
        /// 查询dns服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDnsServersResponse ListDnsServers(ListDnsServersRequest listDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDnsServersResponse>(response);
        }

        public SyncInvoker<ListDnsServersResponse> ListDnsServersInvoker(ListDnsServersRequest listDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDnsServersRequest);
            return new SyncInvoker<ListDnsServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDnsServersResponse>);
        }
        
        /// <summary>
        /// 查询域名解析ip地址
        ///
        /// 测试域名有效性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainParseDetailResponse ListDomainParseDetail(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainParseDetailRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainParseDetailResponse>(response);
        }

        public SyncInvoker<ListDomainParseDetailResponse> ListDomainParseDetailInvoker(ListDomainParseDetailRequest listDomainParseDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listDomainParseDetailRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/parse/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainParseDetailRequest);
            return new SyncInvoker<ListDomainParseDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainParseDetailResponse>);
        }
        
        /// <summary>
        /// 查询域名组列表
        ///
        /// 查询域名组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainSetsResponse ListDomainSets(ListDomainSetsRequest listDomainSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainSetsResponse>(response);
        }

        public SyncInvoker<ListDomainSetsResponse> ListDomainSetsInvoker(ListDomainSetsRequest listDomainSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainSetsRequest);
            return new SyncInvoker<ListDomainSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainSetsResponse>);
        }
        
        /// <summary>
        /// 获取域名组下域名列表
        ///
        /// 获取域名组下域名列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id", listDomainsRequest.DomainSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public SyncInvoker<ListDomainsResponse> ListDomainsInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_set_id", listDomainsRequest.DomainSetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/domains/{domain_set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new SyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 获取东西向防火墙信息
        ///
        /// 获取东西向防火墙信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEastWestFirewallResponse ListEastWestFirewall(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEastWestFirewallResponse>(response);
        }

        public SyncInvoker<ListEastWestFirewallResponse> ListEastWestFirewallInvoker(ListEastWestFirewallRequest listEastWestFirewallRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/east-west", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEastWestFirewallRequest);
            return new SyncInvoker<ListEastWestFirewallResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEastWestFirewallResponse>);
        }
        
        /// <summary>
        /// 查询防火墙详细信息
        ///
        /// 查询防火墙实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallDetailResponse ListFirewallDetail(ListFirewallDetailRequest listFirewallDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFirewallDetailResponse>(response);
        }

        public SyncInvoker<ListFirewallDetailResponse> ListFirewallDetailInvoker(ListFirewallDetailRequest listFirewallDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewall/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallDetailRequest);
            return new SyncInvoker<ListFirewallDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFirewallDetailResponse>);
        }
        
        /// <summary>
        /// 查询防火墙列表
        ///
        /// 查询防火墙列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFirewallListResponse ListFirewallList(ListFirewallListRequest listFirewallListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListFirewallListResponse>(response);
        }

        public SyncInvoker<ListFirewallListResponse> ListFirewallListInvoker(ListFirewallListRequest listFirewallListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/firewalls/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFirewallListRequest);
            return new SyncInvoker<ListFirewallListResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFirewallListResponse>);
        }
        
        /// <summary>
        /// 查询流日志
        ///
        /// 查询流日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFlowLogsResponse ListFlowLogs(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFlowLogsResponse>(response);
        }

        public SyncInvoker<ListFlowLogsResponse> ListFlowLogsInvoker(ListFlowLogsRequest listFlowLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/flow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowLogsRequest);
            return new SyncInvoker<ListFlowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowLogsResponse>);
        }
        
        /// <summary>
        /// 获取CFW任务执行状态
        ///
        /// 获取CFW任务执行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobResponse ListJob(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobResponse>(response);
        }

        public SyncInvoker<ListJobResponse> ListJobInvoker(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            return new SyncInvoker<ListJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobResponse>);
        }
        
        /// <summary>
        /// 获取日志配置
        ///
        /// 获取日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogConfigResponse ListLogConfig(ListLogConfigRequest listLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogConfigResponse>(response);
        }

        public SyncInvoker<ListLogConfigResponse> ListLogConfigInvoker(ListLogConfigRequest listLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogConfigRequest);
            return new SyncInvoker<ListLogConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogConfigResponse>);
        }
        
        /// <summary>
        /// 查询防护VPC数
        ///
        /// 查询防护vpc信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProtectedVpcsResponse ListProtectedVpcs(ListProtectedVpcsRequest listProtectedVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProtectedVpcsResponse>(response);
        }

        public SyncInvoker<ListProtectedVpcsResponse> ListProtectedVpcsInvoker(ListProtectedVpcsRequest listProtectedVpcsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/protection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedVpcsRequest);
            return new SyncInvoker<ListProtectedVpcsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProtectedVpcsResponse>);
        }
        
        /// <summary>
        /// 查询服务成员列表
        ///
        /// 查询服务组成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceItemsResponse ListServiceItems(ListServiceItemsRequest listServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceItemsResponse>(response);
        }

        public SyncInvoker<ListServiceItemsResponse> ListServiceItemsInvoker(ListServiceItemsRequest listServiceItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceItemsRequest);
            return new SyncInvoker<ListServiceItemsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceItemsResponse>);
        }
        
        /// <summary>
        /// 查询服务组详情
        ///
        /// 查询服务组细节
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceSetDetailResponse ListServiceSetDetail(ListServiceSetDetailRequest listServiceSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listServiceSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceSetDetailResponse>(response);
        }

        public SyncInvoker<ListServiceSetDetailResponse> ListServiceSetDetailInvoker(ListServiceSetDetailRequest listServiceSetDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", listServiceSetDetailRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetDetailRequest);
            return new SyncInvoker<ListServiceSetDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceSetDetailResponse>);
        }
        
        /// <summary>
        /// 获取服务组列表
        ///
        /// 获取服务组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceSetsResponse ListServiceSets(ListServiceSetsRequest listServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceSetsResponse>(response);
        }

        public SyncInvoker<ListServiceSetsResponse> ListServiceSetsInvoker(ListServiceSetsRequest listServiceSetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceSetsRequest);
            return new SyncInvoker<ListServiceSetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceSetsResponse>);
        }
        
        /// <summary>
        /// 更新地址组信息
        ///
        /// 更新地址组信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAddressSetResponse UpdateAddressSet(UpdateAddressSetRequest updateAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAddressSetResponse>(response);
        }

        public SyncInvoker<UpdateAddressSetResponse> UpdateAddressSetInvoker(UpdateAddressSetRequest updateAddressSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateAddressSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/address-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressSetRequest);
            return new SyncInvoker<UpdateAddressSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAddressSetResponse>);
        }
        
        /// <summary>
        /// 更新黑白名单列表
        ///
        /// 更新黑白名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBlackWhiteListResponse UpdateBlackWhiteList(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", updateBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }

        public SyncInvoker<UpdateBlackWhiteListResponse> UpdateBlackWhiteListInvoker(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("list_id", updateBlackWhiteListRequest.ListId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/black-white-list/{list_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            return new SyncInvoker<UpdateBlackWhiteListResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 更新dns服务器列表
        ///
        /// 更新dns服务器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDnsServersResponse UpdateDnsServers(UpdateDnsServersRequest updateDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDnsServersResponse>(response);
        }

        public SyncInvoker<UpdateDnsServersResponse> UpdateDnsServersInvoker(UpdateDnsServersRequest updateDnsServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dns/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDnsServersRequest);
            return new SyncInvoker<UpdateDnsServersResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDnsServersResponse>);
        }
        
        /// <summary>
        /// 更新域名组
        ///
        /// 更新域名组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainSetResponse UpdateDomainSet(UpdateDomainSetRequest updateDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainSetResponse>(response);
        }

        public SyncInvoker<UpdateDomainSetResponse> UpdateDomainSetInvoker(UpdateDomainSetRequest updateDomainSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateDomainSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain-set/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainSetRequest);
            return new SyncInvoker<UpdateDomainSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainSetResponse>);
        }
        
        /// <summary>
        /// 更新日志配置
        ///
        /// 更新日志配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogConfigResponse UpdateLogConfig(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogConfigResponse>(response);
        }

        public SyncInvoker<UpdateLogConfigResponse> UpdateLogConfigInvoker(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cfw/logs/configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            return new SyncInvoker<UpdateLogConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogConfigResponse>);
        }
        
        /// <summary>
        /// 修改服务组
        ///
        /// 更新服务组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServiceSetResponse UpdateServiceSet(UpdateServiceSetRequest updateServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateServiceSetResponse>(response);
        }

        public SyncInvoker<UpdateServiceSetResponse> UpdateServiceSetInvoker(UpdateServiceSetRequest updateServiceSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("set_id", updateServiceSetRequest.SetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/service-sets/{set_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServiceSetRequest);
            return new SyncInvoker<UpdateServiceSetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateServiceSetResponse>);
        }
        
        /// <summary>
        /// 创建ACL规则
        ///
        /// 创建ACL规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAclRuleResponse AddAclRule(AddAclRuleRequest addAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddAclRuleResponse>(response);
        }

        public SyncInvoker<AddAclRuleResponse> AddAclRuleInvoker(AddAclRuleRequest addAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAclRuleRequest);
            return new SyncInvoker<AddAclRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddAclRuleResponse>);
        }
        
        /// <summary>
        /// 批量删除Acl规则
        ///
        /// 批量删除Acl规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAclRulesResponse BatchDeleteAclRules(BatchDeleteAclRulesRequest batchDeleteAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>(response);
        }

        public SyncInvoker<BatchDeleteAclRulesResponse> BatchDeleteAclRulesInvoker(BatchDeleteAclRulesRequest batchDeleteAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAclRulesRequest);
            return new SyncInvoker<BatchDeleteAclRulesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteAclRulesResponse>);
        }
        
        /// <summary>
        /// 批量更新规则动作
        ///
        /// 批量更新规则动作
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateAclRuleActionsResponse BatchUpdateAclRuleActions(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>(response);
        }

        public SyncInvoker<BatchUpdateAclRuleActionsResponse> BatchUpdateAclRuleActionsInvoker(BatchUpdateAclRuleActionsRequest batchUpdateAclRuleActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAclRuleActionsRequest);
            return new SyncInvoker<BatchUpdateAclRuleActionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateAclRuleActionsResponse>);
        }
        
        /// <summary>
        /// 删除ACL规则
        ///
        /// 删除ACL规则组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAclRuleResponse DeleteAclRule(DeleteAclRuleRequest deleteAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", deleteAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAclRuleResponse>(response);
        }

        public SyncInvoker<DeleteAclRuleResponse> DeleteAclRuleInvoker(DeleteAclRuleRequest deleteAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", deleteAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleRequest);
            return new SyncInvoker<DeleteAclRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAclRuleResponse>);
        }
        
        /// <summary>
        /// 删除规则击中次数
        ///
        /// 清除规则击中次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAclRuleHitCountResponse DeleteAclRuleHitCount(DeleteAclRuleHitCountRequest deleteAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>(response);
        }

        public SyncInvoker<DeleteAclRuleHitCountResponse> DeleteAclRuleHitCountInvoker(DeleteAclRuleHitCountRequest deleteAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAclRuleHitCountRequest);
            return new SyncInvoker<DeleteAclRuleHitCountResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAclRuleHitCountResponse>);
        }
        
        /// <summary>
        /// 获取规则击中次数
        ///
        /// 获取规则击中次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAclRuleHitCountResponse ListAclRuleHitCount(ListAclRuleHitCountRequest listAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAclRuleHitCountResponse>(response);
        }

        public SyncInvoker<ListAclRuleHitCountResponse> ListAclRuleHitCountInvoker(ListAclRuleHitCountRequest listAclRuleHitCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRuleHitCountRequest);
            return new SyncInvoker<ListAclRuleHitCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAclRuleHitCountResponse>);
        }
        
        /// <summary>
        /// 查询防护规则
        ///
        /// 查询防护规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAclRulesResponse ListAclRules(ListAclRulesRequest listAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAclRulesResponse>(response);
        }

        public SyncInvoker<ListAclRulesResponse> ListAclRulesInvoker(ListAclRulesRequest listAclRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAclRulesRequest);
            return new SyncInvoker<ListAclRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAclRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则标签
        ///
        /// 查询规则标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleAclTagsResponse ListRuleAclTags(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRuleAclTagsResponse>(response);
        }

        public SyncInvoker<ListRuleAclTagsResponse> ListRuleAclTagsInvoker(ListRuleAclTagsRequest listRuleAclTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cfw-acl/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleAclTagsRequest);
            return new SyncInvoker<ListRuleAclTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleAclTagsResponse>);
        }
        
        /// <summary>
        /// 更新ACL规则
        ///
        /// 更新ACL规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclRuleResponse UpdateAclRule(UpdateAclRuleRequest updateAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclRuleResponse>(response);
        }

        public SyncInvoker<UpdateAclRuleResponse> UpdateAclRuleInvoker(UpdateAclRuleRequest updateAclRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleRequest);
            return new SyncInvoker<UpdateAclRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclRuleResponse>);
        }
        
        /// <summary>
        /// ACL防护规则优先级设置
        ///
        /// ACL防护规则优先级设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAclRuleOrderResponse UpdateAclRuleOrder(UpdateAclRuleOrderRequest updateAclRuleOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleOrderRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>(response);
        }

        public SyncInvoker<UpdateAclRuleOrderResponse> UpdateAclRuleOrderInvoker(UpdateAclRuleOrderRequest updateAclRuleOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("acl_rule_id", updateAclRuleOrderRequest.AclRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/acl-rule/order/{acl_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAclRuleOrderRequest);
            return new SyncInvoker<UpdateAclRuleOrderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAclRuleOrderResponse>);
        }
        
        /// <summary>
        /// 弹性IP开启关闭
        ///
        /// 开启关闭EIP，客户购买EIP后首次开启EIP防护前需使用ListEips同步EIP资产，sync字段设置为1。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeEipStatusResponse ChangeEipStatus(ChangeEipStatusRequest changeEipStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeEipStatusResponse>(response);
        }

        public SyncInvoker<ChangeEipStatusResponse> ChangeEipStatusInvoker(ChangeEipStatusRequest changeEipStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeEipStatusRequest);
            return new SyncInvoker<ChangeEipStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeEipStatusResponse>);
        }
        
        /// <summary>
        /// 查询Eip个数
        ///
        /// 查询Eip个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEipCountResponse ListEipCount(ListEipCountRequest listEipCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id", listEipCountRequest.ObjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEipCountResponse>(response);
        }

        public SyncInvoker<ListEipCountResponse> ListEipCountInvoker(ListEipCountRequest listEipCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("object_id", listEipCountRequest.ObjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eip-count/{object_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipCountRequest);
            return new SyncInvoker<ListEipCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipCountResponse>);
        }
        
        /// <summary>
        /// 弹性IP列表查询
        ///
        /// 弹性IP列表查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEipsResponse ListEips(ListEipsRequest listEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEipsResponse>(response);
        }

        public SyncInvoker<ListEipsResponse> ListEipsInvoker(ListEipsRequest listEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/eips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEipsRequest);
            return new SyncInvoker<ListEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEipsResponse>);
        }
        
        /// <summary>
        /// 切换防护模式
        ///
        /// 切换防护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeIpsProtectModeResponse ChangeIpsProtectMode(ChangeIpsProtectModeRequest changeIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>(response);
        }

        public SyncInvoker<ChangeIpsProtectModeResponse> ChangeIpsProtectModeInvoker(ChangeIpsProtectModeRequest changeIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsProtectModeRequest);
            return new SyncInvoker<ChangeIpsProtectModeResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsProtectModeResponse>);
        }
        
        /// <summary>
        /// IPS特性开关操作
        ///
        /// 切换开关状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeIpsSwitchStatusResponse ChangeIpsSwitchStatus(ChangeIpsSwitchStatusRequest changeIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>(response);
        }

        public SyncInvoker<ChangeIpsSwitchStatusResponse> ChangeIpsSwitchStatusInvoker(ChangeIpsSwitchStatusRequest changeIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeIpsSwitchStatusRequest);
            return new SyncInvoker<ChangeIpsSwitchStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeIpsSwitchStatusResponse>);
        }
        
        /// <summary>
        /// 查询防护模式
        ///
        /// 查询防护模式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpsProtectModeResponse ListIpsProtectMode(ListIpsProtectModeRequest listIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpsProtectModeResponse>(response);
        }

        public SyncInvoker<ListIpsProtectModeResponse> ListIpsProtectModeInvoker(ListIpsProtectModeRequest listIpsProtectModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsProtectModeRequest);
            return new SyncInvoker<ListIpsProtectModeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsProtectModeResponse>);
        }
        
        /// <summary>
        /// 查询IPS特性开关状态
        ///
        /// 查询IPS特性开关状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpsSwitchStatusResponse ListIpsSwitchStatus(ListIpsSwitchStatusRequest listIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>(response);
        }

        public SyncInvoker<ListIpsSwitchStatusResponse> ListIpsSwitchStatusInvoker(ListIpsSwitchStatusRequest listIpsSwitchStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ips/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpsSwitchStatusRequest);
            return new SyncInvoker<ListIpsSwitchStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpsSwitchStatusResponse>);
        }
        
    }
}