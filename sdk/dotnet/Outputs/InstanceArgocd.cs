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
    public sealed class InstanceArgocd
    {
        /// <summary>
        /// Argo CD instance spec
        /// </summary>
        public readonly Outputs.InstanceArgocdSpec Spec;

        [OutputConstructor]
        private InstanceArgocd(Outputs.InstanceArgocdSpec spec)
        {
            Spec = spec;
        }
    }
}
