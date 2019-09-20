using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace SpreadWPF_Prism3.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            // RegionManagerの取得
            _regionManager = regionManager;

            // コマンドの作成
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath)
        {
            if (string.IsNullOrEmpty(navigatePath))
            {
                // ContentRegion内のViewを削除
                _regionManager.Regions["ContentRegion"].RemoveAll();
            }
            else
            {
                // ContentRegionにViewを設定
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
            }
        }
    }
}
