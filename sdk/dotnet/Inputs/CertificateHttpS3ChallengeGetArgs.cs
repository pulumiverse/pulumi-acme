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

    public sealed class CertificateHttpS3ChallengeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("s3Bucket", required: true)]
        public Input<string> S3Bucket { get; set; } = null!;

        public CertificateHttpS3ChallengeGetArgs()
        {
        }
        public static new CertificateHttpS3ChallengeGetArgs Empty => new CertificateHttpS3ChallengeGetArgs();
    }
}