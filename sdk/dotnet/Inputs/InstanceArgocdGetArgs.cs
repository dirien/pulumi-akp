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

    public sealed class InstanceArgocdGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Argo CD instance spec
        /// </summary>
        [Input("spec", required: true)]
        public Input<Inputs.InstanceArgocdSpecGetArgs> Spec { get; set; } = null!;

        public InstanceArgocdGetArgs()
        {
        }
        public static new InstanceArgocdGetArgs Empty => new InstanceArgocdGetArgs();
    }
}
