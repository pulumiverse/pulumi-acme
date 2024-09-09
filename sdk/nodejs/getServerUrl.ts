// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # acme.getServerUrl
 *
 * The `acme.getServerUrl` data source can be used to retrieve the CA server URL
 * that the provider is currently configured for.
 *
 * ## Example
 *
 * The following example populates the `serverUrl` output with the currently
 * configured CA server URL.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as acme from "@pulumi/acme";
 *
 * const url = acme.getServerUrl({});
 * export const serverUrl = url.then(url => url.serverUrl);
 * ```
 *
 * #### Argument Reference
 *
 * This data source takes no arguments.
 *
 * #### Attribute Reference
 *
 * The following attributes are exported:
 *
 * * `id`: the CA server URL that the provider is currently configured for.
 * * `serverUrl`: the CA server URL that the provider is currently configured
 *   for. Same as `id`.
 */
export function getServerUrl(opts?: pulumi.InvokeOptions): Promise<GetServerUrlResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("acme:index/getServerUrl:getServerUrl", {
    }, opts);
}

/**
 * A collection of values returned by getServerUrl.
 */
export interface GetServerUrlResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly serverUrl: string;
}
/**
 * ## # acme.getServerUrl
 *
 * The `acme.getServerUrl` data source can be used to retrieve the CA server URL
 * that the provider is currently configured for.
 *
 * ## Example
 *
 * The following example populates the `serverUrl` output with the currently
 * configured CA server URL.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as acme from "@pulumi/acme";
 *
 * const url = acme.getServerUrl({});
 * export const serverUrl = url.then(url => url.serverUrl);
 * ```
 *
 * #### Argument Reference
 *
 * This data source takes no arguments.
 *
 * #### Attribute Reference
 *
 * The following attributes are exported:
 *
 * * `id`: the CA server URL that the provider is currently configured for.
 * * `serverUrl`: the CA server URL that the provider is currently configured
 *   for. Same as `id`.
 */
export function getServerUrlOutput(opts?: pulumi.InvokeOptions): pulumi.Output<GetServerUrlResult> {
    return pulumi.output(getServerUrl(opts))
}
