
# `sln` Command

Gets an information about specified solution and its projects.

## Synopsis

```
roslynator sln <SOLUTION>
[--ignored-projects]
[--language]
[--file-log]
[--file-log-verbosity]
[--msbuild-path]
[--projects]
[-p|--properties]
[-v|--verbosity]
```

## Arguments

**`SOLUTION`**

The solution to open.

### Optional Options

**`--ignored-projects`**

Defines project names that should not be fixed.

**`--language`** `{cs[harp]|v[isual-]b[asic])}`

Defines project language.

**`--msbuild-path`**

Defines a path to MSBuild.

*Note: First found instance of MSBuild will be used if the path to MSBuild is not specified.*

**`--projects`**

Defines projects that should be analyzed.

**`-p|--properties`** `<NAME=VALUE>`

Defines one or more MSBuild properties.

**`-v|--verbosity`** `{q[uiet]|m[inimal]|n[ormal]|d[etailed]|diag[nostic]}`

Defines the amount of information to display in the log.

## See Also

* [Roslynator Command-Line Interface](README.md)