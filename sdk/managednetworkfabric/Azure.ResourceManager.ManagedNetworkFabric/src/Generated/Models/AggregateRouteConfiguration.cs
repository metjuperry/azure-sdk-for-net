// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of IPv4 and IPv6 route configurations. </summary>
    public partial class AggregateRouteConfiguration
    {
        /// <summary> Initializes a new instance of AggregateRouteConfiguration. </summary>
        public AggregateRouteConfiguration()
        {
            IPv4Routes = new ChangeTrackingList<AggregateRoute>();
            IPv6Routes = new ChangeTrackingList<AggregateRoute>();
        }

        /// <summary> Initializes a new instance of AggregateRouteConfiguration. </summary>
        /// <param name="ipv4Routes"> List of IPv4 Route prefixes. </param>
        /// <param name="ipv6Routes"> List of IPv6 Routes prefixes. </param>
        internal AggregateRouteConfiguration(IList<AggregateRoute> ipv4Routes, IList<AggregateRoute> ipv6Routes)
        {
            IPv4Routes = ipv4Routes;
            IPv6Routes = ipv6Routes;
        }

        /// <summary> List of IPv4 Route prefixes. </summary>
        public IList<AggregateRoute> IPv4Routes { get; }
        /// <summary> List of IPv6 Routes prefixes. </summary>
        public IList<AggregateRoute> IPv6Routes { get; }
    }
}
