// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Gets information about all clusters attached to an Argo CD instance
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as akp from "@pulumi/akp";
 *
 * const exampleInstance = akp.getInstance({
 *     name: "test",
 * });
 * const exampleClusters = exampleInstance.then(exampleInstance => akp.getClusters({
 *     instanceId: exampleInstance.id,
 * }));
 * ```
 */
export function getClusters(args: GetClustersArgs, opts?: pulumi.InvokeOptions): Promise<GetClustersResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("akp:index/getClusters:getClusters", {
        "instanceId": args.instanceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersArgs {
    /**
     * Argo CD instance ID
     */
    instanceId: string;
}

/**
 * A collection of values returned by getClusters.
 */
export interface GetClustersResult {
    /**
     * List of clusters
     */
    readonly clusters: outputs.GetClustersCluster[];
    /**
     * Argo CD instance ID
     */
    readonly id: string;
    /**
     * Argo CD instance ID
     */
    readonly instanceId: string;
}
/**
 * Gets information about all clusters attached to an Argo CD instance
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as akp from "@pulumi/akp";
 *
 * const exampleInstance = akp.getInstance({
 *     name: "test",
 * });
 * const exampleClusters = exampleInstance.then(exampleInstance => akp.getClusters({
 *     instanceId: exampleInstance.id,
 * }));
 * ```
 */
export function getClustersOutput(args: GetClustersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClustersResult> {
    return pulumi.output(args).apply((a: any) => getClusters(a, opts))
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersOutputArgs {
    /**
     * Argo CD instance ID
     */
    instanceId: pulumi.Input<string>;
}