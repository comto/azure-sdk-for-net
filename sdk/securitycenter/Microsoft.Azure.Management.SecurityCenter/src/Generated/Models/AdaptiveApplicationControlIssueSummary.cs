// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a summary of the alerts of the machine group
    /// </summary>
    public partial class AdaptiveApplicationControlIssueSummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AdaptiveApplicationControlIssueSummary class.
        /// </summary>
        public AdaptiveApplicationControlIssueSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AdaptiveApplicationControlIssueSummary class.
        /// </summary>
        /// <param name="issue">Possible values include: 'ViolationsAudited',
        /// 'ViolationsBlocked', 'MsiAndScriptViolationsAudited',
        /// 'MsiAndScriptViolationsBlocked', 'ExecutableViolationsAudited',
        /// 'RulesViolatedManually'</param>
        /// <param name="numberOfVms">The number of machines in the group that
        /// have this alert</param>
        public AdaptiveApplicationControlIssueSummary(string issue = default(string), double? numberOfVms = default(double?))
        {
            Issue = issue;
            NumberOfVms = numberOfVms;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'ViolationsAudited',
        /// 'ViolationsBlocked', 'MsiAndScriptViolationsAudited',
        /// 'MsiAndScriptViolationsBlocked', 'ExecutableViolationsAudited',
        /// 'RulesViolatedManually'
        /// </summary>
        [JsonProperty(PropertyName = "issue")]
        public string Issue { get; set; }

        /// <summary>
        /// Gets or sets the number of machines in the group that have this
        /// alert
        /// </summary>
        [JsonProperty(PropertyName = "numberOfVms")]
        public double? NumberOfVms { get; set; }

    }
}
