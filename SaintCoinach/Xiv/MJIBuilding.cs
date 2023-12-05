using System.Collections.Generic;
using System.Linq;
using SaintCoinach.Ex;
using SaintCoinach.Ex.Relational;
using SaintCoinach.Imaging;
using SaintCoinach.Xiv.Sheets;

namespace SaintCoinach.Xiv
{
    public class MJIBuildingItem : XivSubRow
    {
        public MJIBuildingItem(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
        }
        
        public ImageFile Icon => AsImage("Icon");
        
        public int MJITextId => As<MJIText>("Name").Key;
        
        public byte RequiredRank =>(byte) GetRaw("RankRequired");

    }
    /*
    public class MJIBuilding : XivRow
    {
        public MJIBuilding(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
            var items = new List<MJIBuildingItem>();

            var gcItems = Sheet.Collection.GetSheet2<MJIBuildingItem>();
            foreach (var gcItem in gcItems) {
                    items.Add(gcItem);
            }

            Items = items;
        }
        
        public List<MJIBuildingItem> Items { get; private set; }

    }*/
}