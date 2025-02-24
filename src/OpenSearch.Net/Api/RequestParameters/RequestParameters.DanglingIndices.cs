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

// ReSharper disable once CheckNamespace
namespace OpenSearch.Net.Specification.DanglingIndicesApi
{
	///<summary>Request options for DeleteDanglingIndex <para></para></summary>
	public class DeleteDanglingIndexRequestParameters : RequestParameters<DeleteDanglingIndexRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>Must be set to true in order to delete the dangling index</summary>
		public bool? AcceptDataLoss
		{
			get => Q<bool? >("accept_data_loss");
			set => Q("accept_data_loss", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeSpanout"/> instead</remarks>
		public TimeSpan MasterTimeSpanout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeSpanout"/></remarks>
		public TimeSpan ClusterManagerTimeSpanout
		{
			get => Q<TimeSpan>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for ImportDanglingIndex <para></para></summary>
	public class ImportDanglingIndexRequestParameters : RequestParameters<ImportDanglingIndexRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
		///<summary>Must be set to true in order to import the dangling index</summary>
		public bool? AcceptDataLoss
		{
			get => Q<bool? >("accept_data_loss");
			set => Q("accept_data_loss", value);
		}

		///<summary>Specify timeout for connection to master node</summary>
		///<remarks>Deprecated as of OpenSearch 2.0, use <see cref="ClusterManagerTimeSpanout"/> instead</remarks>
		public TimeSpan MasterTimeSpanout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Specify timeout for connection to cluster_manager node</summary>
		///<remarks>Introduced in OpenSearch 2.0 instead of <see cref="MasterTimeSpanout"/></remarks>
		public TimeSpan ClusterManagerTimeSpanout
		{
			get => Q<TimeSpan>("cluster_manager_timeout");
			set => Q("cluster_manager_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for List <para></para></summary>
	public class ListDanglingIndicesRequestParameters : RequestParameters<ListDanglingIndicesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}
}
