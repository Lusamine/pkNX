using System.ComponentModel;
using FlatSharp.Attributes;
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global
#nullable disable

namespace pkNX.Structures.FlatBuffers;

// Generated by FlatSharp
// FileIdentifier: 
// FileExtension: 
// Object Count: 2
// Enum Count: 0
// Root Type: gym.mizu.FixTableArray

[FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
public class FixTableArray : IFlatBufferArchive<FixTable>
{
    [FlatBufferItem(0)] public FixTable[] Table { get; set; }
}

[FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
public class FixTable
{
    [FlatBufferItem(0)] public int FixTableId { get; set; }
    [FlatBufferItem(1)] public int SmallPrice { get; set; }
    [FlatBufferItem(2)] public int LargePrice { get; set; }
    [FlatBufferItem(3)] public int NpcSmallRate { get; set; }
    [FlatBufferItem(4)] public int NpcLargeRate { get; set; }
    [FlatBufferItem(5)] public int NpcWishSmallRate { get; set; }
    [FlatBufferItem(6)] public int NpcWishLargeRate { get; set; }
    [FlatBufferItem(7)] public float PopupDistance { get; set; }
}