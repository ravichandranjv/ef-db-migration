using Amazon.CDK;
using CdkTipsTricks.lib;
using CdkTipsTricks.stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
namespace CdkTipsTricks
{
    sealed class Program
    {
        static Amazon.CDK.Environment makeEnv(string account = null, string region = null)
        {
            return new Amazon.CDK.Environment
            {
                Account = account ?? System.Environment.GetEnvironmentVariable("CDK_DEFAULT_ACCOUNT"),
                Region = region ?? System.Environment.GetEnvironmentVariable("CDK_DEFAULT_REGION"),
            };
        }
        static Amazon.CDK.Environment makeEnv1(string account = null, string region = null)
        {
            return new Amazon.CDK.Environment
            {
                Account = account ?? System.Environment.GetEnvironmentVariable("CDK_DEFAULT_ACCOUNT"),
                Region = "ap-south-1",
            };
        }
        public static void Main(string[] args)
        {
            var app = new App();
            #region Initialize environment

            var envIN = makeEnv(account: "069623884547", region: "ap-south-1");

            #endregion
            new S3Stack(app, "CdkTipsTricksStack", new cdk_tipsntricks_S3BucketStackProps("cdk-tips-tricks")
            {
                /*
                Env = new Amazon.CDK.Environment
                {
                    Account = "123456789012",
                    Region = "us-east-1",
                }
                */
            });
            app.Synth();
        }
    }
}
