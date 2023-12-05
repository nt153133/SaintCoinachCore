using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIGatheringObject: XivRow
    {
        public int EobjKey =>(int) ((uint)GetRaw(3));
        public string Name => Sheet.Collection.GetSheet("EObjName")[EobjKey].AsString("Singular");
        public ushort Progress => (ushort) GetRaw(4);
        public string ProgressName => Progress == 0? string.Empty : Sheet.Collection.GetSheet<MJIProgress>()[Progress].Vision;
        
        public uint NodeType => (uint) GetRaw(2);
        
        public bool IsUnderwater => NodeType == 16;
        
        public MJIGatheringObject(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
    }
}