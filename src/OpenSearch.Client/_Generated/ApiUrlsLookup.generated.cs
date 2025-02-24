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

namespace OpenSearch.Client
{
	internal static class ApiUrlsLookups
	{
		internal static ApiUrls NoNamespaceBulk = new ApiUrls(new[]{"_bulk", "{index}/_bulk"});
		internal static ApiUrls CatAliases = new ApiUrls(new[]{"_cat/aliases", "_cat/aliases/{name}"});
		internal static ApiUrls CatAllocation = new ApiUrls(new[]{"_cat/allocation", "_cat/allocation/{node_id}"});
		internal static ApiUrls CatCount = new ApiUrls(new[]{"_cat/count", "_cat/count/{index}"});
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="CatMaster"/></remarks>
		internal static ApiUrls CatClusterManager = new ApiUrls(new[]{"_cat/cluster_manager"});
		internal static ApiUrls CatFielddata = new ApiUrls(new[]{"_cat/fielddata", "_cat/fielddata/{fields}"});
		internal static ApiUrls CatHealth = new ApiUrls(new[]{"_cat/health"});
		internal static ApiUrls CatHelp = new ApiUrls(new[]{"_cat"});
		internal static ApiUrls CatIndices = new ApiUrls(new[]{"_cat/indices", "_cat/indices/{index}"});
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="CatClusterManager"/> instead</remarks>
		internal static ApiUrls CatMaster = new ApiUrls(new[]{"_cat/master"});
		internal static ApiUrls CatNodeAttributes = new ApiUrls(new[]{"_cat/nodeattrs"});
		internal static ApiUrls CatNodes = new ApiUrls(new[]{"_cat/nodes"});
		internal static ApiUrls CatPendingTasks = new ApiUrls(new[]{"_cat/pending_tasks"});
		internal static ApiUrls CatPlugins = new ApiUrls(new[]{"_cat/plugins"});
		internal static ApiUrls CatRecovery = new ApiUrls(new[]{"_cat/recovery", "_cat/recovery/{index}"});
		internal static ApiUrls CatRepositories = new ApiUrls(new[]{"_cat/repositories"});
		internal static ApiUrls CatSegments = new ApiUrls(new[]{"_cat/segments", "_cat/segments/{index}"});
		internal static ApiUrls CatShards = new ApiUrls(new[]{"_cat/shards", "_cat/shards/{index}"});
		internal static ApiUrls CatSnapshots = new ApiUrls(new[]{"_cat/snapshots", "_cat/snapshots/{repository}"});
		internal static ApiUrls CatTasks = new ApiUrls(new[]{"_cat/tasks"});
		internal static ApiUrls CatTemplates = new ApiUrls(new[]{"_cat/templates", "_cat/templates/{name}"});
		internal static ApiUrls CatThreadPool = new ApiUrls(new[]{"_cat/thread_pool", "_cat/thread_pool/{thread_pool_patterns}"});
		internal static ApiUrls NoNamespaceClearScroll = new ApiUrls(new[]{"_search/scroll"});
		internal static ApiUrls ClusterAllocationExplain = new ApiUrls(new[]{"_cluster/allocation/explain"});
		internal static ApiUrls ClusterDeleteVotingConfigExclusions = new ApiUrls(new[]{"_cluster/voting_config_exclusions"});
		internal static ApiUrls ClusterGetSettings = new ApiUrls(new[]{"_cluster/settings"});
		internal static ApiUrls ClusterHealth = new ApiUrls(new[]{"_cluster/health", "_cluster/health/{index}"});
		internal static ApiUrls ClusterPendingTasks = new ApiUrls(new[]{"_cluster/pending_tasks"});
		internal static ApiUrls ClusterPostVotingConfigExclusions = new ApiUrls(new[]{"_cluster/voting_config_exclusions"});
		internal static ApiUrls ClusterPutSettings = new ApiUrls(new[]{"_cluster/settings"});
		internal static ApiUrls ClusterRemoteInfo = new ApiUrls(new[]{"_remote/info"});
		internal static ApiUrls ClusterReroute = new ApiUrls(new[]{"_cluster/reroute"});
		internal static ApiUrls ClusterState = new ApiUrls(new[]{"_cluster/state", "_cluster/state/{metric}", "_cluster/state/{metric}/{index}"});
		internal static ApiUrls ClusterStats = new ApiUrls(new[]{"_cluster/stats", "_cluster/stats/nodes/{node_id}"});
		internal static ApiUrls NoNamespaceCount = new ApiUrls(new[]{"_count", "{index}/_count"});
		internal static ApiUrls NoNamespaceCreate = new ApiUrls(new[]{"{index}/_create/{id}"});
		internal static ApiUrls DanglingIndicesDeleteDanglingIndex = new ApiUrls(new[]{"_dangling/{index_uuid}"});
		internal static ApiUrls DanglingIndicesImportDanglingIndex = new ApiUrls(new[]{"_dangling/{index_uuid}"});
		internal static ApiUrls DanglingIndicesList = new ApiUrls(new[]{"_dangling"});
		internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[]{"{index}/_doc/{id}"});
		internal static ApiUrls NoNamespaceDeleteByQuery = new ApiUrls(new[]{"{index}/_delete_by_query"});
		internal static ApiUrls NoNamespaceDeleteByQueryRethrottle = new ApiUrls(new[]{"_delete_by_query/{task_id}/_rethrottle"});
		internal static ApiUrls NoNamespaceDeleteScript = new ApiUrls(new[]{"_scripts/{id}"});
		internal static ApiUrls NoNamespaceDocumentExists = new ApiUrls(new[]{"{index}/_doc/{id}"});
		internal static ApiUrls NoNamespaceSourceExists = new ApiUrls(new[]{"{index}/_source/{id}"});
		internal static ApiUrls NoNamespaceExplain = new ApiUrls(new[]{"{index}/_explain/{id}"});
		internal static ApiUrls NoNamespaceFieldCapabilities = new ApiUrls(new[]{"_field_caps", "{index}/_field_caps"});
		internal static ApiUrls NoNamespaceGet = new ApiUrls(new[]{"{index}/_doc/{id}"});
		internal static ApiUrls NoNamespaceGetScript = new ApiUrls(new[]{"_scripts/{id}"});
		internal static ApiUrls NoNamespaceSource = new ApiUrls(new[]{"{index}/_source/{id}"});
		internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[]{"{index}/_doc/{id}", "{index}/_doc"});
		internal static ApiUrls IndicesAddBlock = new ApiUrls(new[]{"{index}/_block/{block}"});
		internal static ApiUrls IndicesAnalyze = new ApiUrls(new[]{"_analyze", "{index}/_analyze"});
		internal static ApiUrls IndicesClearCache = new ApiUrls(new[]{"_cache/clear", "{index}/_cache/clear"});
		internal static ApiUrls IndicesClone = new ApiUrls(new[]{"{index}/_clone/{target}"});
		internal static ApiUrls IndicesClose = new ApiUrls(new[]{"{index}/_close"});
		internal static ApiUrls IndicesCreate = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesDelete = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesDeleteAlias = new ApiUrls(new[]{"{index}/_alias/{name}"});
		internal static ApiUrls IndicesDeleteTemplate = new ApiUrls(new[]{"_template/{name}"});
		internal static ApiUrls IndicesExists = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesAliasExists = new ApiUrls(new[]{"_alias/{name}", "{index}/_alias/{name}"});
		internal static ApiUrls IndicesTemplateExists = new ApiUrls(new[]{"_template/{name}"});
		///<remarks>Deprecated as of OpenSearch 2.0</remarks>
		internal static ApiUrls IndicesTypeExists = new ApiUrls(new[]{"{index}/_mapping/{type}"});
		internal static ApiUrls IndicesFlush = new ApiUrls(new[]{"_flush", "{index}/_flush"});
		internal static ApiUrls IndicesForceMerge = new ApiUrls(new[]{"_forcemerge", "{index}/_forcemerge"});
		internal static ApiUrls IndicesGet = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesGetAlias = new ApiUrls(new[]{"_alias", "_alias/{name}", "{index}/_alias/{name}", "{index}/_alias"});
		internal static ApiUrls IndicesGetFieldMapping = new ApiUrls(new[]{"_mapping/field/{fields}", "{index}/_mapping/field/{fields}"});
		internal static ApiUrls IndicesGetMapping = new ApiUrls(new[]{"_mapping", "{index}/_mapping"});
		internal static ApiUrls IndicesGetSettings = new ApiUrls(new[]{"_settings", "{index}/_settings", "{index}/_settings/{name}", "_settings/{name}"});
		internal static ApiUrls IndicesGetTemplate = new ApiUrls(new[]{"_template", "_template/{name}"});
		internal static ApiUrls IndicesOpen = new ApiUrls(new[]{"{index}/_open"});
		internal static ApiUrls IndicesPutAlias = new ApiUrls(new[]{"{index}/_alias/{name}"});
		internal static ApiUrls IndicesPutMapping = new ApiUrls(new[]{"{index}/_mapping"});
		internal static ApiUrls IndicesUpdateSettings = new ApiUrls(new[]{"_settings", "{index}/_settings"});
		internal static ApiUrls IndicesPutTemplate = new ApiUrls(new[]{"_template/{name}"});
		internal static ApiUrls IndicesRecoveryStatus = new ApiUrls(new[]{"_recovery", "{index}/_recovery"});
		internal static ApiUrls IndicesRefresh = new ApiUrls(new[]{"_refresh", "{index}/_refresh"});
		internal static ApiUrls IndicesResolve = new ApiUrls(new[]{"_resolve/index/{name}"});
		internal static ApiUrls IndicesRollover = new ApiUrls(new[]{"{alias}/_rollover", "{alias}/_rollover/{new_index}"});
		internal static ApiUrls IndicesSegments = new ApiUrls(new[]{"_segments", "{index}/_segments"});
		internal static ApiUrls IndicesShardStores = new ApiUrls(new[]{"_shard_stores", "{index}/_shard_stores"});
		internal static ApiUrls IndicesShrink = new ApiUrls(new[]{"{index}/_shrink/{target}"});
		internal static ApiUrls IndicesSplit = new ApiUrls(new[]{"{index}/_split/{target}"});
		internal static ApiUrls IndicesStats = new ApiUrls(new[]{"_stats", "_stats/{metric}", "{index}/_stats", "{index}/_stats/{metric}"});
		internal static ApiUrls IndicesBulkAlias = new ApiUrls(new[]{"_aliases"});
		internal static ApiUrls IndicesValidateQuery = new ApiUrls(new[]{"_validate/query", "{index}/_validate/query"});
		internal static ApiUrls NoNamespaceRootNodeInfo = new ApiUrls(new[]{""});
		internal static ApiUrls IngestDeletePipeline = new ApiUrls(new[]{"_ingest/pipeline/{id}"});
		internal static ApiUrls IngestGetPipeline = new ApiUrls(new[]{"_ingest/pipeline", "_ingest/pipeline/{id}"});
		internal static ApiUrls IngestGrokProcessorPatterns = new ApiUrls(new[]{"_ingest/processor/grok"});
		internal static ApiUrls IngestPutPipeline = new ApiUrls(new[]{"_ingest/pipeline/{id}"});
		internal static ApiUrls IngestSimulatePipeline = new ApiUrls(new[]{"_ingest/pipeline/_simulate", "_ingest/pipeline/{id}/_simulate"});
		internal static ApiUrls NoNamespaceMultiGet = new ApiUrls(new[]{"_mget", "{index}/_mget"});
		internal static ApiUrls NoNamespaceMultiSearch = new ApiUrls(new[]{"_msearch", "{index}/_msearch"});
		internal static ApiUrls NoNamespaceMultiSearchTemplate = new ApiUrls(new[]{"_msearch/template", "{index}/_msearch/template"});
		internal static ApiUrls NoNamespaceMultiTermVectors = new ApiUrls(new[]{"_mtermvectors", "{index}/_mtermvectors"});
		internal static ApiUrls NodesHotThreads = new ApiUrls(new[]{"_nodes/hot_threads", "_nodes/{node_id}/hot_threads"});
		internal static ApiUrls NodesInfo = new ApiUrls(new[]{"_nodes", "_nodes/{node_id}", "_nodes/{metric}", "_nodes/{node_id}/{metric}"});
		internal static ApiUrls NodesReloadSecureSettings = new ApiUrls(new[]{"_nodes/reload_secure_settings", "_nodes/{node_id}/reload_secure_settings"});
		internal static ApiUrls NodesStats = new ApiUrls(new[]{"_nodes/stats", "_nodes/{node_id}/stats", "_nodes/stats/{metric}", "_nodes/{node_id}/stats/{metric}", "_nodes/stats/{metric}/{index_metric}", "_nodes/{node_id}/stats/{metric}/{index_metric}"});
		internal static ApiUrls NodesUsage = new ApiUrls(new[]{"_nodes/usage", "_nodes/{node_id}/usage", "_nodes/usage/{metric}", "_nodes/{node_id}/usage/{metric}"});
		internal static ApiUrls NoNamespacePing = new ApiUrls(new[]{""});
		internal static ApiUrls NoNamespacePutScript = new ApiUrls(new[]{"_scripts/{id}", "_scripts/{id}/{context}"});
		internal static ApiUrls NoNamespaceReindexOnServer = new ApiUrls(new[]{"_reindex"});
		internal static ApiUrls NoNamespaceReindexRethrottle = new ApiUrls(new[]{"_reindex/{task_id}/_rethrottle"});
		internal static ApiUrls NoNamespaceRenderSearchTemplate = new ApiUrls(new[]{"_render/template", "_render/template/{id}"});
		internal static ApiUrls NoNamespaceExecutePainlessScript = new ApiUrls(new[]{"_scripts/painless/_execute"});
		internal static ApiUrls NoNamespaceScroll = new ApiUrls(new[]{"_search/scroll"});
		internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[]{"_search", "{index}/_search"});
		internal static ApiUrls NoNamespaceSearchShards = new ApiUrls(new[]{"_search_shards", "{index}/_search_shards"});
		internal static ApiUrls NoNamespaceSearchTemplate = new ApiUrls(new[]{"_search/template", "{index}/_search/template"});
		internal static ApiUrls SnapshotCleanupRepository = new ApiUrls(new[]{"_snapshot/{repository}/_cleanup"});
		internal static ApiUrls SnapshotClone = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}"});
		internal static ApiUrls SnapshotSnapshot = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}"});
		internal static ApiUrls SnapshotCreateRepository = new ApiUrls(new[]{"_snapshot/{repository}"});
		internal static ApiUrls SnapshotDelete = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}"});
		internal static ApiUrls SnapshotDeleteRepository = new ApiUrls(new[]{"_snapshot/{repository}"});
		internal static ApiUrls SnapshotGet = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}"});
		internal static ApiUrls SnapshotGetRepository = new ApiUrls(new[]{"_snapshot", "_snapshot/{repository}"});
		internal static ApiUrls SnapshotRestore = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}/_restore"});
		internal static ApiUrls SnapshotStatus = new ApiUrls(new[]{"_snapshot/_status", "_snapshot/{repository}/_status", "_snapshot/{repository}/{snapshot}/_status"});
		internal static ApiUrls SnapshotVerifyRepository = new ApiUrls(new[]{"_snapshot/{repository}/_verify"});
		internal static ApiUrls TasksCancel = new ApiUrls(new[]{"_tasks/_cancel", "_tasks/{task_id}/_cancel"});
		internal static ApiUrls TasksGetTask = new ApiUrls(new[]{"_tasks/{task_id}"});
		internal static ApiUrls TasksList = new ApiUrls(new[]{"_tasks"});
		internal static ApiUrls NoNamespaceTermVectors = new ApiUrls(new[]{"{index}/_termvectors/{id}", "{index}/_termvectors"});
		internal static ApiUrls NoNamespaceUpdate = new ApiUrls(new[]{"{index}/_update/{id}"});
		internal static ApiUrls NoNamespaceUpdateByQuery = new ApiUrls(new[]{"{index}/_update_by_query"});
		internal static ApiUrls NoNamespaceUpdateByQueryRethrottle = new ApiUrls(new[]{"_update_by_query/{task_id}/_rethrottle"});
	}
}
