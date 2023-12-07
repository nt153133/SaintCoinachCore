using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv;

public class MJICraftworksTension : XivRow
{
    public MJICraftworksTension(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
    {
    }
    
    public byte MaxGroove => As<byte>("MaxGroove");
}