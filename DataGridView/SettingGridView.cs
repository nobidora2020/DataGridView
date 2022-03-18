using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewUse
{
    class SettingGridView
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="diffWidth"></param>
        /// <param name="diffHeight"></param>
        public void SetGrid(DataGridView grid, int Width, int Height, ref int diffWidth, ref int diffHeight) {
            // ヘッダー列を中央揃え
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 列ヘッダー非表示
            grid.RowHeadersVisible = false;
            // 行の追加をを無効
            grid.AllowUserToAddRows = false;
            //行の高さをユーザーが変更できないようにする
            grid.AllowUserToResizeRows = false;
            //降順で並び替えを行う (最新のデータを最上部に表示する)
            grid.Sort(grid.Columns[0], ListSortDirection.Descending);
            // 全ての列を右寄せ
            for (int i = 0; i < grid.Columns.Count; i++) {
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // 文字列、日付は左寄せ
            grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ////すべての行の高さを自動調整する
            grid.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //すべての列の幅を自動調整する
            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //幅の差
            diffWidth = Width - grid.Width;
            //高さの差
            diffHeight = Height - grid.Height;
            ///
            /// データテーブルの幅に合わせて、フォーム幅を自動調整する
            ///
            //ディスプレイの幅
            int displayWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            // 各列の幅の合計
            int totalWidth = grid.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            // スクロールバーの幅
            int scrollBarWidth = new VScrollBar().Width;
            // 調整幅
            int adjustWidth = 3;
            // 変更するフォームの幅
            int formWidth = Width + totalWidth + scrollBarWidth + adjustWidth - grid.Width;
            if (formWidth > 0) {
                Width = formWidth < displayWidth
                    ? formWidth
                    : (int)(displayWidth * 0.8);  // ディスプレイの80％の大きさ
            }
        }
    }
}
