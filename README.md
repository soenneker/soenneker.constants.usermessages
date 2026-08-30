[![](https://img.shields.io/nuget/v/soenneker.constants.usermessages.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.constants.usermessages/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.usermessages/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.constants.usermessages/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.constants.usermessages.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.constants.usermessages/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.constants.usermessages/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.constants.usermessages/actions/workflows/codeql.yml)

# Soenneker.Constants.UserMessages

Provides neutral English title/detail pairs for common request failures.

## Install

```bash
dotnet add package Soenneker.Constants.UserMessages
```

## Messages

| Scenario | Title | Detail |
| --- | --- | --- |
| Unexpected failure | `Something went wrong` | `We couldn't complete your request. Please try again.` |
| Cancellation | `Request canceled` | `The request was canceled before it could complete.` |
| Timeout | `Request timeout` | `The request took too long to complete.` |

## Usage

```csharp
using Soenneker.Constants.UserMessages;

return OperationResult.Fail(
    UserMessages.TimeoutTitle,
    UserMessages.TimeoutDetail);
```

The messages are intentionally generic and do not expose exception text or implementation details. Keep diagnostic information in server-side logs rather than appending it to these user-facing values.

These constants are English-only and are not a localization system. Applications with localized UI should map the failure scenarios to their own resources.

Because these are compile-time constants, their values are embedded into consuming assemblies. Rebuild consumers after upgrading if message text changes.
