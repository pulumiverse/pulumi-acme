// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Acme.Inputs
{

    public sealed class CertificateDnsChallengeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("config")]
        private InputMap<string>? _config;
        public InputMap<string> Config
        {
            get => _config ?? (_config = new InputMap<string>());
            set
            {
                var emptySecret = Output.CreateSecret(ImmutableDictionary.Create<string, string>());
                _config = Output.All(value, emptySecret).Apply(v => v[0]);
            }
        }

        [Input("provider", required: true)]
        public Input<string> Provider { get; set; } = null!;

        public CertificateDnsChallengeGetArgs()
        {
        }
        public static new CertificateDnsChallengeGetArgs Empty => new CertificateDnsChallengeGetArgs();
    }
}
