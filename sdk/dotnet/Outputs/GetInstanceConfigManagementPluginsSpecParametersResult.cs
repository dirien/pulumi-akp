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
    public sealed class GetInstanceConfigManagementPluginsSpecParametersResult
    {
        /// <summary>
        /// Dynamic parameter announcements are announcements specific to an Application handled by this plugin. For example, the values for a Helm chart's values.yaml file could be sent as parameter announcements.
        /// </summary>
        public readonly Outputs.GetInstanceConfigManagementPluginsSpecParametersDynamicResult Dynamic;
        /// <summary>
        /// Static parameter announcements are sent to the UI for all Applications handled by this plugin. Think of the `string`, `array`, and `map` values set here as defaults. It is up to the plugin author to make sure that these default values actually reflect the plugin's behavior if the user doesn't explicitly set different values for those parameters.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceConfigManagementPluginsSpecParametersStaticResult> Statics;

        [OutputConstructor]
        private GetInstanceConfigManagementPluginsSpecParametersResult(
            Outputs.GetInstanceConfigManagementPluginsSpecParametersDynamicResult dynamic,

            ImmutableArray<Outputs.GetInstanceConfigManagementPluginsSpecParametersStaticResult> statics)
        {
            Dynamic = dynamic;
            Statics = statics;
        }
    }
}
