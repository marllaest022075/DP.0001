using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP0001.WINUI.Core
{
    public delegate void OnChangeHandler();
    public interface IAppData
    {
        public const int MaxFingers = 10;
        // shared data
        public int EnrolledFingersMask { get; set; }
        public int MaxEnrollFingerCount { get; set; }
        public bool IsEventHandlerSucceeds { get; set; }
        public bool IsFeatureSetMatched { get; set; }
        public int FalseAcceptRate { get; set; }
        public DPFP.Template[]? Templates { get; set; }

        // data change notification
        public void Update();   // just fires the OnChange() event
        public event OnChangeHandler OnChange;
    }
}
