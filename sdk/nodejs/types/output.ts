// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface ClusterKubeConfig {
    /**
     * PEM-encoded client certificate for TLS authentication.
     */
    clientCertificate?: string;
    /**
     * PEM-encoded client certificate key for TLS authentication.
     */
    clientKey?: string;
    /**
     * PEM-encoded root certificates bundle for TLS authentication.
     */
    clusterCaCertificate?: string;
    /**
     * Context name to load from the kube config file.
     */
    configContext?: string;
    configContextAuthInfo?: string;
    configContextCluster?: string;
    /**
     * Path to the kube config file.
     */
    configPath?: string;
    /**
     * A list of paths to kube config files.
     */
    configPaths?: string[];
    /**
     * The hostname (in form of URI) of Kubernetes master.
     */
    host?: string;
    /**
     * Whether server should be accessed without verifying the TLS certificate.
     */
    insecure?: boolean;
    /**
     * The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
     */
    password?: string;
    /**
     * URL to the proxy to be used for all API requests
     */
    proxyUrl?: string;
    /**
     * Token to authenticate an service account
     */
    token?: string;
    /**
     * The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
     */
    username?: string;
}

export interface ClusterSpec {
    /**
     * Cluster data
     */
    data: outputs.ClusterSpecData;
    /**
     * Cluster description
     */
    description: string;
    /**
     * If the agent is namespace scoped
     */
    namespaceScoped: boolean;
}

export interface ClusterSpecData {
    /**
     * Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
     */
    appReplication: boolean;
    autoUpgradeDisabled: boolean;
    /**
     * Enable Datadog metrics collection of Application Controller and Repo Server. Make sure that you install Datadog agent in cluster.
     */
    datadogAnnotationsEnabled: boolean;
    /**
     * Enable this if you are installing this cluster on EKS.
     */
    eksAddonEnabled: boolean;
    /**
     * Kustomize configuration that will be applied to generated agent installation manifests
     */
    kustomization: string;
    /**
     * The config to access managed Kubernetes cluster. By default agent is using "in-cluster" config.
     */
    managedClusterConfig?: outputs.ClusterSpecDataManagedClusterConfig;
    /**
     * Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
     */
    redisTunneling: boolean;
    /**
     * Cluster Size. One of `small`, `medium` or `large`
     */
    size: string;
    /**
     * The version of the agent to install on your cluster
     */
    targetVersion: string;
}

export interface ClusterSpecDataManagedClusterConfig {
    /**
     * The key in the secret for the managed cluster config
     */
    secretKey?: string;
    /**
     * The name of the secret for the managed cluster config
     */
    secretName: string;
}

export interface GetClusterKubeConfig {
    /**
     * PEM-encoded client certificate for TLS authentication.
     */
    clientCertificate: string;
    /**
     * PEM-encoded client certificate key for TLS authentication.
     */
    clientKey: string;
    /**
     * PEM-encoded root certificates bundle for TLS authentication.
     */
    clusterCaCertificate: string;
    /**
     * Context name to load from the kube config file.
     */
    configContext: string;
    configContextAuthInfo: string;
    configContextCluster: string;
    /**
     * Path to the kube config file.
     */
    configPath: string;
    /**
     * A list of paths to kube config files.
     */
    configPaths: string[];
    /**
     * The hostname (in form of URI) of Kubernetes master.
     */
    host: string;
    /**
     * Whether server should be accessed without verifying the TLS certificate.
     */
    insecure: boolean;
    /**
     * The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
     */
    password: string;
    /**
     * URL to the proxy to be used for all API requests
     */
    proxyUrl: string;
    /**
     * Token to authenticate an service account
     */
    token: string;
    /**
     * The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
     */
    username: string;
}

export interface GetClusterSpec {
    /**
     * Cluster data
     */
    data: outputs.GetClusterSpecData;
    /**
     * Cluster description
     */
    description: string;
    /**
     * If the agent is namespace scoped
     */
    namespaceScoped: boolean;
}

