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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a disk.
    /// </summary>
    public partial class Disk
    {
        private string _caching;
        
        /// <summary>
        /// Optional. Gets or sets the caching type.
        /// </summary>
        public string Caching
        {
            get { return this._caching; }
            set { this._caching = value; }
        }
        
        private string _createOption;
        
        /// <summary>
        /// Required. Gets or sets the create option.
        /// </summary>
        public string CreateOption
        {
            get { return this._createOption; }
            set { this._createOption = value; }
        }
        
        private int? _diskSizeGB;
        
        /// <summary>
        /// Optional. Gets or sets the initial disk size in GB for blank data
        /// disks, and the new desired size for existing OS and Data disks.
        /// </summary>
        public int? DiskSizeGB
        {
            get { return this._diskSizeGB; }
            set { this._diskSizeGB = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the disk name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private VirtualHardDisk _sourceImage;
        
        /// <summary>
        /// Optional. Gets or sets the Source User Image VirtualHardDisk. This
        /// VirtualHardDisk will be copied before using it to attach to the
        /// Virtual Machine.If SourceImage is provided, the destination
        /// VirtualHardDisk should not exist.
        /// </summary>
        public VirtualHardDisk SourceImage
        {
            get { return this._sourceImage; }
            set { this._sourceImage = value; }
        }
        
        private VirtualHardDisk _virtualHardDisk;
        
        /// <summary>
        /// Required. Gets or sets the Virtual Hard Disk.
        /// </summary>
        public VirtualHardDisk VirtualHardDisk
        {
            get { return this._virtualHardDisk; }
            set { this._virtualHardDisk = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        public Disk()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Disk class with required
        /// arguments.
        /// </summary>
        public Disk(string name, VirtualHardDisk virtualHardDisk, string createOption)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (virtualHardDisk == null)
            {
                throw new ArgumentNullException("virtualHardDisk");
            }
            if (createOption == null)
            {
                throw new ArgumentNullException("createOption");
            }
            this.Name = name;
            this.VirtualHardDisk = virtualHardDisk;
            this.CreateOption = createOption;
        }
    }
}
