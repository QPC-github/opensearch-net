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
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using OpenSearch.Net;
using OpenSearch.Net.Utf8Json;
using OpenSearch.Net.Specification.NodesApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public partial interface INodesHotThreadsRequest : IRequest<NodesHotThreadsRequestParameters>
	{
		[IgnoreDataMember]
		NodeIds NodeId
		{
			get;
		}
	}

	///<summary>Request for HotThreads <para></para></summary>
	public partial class NodesHotThreadsRequest : PlainRequestBase<NodesHotThreadsRequestParameters>, INodesHotThreadsRequest
	{
		protected INodesHotThreadsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesHotThreads;
		///<summary>/_nodes/hot_threads</summary>
		public NodesHotThreadsRequest(): base()
		{
		}

		///<summary>/_nodes/{node_id}/hot_threads</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesHotThreadsRequest(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		NodeIds INodesHotThreadsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		// Request parameters
		///<summary>Don't show threads that are in known-idle places, such as waiting on a socket select or pulling from an empty task queue (default: true)</summary>
		public bool? IgnoreIdleThreads
		{
			get => Q<bool? >("ignore_idle_threads");
			set => Q("ignore_idle_threads", value);
		}

		///<summary>The interval for the second sampling of threads</summary>
		public Time Interval
		{
			get => Q<Time>("interval");
			set => Q("interval", value);
		}

		///<summary>Number of samples of thread stacktrace (default: 10)</summary>
		public long? Snapshots
		{
			get => Q<long? >("snapshots");
			set => Q("snapshots", value);
		}

		///<summary>The type to sample (default: cpu)</summary>
		public ThreadType? ThreadType
		{
			get => Q<ThreadType? >("type");
			set => Q("type", value);
		}

		///<summary>Specify the number of threads to provide information for (default: 3)</summary>
		public long? Threads
		{
			get => Q<long? >("threads");
			set => Q("threads", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface INodesInfoRequest : IRequest<NodesInfoRequestParameters>
	{
		[IgnoreDataMember]
		NodeIds NodeId
		{
			get;
		}

		[IgnoreDataMember]
		Metrics Metric
		{
			get;
		}
	}

	///<summary>Request for Info <para>https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-nodes/</para></summary>
	public partial class NodesInfoRequest : PlainRequestBase<NodesInfoRequestParameters>, INodesInfoRequest
	{
		protected INodesInfoRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
		///<summary>/_nodes</summary>
		public NodesInfoRequest(): base()
		{
		}

		///<summary>/_nodes/{node_id}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesInfoRequest(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public NodesInfoRequest(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/{metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		public NodesInfoRequest(NodeIds nodeId, Metrics metric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		NodeIds INodesInfoRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		[IgnoreDataMember]
		Metrics INodesInfoRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		// Request parameters
		///<summary>Return settings in flat format (default: false)</summary>
		public bool? FlatSettings
		{
			get => Q<bool? >("flat_settings");
			set => Q("flat_settings", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IReloadSecureSettingsRequest : IRequest<ReloadSecureSettingsRequestParameters>
	{
		[IgnoreDataMember]
		NodeIds NodeId
		{
			get;
		}
	}

	///<summary>Request for ReloadSecureSettings <para></para></summary>
	public partial class ReloadSecureSettingsRequest : PlainRequestBase<ReloadSecureSettingsRequestParameters>, IReloadSecureSettingsRequest
	{
		protected IReloadSecureSettingsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
		///<summary>/_nodes/reload_secure_settings</summary>
		public ReloadSecureSettingsRequest(): base()
		{
		}

		///<summary>/_nodes/{node_id}/reload_secure_settings</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public ReloadSecureSettingsRequest(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		NodeIds IReloadSecureSettingsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface INodesStatsRequest : IRequest<NodesStatsRequestParameters>
	{
		[IgnoreDataMember]
		NodeIds NodeId
		{
			get;
		}

		[IgnoreDataMember]
		Metrics Metric
		{
			get;
		}

		[IgnoreDataMember]
		IndexMetrics IndexMetric
		{
			get;
		}
	}

	///<summary>Request for Stats <para>https://opensearch.org/docs/latest/opensearch/stats-api/</para></summary>
	public partial class NodesStatsRequest : PlainRequestBase<NodesStatsRequestParameters>, INodesStatsRequest
	{
		protected INodesStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesStats;
		///<summary>/_nodes/stats</summary>
		public NodesStatsRequest(): base()
		{
		}

		///<summary>/_nodes/{node_id}/stats</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesStatsRequest(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/stats/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public NodesStatsRequest(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/stats/{metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		public NodesStatsRequest(NodeIds nodeId, Metrics metric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		///<summary>/_nodes/stats/{metric}/{index_metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		///<param name = "indexMetric">Optional, accepts null</param>
		public NodesStatsRequest(Metrics metric, IndexMetrics indexMetric): base(r => r.Optional("metric", metric).Optional("index_metric", indexMetric))
		{
		}

		///<summary>/_nodes/{node_id}/stats/{metric}/{index_metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		///<param name = "indexMetric">Optional, accepts null</param>
		public NodesStatsRequest(NodeIds nodeId, Metrics metric, IndexMetrics indexMetric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric).Optional("index_metric", indexMetric))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		NodeIds INodesStatsRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		[IgnoreDataMember]
		Metrics INodesStatsRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		[IgnoreDataMember]
		IndexMetrics INodesStatsRequest.IndexMetric => Self.RouteValues.Get<IndexMetrics>("index_metric");
		// Request parameters
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		public Fields CompletionFields
		{
			get => Q<Fields>("completion_fields");
			set => Q("completion_fields", value);
		}

		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		public Fields FielddataFields
		{
			get => Q<Fields>("fielddata_fields");
			set => Q("fielddata_fields", value);
		}

		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		public Fields Fields
		{
			get => Q<Fields>("fields");
			set => Q("fields", value);
		}

		///<summary>A comma-separated list of search groups for `search` index metric</summary>
		public bool? Groups
		{
			get => Q<bool? >("groups");
			set => Q("groups", value);
		}

		///<summary>Whether to report the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested)</summary>
		public bool? IncludeSegmentFileSizes
		{
			get => Q<bool? >("include_segment_file_sizes");
			set => Q("include_segment_file_sizes", value);
		}

		///<summary>Return indices stats aggregated at index, node or shard level</summary>
		public Level? Level
		{
			get => Q<Level? >("level");
			set => Q("level", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>A comma-separated list of document types for the `indexing` index metric</summary>
		public string[] Types
		{
			get => Q<string[]>("types");
			set => Q("types", value);
		}
	}

	[InterfaceDataContract]
	public partial interface INodesUsageRequest : IRequest<NodesUsageRequestParameters>
	{
		[IgnoreDataMember]
		NodeIds NodeId
		{
			get;
		}

		[IgnoreDataMember]
		Metrics Metric
		{
			get;
		}
	}

	///<summary>Request for Usage <para></para></summary>
	public partial class NodesUsageRequest : PlainRequestBase<NodesUsageRequestParameters>, INodesUsageRequest
	{
		protected INodesUsageRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
		///<summary>/_nodes/usage</summary>
		public NodesUsageRequest(): base()
		{
		}

		///<summary>/_nodes/{node_id}/usage</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		public NodesUsageRequest(NodeIds nodeId): base(r => r.Optional("node_id", nodeId))
		{
		}

		///<summary>/_nodes/usage/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public NodesUsageRequest(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_nodes/{node_id}/usage/{metric}</summary>
		///<param name = "nodeId">Optional, accepts null</param>
		///<param name = "metric">Optional, accepts null</param>
		public NodesUsageRequest(NodeIds nodeId, Metrics metric): base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		NodeIds INodesUsageRequest.NodeId => Self.RouteValues.Get<NodeIds>("node_id");
		[IgnoreDataMember]
		Metrics INodesUsageRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}
}