export interface GetClusterSpecData {
    /**
     * Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
     */
    appReplication: boolean;
    autoUpgradeDisabled: boolean;
    /**
     * Enable Datadog metrics collection of Application Controller and Repo Server. Make sure that you install Datadog agent in cluster.
     */
    datadogAnnotationsEnabled: boolean;
    /**
     * Enable this if you are installing this cluster on EKS.
     */
    eksAddonEnabled: boolean;
    /**
     * Kustomize configuration that will be applied to generated agent installation manifests
     */
    kustomization: string;
    /**
     * The config to access managed Kubernetes cluster. By default agent is using "in-cluster" config.
     */
    managedClusterConfig: outputs.GetClusterSpecDataManagedClusterConfig;
    /**
     * Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
     */
    redisTunneling: boolean;
    /**
     * Cluster Size. One of `small`, `medium` or `large`
     */
    size: string;
    /**
     * The version of the agent to install on your cluster
     */
    targetVersion: string;
}

export interface GetClusterSpecDataManagedClusterConfig {
    /**
     * The key in the secret for the managed cluster config
     */
    secretKey: string;
    /**
     * The name of the secret for the managed cluster config
     */
    secretName: string;
}

export interface GetClustersCluster {
    /**
     * Annotations
     */
    annotations: {[key: string]: string};
    /**
     * Cluster ID
     */
    id: string;
    /**
     * Argo CD instance ID
     */
    instanceId: string;
    kubeConfig: outputs.GetClustersClusterKubeConfig;
    /**
     * Labels
     */
    labels: {[key: string]: string};
    /**
     * Cluster name
     */
    name: string;
    /**
     * Agent installation namespace
     */
    namespace: string;
    /**
     * Remove agent Kubernetes resources from the managed cluster when destroying cluster
     */
    removeAgentResourcesOnDestroy: boolean;
    /**
     * Cluster spec
     */
    spec: outputs.GetClustersClusterSpec;
}

export interface GetClustersClusterKubeConfig {
    /**
     * PEM-encoded client certificate for TLS authentication.
     */
    clientCertificate: string;
    /**
     * PEM-encoded client certificate key for TLS authentication.
     */
    clientKey: string;
    /**
     * PEM-encoded root certificates bundle for TLS authentication.
     */
    clusterCaCertificate: string;
    /**
     * Context name to load from the kube config file.
     */
    configContext: string;
    configContextAuthInfo: string;
    configContextCluster: string;
    /**
     * Path to the kube config file.
     */
    configPath: string;
    /**
     * A list of paths to kube config files.
     */
    configPaths: string[];
    /**
     * The hostname (in form of URI) of Kubernetes master.
     */
    host: string;
    /**
     * Whether server should be accessed without verifying the TLS certificate.
     */
    insecure: boolean;
    /**
     * The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
     */
    password: string;
    /**
     * URL to the proxy to be used for all API requests
     */
    proxyUrl: string;
    /**
     * Token to authenticate an service account
     */
    token: string;
    /**
     * The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
     */
    username: string;
}

export interface GetClustersClusterSpec {
    /**
     * Cluster data
     */
    data: outputs.GetClustersClusterSpecData;
    /**
     * Cluster description
     */
    description: string;
    /**
     * If the agent is namespace scoped
     */
    namespaceScoped: boolean;
}

export interface GetClustersClusterSpecData {
    /**
     * Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
     */
    appReplication: boolean;
    autoUpgradeDisabled: boolean;
    /**
     * Enable Datadog metrics collection of Application Controller and Repo Server. Make sure that you install Datadog agent in cluster.
     */
    datadogAnnotationsEnabled: boolean;
    /**
     * Enable this if you are installing this cluster on EKS.
     */
    eksAddonEnabled: boolean;
    /**
     * Kustomize configuration that will be applied to generated agent installation manifests
     */
    kustomization: string;
    /**
     * The config to access managed Kubernetes cluster. By default agent is using "in-cluster" config.
     */
    managedClusterConfig: outputs.GetClustersClusterSpecDataManagedClusterConfig;
    /**
     * Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
     */
    redisTunneling: boolean;
    /**
     * Cluster Size. One of `small`, `medium` or `large`
     */
    size: string;
    /**
     * The version of the agent to install on your cluster
     */
    targetVersion: string;
}

export interface GetClustersClusterSpecDataManagedClusterConfig {
    /**
     * The key in the secret for the managed cluster config
     */
    secretKey: string;
    /**
     * The name of the secret for the managed cluster config
     */
    secretName: string;
}

export interface GetInstanceArgocd {
    /**
     * Argo CD instance spec
     */
    spec: outputs.GetInstanceArgocdSpec;
}

