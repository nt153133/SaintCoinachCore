using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIKeyItem: XivRow
    {
        public Item Item => As<Item>("Item");
        
        public byte Sort => As<byte>("Sort");
        
        public MJIKeyItem(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
    }
}