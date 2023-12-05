using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIItemPouch : XivRow
    {
        public Item Item => As<Item>("Item");
        
        public MJIItemPouch(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
    }
}