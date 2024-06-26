# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ClusterArgs', 'Cluster']

@pulumi.input_type
class ClusterArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 namespace: pulumi.Input[str],
                 spec: pulumi.Input['ClusterSpecArgs'],
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 kube_config: Optional[pulumi.Input['ClusterKubeConfigArgs']] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 remove_agent_resources_on_destroy: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a Cluster resource.
        :param pulumi.Input[str] instance_id: Argo CD instance ID
        :param pulumi.Input[str] namespace: Agent installation namespace
        :param pulumi.Input['ClusterSpecArgs'] spec: Cluster spec
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] annotations: Annotations
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels
        :param pulumi.Input[str] name: Cluster name
        :param pulumi.Input[bool] remove_agent_resources_on_destroy: Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "namespace", namespace)
        pulumi.set(__self__, "spec", spec)
        if annotations is not None:
            pulumi.set(__self__, "annotations", annotations)
        if kube_config is not None:
            pulumi.set(__self__, "kube_config", kube_config)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if remove_agent_resources_on_destroy is not None:
            pulumi.set(__self__, "remove_agent_resources_on_destroy", remove_agent_resources_on_destroy)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Argo CD instance ID
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Input[str]:
        """
        Agent installation namespace
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def spec(self) -> pulumi.Input['ClusterSpecArgs']:
        """
        Cluster spec
        """
        return pulumi.get(self, "spec")

    @spec.setter
    def spec(self, value: pulumi.Input['ClusterSpecArgs']):
        pulumi.set(self, "spec", value)

    @property
    @pulumi.getter
    def annotations(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Annotations
        """
        return pulumi.get(self, "annotations")

    @annotations.setter
    def annotations(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "annotations", value)

    @property
    @pulumi.getter(name="kubeConfig")
    def kube_config(self) -> Optional[pulumi.Input['ClusterKubeConfigArgs']]:
        return pulumi.get(self, "kube_config")

    @kube_config.setter
    def kube_config(self, value: Optional[pulumi.Input['ClusterKubeConfigArgs']]):
        pulumi.set(self, "kube_config", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Cluster name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="removeAgentResourcesOnDestroy")
    def remove_agent_resources_on_destroy(self) -> Optional[pulumi.Input[bool]]:
        """
        Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        """
        return pulumi.get(self, "remove_agent_resources_on_destroy")

    @remove_agent_resources_on_destroy.setter
    def remove_agent_resources_on_destroy(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "remove_agent_resources_on_destroy", value)


