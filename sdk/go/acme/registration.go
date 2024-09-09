// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package acme

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-acme/sdk/go/acme/internal"
)

type Registration struct {
	pulumi.CustomResourceState

	AccountKeyAlgorithm    pulumi.StringPtrOutput                      `pulumi:"accountKeyAlgorithm"`
	AccountKeyEcdsaCurve   pulumi.StringPtrOutput                      `pulumi:"accountKeyEcdsaCurve"`
	AccountKeyPem          pulumi.StringOutput                         `pulumi:"accountKeyPem"`
	AccountKeyRsaBits      pulumi.IntPtrOutput                         `pulumi:"accountKeyRsaBits"`
	EmailAddress           pulumi.StringOutput                         `pulumi:"emailAddress"`
	ExternalAccountBinding RegistrationExternalAccountBindingPtrOutput `pulumi:"externalAccountBinding"`
	RegistrationUrl        pulumi.StringOutput                         `pulumi:"registrationUrl"`
}

// NewRegistration registers a new resource with the given unique name, arguments, and options.
func NewRegistration(ctx *pulumi.Context,
	name string, args *RegistrationArgs, opts ...pulumi.ResourceOption) (*Registration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EmailAddress == nil {
		return nil, errors.New("invalid value for required argument 'EmailAddress'")
	}
	if args.AccountKeyPem != nil {
		args.AccountKeyPem = pulumi.ToSecret(args.AccountKeyPem).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"accountKeyPem",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Registration
	err := ctx.RegisterResource("acme:index/registration:Registration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegistration gets an existing Registration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegistration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegistrationState, opts ...pulumi.ResourceOption) (*Registration, error) {
	var resource Registration
	err := ctx.ReadResource("acme:index/registration:Registration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Registration resources.
type registrationState struct {
	AccountKeyAlgorithm    *string                             `pulumi:"accountKeyAlgorithm"`
	AccountKeyEcdsaCurve   *string                             `pulumi:"accountKeyEcdsaCurve"`
	AccountKeyPem          *string                             `pulumi:"accountKeyPem"`
	AccountKeyRsaBits      *int                                `pulumi:"accountKeyRsaBits"`
	EmailAddress           *string                             `pulumi:"emailAddress"`
	ExternalAccountBinding *RegistrationExternalAccountBinding `pulumi:"externalAccountBinding"`
	RegistrationUrl        *string                             `pulumi:"registrationUrl"`
}

type RegistrationState struct {
	AccountKeyAlgorithm    pulumi.StringPtrInput
	AccountKeyEcdsaCurve   pulumi.StringPtrInput
	AccountKeyPem          pulumi.StringPtrInput
	AccountKeyRsaBits      pulumi.IntPtrInput
	EmailAddress           pulumi.StringPtrInput
	ExternalAccountBinding RegistrationExternalAccountBindingPtrInput
	RegistrationUrl        pulumi.StringPtrInput
}

func (RegistrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*registrationState)(nil)).Elem()
}

type registrationArgs struct {
	AccountKeyAlgorithm    *string                             `pulumi:"accountKeyAlgorithm"`
	AccountKeyEcdsaCurve   *string                             `pulumi:"accountKeyEcdsaCurve"`
	AccountKeyPem          *string                             `pulumi:"accountKeyPem"`
	AccountKeyRsaBits      *int                                `pulumi:"accountKeyRsaBits"`
	EmailAddress           string                              `pulumi:"emailAddress"`
	ExternalAccountBinding *RegistrationExternalAccountBinding `pulumi:"externalAccountBinding"`
}

// The set of arguments for constructing a Registration resource.
type RegistrationArgs struct {
	AccountKeyAlgorithm    pulumi.StringPtrInput
	AccountKeyEcdsaCurve   pulumi.StringPtrInput
	AccountKeyPem          pulumi.StringPtrInput
	AccountKeyRsaBits      pulumi.IntPtrInput
	EmailAddress           pulumi.StringInput
	ExternalAccountBinding RegistrationExternalAccountBindingPtrInput
}

func (RegistrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*registrationArgs)(nil)).Elem()
}

type RegistrationInput interface {
	pulumi.Input

	ToRegistrationOutput() RegistrationOutput
	ToRegistrationOutputWithContext(ctx context.Context) RegistrationOutput
}

func (*Registration) ElementType() reflect.Type {
	return reflect.TypeOf((**Registration)(nil)).Elem()
}

func (i *Registration) ToRegistrationOutput() RegistrationOutput {
	return i.ToRegistrationOutputWithContext(context.Background())
}

func (i *Registration) ToRegistrationOutputWithContext(ctx context.Context) RegistrationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegistrationOutput)
}

// RegistrationArrayInput is an input type that accepts RegistrationArray and RegistrationArrayOutput values.
// You can construct a concrete instance of `RegistrationArrayInput` via:
//
//	RegistrationArray{ RegistrationArgs{...} }
type RegistrationArrayInput interface {
	pulumi.Input

	ToRegistrationArrayOutput() RegistrationArrayOutput
	ToRegistrationArrayOutputWithContext(context.Context) RegistrationArrayOutput
}

