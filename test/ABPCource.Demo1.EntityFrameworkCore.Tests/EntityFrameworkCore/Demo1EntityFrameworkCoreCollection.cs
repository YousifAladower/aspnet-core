﻿using Xunit;

namespace ABPCource.Demo1.EntityFrameworkCore;

[CollectionDefinition(Demo1TestConsts.CollectionDefinitionName)]
public class Demo1EntityFrameworkCoreCollection : ICollectionFixture<Demo1EntityFrameworkCoreFixture>
{

}
