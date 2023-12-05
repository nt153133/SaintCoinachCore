using System.Linq;
using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIGatheringItem : XivRow
    {
        public Item Item => As<Item>("Item");
        
        public byte Sort => As<byte>("Sort");
        
        public int MJIItemPouchKey => Sheet.Collection.GetSheet<MJIItemPouch>().First(i=> i.Item.Key == Item.Key).Key;
        
        public MJIGatheringTool Tool => As<MJIGatheringTool>("Tool");
        
        public bool RequiresTool => Tool.Key != 0;
        
        public short X => AsInt16("X");
        
        public short Y => AsInt16("Y");
        
        public short Radius => AsInt16("Radius");
        
        public byte Map => As<byte>("Map");
        
        public MJIGatheringItem(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
    }
}