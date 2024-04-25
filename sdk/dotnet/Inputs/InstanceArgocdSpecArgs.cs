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

    public sealed class InstanceArgocdSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Argo CD instance spec
        /// </summary>
        [Input("instanceSpec", required: true)]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecArgs> InstanceSpec { get; set; } = null!;

        /// <summary>
        /// Argo CD version. Should be equal to any Akuity [`argocd` image tag](https://quay.io/repository/akuity/argocd?tab=tags).
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public InstanceArgocdSpecArgs()
        {
        }
        public static new InstanceArgocdSpecArgs Empty => new InstanceArgocdSpecArgs();
    }
}
