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
namespace OpenSearch.Net.Specification.IndicesApi
{
	///<summary>
	/// Indices APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchLowLevelClient.Indices"/> property
	/// on <see cref = "IOpenSearchLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelIndicesNamespace : NamespacedClientProxy
	{
		internal LowLevelIndicesNamespace(OpenSearchLowLevelClient client): base(client)
		{
		}

		///<summary>PUT on /{index}/_block/{block} <para></para></summary>
		///<param name = "index">A comma separated list of indices to add a block to</param>
		///<param name = "block">The block to add (one of read, write, read_only or metadata)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse AddBlock<TResponse>(string index, string block, AddIndexBlockRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_block/{block:block}"), null, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_block/{block} <para></para></summary>
		///<param name = "index">A comma separated list of indices to add a block to</param>
		///<param name = "block">The block to add (one of read, write, read_only or metadata)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.add_block", "index, block")]
		public Task<TResponse> AddBlockAsync<TResponse>(string index, string block, AddIndexBlockRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_block/{block:block}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_analyze <para></para></summary>
		///<param name = "body">Define analyzer/tokenizer parameters and the text on which the analysis should be performed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse AnalyzeForAll<TResponse>(PostData body, AnalyzeRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_analyze", body, RequestParams(requestParameters));
		///<summary>POST on /_analyze <para></para></summary>
		///<param name = "body">Define analyzer/tokenizer parameters and the text on which the analysis should be performed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.analyze", "body")]
		public Task<TResponse> AnalyzeForAllAsync<TResponse>(PostData body, AnalyzeRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_analyze", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_analyze <para></para></summary>
		///<param name = "index">The name of the index to scope the operation</param>
		///<param name = "body">Define analyzer/tokenizer parameters and the text on which the analysis should be performed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Analyze<TResponse>(string index, PostData body, AnalyzeRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_analyze"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_analyze <para></para></summary>
		///<param name = "index">The name of the index to scope the operation</param>
		///<param name = "body">Define analyzer/tokenizer parameters and the text on which the analysis should be performed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.analyze", "index, body")]
		public Task<TResponse> AnalyzeAsync<TResponse>(string index, PostData body, AnalyzeRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_analyze"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_cache/clear <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ClearCacheForAll<TResponse>(ClearCacheRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_cache/clear", null, RequestParams(requestParameters));
		///<summary>POST on /_cache/clear <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.clear_cache", "")]
		public Task<TResponse> ClearCacheForAllAsync<TResponse>(ClearCacheRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_cache/clear", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_cache/clear <para></para></summary>
		///<param name = "index">A comma-separated list of index name to limit the operation</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ClearCache<TResponse>(string index, ClearCacheRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_cache/clear"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_cache/clear <para></para></summary>
		///<param name = "index">A comma-separated list of index name to limit the operation</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.clear_cache", "index")]
		public Task<TResponse> ClearCacheAsync<TResponse>(string index, ClearCacheRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_cache/clear"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_clone/{target} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/clone/</para></summary>
		///<param name = "index">The name of the source index to clone</param>
		///<param name = "target">The name of the target index to clone into</param>
		///<param name = "body">The configuration for the target index (`settings` and `aliases`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Clone<TResponse>(string index, string target, PostData body, CloneIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_clone/{target:target}"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_clone/{target} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/clone/</para></summary>
		///<param name = "index">The name of the source index to clone</param>
		///<param name = "target">The name of the target index to clone into</param>
		///<param name = "body">The configuration for the target index (`settings` and `aliases`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.clone", "index, target, body")]
		public Task<TResponse> CloneAsync<TResponse>(string index, string target, PostData body, CloneIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_clone/{target:target}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_close <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/close-index/</para></summary>
		///<param name = "index">A comma separated list of indices to close</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Close<TResponse>(string index, CloseIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_close"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_close <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/close-index/</para></summary>
		///<param name = "index">A comma separated list of indices to close</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.close", "index")]
		public Task<TResponse> CloseAsync<TResponse>(string index, CloseIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_close"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/create-index/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "body">The configuration for the index (`settings` and `mappings`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Create<TResponse>(string index, PostData body, CreateIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/create-index/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "body">The configuration for the index (`settings` and `mappings`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.create", "index, body")]
		public Task<TResponse> CreateAsync<TResponse>(string index, PostData body, CreateIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}"), ctx, body, RequestParams(requestParameters));
		///<summary>DELETE on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/delete-index/</para></summary>
		///<param name = "index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Delete<TResponse>(string index, DeleteIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"{index:index}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/delete-index/</para></summary>
		///<param name = "index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.delete", "index")]
		public Task<TResponse> DeleteAsync<TResponse>(string index, DeleteIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>DELETE on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names (supports wildcards); use `_all` for all indices</param>
		///<param name = "name">A comma-separated list of aliases to delete (supports wildcards); use `_all` to delete all aliases for the specified indices.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteAlias<TResponse>(string index, string name, DeleteAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"{index:index}/_alias/{name:name}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names (supports wildcards); use `_all` for all indices</param>
		///<param name = "name">A comma-separated list of aliases to delete (supports wildcards); use `_all` to delete all aliases for the specified indices.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.delete_alias", "index, name")]
		public Task<TResponse> DeleteAliasAsync<TResponse>(string index, string name, DeleteAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"{index:index}/_alias/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>DELETE on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteTemplateV2ForAll<TResponse>(string name, DeleteIndexTemplateV2RequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_index_template/{name:name}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.delete_index_template", "name")]
		public Task<TResponse> DeleteTemplateV2ForAllAsync<TResponse>(string name, DeleteIndexTemplateV2RequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_index_template/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>DELETE on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteTemplateForAll<TResponse>(string name, DeleteIndexTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_template/{name:name}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.delete_template", "name")]
		public Task<TResponse> DeleteTemplateForAllAsync<TResponse>(string name, DeleteIndexTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_template/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>HEAD on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Exists<TResponse>(string index, IndexExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(HEAD, Url($"{index:index}"), null, RequestParams(requestParameters));
		///<summary>HEAD on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.exists", "index")]
		public Task<TResponse> ExistsAsync<TResponse>(string index, IndexExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(HEAD, Url($"{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>HEAD on /_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse AliasExistsForAll<TResponse>(string name, AliasExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(HEAD, Url($"_alias/{name:name}"), null, RequestParams(requestParameters));
		///<summary>HEAD on /_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.exists_alias", "name")]
		public Task<TResponse> AliasExistsForAllAsync<TResponse>(string name, AliasExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(HEAD, Url($"_alias/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>HEAD on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names to filter aliases</param>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse AliasExists<TResponse>(string index, string name, AliasExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(HEAD, Url($"{index:index}/_alias/{name:name}"), null, RequestParams(requestParameters));
		///<summary>HEAD on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names to filter aliases</param>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.exists_alias", "index, name")]
		public Task<TResponse> AliasExistsAsync<TResponse>(string index, string name, AliasExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(HEAD, Url($"{index:index}/_alias/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>HEAD on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ExistsTemplateForAll<TResponse>(string name, ExistsIndexTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(HEAD, Url($"_index_template/{name:name}"), null, RequestParams(requestParameters));
		///<summary>HEAD on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.exists_index_template", "name")]
		public Task<TResponse> ExistsTemplateForAllAsync<TResponse>(string name, ExistsIndexTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(HEAD, Url($"_index_template/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>HEAD on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The comma separated names of the index templates</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse TemplateExistsForAll<TResponse>(string name, IndexTemplateExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(HEAD, Url($"_template/{name:name}"), null, RequestParams(requestParameters));
		///<summary>HEAD on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The comma separated names of the index templates</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.exists_template", "name")]
		public Task<TResponse> TemplateExistsForAllAsync<TResponse>(string name, IndexTemplateExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(HEAD, Url($"_template/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>HEAD on /{index}/_mapping/{type} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
		///<param name = "index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
		///<param name = "type">A comma-separated list of document types to check</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		public TResponse TypeExists<TResponse>(string index, string type, TypeExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(HEAD, Url($"{index:index}/_mapping/{type:type}"), null, RequestParams(requestParameters));
		///<summary>HEAD on /{index}/_mapping/{type} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/exists/</para></summary>
		///<param name = "index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
		///<param name = "type">A comma-separated list of document types to check</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		[MapsApi("indices.exists_type", "index, type")]
		public Task<TResponse> TypeExistsAsync<TResponse>(string index, string type, TypeExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(HEAD, Url($"{index:index}/_mapping/{type:type}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_flush <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse FlushForAll<TResponse>(FlushRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_flush", null, RequestParams(requestParameters));
		///<summary>POST on /_flush <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.flush", "")]
		public Task<TResponse> FlushForAllAsync<TResponse>(FlushRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_flush", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_flush <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All for all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Flush<TResponse>(string index, FlushRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_flush"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_flush <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All for all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.flush", "index")]
		public Task<TResponse> FlushAsync<TResponse>(string index, FlushRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_flush"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_forcemerge <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ForceMergeForAll<TResponse>(ForceMergeRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_forcemerge", null, RequestParams(requestParameters));
		///<summary>POST on /_forcemerge <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.forcemerge", "")]
		public Task<TResponse> ForceMergeForAllAsync<TResponse>(ForceMergeRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_forcemerge", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_forcemerge <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ForceMerge<TResponse>(string index, ForceMergeRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_forcemerge"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_forcemerge <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.forcemerge", "index")]
		public Task<TResponse> ForceMergeAsync<TResponse>(string index, ForceMergeRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_forcemerge"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/get-index/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(string index, GetIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}"), null, RequestParams(requestParameters));
		///<summary>GET on /{index} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/get-index/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get", "index")]
		public Task<TResponse> GetAsync<TResponse>(string index, GetIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_alias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetAliasForAll<TResponse>(GetAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_alias", null, RequestParams(requestParameters));
		///<summary>GET on /_alias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_alias", "")]
		public Task<TResponse> GetAliasForAllAsync<TResponse>(GetAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_alias", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetAliasForAll<TResponse>(string name, GetAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_alias/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_alias", "name")]
		public Task<TResponse> GetAliasForAllAsync<TResponse>(string name, GetAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_alias/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names to filter aliases</param>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetAlias<TResponse>(string index, string name, GetAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_alias/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names to filter aliases</param>
		///<param name = "name">A comma-separated list of alias names to return</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_alias", "index, name")]
		public Task<TResponse> GetAliasAsync<TResponse>(string index, string name, GetAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_alias/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_alias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names to filter aliases</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetAlias<TResponse>(string index, GetAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_alias"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_alias <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names to filter aliases</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_alias", "index")]
		public Task<TResponse> GetAliasAsync<TResponse>(string index, GetAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_alias"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_mapping/field/{fields} <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "fields">A comma-separated list of fields</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetFieldMappingForAll<TResponse>(string fields, GetFieldMappingRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_mapping/field/{fields:fields}"), null, RequestParams(requestParameters));
		///<summary>GET on /_mapping/field/{fields} <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "fields">A comma-separated list of fields</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_field_mapping", "fields")]
		public Task<TResponse> GetFieldMappingForAllAsync<TResponse>(string fields, GetFieldMappingRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_mapping/field/{fields:fields}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_mapping/field/{fields} <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "fields">A comma-separated list of fields</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetFieldMapping<TResponse>(string index, string fields, GetFieldMappingRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_mapping/field/{fields:fields}"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_mapping/field/{fields} <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "fields">A comma-separated list of fields</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_field_mapping", "index, fields")]
		public Task<TResponse> GetFieldMappingAsync<TResponse>(string index, string fields, GetFieldMappingRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_mapping/field/{fields:fields}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_index_template <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetTemplateV2ForAll<TResponse>(GetIndexTemplateV2RequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_index_template", null, RequestParams(requestParameters));
		///<summary>GET on /_index_template <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_index_template", "")]
		public Task<TResponse> GetTemplateV2ForAllAsync<TResponse>(GetIndexTemplateV2RequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_index_template", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The comma separated names of the index templates</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetTemplateV2ForAll<TResponse>(string name, GetIndexTemplateV2RequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_index_template/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The comma separated names of the index templates</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_index_template", "name")]
		public Task<TResponse> GetTemplateV2ForAllAsync<TResponse>(string name, GetIndexTemplateV2RequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_index_template/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_mapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetMappingForAll<TResponse>(GetMappingRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_mapping", null, RequestParams(requestParameters));
		///<summary>GET on /_mapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_mapping", "")]
		public Task<TResponse> GetMappingForAllAsync<TResponse>(GetMappingRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_mapping", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_mapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetMapping<TResponse>(string index, GetMappingRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_mapping"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_mapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "index">A comma-separated list of index names</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_mapping", "index")]
		public Task<TResponse> GetMappingAsync<TResponse>(string index, GetMappingRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_mapping"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_settings <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetSettingsForAll<TResponse>(GetIndexSettingsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_settings", null, RequestParams(requestParameters));
		///<summary>GET on /_settings <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_settings", "")]
		public Task<TResponse> GetSettingsForAllAsync<TResponse>(GetIndexSettingsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_settings", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_settings <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetSettings<TResponse>(string index, GetIndexSettingsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_settings"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_settings <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_settings", "index")]
		public Task<TResponse> GetSettingsAsync<TResponse>(string index, GetIndexSettingsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_settings"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_settings/{name} <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "name">The name of the settings that should be included</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetSettings<TResponse>(string index, string name, GetIndexSettingsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_settings/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_settings/{name} <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "name">The name of the settings that should be included</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_settings", "index, name")]
		public Task<TResponse> GetSettingsAsync<TResponse>(string index, string name, GetIndexSettingsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_settings/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_settings/{name} <para></para></summary>
		///<param name = "name">The name of the settings that should be included</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetSettingsForAll<TResponse>(string name, GetIndexSettingsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_settings/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_settings/{name} <para></para></summary>
		///<param name = "name">The name of the settings that should be included</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_settings", "name")]
		public Task<TResponse> GetSettingsForAllAsync<TResponse>(string name, GetIndexSettingsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_settings/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_template <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetTemplateForAll<TResponse>(GetIndexTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_template", null, RequestParams(requestParameters));
		///<summary>GET on /_template <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_template", "")]
		public Task<TResponse> GetTemplateForAllAsync<TResponse>(GetIndexTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_template", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The comma separated names of the index templates</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetTemplateForAll<TResponse>(string name, GetIndexTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_template/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The comma separated names of the index templates</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.get_template", "name")]
		public Task<TResponse> GetTemplateForAllAsync<TResponse>(string name, GetIndexTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_template/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_open <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/close-index/</para></summary>
		///<param name = "index">A comma separated list of indices to open</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Open<TResponse>(string index, OpenIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_open"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_open <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/close-index/</para></summary>
		///<param name = "index">A comma separated list of indices to open</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.open", "index")]
		public Task<TResponse> OpenAsync<TResponse>(string index, OpenIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_open"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name = "name">The name of the alias to be created or updated</param>
		///<param name = "body">The settings for the alias, such as `routing` or `filter`</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutAlias<TResponse>(string index, string name, PostData body, PutAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_alias/{name:name}"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_alias/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
		///<param name = "name">The name of the alias to be created or updated</param>
		///<param name = "body">The settings for the alias, such as `routing` or `filter`</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.put_alias", "index, name, body")]
		public Task<TResponse> PutAliasAsync<TResponse>(string index, string name, PostData body, PutAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_alias/{name:name}"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "body">The template definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutTemplateV2ForAll<TResponse>(string name, PostData body, PutIndexTemplateV2RequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_index_template/{name:name}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_index_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "body">The template definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.put_index_template", "name, body")]
		public Task<TResponse> PutTemplateV2ForAllAsync<TResponse>(string name, PostData body, PutIndexTemplateV2RequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_index_template/{name:name}"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_mapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
		///<param name = "body">The mapping definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutMapping<TResponse>(string index, PostData body, PutMappingRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_mapping"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_mapping <para>https://opensearch.org/docs/latest/opensearch/rest-api/update-mapping/</para></summary>
		///<param name = "index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
		///<param name = "body">The mapping definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.put_mapping", "index, body")]
		public Task<TResponse> PutMappingAsync<TResponse>(string index, PostData body, PutMappingRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_mapping"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_settings <para></para></summary>
		///<param name = "body">The index settings to be updated</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse UpdateSettingsForAll<TResponse>(PostData body, UpdateIndexSettingsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, "_settings", body, RequestParams(requestParameters));
		///<summary>PUT on /_settings <para></para></summary>
		///<param name = "body">The index settings to be updated</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.put_settings", "body")]
		public Task<TResponse> UpdateSettingsForAllAsync<TResponse>(PostData body, UpdateIndexSettingsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, "_settings", ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_settings <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The index settings to be updated</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse UpdateSettings<TResponse>(string index, PostData body, UpdateIndexSettingsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_settings"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_settings <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The index settings to be updated</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.put_settings", "index, body")]
		public Task<TResponse> UpdateSettingsAsync<TResponse>(string index, PostData body, UpdateIndexSettingsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_settings"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "body">The template definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutTemplateForAll<TResponse>(string name, PostData body, PutIndexTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_template/{name:name}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_template/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the template</param>
		///<param name = "body">The template definition</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.put_template", "name, body")]
		public Task<TResponse> PutTemplateForAllAsync<TResponse>(string name, PostData body, PutIndexTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_template/{name:name}"), ctx, body, RequestParams(requestParameters));
		///<summary>GET on /_recovery <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse RecoveryStatusForAll<TResponse>(RecoveryStatusRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_recovery", null, RequestParams(requestParameters));
		///<summary>GET on /_recovery <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.recovery", "")]
		public Task<TResponse> RecoveryStatusForAllAsync<TResponse>(RecoveryStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_recovery", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_recovery <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse RecoveryStatus<TResponse>(string index, RecoveryStatusRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_recovery"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_recovery <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.recovery", "index")]
		public Task<TResponse> RecoveryStatusAsync<TResponse>(string index, RecoveryStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_recovery"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_refresh <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse RefreshForAll<TResponse>(RefreshRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_refresh", null, RequestParams(requestParameters));
		///<summary>POST on /_refresh <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.refresh", "")]
		public Task<TResponse> RefreshForAllAsync<TResponse>(RefreshRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_refresh", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_refresh <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Refresh<TResponse>(string index, RefreshRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_refresh"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_refresh <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.refresh", "index")]
		public Task<TResponse> RefreshAsync<TResponse>(string index, RefreshRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_refresh"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_resolve/index/{name} <para></para></summary>
		///<param name = "name">A comma-separated list of names or wildcard expressions</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		public TResponse ResolveForAll<TResponse>(string name, ResolveIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_resolve/index/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_resolve/index/{name} <para></para></summary>
		///<param name = "name">A comma-separated list of names or wildcard expressions</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		[MapsApi("indices.resolve_index", "name")]
		public Task<TResponse> ResolveForAllAsync<TResponse>(string name, ResolveIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_resolve/index/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{alias}/_rollover <para>https://opensearch.org/docs/latest/opensearch/data-streams/#step-5-rollover-a-data-stream</para></summary>
		///<param name = "alias">The name of the alias to rollover</param>
		///<param name = "body">The conditions that needs to be met for executing rollover</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse RolloverForAll<TResponse>(string alias, PostData body, RolloverIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{alias:alias}/_rollover"), body, RequestParams(requestParameters));
		///<summary>POST on /{alias}/_rollover <para>https://opensearch.org/docs/latest/opensearch/data-streams/#step-5-rollover-a-data-stream</para></summary>
		///<param name = "alias">The name of the alias to rollover</param>
		///<param name = "body">The conditions that needs to be met for executing rollover</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.rollover", "alias, body")]
		public Task<TResponse> RolloverForAllAsync<TResponse>(string alias, PostData body, RolloverIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{alias:alias}/_rollover"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{alias}/_rollover/{new_index} <para>https://opensearch.org/docs/latest/opensearch/data-streams/#step-5-rollover-a-data-stream</para></summary>
		///<param name = "alias">The name of the alias to rollover</param>
		///<param name = "newIndex">The name of the rollover index</param>
		///<param name = "body">The conditions that needs to be met for executing rollover</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse RolloverForAll<TResponse>(string alias, string newIndex, PostData body, RolloverIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{alias:alias}/_rollover/{newIndex:newIndex}"), body, RequestParams(requestParameters));
		///<summary>POST on /{alias}/_rollover/{new_index} <para>https://opensearch.org/docs/latest/opensearch/data-streams/#step-5-rollover-a-data-stream</para></summary>
		///<param name = "alias">The name of the alias to rollover</param>
		///<param name = "newIndex">The name of the rollover index</param>
		///<param name = "body">The conditions that needs to be met for executing rollover</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.rollover", "alias, new_index, body")]
		public Task<TResponse> RolloverForAllAsync<TResponse>(string alias, string newIndex, PostData body, RolloverIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{alias:alias}/_rollover/{newIndex:newIndex}"), ctx, body, RequestParams(requestParameters));
		///<summary>GET on /_segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SegmentsForAll<TResponse>(SegmentsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_segments", null, RequestParams(requestParameters));
		///<summary>GET on /_segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.segments", "")]
		public Task<TResponse> SegmentsForAllAsync<TResponse>(SegmentsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_segments", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Segments<TResponse>(string index, SegmentsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_segments"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_segments <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-segments/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.segments", "index")]
		public Task<TResponse> SegmentsAsync<TResponse>(string index, SegmentsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_segments"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_shard_stores <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ShardStoresForAll<TResponse>(IndicesShardStoresRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_shard_stores", null, RequestParams(requestParameters));
		///<summary>GET on /_shard_stores <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.shard_stores", "")]
		public Task<TResponse> ShardStoresForAllAsync<TResponse>(IndicesShardStoresRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_shard_stores", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_shard_stores <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ShardStores<TResponse>(string index, IndicesShardStoresRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_shard_stores"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_shard_stores <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.shard_stores", "index")]
		public Task<TResponse> ShardStoresAsync<TResponse>(string index, IndicesShardStoresRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_shard_stores"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_shrink/{target} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/shrink-index/</para></summary>
		///<param name = "index">The name of the source index to shrink</param>
		///<param name = "target">The name of the target index to shrink into</param>
		///<param name = "body">The configuration for the target index (`settings` and `aliases`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Shrink<TResponse>(string index, string target, PostData body, ShrinkIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_shrink/{target:target}"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_shrink/{target} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/shrink-index/</para></summary>
		///<param name = "index">The name of the source index to shrink</param>
		///<param name = "target">The name of the target index to shrink into</param>
		///<param name = "body">The configuration for the target index (`settings` and `aliases`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.shrink", "index, target, body")]
		public Task<TResponse> ShrinkAsync<TResponse>(string index, string target, PostData body, ShrinkIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_shrink/{target:target}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_index_template/_simulate_index/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the index (it must be a concrete index name)</param>
		///<param name = "body">New index template definition, which will be included in the simulation, as if it already exists in the system</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulateIndexTemplateForAll<TResponse>(string name, PostData body, SimulateIndexTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"_index_template/_simulate_index/{name:name}"), body, RequestParams(requestParameters));
		///<summary>POST on /_index_template/_simulate_index/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the index (it must be a concrete index name)</param>
		///<param name = "body">New index template definition, which will be included in the simulation, as if it already exists in the system</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.simulate_index_template", "name, body")]
		public Task<TResponse> SimulateIndexTemplateForAllAsync<TResponse>(string name, PostData body, SimulateIndexTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_index_template/_simulate_index/{name:name}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_index_template/_simulate <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "body">New index template definition to be simulated, if no index template name is specified</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulateTemplateForAll<TResponse>(PostData body, SimulateTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_index_template/_simulate", body, RequestParams(requestParameters));
		///<summary>POST on /_index_template/_simulate <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "body">New index template definition to be simulated, if no index template name is specified</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.simulate_template", "body")]
		public Task<TResponse> SimulateTemplateForAllAsync<TResponse>(PostData body, SimulateTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_index_template/_simulate", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_index_template/_simulate/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the index template</param>
		///<param name = "body">New index template definition to be simulated, if no index template name is specified</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse SimulateTemplateForAll<TResponse>(string name, PostData body, SimulateTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"_index_template/_simulate/{name:name}"), body, RequestParams(requestParameters));
		///<summary>POST on /_index_template/_simulate/{name} <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-templates/</para></summary>
		///<param name = "name">The name of the index template</param>
		///<param name = "body">New index template definition to be simulated, if no index template name is specified</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.simulate_template", "name, body")]
		public Task<TResponse> SimulateTemplateForAllAsync<TResponse>(string name, PostData body, SimulateTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_index_template/_simulate/{name:name}"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_split/{target} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/split/</para></summary>
		///<param name = "index">The name of the source index to split</param>
		///<param name = "target">The name of the target index to split into</param>
		///<param name = "body">The configuration for the target index (`settings` and `aliases`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Split<TResponse>(string index, string target, PostData body, SplitIndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_split/{target:target}"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_split/{target} <para>https://opensearch.org/docs/latest/opensearch/rest-api/index-apis/split/</para></summary>
		///<param name = "index">The name of the source index to split</param>
		///<param name = "target">The name of the target index to split into</param>
		///<param name = "body">The configuration for the target index (`settings` and `aliases`)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.split", "index, target, body")]
		public Task<TResponse> SplitAsync<TResponse>(string index, string target, PostData body, SplitIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_split/{target:target}"), ctx, body, RequestParams(requestParameters));
		///<summary>GET on /_stats <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse StatsForAll<TResponse>(IndicesStatsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, "_stats", null, RequestParams(requestParameters));
		///<summary>GET on /_stats <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.stats", "")]
		public Task<TResponse> StatsForAllAsync<TResponse>(IndicesStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, "_stats", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_stats/{metric} <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "metric">Limit the information returned the specific metrics.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse StatsForAll<TResponse>(string metric, IndicesStatsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"_stats/{metric:metric}"), null, RequestParams(requestParameters));
		///<summary>GET on /_stats/{metric} <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "metric">Limit the information returned the specific metrics.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.stats", "metric")]
		public Task<TResponse> StatsForAllAsync<TResponse>(string metric, IndicesStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_stats/{metric:metric}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_stats <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Stats<TResponse>(string index, IndicesStatsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_stats"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_stats <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.stats", "index")]
		public Task<TResponse> StatsAsync<TResponse>(string index, IndicesStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_stats"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_stats/{metric} <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "metric">Limit the information returned the specific metrics.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Stats<TResponse>(string index, string metric, IndicesStatsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_stats/{metric:metric}"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_stats/{metric} <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "metric">Limit the information returned the specific metrics.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.stats", "index, metric")]
		public Task<TResponse> StatsAsync<TResponse>(string index, string metric, IndicesStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_stats/{metric:metric}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_aliases <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "body">The definition of `actions` to perform</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse BulkAliasForAll<TResponse>(PostData body, BulkAliasRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_aliases", body, RequestParams(requestParameters));
		///<summary>POST on /_aliases <para>https://opensearch.org/docs/latest/opensearch/rest-api/alias/</para></summary>
		///<param name = "body">The definition of `actions` to perform</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.update_aliases", "body")]
		public Task<TResponse> BulkAliasForAllAsync<TResponse>(PostData body, BulkAliasRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_aliases", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_validate/query <para></para></summary>
		///<param name = "body">The query definition specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ValidateQueryForAll<TResponse>(PostData body, ValidateQueryRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, "_validate/query", body, RequestParams(requestParameters));
		///<summary>POST on /_validate/query <para></para></summary>
		///<param name = "body">The query definition specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.validate_query", "body")]
		public Task<TResponse> ValidateQueryForAllAsync<TResponse>(PostData body, ValidateQueryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, "_validate/query", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_validate/query <para></para></summary>
		///<param name = "index">A comma-separated list of index names to restrict the operation; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The query definition specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ValidateQuery<TResponse>(string index, PostData body, ValidateQueryRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_validate/query"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_validate/query <para></para></summary>
		///<param name = "index">A comma-separated list of index names to restrict the operation; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The query definition specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("indices.validate_query", "index, body")]
		public Task<TResponse> ValidateQueryAsync<TResponse>(string index, PostData body, ValidateQueryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_validate/query"), ctx, body, RequestParams(requestParameters));
	}
}
