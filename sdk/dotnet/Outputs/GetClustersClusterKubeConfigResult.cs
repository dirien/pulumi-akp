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
    public sealed class GetClustersClusterKubeConfigResult
    {
        /// <summary>
        /// PEM-encoded client certificate for TLS authentication.
        /// </summary>
        public readonly string ClientCertificate;
        /// <summary>
        /// PEM-encoded client certificate key for TLS authentication.
        /// </summary>
        public readonly string ClientKey;
        /// <summary>
        /// PEM-encoded root certificates bundle for TLS authentication.
        /// </summary>
        public readonly string ClusterCaCertificate;
        /// <summary>
        /// Context name to load from the kube config file.
        /// </summary>
        public readonly string ConfigContext;
        public readonly string ConfigContextAuthInfo;
        public readonly string ConfigContextCluster;
        /// <summary>
        /// Path to the kube config file.
        /// </summary>
        public readonly string ConfigPath;
        /// <summary>
        /// A list of paths to kube config files.
        /// </summary>
        public readonly ImmutableArray<string> ConfigPaths;
        /// <summary>
        /// The hostname (in form of URI) of Kubernetes master.
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// Whether server should be accessed without verifying the TLS certificate.
        /// </summary>
        public readonly bool Insecure;
        /// <summary>
        /// The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// URL to the proxy to be used for all API requests
        /// </summary>
        public readonly string ProxyUrl;
        /// <summary>
        /// Token to authenticate an service account
        /// </summary>
        public readonly string Token;
        /// <summary>
        /// The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private GetClustersClusterKubeConfigResult(
            string clientCertificate,

            string clientKey,

            string clusterCaCertificate,

            string configContext,

            string configContextAuthInfo,

            string configContextCluster,

            string configPath,

            ImmutableArray<string> configPaths,

            string host,

            bool insecure,

            string password,

            string proxyUrl,

            string token,

            string username)
        {
            ClientCertificate = clientCertificate;
            ClientKey = clientKey;
            ClusterCaCertificate = clusterCaCertificate;
            ConfigContext = configContext;
            ConfigContextAuthInfo = configContextAuthInfo;
            ConfigContextCluster = configContextCluster;
            ConfigPath = configPath;
            ConfigPaths = configPaths;
            Host = host;
            Insecure = insecure;
            Password = password;
            ProxyUrl = proxyUrl;
            Token = token;
            Username = username;
        }
    }
}