export interface GetInstanceArgocdSpec {
    /**
     * Instance description
     */
    description: string;
    /**
     * Argo CD instance spec
     */
    instanceSpec: outputs.GetInstanceArgocdSpecInstanceSpec;
    /**
     * Argo CD version. Should be equal to any Akuity [`argocd` image tag](https://quay.io/repository/akuity/argocd?tab=tags).
     */
    version: string;
}

export interface GetInstanceArgocdSpecInstanceSpec {
    /**
     * The ability to configure agent permissions rules.
     */
    agentPermissionsRules: outputs.GetInstanceArgocdSpecInstanceSpecAgentPermissionsRule[];
    /**
     * Select cluster in which you want to Install Application Set controller
     */
    appSetDelegate: outputs.GetInstanceArgocdSpecInstanceSpecAppSetDelegate;
    /**
     * Configures Application Set policy settings.
     */
    appsetPolicy: outputs.GetInstanceArgocdSpecInstanceSpecAppsetPolicy;
    /**
     * Enable Powerful AI-powered assistant Extension. It helps analyze Kubernetes resources behavior and provides suggestions about resolving issues.
     */
    assistantExtensionEnabled: boolean;
    /**
     * Enable Audit Extension. Set this to `true` to install Audit Extension to Argo CD instance.
     */
    auditExtensionEnabled: boolean;
    /**
     * Enable ip allow list for cluster agents
     */
    backendIpAllowListEnabled: boolean;
    /**
     * Default values for cluster agents
     */
    clusterCustomizationDefaults: outputs.GetInstanceArgocdSpecInstanceSpecClusterCustomizationDefaults;
    /**
     * Custom Resource Definition group name that identifies the Crossplane resource in kubernetes. We will include built-in crossplane resources. Note that you can use glob pattern to match the group. ie. *.crossplane.io
     */
    crossplaneExtension: outputs.GetInstanceArgocdSpecInstanceSpecCrossplaneExtension;
    /**
     * Enable Declarative Management
     */
    declarativeManagementEnabled: boolean;
    /**
     * Extensions
     */
    extensions: outputs.GetInstanceArgocdSpecInstanceSpecExtension[];
    /**
     * Configures the FQDN for the argocd instance, for ingress URL, domain suffix, etc.
     */
    fqdn: string;
    /**
     * Host Aliases that override the DNS entries for control plane Argo CD components such as API Server and Dex.
     */
    hostAliases: outputs.GetInstanceArgocdSpecInstanceSpecHostAlias[];
    /**
     * Select cluster in which you want to Install Image Updater
     */
    imageUpdaterDelegate: outputs.GetInstanceArgocdSpecInstanceSpecImageUpdaterDelegate;
    /**
     * Enable Image Updater
     */
    imageUpdaterEnabled: boolean;
    /**
     * IP allow list
     */
    ipAllowLists: outputs.GetInstanceArgocdSpecInstanceSpecIpAllowList[];
    /**
     * In case some clusters don't have network access to your private Git provider you can delegate these operations to one specific cluster.
     */
    repoServerDelegate: outputs.GetInstanceArgocdSpecInstanceSpecRepoServerDelegate;
    /**
     * Instance subdomain. By default equals to instance id
     */
    subdomain: string;
    /**
     * Enable Sync History Extension. Sync count and duration graphs as well as event details table on Argo CD application details page.
     */
    syncHistoryExtensionEnabled: boolean;
}

export interface GetInstanceArgocdSpecInstanceSpecAgentPermissionsRule {
    /**
     * API groups of the rule.
     */
    apiGroups: string[];
    /**
     * Resources of the rule.
     */
    resources: string[];
    /**
     * Verbs of the rule.
     */
    verbs: string[];
}

export interface GetInstanceArgocdSpecInstanceSpecAppSetDelegate {
    /**
     * Use managed cluster
     */
    managedCluster: outputs.GetInstanceArgocdSpecInstanceSpecAppSetDelegateManagedCluster;
}

export interface GetInstanceArgocdSpecInstanceSpecAppSetDelegateManagedCluster {
    /**
     * Cluster name
     */
    clusterName: string;
}

