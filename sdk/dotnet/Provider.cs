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
    /// The provider type for the akp package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [AkpResourceType("pulumi:providers:akp")]
    public partial class Provider : global::Pulumi.ProviderResource
    {
        /// <summary>
        /// API Key Id. Use environment variable `AKUITY_API_KEY_ID`
        /// </summary>
        [Output("apiKeyId")]
        public Output<string?> ApiKeyId { get; private set; } = null!;

        /// <summary>
        /// API Key Secret, Use environment variable `AKUITY_API_KEY_SECRET`
        /// </summary>
        [Output("apiKeySecret")]
        public Output<string?> ApiKeySecret { get; private set; } = null!;

        /// <summary>
        /// Organization Name
        /// </summary>
        [Output("orgName")]
        public Output<string> OrgName { get; private set; } = null!;

        /// <summary>
        /// Akuity Platform API URL, default: `https://akuity.cloud`. You can use environment variable `AKUITY_SERVER_URL` instead
        /// </summary>
        [Output("serverUrl")]
        public Output<string?> ServerUrl { get; private set; } = null!;


        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs args, CustomResourceOptions? options = null)
            : base("akp", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/dirien/pulumi-akp",
                AdditionalSecretOutputs =
                {
                    "apiKeyId",
                    "apiKeySecret",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiKeyId")]
        private Input<string>? _apiKeyId;

        /// <summary>
        /// API Key Id. Use environment variable `AKUITY_API_KEY_ID`
        /// </summary>
        public Input<string>? ApiKeyId
        {
            get => _apiKeyId;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiKeyId = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("apiKeySecret")]
        private Input<string>? _apiKeySecret;

        /// <summary>
        /// API Key Secret, Use environment variable `AKUITY_API_KEY_SECRET`
        /// </summary>
        public Input<string>? ApiKeySecret
        {
            get => _apiKeySecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiKeySecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Organization Name
        /// </summary>
        [Input("orgName", required: true)]
        public Input<string> OrgName { get; set; } = null!;

        /// <summary>
        /// Akuity Platform API URL, default: `https://akuity.cloud`. You can use environment variable `AKUITY_SERVER_URL` instead
        /// </summary>
        [Input("serverUrl")]
        public Input<string>? ServerUrl { get; set; }

        /// <summary>
        /// Skip TLS Verify. Only use for testing self-hosted version
        /// </summary>
        [Input("skipTlsVerify", json: true)]
        public Input<bool>? SkipTlsVerify { get; set; }

        public ProviderArgs()
        {
            ApiKeyId = Utilities.GetEnv("AKUITY_API_KEY_ID");
            ApiKeySecret = Utilities.GetEnv("AKUITY_API_KEY_SECRET");
            ServerUrl = Utilities.GetEnv("AKUITY_SERVER_URL");
        }
        public static new ProviderArgs Empty => new ProviderArgs();
    }
}
