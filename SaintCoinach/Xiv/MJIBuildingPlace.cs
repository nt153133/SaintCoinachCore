using SaintCoinach.Ex.Relational;

namespace SaintCoinach.Xiv
{
    public class MJIBuildingPlace : XivRow
    {
        public MJIBuildingPlace(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
        
        public int EobjKey =>(int) ((uint)GetRaw("Name"));
        
        public byte VillageDevelopmentRequired => (byte) GetRaw("VillageDevRequired");
        
        public short X => AsInt16("X");

        public short Y => AsInt16("Y");
    }

}