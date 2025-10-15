﻿using System.Net.Security;
using Kafka.Consumer.Console;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
{
    services.AddHostedService<ConsumerService>();
}).Build();

await host.RunAsync();
















