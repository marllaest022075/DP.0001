using DPFP;
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
    public class AppData : IAppData
    {
        public const int MaxFingers = 10;
        // shared data
        //public int EnrolledFingersMask = 0;
        //public int MaxEnrollFingerCount = MaxFingers;
        //public bool IsEventHandlerSucceeds = true;
        //public bool IsFeatureSetMatched = false;
        //public int FalseAcceptRate = 0;
        //public DPFP.Template[] Templates = new DPFP.Template[MaxFingers];

        //// data change notification
        //public void Update() { OnChange(); }        // just fires the OnChange() event
        //public event OnChangeHandler OnChange;
        public int EnrolledFingersMask {get;set;}
        public int MaxEnrollFingerCount {get;set;}
        public bool IsEventHandlerSucceeds {get;set;}
        public bool IsFeatureSetMatched {get;set;}
        public int FalseAcceptRate {get;set;}
        public Template[]? Templates {get;set;}

        public event OnChangeHandler? OnChange;
        public AppData()
        {
            EnrolledFingersMask = 0;
            MaxEnrollFingerCount = MaxFingers;
            IsEventHandlerSucceeds = true;
            IsFeatureSetMatched = false;
            FalseAcceptRate = 0;
            Templates = new Template[MaxFingers];
        }
        public void Update()
        {
            OnChange?.Invoke();
        }
    }
}