export interface GetInstanceArgocdSpecInstanceSpecAppsetPolicy {
    /**
     * Allows per `ApplicationSet` sync policy.
     */
    overridePolicy: boolean;
    /**
     * Policy restricts what types of modifications will be made to managed Argo CD `Application` resources.
     * Available options: `sync`, `create-only`, `create-delete`, and `create-update`.
     *   - Policy `sync`(default): Update and delete are allowed.
     *   - Policy `create-only`: Prevents ApplicationSet controller from modifying or deleting Applications.
     *   - Policy `create-update`: Prevents ApplicationSet controller from deleting Applications. Update is allowed.
     *   - Policy `create-delete`: Prevents ApplicationSet controller from modifying Applications, Delete is allowed.
     */
    policy: string;
}

export interface GetInstanceArgocdSpecInstanceSpecClusterCustomizationDefaults {
    /**
     * Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
     */
    appReplication: boolean;
    autoUpgradeDisabled: boolean;
    /**
     * Kustomize configuration that will be applied to generated agent installation manifests
     */
    kustomization: string;
    /**
     * Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
     */
    redisTunneling: boolean;
}

export interface GetInstanceArgocdSpecInstanceSpecCrossplaneExtension {
    /**
     * Glob patterns of the resources to match.
     */
    resources: outputs.GetInstanceArgocdSpecInstanceSpecCrossplaneExtensionResource[];
}

export interface GetInstanceArgocdSpecInstanceSpecCrossplaneExtensionResource {
    /**
     * Glob pattern of the group to match.
     */
    group: string;
}

export interface GetInstanceArgocdSpecInstanceSpecExtension {
    /**
     * Extension ID
     */
    id: string;
    /**
     * Extension version
     */
    version: string;
}

export interface GetInstanceArgocdSpecInstanceSpecHostAlias {
    /**
     * Hostnames
     */
    hostnames: string[];
    /**
     * IP address
     */
    ip: string;
}

export interface GetInstanceArgocdSpecInstanceSpecImageUpdaterDelegate {
    /**
     * If use control plane or not
     */
    controlPlane: boolean;
    /**
     * If use managed cluster or not
     */
    managedCluster: outputs.GetInstanceArgocdSpecInstanceSpecImageUpdaterDelegateManagedCluster;
}

export interface GetInstanceArgocdSpecInstanceSpecImageUpdaterDelegateManagedCluster {
    /**
     * Cluster name
     */
    clusterName: string;
}

export interface GetInstanceArgocdSpecInstanceSpecIpAllowList {
    /**
     * IP description
     */
    description: string;
    /**
     * IP address
     */
    ip: string;
}

export interface GetInstanceArgocdSpecInstanceSpecRepoServerDelegate {
    /**
     * If use control plane or not
     */
    controlPlane: boolean;
    /**
     * If use managed cluster or not
     */
    managedCluster: outputs.GetInstanceArgocdSpecInstanceSpecRepoServerDelegateManagedCluster;
}

export interface GetInstanceArgocdSpecInstanceSpecRepoServerDelegateManagedCluster {
    /**
     * Cluster name
     */
    clusterName: string;
}

export interface GetInstanceConfigManagementPlugins {
    /**
     * Whether this plugin is enabled or not. Default to false.
     */
    enabled: boolean;
    /**
     * Image to use for the plugin
     */
    image: string;
    /**
     * Plugin spec
     */
    spec: outputs.GetInstanceConfigManagementPluginsSpec;
}

export interface GetInstanceConfigManagementPluginsSpec {
    /**
     * The discovery config is applied to a repository. If every configured discovery tool matches, then the plugin may be used to generate manifests for Applications using the repository. If the discovery config is omitted then the plugin will not match any application but can still be invoked explicitly by specifying the plugin name in the app spec. Only one of fileName, find.glob, or find.command should be specified. If multiple are specified then only the first (in that order) is evaluated.
     */
    discover: outputs.GetInstanceConfigManagementPluginsSpecDiscover;
    /**
     * The generate command runs in the Application source directory each time manifests are generated. Standard output must be ONLY valid Kubernetes Objects in either YAML or JSON. A non-zero exit code will fail manifest generation. Error output will be sent to the UI, so avoid printing sensitive information (such as secrets).
     */
    generate: outputs.GetInstanceConfigManagementPluginsSpecGenerate;
    /**
     * The init command runs in the Application source directory at the beginning of each manifest generation. The init command can output anything. A non-zero status code will fail manifest generation. Init always happens immediately before generate, but its output is not treated as manifests. This is a good place to, for example, download chart dependencies.
     */
    init: outputs.GetInstanceConfigManagementPluginsSpecInit;
    /**
     * The parameters config describes what parameters the UI should display for an Application. It is up to the user to actually set parameters in the Application manifest (in spec.source.plugin.parameters). The announcements only inform the "Parameters" tab in the App Details page of the UI.
     */
    parameters: outputs.GetInstanceConfigManagementPluginsSpecParameters;
    /**
     * Whether the plugin receives repository files with original file mode. Dangerous since the repository might have executable files. Set to true only if you trust the CMP plugin authors. Set to false by default.
     */
    preserveFileMode: boolean;
    /**
     * Plugin version
     */
    version: string;
}

