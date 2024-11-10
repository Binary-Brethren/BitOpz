#region

using System;
using BitOpz.Core.Extensions;
using BitOpz.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

#endregion

namespace BitOpz.Core.Tests.IntegrationTests;

public class BitWizerIntegrationTests
{
    private IServiceCollection _services;
    private IServiceProvider _provider;

    private void ConfigureServices()
    {
        _services = new ServiceCollection();
        Assert.NotNull(_services);

        _services.ConfigureBitWizerServices();
        Assert.Contains(_services, x => x.ServiceType == typeof(IBitWizer));

        _provider = _services.BuildServiceProvider();
        Assert.NotNull(_provider);
    }

    [Fact]
    public void TestBitWizerServiceInjection()
    {
        ConfigureServices();
        Assert.Single(_provider.GetServices<IBitWizer>(), x => x.GetType() == typeof(BitWizer));
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void TestBitWizerConstruction(bool isInjected)
    {
        if (isInjected)
        {
            ConfigureServices();
            var injected = _provider.GetRequiredService<IBitWizer>() as BitWizer;
            Assert.NotNull(injected);
            Assert.Empty(injected.GetHistory());
        }
        else
        {
            var direct = new BitWizer();
            Assert.NotNull(direct);
            Assert.Empty(direct.GetHistory());
        }
    }
}
