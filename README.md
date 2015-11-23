.NET Core Example
=================

This is a project for demoing .NET on OS X and Linux.

All this stuff is highly experimental. To get to this point
I followed the getting started guide for .NET Core, as well
as a getting started guide for Entity Framework 7 and ASP.NET 5.

### Links that helped me
- Getting started with .NET core:
https://dotnet.github.io/getting-started/

- Getting started with EntityFramework7
https://ef.readthedocs.org/en/latest/getting-started/osx.html

You might also have to read some source.

### Issues I had
When creating a migration, something happens with a missing table in
the database EF7 is connecting to. To fix it, google the error and find
the link to the GitHub issue. In there, there's the SQL you need to run
to get it working. It might be fixed by the time you read this so if it
is don't worry just forget it. I tried finding the link for it but I couldn't
remember the exact error.

You need to install the ICU dependency if not coreclr will silently fail.
`brew install icu4c`