@pulumi.input_type
class _ClusterState:
    def __init__(__self__, *,
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 kube_config: Optional[pulumi.Input['ClusterKubeConfigArgs']] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 remove_agent_resources_on_destroy: Optional[pulumi.Input[bool]] = None,
                 spec: Optional[pulumi.Input['ClusterSpecArgs']] = None):
        """
        Input properties used for looking up and filtering Cluster resources.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] annotations: Annotations
        :param pulumi.Input[str] instance_id: Argo CD instance ID
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels
        :param pulumi.Input[str] name: Cluster name
        :param pulumi.Input[str] namespace: Agent installation namespace
        :param pulumi.Input[bool] remove_agent_resources_on_destroy: Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        :param pulumi.Input['ClusterSpecArgs'] spec: Cluster spec
        """
        if annotations is not None:
            pulumi.set(__self__, "annotations", annotations)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if kube_config is not None:
            pulumi.set(__self__, "kube_config", kube_config)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)
        if remove_agent_resources_on_destroy is not None:
            pulumi.set(__self__, "remove_agent_resources_on_destroy", remove_agent_resources_on_destroy)
        if spec is not None:
            pulumi.set(__self__, "spec", spec)

    @property
    @pulumi.getter
    def annotations(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Annotations
        """
        return pulumi.get(self, "annotations")

    @annotations.setter
    def annotations(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "annotations", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Argo CD instance ID
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="kubeConfig")
    def kube_config(self) -> Optional[pulumi.Input['ClusterKubeConfigArgs']]:
        return pulumi.get(self, "kube_config")

    @kube_config.setter
    def kube_config(self, value: Optional[pulumi.Input['ClusterKubeConfigArgs']]):
        pulumi.set(self, "kube_config", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Cluster name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Agent installation namespace
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter(name="removeAgentResourcesOnDestroy")
    def remove_agent_resources_on_destroy(self) -> Optional[pulumi.Input[bool]]:
        """
        Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        """
        return pulumi.get(self, "remove_agent_resources_on_destroy")

    @remove_agent_resources_on_destroy.setter
    def remove_agent_resources_on_destroy(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "remove_agent_resources_on_destroy", value)

    @property
    @pulumi.getter
    def spec(self) -> Optional[pulumi.Input['ClusterSpecArgs']]:
        """
        Cluster spec
        """
        return pulumi.get(self, "spec")

    @spec.setter
    def spec(self, value: Optional[pulumi.Input['ClusterSpecArgs']]):
        pulumi.set(self, "spec", value)


class Cluster(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 kube_config: Optional[pulumi.Input[pulumi.InputType['ClusterKubeConfigArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 remove_agent_resources_on_destroy: Optional[pulumi.Input[bool]] = None,
                 spec: Optional[pulumi.Input[pulumi.InputType['ClusterSpecArgs']]] = None,
                 __props__=None):
        """
        Manages a cluster attached to an Argo CD instance.

        ## Example Usage

        ## Import

        Using `pulumi import`, import AKP cluster using `instance_id` and `name` separated by a forward slash (`/`). For example:

        ```sh
        $ pulumi import akp:index/cluster:Cluster example 6pzhawvy4echbd8x/test-cluster
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] annotations: Annotations
        :param pulumi.Input[str] instance_id: Argo CD instance ID
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels
        :param pulumi.Input[str] name: Cluster name
        :param pulumi.Input[str] namespace: Agent installation namespace
        :param pulumi.Input[bool] remove_agent_resources_on_destroy: Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        :param pulumi.Input[pulumi.InputType['ClusterSpecArgs']] spec: Cluster spec
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ClusterArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Manages a cluster attached to an Argo CD instance.

        ## Example Usage

        ## Import

        Using `pulumi import`, import AKP cluster using `instance_id` and `name` separated by a forward slash (`/`). For example:

        ```sh
        $ pulumi import akp:index/cluster:Cluster example 6pzhawvy4echbd8x/test-cluster
        ```

        :param str resource_name: The name of the resource.
        :param ClusterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ClusterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 kube_config: Optional[pulumi.Input[pulumi.InputType['ClusterKubeConfigArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 remove_agent_resources_on_destroy: Optional[pulumi.Input[bool]] = None,
                 spec: Optional[pulumi.Input[pulumi.InputType['ClusterSpecArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ClusterArgs.__new__(ClusterArgs)

            __props__.__dict__["annotations"] = annotations
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            __props__.__dict__["kube_config"] = kube_config
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            if namespace is None and not opts.urn:
                raise TypeError("Missing required property 'namespace'")
            __props__.__dict__["namespace"] = namespace
            __props__.__dict__["remove_agent_resources_on_destroy"] = remove_agent_resources_on_destroy
            if spec is None and not opts.urn:
                raise TypeError("Missing required property 'spec'")
            __props__.__dict__["spec"] = spec
        super(Cluster, __self__).__init__(
            'akp:index/cluster:Cluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            annotations: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            kube_config: Optional[pulumi.Input[pulumi.InputType['ClusterKubeConfigArgs']]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            namespace: Optional[pulumi.Input[str]] = None,
            remove_agent_resources_on_destroy: Optional[pulumi.Input[bool]] = None,
            spec: Optional[pulumi.Input[pulumi.InputType['ClusterSpecArgs']]] = None) -> 'Cluster':
        """
        Get an existing Cluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] annotations: Annotations
        :param pulumi.Input[str] instance_id: Argo CD instance ID
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels
        :param pulumi.Input[str] name: Cluster name
        :param pulumi.Input[str] namespace: Agent installation namespace
        :param pulumi.Input[bool] remove_agent_resources_on_destroy: Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        :param pulumi.Input[pulumi.InputType['ClusterSpecArgs']] spec: Cluster spec
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ClusterState.__new__(_ClusterState)

        __props__.__dict__["annotations"] = annotations
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["kube_config"] = kube_config
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["namespace"] = namespace
        __props__.__dict__["remove_agent_resources_on_destroy"] = remove_agent_resources_on_destroy
        __props__.__dict__["spec"] = spec
        return Cluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def annotations(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Annotations
        """
        return pulumi.get(self, "annotations")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Argo CD instance ID
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="kubeConfig")
    def kube_config(self) -> pulumi.Output[Optional['outputs.ClusterKubeConfig']]:
        return pulumi.get(self, "kube_config")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Labels
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Cluster name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Output[str]:
        """
        Agent installation namespace
        """
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter(name="removeAgentResourcesOnDestroy")
    def remove_agent_resources_on_destroy(self) -> pulumi.Output[bool]:
        """
        Remove agent Kubernetes resources from the managed cluster when destroying cluster, default to `true`
        """
        return pulumi.get(self, "remove_agent_resources_on_destroy")

    @property
    @pulumi.getter
    def spec(self) -> pulumi.Output['outputs.ClusterSpec']:
        """
        Cluster spec
        """
        return pulumi.get(self, "spec")

