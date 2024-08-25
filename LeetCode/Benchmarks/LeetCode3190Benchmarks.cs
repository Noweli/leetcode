using BenchmarkDotNet.Attributes;

namespace LeetCode.Benchmarks;

[MemoryDiagnoser]
public class LeetCode3190Benchmarks
{
    private int[] _inputIntegers = Enumerable.Range(1, 50_000_000).ToArray();
    
    [Benchmark(Baseline = true)]
    public int Count()
    {
        return LeetCode3190.MinimumOperationsCount(_inputIntegers);
    }

    [Benchmark]
    public int WhereNoParallel()
    {
        return LeetCode3190.MinimumOperationsWhere(_inputIntegers);
    }

    [Benchmark]
    public int WhereWithAsParallel()
    {
        return LeetCode3190.MinimumOperationsAsParallel(_inputIntegers);
    }

    /*
    | Method              | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0     | Gen1     | Gen2     | Allocated     | Alloc Ratio  |
    |-------------------- |---------:|---------:|---------:|------:|--------:|---------:|---------:|---------:|--------------:|-------------:|
    | Count               | 53.72 ms | 0.330 ms | 0.293 ms |  1.00 |    0.01 |        - |        - |        - |          89 B |         1.00 |
    | WhereNoParallel     | 61.99 ms | 1.215 ms | 1.137 ms |  1.15 |    0.02 | 285.7143 | 285.7143 | 285.7143 | 267_552_454 B | 3,006,207.35 |
    | WhereWithAsParallel | 43.31 ms | 0.796 ms | 1.062 ms |  0.81 |    0.02 | 909.0909 | 818.1818 | 818.1818 | 535_999_729 B | 6,022,468.87 |
    */
     
}