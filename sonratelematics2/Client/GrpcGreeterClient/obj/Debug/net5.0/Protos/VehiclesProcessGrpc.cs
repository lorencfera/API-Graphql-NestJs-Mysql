// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/vehicles_process.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeterClient {
  public static partial class ProcessService
  {
    static readonly string __ServiceName = "sonartelematics.vehicles.process.ProcessService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.AddProcessRequest> __Marshaller_sonartelematics_vehicles_process_AddProcessRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.AddProcessRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.VehicleProcess> __Marshaller_sonartelematics_vehicles_process_VehicleProcess = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.VehicleProcess.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.UpdateProcessStatusRequest> __Marshaller_sonartelematics_vehicles_process_UpdateProcessStatusRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.UpdateProcessStatusRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.AddProcessUpdateRequest> __Marshaller_sonartelematics_vehicles_process_AddProcessUpdateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.AddProcessUpdateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.ProcessUpdate> __Marshaller_sonartelematics_vehicles_process_ProcessUpdate = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.ProcessUpdate.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.RetrieveVehicleProcessRequest> __Marshaller_sonartelematics_vehicles_process_RetrieveVehicleProcessRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.RetrieveVehicleProcessRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.RetrieveVehicleProcessResponse> __Marshaller_sonartelematics_vehicles_process_RetrieveVehicleProcessResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.RetrieveVehicleProcessResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.RetrieveProcessUpdatesRequest> __Marshaller_sonartelematics_vehicles_process_RetrieveProcessUpdatesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.RetrieveProcessUpdatesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcGreeterClient.RetrieveProcessUpdatesResponse> __Marshaller_sonartelematics_vehicles_process_RetrieveProcessUpdatesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcGreeterClient.RetrieveProcessUpdatesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcGreeterClient.AddProcessRequest, global::GrpcGreeterClient.VehicleProcess> __Method_AddProcess = new grpc::Method<global::GrpcGreeterClient.AddProcessRequest, global::GrpcGreeterClient.VehicleProcess>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddProcess",
        __Marshaller_sonartelematics_vehicles_process_AddProcessRequest,
        __Marshaller_sonartelematics_vehicles_process_VehicleProcess);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcGreeterClient.UpdateProcessStatusRequest, global::GrpcGreeterClient.VehicleProcess> __Method_UpdateProcessStatus = new grpc::Method<global::GrpcGreeterClient.UpdateProcessStatusRequest, global::GrpcGreeterClient.VehicleProcess>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProcessStatus",
        __Marshaller_sonartelematics_vehicles_process_UpdateProcessStatusRequest,
        __Marshaller_sonartelematics_vehicles_process_VehicleProcess);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcGreeterClient.AddProcessUpdateRequest, global::GrpcGreeterClient.ProcessUpdate> __Method_AddProcessUpdate = new grpc::Method<global::GrpcGreeterClient.AddProcessUpdateRequest, global::GrpcGreeterClient.ProcessUpdate>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddProcessUpdate",
        __Marshaller_sonartelematics_vehicles_process_AddProcessUpdateRequest,
        __Marshaller_sonartelematics_vehicles_process_ProcessUpdate);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcGreeterClient.RetrieveVehicleProcessRequest, global::GrpcGreeterClient.RetrieveVehicleProcessResponse> __Method_RetrieveVehicleProcess = new grpc::Method<global::GrpcGreeterClient.RetrieveVehicleProcessRequest, global::GrpcGreeterClient.RetrieveVehicleProcessResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RetrieveVehicleProcess",
        __Marshaller_sonartelematics_vehicles_process_RetrieveVehicleProcessRequest,
        __Marshaller_sonartelematics_vehicles_process_RetrieveVehicleProcessResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcGreeterClient.RetrieveProcessUpdatesRequest, global::GrpcGreeterClient.RetrieveProcessUpdatesResponse> __Method_RetrieveProcessUpdates = new grpc::Method<global::GrpcGreeterClient.RetrieveProcessUpdatesRequest, global::GrpcGreeterClient.RetrieveProcessUpdatesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RetrieveProcessUpdates",
        __Marshaller_sonartelematics_vehicles_process_RetrieveProcessUpdatesRequest,
        __Marshaller_sonartelematics_vehicles_process_RetrieveProcessUpdatesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeterClient.VehiclesProcessReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ProcessService</summary>
    public partial class ProcessServiceClient : grpc::ClientBase<ProcessServiceClient>
    {
      /// <summary>Creates a new client for ProcessService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProcessServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProcessService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProcessServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProcessServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProcessServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.VehicleProcess AddProcess(global::GrpcGreeterClient.AddProcessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddProcess(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.VehicleProcess AddProcess(global::GrpcGreeterClient.AddProcessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddProcess, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.VehicleProcess> AddProcessAsync(global::GrpcGreeterClient.AddProcessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddProcessAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.VehicleProcess> AddProcessAsync(global::GrpcGreeterClient.AddProcessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddProcess, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.VehicleProcess UpdateProcessStatus(global::GrpcGreeterClient.UpdateProcessStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProcessStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.VehicleProcess UpdateProcessStatus(global::GrpcGreeterClient.UpdateProcessStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateProcessStatus, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.VehicleProcess> UpdateProcessStatusAsync(global::GrpcGreeterClient.UpdateProcessStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProcessStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.VehicleProcess> UpdateProcessStatusAsync(global::GrpcGreeterClient.UpdateProcessStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateProcessStatus, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.ProcessUpdate AddProcessUpdate(global::GrpcGreeterClient.AddProcessUpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddProcessUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.ProcessUpdate AddProcessUpdate(global::GrpcGreeterClient.AddProcessUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddProcessUpdate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.ProcessUpdate> AddProcessUpdateAsync(global::GrpcGreeterClient.AddProcessUpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddProcessUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.ProcessUpdate> AddProcessUpdateAsync(global::GrpcGreeterClient.AddProcessUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddProcessUpdate, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.RetrieveVehicleProcessResponse RetrieveVehicleProcess(global::GrpcGreeterClient.RetrieveVehicleProcessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetrieveVehicleProcess(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.RetrieveVehicleProcessResponse RetrieveVehicleProcess(global::GrpcGreeterClient.RetrieveVehicleProcessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RetrieveVehicleProcess, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.RetrieveVehicleProcessResponse> RetrieveVehicleProcessAsync(global::GrpcGreeterClient.RetrieveVehicleProcessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetrieveVehicleProcessAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.RetrieveVehicleProcessResponse> RetrieveVehicleProcessAsync(global::GrpcGreeterClient.RetrieveVehicleProcessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RetrieveVehicleProcess, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.RetrieveProcessUpdatesResponse RetrieveProcessUpdates(global::GrpcGreeterClient.RetrieveProcessUpdatesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetrieveProcessUpdates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcGreeterClient.RetrieveProcessUpdatesResponse RetrieveProcessUpdates(global::GrpcGreeterClient.RetrieveProcessUpdatesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RetrieveProcessUpdates, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.RetrieveProcessUpdatesResponse> RetrieveProcessUpdatesAsync(global::GrpcGreeterClient.RetrieveProcessUpdatesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RetrieveProcessUpdatesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcGreeterClient.RetrieveProcessUpdatesResponse> RetrieveProcessUpdatesAsync(global::GrpcGreeterClient.RetrieveProcessUpdatesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RetrieveProcessUpdates, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProcessServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProcessServiceClient(configuration);
      }
    }

  }
}
#endregion
