// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkRest/FieldDesc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkRest/FieldDesc.proto</summary>
  public static partial class FieldDescReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkRest/FieldDesc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldDescReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQcm90b2J1Zi9NTGlua1Jlc3QvRmllbGREZXNjLnByb3RvEhNzcGlkZXJy",
            "b2NrLnByb3RvYnVmGhdzcGlkZXJyb2NrX2NvbW1vbi5wcm90byKiBAoJRmll",
            "bGREZXNjEjMKBV9tZXRhGAEgASgLMiQuc3BpZGVycm9jay5wcm90b2J1Zi5N",
            "ZXNzYWdlTWV0YWRhdGESCwoDcG9zGGQgASgNEgwKBG5hbWUYZyABKAkSDQoF",
            "Zl9udW0YaiABKA0SKwoHaXNfcGtleRhtIAEoDjIaLnNwaWRlcnJvY2sucHJv",
            "dG9idWYuWWVzTm8SEwoLaW5fcmVwZWF0ZXIYcCABKAkSLgoGZl90eXBlGHMg",
            "ASgOMh4uc3BpZGVycm9jay5wcm90b2J1Zi5GaWVsZFR5cGUSFQoNanNvbl9l",
            "bmNfdHlwZRh2IAEoCRIWCg5wcm90b19lbmNfdHlwZRh5IAEoCRINCgVzX2xl",
            "bhh8IAEoDRIOCgZlX25hbWUYfyABKAkSDgoFZV9zZXQYggEgASgJEhQKC2Rl",
            "ZmF1bHRfdmFsGIUBIAEoCRINCgRkZXNjGIgBIAEoCRIyCgZmX2N0cmwYiwEg",
            "ASgOMiEuc3BpZGVycm9jay5wcm90b2J1Zi5GaWVsZENvbnRyb2wSDgoFbWlu",
            "X3YYjgEgASgBEg4KBW1heF92GJEBIAEoARISCgltZXRhX3R5cGUYlAEgASgJ",
            "Eg4KBWxhYmVsGJcBIAEoCRIOCgVncm91cBiaASABKAkSDwoGZm9ybWF0GJ0B",
            "IAEoCRIQCgdjX2NvbG9yGKABIAEoBRIWCg1jb250ZXh0X3F1ZXJ5GKMBIAEo",
            "CWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.FieldDesc), global::Spiderrock.Protobuf.FieldDesc.Parser, new[]{ "Meta", "Pos", "Name", "FNum", "IsPkey", "InRepeater", "FType", "JsonEncType", "ProtoEncType", "SLen", "EName", "ESet", "DefaultVal", "Desc", "FCtrl", "MinV", "MaxV", "MetaType", "Label", "Group", "Format", "CColor", "ContextQuery" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FieldDesc : pb::IMessage<FieldDesc>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FieldDesc> _parser = new pb::MessageParser<FieldDesc>(() => new FieldDesc());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FieldDesc> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.FieldDescReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldDesc() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldDesc(FieldDesc other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pos_ = other.pos_;
      name_ = other.name_;
      fNum_ = other.fNum_;
      isPkey_ = other.isPkey_;
      inRepeater_ = other.inRepeater_;
      fType_ = other.fType_;
      jsonEncType_ = other.jsonEncType_;
      protoEncType_ = other.protoEncType_;
      sLen_ = other.sLen_;
      eName_ = other.eName_;
      eSet_ = other.eSet_;
      defaultVal_ = other.defaultVal_;
      desc_ = other.desc_;
      fCtrl_ = other.fCtrl_;
      minV_ = other.minV_;
      maxV_ = other.maxV_;
      metaType_ = other.metaType_;
      label_ = other.label_;
      group_ = other.group_;
      format_ = other.format_;
      cColor_ = other.cColor_;
      contextQuery_ = other.contextQuery_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldDesc Clone() {
      return new FieldDesc(this);
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

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 100;
    private uint pos_;
    /// <summary>
    /// position in message (1...N)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 103;
    private string name_ = "";
    /// <summary>
    /// field name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "f_num" field.</summary>
    public const int FNumFieldNumber = 106;
    private uint fNum_;
    /// <summary>
    /// protobuf field number
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FNum {
      get { return fNum_; }
      set {
        fNum_ = value;
      }
    }

    /// <summary>Field number for the "is_pkey" field.</summary>
    public const int IsPkeyFieldNumber = 109;
    private global::Spiderrock.Protobuf.YesNo isPkey_ = global::Spiderrock.Protobuf.YesNo.Unspecified;
    /// <summary>
    /// YesNo enum  (if field is a primary key)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.YesNo IsPkey {
      get { return isPkey_; }
      set {
        isPkey_ = value;
      }
    }

    /// <summary>Field number for the "in_repeater" field.</summary>
    public const int InRepeaterFieldNumber = 112;
    private string inRepeater_ = "";
    /// <summary>
    /// if field is in a repeating group, the repeater's name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InRepeater {
      get { return inRepeater_; }
      set {
        inRepeater_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "f_type" field.</summary>
    public const int FTypeFieldNumber = 115;
    private global::Spiderrock.Protobuf.FieldType fType_ = global::Spiderrock.Protobuf.FieldType.Unspecified;
    /// <summary>
    /// Field Type
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.FieldType FType {
      get { return fType_; }
      set {
        fType_ = value;
      }
    }

    /// <summary>Field number for the "json_enc_type" field.</summary>
    public const int JsonEncTypeFieldNumber = 118;
    private string jsonEncType_ = "";
    /// <summary>
    /// overriden type specifically for JSON encoding
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JsonEncType {
      get { return jsonEncType_; }
      set {
        jsonEncType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "proto_enc_type" field.</summary>
    public const int ProtoEncTypeFieldNumber = 121;
    private string protoEncType_ = "";
    /// <summary>
    /// overriden type specifically for protobuf encoding
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProtoEncType {
      get { return protoEncType_; }
      set {
        protoEncType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "s_len" field.</summary>
    public const int SLenFieldNumber = 124;
    private uint sLen_;
    /// <summary>
    /// string length (if fType is string)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SLen {
      get { return sLen_; }
      set {
        sLen_ = value;
      }
    }

    /// <summary>Field number for the "e_name" field.</summary>
    public const int ENameFieldNumber = 127;
    private string eName_ = "";
    /// <summary>
    /// enum name (if fType is enum)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EName {
      get { return eName_; }
      set {
        eName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "e_set" field.</summary>
    public const int ESetFieldNumber = 130;
    private string eSet_ = "";
    /// <summary>
    /// comma separated list of enum or string values (can be specific for a given user; default complete set)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ESet {
      get { return eSet_; }
      set {
        eSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "default_val" field.</summary>
    public const int DefaultValFieldNumber = 133;
    private string defaultVal_ = "";
    /// <summary>
    /// from Core.def: (...) can be a string, number, xKey, or partial xKey
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DefaultVal {
      get { return defaultVal_; }
      set {
        defaultVal_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "desc" field.</summary>
    public const int DescFieldNumber = 136;
    private string desc_ = "";
    /// <summary>
    /// from core.def: ... # comment line
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Desc {
      get { return desc_; }
      set {
        desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "f_ctrl" field.</summary>
    public const int FCtrlFieldNumber = 139;
    private global::Spiderrock.Protobuf.FieldControl fCtrl_ = global::Spiderrock.Protobuf.FieldControl.Unspecified;
    /// <summary>
    /// None = should not be visible; View = view only; Edit = View/Edit; Hide = Suppress on UI; Init = only can set during message creation; (form level directive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.FieldControl FCtrl {
      get { return fCtrl_; }
      set {
        fCtrl_ = value;
      }
    }

    /// <summary>Field number for the "min_v" field.</summary>
    public const int MinVFieldNumber = 142;
    private double minV_;
    /// <summary>
    /// form edit number range min bound (if field is a numeric type) [enforced on edit]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MinV {
      get { return minV_; }
      set {
        minV_ = value;
      }
    }

    /// <summary>Field number for the "max_v" field.</summary>
    public const int MaxVFieldNumber = 145;
    private double maxV_;
    /// <summary>
    /// form edit number range max bound (if field is a numeric type) [enforced on edit]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MaxV {
      get { return maxV_; }
      set {
        maxV_ = value;
      }
    }

    /// <summary>Field number for the "meta_type" field.</summary>
    public const int MetaTypeFieldNumber = 148;
    private string metaType_ = "";
    /// <summary>
    /// metatype associated with field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MetaType {
      get { return metaType_; }
      set {
        metaType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 151;
    private string label_ = "";
    /// <summary>
    /// column (grid) and widget (form) label
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "group" field.</summary>
    public const int GroupFieldNumber = 154;
    private string group_ = "";
    /// <summary>
    /// form flow groups
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Group {
      get { return group_; }
      set {
        group_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "format" field.</summary>
    public const int FormatFieldNumber = 157;
    private string format_ = "";
    /// <summary>
    /// numeric format string (eg. '#,###.00') (both grid and form)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Format {
      get { return format_; }
      set {
        format_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "c_color" field.</summary>
    public const int CColorFieldNumber = 160;
    private int cColor_;
    /// <summary>
    /// grid column color number (color palette number) (0 means undefined)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CColor {
      get { return cColor_; }
      set {
        cColor_ = value;
      }
    }

    /// <summary>Field number for the "context_query" field.</summary>
    public const int ContextQueryFieldNumber = 163;
    private string contextQuery_ = "";
    /// <summary>
    /// context query for pseudo enum fields with format of contextQuery=otherMsgType|selectField|contextField|contextField|...|contextField
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ContextQuery {
      get { return contextQuery_; }
      set {
        contextQuery_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FieldDesc);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FieldDesc other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (Pos != other.Pos) return false;
      if (Name != other.Name) return false;
      if (FNum != other.FNum) return false;
      if (IsPkey != other.IsPkey) return false;
      if (InRepeater != other.InRepeater) return false;
      if (FType != other.FType) return false;
      if (JsonEncType != other.JsonEncType) return false;
      if (ProtoEncType != other.ProtoEncType) return false;
      if (SLen != other.SLen) return false;
      if (EName != other.EName) return false;
      if (ESet != other.ESet) return false;
      if (DefaultVal != other.DefaultVal) return false;
      if (Desc != other.Desc) return false;
      if (FCtrl != other.FCtrl) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MinV, other.MinV)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxV, other.MaxV)) return false;
      if (MetaType != other.MetaType) return false;
      if (Label != other.Label) return false;
      if (Group != other.Group) return false;
      if (Format != other.Format) return false;
      if (CColor != other.CColor) return false;
      if (ContextQuery != other.ContextQuery) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (Pos != 0) hash ^= Pos.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (FNum != 0) hash ^= FNum.GetHashCode();
      if (IsPkey != global::Spiderrock.Protobuf.YesNo.Unspecified) hash ^= IsPkey.GetHashCode();
      if (InRepeater.Length != 0) hash ^= InRepeater.GetHashCode();
      if (FType != global::Spiderrock.Protobuf.FieldType.Unspecified) hash ^= FType.GetHashCode();
      if (JsonEncType.Length != 0) hash ^= JsonEncType.GetHashCode();
      if (ProtoEncType.Length != 0) hash ^= ProtoEncType.GetHashCode();
      if (SLen != 0) hash ^= SLen.GetHashCode();
      if (EName.Length != 0) hash ^= EName.GetHashCode();
      if (ESet.Length != 0) hash ^= ESet.GetHashCode();
      if (DefaultVal.Length != 0) hash ^= DefaultVal.GetHashCode();
      if (Desc.Length != 0) hash ^= Desc.GetHashCode();
      if (FCtrl != global::Spiderrock.Protobuf.FieldControl.Unspecified) hash ^= FCtrl.GetHashCode();
      if (MinV != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MinV);
      if (MaxV != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxV);
      if (MetaType.Length != 0) hash ^= MetaType.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Group.Length != 0) hash ^= Group.GetHashCode();
      if (Format.Length != 0) hash ^= Format.GetHashCode();
      if (CColor != 0) hash ^= CColor.GetHashCode();
      if (ContextQuery.Length != 0) hash ^= ContextQuery.GetHashCode();
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
      if (Pos != 0) {
        output.WriteRawTag(160, 6);
        output.WriteUInt32(Pos);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Name);
      }
      if (FNum != 0) {
        output.WriteRawTag(208, 6);
        output.WriteUInt32(FNum);
      }
      if (IsPkey != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) IsPkey);
      }
      if (InRepeater.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(InRepeater);
      }
      if (FType != global::Spiderrock.Protobuf.FieldType.Unspecified) {
        output.WriteRawTag(152, 7);
        output.WriteEnum((int) FType);
      }
      if (JsonEncType.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(JsonEncType);
      }
      if (ProtoEncType.Length != 0) {
        output.WriteRawTag(202, 7);
        output.WriteString(ProtoEncType);
      }
      if (SLen != 0) {
        output.WriteRawTag(224, 7);
        output.WriteUInt32(SLen);
      }
      if (EName.Length != 0) {
        output.WriteRawTag(250, 7);
        output.WriteString(EName);
      }
      if (ESet.Length != 0) {
        output.WriteRawTag(146, 8);
        output.WriteString(ESet);
      }
      if (DefaultVal.Length != 0) {
        output.WriteRawTag(170, 8);
        output.WriteString(DefaultVal);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(194, 8);
        output.WriteString(Desc);
      }
      if (FCtrl != global::Spiderrock.Protobuf.FieldControl.Unspecified) {
        output.WriteRawTag(216, 8);
        output.WriteEnum((int) FCtrl);
      }
      if (MinV != 0D) {
        output.WriteRawTag(241, 8);
        output.WriteDouble(MinV);
      }
      if (MaxV != 0D) {
        output.WriteRawTag(137, 9);
        output.WriteDouble(MaxV);
      }
      if (MetaType.Length != 0) {
        output.WriteRawTag(162, 9);
        output.WriteString(MetaType);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(186, 9);
        output.WriteString(Label);
      }
      if (Group.Length != 0) {
        output.WriteRawTag(210, 9);
        output.WriteString(Group);
      }
      if (Format.Length != 0) {
        output.WriteRawTag(234, 9);
        output.WriteString(Format);
      }
      if (CColor != 0) {
        output.WriteRawTag(128, 10);
        output.WriteInt32(CColor);
      }
      if (ContextQuery.Length != 0) {
        output.WriteRawTag(154, 10);
        output.WriteString(ContextQuery);
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
      if (Pos != 0) {
        output.WriteRawTag(160, 6);
        output.WriteUInt32(Pos);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(186, 6);
        output.WriteString(Name);
      }
      if (FNum != 0) {
        output.WriteRawTag(208, 6);
        output.WriteUInt32(FNum);
      }
      if (IsPkey != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(232, 6);
        output.WriteEnum((int) IsPkey);
      }
      if (InRepeater.Length != 0) {
        output.WriteRawTag(130, 7);
        output.WriteString(InRepeater);
      }
      if (FType != global::Spiderrock.Protobuf.FieldType.Unspecified) {
        output.WriteRawTag(152, 7);
        output.WriteEnum((int) FType);
      }
      if (JsonEncType.Length != 0) {
        output.WriteRawTag(178, 7);
        output.WriteString(JsonEncType);
      }
      if (ProtoEncType.Length != 0) {
        output.WriteRawTag(202, 7);
        output.WriteString(ProtoEncType);
      }
      if (SLen != 0) {
        output.WriteRawTag(224, 7);
        output.WriteUInt32(SLen);
      }
      if (EName.Length != 0) {
        output.WriteRawTag(250, 7);
        output.WriteString(EName);
      }
      if (ESet.Length != 0) {
        output.WriteRawTag(146, 8);
        output.WriteString(ESet);
      }
      if (DefaultVal.Length != 0) {
        output.WriteRawTag(170, 8);
        output.WriteString(DefaultVal);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(194, 8);
        output.WriteString(Desc);
      }
      if (FCtrl != global::Spiderrock.Protobuf.FieldControl.Unspecified) {
        output.WriteRawTag(216, 8);
        output.WriteEnum((int) FCtrl);
      }
      if (MinV != 0D) {
        output.WriteRawTag(241, 8);
        output.WriteDouble(MinV);
      }
      if (MaxV != 0D) {
        output.WriteRawTag(137, 9);
        output.WriteDouble(MaxV);
      }
      if (MetaType.Length != 0) {
        output.WriteRawTag(162, 9);
        output.WriteString(MetaType);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(186, 9);
        output.WriteString(Label);
      }
      if (Group.Length != 0) {
        output.WriteRawTag(210, 9);
        output.WriteString(Group);
      }
      if (Format.Length != 0) {
        output.WriteRawTag(234, 9);
        output.WriteString(Format);
      }
      if (CColor != 0) {
        output.WriteRawTag(128, 10);
        output.WriteInt32(CColor);
      }
      if (ContextQuery.Length != 0) {
        output.WriteRawTag(154, 10);
        output.WriteString(ContextQuery);
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
      if (Pos != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      if (Name.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (FNum != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(FNum);
      }
      if (IsPkey != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) IsPkey);
      }
      if (InRepeater.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(InRepeater);
      }
      if (FType != global::Spiderrock.Protobuf.FieldType.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) FType);
      }
      if (JsonEncType.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(JsonEncType);
      }
      if (ProtoEncType.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ProtoEncType);
      }
      if (SLen != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SLen);
      }
      if (EName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(EName);
      }
      if (ESet.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ESet);
      }
      if (DefaultVal.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(DefaultVal);
      }
      if (Desc.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Desc);
      }
      if (FCtrl != global::Spiderrock.Protobuf.FieldControl.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) FCtrl);
      }
      if (MinV != 0D) {
        size += 2 + 8;
      }
      if (MaxV != 0D) {
        size += 2 + 8;
      }
      if (MetaType.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(MetaType);
      }
      if (Label.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Group.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Group);
      }
      if (Format.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Format);
      }
      if (CColor != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(CColor);
      }
      if (ContextQuery.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ContextQuery);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FieldDesc other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.FNum != 0) {
        FNum = other.FNum;
      }
      if (other.IsPkey != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        IsPkey = other.IsPkey;
      }
      if (other.InRepeater.Length != 0) {
        InRepeater = other.InRepeater;
      }
      if (other.FType != global::Spiderrock.Protobuf.FieldType.Unspecified) {
        FType = other.FType;
      }
      if (other.JsonEncType.Length != 0) {
        JsonEncType = other.JsonEncType;
      }
      if (other.ProtoEncType.Length != 0) {
        ProtoEncType = other.ProtoEncType;
      }
      if (other.SLen != 0) {
        SLen = other.SLen;
      }
      if (other.EName.Length != 0) {
        EName = other.EName;
      }
      if (other.ESet.Length != 0) {
        ESet = other.ESet;
      }
      if (other.DefaultVal.Length != 0) {
        DefaultVal = other.DefaultVal;
      }
      if (other.Desc.Length != 0) {
        Desc = other.Desc;
      }
      if (other.FCtrl != global::Spiderrock.Protobuf.FieldControl.Unspecified) {
        FCtrl = other.FCtrl;
      }
      if (other.MinV != 0D) {
        MinV = other.MinV;
      }
      if (other.MaxV != 0D) {
        MaxV = other.MaxV;
      }
      if (other.MetaType.Length != 0) {
        MetaType = other.MetaType;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Group.Length != 0) {
        Group = other.Group;
      }
      if (other.Format.Length != 0) {
        Format = other.Format;
      }
      if (other.CColor != 0) {
        CColor = other.CColor;
      }
      if (other.ContextQuery.Length != 0) {
        ContextQuery = other.ContextQuery;
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
            Pos = input.ReadUInt32();
            break;
          }
          case 826: {
            Name = input.ReadString();
            break;
          }
          case 848: {
            FNum = input.ReadUInt32();
            break;
          }
          case 872: {
            IsPkey = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 898: {
            InRepeater = input.ReadString();
            break;
          }
          case 920: {
            FType = (global::Spiderrock.Protobuf.FieldType) input.ReadEnum();
            break;
          }
          case 946: {
            JsonEncType = input.ReadString();
            break;
          }
          case 970: {
            ProtoEncType = input.ReadString();
            break;
          }
          case 992: {
            SLen = input.ReadUInt32();
            break;
          }
          case 1018: {
            EName = input.ReadString();
            break;
          }
          case 1042: {
            ESet = input.ReadString();
            break;
          }
          case 1066: {
            DefaultVal = input.ReadString();
            break;
          }
          case 1090: {
            Desc = input.ReadString();
            break;
          }
          case 1112: {
            FCtrl = (global::Spiderrock.Protobuf.FieldControl) input.ReadEnum();
            break;
          }
          case 1137: {
            MinV = input.ReadDouble();
            break;
          }
          case 1161: {
            MaxV = input.ReadDouble();
            break;
          }
          case 1186: {
            MetaType = input.ReadString();
            break;
          }
          case 1210: {
            Label = input.ReadString();
            break;
          }
          case 1234: {
            Group = input.ReadString();
            break;
          }
          case 1258: {
            Format = input.ReadString();
            break;
          }
          case 1280: {
            CColor = input.ReadInt32();
            break;
          }
          case 1306: {
            ContextQuery = input.ReadString();
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
            Pos = input.ReadUInt32();
            break;
          }
          case 826: {
            Name = input.ReadString();
            break;
          }
          case 848: {
            FNum = input.ReadUInt32();
            break;
          }
          case 872: {
            IsPkey = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 898: {
            InRepeater = input.ReadString();
            break;
          }
          case 920: {
            FType = (global::Spiderrock.Protobuf.FieldType) input.ReadEnum();
            break;
          }
          case 946: {
            JsonEncType = input.ReadString();
            break;
          }
          case 970: {
            ProtoEncType = input.ReadString();
            break;
          }
          case 992: {
            SLen = input.ReadUInt32();
            break;
          }
          case 1018: {
            EName = input.ReadString();
            break;
          }
          case 1042: {
            ESet = input.ReadString();
            break;
          }
          case 1066: {
            DefaultVal = input.ReadString();
            break;
          }
          case 1090: {
            Desc = input.ReadString();
            break;
          }
          case 1112: {
            FCtrl = (global::Spiderrock.Protobuf.FieldControl) input.ReadEnum();
            break;
          }
          case 1137: {
            MinV = input.ReadDouble();
            break;
          }
          case 1161: {
            MaxV = input.ReadDouble();
            break;
          }
          case 1186: {
            MetaType = input.ReadString();
            break;
          }
          case 1210: {
            Label = input.ReadString();
            break;
          }
          case 1234: {
            Group = input.ReadString();
            break;
          }
          case 1258: {
            Format = input.ReadString();
            break;
          }
          case 1280: {
            CColor = input.ReadInt32();
            break;
          }
          case 1306: {
            ContextQuery = input.ReadString();
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