type RegistrationArray []RegistrationInput

func (RegistrationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Registration)(nil)).Elem()
}

func (i RegistrationArray) ToRegistrationArrayOutput() RegistrationArrayOutput {
	return i.ToRegistrationArrayOutputWithContext(context.Background())
}

func (i RegistrationArray) ToRegistrationArrayOutputWithContext(ctx context.Context) RegistrationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegistrationArrayOutput)
}

// RegistrationMapInput is an input type that accepts RegistrationMap and RegistrationMapOutput values.
// You can construct a concrete instance of `RegistrationMapInput` via:
//
//	RegistrationMap{ "key": RegistrationArgs{...} }
type RegistrationMapInput interface {
	pulumi.Input

	ToRegistrationMapOutput() RegistrationMapOutput
	ToRegistrationMapOutputWithContext(context.Context) RegistrationMapOutput
}

type RegistrationMap map[string]RegistrationInput

func (RegistrationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Registration)(nil)).Elem()
}

func (i RegistrationMap) ToRegistrationMapOutput() RegistrationMapOutput {
	return i.ToRegistrationMapOutputWithContext(context.Background())
}

func (i RegistrationMap) ToRegistrationMapOutputWithContext(ctx context.Context) RegistrationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegistrationMapOutput)
}

type RegistrationOutput struct{ *pulumi.OutputState }

func (RegistrationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Registration)(nil)).Elem()
}

func (o RegistrationOutput) ToRegistrationOutput() RegistrationOutput {
	return o
}

func (o RegistrationOutput) ToRegistrationOutputWithContext(ctx context.Context) RegistrationOutput {
	return o
}

func (o RegistrationOutput) AccountKeyAlgorithm() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Registration) pulumi.StringPtrOutput { return v.AccountKeyAlgorithm }).(pulumi.StringPtrOutput)
}

func (o RegistrationOutput) AccountKeyEcdsaCurve() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Registration) pulumi.StringPtrOutput { return v.AccountKeyEcdsaCurve }).(pulumi.StringPtrOutput)
}

func (o RegistrationOutput) AccountKeyPem() pulumi.StringOutput {
	return o.ApplyT(func(v *Registration) pulumi.StringOutput { return v.AccountKeyPem }).(pulumi.StringOutput)
}

func (o RegistrationOutput) AccountKeyRsaBits() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Registration) pulumi.IntPtrOutput { return v.AccountKeyRsaBits }).(pulumi.IntPtrOutput)
}

func (o RegistrationOutput) EmailAddress() pulumi.StringOutput {
	return o.ApplyT(func(v *Registration) pulumi.StringOutput { return v.EmailAddress }).(pulumi.StringOutput)
}

func (o RegistrationOutput) ExternalAccountBinding() RegistrationExternalAccountBindingPtrOutput {
	return o.ApplyT(func(v *Registration) RegistrationExternalAccountBindingPtrOutput { return v.ExternalAccountBinding }).(RegistrationExternalAccountBindingPtrOutput)
}

func (o RegistrationOutput) RegistrationUrl() pulumi.StringOutput {
	return o.ApplyT(func(v *Registration) pulumi.StringOutput { return v.RegistrationUrl }).(pulumi.StringOutput)
}

type RegistrationArrayOutput struct{ *pulumi.OutputState }

func (RegistrationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Registration)(nil)).Elem()
}

func (o RegistrationArrayOutput) ToRegistrationArrayOutput() RegistrationArrayOutput {
	return o
}

func (o RegistrationArrayOutput) ToRegistrationArrayOutputWithContext(ctx context.Context) RegistrationArrayOutput {
	return o
}

func (o RegistrationArrayOutput) Index(i pulumi.IntInput) RegistrationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Registration {
		return vs[0].([]*Registration)[vs[1].(int)]
	}).(RegistrationOutput)
}

type RegistrationMapOutput struct{ *pulumi.OutputState }

func (RegistrationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Registration)(nil)).Elem()
}

func (o RegistrationMapOutput) ToRegistrationMapOutput() RegistrationMapOutput {
	return o
}

func (o RegistrationMapOutput) ToRegistrationMapOutputWithContext(ctx context.Context) RegistrationMapOutput {
	return o
}

func (o RegistrationMapOutput) MapIndex(k pulumi.StringInput) RegistrationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Registration {
		return vs[0].(map[string]*Registration)[vs[1].(string)]
	}).(RegistrationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RegistrationInput)(nil)).Elem(), &Registration{})
	pulumi.RegisterInputType(reflect.TypeOf((*RegistrationArrayInput)(nil)).Elem(), RegistrationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RegistrationMapInput)(nil)).Elem(), RegistrationMap{})
	pulumi.RegisterOutputType(RegistrationOutput{})
	pulumi.RegisterOutputType(RegistrationArrayOutput{})
	pulumi.RegisterOutputType(RegistrationMapOutput{})
}
