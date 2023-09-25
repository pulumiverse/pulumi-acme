// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

//go:generate go run ./generate.go

package main

import (
	_ "embed"
	"os"

	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	acme "github.com/pulumiverse/pulumi-acme/provider"
	"github.com/pulumiverse/pulumi-acme/provider/pkg/version"
	"github.com/vancluever/terraform-provider-acme/v2/acme/dnsplugin"
)

//go:embed schema-embed.json
var pulumiSchema []byte

func main() {
	if len(os.Args) == 2 && os.Args[1] == dnsplugin.PluginArg {
		// Start the plugin here
		dnsplugin.Serve()
	} else {
		tfbridge.Main("acme", version.Version, acme.Provider(), pulumiSchema)
	}
}
