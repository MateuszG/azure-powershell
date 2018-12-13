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

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssRollingUpgradePolicy", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class SetAzureRmVmssRollingUpgradePolicyCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public int MaxBatchInstancePercent { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int MaxUnhealthyInstancePercent { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public int MaxUnhealthyUpgradedInstancePercent { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PauseTimeBetweenBatches { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Set"))
            {
                Run();
            }
        }

        private void Run()
        {
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxBatchInstancePercent"))
            {
                // UpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy = new UpgradePolicy();
                }
                // RollingUpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy = new RollingUpgradePolicy();
                }
                this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy.MaxBatchInstancePercent = this.MaxBatchInstancePercent;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("MaxUnhealthyInstancePercent"))
            {
                // UpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy = new UpgradePolicy();
                }
                // RollingUpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy = new RollingUpgradePolicy();
                }
                this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy.MaxUnhealthyInstancePercent = this.MaxUnhealthyInstancePercent;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("MaxUnhealthyUpgradedInstancePercent"))
            {
                // UpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy = new UpgradePolicy();
                }
                // RollingUpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy = new RollingUpgradePolicy();
                }
                this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy.MaxUnhealthyUpgradedInstancePercent = this.MaxUnhealthyUpgradedInstancePercent;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("PauseTimeBetweenBatches"))
            {
                // UpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy = new UpgradePolicy();
                }
                // RollingUpgradePolicy
                if (this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy == null)
                {
                    this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy = new RollingUpgradePolicy();
                }
                this.VirtualMachineScaleSet.UpgradePolicy.RollingUpgradePolicy.PauseTimeBetweenBatches = this.PauseTimeBetweenBatches;
            }

            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
