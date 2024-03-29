// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkWs/MLinkLogon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkWs/MLinkLogon.proto</summary>
  public static partial class MLinkLogonReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkWs/MLinkLogon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MLinkLogonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQcm90b2J1Zi9NTGlua1dzL01MaW5rTG9nb24ucHJvdG8SE3NwaWRlcnJv",
            "Y2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29tbW9uLnByb3RvIpcBCgpNTGlu",
            "a0xvZ29uEjMKBV9tZXRhGAEgASgLMiQuc3BpZGVycm9jay5wcm90b2J1Zi5N",
            "ZXNzYWdlTWV0YWRhdGESEQoJdXNlcl9uYW1lGGQgASgJEhAKCHBhc3N3b3Jk",
            "GGcgASgJEgsKA3BpbhhqIAEoCRIPCgdhcGlfa2V5GG0gASgJEhEKCWp3dF90",
            "b2tlbhhwIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.MLinkLogon), global::Spiderrock.Protobuf.MLinkLogon.Parser, new[]{ "Meta", "UserName", "Password", "Pin", "ApiKey", "JwtToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MLinkLogon : pb::IMessage<MLinkLogon>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MLinkLogon> _parser = new pb::MessageParser<MLinkLogon>(() => new MLinkLogon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MLinkLogon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.MLinkLogonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkLogon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkLogon(MLinkLogon other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      userName_ = other.userName_;
      password_ = other.password_;
      pin_ = other.pin_;
      apiKey_ = other.apiKey_;
      jwtToken_ = other.jwtToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkLogon Clone() {
      return new MLinkLogon(this);
    }

    /// <summary>Field number for the "_meta" field.</summary>
    public const int MetaFieldNumber = 1;
    private global::Spiderrock.Protobuf.MessageMetadata Meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MessageMetadata Meta {
      get { return Meta_; }
      set {
        Meta_ = value;
      }
    }

    /// <summary>Field number for the "user_name" field.</summary>
    public const int UserNameFieldNumber = 100;
    private string userName_ = "";
    /// <summary>
    /// SR UserName
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 103;
    private string password_ = "";
    /// <summary>
    /// client supplied secret (optional; required if supplied previously)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pin" field.</summary>
    public const int PinFieldNumber = 106;
    private string pin_ = "";
    /// <summary>
    /// SR Mfa Pin
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Pin {
      get { return pin_; }
      set {
        pin_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "api_key" field.</summary>
    public const int ApiKeyFieldNumber = 109;
    private string apiKey_ = "";
    /// <summary>
    /// SR generated API key
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ApiKey {
      get { return apiKey_; }
      set {
        apiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "jwt_token" field.</summary>
    public const int JwtTokenFieldNumber = 112;
    private string jwtToken_ = "";
    /// <summary>
    /// Cognito JWT token
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JwtToken {
      get { return jwtToken_; }
      set {
        jwtToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MLinkLogon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MLinkLogon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (UserName != other.UserName) return false;
      if (Password != other.Password) return false;
      if (Pin != other.Pin) return false;
      if (ApiKey != other.ApiKey) return false;
      if (JwtToken != other.JwtToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (Pin.Length != 0) hash ^= Pin.GetHashCode();
      if (ApiKey.Length != 0) hash ^= ApiKey.GetHashCode();
      if (JwtToken.Length != 0) hash ^= JwtToken.GetHashCode();
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
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(UserName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Password);
      }
      if (Pin.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Pin);
      }
      if (ApiKey.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(ApiKey);
      }
      if (JwtToken.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(JwtToken);
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
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteString(UserName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Password);
      }
      if (Pin.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(Pin);
      }
      if (ApiKey.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(ApiKey);
      }
      if (JwtToken.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(JwtToken);
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
      if (Meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      if (UserName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (Password.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (Pin.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Pin);
      }
      if (ApiKey.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ApiKey);
      }
      if (JwtToken.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(JwtToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MLinkLogon other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      if (other.Pin.Length != 0) {
        Pin = other.Pin;
      }
      if (other.ApiKey.Length != 0) {
        ApiKey = other.ApiKey;
      }
      if (other.JwtToken.Length != 0) {
        JwtToken = other.JwtToken;
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
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 802: {
            UserName = input.ReadString();
            break;
          }
          case 826: {
            Password = input.ReadString();
            break;
          }
          case 850: {
            Pin = input.ReadString();
            break;
          }
          case 874: {
            ApiKey = input.ReadString();
            break;
          }
          case 898: {
            JwtToken = input.ReadString();
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
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 802: {
            UserName = input.ReadString();
            break;
          }
          case 826: {
            Password = input.ReadString();
            break;
          }
          case 850: {
            Pin = input.ReadString();
            break;
          }
          case 874: {
            ApiKey = input.ReadString();
            break;
          }
          case 898: {
            JwtToken = input.ReadString();
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
