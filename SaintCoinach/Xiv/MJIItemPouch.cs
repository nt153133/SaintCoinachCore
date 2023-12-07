using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIItemPouch : XivRow
    {
        public Item Item => As<Item>("Item");
        
        public byte Category => (byte)AsInt32("Category");
        
        public byte Crop => (byte)AsInt32("Crop");
        
        public byte Sort => As<byte>("Sort");
        
        public MJIItemPouch(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
        
        public override string ToString()
        {
            return Item.Name;
        }
    }
}