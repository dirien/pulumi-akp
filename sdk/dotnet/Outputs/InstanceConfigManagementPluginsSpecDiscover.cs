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
    public sealed class InstanceConfigManagementPluginsSpecDiscover
    {
        /// <summary>
        /// A glob pattern (https://pkg.go.dev/path/filepath#Glob) that is applied to the Application's source directory. If there is a match, this plugin may be used for the Application.
        /// </summary>
        public readonly string? FileName;
        /// <summary>
        /// Find config
        /// </summary>
        public readonly Outputs.InstanceConfigManagementPluginsSpecDiscoverFind? Find;

        [OutputConstructor]
        private InstanceConfigManagementPluginsSpecDiscover(
            string? fileName,

            Outputs.InstanceConfigManagementPluginsSpecDiscoverFind? find)
        {
            FileName = fileName;
            Find = find;
        }
    }
}
