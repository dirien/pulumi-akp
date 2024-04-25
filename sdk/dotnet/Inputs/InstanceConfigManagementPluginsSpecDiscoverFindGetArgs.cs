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

    public sealed class InstanceConfigManagementPluginsSpecDiscoverFindGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Arguments for the find command
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("commands")]
        private InputList<string>? _commands;

        /// <summary>
        /// The find command runs in the repository's root directory. To match, it must exit with status code 0 and produce non-empty output to standard out.
        /// </summary>
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        /// <summary>
        /// This does the same thing as `file_name`, but it supports double-start (nested directory) glob patterns.
        /// </summary>
        [Input("glob")]
        public Input<string>? Glob { get; set; }

        public InstanceConfigManagementPluginsSpecDiscoverFindGetArgs()
        {
        }
        public static new InstanceConfigManagementPluginsSpecDiscoverFindGetArgs Empty => new InstanceConfigManagementPluginsSpecDiscoverFindGetArgs();
    }
}
