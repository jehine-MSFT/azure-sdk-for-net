// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The configuration for the virtual IP address (VIP) this load balancer
    /// provides.
    /// </summary>
    public partial class FrontendIPConfiguration
    {
        private string _staticVirtualNetworkIPAddress;
        
        /// <summary>
        /// Optional. If the deployment exists inside a virtual network, a
        /// specific address from the load balancer subnet can be specified.
        /// The VIP for the load balancer will then be this specific IP
        /// address. If a static virtual network IP address is provided, the
        /// SubnetName element of the load balancer must be specified as well.
        /// If the deployment exists outside of a virtual network, no static
        /// virtual network IP address can be specified.
        /// </summary>
        public string StaticVirtualNetworkIPAddress
        {
            get { return this._staticVirtualNetworkIPAddress; }
            set { this._staticVirtualNetworkIPAddress = value; }
        }
        
        private string _subnetName;
        
        /// <summary>
        /// Optional. If the deployment exists inside a virtual network, a
        /// subnet of that virtual network must be specified for the load
        /// balancer. The VIP managed by the load balancer will then be an IP
        /// address out of this subnet. If the deployment exists outside of a
        /// virtual network, no subnet can be specified and the private VIP
        /// will be an IP address from the general private address pool.
        /// </summary>
        public string SubnetName
        {
            get { return this._subnetName; }
            set { this._subnetName = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. The type of the VIP provided by this load balancer.
        /// Currently, only 'Private' is supported. This will create load
        /// balancing services on a private VIP.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FrontendIPConfiguration class.
        /// </summary>
        public FrontendIPConfiguration()
        {
        }
    }
}