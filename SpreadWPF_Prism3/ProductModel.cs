using System;
using System.Data;

namespace SpreadWPF_Prism3
{
    class ProductModel
    {
        private static DataSet ds;

        public ProductModel() { }

        // データの取得
        public static DataSet GetSales()
        {
            // 初期値の作成
            if (ds == null)
            {
                ds = new DataSet();
                DataTable dt1 = ds.Tables.Add("Sales");
                dt1.Columns.Add("Code", typeof(String));
                dt1.Columns.Add("Name", typeof(String));
                dt1.Columns.Add("Price", typeof(Int32));
                dt1.Columns.Add("Class", typeof(String));
                dt1.Columns.Add("Quantity", typeof(Int32));
                dt1.Columns.Add("Amount", typeof(Int32));
                dt1.Rows.Add("0000001", "アーモンド", 200, "A分類", 10, 2000);
                dt1.Rows.Add("0000002", "グレープシード", 200, "A分類", 15, 3000);
                dt1.Rows.Add("0000003", "オリーブ", 320, "A分類", 20, 6400);
                dt1.Rows.Add("0000004", "ゴマ油", 300, "B分類", 10, 3000);
                dt1.Rows.Add("0000005", "ひまわり", 200, "B分類", 15, 3000);
                dt1.Rows.Add("0000006", "えごま", 300, "B分類", 20, 6000);
                dt1.Rows.Add("0000007", "アルガン", 800, "B分類", 5, 4000);
                dt1.Rows.Add("0000008", "ココナッツ", 720, "C分類", 10, 7200);
                dt1.Rows.Add("0000009", "ウォールナッツ", 400, "C分類", 15, 6000);
                dt1.Rows.Add("0000010", "亜麻仁油", 700, "C分類", 20, 14000);

                DataTable dt2 = ds.Tables.Add("Outline");
                dt2.Columns.Add("Class", typeof(String));
                dt2.Columns.Add("Quantity", typeof(Int32));
                dt2.Columns.Add("Amount", typeof(Int32));
                dt2.Rows.Add("A分類", 45, 11400);
                dt2.Rows.Add("B分類", 50, 16000);
                dt2.Rows.Add( "C分類", 45, 27200);

                ds.AcceptChanges();
            }

            // 戻り値の設定
            return ds;
        }
    }
}
