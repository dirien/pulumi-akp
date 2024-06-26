// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Akp.Outputs
{

    [OutputType]
    public sealed class GetInstanceArgocdSpecResult
    {
        /// <summary>
        /// Instance description
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Argo CD instance spec
        /// </summary>
        public readonly Outputs.GetInstanceArgocdSpecInstanceSpecResult InstanceSpec;
        /// <summary>
        /// Argo CD version. Should be equal to any Akuity [`argocd` image tag](https://quay.io/repository/akuity/argocd?tab=tags).
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private GetInstanceArgocdSpecResult(
            string description,

            Outputs.GetInstanceArgocdSpecInstanceSpecResult instanceSpec,

            string version)
        {
            Description = description;
            InstanceSpec = instanceSpec;
            Version = version;
        }
    }
}
