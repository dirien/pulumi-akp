// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Akp
{
    /// <summary>
    /// Manages a cluster attached to an Argo CD instance.
    /// 
    /// ## Example Usage
    /// 
    /// ## Import
    /// 
    /// Using `pulumi import`, import AKP cluster using `instance_id` and `name` separated by a forward slash (`/`). For example:
    /// 
    /// ```sh
    /// $ pulumi import akp:index/cluster:Cluster example 6pzhawvy4echbd8x/test-cluster
    /// ```
    /// </summary>
    [AkpResourceType("akp:index/cluster:Cluster")]
    public partial class Cluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Annotations
        /// </summary>
        [Output("annotations")]
        public Output<ImmutableDictionary<string, string>> Annotations { get; private set; } = null!;

        /// <summary>
        /// Argo CD instance ID
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        [Output("kubeConfig")]
        public Output<Outputs.ClusterKubeConfig?> KubeConfig { get; private set; } = null!;

        /// <summary>
        /// Labels
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// Cluster name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Agent installation namespace
        /// </summary>
        [Output("namespace")]
        public Output<string> Namespace { get; private set; } = null!;

        /// <summary>
        /// Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        /// </summary>
        [Output("removeAgentResourcesOnDestroy")]
        public Output<bool> RemoveAgentResourcesOnDestroy { get; private set; } = null!;

        /// <summary>
        /// Cluster spec
        /// </summary>
        [Output("spec")]
        public Output<Outputs.ClusterSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a Cluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Cluster(string name, ClusterArgs args, CustomResourceOptions? options = null)
            : base("akp:index/cluster:Cluster", name, args ?? new ClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Cluster(string name, Input<string> id, ClusterState? state = null, CustomResourceOptions? options = null)
            : base("akp:index/cluster:Cluster", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/dirien/pulumi-akp",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Cluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Cluster Get(string name, Input<string> id, ClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new Cluster(name, id, state, options);
        }
    }

    public sealed class ClusterArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;

        /// <summary>
        /// Annotations
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// Argo CD instance ID
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("kubeConfig")]
        public Input<Inputs.ClusterKubeConfigArgs>? KubeConfig { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Cluster name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Agent installation namespace
        /// </summary>
        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        /// <summary>
        /// Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        /// </summary>
        [Input("removeAgentResourcesOnDestroy")]
        public Input<bool>? RemoveAgentResourcesOnDestroy { get; set; }

        /// <summary>
        /// Cluster spec
        /// </summary>
        [Input("spec", required: true)]
        public Input<Inputs.ClusterSpecArgs> Spec { get; set; } = null!;

        public ClusterArgs()
        {
        }
        public static new ClusterArgs Empty => new ClusterArgs();
    }

    public sealed class ClusterState : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;

        /// <summary>
        /// Annotations
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// Argo CD instance ID
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("kubeConfig")]
        public Input<Inputs.ClusterKubeConfigGetArgs>? KubeConfig { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Cluster name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Agent installation namespace
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        /// </summary>
        [Input("removeAgentResourcesOnDestroy")]
        public Input<bool>? RemoveAgentResourcesOnDestroy { get; set; }

        /// <summary>
        /// Cluster spec
        /// </summary>
        [Input("spec")]
        public Input<Inputs.ClusterSpecGetArgs>? Spec { get; set; }

        public ClusterState()
        {
        }
        public static new ClusterState Empty => new ClusterState();
    }
}
