// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Akp.Inputs
{

    public sealed class InstanceArgocdSpecInstanceSpecImageUpdaterDelegateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If use control plane or not
        /// </summary>
        [Input("controlPlane", required: true)]
        public Input<bool> ControlPlane { get; set; } = null!;

        /// <summary>
        /// If use managed cluster or not
        /// </summary>
        [Input("managedCluster")]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecImageUpdaterDelegateManagedClusterArgs>? ManagedCluster { get; set; }

        public InstanceArgocdSpecInstanceSpecImageUpdaterDelegateArgs()
        {
        }
        public static new InstanceArgocdSpecInstanceSpecImageUpdaterDelegateArgs Empty => new InstanceArgocdSpecInstanceSpecImageUpdaterDelegateArgs();
    }
}