export interface GetInstanceConfigManagementPluginsSpecDiscover {
    /**
     * A glob pattern (https://pkg.go.dev/path/filepath#Glob) that is applied to the Application's source directory. If there is a match, this plugin may be used for the Application.
     */
    fileName: string;
    /**
     * Find config
     */
    find: outputs.GetInstanceConfigManagementPluginsSpecDiscoverFind;
}

export interface GetInstanceConfigManagementPluginsSpecDiscoverFind {
    /**
     * Arguments for the find command
     */
    args: string[];
    /**
     * The find command runs in the repository's root directory. To match, it must exit with status code 0 and produce non-empty output to standard out.
     */
    commands: string[];
    /**
     * This does the same thing as `fileName`, but it supports double-start (nested directory) glob patterns.
     */
    glob: string;
}

export interface GetInstanceConfigManagementPluginsSpecGenerate {
    /**
     * Arguments of the command
     */
    args: string[];
    /**
     * Command
     */
    commands: string[];
}

export interface GetInstanceConfigManagementPluginsSpecInit {
    /**
     * Arguments of the command
     */
    args: string[];
    /**
     * Command
     */
    commands: string[];
}

export interface GetInstanceConfigManagementPluginsSpecParameters {
    /**
     * Dynamic parameter announcements are announcements specific to an Application handled by this plugin. For example, the values for a Helm chart's values.yaml file could be sent as parameter announcements.
     */
    dynamic: outputs.GetInstanceConfigManagementPluginsSpecParametersDynamic;
    /**
     * Static parameter announcements are sent to the UI for all Applications handled by this plugin. Think of the `string`, `array`, and `map` values set here as defaults. It is up to the plugin author to make sure that these default values actually reflect the plugin's behavior if the user doesn't explicitly set different values for those parameters.
     */
    statics: outputs.GetInstanceConfigManagementPluginsSpecParametersStatic[];
}

export interface GetInstanceConfigManagementPluginsSpecParametersDynamic {
    /**
     * Arguments of the command
     */
    args: string[];
    /**
     * The command will run in an Application's source directory. Standard output must be JSON matching the schema of the static parameter announcements list.
     */
    commands: string[];
}

export interface GetInstanceConfigManagementPluginsSpecParametersStatic {
    /**
     * This field communicates the parameter's default value to the UI if the parameter is an `array`.
     */
    arrays: string[];
    /**
     * Collection Type describes what type of value this parameter accepts (string, array, or map) and allows the UI to present a form to match that type. Default is `string`. This field must be present for non-string types. It will not be inferred from the presence of an `array` or `map` field.
     */
    collectionType: string;
    /**
     * Item type tells the UI how to present the parameter's value (or, for arrays and maps, values). Default is `string`. Examples of other types which may be supported in the future are `boolean` or `number`. Even if the itemType is not `string`, the parameter value from the Application spec will be sent to the plugin as a string. It's up to the plugin to do the appropriate conversion.
     */
    itemType: string;
    /**
     * This field communicates the parameter's default value to the UI if the parameter is a `map`.
     */
    map: {[key: string]: string};
    /**
     * Parameter name
     */
    name: string;
    /**
     * Whether the Parameter is required or not. If this field is set to true, the UI will indicate to the user that they must set the value. Default to false.
     */
    required: boolean;
    /**
     * This field communicates the parameter's default value to the UI if the parameter is a `string`.
     */
    string: string;
    /**
     * Title and description of the parameter
     */
    title: string;
    /**
     * Tooltip of the Parameter, will be shown when hovering over the title
     */
    tooltip: string;
}

export interface InstanceArgocd {
    /**
     * Argo CD instance spec
     */
    spec: outputs.InstanceArgocdSpec;
}

