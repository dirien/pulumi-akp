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
    /// Manages an Argo CD instance
    /// 
    /// ## Example Usage
    /// 
    /// ### Basic)
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Akp = ediri.Akp;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var argocd = new Akp.Instance("argocd", new()
    ///     {
    ///         Argocd = new Akp.Inputs.InstanceArgocdArgs
    ///         {
    ///             Spec = new Akp.Inputs.InstanceArgocdSpecArgs
    ///             {
    ///                 InstanceSpec = new Akp.Inputs.InstanceArgocdSpecInstanceSpecArgs
    ///                 {
    ///                     DeclarativeManagementEnabled = true,
    ///                 },
    ///                 Version = "v2.11.4",
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// Using `pulumi import`, import AKP instance using its `name`. For example:
    /// 
    /// ```sh
    /// $ pulumi import akp:index/instance:Instance example test
    /// ```
    /// </summary>
    [AkpResourceType("akp:index/instance:Instance")]
    public partial class Instance : global::Pulumi.CustomResource
    {
        /// <summary>
        /// stores secret key-value that will be used by `ApplicationSet`. For an example of how to use this in your
        /// ApplicationSet's pull request generator, see
        /// [here](https://github.com/argoproj/argo-cd/blob/master/docs/operator-manual/applicationset/Generators-Pull-Request.md#github).
        /// In this example, `tokenRef.secretName` would be application-set-secret.
        /// </summary>
        [Output("applicationSetSecret")]
        public Output<ImmutableDictionary<string, string>?> ApplicationSetSecret { get; private set; } = null!;

        /// <summary>
        /// Argo CD instance configuration
        /// </summary>
        [Output("argocd")]
        public Output<Outputs.InstanceArgocd> Argocd { get; private set; } = null!;

        /// <summary>
        /// is aligned with the options in `argocd-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-cm-yaml/).
        /// </summary>
        [Output("argocdCm")]
        public Output<ImmutableDictionary<string, string>> ArgocdCm { get; private set; } = null!;

        /// <summary>
        /// configures Argo CD image updater, and it is aligned with `argocd-image-updater-config` ConfigMap of Argo CD, for
        /// available options and examples, refer to [this documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        [Output("argocdImageUpdaterConfig")]
        public Output<ImmutableDictionary<string, string>> ArgocdImageUpdaterConfig { get; private set; } = null!;

        /// <summary>
        /// contains sensitive data (e.g., credentials for image updater to access registries) of Argo CD image updater, for
        /// available options and examples, refer to [this documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        [Output("argocdImageUpdaterSecret")]
        public Output<ImmutableDictionary<string, string>?> ArgocdImageUpdaterSecret { get; private set; } = null!;

        /// <summary>
        /// contains the ssh configuration for Argo CD image updater, and it is aligned with `argocd-image-updater-ssh-config`
        /// ConfigMap of Argo CD, for available options and examples, refer to [this
        /// documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        [Output("argocdImageUpdaterSshConfig")]
        public Output<ImmutableDictionary<string, string>> ArgocdImageUpdaterSshConfig { get; private set; } = null!;

        /// <summary>
        /// configures Argo CD notifications, and it is aligned with `argocd-notifications-cm` ConfigMap of Argo CD, for more
        /// details and examples, refer to [this documentation](https://argocd-notifications.readthedocs.io/en/stable/).
        /// </summary>
        [Output("argocdNotificationsCm")]
        public Output<ImmutableDictionary<string, string>> ArgocdNotificationsCm { get; private set; } = null!;

        /// <summary>
        /// contains sensitive data of Argo CD notifications, and it is aligned with `argocd-notifications-secret` Secret of Argo
        /// CD, for more details and examples, refer to [this
        /// documentation](https://argocd-notifications.readthedocs.io/en/stable/services/overview/#sensitive-data).
        /// </summary>
        [Output("argocdNotificationsSecret")]
        public Output<ImmutableDictionary<string, string>?> ArgocdNotificationsSecret { get; private set; } = null!;

        /// <summary>
        /// is aligned with the options in `argocd-rbac-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-rbac-cm-yaml/).
        /// </summary>
        [Output("argocdRbacCm")]
        public Output<ImmutableDictionary<string, string>> ArgocdRbacCm { get; private set; } = null!;

        /// <summary>
        /// is aligned with the options in `argocd-secret` Secret as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-secret-yaml/).
        /// </summary>
        [Output("argocdSecret")]
        public Output<ImmutableDictionary<string, string>?> ArgocdSecret { get; private set; } = null!;

        /// <summary>
        /// is aligned with the options in `argocd-ssh-known-hosts-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-ssh-known-hosts-cm-yaml/).
        /// </summary>
        [Output("argocdSshKnownHostsCm")]
        public Output<ImmutableDictionary<string, string>> ArgocdSshKnownHostsCm { get; private set; } = null!;

        /// <summary>
        /// is aligned with the options in `argocd-tls-certs-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-tls-certs-cm-yaml/).
        /// </summary>
        [Output("argocdTlsCertsCm")]
        public Output<ImmutableDictionary<string, string>> ArgocdTlsCertsCm { get; private set; } = null!;

        /// <summary>
        /// is a map of [Config Management
        /// Plugins](https://argo-cd.readthedocs.io/en/stable/operator-manual/config-management-plugins/#config-management-plugins),
        /// the key of map entry is the `name` of the plugin, and the value is the definition of the Config Management Plugin(v2).
        /// </summary>
        [Output("configManagementPlugins")]
        public Output<ImmutableDictionary<string, Outputs.InstanceConfigManagementPlugins>?> ConfigManagementPlugins { get; private set; } = null!;

        /// <summary>
        /// Instance name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// is a map of repo credential secrets, the key of map entry is the `name` of the secret, and the value is the aligned with
        /// options in `argocd-repositories.yaml.data` as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-repositories-yaml/).
        /// </summary>
        [Output("repoCredentialSecrets")]
        public Output<ImmutableDictionary<string, ImmutableDictionary<string, string>>?> RepoCredentialSecrets { get; private set; } = null!;

        /// <summary>
        /// is a map of repository credential templates secrets, the key of map entry is the `name` of the secret, and the value is
        /// the aligned with options in `argocd-repo-creds.yaml.data` as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-repo-creds.yaml/).
        /// </summary>
        [Output("repoTemplateCredentialSecrets")]
        public Output<ImmutableDictionary<string, ImmutableDictionary<string, string>>?> RepoTemplateCredentialSecrets { get; private set; } = null!;


        /// <summary>
        /// Create a Instance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Instance(string name, InstanceArgs args, CustomResourceOptions? options = null)
            : base("akp:index/instance:Instance", name, args ?? new InstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Instance(string name, Input<string> id, InstanceState? state = null, CustomResourceOptions? options = null)
            : base("akp:index/instance:Instance", name, state, MakeResourceOptions(options, id))
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
                    "applicationSetSecret",
                    "argocdImageUpdaterSecret",
                    "argocdNotificationsSecret",
                    "argocdSecret",
                    "repoCredentialSecrets",
                    "repoTemplateCredentialSecrets",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Instance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Instance Get(string name, Input<string> id, InstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new Instance(name, id, state, options);
        }
    }

    public sealed class InstanceArgs : global::Pulumi.ResourceArgs
    {
        [Input("applicationSetSecret")]
        private InputMap<string>? _applicationSetSecret;

        /// <summary>
        /// stores secret key-value that will be used by `ApplicationSet`. For an example of how to use this in your
        /// ApplicationSet's pull request generator, see
        /// [here](https://github.com/argoproj/argo-cd/blob/master/docs/operator-manual/applicationset/Generators-Pull-Request.md#github).
        /// In this example, `tokenRef.secretName` would be application-set-secret.
        /// </summary>
        public InputMap<string> ApplicationSetSecret
        {
            get => _applicationSetSecret ?? (_applicationSetSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _applicationSetSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        /// <summary>
        /// Argo CD instance configuration
        /// </summary>
        [Input("argocd", required: true)]
        public Input<Inputs.InstanceArgocdArgs> Argocd { get; set; } = null!;

        [Input("argocdCm")]
        private InputMap<string>? _argocdCm;

        /// <summary>
        /// is aligned with the options in `argocd-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdCm
        {
            get => _argocdCm ?? (_argocdCm = new InputMap<string>());
            set => _argocdCm = value;
        }

        [Input("argocdImageUpdaterConfig")]
        private InputMap<string>? _argocdImageUpdaterConfig;

        /// <summary>
        /// configures Argo CD image updater, and it is aligned with `argocd-image-updater-config` ConfigMap of Argo CD, for
        /// available options and examples, refer to [this documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdImageUpdaterConfig
        {
            get => _argocdImageUpdaterConfig ?? (_argocdImageUpdaterConfig = new InputMap<string>());
            set => _argocdImageUpdaterConfig = value;
        }

        [Input("argocdImageUpdaterSecret")]
        private InputMap<string>? _argocdImageUpdaterSecret;

        /// <summary>
        /// contains sensitive data (e.g., credentials for image updater to access registries) of Argo CD image updater, for
        /// available options and examples, refer to [this documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdImageUpdaterSecret
        {
            get => _argocdImageUpdaterSecret ?? (_argocdImageUpdaterSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _argocdImageUpdaterSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("argocdImageUpdaterSshConfig")]
        private InputMap<string>? _argocdImageUpdaterSshConfig;

        /// <summary>
        /// contains the ssh configuration for Argo CD image updater, and it is aligned with `argocd-image-updater-ssh-config`
        /// ConfigMap of Argo CD, for available options and examples, refer to [this
        /// documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdImageUpdaterSshConfig
        {
            get => _argocdImageUpdaterSshConfig ?? (_argocdImageUpdaterSshConfig = new InputMap<string>());
            set => _argocdImageUpdaterSshConfig = value;
        }

        [Input("argocdNotificationsCm")]
        private InputMap<string>? _argocdNotificationsCm;

        /// <summary>
        /// configures Argo CD notifications, and it is aligned with `argocd-notifications-cm` ConfigMap of Argo CD, for more
        /// details and examples, refer to [this documentation](https://argocd-notifications.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdNotificationsCm
        {
            get => _argocdNotificationsCm ?? (_argocdNotificationsCm = new InputMap<string>());
            set => _argocdNotificationsCm = value;
        }

        [Input("argocdNotificationsSecret")]
        private InputMap<string>? _argocdNotificationsSecret;

        /// <summary>
        /// contains sensitive data of Argo CD notifications, and it is aligned with `argocd-notifications-secret` Secret of Argo
        /// CD, for more details and examples, refer to [this
        /// documentation](https://argocd-notifications.readthedocs.io/en/stable/services/overview/#sensitive-data).
        /// </summary>
        public InputMap<string> ArgocdNotificationsSecret
        {
            get => _argocdNotificationsSecret ?? (_argocdNotificationsSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _argocdNotificationsSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("argocdRbacCm")]
        private InputMap<string>? _argocdRbacCm;

        /// <summary>
        /// is aligned with the options in `argocd-rbac-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-rbac-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdRbacCm
        {
            get => _argocdRbacCm ?? (_argocdRbacCm = new InputMap<string>());
            set => _argocdRbacCm = value;
        }

        [Input("argocdSecret")]
        private InputMap<string>? _argocdSecret;

        /// <summary>
        /// is aligned with the options in `argocd-secret` Secret as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-secret-yaml/).
        /// </summary>
        public InputMap<string> ArgocdSecret
        {
            get => _argocdSecret ?? (_argocdSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _argocdSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("argocdSshKnownHostsCm")]
        private InputMap<string>? _argocdSshKnownHostsCm;

        /// <summary>
        /// is aligned with the options in `argocd-ssh-known-hosts-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-ssh-known-hosts-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdSshKnownHostsCm
        {
            get => _argocdSshKnownHostsCm ?? (_argocdSshKnownHostsCm = new InputMap<string>());
            set => _argocdSshKnownHostsCm = value;
        }

        [Input("argocdTlsCertsCm")]
        private InputMap<string>? _argocdTlsCertsCm;

        /// <summary>
        /// is aligned with the options in `argocd-tls-certs-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-tls-certs-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdTlsCertsCm
        {
            get => _argocdTlsCertsCm ?? (_argocdTlsCertsCm = new InputMap<string>());
            set => _argocdTlsCertsCm = value;
        }

        [Input("configManagementPlugins")]
        private InputMap<Inputs.InstanceConfigManagementPluginsArgs>? _configManagementPlugins;

        /// <summary>
        /// is a map of [Config Management
        /// Plugins](https://argo-cd.readthedocs.io/en/stable/operator-manual/config-management-plugins/#config-management-plugins),
        /// the key of map entry is the `name` of the plugin, and the value is the definition of the Config Management Plugin(v2).
        /// </summary>
        public InputMap<Inputs.InstanceConfigManagementPluginsArgs> ConfigManagementPlugins
        {
            get => _configManagementPlugins ?? (_configManagementPlugins = new InputMap<Inputs.InstanceConfigManagementPluginsArgs>());
            set => _configManagementPlugins = value;
        }

        /// <summary>
        /// Instance name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("repoCredentialSecrets")]
        private InputMap<ImmutableDictionary<string, string>>? _repoCredentialSecrets;

        /// <summary>
        /// is a map of repo credential secrets, the key of map entry is the `name` of the secret, and the value is the aligned with
        /// options in `argocd-repositories.yaml.data` as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-repositories-yaml/).
        /// </summary>
        public InputMap<ImmutableDictionary<string, string>> RepoCredentialSecrets
        {
            get => _repoCredentialSecrets ?? (_repoCredentialSecrets = new InputMap<ImmutableDictionary<string, string>>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, ImmutableDictionary<string, string>>());
                _repoCredentialSecrets = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("repoTemplateCredentialSecrets")]
        private InputMap<ImmutableDictionary<string, string>>? _repoTemplateCredentialSecrets;

        /// <summary>
        /// is a map of repository credential templates secrets, the key of map entry is the `name` of the secret, and the value is
        /// the aligned with options in `argocd-repo-creds.yaml.data` as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-repo-creds.yaml/).
        /// </summary>
        public InputMap<ImmutableDictionary<string, string>> RepoTemplateCredentialSecrets
        {
            get => _repoTemplateCredentialSecrets ?? (_repoTemplateCredentialSecrets = new InputMap<ImmutableDictionary<string, string>>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, ImmutableDictionary<string, string>>());
                _repoTemplateCredentialSecrets = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        public InstanceArgs()
        {
        }
        public static new InstanceArgs Empty => new InstanceArgs();
    }

    public sealed class InstanceState : global::Pulumi.ResourceArgs
    {
        [Input("applicationSetSecret")]
        private InputMap<string>? _applicationSetSecret;

        /// <summary>
        /// stores secret key-value that will be used by `ApplicationSet`. For an example of how to use this in your
        /// ApplicationSet's pull request generator, see
        /// [here](https://github.com/argoproj/argo-cd/blob/master/docs/operator-manual/applicationset/Generators-Pull-Request.md#github).
        /// In this example, `tokenRef.secretName` would be application-set-secret.
        /// </summary>
        public InputMap<string> ApplicationSetSecret
        {
            get => _applicationSetSecret ?? (_applicationSetSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _applicationSetSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        /// <summary>
        /// Argo CD instance configuration
        /// </summary>
        [Input("argocd")]
        public Input<Inputs.InstanceArgocdGetArgs>? Argocd { get; set; }

        [Input("argocdCm")]
        private InputMap<string>? _argocdCm;

        /// <summary>
        /// is aligned with the options in `argocd-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdCm
        {
            get => _argocdCm ?? (_argocdCm = new InputMap<string>());
            set => _argocdCm = value;
        }

        [Input("argocdImageUpdaterConfig")]
        private InputMap<string>? _argocdImageUpdaterConfig;

        /// <summary>
        /// configures Argo CD image updater, and it is aligned with `argocd-image-updater-config` ConfigMap of Argo CD, for
        /// available options and examples, refer to [this documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdImageUpdaterConfig
        {
            get => _argocdImageUpdaterConfig ?? (_argocdImageUpdaterConfig = new InputMap<string>());
            set => _argocdImageUpdaterConfig = value;
        }

        [Input("argocdImageUpdaterSecret")]
        private InputMap<string>? _argocdImageUpdaterSecret;

        /// <summary>
        /// contains sensitive data (e.g., credentials for image updater to access registries) of Argo CD image updater, for
        /// available options and examples, refer to [this documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdImageUpdaterSecret
        {
            get => _argocdImageUpdaterSecret ?? (_argocdImageUpdaterSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _argocdImageUpdaterSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("argocdImageUpdaterSshConfig")]
        private InputMap<string>? _argocdImageUpdaterSshConfig;

        /// <summary>
        /// contains the ssh configuration for Argo CD image updater, and it is aligned with `argocd-image-updater-ssh-config`
        /// ConfigMap of Argo CD, for available options and examples, refer to [this
        /// documentation](https://argocd-image-updater.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdImageUpdaterSshConfig
        {
            get => _argocdImageUpdaterSshConfig ?? (_argocdImageUpdaterSshConfig = new InputMap<string>());
            set => _argocdImageUpdaterSshConfig = value;
        }

        [Input("argocdNotificationsCm")]
        private InputMap<string>? _argocdNotificationsCm;

        /// <summary>
        /// configures Argo CD notifications, and it is aligned with `argocd-notifications-cm` ConfigMap of Argo CD, for more
        /// details and examples, refer to [this documentation](https://argocd-notifications.readthedocs.io/en/stable/).
        /// </summary>
        public InputMap<string> ArgocdNotificationsCm
        {
            get => _argocdNotificationsCm ?? (_argocdNotificationsCm = new InputMap<string>());
            set => _argocdNotificationsCm = value;
        }

        [Input("argocdNotificationsSecret")]
        private InputMap<string>? _argocdNotificationsSecret;

        /// <summary>
        /// contains sensitive data of Argo CD notifications, and it is aligned with `argocd-notifications-secret` Secret of Argo
        /// CD, for more details and examples, refer to [this
        /// documentation](https://argocd-notifications.readthedocs.io/en/stable/services/overview/#sensitive-data).
        /// </summary>
        public InputMap<string> ArgocdNotificationsSecret
        {
            get => _argocdNotificationsSecret ?? (_argocdNotificationsSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _argocdNotificationsSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("argocdRbacCm")]
        private InputMap<string>? _argocdRbacCm;

        /// <summary>
        /// is aligned with the options in `argocd-rbac-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-rbac-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdRbacCm
        {
            get => _argocdRbacCm ?? (_argocdRbacCm = new InputMap<string>());
            set => _argocdRbacCm = value;
        }

        [Input("argocdSecret")]
        private InputMap<string>? _argocdSecret;

        /// <summary>
        /// is aligned with the options in `argocd-secret` Secret as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-secret-yaml/).
        /// </summary>
        public InputMap<string> ArgocdSecret
        {
            get => _argocdSecret ?? (_argocdSecret = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _argocdSecret = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("argocdSshKnownHostsCm")]
        private InputMap<string>? _argocdSshKnownHostsCm;

        /// <summary>
        /// is aligned with the options in `argocd-ssh-known-hosts-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-ssh-known-hosts-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdSshKnownHostsCm
        {
            get => _argocdSshKnownHostsCm ?? (_argocdSshKnownHostsCm = new InputMap<string>());
            set => _argocdSshKnownHostsCm = value;
        }

        [Input("argocdTlsCertsCm")]
        private InputMap<string>? _argocdTlsCertsCm;

        /// <summary>
        /// is aligned with the options in `argocd-tls-certs-cm` ConfigMap as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-tls-certs-cm-yaml/).
        /// </summary>
        public InputMap<string> ArgocdTlsCertsCm
        {
            get => _argocdTlsCertsCm ?? (_argocdTlsCertsCm = new InputMap<string>());
            set => _argocdTlsCertsCm = value;
        }

        [Input("configManagementPlugins")]
        private InputMap<Inputs.InstanceConfigManagementPluginsGetArgs>? _configManagementPlugins;

        /// <summary>
        /// is a map of [Config Management
        /// Plugins](https://argo-cd.readthedocs.io/en/stable/operator-manual/config-management-plugins/#config-management-plugins),
        /// the key of map entry is the `name` of the plugin, and the value is the definition of the Config Management Plugin(v2).
        /// </summary>
        public InputMap<Inputs.InstanceConfigManagementPluginsGetArgs> ConfigManagementPlugins
        {
            get => _configManagementPlugins ?? (_configManagementPlugins = new InputMap<Inputs.InstanceConfigManagementPluginsGetArgs>());
            set => _configManagementPlugins = value;
        }

        /// <summary>
        /// Instance name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("repoCredentialSecrets")]
        private InputMap<ImmutableDictionary<string, string>>? _repoCredentialSecrets;

        /// <summary>
        /// is a map of repo credential secrets, the key of map entry is the `name` of the secret, and the value is the aligned with
        /// options in `argocd-repositories.yaml.data` as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-repositories-yaml/).
        /// </summary>
        public InputMap<ImmutableDictionary<string, string>> RepoCredentialSecrets
        {
            get => _repoCredentialSecrets ?? (_repoCredentialSecrets = new InputMap<ImmutableDictionary<string, string>>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, ImmutableDictionary<string, string>>());
                _repoCredentialSecrets = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("repoTemplateCredentialSecrets")]
        private InputMap<ImmutableDictionary<string, string>>? _repoTemplateCredentialSecrets;

        /// <summary>
        /// is a map of repository credential templates secrets, the key of map entry is the `name` of the secret, and the value is
        /// the aligned with options in `argocd-repo-creds.yaml.data` as described in the [ArgoCD Atomic
        /// Configuration](https://argo-cd.readthedocs.io/en/stable/operator-manual/declarative-setup/#atomic-configuration). For a
        /// concrete example, refer to [this
        /// documentation](https://argo-cd.readthedocs.io/en/stable/operator-manual/argocd-repo-creds.yaml/).
        /// </summary>
        public InputMap<ImmutableDictionary<string, string>> RepoTemplateCredentialSecrets
        {
            get => _repoTemplateCredentialSecrets ?? (_repoTemplateCredentialSecrets = new InputMap<ImmutableDictionary<string, string>>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, ImmutableDictionary<string, string>>());
                _repoTemplateCredentialSecrets = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        public InstanceState()
        {
        }
        public static new InstanceState Empty => new InstanceState();
    }
}
