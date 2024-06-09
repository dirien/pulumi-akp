// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Manages a cluster attached to an Argo CD instance.
 *
 * ## Example Usage
 *
 * ## Import
 *
 * Using `pulumi import`, import AKP cluster using `instance_id` and `name` separated by a forward slash (`/`). For example:
 *
 * ```sh
 * $ pulumi import akp:index/cluster:Cluster example 6pzhawvy4echbd8x/test-cluster
 * ```
 */
export class Cluster extends pulumi.CustomResource {
    /**
     * Get an existing Cluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ClusterState, opts?: pulumi.CustomResourceOptions): Cluster {
        return new Cluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'akp:index/cluster:Cluster';

    /**
     * Returns true if the given object is an instance of Cluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Cluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Cluster.__pulumiType;
    }

    /**
     * Annotations
     */
    public readonly annotations!: pulumi.Output<{[key: string]: string}>;
    /**
     * Argo CD instance ID
     */
    public readonly instanceId!: pulumi.Output<string>;
    public readonly kubeConfig!: pulumi.Output<outputs.ClusterKubeConfig | undefined>;
    /**
     * Labels
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * Cluster name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Agent installation namespace
     */
    public readonly namespace!: pulumi.Output<string>;
    /**
     * Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
     */
    public readonly removeAgentResourcesOnDestroy!: pulumi.Output<boolean>;
    /**
     * Cluster spec
     */
    public readonly spec!: pulumi.Output<outputs.ClusterSpec>;

    /**
     * Create a Cluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ClusterArgs | ClusterState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ClusterState | undefined;
            resourceInputs["annotations"] = state ? state.annotations : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["kubeConfig"] = state ? state.kubeConfig : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["namespace"] = state ? state.namespace : undefined;
            resourceInputs["removeAgentResourcesOnDestroy"] = state ? state.removeAgentResourcesOnDestroy : undefined;
            resourceInputs["spec"] = state ? state.spec : undefined;
        } else {
            const args = argsOrState as ClusterArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.namespace === undefined) && !opts.urn) {
                throw new Error("Missing required property 'namespace'");
            }
            if ((!args || args.spec === undefined) && !opts.urn) {
                throw new Error("Missing required property 'spec'");
            }
            resourceInputs["annotations"] = args ? args.annotations : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["kubeConfig"] = args ? args.kubeConfig : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["namespace"] = args ? args.namespace : undefined;
            resourceInputs["removeAgentResourcesOnDestroy"] = args ? args.removeAgentResourcesOnDestroy : undefined;
            resourceInputs["spec"] = args ? args.spec : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Cluster.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Cluster resources.
 */
export interface ClusterState {
    /**
     * Annotations
     */
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Argo CD instance ID
     */
    instanceId?: pulumi.Input<string>;
    kubeConfig?: pulumi.Input<inputs.ClusterKubeConfig>;
    /**
     * Labels
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Cluster name
     */
    name?: pulumi.Input<string>;
    /**
     * Agent installation namespace
     */
    namespace?: pulumi.Input<string>;
    /**
     * Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
     */
    removeAgentResourcesOnDestroy?: pulumi.Input<boolean>;
    /**
     * Cluster spec
     */
    spec?: pulumi.Input<inputs.ClusterSpec>;
}

/**
 * The set of arguments for constructing a Cluster resource.
 */
export interface ClusterArgs {
    /**
     * Annotations
     */
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Argo CD instance ID
     */
    instanceId: pulumi.Input<string>;
    kubeConfig?: pulumi.Input<inputs.ClusterKubeConfig>;
    /**
     * Labels
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Cluster name
     */
    name?: pulumi.Input<string>;
    /**
     * Agent installation namespace
     */
    namespace: pulumi.Input<string>;
    /**
     * Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
     */
    removeAgentResourcesOnDestroy?: pulumi.Input<boolean>;
    /**
     * Cluster spec
     */
    spec: pulumi.Input<inputs.ClusterSpec>;
}
