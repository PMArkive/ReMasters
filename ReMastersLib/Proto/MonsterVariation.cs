// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/MonsterVariation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/MonsterVariation.proto</summary>
  public static partial class MonsterVariationReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/MonsterVariation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterVariationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQcm90by9Nb25zdGVyVmFyaWF0aW9uLnByb3RvEgxSZU1hc3RlcnNMaWIi",
            "tAMKEE1vbnN0ZXJWYXJpYXRpb24SEgoKbW9uc3Rlcl9pZBgBIAEoBBIMCgRm",
            "b3JtGAIgASgNEhAKCGFjdG9yX2lkGAMgASgJEhEKCWF0a19zY2FsZRgEIAEo",
            "DRIRCglkZWZfc2NhbGUYBSABKA0SEQoJc3BhX3NjYWxlGAYgASgNEhEKCXNw",
            "ZF9zY2FsZRgHIAEoDRIRCglzcGVfc2NhbGUYCCABKA0SEQoJbW92ZV8xX2lk",
            "GAkgASgDEhEKCW1vdmVfMl9pZBgKIAEoAxIRCgltb3ZlXzNfaWQYCyABKAMS",
            "EQoJbW92ZV80X2lkGAwgASgDEhEKCW1vdmVfNV9pZBgNIAEoAxIRCgltb3Zl",
            "XzZfaWQYDiABKAMSFAoMcGFzc2l2ZV8xX2lkGA8gASgFEhQKDHBhc3NpdmVf",
            "Ml9pZBgQIAEoBRIUCgxwYXNzaXZlXzNfaWQYESABKAUSCwoDdTE4GBIgASgF",
            "EgsKA3UxORgTIAEoBRILCgN1MjAYFCABKAUSCwoDdTIxGBUgASgFEgsKA3Uy",
            "MhgWIAEoBRILCgN1MjMYFyABKAUSCwoDdTI0GBggASgFIkgKFU1vbnN0ZXJW",
            "YXJpYXRpb25UYWJsZRIvCgdlbnRyaWVzGAEgAygLMh4uUmVNYXN0ZXJzTGli",
            "Lk1vbnN0ZXJWYXJpYXRpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MonsterVariation), global::ReMastersLib.MonsterVariation.Parser, new[]{ "MonsterId", "Form", "ActorId", "AtkScale", "DefScale", "SpaScale", "SpdScale", "SpeScale", "Move1Id", "Move2Id", "Move3Id", "Move4Id", "Move5Id", "Move6Id", "Passive1Id", "Passive2Id", "Passive3Id", "U18", "U19", "U20", "U21", "U22", "U23", "U24" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MonsterVariationTable), global::ReMastersLib.MonsterVariationTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MonsterVariation : pb::IMessage<MonsterVariation> {
    private static readonly pb::MessageParser<MonsterVariation> _parser = new pb::MessageParser<MonsterVariation>(() => new MonsterVariation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonsterVariation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MonsterVariationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterVariation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterVariation(MonsterVariation other) : this() {
      monsterId_ = other.monsterId_;
      form_ = other.form_;
      actorId_ = other.actorId_;
      atkScale_ = other.atkScale_;
      defScale_ = other.defScale_;
      spaScale_ = other.spaScale_;
      spdScale_ = other.spdScale_;
      speScale_ = other.speScale_;
      move1Id_ = other.move1Id_;
      move2Id_ = other.move2Id_;
      move3Id_ = other.move3Id_;
      move4Id_ = other.move4Id_;
      move5Id_ = other.move5Id_;
      move6Id_ = other.move6Id_;
      passive1Id_ = other.passive1Id_;
      passive2Id_ = other.passive2Id_;
      passive3Id_ = other.passive3Id_;
      u18_ = other.u18_;
      u19_ = other.u19_;
      u20_ = other.u20_;
      u21_ = other.u21_;
      u22_ = other.u22_;
      u23_ = other.u23_;
      u24_ = other.u24_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterVariation Clone() {
      return new MonsterVariation(this);
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 1;
    private ulong monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "form" field.</summary>
    public const int FormFieldNumber = 2;
    private uint form_;
    /// <summary>
    /// 1 = Mega, 2 = Other
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Form {
      get { return form_; }
      set {
        form_ = value;
      }
    }

    /// <summary>Field number for the "actor_id" field.</summary>
    public const int ActorIdFieldNumber = 3;
    private string actorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActorId {
      get { return actorId_; }
      set {
        actorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "atk_scale" field.</summary>
    public const int AtkScaleFieldNumber = 4;
    private uint atkScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint AtkScale {
      get { return atkScale_; }
      set {
        atkScale_ = value;
      }
    }

    /// <summary>Field number for the "def_scale" field.</summary>
    public const int DefScaleFieldNumber = 5;
    private uint defScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DefScale {
      get { return defScale_; }
      set {
        defScale_ = value;
      }
    }

    /// <summary>Field number for the "spa_scale" field.</summary>
    public const int SpaScaleFieldNumber = 6;
    private uint spaScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SpaScale {
      get { return spaScale_; }
      set {
        spaScale_ = value;
      }
    }

    /// <summary>Field number for the "spd_scale" field.</summary>
    public const int SpdScaleFieldNumber = 7;
    private uint spdScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SpdScale {
      get { return spdScale_; }
      set {
        spdScale_ = value;
      }
    }

    /// <summary>Field number for the "spe_scale" field.</summary>
    public const int SpeScaleFieldNumber = 8;
    private uint speScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SpeScale {
      get { return speScale_; }
      set {
        speScale_ = value;
      }
    }

    /// <summary>Field number for the "move_1_id" field.</summary>
    public const int Move1IdFieldNumber = 9;
    private long move1Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Move1Id {
      get { return move1Id_; }
      set {
        move1Id_ = value;
      }
    }

    /// <summary>Field number for the "move_2_id" field.</summary>
    public const int Move2IdFieldNumber = 10;
    private long move2Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Move2Id {
      get { return move2Id_; }
      set {
        move2Id_ = value;
      }
    }

    /// <summary>Field number for the "move_3_id" field.</summary>
    public const int Move3IdFieldNumber = 11;
    private long move3Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Move3Id {
      get { return move3Id_; }
      set {
        move3Id_ = value;
      }
    }

    /// <summary>Field number for the "move_4_id" field.</summary>
    public const int Move4IdFieldNumber = 12;
    private long move4Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Move4Id {
      get { return move4Id_; }
      set {
        move4Id_ = value;
      }
    }

    /// <summary>Field number for the "move_5_id" field.</summary>
    public const int Move5IdFieldNumber = 13;
    private long move5Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Move5Id {
      get { return move5Id_; }
      set {
        move5Id_ = value;
      }
    }

    /// <summary>Field number for the "move_6_id" field.</summary>
    public const int Move6IdFieldNumber = 14;
    private long move6Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Move6Id {
      get { return move6Id_; }
      set {
        move6Id_ = value;
      }
    }

    /// <summary>Field number for the "passive_1_id" field.</summary>
    public const int Passive1IdFieldNumber = 15;
    private int passive1Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Passive1Id {
      get { return passive1Id_; }
      set {
        passive1Id_ = value;
      }
    }

    /// <summary>Field number for the "passive_2_id" field.</summary>
    public const int Passive2IdFieldNumber = 16;
    private int passive2Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Passive2Id {
      get { return passive2Id_; }
      set {
        passive2Id_ = value;
      }
    }

    /// <summary>Field number for the "passive_3_id" field.</summary>
    public const int Passive3IdFieldNumber = 17;
    private int passive3Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Passive3Id {
      get { return passive3Id_; }
      set {
        passive3Id_ = value;
      }
    }

    /// <summary>Field number for the "u18" field.</summary>
    public const int U18FieldNumber = 18;
    private int u18_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U18 {
      get { return u18_; }
      set {
        u18_ = value;
      }
    }

    /// <summary>Field number for the "u19" field.</summary>
    public const int U19FieldNumber = 19;
    private int u19_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U19 {
      get { return u19_; }
      set {
        u19_ = value;
      }
    }

    /// <summary>Field number for the "u20" field.</summary>
    public const int U20FieldNumber = 20;
    private int u20_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U20 {
      get { return u20_; }
      set {
        u20_ = value;
      }
    }

    /// <summary>Field number for the "u21" field.</summary>
    public const int U21FieldNumber = 21;
    private int u21_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U21 {
      get { return u21_; }
      set {
        u21_ = value;
      }
    }

    /// <summary>Field number for the "u22" field.</summary>
    public const int U22FieldNumber = 22;
    private int u22_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U22 {
      get { return u22_; }
      set {
        u22_ = value;
      }
    }

    /// <summary>Field number for the "u23" field.</summary>
    public const int U23FieldNumber = 23;
    private int u23_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U23 {
      get { return u23_; }
      set {
        u23_ = value;
      }
    }

    /// <summary>Field number for the "u24" field.</summary>
    public const int U24FieldNumber = 24;
    private int u24_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U24 {
      get { return u24_; }
      set {
        u24_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonsterVariation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonsterVariation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonsterId != other.MonsterId) return false;
      if (Form != other.Form) return false;
      if (ActorId != other.ActorId) return false;
      if (AtkScale != other.AtkScale) return false;
      if (DefScale != other.DefScale) return false;
      if (SpaScale != other.SpaScale) return false;
      if (SpdScale != other.SpdScale) return false;
      if (SpeScale != other.SpeScale) return false;
      if (Move1Id != other.Move1Id) return false;
      if (Move2Id != other.Move2Id) return false;
      if (Move3Id != other.Move3Id) return false;
      if (Move4Id != other.Move4Id) return false;
      if (Move5Id != other.Move5Id) return false;
      if (Move6Id != other.Move6Id) return false;
      if (Passive1Id != other.Passive1Id) return false;
      if (Passive2Id != other.Passive2Id) return false;
      if (Passive3Id != other.Passive3Id) return false;
      if (U18 != other.U18) return false;
      if (U19 != other.U19) return false;
      if (U20 != other.U20) return false;
      if (U21 != other.U21) return false;
      if (U22 != other.U22) return false;
      if (U23 != other.U23) return false;
      if (U24 != other.U24) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MonsterId != 0UL) hash ^= MonsterId.GetHashCode();
      if (Form != 0) hash ^= Form.GetHashCode();
      if (ActorId.Length != 0) hash ^= ActorId.GetHashCode();
      if (AtkScale != 0) hash ^= AtkScale.GetHashCode();
      if (DefScale != 0) hash ^= DefScale.GetHashCode();
      if (SpaScale != 0) hash ^= SpaScale.GetHashCode();
      if (SpdScale != 0) hash ^= SpdScale.GetHashCode();
      if (SpeScale != 0) hash ^= SpeScale.GetHashCode();
      if (Move1Id != 0L) hash ^= Move1Id.GetHashCode();
      if (Move2Id != 0L) hash ^= Move2Id.GetHashCode();
      if (Move3Id != 0L) hash ^= Move3Id.GetHashCode();
      if (Move4Id != 0L) hash ^= Move4Id.GetHashCode();
      if (Move5Id != 0L) hash ^= Move5Id.GetHashCode();
      if (Move6Id != 0L) hash ^= Move6Id.GetHashCode();
      if (Passive1Id != 0) hash ^= Passive1Id.GetHashCode();
      if (Passive2Id != 0) hash ^= Passive2Id.GetHashCode();
      if (Passive3Id != 0) hash ^= Passive3Id.GetHashCode();
      if (U18 != 0) hash ^= U18.GetHashCode();
      if (U19 != 0) hash ^= U19.GetHashCode();
      if (U20 != 0) hash ^= U20.GetHashCode();
      if (U21 != 0) hash ^= U21.GetHashCode();
      if (U22 != 0) hash ^= U22.GetHashCode();
      if (U23 != 0) hash ^= U23.GetHashCode();
      if (U24 != 0) hash ^= U24.GetHashCode();
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
      if (MonsterId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MonsterId);
      }
      if (Form != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Form);
      }
      if (ActorId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ActorId);
      }
      if (AtkScale != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AtkScale);
      }
      if (DefScale != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DefScale);
      }
      if (SpaScale != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SpaScale);
      }
      if (SpdScale != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SpdScale);
      }
      if (SpeScale != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SpeScale);
      }
      if (Move1Id != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Move1Id);
      }
      if (Move2Id != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(Move2Id);
      }
      if (Move3Id != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(Move3Id);
      }
      if (Move4Id != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(Move4Id);
      }
      if (Move5Id != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(Move5Id);
      }
      if (Move6Id != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(Move6Id);
      }
      if (Passive1Id != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Passive1Id);
      }
      if (Passive2Id != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(Passive2Id);
      }
      if (Passive3Id != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(Passive3Id);
      }
      if (U18 != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(U18);
      }
      if (U19 != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(U19);
      }
      if (U20 != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(U20);
      }
      if (U21 != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(U21);
      }
      if (U22 != 0) {
        output.WriteRawTag(176, 1);
        output.WriteInt32(U22);
      }
      if (U23 != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(U23);
      }
      if (U24 != 0) {
        output.WriteRawTag(192, 1);
        output.WriteInt32(U24);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MonsterId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MonsterId);
      }
      if (Form != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Form);
      }
      if (ActorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActorId);
      }
      if (AtkScale != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AtkScale);
      }
      if (DefScale != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DefScale);
      }
      if (SpaScale != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpaScale);
      }
      if (SpdScale != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpdScale);
      }
      if (SpeScale != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpeScale);
      }
      if (Move1Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Move1Id);
      }
      if (Move2Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Move2Id);
      }
      if (Move3Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Move3Id);
      }
      if (Move4Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Move4Id);
      }
      if (Move5Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Move5Id);
      }
      if (Move6Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Move6Id);
      }
      if (Passive1Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Passive1Id);
      }
      if (Passive2Id != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Passive2Id);
      }
      if (Passive3Id != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Passive3Id);
      }
      if (U18 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U18);
      }
      if (U19 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U19);
      }
      if (U20 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U20);
      }
      if (U21 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U21);
      }
      if (U22 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U22);
      }
      if (U23 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U23);
      }
      if (U24 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(U24);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MonsterVariation other) {
      if (other == null) {
        return;
      }
      if (other.MonsterId != 0UL) {
        MonsterId = other.MonsterId;
      }
      if (other.Form != 0) {
        Form = other.Form;
      }
      if (other.ActorId.Length != 0) {
        ActorId = other.ActorId;
      }
      if (other.AtkScale != 0) {
        AtkScale = other.AtkScale;
      }
      if (other.DefScale != 0) {
        DefScale = other.DefScale;
      }
      if (other.SpaScale != 0) {
        SpaScale = other.SpaScale;
      }
      if (other.SpdScale != 0) {
        SpdScale = other.SpdScale;
      }
      if (other.SpeScale != 0) {
        SpeScale = other.SpeScale;
      }
      if (other.Move1Id != 0L) {
        Move1Id = other.Move1Id;
      }
      if (other.Move2Id != 0L) {
        Move2Id = other.Move2Id;
      }
      if (other.Move3Id != 0L) {
        Move3Id = other.Move3Id;
      }
      if (other.Move4Id != 0L) {
        Move4Id = other.Move4Id;
      }
      if (other.Move5Id != 0L) {
        Move5Id = other.Move5Id;
      }
      if (other.Move6Id != 0L) {
        Move6Id = other.Move6Id;
      }
      if (other.Passive1Id != 0) {
        Passive1Id = other.Passive1Id;
      }
      if (other.Passive2Id != 0) {
        Passive2Id = other.Passive2Id;
      }
      if (other.Passive3Id != 0) {
        Passive3Id = other.Passive3Id;
      }
      if (other.U18 != 0) {
        U18 = other.U18;
      }
      if (other.U19 != 0) {
        U19 = other.U19;
      }
      if (other.U20 != 0) {
        U20 = other.U20;
      }
      if (other.U21 != 0) {
        U21 = other.U21;
      }
      if (other.U22 != 0) {
        U22 = other.U22;
      }
      if (other.U23 != 0) {
        U23 = other.U23;
      }
      if (other.U24 != 0) {
        U24 = other.U24;
      }
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
          case 8: {
            MonsterId = input.ReadUInt64();
            break;
          }
          case 16: {
            Form = input.ReadUInt32();
            break;
          }
          case 26: {
            ActorId = input.ReadString();
            break;
          }
          case 32: {
            AtkScale = input.ReadUInt32();
            break;
          }
          case 40: {
            DefScale = input.ReadUInt32();
            break;
          }
          case 48: {
            SpaScale = input.ReadUInt32();
            break;
          }
          case 56: {
            SpdScale = input.ReadUInt32();
            break;
          }
          case 64: {
            SpeScale = input.ReadUInt32();
            break;
          }
          case 72: {
            Move1Id = input.ReadInt64();
            break;
          }
          case 80: {
            Move2Id = input.ReadInt64();
            break;
          }
          case 88: {
            Move3Id = input.ReadInt64();
            break;
          }
          case 96: {
            Move4Id = input.ReadInt64();
            break;
          }
          case 104: {
            Move5Id = input.ReadInt64();
            break;
          }
          case 112: {
            Move6Id = input.ReadInt64();
            break;
          }
          case 120: {
            Passive1Id = input.ReadInt32();
            break;
          }
          case 128: {
            Passive2Id = input.ReadInt32();
            break;
          }
          case 136: {
            Passive3Id = input.ReadInt32();
            break;
          }
          case 144: {
            U18 = input.ReadInt32();
            break;
          }
          case 152: {
            U19 = input.ReadInt32();
            break;
          }
          case 160: {
            U20 = input.ReadInt32();
            break;
          }
          case 168: {
            U21 = input.ReadInt32();
            break;
          }
          case 176: {
            U22 = input.ReadInt32();
            break;
          }
          case 184: {
            U23 = input.ReadInt32();
            break;
          }
          case 192: {
            U24 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MonsterVariationTable : pb::IMessage<MonsterVariationTable> {
    private static readonly pb::MessageParser<MonsterVariationTable> _parser = new pb::MessageParser<MonsterVariationTable>(() => new MonsterVariationTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonsterVariationTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MonsterVariationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterVariationTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterVariationTable(MonsterVariationTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterVariationTable Clone() {
      return new MonsterVariationTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.MonsterVariation> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.MonsterVariation.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.MonsterVariation> entries_ = new pbc::RepeatedField<global::ReMastersLib.MonsterVariation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.MonsterVariation> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonsterVariationTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonsterVariationTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
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
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MonsterVariationTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
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
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code