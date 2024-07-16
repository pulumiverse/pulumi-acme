// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Acme.Outputs
{

    [OutputType]
    public sealed class CertificateHttpS3Challenge
    {
        /// <summary>
        /// The s3_bucket to publish the record to.
        /// </summary>
        public readonly string S3Bucket;

        [OutputConstructor]
        private CertificateHttpS3Challenge(string s3Bucket)
        {
            S3Bucket = s3Bucket;
        }
    }
}