export interface InstanceArgocdSpec {
    /**
     * Instance description
     */
    description: string;
    /**
     * Argo CD instance spec
     */
    instanceSpec: outputs.InstanceArgocdSpecInstanceSpec;
    /**
     * Argo CD version. Should be equal to any Akuity [`argocd` image tag](https://quay.io/repository/akuity/argocd?tab=tags).
     */
    version: string;
}

export interface InstanceArgocdSpecInstanceSpec {
    /**
     * The ability to configure agent permissions rules.
     */
    agentPermissionsRules?: outputs.InstanceArgocdSpecInstanceSpecAgentPermissionsRule[];
    /**
     * Select cluster in which you want to Install Application Set controller
     */
    appSetDelegate?: outputs.InstanceArgocdSpecInstanceSpecAppSetDelegate;
    /**
     * Configures Application Set policy settings.
     */
    appsetPolicy: outputs.InstanceArgocdSpecInstanceSpecAppsetPolicy;
    /**
     * Enable Powerful AI-powered assistant Extension. It helps analyze Kubernetes resources behavior and provides suggestions about resolving issues.
     */
    assistantExtensionEnabled: boolean;
    /**
     * Enable Audit Extension. Set this to `true` to install Audit Extension to Argo CD instance.
     */
    auditExtensionEnabled: boolean;
    /**
     * Enable ip allow list for cluster agents
     */
    backendIpAllowListEnabled: boolean;
    /**
     * Default values for cluster agents
     */
    clusterCustomizationDefaults: outputs.InstanceArgocdSpecInstanceSpecClusterCustomizationDefaults;
    /**
     * Custom Resource Definition group name that identifies the Crossplane resource in kubernetes. We will include built-in crossplane resources. Note that you can use glob pattern to match the group. ie. *.crossplane.io
     */
    crossplaneExtension?: outputs.InstanceArgocdSpecInstanceSpecCrossplaneExtension;
    /**
     * Enable Declarative Management
     */
    declarativeManagementEnabled: boolean;
    /**
     * Extensions
     */
    extensions?: outputs.InstanceArgocdSpecInstanceSpecExtension[];
    /**
     * Configures the FQDN for the argocd instance, for ingress URL, domain suffix, etc.
     */
    fqdn: string;
    /**
     * Host Aliases that override the DNS entries for control plane Argo CD components such as API Server and Dex.
     */
    hostAliases?: outputs.InstanceArgocdSpecInstanceSpecHostAlias[];
    /**
     * Select cluster in which you want to Install Image Updater
     */
    imageUpdaterDelegate?: outputs.InstanceArgocdSpecInstanceSpecImageUpdaterDelegate;
    /**
     * Enable Image Updater
     */
    imageUpdaterEnabled: boolean;
    /**
     * IP allow list
     */
    ipAllowLists?: outputs.InstanceArgocdSpecInstanceSpecIpAllowList[];
    /**
     * In case some clusters don't have network access to your private Git provider you can delegate these operations to one specific cluster.
     */
    repoServerDelegate?: outputs.InstanceArgocdSpecInstanceSpecRepoServerDelegate;
    /**
     * Instance subdomain. By default equals to instance id
     */
    subdomain: string;
    /**
     * Enable Sync History Extension. Sync count and duration graphs as well as event details table on Argo CD application details page.
     */
    syncHistoryExtensionEnabled: boolean;
}

export interface InstanceArgocdSpecInstanceSpecAgentPermissionsRule {
    /**
     * API groups of the rule.
     */
    apiGroups?: string[];
    /**
     * Resources of the rule.
     */
    resources?: string[];
    /**
     * Verbs of the rule.
     */
    verbs?: string[];
}

export interface InstanceArgocdSpecInstanceSpecAppSetDelegate {
    /**
     * Use managed cluster
     */
    managedCluster?: outputs.InstanceArgocdSpecInstanceSpecAppSetDelegateManagedCluster;
}

export interface InstanceArgocdSpecInstanceSpecAppSetDelegateManagedCluster {
    /**
     * Cluster name
     */
    clusterName: string;
}

