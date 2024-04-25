package main

import (
	"github.com/dirien/pulumi-akp/sdk/go/akp"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := akp.NewProvider(ctx, "my-provider", &akp.ProviderArgs{
			OrgName: pulumi.String("la-devops-days"),
		})
		if err != nil {
			return err
		}
		return nil
	})
}
