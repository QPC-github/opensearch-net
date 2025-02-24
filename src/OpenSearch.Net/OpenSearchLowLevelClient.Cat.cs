/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net;
using static OpenSearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace OpenSearch.Net.Specification.CatApi
{
	///<summary>
	/// Cat APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchLowLevelClient.Cat"/> property
	/// on <see cref = "IOpenSearchLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelCatNamespace : NamespacedClientProxy
	{
		internal LowLevelCatNamespace(OpenSearchLowLevelClient client): base(client)
		{
		}

		protected override string ContentType
		{
			get;
		}

		= "text/plain";
		///<summary>GET on /_cat/aliases <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Aliases<TResponse>(CatAliasesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/aliases", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/aliases <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.aliases", "")]
		public Task<TResponse> AliasesAsync<TResponse>(CatAliasesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/aliases", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/aliases/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</para></summary>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Aliases<TResponse>(string name, CatAliasesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/aliases/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/aliases/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-aliases/</para></summary>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.aliases", "name")]
		public Task<TResponse> AliasesAsync<TResponse>(string name, CatAliasesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/aliases/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/allocation <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Allocation<TResponse>(CatAllocationRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/allocation", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/allocation <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.allocation", "")]
		public Task<TResponse> AllocationAsync<TResponse>(CatAllocationRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/allocation", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/allocation/{node_id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</para></summary>
		///<param name = "nodeId">A comma-separated list of node IDs or names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Allocation<TResponse>(string nodeId, CatAllocationRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/allocation/{nodeId:nodeId}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/allocation/{node_id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-allocation/</para></summary>
		///<param name = "nodeId">A comma-separated list of node IDs or names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.allocation", "node_id")]
		public Task<TResponse> AllocationAsync<TResponse>(string nodeId, CatAllocationRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/allocation/{nodeId:nodeId}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/count <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Count<TResponse>(CatCountRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/count", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/count <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.count", "")]
		public Task<TResponse> CountAsync<TResponse>(CatCountRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/count", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/count/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Count<TResponse>(string index, CatCountRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/count/{index:index}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/count/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-count/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.count", "index")]
		public Task<TResponse> CountAsync<TResponse>(string index, CatCountRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/count/{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/fielddata <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Fielddata<TResponse>(CatFielddataRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/fielddata", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/fielddata <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.fielddata", "")]
		public Task<TResponse> FielddataAsync<TResponse>(CatFielddataRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/fielddata", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/fielddata/{fields} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</para></summary>
		///<param name = "fields">A comma-separated list of fields to return the fielddata size</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Fielddata<TResponse>(string fields, CatFielddataRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/fielddata/{fields:fields}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/fielddata/{fields} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-field-data/</para></summary>
		///<param name = "fields">A comma-separated list of fields to return the fielddata size</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.fielddata", "fields")]
		public Task<TResponse> FielddataAsync<TResponse>(string fields, CatFielddataRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/fielddata/{fields:fields}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/health <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Health<TResponse>(CatHealthRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/health", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/health <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-health/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.health", "")]
		public Task<TResponse> HealthAsync<TResponse>(CatHealthRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/health", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Help<TResponse>(CatHelpRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat", null, RequestParams(requestParameters));
		///<summary>GET on /_cat <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/index/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.help", "")]
		public Task<TResponse> HelpAsync<TResponse>(CatHelpRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/indices <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Indices<TResponse>(CatIndicesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/indices", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/indices <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.indices", "")]
		public Task<TResponse> IndicesAsync<TResponse>(CatIndicesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/indices", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/indices/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Indices<TResponse>(string index, CatIndicesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/indices/{index:index}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/indices/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-indices/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.indices", "index")]
		public Task<TResponse> IndicesAsync<TResponse>(string index, CatIndicesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/indices/{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/master <para>https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</para></summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManager"/> instead</remarks>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Master<TResponse>(CatMasterRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/master", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/master <para>https://opensearch.org/docs/1.2/opensearch/rest-api/cat/cat-master/</para></summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerAsync"/> instead</remarks>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.master", "")]
		public Task<TResponse> MasterAsync<TResponse>(CatMasterRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/master", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/cluster_manager <para>https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/</para></summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="Master"/></remarks>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ClusterManager<TResponse>(CatClusterManagerRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/cluster_manager", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/cluster_manager <para>https://opensearch.org/docs/2.0/opensearch/rest-api/cat/cat-cluster_manager/</para></summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterAsync"/></remarks>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.cluster_manager", "")]
		public Task<TResponse> ClusterManagerAsync<TResponse>(CatClusterManagerRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/cluster_manager", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/nodeattrs <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse NodeAttributes<TResponse>(CatNodeAttributesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/nodeattrs", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/nodeattrs <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodeattrs/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.nodeattrs", "")]
		public Task<TResponse> NodeAttributesAsync<TResponse>(CatNodeAttributesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/nodeattrs", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/nodes <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Nodes<TResponse>(CatNodesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/nodes", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/nodes <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.nodes", "")]
		public Task<TResponse> NodesAsync<TResponse>(CatNodesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/nodes", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/pending_tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PendingTasks<TResponse>(CatPendingTasksRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/pending_tasks", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/pending_tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-pending-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.pending_tasks", "")]
		public Task<TResponse> PendingTasksAsync<TResponse>(CatPendingTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/pending_tasks", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/plugins <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Plugins<TResponse>(CatPluginsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/plugins", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/plugins <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-plugins/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.plugins", "")]
		public Task<TResponse> PluginsAsync<TResponse>(CatPluginsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/plugins", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/recovery <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Recovery<TResponse>(CatRecoveryRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/recovery", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/recovery <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.recovery", "")]
		public Task<TResponse> RecoveryAsync<TResponse>(CatRecoveryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/recovery", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/recovery/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</para></summary>
		///<param name = "index">Comma-separated list or wildcard expression of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Recovery<TResponse>(string index, CatRecoveryRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/recovery/{index:index}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/recovery/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-recovery/</para></summary>
		///<param name = "index">Comma-separated list or wildcard expression of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.recovery", "index")]
		public Task<TResponse> RecoveryAsync<TResponse>(string index, CatRecoveryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/recovery/{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/repositories <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Repositories<TResponse>(CatRepositoriesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/repositories", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/repositories <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-repositories/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.repositories", "")]
		public Task<TResponse> RepositoriesAsync<TResponse>(CatRepositoriesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/repositories", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Segments<TResponse>(CatSegmentsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/segments", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.segments", "")]
		public Task<TResponse> SegmentsAsync<TResponse>(CatSegmentsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/segments", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/segments/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Segments<TResponse>(string index, CatSegmentsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/segments/{index:index}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/segments/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.segments", "index")]
		public Task<TResponse> SegmentsAsync<TResponse>(string index, CatSegmentsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/segments/{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/shards <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Shards<TResponse>(CatShardsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/shards", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/shards <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.shards", "")]
		public Task<TResponse> ShardsAsync<TResponse>(CatShardsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/shards", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/shards/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Shards<TResponse>(string index, CatShardsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/shards/{index:index}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/shards/{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-shards/</para></summary>
		///<param name = "index">A comma-separated list of index names to limit the returned information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.shards", "index")]
		public Task<TResponse> ShardsAsync<TResponse>(string index, CatShardsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/shards/{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/snapshots <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Snapshots<TResponse>(CatSnapshotsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/snapshots", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/snapshots <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.snapshots", "")]
		public Task<TResponse> SnapshotsAsync<TResponse>(CatSnapshotsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/snapshots", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/snapshots/{repository} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</para></summary>
		///<param name = "repository">Name of repository from which to fetch the snapshot information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Snapshots<TResponse>(string repository, CatSnapshotsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/snapshots/{repository:repository}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/snapshots/{repository} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</para></summary>
		///<param name = "repository">Name of repository from which to fetch the snapshot information</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.snapshots", "repository")]
		public Task<TResponse> SnapshotsAsync<TResponse>(string repository, CatSnapshotsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/snapshots/{repository:repository}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse Tasks<TResponse>(CatTasksRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/tasks", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/tasks <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-tasks/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("cat.tasks", "")]
		public Task<TResponse> TasksAsync<TResponse>(CatTasksRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/tasks", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/templates <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Templates<TResponse>(CatTemplatesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/templates", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/templates <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.templates", "")]
		public Task<TResponse> TemplatesAsync<TResponse>(CatTemplatesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/templates", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/templates/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">A pattern that returned template names must match</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Templates<TResponse>(string name, CatTemplatesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/templates/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/templates/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">A pattern that returned template names must match</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.templates", "name")]
		public Task<TResponse> TemplatesAsync<TResponse>(string name, CatTemplatesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/templates/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/thread_pool <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ThreadPool<TResponse>(CatThreadPoolRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_cat/thread_pool", null, RequestParams(requestParameters));
		///<summary>GET on /_cat/thread_pool <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.thread_pool", "")]
		public Task<TResponse> ThreadPoolAsync<TResponse>(CatThreadPoolRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_cat/thread_pool", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_cat/thread_pool/{thread_pool_patterns} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</para></summary>
		///<param name = "threadPoolPatterns">A comma-separated list of regular-expressions to filter the thread pools in the output</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ThreadPool<TResponse>(string threadPoolPatterns, CatThreadPoolRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_cat/thread_pool/{threadPoolPatterns:threadPoolPatterns}"), null, RequestParams(requestParameters));
		///<summary>GET on /_cat/thread_pool/{thread_pool_patterns} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-thread-pool/</para></summary>
		///<param name = "threadPoolPatterns">A comma-separated list of regular-expressions to filter the thread pools in the output</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("cat.thread_pool", "thread_pool_patterns")]
		public Task<TResponse> ThreadPoolAsync<TResponse>(string threadPoolPatterns, CatThreadPoolRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_cat/thread_pool/{threadPoolPatterns:threadPoolPatterns}"), ctx, null, RequestParams(requestParameters));
	}
}
