// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Acme
{
    [AcmeResourceType("acme:index/certificate:Certificate")]
    public partial class Certificate : global::Pulumi.CustomResource
    {
        [Output("accountKeyPem")]
        public Output<string> AccountKeyPem { get; private set; } = null!;

        [Output("certificateDomain")]
        public Output<string> CertificateDomain { get; private set; } = null!;

        [Output("certificateNotAfter")]
        public Output<string> CertificateNotAfter { get; private set; } = null!;

        [Output("certificateP12")]
        public Output<string> CertificateP12 { get; private set; } = null!;

        [Output("certificateP12Password")]
        public Output<string?> CertificateP12Password { get; private set; } = null!;

        [Output("certificatePem")]
        public Output<string> CertificatePem { get; private set; } = null!;

        [Output("certificateRequestPem")]
        public Output<string?> CertificateRequestPem { get; private set; } = null!;

        [Output("certificateUrl")]
        public Output<string> CertificateUrl { get; private set; } = null!;

        [Output("commonName")]
        public Output<string?> CommonName { get; private set; } = null!;

        [Output("disableCompletePropagation")]
        public Output<bool?> DisableCompletePropagation { get; private set; } = null!;

        [Output("dnsChallenges")]
        public Output<ImmutableArray<Outputs.CertificateDnsChallenge>> DnsChallenges { get; private set; } = null!;

        [Output("httpChallenge")]
        public Output<Outputs.CertificateHttpChallenge?> HttpChallenge { get; private set; } = null!;

        [Output("httpMemcachedChallenge")]
        public Output<Outputs.CertificateHttpMemcachedChallenge?> HttpMemcachedChallenge { get; private set; } = null!;

        [Output("httpWebrootChallenge")]
        public Output<Outputs.CertificateHttpWebrootChallenge?> HttpWebrootChallenge { get; private set; } = null!;

        [Output("issuerPem")]
        public Output<string> IssuerPem { get; private set; } = null!;

        [Output("keyType")]
        public Output<string?> KeyType { get; private set; } = null!;

        [Output("minDaysRemaining")]
        public Output<int?> MinDaysRemaining { get; private set; } = null!;

        [Output("mustStaple")]
        public Output<bool?> MustStaple { get; private set; } = null!;

        [Output("preCheckDelay")]
        public Output<int?> PreCheckDelay { get; private set; } = null!;

        [Output("preferredChain")]
        public Output<string?> PreferredChain { get; private set; } = null!;

        [Output("privateKeyPem")]
        public Output<string> PrivateKeyPem { get; private set; } = null!;

        [Output("recursiveNameservers")]
        public Output<ImmutableArray<string>> RecursiveNameservers { get; private set; } = null!;

        [Output("revokeCertificateOnDestroy")]
        public Output<bool?> RevokeCertificateOnDestroy { get; private set; } = null!;

        [Output("subjectAlternativeNames")]
        public Output<ImmutableArray<string>> SubjectAlternativeNames { get; private set; } = null!;

        [Output("tlsChallenge")]
        public Output<Outputs.CertificateTlsChallenge?> TlsChallenge { get; private set; } = null!;


        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs args, CustomResourceOptions? options = null)
            : base("acme:index/certificate:Certificate", name, args ?? new CertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Certificate(string name, Input<string> id, CertificateState? state = null, CustomResourceOptions? options = null)
            : base("acme:index/certificate:Certificate", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CertificateState? state = null, CustomResourceOptions? options = null)
        {
            return new Certificate(name, id, state, options);
        }
    }

    public sealed class CertificateArgs : global::Pulumi.ResourceArgs
    {
        [Input("accountKeyPem", required: true)]
        public Input<string> AccountKeyPem { get; set; } = null!;

        [Input("certificateP12Password")]
        public Input<string>? CertificateP12Password { get; set; }

        [Input("certificateRequestPem")]
        public Input<string>? CertificateRequestPem { get; set; }

        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        [Input("disableCompletePropagation")]
        public Input<bool>? DisableCompletePropagation { get; set; }

        [Input("dnsChallenges")]
        private InputList<Inputs.CertificateDnsChallengeArgs>? _dnsChallenges;
        public InputList<Inputs.CertificateDnsChallengeArgs> DnsChallenges
        {
            get => _dnsChallenges ?? (_dnsChallenges = new InputList<Inputs.CertificateDnsChallengeArgs>());
            set => _dnsChallenges = value;
        }

        [Input("httpChallenge")]
        public Input<Inputs.CertificateHttpChallengeArgs>? HttpChallenge { get; set; }

        [Input("httpMemcachedChallenge")]
        public Input<Inputs.CertificateHttpMemcachedChallengeArgs>? HttpMemcachedChallenge { get; set; }

        [Input("httpWebrootChallenge")]
        public Input<Inputs.CertificateHttpWebrootChallengeArgs>? HttpWebrootChallenge { get; set; }

        [Input("keyType")]
        public Input<string>? KeyType { get; set; }

        [Input("minDaysRemaining")]
        public Input<int>? MinDaysRemaining { get; set; }

        [Input("mustStaple")]
        public Input<bool>? MustStaple { get; set; }

        [Input("preCheckDelay")]
        public Input<int>? PreCheckDelay { get; set; }

        [Input("preferredChain")]
        public Input<string>? PreferredChain { get; set; }

        [Input("recursiveNameservers")]
        private InputList<string>? _recursiveNameservers;
        public InputList<string> RecursiveNameservers
        {
            get => _recursiveNameservers ?? (_recursiveNameservers = new InputList<string>());
            set => _recursiveNameservers = value;
        }

        [Input("revokeCertificateOnDestroy")]
        public Input<bool>? RevokeCertificateOnDestroy { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        [Input("tlsChallenge")]
        public Input<Inputs.CertificateTlsChallengeArgs>? TlsChallenge { get; set; }

        public CertificateArgs()
        {
        }
        public static new CertificateArgs Empty => new CertificateArgs();
    }

    public sealed class CertificateState : global::Pulumi.ResourceArgs
    {
        [Input("accountKeyPem")]
        public Input<string>? AccountKeyPem { get; set; }

        [Input("certificateDomain")]
        public Input<string>? CertificateDomain { get; set; }

        [Input("certificateNotAfter")]
        public Input<string>? CertificateNotAfter { get; set; }

        [Input("certificateP12")]
        public Input<string>? CertificateP12 { get; set; }

        [Input("certificateP12Password")]
        public Input<string>? CertificateP12Password { get; set; }

        [Input("certificatePem")]
        public Input<string>? CertificatePem { get; set; }

        [Input("certificateRequestPem")]
        public Input<string>? CertificateRequestPem { get; set; }

        [Input("certificateUrl")]
        public Input<string>? CertificateUrl { get; set; }

        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        [Input("disableCompletePropagation")]
        public Input<bool>? DisableCompletePropagation { get; set; }

        [Input("dnsChallenges")]
        private InputList<Inputs.CertificateDnsChallengeGetArgs>? _dnsChallenges;
        public InputList<Inputs.CertificateDnsChallengeGetArgs> DnsChallenges
        {
            get => _dnsChallenges ?? (_dnsChallenges = new InputList<Inputs.CertificateDnsChallengeGetArgs>());
            set => _dnsChallenges = value;
        }

        [Input("httpChallenge")]
        public Input<Inputs.CertificateHttpChallengeGetArgs>? HttpChallenge { get; set; }

        [Input("httpMemcachedChallenge")]
        public Input<Inputs.CertificateHttpMemcachedChallengeGetArgs>? HttpMemcachedChallenge { get; set; }

        [Input("httpWebrootChallenge")]
        public Input<Inputs.CertificateHttpWebrootChallengeGetArgs>? HttpWebrootChallenge { get; set; }

        [Input("issuerPem")]
        public Input<string>? IssuerPem { get; set; }

        [Input("keyType")]
        public Input<string>? KeyType { get; set; }

        [Input("minDaysRemaining")]
        public Input<int>? MinDaysRemaining { get; set; }

        [Input("mustStaple")]
        public Input<bool>? MustStaple { get; set; }

        [Input("preCheckDelay")]
        public Input<int>? PreCheckDelay { get; set; }

        [Input("preferredChain")]
        public Input<string>? PreferredChain { get; set; }

        [Input("privateKeyPem")]
        public Input<string>? PrivateKeyPem { get; set; }

        [Input("recursiveNameservers")]
        private InputList<string>? _recursiveNameservers;
        public InputList<string> RecursiveNameservers
        {
            get => _recursiveNameservers ?? (_recursiveNameservers = new InputList<string>());
            set => _recursiveNameservers = value;
        }

        [Input("revokeCertificateOnDestroy")]
        public Input<bool>? RevokeCertificateOnDestroy { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        [Input("tlsChallenge")]
        public Input<Inputs.CertificateTlsChallengeGetArgs>? TlsChallenge { get; set; }

        public CertificateState()
        {
        }
        public static new CertificateState Empty => new CertificateState();
    }
}