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
    public sealed class GetClustersClusterSpecResult
    {
        /// <summary>
        /// Cluster data
        /// </summary>
        public readonly Outputs.GetClustersClusterSpecDataResult Data;
        /// <summary>
        /// Cluster description
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// If the agent is namespace scoped
        /// </summary>
        public readonly bool NamespaceScoped;

        [OutputConstructor]
        private GetClustersClusterSpecResult(
            Outputs.GetClustersClusterSpecDataResult data,

            string description,

            bool namespaceScoped)
        {
            Data = data;
            Description = description;
            NamespaceScoped = namespaceScoped;
        }
    }
}