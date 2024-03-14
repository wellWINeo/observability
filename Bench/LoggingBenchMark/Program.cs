using BenchmarkDotNet.Running;
using LoggingBenchmark;
using LoggingBenchmark.Benchmarks;

//var summary = BenchmarkRunner.Run<LoggingBenchMark>();
//BenchmarkRunner.Run<LoggingStringInterpolation>();
BenchmarkRunner.Run<LogDestinationBenchMark>();