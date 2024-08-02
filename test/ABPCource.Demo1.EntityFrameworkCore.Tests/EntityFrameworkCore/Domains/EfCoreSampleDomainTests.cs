using ABPCource.Demo1.Samples;
using Xunit;

namespace ABPCource.Demo1.EntityFrameworkCore.Domains;

[Collection(Demo1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Demo1EntityFrameworkCoreTestModule>
{

}
