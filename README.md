<h1 align="center">PKGS</h1>

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

Template Package

## Setup


### Requirement
- Unity 6000.0 or higher


### Install

1. Open the Package Manager from Window > Package Manager
2. "+" button > Add package from git URL
3. Enter the following to install

    * https://github.com/minnleee/pkg.git?path=Assets/OtherPkg (first)
    * https://github.com/minnleee/pkg.git?path=Assets/Pkg (has dependencies)
    * ![alt text](./Assets/Images/pkg-manager.png)

Or, open Packages/manifest.json and add the following to the dependencies block.

```json
{
    "dependencies": {
        "com.minn.other.pkg": "https://github.com/minnleee/pkg.git?path=Assets/OtherPkg",
        "com.minn.pkg": "https://github.com/minnleee/pkg.git?path=Assets/Pkg"
    }
}
```

If you want to set the target version, specify it like follow.
* https://github.com/minnleee/pkg.git?path=Assets/Pkg#1.0.0


## Publish 'Other Package'

Publish to a scoped registry (like npm or OpenUPM)

This lets you resolve dependencies by version. It's more complex but works perfectly.

- https://openupm.com

- Host your own npm-compatible registry (e.g., Verdaccio)

- Push Unity packages using ```npm publish```

Then your package.json can truly resolve other packages by name/version, no manual manifest edits.