using DPFP;

namespace DP0001.WINUI.Core
{
    public class AppData : IAppData
    {
        public const int MaxFingers = 10;
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
