# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .certificate import *
from .get_server_url import *
from .provider import *
from .registration import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumiverse_acme.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumiverse_acme.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "acme",
  "mod": "index/certificate",
  "fqn": "pulumiverse_acme",
  "classes": {
   "acme:index/certificate:Certificate": "Certificate"
  }
 },
 {
  "pkg": "acme",
  "mod": "index/registration",
  "fqn": "pulumiverse_acme",
  "classes": {
   "acme:index/registration:Registration": "Registration"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "acme",
  "token": "pulumi:providers:acme",
  "fqn": "pulumiverse_acme",
  "class": "Provider"
 }
]
"""
)
