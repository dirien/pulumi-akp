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
    public sealed class InstanceArgocdSpecInstanceSpecCrossplaneExtension
    {
        /// <summary>
        /// Glob patterns of the resources to match.
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecCrossplaneExtensionResource> Resources;

        [OutputConstructor]
        private InstanceArgocdSpecInstanceSpecCrossplaneExtension(ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecCrossplaneExtensionResource> resources)
        {
            Resources = resources;
        }
    }
}