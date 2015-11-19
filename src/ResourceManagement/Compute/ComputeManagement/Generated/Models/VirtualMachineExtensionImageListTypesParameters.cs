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

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Contains the parameteres required to list virtual machine extension
    /// image types.
    /// </summary>
    public partial class VirtualMachineExtensionImageListTypesParameters
    {
        private string _location;
        
        /// <summary>
        /// Required. Location of the PIR, used for orchestration and required
        /// by CSM to direct request to appropriate PIR region. Example:
        /// westus, eastus.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _publisherName;
        
        /// <summary>
        /// Required. Publisher identifier. For example: Microsoft.Windows or
        /// Canonical.
        /// </summary>
        public string PublisherName
        {
            get { return this._publisherName; }
            set { this._publisherName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionImageListTypesParameters class.
        /// </summary>
        public VirtualMachineExtensionImageListTypesParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionImageListTypesParameters class with
        /// required arguments.
        /// </summary>
        public VirtualMachineExtensionImageListTypesParameters(string location, string publisherName)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException("publisherName");
            }
            this.Location = location;
            this.PublisherName = publisherName;
        }
    }
}
