// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/texttospeech/v1/cloud_tts_lrs.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.TextToSpeech.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/texttospeech/v1/cloud_tts_lrs.proto</summary>
  public static partial class CloudTtsLrsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/texttospeech/v1/cloud_tts_lrs.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudTtsLrsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvdGV4dHRvc3BlZWNoL3YxL2Nsb3VkX3R0c19scnMu",
            "cHJvdG8SHGdvb2dsZS5jbG91ZC50ZXh0dG9zcGVlY2gudjEaHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3Rv",
            "Gh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGixnb29nbGUvY2xv",
            "dWQvdGV4dHRvc3BlZWNoL3YxL2Nsb3VkX3R0cy5wcm90bxojZ29vZ2xlL2xv",
            "bmdydW5uaW5nL29wZXJhdGlvbnMucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8ijwIKGlN5bnRoZXNpemVMb25nQXVkaW9SZXF1ZXN0",
            "Eg4KBnBhcmVudBgBIAEoCRJACgVpbnB1dBgCIAEoCzIsLmdvb2dsZS5jbG91",
            "ZC50ZXh0dG9zcGVlY2gudjEuU3ludGhlc2lzSW5wdXRCA+BBAhJECgxhdWRp",
            "b19jb25maWcYAyABKAsyKS5nb29nbGUuY2xvdWQudGV4dHRvc3BlZWNoLnYx",
            "LkF1ZGlvQ29uZmlnQgPgQQISFgoOb3V0cHV0X2djc191cmkYBCABKAkSQQoF",
            "dm9pY2UYBSABKAsyMi5nb29nbGUuY2xvdWQudGV4dHRvc3BlZWNoLnYxLlZv",
            "aWNlU2VsZWN0aW9uUGFyYW1zIh0KG1N5bnRoZXNpemVMb25nQXVkaW9SZXNw",
            "b25zZSKgAQobU3ludGhlc2l6ZUxvbmdBdWRpb01ldGFkYXRhEi4KCnN0YXJ0",
            "X3RpbWUYASABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEjQKEGxh",
            "c3RfdXBkYXRlX3RpbWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wEhsKE3Byb2dyZXNzX3BlcmNlbnRhZ2UYAyABKAEy7gIKH1RleHRUb1Nw",
            "ZWVjaExvbmdBdWRpb1N5bnRoZXNpemUS+QEKE1N5bnRoZXNpemVMb25nQXVk",
            "aW8SOC5nb29nbGUuY2xvdWQudGV4dHRvc3BlZWNoLnYxLlN5bnRoZXNpemVM",
            "b25nQXVkaW9SZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlv",
            "biKIAYLT5JMCRSJAL3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMv",
            "Ki92b2ljZXMvKn06U3ludGhlc2l6ZUxvbmdBdWRpbzoBKspBOgobU3ludGhl",
            "c2l6ZUxvbmdBdWRpb1Jlc3BvbnNlEhtTeW50aGVzaXplTG9uZ0F1ZGlvTWV0",
            "YWRhdGEaT8pBG3RleHR0b3NwZWVjaC5nb29nbGVhcGlzLmNvbdJBLmh0dHBz",
            "Oi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm1C9gEK",
            "IGNvbS5nb29nbGUuY2xvdWQudGV4dHRvc3BlZWNoLnYxQiNUZXh0VG9TcGVl",
            "Y2hMb25nQXVkaW9TeW50aGVzaXNQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL3RleHR0b3NwZWVjaC92MTt0",
            "ZXh0dG9zcGVlY2j4AQGqAhxHb29nbGUuQ2xvdWQuVGV4dFRvU3BlZWNoLlYx",
            "ygIcR29vZ2xlXENsb3VkXFRleHRUb1NwZWVjaFxWMeoCH0dvb2dsZTo6Q2xv",
            "dWQ6OlRleHRUb1NwZWVjaDo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.TextToSpeech.V1.CloudTtsReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.TextToSpeech.V1.SynthesizeLongAudioRequest), global::Google.Cloud.TextToSpeech.V1.SynthesizeLongAudioRequest.Parser, new[]{ "Parent", "Input", "AudioConfig", "OutputGcsUri", "Voice" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.TextToSpeech.V1.SynthesizeLongAudioResponse), global::Google.Cloud.TextToSpeech.V1.SynthesizeLongAudioResponse.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.TextToSpeech.V1.SynthesizeLongAudioMetadata), global::Google.Cloud.TextToSpeech.V1.SynthesizeLongAudioMetadata.Parser, new[]{ "StartTime", "LastUpdateTime", "ProgressPercentage" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The top-level message sent by the client for the
  /// `SynthesizeLongAudio` method.
  /// </summary>
  public sealed partial class SynthesizeLongAudioRequest : pb::IMessage<SynthesizeLongAudioRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SynthesizeLongAudioRequest> _parser = new pb::MessageParser<SynthesizeLongAudioRequest>(() => new SynthesizeLongAudioRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SynthesizeLongAudioRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.TextToSpeech.V1.CloudTtsLrsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioRequest(SynthesizeLongAudioRequest other) : this() {
      parent_ = other.parent_;
      input_ = other.input_ != null ? other.input_.Clone() : null;
      audioConfig_ = other.audioConfig_ != null ? other.audioConfig_.Clone() : null;
      outputGcsUri_ = other.outputGcsUri_;
      voice_ = other.voice_ != null ? other.voice_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioRequest Clone() {
      return new SynthesizeLongAudioRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// The resource states of the request in the form of
    /// `projects/*/locations/*/voices/*`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "input" field.</summary>
    public const int InputFieldNumber = 2;
    private global::Google.Cloud.TextToSpeech.V1.SynthesisInput input_;
    /// <summary>
    /// Required. The Synthesizer requires either plain text or SSML as input.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.TextToSpeech.V1.SynthesisInput Input {
      get { return input_; }
      set {
        input_ = value;
      }
    }

    /// <summary>Field number for the "audio_config" field.</summary>
    public const int AudioConfigFieldNumber = 3;
    private global::Google.Cloud.TextToSpeech.V1.AudioConfig audioConfig_;
    /// <summary>
    /// Required. The configuration of the synthesized audio.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.TextToSpeech.V1.AudioConfig AudioConfig {
      get { return audioConfig_; }
      set {
        audioConfig_ = value;
      }
    }

    /// <summary>Field number for the "output_gcs_uri" field.</summary>
    public const int OutputGcsUriFieldNumber = 4;
    private string outputGcsUri_ = "";
    /// <summary>
    /// Specifies a Cloud Storage URI for the synthesis results. Must be
    /// specified in the format: `gs://bucket_name/object_name`, and the bucket
    /// must already exist.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OutputGcsUri {
      get { return outputGcsUri_; }
      set {
        outputGcsUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "voice" field.</summary>
    public const int VoiceFieldNumber = 5;
    private global::Google.Cloud.TextToSpeech.V1.VoiceSelectionParams voice_;
    /// <summary>
    /// The desired voice of the synthesized audio.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.TextToSpeech.V1.VoiceSelectionParams Voice {
      get { return voice_; }
      set {
        voice_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SynthesizeLongAudioRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SynthesizeLongAudioRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (!object.Equals(Input, other.Input)) return false;
      if (!object.Equals(AudioConfig, other.AudioConfig)) return false;
      if (OutputGcsUri != other.OutputGcsUri) return false;
      if (!object.Equals(Voice, other.Voice)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (input_ != null) hash ^= Input.GetHashCode();
      if (audioConfig_ != null) hash ^= AudioConfig.GetHashCode();
      if (OutputGcsUri.Length != 0) hash ^= OutputGcsUri.GetHashCode();
      if (voice_ != null) hash ^= Voice.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (input_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Input);
      }
      if (audioConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AudioConfig);
      }
      if (OutputGcsUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OutputGcsUri);
      }
      if (voice_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Voice);
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (input_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Input);
      }
      if (audioConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AudioConfig);
      }
      if (OutputGcsUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OutputGcsUri);
      }
      if (voice_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Voice);
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
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (input_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Input);
      }
      if (audioConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AudioConfig);
      }
      if (OutputGcsUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OutputGcsUri);
      }
      if (voice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Voice);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SynthesizeLongAudioRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.input_ != null) {
        if (input_ == null) {
          Input = new global::Google.Cloud.TextToSpeech.V1.SynthesisInput();
        }
        Input.MergeFrom(other.Input);
      }
      if (other.audioConfig_ != null) {
        if (audioConfig_ == null) {
          AudioConfig = new global::Google.Cloud.TextToSpeech.V1.AudioConfig();
        }
        AudioConfig.MergeFrom(other.AudioConfig);
      }
      if (other.OutputGcsUri.Length != 0) {
        OutputGcsUri = other.OutputGcsUri;
      }
      if (other.voice_ != null) {
        if (voice_ == null) {
          Voice = new global::Google.Cloud.TextToSpeech.V1.VoiceSelectionParams();
        }
        Voice.MergeFrom(other.Voice);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            if (input_ == null) {
              Input = new global::Google.Cloud.TextToSpeech.V1.SynthesisInput();
            }
            input.ReadMessage(Input);
            break;
          }
          case 26: {
            if (audioConfig_ == null) {
              AudioConfig = new global::Google.Cloud.TextToSpeech.V1.AudioConfig();
            }
            input.ReadMessage(AudioConfig);
            break;
          }
          case 34: {
            OutputGcsUri = input.ReadString();
            break;
          }
          case 42: {
            if (voice_ == null) {
              Voice = new global::Google.Cloud.TextToSpeech.V1.VoiceSelectionParams();
            }
            input.ReadMessage(Voice);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            if (input_ == null) {
              Input = new global::Google.Cloud.TextToSpeech.V1.SynthesisInput();
            }
            input.ReadMessage(Input);
            break;
          }
          case 26: {
            if (audioConfig_ == null) {
              AudioConfig = new global::Google.Cloud.TextToSpeech.V1.AudioConfig();
            }
            input.ReadMessage(AudioConfig);
            break;
          }
          case 34: {
            OutputGcsUri = input.ReadString();
            break;
          }
          case 42: {
            if (voice_ == null) {
              Voice = new global::Google.Cloud.TextToSpeech.V1.VoiceSelectionParams();
            }
            input.ReadMessage(Voice);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The message returned to the client by the `SynthesizeLongAudio` method.
  /// </summary>
  public sealed partial class SynthesizeLongAudioResponse : pb::IMessage<SynthesizeLongAudioResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SynthesizeLongAudioResponse> _parser = new pb::MessageParser<SynthesizeLongAudioResponse>(() => new SynthesizeLongAudioResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SynthesizeLongAudioResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.TextToSpeech.V1.CloudTtsLrsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioResponse(SynthesizeLongAudioResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioResponse Clone() {
      return new SynthesizeLongAudioResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SynthesizeLongAudioResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SynthesizeLongAudioResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SynthesizeLongAudioResponse other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Metadata for response returned by the `SynthesizeLongAudio` method.
  /// </summary>
  public sealed partial class SynthesizeLongAudioMetadata : pb::IMessage<SynthesizeLongAudioMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SynthesizeLongAudioMetadata> _parser = new pb::MessageParser<SynthesizeLongAudioMetadata>(() => new SynthesizeLongAudioMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SynthesizeLongAudioMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.TextToSpeech.V1.CloudTtsLrsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioMetadata(SynthesizeLongAudioMetadata other) : this() {
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      lastUpdateTime_ = other.lastUpdateTime_ != null ? other.lastUpdateTime_.Clone() : null;
      progressPercentage_ = other.progressPercentage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SynthesizeLongAudioMetadata Clone() {
      return new SynthesizeLongAudioMetadata(this);
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// Time when the request was received.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "last_update_time" field.</summary>
    public const int LastUpdateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdateTime_;
    /// <summary>
    /// Time of the most recent processing update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdateTime {
      get { return lastUpdateTime_; }
      set {
        lastUpdateTime_ = value;
      }
    }

    /// <summary>Field number for the "progress_percentage" field.</summary>
    public const int ProgressPercentageFieldNumber = 3;
    private double progressPercentage_;
    /// <summary>
    /// The progress of the most recent processing update in percentage, ie. 70.0%.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double ProgressPercentage {
      get { return progressPercentage_; }
      set {
        progressPercentage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SynthesizeLongAudioMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SynthesizeLongAudioMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(LastUpdateTime, other.LastUpdateTime)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ProgressPercentage, other.ProgressPercentage)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (lastUpdateTime_ != null) hash ^= LastUpdateTime.GetHashCode();
      if (ProgressPercentage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ProgressPercentage);
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
      if (startTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(StartTime);
      }
      if (lastUpdateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LastUpdateTime);
      }
      if (ProgressPercentage != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(ProgressPercentage);
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
      if (startTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(StartTime);
      }
      if (lastUpdateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LastUpdateTime);
      }
      if (ProgressPercentage != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(ProgressPercentage);
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
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (lastUpdateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastUpdateTime);
      }
      if (ProgressPercentage != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SynthesizeLongAudioMetadata other) {
      if (other == null) {
        return;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.lastUpdateTime_ != null) {
        if (lastUpdateTime_ == null) {
          LastUpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdateTime.MergeFrom(other.LastUpdateTime);
      }
      if (other.ProgressPercentage != 0D) {
        ProgressPercentage = other.ProgressPercentage;
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
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 18: {
            if (lastUpdateTime_ == null) {
              LastUpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdateTime);
            break;
          }
          case 25: {
            ProgressPercentage = input.ReadDouble();
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
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 18: {
            if (lastUpdateTime_ == null) {
              LastUpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdateTime);
            break;
          }
          case 25: {
            ProgressPercentage = input.ReadDouble();
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
