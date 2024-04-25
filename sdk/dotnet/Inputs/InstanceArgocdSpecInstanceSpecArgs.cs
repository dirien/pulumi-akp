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

    public sealed class InstanceArgocdSpecInstanceSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Select cluster in which you want to Install Application Set controller
        /// </summary>
        [Input("appSetDelegate")]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecAppSetDelegateArgs>? AppSetDelegate { get; set; }

        /// <summary>
        /// Configures Application Set policy settings.
        /// </summary>
        [Input("appsetPolicy")]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecAppsetPolicyArgs>? AppsetPolicy { get; set; }

        /// <summary>
        /// Enable Powerful AI-powered assistant Extension. It helps analyze Kubernetes resources behavior and provides suggestions about resolving issues.
        /// </summary>
        [Input("assistantExtensionEnabled")]
        public Input<bool>? AssistantExtensionEnabled { get; set; }

        /// <summary>
        /// Enable Audit Extension. Set this to `true` to install Audit Extension to Argo CD instance.
        /// </summary>
        [Input("auditExtensionEnabled")]
        public Input<bool>? AuditExtensionEnabled { get; set; }

        /// <summary>
        /// Enable ip allow list for cluster agents
        /// </summary>
        [Input("backendIpAllowListEnabled")]
        public Input<bool>? BackendIpAllowListEnabled { get; set; }

        /// <summary>
        /// Default values for cluster agents
        /// </summary>
        [Input("clusterCustomizationDefaults")]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecClusterCustomizationDefaultsArgs>? ClusterCustomizationDefaults { get; set; }

        /// <summary>
        /// Enable Declarative Management
        /// </summary>
        [Input("declarativeManagementEnabled")]
        public Input<bool>? DeclarativeManagementEnabled { get; set; }

        [Input("extensions")]
        private InputList<Inputs.InstanceArgocdSpecInstanceSpecExtensionArgs>? _extensions;

        /// <summary>
        /// Extensions
        /// </summary>
        public InputList<Inputs.InstanceArgocdSpecInstanceSpecExtensionArgs> Extensions
        {
            get => _extensions ?? (_extensions = new InputList<Inputs.InstanceArgocdSpecInstanceSpecExtensionArgs>());
            set => _extensions = value;
        }

        [Input("hostAliases")]
        private InputList<Inputs.InstanceArgocdSpecInstanceSpecHostAliasArgs>? _hostAliases;

        /// <summary>
        /// Host Aliases that override the DNS entries for control plane Argo CD components such as API Server and Dex.
        /// </summary>
        public InputList<Inputs.InstanceArgocdSpecInstanceSpecHostAliasArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.InstanceArgocdSpecInstanceSpecHostAliasArgs>());
            set => _hostAliases = value;
        }

        /// <summary>
        /// Select cluster in which you want to Install Image Updater
        /// </summary>
        [Input("imageUpdaterDelegate")]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecImageUpdaterDelegateArgs>? ImageUpdaterDelegate { get; set; }

        /// <summary>
        /// Enable Image Updater
        /// </summary>
        [Input("imageUpdaterEnabled")]
        public Input<bool>? ImageUpdaterEnabled { get; set; }

        [Input("ipAllowLists")]
        private InputList<Inputs.InstanceArgocdSpecInstanceSpecIpAllowListArgs>? _ipAllowLists;

        /// <summary>
        /// IP allow list
        /// </summary>
        public InputList<Inputs.InstanceArgocdSpecInstanceSpecIpAllowListArgs> IpAllowLists
        {
            get => _ipAllowLists ?? (_ipAllowLists = new InputList<Inputs.InstanceArgocdSpecInstanceSpecIpAllowListArgs>());
            set => _ipAllowLists = value;
        }

        /// <summary>
        /// In case some clusters don't have network access to your private Git provider you can delegate these operations to one specific cluster.
        /// </summary>
        [Input("repoServerDelegate")]
        public Input<Inputs.InstanceArgocdSpecInstanceSpecRepoServerDelegateArgs>? RepoServerDelegate { get; set; }

        /// <summary>
        /// Instance subdomain. By default equals to instance id
        /// </summary>
        [Input("subdomain")]
        public Input<string>? Subdomain { get; set; }

        /// <summary>
        /// Enable Sync History Extension. Sync count and duration graphs as well as event details table on Argo CD application details page.
        /// </summary>
        [Input("syncHistoryExtensionEnabled")]
        public Input<bool>? SyncHistoryExtensionEnabled { get; set; }

        public InstanceArgocdSpecInstanceSpecArgs()
        {
        }
        public static new InstanceArgocdSpecInstanceSpecArgs Empty => new InstanceArgocdSpecInstanceSpecArgs();
    }
}
