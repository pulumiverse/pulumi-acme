// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

// Export members:
export { CertificateArgs, CertificateState } from "./certificate";
export type Certificate = import("./certificate").Certificate;
export const Certificate: typeof import("./certificate").Certificate = null as any;
utilities.lazyLoad(exports, ["Certificate"], () => require("./certificate"));

export { GetServerUrlResult } from "./getServerUrl";
export const getServerUrl: typeof import("./getServerUrl").getServerUrl = null as any;
export const getServerUrlOutput: typeof import("./getServerUrl").getServerUrlOutput = null as any;
utilities.lazyLoad(exports, ["getServerUrl","getServerUrlOutput"], () => require("./getServerUrl"));

export { ProviderArgs } from "./provider";
export type Provider = import("./provider").Provider;
export const Provider: typeof import("./provider").Provider = null as any;
utilities.lazyLoad(exports, ["Provider"], () => require("./provider"));

export { RegistrationArgs, RegistrationState } from "./registration";
export type Registration = import("./registration").Registration;
export const Registration: typeof import("./registration").Registration = null as any;
utilities.lazyLoad(exports, ["Registration"], () => require("./registration"));


// Export sub-modules:
import * as config from "./config";
import * as types from "./types";

export {
    config,
    types,
};

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "acme:index/certificate:Certificate":
                return new Certificate(name, <any>undefined, { urn })
            case "acme:index/registration:Registration":
                return new Registration(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("acme", "index/certificate", _module)
pulumi.runtime.registerResourceModule("acme", "index/registration", _module)
pulumi.runtime.registerResourcePackage("acme", {
    version: utilities.getVersion(),
    constructProvider: (name: string, type: string, urn: string): pulumi.ProviderResource => {
        if (type !== "pulumi:providers:acme") {
            throw new Error(`unknown provider type ${type}`);
        }
        return new Provider(name, <any>undefined, { urn });
    },
});
