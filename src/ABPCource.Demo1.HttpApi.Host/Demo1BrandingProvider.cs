﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPCource.Demo1;

[Dependency(ReplaceServices = true)]
public class Demo1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Demo1";
}
