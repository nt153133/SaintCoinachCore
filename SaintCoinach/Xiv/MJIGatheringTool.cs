using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIGatheringTool : XivRow
    {
        public MJIKeyItem KeyItem => As<MJIKeyItem>("Item");
        
        public MJIGatheringTool(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
    }

}