# Disease Prediction Application

> [!WARNING]
> **Archived educational project — not a medical device and not suitable for deployment.**
> Do not use this application for diagnosis, treatment, or health decisions.

## Purpose

This project was an early ASP.NET learning exercise for building a web interface that maps entered symptoms to stored disease information. It also includes administration screens for maintaining application records.

## Technology

- ASP.NET Web Forms and C#
- .NET Framework 4.0
- Entity Framework model files
- Microsoft SQL Server
- HTML, CSS, JavaScript, and Bootstrap

## Current status

- Educational/legacy code from an earlier learning phase
- Not part of the owner's current technology focus
- Not deployed and does not contain real patient data
- Unmaintained; .NET Framework 4.0 and several project dependencies are obsolete
- No clinical validation, accuracy evidence, or regulatory review is provided

## Known security and safety limitations

- The original committed configuration contained a predictable cleartext administrator credential; it has been removed
- Debug compilation was enabled and has been disabled in the archival configuration
- Authentication and authorization do not meet current application-security expectations
- Generated `bin/` and `obj/` build outputs are excluded from the repository; regenerate them locally with a compatible toolchain
- The prediction logic must not be interpreted as medical advice

## Running locally

Local execution would require a compatible Windows/.NET Framework development environment and a separately configured SQL Server database. No production deployment instructions are provided because this code is retained for reference only.

## If rebuilding this idea

Create a new application on a supported platform. Begin with a threat model, privacy requirements, secure identity, least-privilege data access, encrypted configuration, audit logging, and qualified medical/product review. Use clearly sourced and validated datasets, and present results only as educational information with appropriate professional oversight.

## Archival recommendation

Keep this repository archived and unpinned. It documents an older exercise but should not represent a current production or healthcare capability.
