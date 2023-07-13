using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;

var baseJob = Job.ShortRun
    .WithLaunchCount(1)
    .WithWarmupCount(1)
    .WithIterationCount(1)
    .WithIterationTime(TimeInterval.FromMilliseconds(200));

var config = DefaultConfig.Instance
    .AddJob(baseJob.WithRuntime(CoreRuntime.Core60))
    .AddJob(baseJob.WithRuntime(CoreRuntime.Core80))
    .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByMethod)
    .AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(maxDepth: 10, exportCombinedDisassemblyReport: true, printSource: true)))
    .AddFilter(new Filter())
    ;

BenchmarkSwitcher.FromAssemblies(new[] {
    typeof(Old.BenchV3).Assembly,
    typeof(New.BenchV3).Assembly,
}).RunAllJoined(config);

class Filter : IFilter
{
    public bool Predicate(BenchmarkCase benchmarkCase)
    {
        return true;
        //return benchmarkCase.Descriptor.WorkloadMethod.Name.Contains("Add");
    }
}
