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
    public sealed class GetInstanceConfigManagementPluginsSpecInitResult
    {
        /// <summary>
        /// Arguments of the command
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// Command
        /// </summary>
        public readonly ImmutableArray<string> Commands;

        [OutputConstructor]
        private GetInstanceConfigManagementPluginsSpecInitResult(
            ImmutableArray<string> args,

            ImmutableArray<string> commands)
        {
            Args = args;
            Commands = commands;
        }
    }
}
