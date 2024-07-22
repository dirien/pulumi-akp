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

    public sealed class ClusterSpecDataManagedClusterConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key in the secret for the managed cluster config
        /// </summary>
        [Input("secretKey")]
        public Input<string>? SecretKey { get; set; }

        /// <summary>
        /// The name of the secret for the managed cluster config
        /// </summary>
        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        public ClusterSpecDataManagedClusterConfigGetArgs()
        {
        }
        public static new ClusterSpecDataManagedClusterConfigGetArgs Empty => new ClusterSpecDataManagedClusterConfigGetArgs();
    }
}
