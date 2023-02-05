using System;
using System.Collections.Generic;
using System.Text;
using Amazon.CDK;
using Amazon.JSII.Runtime.Deputy;
using Amazon.CDK.AWS.S3;
using Amazon.CDK.AWS.IAM;
using Amazon.CDK.AWS.Events;

namespace CdkTipsTricks.lib
{
    // S3 bucket with lifecycle rules, replication rules, bucket policy, bucket versioning, tags,
    // default encryption, Intelligent-Tiering Archive configurations, Event notifications,
    // Static website hosting, and inventory configurations
    public class cdk_tipsntricks_S3BucketProps : DeputyBase, ICfnBucketProps, IBucket
    {
        /// <summary>
        /// AWS CDK S3 Bucket
        /// </summary>
        ///       
        public CfnBucket cfnBucket { get; set; }
        public Bucket bucket { get; set; }
        public IBucket iBucket { get; set; }

        public string BucketArn => throw new NotImplementedException();

        public string BucketDomainName => throw new NotImplementedException();

        public string BucketDualStackDomainName => throw new NotImplementedException();

        public string BucketName { get;set;}

        public string BucketRegionalDomainName => throw new NotImplementedException();

        public string BucketWebsiteDomainName => throw new NotImplementedException();

        public string BucketWebsiteUrl => throw new NotImplementedException();

        public IResourceEnvironment Env => throw new NotImplementedException();

        public Stack Stack => throw new NotImplementedException();

        public ConstructNode Node => throw new NotImplementedException();

        public string mainBucketname;

        public void AddEventNotification(EventType @event, IBucketNotificationDestination dest, params INotificationKeyFilter[] filters)
        {
            throw new NotImplementedException();
        }

        public void AddObjectCreatedNotification(IBucketNotificationDestination dest, params INotificationKeyFilter[] filters)
        {
            throw new NotImplementedException();
        }

        public void AddObjectRemovedNotification(IBucketNotificationDestination dest, params INotificationKeyFilter[] filters)
        {
            throw new NotImplementedException();
        }

        public IAddToResourcePolicyResult AddToResourcePolicy(PolicyStatement permission)
        {
            throw new NotImplementedException();
        }

        public string ArnForObjects(string keyPattern)
        {
            throw new NotImplementedException();
        }

        public Grant GrantDelete(IGrantable identity, object objectsKeyPattern = null)
        {
            throw new NotImplementedException();
        }

        public Grant GrantPublicAccess(string keyPrefix = null, params string[] allowedActions)
        {
            throw new NotImplementedException();
        }

        public Grant GrantPut(IGrantable identity, object objectsKeyPattern = null)
        {
            throw new NotImplementedException();
        }

        public Grant GrantPutAcl(IGrantable identity, string objectsKeyPattern = null)
        {
            throw new NotImplementedException();
        }

        public Grant GrantRead(IGrantable identity, object objectsKeyPattern = null)
        {
            throw new NotImplementedException();
        }

        public Grant GrantReadWrite(IGrantable identity, object objectsKeyPattern = null)
        {
            throw new NotImplementedException();
        }

        public Grant GrantWrite(IGrantable identity, object objectsKeyPattern = null)
        {
            throw new NotImplementedException();
        }

        public Rule OnCloudTrailEvent(string id, IOnCloudTrailBucketEventOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Rule OnCloudTrailPutObject(string id, IOnCloudTrailBucketEventOptions options = null)
        {
            throw new NotImplementedException();
        }

        public Rule OnCloudTrailWriteObject(string id, IOnCloudTrailBucketEventOptions options = null)
        {
            throw new NotImplementedException();
        }

        public string S3UrlForObject(string key = null)
        {
            throw new NotImplementedException();
        }

        public string TransferAccelerationUrlForObject(string key = null, ITransferAccelerationUrlOptions options = null)
        {
            throw new NotImplementedException();
        }

        public string UrlForObject(string key = null)
        {
            throw new NotImplementedException();
        }

        public string VirtualHostedUrlForObject(string key = null, IVirtualHostedStyleUrlOptions options = null)
        {
            throw new NotImplementedException();
        }

        public void ApplyRemovalPolicy(RemovalPolicy policy)
        {
            throw new NotImplementedException();
        }
    }
    public class cdk_tipsntricks_S3BucketStackProps : StackProps
    {
        public cdk_tipsntricks_S3BucketProps bucketProps { get; set; }
        public cdk_tipsntricks_S3BucketStackProps(string bucketName)
        {
            this.bucketProps = new cdk_tipsntricks_S3BucketProps();
            this.bucketProps.BucketName = bucketName;
        }
    }
}
