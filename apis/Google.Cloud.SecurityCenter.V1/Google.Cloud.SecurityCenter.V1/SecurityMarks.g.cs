// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/security_marks.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/security_marks.proto</summary>
  public static partial class SecurityMarksReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/security_marks.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SecurityMarksReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvc2VjdXJpdHlfbWFy",
            "a3MucHJvdG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MRoZZ29v",
            "Z2xlL2FwaS9yZXNvdXJjZS5wcm90byLVBAoNU2VjdXJpdHlNYXJrcxIMCgRu",
            "YW1lGAEgASgJEkcKBW1hcmtzGAIgAygLMjguZ29vZ2xlLmNsb3VkLnNlY3Vy",
            "aXR5Y2VudGVyLnYxLlNlY3VyaXR5TWFya3MuTWFya3NFbnRyeRIWCg5jYW5v",
            "bmljYWxfbmFtZRgDIAEoCRosCgpNYXJrc0VudHJ5EgsKA2tleRgBIAEoCRIN",
            "CgV2YWx1ZRgCIAEoCToCOAE6pgPqQaIDCitzZWN1cml0eWNlbnRlci5nb29n",
            "bGVhcGlzLmNvbS9TZWN1cml0eU1hcmtzEjlvcmdhbml6YXRpb25zL3tvcmdh",
            "bml6YXRpb259L2Fzc2V0cy97YXNzZXR9L3NlY3VyaXR5TWFya3MSTm9yZ2Fu",
            "aXphdGlvbnMve29yZ2FuaXphdGlvbn0vc291cmNlcy97c291cmNlfS9maW5k",
            "aW5ncy97ZmluZGluZ30vc2VjdXJpdHlNYXJrcxItZm9sZGVycy97Zm9sZGVy",
            "fS9hc3NldHMve2Fzc2V0fS9zZWN1cml0eU1hcmtzEi9wcm9qZWN0cy97cHJv",
            "amVjdH0vYXNzZXRzL3thc3NldH0vc2VjdXJpdHlNYXJrcxJCZm9sZGVycy97",
            "Zm9sZGVyfS9zb3VyY2VzL3tzb3VyY2V9L2ZpbmRpbmdzL3tmaW5kaW5nfS9z",
            "ZWN1cml0eU1hcmtzEkRwcm9qZWN0cy97cHJvamVjdH0vc291cmNlcy97c291",
            "cmNlfS9maW5kaW5ncy97ZmluZGluZ30vc2VjdXJpdHlNYXJrc0LaAQoiY29t",
            "Lmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MVABWkxnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL3NlY3VyaXR5Y2Vu",
            "dGVyL3YxO3NlY3VyaXR5Y2VudGVyqgIeR29vZ2xlLkNsb3VkLlNlY3VyaXR5",
            "Q2VudGVyLlYxygIeR29vZ2xlXENsb3VkXFNlY3VyaXR5Q2VudGVyXFYx6gIh",
            "R29vZ2xlOjpDbG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.SecurityMarks), global::Google.Cloud.SecurityCenter.V1.SecurityMarks.Parser, new[]{ "Name", "Marks", "CanonicalName" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// User specified security marks that are attached to the parent Security
  /// Command Center resource. Security marks are scoped within a Security Command
  /// Center organization -- they can be modified and viewed by all users who have
  /// proper permissions on the organization.
  /// </summary>
  public sealed partial class SecurityMarks : pb::IMessage<SecurityMarks>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SecurityMarks> _parser = new pb::MessageParser<SecurityMarks>(() => new SecurityMarks());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SecurityMarks> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.SecurityMarksReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecurityMarks() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecurityMarks(SecurityMarks other) : this() {
      name_ = other.name_;
      marks_ = other.marks_.Clone();
      canonicalName_ = other.canonicalName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecurityMarks Clone() {
      return new SecurityMarks(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of the SecurityMarks. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Examples:
    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "marks" field.</summary>
    public const int MarksFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_marks_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> marks_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Mutable user specified security marks belonging to the parent resource.
    /// Constraints are as follows:
    ///
    ///   * Keys and values are treated as case insensitive
    ///   * Keys must be between 1 - 256 characters (inclusive)
    ///   * Keys must be letters, numbers, underscores, or dashes
    ///   * Values have leading and trailing whitespace trimmed, remaining
    ///     characters must be between 1 - 4096 characters (inclusive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Marks {
      get { return marks_; }
    }

    /// <summary>Field number for the "canonical_name" field.</summary>
    public const int CanonicalNameFieldNumber = 3;
    private string canonicalName_ = "";
    /// <summary>
    /// The canonical name of the marks.
    /// Examples:
    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
    /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
    /// "projects/{project_number}/assets/{asset_id}/securityMarks"
    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
    /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CanonicalName {
      get { return canonicalName_; }
      set {
        canonicalName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SecurityMarks);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SecurityMarks other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Marks.Equals(other.Marks)) return false;
      if (CanonicalName != other.CanonicalName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Marks.GetHashCode();
      if (CanonicalName.Length != 0) hash ^= CanonicalName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      marks_.WriteTo(output, _map_marks_codec);
      if (CanonicalName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CanonicalName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      marks_.WriteTo(ref output, _map_marks_codec);
      if (CanonicalName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CanonicalName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += marks_.CalculateSize(_map_marks_codec);
      if (CanonicalName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CanonicalName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SecurityMarks other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      marks_.Add(other.marks_);
      if (other.CanonicalName.Length != 0) {
        CanonicalName = other.CanonicalName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
            marks_.AddEntriesFrom(input, _map_marks_codec);
            break;
          }
          case 26: {
            CanonicalName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            marks_.AddEntriesFrom(ref input, _map_marks_codec);
            break;
          }
          case 26: {
            CanonicalName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