export interface InstanceArgocdSpecInstanceSpecAppsetPolicy {
    /**
     * Allows per `ApplicationSet` sync policy.
     */
    overridePolicy: boolean;
    /**
     * Policy restricts what types of modifications will be made to managed Argo CD `Application` resources.
     * Available options: `sync`, `create-only`, `create-delete`, and `create-update`.
     *   - Policy `sync`(default): Update and delete are allowed.
     *   - Policy `create-only`: Prevents ApplicationSet controller from modifying or deleting Applications.
     *   - Policy `create-update`: Prevents ApplicationSet controller from deleting Applications. Update is allowed.
     *   - Policy `create-delete`: Prevents ApplicationSet controller from modifying Applications, Delete is allowed.
     */
    policy: string;
}

export interface InstanceArgocdSpecInstanceSpecClusterCustomizationDefaults {
    /**
     * Enables Argo CD state replication to the managed cluster that allows disconnecting the cluster from Akuity Platform without losing core Argocd features
     */
    appReplication: boolean;
    autoUpgradeDisabled: boolean;
    /**
     * Kustomize configuration that will be applied to generated agent installation manifests
     */
    kustomization: string;
    /**
     * Enables the ability to connect to Redis over a web-socket tunnel that allows using Akuity agent behind HTTPS proxy
     */
    redisTunneling: boolean;
}

export interface InstanceArgocdSpecInstanceSpecCrossplaneExtension {
    /**
     * Glob patterns of the resources to match.
     */
    resources?: outputs.InstanceArgocdSpecInstanceSpecCrossplaneExtensionResource[];
}

export interface InstanceArgocdSpecInstanceSpecCrossplaneExtensionResource {
    /**
     * Glob pattern of the group to match.
     */
    group?: string;
}

export interface InstanceArgocdSpecInstanceSpecExtension {
    /**
     * Extension ID
     */
    id: string;
    /**
     * Extension version
     */
    version: string;
}

export interface InstanceArgocdSpecInstanceSpecHostAlias {
    /**
     * List of hostnames
     */
    hostnames?: string[];
    /**
     * IP address
     */
    ip: string;
}

export interface InstanceArgocdSpecInstanceSpecImageUpdaterDelegate {
    /**
     * If use control plane or not
     */
    controlPlane: boolean;
    /**
     * If use managed cluster or not
     */
    managedCluster?: outputs.InstanceArgocdSpecInstanceSpecImageUpdaterDelegateManagedCluster;
}

export interface InstanceArgocdSpecInstanceSpecImageUpdaterDelegateManagedCluster {
    /**
     * Cluster name
     */
    clusterName: string;
}

export interface InstanceArgocdSpecInstanceSpecIpAllowList {
    /**
     * IP description
     */
    description?: string;
    /**
     * IP address
     */
    ip: string;
}

export interface InstanceArgocdSpecInstanceSpecRepoServerDelegate {
    /**
     * If use control plane or not
     */
    controlPlane: boolean;
    /**
     * If use managed cluster or not
     */
    managedCluster?: outputs.InstanceArgocdSpecInstanceSpecRepoServerDelegateManagedCluster;
}

export interface InstanceArgocdSpecInstanceSpecRepoServerDelegateManagedCluster {
    /**
     * Cluster name
     */
    clusterName: string;
}

export interface InstanceConfigManagementPlugins {
    /**
     * Whether this plugin is enabled or not. Default to false.
     */
    enabled: boolean;
    /**
     * Image to use for the plugin
     */
    image: string;
    /**
     * Plugin spec
     */
    spec: outputs.InstanceConfigManagementPluginsSpec;
}

export interface InstanceConfigManagementPluginsSpec {
    /**
     * The discovery config is applied to a repository. If every configured discovery tool matches, then the plugin may be used to generate manifests for Applications using the repository. If the discovery config is omitted then the plugin will not match any application but can still be invoked explicitly by specifying the plugin name in the app spec. Only one of fileName, find.glob, or find.command should be specified. If multiple are specified then only the first (in that order) is evaluated.
     */
    discover?: outputs.InstanceConfigManagementPluginsSpecDiscover;
    /**
     * The generate command runs in the Application source directory each time manifests are generated. Standard output must be ONLY valid Kubernetes Objects in either YAML or JSON. A non-zero exit code will fail manifest generation. Error output will be sent to the UI, so avoid printing sensitive information (such as secrets).
     */
    generate: outputs.InstanceConfigManagementPluginsSpecGenerate;
    /**
     * The init command runs in the Application source directory at the beginning of each manifest generation. The init command can output anything. A non-zero status code will fail manifest generation. Init always happens immediately before generate, but its output is not treated as manifests. This is a good place to, for example, download chart dependencies.
     */
    init?: outputs.InstanceConfigManagementPluginsSpecInit;
    /**
     * The parameters config describes what parameters the UI should display for an Application. It is up to the user to actually set parameters in the Application manifest (in spec.source.plugin.parameters). The announcements only inform the "Parameters" tab in the App Details page of the UI.
     */
    parameters?: outputs.InstanceConfigManagementPluginsSpecParameters;
    /**
     * Whether the plugin receives repository files with original file mode. Dangerous since the repository might have executable files. Set to true only if you trust the CMP plugin authors. Set to false by default.
     */
    preserveFileMode: boolean;
    /**
     * Plugin version
     */
    version?: string;
}

