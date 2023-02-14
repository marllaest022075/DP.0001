using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DP0001.WINUI.Controls;
using DP0001.WINUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP._0001.UI
{
    public class MainViewModel : ObservableObject
    {
        private readonly IAppData _appData;

        private readonly IRelayCommand _enrollCommand;
        private readonly IRelayCommand _verifyCommand;

        public IRelayCommand EnrollCommand => _enrollCommand;
        public IRelayCommand VerifyCommand => _verifyCommand;

        public MainViewModel()
        {
            _appData = new AppData();
            _enrollCommand = new RelayCommand(EnrollAction);
            _verifyCommand = new RelayCommand(VerifyAction);
        }

        private void EnrollAction()
        {
            EnrollmentForm enrollment = new EnrollmentForm(_appData);
            enrollment.ShowDialog();
        }

        private void VerifyAction()
        {
            VerificationForm verification = new VerificationForm(_appData);
            verification.ShowDialog();
        }
    }
}
