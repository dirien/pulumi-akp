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

    public sealed class InstanceArgocdSpecInstanceSpecIpAllowListArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// IP description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        public InstanceArgocdSpecInstanceSpecIpAllowListArgs()
        {
        }
        public static new InstanceArgocdSpecInstanceSpecIpAllowListArgs Empty => new InstanceArgocdSpecInstanceSpecIpAllowListArgs();
    }
}
