using System;
using System.Collections.Generic;
using System.Text;
using Amazon.CDK;
using Amazon.CDK.AWS.S3;
using CdkTipsTricks.lib;

namespace CdkTipsTricks.stacks
{
    // S3 bucket with lifecycle rules, replication rules, bucket policy, bucket versioning, tags,
    // default encryption, Intelligent-Tiering Archive configurations, Event notifications,
    // Static website hosting, and inventory configurations
    public class S3Stack : Stack
    {
        public S3Stack(Construct scope, string id, cdk_tipsntricks_S3BucketStackProps props) : base(scope, id, props)
        {
            // Main bucket
            props.bucketProps.cfnBucket = new CfnBucket(this, id, props.bucketProps)
            {
                //BucketName = props.bucketProps.mainBucketname,
                //BucketEncryption = props.bucketProps.mainBucketEncryption,
                //Versioned = props.bucketProps.isMainBucketVersioned,
                //BucketKeyEnabled = props.bucketProps.enableMainBucketKey,                
            };
        }
    }
}
