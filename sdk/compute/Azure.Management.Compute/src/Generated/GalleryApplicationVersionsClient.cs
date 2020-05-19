// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The GalleryApplicationVersions service client. </summary>
    public partial class GalleryApplicationVersionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GalleryApplicationVersionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of GalleryApplicationVersionsClient for mocking. </summary>
        protected GalleryApplicationVersionsClient()
        {
        }
        /// <summary> Initializes a new instance of GalleryApplicationVersionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal GalleryApplicationVersionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new GalleryApplicationVersionsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves information about a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GalleryApplicationVersion>> GetAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GalleryApplicationVersion> Get(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the Shared Application Gallery Application Definition from which the Application Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<GalleryApplicationVersion> ListByGalleryApplicationAsync(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            async Task<Page<GalleryApplicationVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.ListByGalleryApplication");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByGalleryApplicationAsync(resourceGroupName, galleryName, galleryApplicationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryApplicationVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.ListByGalleryApplication");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByGalleryApplicationNextPageAsync(nextLink, resourceGroupName, galleryName, galleryApplicationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the Shared Application Gallery Application Definition from which the Application Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<GalleryApplicationVersion> ListByGalleryApplication(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            Page<GalleryApplicationVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.ListByGalleryApplication");
                scope.Start();
                try
                {
                    var response = RestClient.ListByGalleryApplication(resourceGroupName, galleryName, galleryApplicationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryApplicationVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.ListByGalleryApplication");
                scope.Start();
                try
                {
                    var response = RestClient.ListByGalleryApplicationNextPage(nextLink, resourceGroupName, galleryName, galleryApplicationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be created. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<GalleryApplicationVersionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, cancellationToken).ConfigureAwait(false);
                return new GalleryApplicationVersionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be created. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual GalleryApplicationVersionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, cancellationToken);
                return new GalleryApplicationVersionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be updated. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<GalleryApplicationVersionsUpdateOperation> StartUpdateAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, cancellationToken).ConfigureAwait(false);
                return new GalleryApplicationVersionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be updated. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual GalleryApplicationVersionsUpdateOperation StartUpdate(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion, cancellationToken);
                return new GalleryApplicationVersionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<GalleryApplicationVersionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, cancellationToken).ConfigureAwait(false);
                return new GalleryApplicationVersionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual GalleryApplicationVersionsDeleteOperation StartDelete(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, cancellationToken);
                return new GalleryApplicationVersionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
