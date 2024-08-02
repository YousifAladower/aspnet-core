using ABPCource.Demo1.Samples;
using Xunit;

namespace ABPCource.Demo1.EntityFrameworkCore.Applications;

[Collection(Demo1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Demo1EntityFrameworkCoreTestModule>
{

}
