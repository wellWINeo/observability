using BenchmarkDotNet.Running;
using LoggingBenchmark;

//var summary = BenchmarkRunner.Run<LoggingBenchMark>();
BenchmarkRunner.Run<LoggingStringInterpolation>();