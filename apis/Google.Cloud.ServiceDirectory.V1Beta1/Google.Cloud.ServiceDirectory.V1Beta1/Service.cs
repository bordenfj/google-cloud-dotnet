// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1beta1/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1beta1/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1beta1/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MWJldGExL3NlcnZp",
            "Y2UucHJvdG8SJWdvb2dsZS5jbG91ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxYmV0",
            "YTEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aNGdvb2dsZS9jbG91ZC9zZXJ2aWNlZGlyZWN0",
            "b3J5L3YxYmV0YTEvZW5kcG9pbnQucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8i7AIKB1NlcnZpY2USEQoEbmFtZRgBIAEoCUID4EEFElMK",
            "CG1ldGFkYXRhGAIgAygLMjwuZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJlY3Rv",
            "cnkudjFiZXRhMS5TZXJ2aWNlLk1ldGFkYXRhRW50cnlCA+BBARJHCgllbmRw",
            "b2ludHMYAyADKAsyLy5nb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52",
            "MWJldGExLkVuZHBvaW50QgPgQQMaLwoNTWV0YWRhdGFFbnRyeRILCgNrZXkY",
            "ASABKAkSDQoFdmFsdWUYAiABKAk6AjgBOn/qQXwKJ3NlcnZpY2VkaXJlY3Rv",
            "cnkuZ29vZ2xlYXBpcy5jb20vU2VydmljZRJRcHJvamVjdHMve3Byb2plY3R9",
            "L2xvY2F0aW9ucy97bG9jYXRpb259L25hbWVzcGFjZXMve25hbWVzcGFjZX0v",
            "c2VydmljZXMve3NlcnZpY2V9QpACCiljb20uZ29vZ2xlLmNsb3VkLnNlcnZp",
            "Y2VkaXJlY3RvcnkudjFiZXRhMUIMU2VydmljZVByb3RvUAFaVWdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvc2VydmljZWRp",
            "cmVjdG9yeS92MWJldGExO3NlcnZpY2VkaXJlY3Rvcnn4AQGqAiVHb29nbGUu",
            "Q2xvdWQuU2VydmljZURpcmVjdG9yeS5WMUJldGExygIlR29vZ2xlXENsb3Vk",
            "XFNlcnZpY2VEaXJlY3RvcnlcVjFiZXRhMeoCKEdvb2dsZTo6Q2xvdWQ6OlNl",
            "cnZpY2VEaXJlY3Rvcnk6OlYxYmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.ServiceDirectory.V1Beta1.EndpointReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1Beta1.Service), global::Google.Cloud.ServiceDirectory.V1Beta1.Service.Parser, new[]{ "Name", "Metadata", "Endpoints" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An individual service. A service contains a name and optional metadata.
  /// A service must exist before
  /// [endpoints][google.cloud.servicedirectory.v1beta1.Endpoint] can be
  /// added to it.
  /// </summary>
  public sealed partial class Service : pb::IMessage<Service> {
    private static readonly pb::MessageParser<Service> _parser = new pb::MessageParser<Service>(() => new Service());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Service> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1Beta1.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service(Service other) : this() {
      name_ = other.name_;
      metadata_ = other.metadata_.Clone();
      endpoints_ = other.endpoints_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service Clone() {
      return new Service(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The resource name for the service in the format
    /// 'projects/*/locations/*/namespaces/*/services/*'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. Metadata for the service. This data can be consumed by service
    /// clients.  The entire metadata dictionary may contain up to 2000 characters,
    /// spread across all key-value pairs. Metadata that goes beyond any these
    /// limits will be rejected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    /// <summary>Field number for the "endpoints" field.</summary>
    public const int EndpointsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint> _repeated_endpoints_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint> endpoints_ = new pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint>();
    /// <summary>
    /// Output only. Endpoints associated with this service. Returned on LookupService.Resolve.
    /// Control plane clients should use RegistrationService.ListEndpoints.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint> Endpoints {
      get { return endpoints_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Service);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Service other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      if(!endpoints_.Equals(other.endpoints_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Metadata.GetHashCode();
      hash ^= endpoints_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      metadata_.WriteTo(output, _map_metadata_codec);
      endpoints_.WriteTo(output, _repeated_endpoints_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += metadata_.CalculateSize(_map_metadata_codec);
      size += endpoints_.CalculateSize(_repeated_endpoints_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Service other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      metadata_.Add(other.metadata_);
      endpoints_.Add(other.endpoints_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
          case 26: {
            endpoints_.AddEntriesFrom(input, _repeated_endpoints_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
