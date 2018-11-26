// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Maestro.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubscriptionHistoryItem
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionHistoryItem class.
        /// </summary>
        public SubscriptionHistoryItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionHistoryItem class.
        /// </summary>
        public SubscriptionHistoryItem(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), string errorMessage = default(string), bool? success = default(bool?), System.Guid? subscriptionId = default(System.Guid?), string action = default(string), string retryUrl = default(string))
        {
            Timestamp = timestamp;
            ErrorMessage = errorMessage;
            Success = success;
            SubscriptionId = subscriptionId;
            Action = action;
            RetryUrl = retryUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retryUrl")]
        public string RetryUrl { get; set; }

    }
}