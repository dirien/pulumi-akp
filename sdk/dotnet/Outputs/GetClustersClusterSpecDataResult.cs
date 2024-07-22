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
    public sealed class GetClustersClusterSpecDataResult
    {
        /// <summary>
        /// Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
        /// </summary>
        public readonly bool AppReplication;
        public readonly bool AutoUpgradeDisabled;
        /// <summary>
        /// Enable Datadog metrics collection of Application Controller and Repo Server. Make sure that you install Datadog agent in cluster.
        /// </summary>
        public readonly bool DatadogAnnotationsEnabled;
        /// <summary>
        /// Enable this if you are installing this cluster on EKS.
        /// </summary>
        public readonly bool EksAddonEnabled;
        /// <summary>
        /// Kustomize configuration that will be applied to generated agent installation manifests
        /// </summary>
        public readonly string Kustomization;
        /// <summary>
        /// The config to access managed Kubernetes cluster. By default agent is using "in-cluster" config.
        /// </summary>
        public readonly Outputs.GetClustersClusterSpecDataManagedClusterConfigResult ManagedClusterConfig;
        /// <summary>
        /// Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
        /// </summary>
        public readonly bool RedisTunneling;
        /// <summary>
        /// Cluster Size. One of `small`, `medium` or `large`
        /// </summary>
        public readonly string Size;
        /// <summary>
        /// The version of the agent to install on your cluster
        /// </summary>
        public readonly string TargetVersion;

        [OutputConstructor]
        private GetClustersClusterSpecDataResult(
            bool appReplication,

            bool autoUpgradeDisabled,

            bool datadogAnnotationsEnabled,

            bool eksAddonEnabled,

            string kustomization,

            Outputs.GetClustersClusterSpecDataManagedClusterConfigResult managedClusterConfig,

            bool redisTunneling,

            string size,

            string targetVersion)
        {
            AppReplication = appReplication;
            AutoUpgradeDisabled = autoUpgradeDisabled;
            DatadogAnnotationsEnabled = datadogAnnotationsEnabled;
            EksAddonEnabled = eksAddonEnabled;
            Kustomization = kustomization;
            ManagedClusterConfig = managedClusterConfig;
            RedisTunneling = redisTunneling;
            Size = size;
            TargetVersion = targetVersion;
        }
    }
}
