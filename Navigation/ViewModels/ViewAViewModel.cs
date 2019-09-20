using Navigation.Notifications;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using System.Data;

namespace Navigation.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public InteractionRequest<INotification> ShowDetailRequest { get; set; }
        public DelegateCommand ShowDetailCommand { get; set; }

        public ViewAViewModel(DataSet ds)
        {
            // データの取得
            Outline = ds.Tables["Outline"];

            // コマンドの作成
            ShowDetailRequest = new InteractionRequest<INotification>();
            ShowDetailCommand = new DelegateCommand(ShowDetail);
        }

        // データを保持するプロパティ
        private DataTable _outline;
        public DataTable Outline
        {
            get => _outline;
            set => SetProperty(ref _outline, value);
        }

        // カレントレコードを保持するプロパティ
        private DataRowView _selectedProduct;
        public DataRowView SelectedProduct
        {
            get => _selectedProduct;
            set => SetProperty(ref _selectedProduct, value);
        }

        // 戻る
        private void ShowDetail()
        {
            string className = string.Concat(SelectedProduct["Class"]);
            ShowDetailRequest.Raise(new CustomNotification { Title = "売上明細", ClassName = className });
        }
    }
}
