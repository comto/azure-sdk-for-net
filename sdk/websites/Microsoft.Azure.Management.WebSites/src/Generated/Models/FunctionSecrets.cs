// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Function secrets.
    /// </summary>
    public partial class FunctionSecrets
    {
        /// <summary>
        /// Initializes a new instance of the FunctionSecrets class.
        /// </summary>
        public FunctionSecrets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FunctionSecrets class.
        /// </summary>
        /// <param name="key">Secret key.</param>
        /// <param name="triggerUrl">Trigger URL.</param>
        public FunctionSecrets(string key = default(string), string triggerUrl = default(string))
        {
            Key = key;
            TriggerUrl = triggerUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets secret key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets trigger URL.
        /// </summary>
        [JsonProperty(PropertyName = "trigger_url")]
        public string TriggerUrl { get; set; }

    }
}
