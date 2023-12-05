using System.Collections.Generic;
using SaintCoinach.Ex.Relational;
using SaintCoinach.Imaging;

namespace SaintCoinach.Xiv {
    public class Emote : XivRow {
        #region Properties

        public Text.XivString Name { get { return AsString("Name"); } }
        public EmoteCategory EmoteCategory { get { return As<EmoteCategory>(); } }
        public ImageFile Icon { get { return AsImage("Icon"); } }
        public LogMessage TargetedLogMessage { get { return As<LogMessage>("LogMessage{Targeted}"); } }
        public LogMessage UntargetedLogMessage { get { return As<LogMessage>("LogMessage{Untargeted}"); } }
        
        public List<string> ActionTimeLine { get; }
        
        public bool IsValid => ((ushort)GetRaw(24) != 0 && Key != 0);
        
        public int UnlockLink { get { return AsInt32("UnlockLink"); } }

        #endregion

        #region Constructors

        #region Constructor

        public Emote(IXivSheet sheet, IRelationalRow sourceRow) : base(sheet, sourceRow)
        {
            var actionSheet = sheet.Collection.GetSheet("ActionTimeline");
            ActionTimeLine = new List<string>();
            for (int i = 0; i < 7; i++)
            {
                var time = (ushort)GetRaw($"ActionTimeline[{i}]");
                if (time != 0)
                {
                    var actionName = actionSheet[time].AsString("Key");
                    ActionTimeLine.Add(actionName.ToString());
                }
            }
             
        }

        #endregion

        #endregion

        public override string ToString() {
            return Name;
        }
    }
}