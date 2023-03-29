# ACME Resource Provider

The ACME Resource Provider lets you manage [ACME](http://example.com) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pulumi/acme
```

or `yarn`:

```bash
yarn add @pulumi/acme
```

### Python

To use from Python, install using `pip`:

```bash
pip install pulumi_acme
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/pulumi/pulumi-acme/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package Pulumi.ACME
```

## Configuration

The following configuration points are available for the `acme` provider:

- `acme:apiKey` (environment: `ACME_API_KEY`) - the API key for `acme`
- `acme:region` (environment: `ACME_REGION`) - the region in which to deploy resources

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/acme/api-docs/).
