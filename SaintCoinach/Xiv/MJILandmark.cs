using SaintCoinach.Ex.Relational;
using SaintCoinach.Imaging;

namespace SaintCoinach.Xiv
{
    public class MJILandmark : XivRow
    {
        
        public ImageFile Icon { get { return AsImage("Icon"); } }
        
        public int MJITextId => (int) ((uint)GetRaw("Name"));
        
        public MJILandmark(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
    }
}