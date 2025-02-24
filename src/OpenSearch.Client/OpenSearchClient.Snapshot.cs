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
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net.Specification.SnapshotApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace OpenSearch.Client.Specification.SnapshotApi
{
	///<summary>
	/// Snapshot APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IOpenSearchClient.Snapshot"/> property
	/// on <see cref = "IOpenSearchClient"/>.
	///</para>
	///</summary>
	public class SnapshotNamespace : NamespacedClientProxy
	{
		internal SnapshotNamespace(OpenSearchClient client): base(client)
		{
		}

		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.cleanup_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public CleanupRepositoryResponse CleanupRepository(Name repository, Func<CleanupRepositoryDescriptor, ICleanupRepositoryRequest> selector = null) => CleanupRepository(selector.InvokeOrDefault(new CleanupRepositoryDescriptor(repository: repository)));
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.cleanup_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<CleanupRepositoryResponse> CleanupRepositoryAsync(Name repository, Func<CleanupRepositoryDescriptor, ICleanupRepositoryRequest> selector = null, CancellationToken ct = default) => CleanupRepositoryAsync(selector.InvokeOrDefault(new CleanupRepositoryDescriptor(repository: repository)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.cleanup_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public CleanupRepositoryResponse CleanupRepository(ICleanupRepositoryRequest request) => DoRequest<ICleanupRepositoryRequest, CleanupRepositoryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.cleanup_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = ""></a>
		/// </summary>
		public Task<CleanupRepositoryResponse> CleanupRepositoryAsync(ICleanupRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<ICleanupRepositoryRequest, CleanupRepositoryResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.clone</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public CloneSnapshotResponse Clone(Name repository, Name snapshot, Name targetSnapshot, Func<CloneSnapshotDescriptor, ICloneSnapshotRequest> selector) => Clone(selector.InvokeOrDefault(new CloneSnapshotDescriptor(repository: repository, snapshot: snapshot, targetSnapshot: targetSnapshot)));
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.clone</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<CloneSnapshotResponse> CloneAsync(Name repository, Name snapshot, Name targetSnapshot, Func<CloneSnapshotDescriptor, ICloneSnapshotRequest> selector, CancellationToken ct = default) => CloneAsync(selector.InvokeOrDefault(new CloneSnapshotDescriptor(repository: repository, snapshot: snapshot, targetSnapshot: targetSnapshot)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.clone</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public CloneSnapshotResponse Clone(ICloneSnapshotRequest request) => DoRequest<ICloneSnapshotRequest, CloneSnapshotResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.clone</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<CloneSnapshotResponse> CloneAsync(ICloneSnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<ICloneSnapshotRequest, CloneSnapshotResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public SnapshotResponse Snapshot(Name repository, Name snapshot, Func<SnapshotDescriptor, ISnapshotRequest> selector = null) => Snapshot(selector.InvokeOrDefault(new SnapshotDescriptor(repository: repository, snapshot: snapshot)));
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<SnapshotResponse> SnapshotAsync(Name repository, Name snapshot, Func<SnapshotDescriptor, ISnapshotRequest> selector = null, CancellationToken ct = default) => SnapshotAsync(selector.InvokeOrDefault(new SnapshotDescriptor(repository: repository, snapshot: snapshot)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public SnapshotResponse Snapshot(ISnapshotRequest request) => DoRequest<ISnapshotRequest, SnapshotResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<SnapshotResponse> SnapshotAsync(ISnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<ISnapshotRequest, SnapshotResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public CreateRepositoryResponse CreateRepository(Name repository, Func<CreateRepositoryDescriptor, ICreateRepositoryRequest> selector) => CreateRepository(selector.InvokeOrDefault(new CreateRepositoryDescriptor(repository: repository)));
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<CreateRepositoryResponse> CreateRepositoryAsync(Name repository, Func<CreateRepositoryDescriptor, ICreateRepositoryRequest> selector, CancellationToken ct = default) => CreateRepositoryAsync(selector.InvokeOrDefault(new CreateRepositoryDescriptor(repository: repository)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public CreateRepositoryResponse CreateRepository(ICreateRepositoryRequest request) => DoRequest<ICreateRepositoryRequest, CreateRepositoryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>snapshot.create_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<CreateRepositoryResponse> CreateRepositoryAsync(ICreateRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<ICreateRepositoryRequest, CreateRepositoryResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public DeleteSnapshotResponse Delete(Name repository, Name snapshot, Func<DeleteSnapshotDescriptor, IDeleteSnapshotRequest> selector = null) => Delete(selector.InvokeOrDefault(new DeleteSnapshotDescriptor(repository: repository, snapshot: snapshot)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<DeleteSnapshotResponse> DeleteAsync(Name repository, Name snapshot, Func<DeleteSnapshotDescriptor, IDeleteSnapshotRequest> selector = null, CancellationToken ct = default) => DeleteAsync(selector.InvokeOrDefault(new DeleteSnapshotDescriptor(repository: repository, snapshot: snapshot)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public DeleteSnapshotResponse Delete(IDeleteSnapshotRequest request) => DoRequest<IDeleteSnapshotRequest, DeleteSnapshotResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<DeleteSnapshotResponse> DeleteAsync(IDeleteSnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteSnapshotRequest, DeleteSnapshotResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public DeleteRepositoryResponse DeleteRepository(Names repository, Func<DeleteRepositoryDescriptor, IDeleteRepositoryRequest> selector = null) => DeleteRepository(selector.InvokeOrDefault(new DeleteRepositoryDescriptor(repository: repository)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(Names repository, Func<DeleteRepositoryDescriptor, IDeleteRepositoryRequest> selector = null, CancellationToken ct = default) => DeleteRepositoryAsync(selector.InvokeOrDefault(new DeleteRepositoryDescriptor(repository: repository)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public DeleteRepositoryResponse DeleteRepository(IDeleteRepositoryRequest request) => DoRequest<IDeleteRepositoryRequest, DeleteRepositoryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>snapshot.delete_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(IDeleteRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteRepositoryRequest, DeleteRepositoryResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public GetSnapshotResponse Get(Name repository, Names snapshot, Func<GetSnapshotDescriptor, IGetSnapshotRequest> selector = null) => Get(selector.InvokeOrDefault(new GetSnapshotDescriptor(repository: repository, snapshot: snapshot)));
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<GetSnapshotResponse> GetAsync(Name repository, Names snapshot, Func<GetSnapshotDescriptor, IGetSnapshotRequest> selector = null, CancellationToken ct = default) => GetAsync(selector.InvokeOrDefault(new GetSnapshotDescriptor(repository: repository, snapshot: snapshot)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public GetSnapshotResponse Get(IGetSnapshotRequest request) => DoRequest<IGetSnapshotRequest, GetSnapshotResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<GetSnapshotResponse> GetAsync(IGetSnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<IGetSnapshotRequest, GetSnapshotResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public GetRepositoryResponse GetRepository(Func<GetRepositoryDescriptor, IGetRepositoryRequest> selector = null) => GetRepository(selector.InvokeOrDefault(new GetRepositoryDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<GetRepositoryResponse> GetRepositoryAsync(Func<GetRepositoryDescriptor, IGetRepositoryRequest> selector = null, CancellationToken ct = default) => GetRepositoryAsync(selector.InvokeOrDefault(new GetRepositoryDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public GetRepositoryResponse GetRepository(IGetRepositoryRequest request) => DoRequest<IGetRepositoryRequest, GetRepositoryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.get_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<GetRepositoryResponse> GetRepositoryAsync(IGetRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<IGetRepositoryRequest, GetRepositoryResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.restore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public RestoreResponse Restore(Name repository, Name snapshot, Func<RestoreDescriptor, IRestoreRequest> selector = null) => Restore(selector.InvokeOrDefault(new RestoreDescriptor(repository: repository, snapshot: snapshot)));
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.restore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<RestoreResponse> RestoreAsync(Name repository, Name snapshot, Func<RestoreDescriptor, IRestoreRequest> selector = null, CancellationToken ct = default) => RestoreAsync(selector.InvokeOrDefault(new RestoreDescriptor(repository: repository, snapshot: snapshot)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.restore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public RestoreResponse Restore(IRestoreRequest request) => DoRequest<IRestoreRequest, RestoreResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.restore</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<RestoreResponse> RestoreAsync(IRestoreRequest request, CancellationToken ct = default) => DoRequestAsync<IRestoreRequest, RestoreResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public SnapshotStatusResponse Status(Func<SnapshotStatusDescriptor, ISnapshotStatusRequest> selector = null) => Status(selector.InvokeOrDefault(new SnapshotStatusDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<SnapshotStatusResponse> StatusAsync(Func<SnapshotStatusDescriptor, ISnapshotStatusRequest> selector = null, CancellationToken ct = default) => StatusAsync(selector.InvokeOrDefault(new SnapshotStatusDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public SnapshotStatusResponse Status(ISnapshotStatusRequest request) => DoRequest<ISnapshotStatusRequest, SnapshotStatusResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>snapshot.status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<SnapshotStatusResponse> StatusAsync(ISnapshotStatusRequest request, CancellationToken ct = default) => DoRequestAsync<ISnapshotStatusRequest, SnapshotStatusResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.verify_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public VerifyRepositoryResponse VerifyRepository(Name repository, Func<VerifyRepositoryDescriptor, IVerifyRepositoryRequest> selector = null) => VerifyRepository(selector.InvokeOrDefault(new VerifyRepositoryDescriptor(repository: repository)));
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.verify_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<VerifyRepositoryResponse> VerifyRepositoryAsync(Name repository, Func<VerifyRepositoryDescriptor, IVerifyRepositoryRequest> selector = null, CancellationToken ct = default) => VerifyRepositoryAsync(selector.InvokeOrDefault(new VerifyRepositoryDescriptor(repository: repository)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.verify_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public VerifyRepositoryResponse VerifyRepository(IVerifyRepositoryRequest request) => DoRequest<IVerifyRepositoryRequest, VerifyRepositoryResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>snapshot.verify_repository</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/">https://opensearch.org/docs/latest/opensearch/rest-api/cat/cat-snapshots/</a>
		/// </summary>
		public Task<VerifyRepositoryResponse> VerifyRepositoryAsync(IVerifyRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<IVerifyRepositoryRequest, VerifyRepositoryResponse>(request, request.RequestParameters, ct);
	}
}
