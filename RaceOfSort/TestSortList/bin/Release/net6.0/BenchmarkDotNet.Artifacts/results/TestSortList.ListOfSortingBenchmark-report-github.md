``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
AMD Ryzen 9 5900HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT


```
|                Method |       Mean |    Error |   StdDev | Rank | Allocated |
|---------------------- |-----------:|---------:|---------:|-----:|----------:|
|         TestSerialMul | 3,120.2 ms | 55.35 ms | 49.07 ms |    2 |     384 B |
| TestParallelMulThread |   484.8 ms |  9.69 ms | 16.46 ms |    1 |   2,456 B |
|   TestParallelMulTask |   475.2 ms |  9.38 ms | 17.15 ms |    1 |   4,488 B |
