// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> The file share properties be listed out. </summary>
    public partial class FileShareItem : AzureEntityResource
    {
        /// <summary> Initializes a new instance of FileShareItem. </summary>
        public FileShareItem()
        {
        }

        /// <summary> Initializes a new instance of FileShareItem. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="lastModifiedTime"> Returns the date and time the share was last modified. </param>
        /// <param name="metadata"> A name-value pair to associate with the share as metadata. </param>
        /// <param name="shareQuota"> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </param>
        /// <param name="enabledProtocols"> The authentication protocol that is used for the file share. Can only be specified when creating a share. </param>
        /// <param name="rootSquash"> The property is for NFS share only. The default is NoRootSquash. </param>
        /// <param name="version"> The version of the share. </param>
        /// <param name="deleted"> Indicates whether the share was deleted. </param>
        /// <param name="deletedTime"> The deleted time if the share was deleted. </param>
        /// <param name="remainingRetentionDays"> Remaining retention days for share that was soft deleted. </param>
        /// <param name="accessTier"> Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium. </param>
        /// <param name="accessTierChangeTime"> Indicates the last modification time for share access tier. </param>
        /// <param name="accessTierStatus"> Indicates if there is a pending transition for access tier. </param>
        /// <param name="shareUsageBytes"> The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files. </param>
        internal FileShareItem(string id, string name, string type, string etag, DateTimeOffset? lastModifiedTime, IDictionary<string, string> metadata, int? shareQuota, EnabledProtocols? enabledProtocols, RootSquashType? rootSquash, string version, bool? deleted, DateTimeOffset? deletedTime, int? remainingRetentionDays, ShareAccessTier? accessTier, DateTimeOffset? accessTierChangeTime, string accessTierStatus, long? shareUsageBytes) : base(id, name, type, etag)
        {
            LastModifiedTime = lastModifiedTime;
            Metadata = metadata;
            ShareQuota = shareQuota;
            EnabledProtocols = enabledProtocols;
            RootSquash = rootSquash;
            Version = version;
            Deleted = deleted;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            AccessTier = accessTier;
            AccessTierChangeTime = accessTierChangeTime;
            AccessTierStatus = accessTierStatus;
            ShareUsageBytes = shareUsageBytes;
        }

        /// <summary> Returns the date and time the share was last modified. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
        /// <summary> A name-value pair to associate with the share as metadata. </summary>
        public IDictionary<string, string> Metadata { get; set; }
        /// <summary> The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400. </summary>
        public int? ShareQuota { get; set; }
        /// <summary> The authentication protocol that is used for the file share. Can only be specified when creating a share. </summary>
        public EnabledProtocols? EnabledProtocols { get; set; }
        /// <summary> The property is for NFS share only. The default is NoRootSquash. </summary>
        public RootSquashType? RootSquash { get; set; }
        /// <summary> The version of the share. </summary>
        public string Version { get; }
        /// <summary> Indicates whether the share was deleted. </summary>
        public bool? Deleted { get; }
        /// <summary> The deleted time if the share was deleted. </summary>
        public DateTimeOffset? DeletedTime { get; }
        /// <summary> Remaining retention days for share that was soft deleted. </summary>
        public int? RemainingRetentionDays { get; }
        /// <summary> Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium. </summary>
        public ShareAccessTier? AccessTier { get; set; }
        /// <summary> Indicates the last modification time for share access tier. </summary>
        public DateTimeOffset? AccessTierChangeTime { get; }
        /// <summary> Indicates if there is a pending transition for access tier. </summary>
        public string AccessTierStatus { get; }
        /// <summary> The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files. </summary>
        public long? ShareUsageBytes { get; }
    }
}
