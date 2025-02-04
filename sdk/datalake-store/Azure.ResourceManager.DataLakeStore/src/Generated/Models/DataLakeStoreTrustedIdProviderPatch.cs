// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a trusted identity provider. </summary>
    public partial class DataLakeStoreTrustedIdProviderPatch
    {
        /// <summary> Initializes a new instance of DataLakeStoreTrustedIdProviderPatch. </summary>
        public DataLakeStoreTrustedIdProviderPatch()
        {
        }

        /// <summary> The URL of this trusted identity provider. </summary>
        public Uri IdProvider { get; set; }
    }
}
