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
    public sealed class InstanceArgocdSpecInstanceSpecCrossplaneExtensionResource
    {
        /// <summary>
        /// Glob pattern of the group to match.
        /// </summary>
        public readonly string? Group;

        [OutputConstructor]
        private InstanceArgocdSpecInstanceSpecCrossplaneExtensionResource(string? group)
        {
            Group = group;
        }
    }
}
