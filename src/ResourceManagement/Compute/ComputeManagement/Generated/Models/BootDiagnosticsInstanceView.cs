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
    /// The instance view of a virtual machine boot diagnostics.
    /// </summary>
    public partial class BootDiagnosticsInstanceView
    {
        private Uri _consoleScreenshotBlobUri;
        
        /// <summary>
        /// Optional. Gets or sets the console screenshot blob Uri.
        /// </summary>
        public Uri ConsoleScreenshotBlobUri
        {
            get { return this._consoleScreenshotBlobUri; }
            set { this._consoleScreenshotBlobUri = value; }
        }
        
        private Uri _serialConsoleLogBlobUri;
        
        /// <summary>
        /// Optional. Gets or sets the Linux serial console log blob Uri.
        /// </summary>
        public Uri SerialConsoleLogBlobUri
        {
            get { return this._serialConsoleLogBlobUri; }
            set { this._serialConsoleLogBlobUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BootDiagnosticsInstanceView class.
        /// </summary>
        public BootDiagnosticsInstanceView()
        {
        }
    }
}
