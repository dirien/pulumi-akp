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

    public sealed class InstanceConfigManagementPluginsSpecGenerateArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Arguments of the command
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("commands", required: true)]
        private InputList<string>? _commands;

        /// <summary>
        /// Command
        /// </summary>
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        public InstanceConfigManagementPluginsSpecGenerateArgs()
        {
        }
        public static new InstanceConfigManagementPluginsSpecGenerateArgs Empty => new InstanceConfigManagementPluginsSpecGenerateArgs();
    }
}
