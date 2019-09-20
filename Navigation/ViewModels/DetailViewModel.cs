using Navigation.Notifications;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System;
using System.Data;

namespace Navigation.ViewModels
{
    public class DetailViewModel : BindableBase, Prism.Interactivity.InteractionRequest.IInteractionRequestAware
    {
        public DelegateCommand CloseCommand { get; private set; }

        public DetailViewModel(DataSet ds)
        {
            // データの取得
            Sales = ds.Tables["Sales"].DefaultView;

            // コマンドの作成
            CloseCommand = new DelegateCommand(CloseInteraction);
        }

        // 通知用のプロパティ
        private ICustomNotification _notification;
        public INotification Notification
        {
            get { return _notification; }
            set
            {
                SetProperty(ref _notification, (ICustomNotification)value);
                Sales.RowFilter = $"Class='{_notification.ClassName}'";
            }
        }

        // データを保持するプロパティ
        private DataView _sales;
        public DataView Sales
        {
            get => _sales;
            set => SetProperty(ref _sales, value);
        }

        // ダイアログのクローズ
        private void CloseInteraction()
        {
            FinishInteraction?.Invoke();
        }

        // インタラクションの終了処理
        public Action FinishInteraction { get; set; }
    }
}
