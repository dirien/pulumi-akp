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
    public sealed class InstanceArgocdSpecInstanceSpec
    {
        /// <summary>
        /// The ability to configure agent permissions rules.
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecAgentPermissionsRule> AgentPermissionsRules;
        /// <summary>
        /// Select cluster in which you want to Install Application Set controller
        /// </summary>
        public readonly Outputs.InstanceArgocdSpecInstanceSpecAppSetDelegate? AppSetDelegate;
        /// <summary>
        /// Configures Application Set policy settings.
        /// </summary>
        public readonly Outputs.InstanceArgocdSpecInstanceSpecAppsetPolicy? AppsetPolicy;
        /// <summary>
        /// Enable Powerful AI-powered assistant Extension. It helps analyze Kubernetes resources behavior and provides suggestions about resolving issues.
        /// </summary>
        public readonly bool? AssistantExtensionEnabled;
        /// <summary>
        /// Enable Audit Extension. Set this to `true` to install Audit Extension to Argo CD instance.
        /// </summary>
        public readonly bool? AuditExtensionEnabled;
        /// <summary>
        /// Enable ip allow list for cluster agents
        /// </summary>
        public readonly bool? BackendIpAllowListEnabled;
        /// <summary>
        /// Default values for cluster agents
        /// </summary>
        public readonly Outputs.InstanceArgocdSpecInstanceSpecClusterCustomizationDefaults? ClusterCustomizationDefaults;
        /// <summary>
        /// Custom Resource Definition group name that identifies the Crossplane resource in kubernetes. We will include built-in crossplane resources. Note that you can use glob pattern to match the group. ie. *.crossplane.io
        /// </summary>
        public readonly Outputs.InstanceArgocdSpecInstanceSpecCrossplaneExtension? CrossplaneExtension;
        /// <summary>
        /// Enable Declarative Management
        /// </summary>
        public readonly bool? DeclarativeManagementEnabled;
        /// <summary>
        /// Extensions
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecExtension> Extensions;
        /// <summary>
        /// Configures the FQDN for the argocd instance, for ingress URL, domain suffix, etc.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// Host Aliases that override the DNS entries for control plane Argo CD components such as API Server and Dex.
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecHostAlias> HostAliases;
        /// <summary>
        /// Select cluster in which you want to Install Image Updater
        /// </summary>
        public readonly Outputs.InstanceArgocdSpecInstanceSpecImageUpdaterDelegate? ImageUpdaterDelegate;
        /// <summary>
        /// Enable Image Updater
        /// </summary>
        public readonly bool? ImageUpdaterEnabled;
        /// <summary>
        /// IP allow list
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecIpAllowList> IpAllowLists;
        /// <summary>
        /// In case some clusters don't have network access to your private Git provider you can delegate these operations to one specific cluster.
        /// </summary>
        public readonly Outputs.InstanceArgocdSpecInstanceSpecRepoServerDelegate? RepoServerDelegate;
        /// <summary>
        /// Instance subdomain. By default equals to instance id
        /// </summary>
        public readonly string? Subdomain;
        /// <summary>
        /// Enable Sync History Extension. Sync count and duration graphs as well as event details table on Argo CD application details page.
        /// </summary>
        public readonly bool? SyncHistoryExtensionEnabled;

        [OutputConstructor]
        private InstanceArgocdSpecInstanceSpec(
            ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecAgentPermissionsRule> agentPermissionsRules,

            Outputs.InstanceArgocdSpecInstanceSpecAppSetDelegate? appSetDelegate,

            Outputs.InstanceArgocdSpecInstanceSpecAppsetPolicy? appsetPolicy,

            bool? assistantExtensionEnabled,

            bool? auditExtensionEnabled,

            bool? backendIpAllowListEnabled,

            Outputs.InstanceArgocdSpecInstanceSpecClusterCustomizationDefaults? clusterCustomizationDefaults,

            Outputs.InstanceArgocdSpecInstanceSpecCrossplaneExtension? crossplaneExtension,

            bool? declarativeManagementEnabled,

            ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecExtension> extensions,

            string? fqdn,

            ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecHostAlias> hostAliases,

            Outputs.InstanceArgocdSpecInstanceSpecImageUpdaterDelegate? imageUpdaterDelegate,

            bool? imageUpdaterEnabled,

            ImmutableArray<Outputs.InstanceArgocdSpecInstanceSpecIpAllowList> ipAllowLists,

            Outputs.InstanceArgocdSpecInstanceSpecRepoServerDelegate? repoServerDelegate,

            string? subdomain,

            bool? syncHistoryExtensionEnabled)
        {
            AgentPermissionsRules = agentPermissionsRules;
            AppSetDelegate = appSetDelegate;
            AppsetPolicy = appsetPolicy;
            AssistantExtensionEnabled = assistantExtensionEnabled;
            AuditExtensionEnabled = auditExtensionEnabled;
            BackendIpAllowListEnabled = backendIpAllowListEnabled;
            ClusterCustomizationDefaults = clusterCustomizationDefaults;
            CrossplaneExtension = crossplaneExtension;
            DeclarativeManagementEnabled = declarativeManagementEnabled;
            Extensions = extensions;
            Fqdn = fqdn;
            HostAliases = hostAliases;
            ImageUpdaterDelegate = imageUpdaterDelegate;
            ImageUpdaterEnabled = imageUpdaterEnabled;
            IpAllowLists = ipAllowLists;
            RepoServerDelegate = repoServerDelegate;
            Subdomain = subdomain;
            SyncHistoryExtensionEnabled = syncHistoryExtensionEnabled;
        }
    }
}
