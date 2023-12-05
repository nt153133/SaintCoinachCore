using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIText : XivRow
    {
        public MJIText(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
        
        public string Text => AsString("Text");
    }
}