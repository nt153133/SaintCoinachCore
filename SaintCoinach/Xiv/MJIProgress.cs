using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIProgress: XivRow
    {
        public Text.XivString Vision { get { return AsString("Vision"); } }
        
        public MJIProgress(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow) { }
        
        public override string ToString() {
            return Vision;
        }
    }
}