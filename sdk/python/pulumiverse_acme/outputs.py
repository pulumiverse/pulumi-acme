# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'CertificateDnsChallenge',
    'CertificateHttpChallenge',
    'CertificateHttpMemcachedChallenge',
    'CertificateHttpS3Challenge',
    'CertificateHttpWebrootChallenge',
    'CertificateTlsChallenge',
    'RegistrationExternalAccountBinding',
]

@pulumi.output_type
class CertificateDnsChallenge(dict):
    def __init__(__self__, *,
                 provider: str,
                 config: Optional[Mapping[str, str]] = None):
        pulumi.set(__self__, "provider", provider)
        if config is not None:
            pulumi.set(__self__, "config", config)

    @property
    @pulumi.getter
    def provider(self) -> str:
        return pulumi.get(self, "provider")

    @property
    @pulumi.getter
    def config(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "config")


@pulumi.output_type
class CertificateHttpChallenge(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "proxyHeader":
            suggest = "proxy_header"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in CertificateHttpChallenge. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        CertificateHttpChallenge.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        CertificateHttpChallenge.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 port: Optional[int] = None,
                 proxy_header: Optional[str] = None):
        """
        :param int port: The port that the challenge server listens on. Default: `80`.
        :param str proxy_header: The proxy header to match against. Default:
               `Host`.
               
               The `proxy_header` option behaves differently depending on its definition:
               
               * When set to `Host`, standard host header validation is used.
               * When set to `Forwarded`, the server looks in the `Forwarded` header for a
               section matching `host=DOMAIN` where `DOMAIN` is the domain currently being
               resolved by the challenge. See [RFC 7239](https://tools.ietf.org/html/rfc7239)
               for more details.
               * When set to an arbitrary header (example: `X-Forwarded-Host`), that header is
               checked for the host entry in the same way the host header would normally be
               checked.
        """
        if port is not None:
            pulumi.set(__self__, "port", port)
        if proxy_header is not None:
            pulumi.set(__self__, "proxy_header", proxy_header)

    @property
    @pulumi.getter
    def port(self) -> Optional[int]:
        """
        The port that the challenge server listens on. Default: `80`.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="proxyHeader")
    def proxy_header(self) -> Optional[str]:
        """
        The proxy header to match against. Default:
        `Host`.

        The `proxy_header` option behaves differently depending on its definition:

        * When set to `Host`, standard host header validation is used.
        * When set to `Forwarded`, the server looks in the `Forwarded` header for a
        section matching `host=DOMAIN` where `DOMAIN` is the domain currently being
        resolved by the challenge. See [RFC 7239](https://tools.ietf.org/html/rfc7239)
        for more details.
        * When set to an arbitrary header (example: `X-Forwarded-Host`), that header is
        checked for the host entry in the same way the host header would normally be
        checked.
        """
        return pulumi.get(self, "proxy_header")


@pulumi.output_type
class CertificateHttpMemcachedChallenge(dict):
    def __init__(__self__, *,
                 hosts: Sequence[str]):
        pulumi.set(__self__, "hosts", hosts)

    @property
    @pulumi.getter
    def hosts(self) -> Sequence[str]:
        return pulumi.get(self, "hosts")


@pulumi.output_type
class CertificateHttpS3Challenge(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "s3Bucket":
            suggest = "s3_bucket"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in CertificateHttpS3Challenge. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        CertificateHttpS3Challenge.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        CertificateHttpS3Challenge.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 s3_bucket: str):
        """
        :param str s3_bucket: The s3_bucket to publish the record to.
        """
        pulumi.set(__self__, "s3_bucket", s3_bucket)

    @property
    @pulumi.getter(name="s3Bucket")
    def s3_bucket(self) -> str:
        """
        The s3_bucket to publish the record to.
        """
        return pulumi.get(self, "s3_bucket")


@pulumi.output_type
class CertificateHttpWebrootChallenge(dict):
    def __init__(__self__, *,
                 directory: str):
        """
        :param str directory: The directory to publish the record to.
        """
        pulumi.set(__self__, "directory", directory)

    @property
    @pulumi.getter
    def directory(self) -> str:
        """
        The directory to publish the record to.
        """
        return pulumi.get(self, "directory")


@pulumi.output_type
class CertificateTlsChallenge(dict):
    def __init__(__self__, *,
                 port: Optional[int] = None):
        """
        :param int port: The port that the challenge server listens on. Default: `443`.
        """
        if port is not None:
            pulumi.set(__self__, "port", port)

    @property
    @pulumi.getter
    def port(self) -> Optional[int]:
        """
        The port that the challenge server listens on. Default: `443`.
        """
        return pulumi.get(self, "port")


@pulumi.output_type
class RegistrationExternalAccountBinding(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "hmacBase64":
            suggest = "hmac_base64"
        elif key == "keyId":
            suggest = "key_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RegistrationExternalAccountBinding. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RegistrationExternalAccountBinding.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RegistrationExternalAccountBinding.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 hmac_base64: str,
                 key_id: str):
        pulumi.set(__self__, "hmac_base64", hmac_base64)
        pulumi.set(__self__, "key_id", key_id)

    @property
    @pulumi.getter(name="hmacBase64")
    def hmac_base64(self) -> str:
        return pulumi.get(self, "hmac_base64")

    @property
    @pulumi.getter(name="keyId")
    def key_id(self) -> str:
        return pulumi.get(self, "key_id")


