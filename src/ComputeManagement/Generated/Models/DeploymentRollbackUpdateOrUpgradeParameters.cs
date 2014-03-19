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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Rollback Update Or Upgrade operation.
    /// </summary>
    public partial class DeploymentRollbackUpdateOrUpgradeParameters
    {
        private bool _force;
        
        /// <summary>
        /// Optional. Specifies whether the rollback should proceed even when
        /// it will cause local data to be lost from some role instances. True
        /// if the rollback should proceed; otherwise false.
        /// </summary>
        public bool Force
        {
            get { return this._force; }
            set { this._force = value; }
        }
        
        private RollbackUpdateOrUpgradeMode _mode;
        
        /// <summary>
        /// Required. Specifies whether the rollback should proceed
        /// automatically.
        /// </summary>
        public RollbackUpdateOrUpgradeMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DeploymentRollbackUpdateOrUpgradeParameters class.
        /// </summary>
        public DeploymentRollbackUpdateOrUpgradeParameters()
        {
        }
    }
}
