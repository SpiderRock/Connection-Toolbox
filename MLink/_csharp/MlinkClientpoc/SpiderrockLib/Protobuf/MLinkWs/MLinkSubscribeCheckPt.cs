// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkWs/MLinkSubscribeCheckPt.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkWs/MLinkSubscribeCheckPt.proto</summary>
  public static partial class MLinkSubscribeCheckPtReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkWs/MLinkSubscribeCheckPt.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MLinkSubscribeCheckPtReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQcm90b2J1Zi9NTGlua1dzL01MaW5rU3Vic2NyaWJlQ2hlY2tQdC5wcm90",
            "bxITc3BpZGVycm9jay5wcm90b2J1ZhoXc3BpZGVycm9ja19jb21tb24ucHJv",
            "dG8i0gEKFU1MaW5rU3Vic2NyaWJlQ2hlY2tQdBIzCgVfbWV0YRgBIAEoCzIk",
            "LnNwaWRlcnJvY2sucHJvdG9idWYuTWVzc2FnZU1ldGFkYXRhEhIKCnNlc3Np",
            "b25faUQYZCABKAUSFAoMc3Vic2NyaWJlX2lEGGcgASgDEhEKCXNpZ25hbF9p",
            "RBhqIAEoAxI3CgVzdGF0ZRhtIAEoDjIoLnNwaWRlcnJvY2sucHJvdG9idWYu",
            "TUxpbmtTdWJzY3JpYmVTdGF0ZRIOCgZkZXRhaWwYcCABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.MLinkSubscribeCheckPt), global::Spiderrock.Protobuf.MLinkSubscribeCheckPt.Parser, new[]{ "Meta", "SessionID", "SubscribeID", "SignalID", "State", "Detail" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MLinkSubscribeCheckPt : pb::IMessage<MLinkSubscribeCheckPt>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MLinkSubscribeCheckPt> _parser = new pb::MessageParser<MLinkSubscribeCheckPt>(() => new MLinkSubscribeCheckPt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MLinkSubscribeCheckPt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.MLinkSubscribeCheckPtReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkSubscribeCheckPt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkSubscribeCheckPt(MLinkSubscribeCheckPt other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      sessionID_ = other.sessionID_;
      subscribeID_ = other.subscribeID_;
      signalID_ = other.signalID_;
      state_ = other.state_;
      detail_ = other.detail_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkSubscribeCheckPt Clone() {
      return new MLinkSubscribeCheckPt(this);
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

    /// <summary>Field number for the "session_iD" field.</summary>
    public const int SessionIDFieldNumber = 100;
    private int sessionID_;
    /// <summary>
    /// from MLinkSubscribe.sessionID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SessionID {
      get { return sessionID_; }
      set {
        sessionID_ = value;
      }
    }

    /// <summary>Field number for the "subscribe_iD" field.</summary>
    public const int SubscribeIDFieldNumber = 103;
    private long subscribeID_;
    /// <summary>
    /// from MLinkSubscribe.subscribeID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SubscribeID {
      get { return subscribeID_; }
      set {
        subscribeID_ = value;
      }
    }

    /// <summary>Field number for the "signal_iD" field.</summary>
    public const int SignalIDFieldNumber = 106;
    private long signalID_;
    /// <summary>
    /// MLinkSignalReady.signalID (if send sequence triggered by an MLinkSignalReady message)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SignalID {
      get { return signalID_; }
      set {
        signalID_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 109;
    private global::Spiderrock.Protobuf.MLinkSubscribeState state_ = global::Spiderrock.Protobuf.MLinkSubscribeState.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MLinkSubscribeState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "detail" field.</summary>
    public const int DetailFieldNumber = 112;
    private string detail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Detail {
      get { return detail_; }
      set {
        detail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MLinkSubscribeCheckPt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MLinkSubscribeCheckPt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (SessionID != other.SessionID) return false;
      if (SubscribeID != other.SubscribeID) return false;
      if (SignalID != other.SignalID) return false;
      if (State != other.State) return false;
      if (Detail != other.Detail) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (SessionID != 0) hash ^= SessionID.GetHashCode();
      if (SubscribeID != 0L) hash ^= SubscribeID.GetHashCode();
      if (SignalID != 0L) hash ^= SignalID.GetHashCode();
      if (State != global::Spiderrock.Protobuf.MLinkSubscribeState.Unspecified) hash ^= State.GetHashCode();
      if (Detail.Length != 0) hash ^= Detail.GetHashCode();
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
      if (SessionID != 0) {
        output.WriteRawTag(160, 6);
        output.WriteInt32(SessionID);
      }
      if (SubscribeID != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(SubscribeID);
      }
      if (SignalID != 0L) {
        output.WriteRawTag(208, 6);
        output.WriteInt64(SignalID);
      }
      if (State != global::Spiderrock.Protobuf.MLinkSubscribeState.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) State);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Detail);
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
      if (SessionID != 0) {
        output.WriteRawTag(160, 6);
        output.WriteInt32(SessionID);
      }
      if (SubscribeID != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(SubscribeID);
      }
      if (SignalID != 0L) {
        output.WriteRawTag(208, 6);
        output.WriteInt64(SignalID);
      }
      if (State != global::Spiderrock.Protobuf.MLinkSubscribeState.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) State);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(Detail);
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
      if (SessionID != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(SessionID);
      }
      if (SubscribeID != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(SubscribeID);
      }
      if (SignalID != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(SignalID);
      }
      if (State != global::Spiderrock.Protobuf.MLinkSubscribeState.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Detail.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Detail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MLinkSubscribeCheckPt other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.SessionID != 0) {
        SessionID = other.SessionID;
      }
      if (other.SubscribeID != 0L) {
        SubscribeID = other.SubscribeID;
      }
      if (other.SignalID != 0L) {
        SignalID = other.SignalID;
      }
      if (other.State != global::Spiderrock.Protobuf.MLinkSubscribeState.Unspecified) {
        State = other.State;
      }
      if (other.Detail.Length != 0) {
        Detail = other.Detail;
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
          case 800: {
            SessionID = input.ReadInt32();
            break;
          }
          case 824: {
            SubscribeID = input.ReadInt64();
            break;
          }
          case 848: {
            SignalID = input.ReadInt64();
            break;
          }
          case 872: {
            State = (global::Spiderrock.Protobuf.MLinkSubscribeState) input.ReadEnum();
            break;
          }
          case 898: {
            Detail = input.ReadString();
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
          case 800: {
            SessionID = input.ReadInt32();
            break;
          }
          case 824: {
            SubscribeID = input.ReadInt64();
            break;
          }
          case 848: {
            SignalID = input.ReadInt64();
            break;
          }
          case 872: {
            State = (global::Spiderrock.Protobuf.MLinkSubscribeState) input.ReadEnum();
            break;
          }
          case 898: {
            Detail = input.ReadString();
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
