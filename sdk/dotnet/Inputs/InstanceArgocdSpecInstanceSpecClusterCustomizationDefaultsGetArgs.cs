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

    public sealed class InstanceArgocdSpecInstanceSpecClusterCustomizationDefaultsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
        /// </summary>
        [Input("appReplication")]
        public Input<bool>? AppReplication { get; set; }

        [Input("autoUpgradeDisabled")]
        public Input<bool>? AutoUpgradeDisabled { get; set; }

        /// <summary>
        /// Kustomize configuration that will be applied to generated agent installation manifests
        /// </summary>
        [Input("kustomization")]
        public Input<string>? Kustomization { get; set; }

        /// <summary>
        /// Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
        /// </summary>
        [Input("redisTunneling")]
        public Input<bool>? RedisTunneling { get; set; }

        public InstanceArgocdSpecInstanceSpecClusterCustomizationDefaultsGetArgs()
        {
        }
        public static new InstanceArgocdSpecInstanceSpecClusterCustomizationDefaultsGetArgs Empty => new InstanceArgocdSpecInstanceSpecClusterCustomizationDefaultsGetArgs();
    }
}
