// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/StoryQuest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/StoryQuest.proto</summary>
  public static partial class StoryQuestReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/StoryQuest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoryQuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90by9TdG9yeVF1ZXN0LnByb3RvEgxSZU1hc3RlcnNMaWIi4gIKClN0",
            "b3J5UXVlc3QSEAoIcXVlc3RfaWQYASABKAQSEwoLcXVlc3RfdGl0bGUYAiAB",
            "KAkSEQoJcXVlc3RfaWQyGAMgASgEEgoKAnU0GAQgASgDEgsKA3UwNRgFIAEo",
            "BBILCgN1MDYYBiABKAQSEQoJcXVlc3RfaWQzGAcgASgEEgsKA3UwOBgIIAEo",
            "BBILCgN1MDkYCSABKAQSCwoDdTEwGAogASgJEgsKA3UxMRgLIAEoBBILCgN1",
            "MTIYDCABKAQSCwoDdTEzGA0gASgEEgsKA3UxNBgOIAEoCRILCgN1MTUYDyAB",
            "KAQSCwoDdTE2GBAgASgEEgsKA3UxNxgRIAEoBBILCgN1MTgYEiABKAQSCwoD",
            "dTE5GBMgASgEEgsKA3UyMBgUIAEoBBILCgN1MjEYFSABKAQSCwoDdTIyGBYg",
            "ASgEEhEKCXF1ZXN0X2lkNBgXIAEoBBILCgN1MjQYGCABKAQiPAoPU3RvcnlR",
            "dWVzdFRhYmxlEikKB2VudHJpZXMYASADKAsyGC5SZU1hc3RlcnNMaWIuU3Rv",
            "cnlRdWVzdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.StoryQuest), global::ReMastersLib.StoryQuest.Parser, new[]{ "QuestId", "QuestTitle", "QuestId2", "U4", "U05", "U06", "QuestId3", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "QuestId4", "U24" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.StoryQuestTable), global::ReMastersLib.StoryQuestTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StoryQuest : pb::IMessage<StoryQuest> {
    private static readonly pb::MessageParser<StoryQuest> _parser = new pb::MessageParser<StoryQuest>(() => new StoryQuest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StoryQuest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.StoryQuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryQuest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryQuest(StoryQuest other) : this() {
      questId_ = other.questId_;
      questTitle_ = other.questTitle_;
      questId2_ = other.questId2_;
      u4_ = other.u4_;
      u05_ = other.u05_;
      u06_ = other.u06_;
      questId3_ = other.questId3_;
      u08_ = other.u08_;
      u09_ = other.u09_;
      u10_ = other.u10_;
      u11_ = other.u11_;
      u12_ = other.u12_;
      u13_ = other.u13_;
      u14_ = other.u14_;
      u15_ = other.u15_;
      u16_ = other.u16_;
      u17_ = other.u17_;
      u18_ = other.u18_;
      u19_ = other.u19_;
      u20_ = other.u20_;
      u21_ = other.u21_;
      u22_ = other.u22_;
      questId4_ = other.questId4_;
      u24_ = other.u24_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryQuest Clone() {
      return new StoryQuest(this);
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 1;
    private ulong questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "quest_title" field.</summary>
    public const int QuestTitleFieldNumber = 2;
    private string questTitle_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QuestTitle {
      get { return questTitle_; }
      set {
        questTitle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quest_id2" field.</summary>
    public const int QuestId2FieldNumber = 3;
    private ulong questId2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong QuestId2 {
      get { return questId2_; }
      set {
        questId2_ = value;
      }
    }

    /// <summary>Field number for the "u4" field.</summary>
    public const int U4FieldNumber = 4;
    private long u4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long U4 {
      get { return u4_; }
      set {
        u4_ = value;
      }
    }

    /// <summary>Field number for the "u05" field.</summary>
    public const int U05FieldNumber = 5;
    private ulong u05_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U05 {
      get { return u05_; }
      set {
        u05_ = value;
      }
    }

    /// <summary>Field number for the "u06" field.</summary>
    public const int U06FieldNumber = 6;
    private ulong u06_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U06 {
      get { return u06_; }
      set {
        u06_ = value;
      }
    }

    /// <summary>Field number for the "quest_id3" field.</summary>
    public const int QuestId3FieldNumber = 7;
    private ulong questId3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong QuestId3 {
      get { return questId3_; }
      set {
        questId3_ = value;
      }
    }

    /// <summary>Field number for the "u08" field.</summary>
    public const int U08FieldNumber = 8;
    private ulong u08_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U08 {
      get { return u08_; }
      set {
        u08_ = value;
      }
    }

    /// <summary>Field number for the "u09" field.</summary>
    public const int U09FieldNumber = 9;
    private ulong u09_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U09 {
      get { return u09_; }
      set {
        u09_ = value;
      }
    }

    /// <summary>Field number for the "u10" field.</summary>
    public const int U10FieldNumber = 10;
    private string u10_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string U10 {
      get { return u10_; }
      set {
        u10_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u11" field.</summary>
    public const int U11FieldNumber = 11;
    private ulong u11_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U11 {
      get { return u11_; }
      set {
        u11_ = value;
      }
    }

    /// <summary>Field number for the "u12" field.</summary>
    public const int U12FieldNumber = 12;
    private ulong u12_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U12 {
      get { return u12_; }
      set {
        u12_ = value;
      }
    }

    /// <summary>Field number for the "u13" field.</summary>
    public const int U13FieldNumber = 13;
    private ulong u13_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U13 {
      get { return u13_; }
      set {
        u13_ = value;
      }
    }

    /// <summary>Field number for the "u14" field.</summary>
    public const int U14FieldNumber = 14;
    private string u14_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string U14 {
      get { return u14_; }
      set {
        u14_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u15" field.</summary>
    public const int U15FieldNumber = 15;
    private ulong u15_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U15 {
      get { return u15_; }
      set {
        u15_ = value;
      }
    }

    /// <summary>Field number for the "u16" field.</summary>
    public const int U16FieldNumber = 16;
    private ulong u16_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U16 {
      get { return u16_; }
      set {
        u16_ = value;
      }
    }

    /// <summary>Field number for the "u17" field.</summary>
    public const int U17FieldNumber = 17;
    private ulong u17_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U17 {
      get { return u17_; }
      set {
        u17_ = value;
      }
    }

    /// <summary>Field number for the "u18" field.</summary>
    public const int U18FieldNumber = 18;
    private ulong u18_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U18 {
      get { return u18_; }
      set {
        u18_ = value;
      }
    }

    /// <summary>Field number for the "u19" field.</summary>
    public const int U19FieldNumber = 19;
    private ulong u19_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U19 {
      get { return u19_; }
      set {
        u19_ = value;
      }
    }

    /// <summary>Field number for the "u20" field.</summary>
    public const int U20FieldNumber = 20;
    private ulong u20_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U20 {
      get { return u20_; }
      set {
        u20_ = value;
      }
    }

    /// <summary>Field number for the "u21" field.</summary>
    public const int U21FieldNumber = 21;
    private ulong u21_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U21 {
      get { return u21_; }
      set {
        u21_ = value;
      }
    }

    /// <summary>Field number for the "u22" field.</summary>
    public const int U22FieldNumber = 22;
    private ulong u22_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U22 {
      get { return u22_; }
      set {
        u22_ = value;
      }
    }

    /// <summary>Field number for the "quest_id4" field.</summary>
    public const int QuestId4FieldNumber = 23;
    private ulong questId4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong QuestId4 {
      get { return questId4_; }
      set {
        questId4_ = value;
      }
    }

    /// <summary>Field number for the "u24" field.</summary>
    public const int U24FieldNumber = 24;
    private ulong u24_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong U24 {
      get { return u24_; }
      set {
        u24_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StoryQuest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StoryQuest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestId != other.QuestId) return false;
      if (QuestTitle != other.QuestTitle) return false;
      if (QuestId2 != other.QuestId2) return false;
      if (U4 != other.U4) return false;
      if (U05 != other.U05) return false;
      if (U06 != other.U06) return false;
      if (QuestId3 != other.QuestId3) return false;
      if (U08 != other.U08) return false;
      if (U09 != other.U09) return false;
      if (U10 != other.U10) return false;
      if (U11 != other.U11) return false;
      if (U12 != other.U12) return false;
      if (U13 != other.U13) return false;
      if (U14 != other.U14) return false;
      if (U15 != other.U15) return false;
      if (U16 != other.U16) return false;
      if (U17 != other.U17) return false;
      if (U18 != other.U18) return false;
      if (U19 != other.U19) return false;
      if (U20 != other.U20) return false;
      if (U21 != other.U21) return false;
      if (U22 != other.U22) return false;
      if (QuestId4 != other.QuestId4) return false;
      if (U24 != other.U24) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestId != 0UL) hash ^= QuestId.GetHashCode();
      if (QuestTitle.Length != 0) hash ^= QuestTitle.GetHashCode();
      if (QuestId2 != 0UL) hash ^= QuestId2.GetHashCode();
      if (U4 != 0L) hash ^= U4.GetHashCode();
      if (U05 != 0UL) hash ^= U05.GetHashCode();
      if (U06 != 0UL) hash ^= U06.GetHashCode();
      if (QuestId3 != 0UL) hash ^= QuestId3.GetHashCode();
      if (U08 != 0UL) hash ^= U08.GetHashCode();
      if (U09 != 0UL) hash ^= U09.GetHashCode();
      if (U10.Length != 0) hash ^= U10.GetHashCode();
      if (U11 != 0UL) hash ^= U11.GetHashCode();
      if (U12 != 0UL) hash ^= U12.GetHashCode();
      if (U13 != 0UL) hash ^= U13.GetHashCode();
      if (U14.Length != 0) hash ^= U14.GetHashCode();
      if (U15 != 0UL) hash ^= U15.GetHashCode();
      if (U16 != 0UL) hash ^= U16.GetHashCode();
      if (U17 != 0UL) hash ^= U17.GetHashCode();
      if (U18 != 0UL) hash ^= U18.GetHashCode();
      if (U19 != 0UL) hash ^= U19.GetHashCode();
      if (U20 != 0UL) hash ^= U20.GetHashCode();
      if (U21 != 0UL) hash ^= U21.GetHashCode();
      if (U22 != 0UL) hash ^= U22.GetHashCode();
      if (QuestId4 != 0UL) hash ^= QuestId4.GetHashCode();
      if (U24 != 0UL) hash ^= U24.GetHashCode();
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
      if (QuestId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(QuestId);
      }
      if (QuestTitle.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(QuestTitle);
      }
      if (QuestId2 != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(QuestId2);
      }
      if (U4 != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(U4);
      }
      if (U05 != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(U05);
      }
      if (U06 != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(U06);
      }
      if (QuestId3 != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(QuestId3);
      }
      if (U08 != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(U08);
      }
      if (U09 != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(U09);
      }
      if (U10.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(U10);
      }
      if (U11 != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(U11);
      }
      if (U12 != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(U12);
      }
      if (U13 != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(U13);
      }
      if (U14.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(U14);
      }
      if (U15 != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(U15);
      }
      if (U16 != 0UL) {
        output.WriteRawTag(128, 1);
        output.WriteUInt64(U16);
      }
      if (U17 != 0UL) {
        output.WriteRawTag(136, 1);
        output.WriteUInt64(U17);
      }
      if (U18 != 0UL) {
        output.WriteRawTag(144, 1);
        output.WriteUInt64(U18);
      }
      if (U19 != 0UL) {
        output.WriteRawTag(152, 1);
        output.WriteUInt64(U19);
      }
      if (U20 != 0UL) {
        output.WriteRawTag(160, 1);
        output.WriteUInt64(U20);
      }
      if (U21 != 0UL) {
        output.WriteRawTag(168, 1);
        output.WriteUInt64(U21);
      }
      if (U22 != 0UL) {
        output.WriteRawTag(176, 1);
        output.WriteUInt64(U22);
      }
      if (QuestId4 != 0UL) {
        output.WriteRawTag(184, 1);
        output.WriteUInt64(QuestId4);
      }
      if (U24 != 0UL) {
        output.WriteRawTag(192, 1);
        output.WriteUInt64(U24);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (QuestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(QuestId);
      }
      if (QuestTitle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QuestTitle);
      }
      if (QuestId2 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(QuestId2);
      }
      if (U4 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U4);
      }
      if (U05 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U05);
      }
      if (U06 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U06);
      }
      if (QuestId3 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(QuestId3);
      }
      if (U08 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U08);
      }
      if (U09 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U09);
      }
      if (U10.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U10);
      }
      if (U11 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U11);
      }
      if (U12 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U12);
      }
      if (U13 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U13);
      }
      if (U14.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U14);
      }
      if (U15 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(U15);
      }
      if (U16 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U16);
      }
      if (U17 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U17);
      }
      if (U18 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U18);
      }
      if (U19 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U19);
      }
      if (U20 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U20);
      }
      if (U21 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U21);
      }
      if (U22 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U22);
      }
      if (QuestId4 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(QuestId4);
      }
      if (U24 != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(U24);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StoryQuest other) {
      if (other == null) {
        return;
      }
      if (other.QuestId != 0UL) {
        QuestId = other.QuestId;
      }
      if (other.QuestTitle.Length != 0) {
        QuestTitle = other.QuestTitle;
      }
      if (other.QuestId2 != 0UL) {
        QuestId2 = other.QuestId2;
      }
      if (other.U4 != 0L) {
        U4 = other.U4;
      }
      if (other.U05 != 0UL) {
        U05 = other.U05;
      }
      if (other.U06 != 0UL) {
        U06 = other.U06;
      }
      if (other.QuestId3 != 0UL) {
        QuestId3 = other.QuestId3;
      }
      if (other.U08 != 0UL) {
        U08 = other.U08;
      }
      if (other.U09 != 0UL) {
        U09 = other.U09;
      }
      if (other.U10.Length != 0) {
        U10 = other.U10;
      }
      if (other.U11 != 0UL) {
        U11 = other.U11;
      }
      if (other.U12 != 0UL) {
        U12 = other.U12;
      }
      if (other.U13 != 0UL) {
        U13 = other.U13;
      }
      if (other.U14.Length != 0) {
        U14 = other.U14;
      }
      if (other.U15 != 0UL) {
        U15 = other.U15;
      }
      if (other.U16 != 0UL) {
        U16 = other.U16;
      }
      if (other.U17 != 0UL) {
        U17 = other.U17;
      }
      if (other.U18 != 0UL) {
        U18 = other.U18;
      }
      if (other.U19 != 0UL) {
        U19 = other.U19;
      }
      if (other.U20 != 0UL) {
        U20 = other.U20;
      }
      if (other.U21 != 0UL) {
        U21 = other.U21;
      }
      if (other.U22 != 0UL) {
        U22 = other.U22;
      }
      if (other.QuestId4 != 0UL) {
        QuestId4 = other.QuestId4;
      }
      if (other.U24 != 0UL) {
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
            QuestId = input.ReadUInt64();
            break;
          }
          case 18: {
            QuestTitle = input.ReadString();
            break;
          }
          case 24: {
            QuestId2 = input.ReadUInt64();
            break;
          }
          case 32: {
            U4 = input.ReadInt64();
            break;
          }
          case 40: {
            U05 = input.ReadUInt64();
            break;
          }
          case 48: {
            U06 = input.ReadUInt64();
            break;
          }
          case 56: {
            QuestId3 = input.ReadUInt64();
            break;
          }
          case 64: {
            U08 = input.ReadUInt64();
            break;
          }
          case 72: {
            U09 = input.ReadUInt64();
            break;
          }
          case 82: {
            U10 = input.ReadString();
            break;
          }
          case 88: {
            U11 = input.ReadUInt64();
            break;
          }
          case 96: {
            U12 = input.ReadUInt64();
            break;
          }
          case 104: {
            U13 = input.ReadUInt64();
            break;
          }
          case 114: {
            U14 = input.ReadString();
            break;
          }
          case 120: {
            U15 = input.ReadUInt64();
            break;
          }
          case 128: {
            U16 = input.ReadUInt64();
            break;
          }
          case 136: {
            U17 = input.ReadUInt64();
            break;
          }
          case 144: {
            U18 = input.ReadUInt64();
            break;
          }
          case 152: {
            U19 = input.ReadUInt64();
            break;
          }
          case 160: {
            U20 = input.ReadUInt64();
            break;
          }
          case 168: {
            U21 = input.ReadUInt64();
            break;
          }
          case 176: {
            U22 = input.ReadUInt64();
            break;
          }
          case 184: {
            QuestId4 = input.ReadUInt64();
            break;
          }
          case 192: {
            U24 = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StoryQuestTable : pb::IMessage<StoryQuestTable> {
    private static readonly pb::MessageParser<StoryQuestTable> _parser = new pb::MessageParser<StoryQuestTable>(() => new StoryQuestTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StoryQuestTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.StoryQuestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryQuestTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryQuestTable(StoryQuestTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryQuestTable Clone() {
      return new StoryQuestTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.StoryQuest> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.StoryQuest.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.StoryQuest> entries_ = new pbc::RepeatedField<global::ReMastersLib.StoryQuest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.StoryQuest> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StoryQuestTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StoryQuestTable other) {
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
    public void MergeFrom(StoryQuestTable other) {
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