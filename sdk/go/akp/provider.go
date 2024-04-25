// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package akp

import (
	"context"
	"reflect"

	"errors"
	"github.com/dirien/pulumi-akp/sdk/go/akp/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The provider type for the akp package. By default, resources use package-wide configuration
// settings, however an explicit `Provider` instance may be created and passed during resource
// construction to achieve fine-grained programmatic control over provider settings. See the
// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
type Provider struct {
	pulumi.ProviderResourceState

	// API Key Id. Use environment variable `AKUITY_API_KEY_ID`
	ApiKeyId pulumi.StringPtrOutput `pulumi:"apiKeyId"`
	// API Key Secret, Use environment variable `AKUITY_API_KEY_SECRET`
	ApiKeySecret pulumi.StringPtrOutput `pulumi:"apiKeySecret"`
	// Organization Name
	OrgName pulumi.StringOutput `pulumi:"orgName"`
	// Akuity Platform API URL, default: `https://akuity.cloud`. You can use environment variable `AKUITY_SERVER_URL` instead
	ServerUrl pulumi.StringPtrOutput `pulumi:"serverUrl"`
}

// NewProvider registers a new resource with the given unique name, arguments, and options.
func NewProvider(ctx *pulumi.Context,
	name string, args *ProviderArgs, opts ...pulumi.ResourceOption) (*Provider, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.OrgName == nil {
		return nil, errors.New("invalid value for required argument 'OrgName'")
	}
	if args.ApiKeyId == nil {
		if d := internal.GetEnvOrDefault(nil, nil, "AKUITY_API_KEY_ID"); d != nil {
			args.ApiKeyId = pulumi.StringPtr(d.(string))
		}
	}
	if args.ApiKeySecret == nil {
		if d := internal.GetEnvOrDefault(nil, nil, "AKUITY_API_KEY_SECRET"); d != nil {
			args.ApiKeySecret = pulumi.StringPtr(d.(string))
		}
	}
	if args.ServerUrl == nil {
		if d := internal.GetEnvOrDefault(nil, nil, "AKUITY_SERVER_URL"); d != nil {
			args.ServerUrl = pulumi.StringPtr(d.(string))
		}
	}
	if args.ApiKeyId != nil {
		args.ApiKeyId = pulumi.ToSecret(args.ApiKeyId).(pulumi.StringPtrInput)
	}
	if args.ApiKeySecret != nil {
		args.ApiKeySecret = pulumi.ToSecret(args.ApiKeySecret).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"apiKeyId",
		"apiKeySecret",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Provider
	err := ctx.RegisterResource("pulumi:providers:akp", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

type providerArgs struct {
	// API Key Id. Use environment variable `AKUITY_API_KEY_ID`
	ApiKeyId *string `pulumi:"apiKeyId"`
	// API Key Secret, Use environment variable `AKUITY_API_KEY_SECRET`
	ApiKeySecret *string `pulumi:"apiKeySecret"`
	// Organization Name
	OrgName string `pulumi:"orgName"`
	// Akuity Platform API URL, default: `https://akuity.cloud`. You can use environment variable `AKUITY_SERVER_URL` instead
	ServerUrl *string `pulumi:"serverUrl"`
	// Skip TLS Verify. Only use for testing self-hosted version
	SkipTlsVerify *bool `pulumi:"skipTlsVerify"`
}

// The set of arguments for constructing a Provider resource.
type ProviderArgs struct {
	// API Key Id. Use environment variable `AKUITY_API_KEY_ID`
	ApiKeyId pulumi.StringPtrInput
	// API Key Secret, Use environment variable `AKUITY_API_KEY_SECRET`
	ApiKeySecret pulumi.StringPtrInput
	// Organization Name
	OrgName pulumi.StringInput
	// Akuity Platform API URL, default: `https://akuity.cloud`. You can use environment variable `AKUITY_SERVER_URL` instead
	ServerUrl pulumi.StringPtrInput
	// Skip TLS Verify. Only use for testing self-hosted version
	SkipTlsVerify pulumi.BoolPtrInput
}

func (ProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*providerArgs)(nil)).Elem()
}

type ProviderInput interface {
	pulumi.Input

	ToProviderOutput() ProviderOutput
	ToProviderOutputWithContext(ctx context.Context) ProviderOutput
}

func (*Provider) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (i *Provider) ToProviderOutput() ProviderOutput {
	return i.ToProviderOutputWithContext(context.Background())
}

func (i *Provider) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderOutput)
}

type ProviderOutput struct{ *pulumi.OutputState }

func (ProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (o ProviderOutput) ToProviderOutput() ProviderOutput {
	return o
}

func (o ProviderOutput) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return o
}

// API Key Id. Use environment variable `AKUITY_API_KEY_ID`
func (o ProviderOutput) ApiKeyId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ApiKeyId }).(pulumi.StringPtrOutput)
}

// API Key Secret, Use environment variable `AKUITY_API_KEY_SECRET`
func (o ProviderOutput) ApiKeySecret() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ApiKeySecret }).(pulumi.StringPtrOutput)
}

// Organization Name
func (o ProviderOutput) OrgName() pulumi.StringOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringOutput { return v.OrgName }).(pulumi.StringOutput)
}

// Akuity Platform API URL, default: `https://akuity.cloud`. You can use environment variable `AKUITY_SERVER_URL` instead
func (o ProviderOutput) ServerUrl() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringPtrOutput { return v.ServerUrl }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProviderInput)(nil)).Elem(), &Provider{})
	pulumi.RegisterOutputType(ProviderOutput{})
}
