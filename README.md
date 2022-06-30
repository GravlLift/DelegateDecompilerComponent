## DelegateDecompiler Reproduction

This repository reproduces [an issue](https://github.com/hazzik/DelegateDecompiler/issues/15) on the DelegateDecompiler project where tests will fail only when gathering unit test coverage.

## Instructions

To run tests successfully, run:
```
dotnet test
```

To reproduce issue (and fail `Run_decompiled_query` test despite no changes to code):
```
dotnet test --collect:"Code Coverage"
```