export interface InstanceConfigManagementPluginsSpecDiscover {
    /**
     * A glob pattern (https://pkg.go.dev/path/filepath#Glob) that is applied to the Application's source directory. If there is a match, this plugin may be used for the Application.
     */
    fileName?: string;
    /**
     * Find config
     */
    find?: outputs.InstanceConfigManagementPluginsSpecDiscoverFind;
}

export interface InstanceConfigManagementPluginsSpecDiscoverFind {
    /**
     * Arguments for the find command
     */
    args?: string[];
    /**
     * The find command runs in the repository's root directory. To match, it must exit with status code 0 and produce non-empty output to standard out.
     */
    commands?: string[];
    /**
     * This does the same thing as `fileName`, but it supports double-start (nested directory) glob patterns.
     */
    glob?: string;
}

export interface InstanceConfigManagementPluginsSpecGenerate {
    /**
     * Arguments of the command
     */
    args?: string[];
    /**
     * Command
     */
    commands: string[];
}

export interface InstanceConfigManagementPluginsSpecInit {
    /**
     * Arguments of the command
     */
    args?: string[];
    /**
     * Command
     */
    commands: string[];
}

export interface InstanceConfigManagementPluginsSpecParameters {
    /**
     * Dynamic parameter announcements are announcements specific to an Application handled by this plugin. For example, the values for a Helm chart's values.yaml file could be sent as parameter announcements.
     */
    dynamic?: outputs.InstanceConfigManagementPluginsSpecParametersDynamic;
    /**
     * Static parameter announcements are sent to the UI for all Applications handled by this plugin. Think of the `string`, `array`, and `map` values set here as defaults. It is up to the plugin author to make sure that these default values actually reflect the plugin's behavior if the user doesn't explicitly set different values for those parameters.
     */
    statics?: outputs.InstanceConfigManagementPluginsSpecParametersStatic[];
}

export interface InstanceConfigManagementPluginsSpecParametersDynamic {
    /**
     * Arguments of the command
     */
    args?: string[];
    /**
     * The command will run in an Application's source directory. Standard output must be JSON matching the schema of the static parameter announcements list.
     */
    commands?: string[];
}

export interface InstanceConfigManagementPluginsSpecParametersStatic {
    /**
     * This field communicates the parameter's default value to the UI if the parameter is an `array`.
     */
    arrays?: string[];
    /**
     * Collection Type describes what type of value this parameter accepts (string, array, or map) and allows the UI to present a form to match that type. Default is `string`. This field must be present for non-string types. It will not be inferred from the presence of an `array` or `map` field.
     */
    collectionType?: string;
    /**
     * Item type tells the UI how to present the parameter's value (or, for arrays and maps, values). Default is `string`. Examples of other types which may be supported in the future are `boolean` or `number`. Even if the itemType is not `string`, the parameter value from the Application spec will be sent to the plugin as a string. It's up to the plugin to do the appropriate conversion.
     */
    itemType?: string;
    /**
     * This field communicates the parameter's default value to the UI if the parameter is a `map`.
     */
    map?: {[key: string]: string};
    /**
     * Parameter name
     */
    name?: string;
    /**
     * Whether the Parameter is required or not. If this field is set to true, the UI will indicate to the user that they must set the value. Default to false.
     */
    required: boolean;
    /**
     * This field communicates the parameter's default value to the UI if the parameter is a `string`.
     */
    string?: string;
    /**
     * Title and description of the parameter
     */
    title?: string;
    /**
     * Tooltip of the Parameter, will be shown when hovering over the title
     */
    tooltip?: string;
}

