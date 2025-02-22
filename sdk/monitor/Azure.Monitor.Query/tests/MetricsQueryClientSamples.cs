﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Monitor.Query.Models;
using NUnit.Framework;

namespace Azure.Monitor.Query.Tests
{
    public class MetricsQueryClientSamples: SamplesBase<MonitorQueryTestEnvironment>
    {
        [Test]
        [Ignore("https://github.com/Azure/azure-sdk-for-net/issues/21657")]
        public async Task QueryMetrics()
        {
            #region Snippet:QueryMetrics

#if SNIPPET
            string resourceId =
                "/subscriptions/<subscription_id>/resourceGroups/<resource_group_name>/providers/<resource_provider>/<resource>";
#else
            string resourceId = TestEnvironment.MetricsResource;
#endif

            #region Snippet:CreateMetricsClient
            var metricsClient = new MetricsQueryClient(new DefaultAzureCredential());
            #endregion

            Response<MetricsQueryResult> results = await metricsClient.QueryResourceAsync(
                resourceId,
                new[] {"Microsoft.OperationalInsights/workspaces"}
            );

            foreach (var metric in results.Value.Metrics)
            {
                Console.WriteLine(metric.Name);
                foreach (var element in metric.TimeSeries)
                {
                    Console.WriteLine("Dimensions: " + string.Join(",", element.Metadata));

                    foreach (var metricValue in element.Values)
                    {
                        Console.WriteLine(metricValue);
                    }
                }
            }
            #endregion
        }
    }
}
