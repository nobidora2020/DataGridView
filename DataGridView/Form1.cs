using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;
using System.Runtime.InteropServices;
//app: データグリッドビューに関する

namespace DataGridViewUse
{
    public partial class Form1 : Form
    {
        private int diffWidth = 0; // 幅の差
        private int diffHeight = 0; // 高さの差
        private DataSet dataSet = new DataSet("データリスト"); // データセットを作成
        private DataTable table = new DataTable("Table"); // データテーブルを作成
        private List<bool> robotChecked = new List<bool>(); // フィルターのチェック状態

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            string fileName = "20210804.csv";
            string path = @"CSV_PowerData\" + fileName;
            // csvがなければ何もしない
            if (System.IO.File.Exists(path)) {
                SetPowerData(path);
            }
            LoadColumnsMode();
            SizeColumnsCmb.SelectedIndex = SizeColumnsCmb.Items.IndexOf(nameof(DataGridViewAutoSizeColumnsMode.Fill));
            addCheckCoumCbx.Text = addCheckCoumCbx.Checked.ToString();
            timer1.Interval = 10;
            timer1.Enabled = true;
            //セルを選択すると行全体が選択されるようにする
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        ///データセット
        /// </summary>
        /// <param name="path"></param>
        private void SetPowerData(string path) {
            dataSet = new DataSet("データリスト");
            table = new DataTable("Table");
            int num = 0;
            try {
                // 初期化
                table.Clear();
                table.Columns.Clear();
                dataSet.Clear();
                dataSet.Tables.Clear();
                // データテーブルに列を追加
                var header = new string[] { "時刻", "ロボット名", "現在位置",
                    "Fx[N]", "Fy[N]", "Fz[N]", "Mx[Nm]", "My[N]", "Mz[N]" };
                foreach (var item in header) {
                    table.Columns.Add(item);
                }
                // データセットにデータテーブルを追加
                dataSet.Tables.Add(table);
                //// テーブルにデータを追加
                // 読み込みたいCSVファイルのパスを指定して開く
                StreamReader sr = new StreamReader(path);
                {
                    // 末尾まで繰り返す
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        
                        // 空行は無視する
                        if (line == string.Empty) {
                            continue;
                        }
                        string[] csvData = line.Split(',');
                        if (csvData.Length != 14) {
                            throw new Exception("データ数が間違えている");
                        }

                        string curPos = string.Empty;

                        for (int i = 2; i < 8; i++) {
                            if (double.TryParse(csvData[i].ToString(), out double d)) {
                                if (i > 2) {
                                    curPos += ", ";
                                }
                                curPos += d.ToString("F3");
                            }
                            else {
                                curPos = string.Empty;
                                break;
                            }
                        }
                        string fx = double.Parse(csvData[8]).ToString("F2");
                        string fy = double.Parse(csvData[9]).ToString("F2");
                        string fz = double.Parse(csvData[10]).ToString("F2");
                        string mx = double.Parse(csvData[11]).ToString("F3");
                        string my = double.Parse(csvData[12]).ToString("F3");
                        string mz = double.Parse(csvData[13]).ToString("F3");

                        table.Rows.Add(csvData[0], csvData[1], curPos, fx, fy, fz, mx, my, mz);
                        num++;
                    }
                }
                // データグリッドにテーブルを表示する
                this.GridView.DataSource = table;
                // データグリッドの設定
                SetCommonGridView();

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"データの読み込み失敗({num + 1}行目)", string.Empty,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// GridViewの共通設定
        /// </summary>
        private void SetCommonGridView() {
            SettingGridView settingGridView = new SettingGridView();
            settingGridView.SetGrid(this.GridView, this.Width, this.Height, ref diffWidth, ref diffHeight);
        }

        /// <summary>
        /// DataGridViewAutoSizeColumnsModeの確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeColumnsCmb_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (DataGridViewAutoSizeColumnsMode Value in Enum.GetValues(typeof(DataGridViewAutoSizeColumnsMode))) {
                string name = Enum.GetName(typeof(DataGridViewAutoSizeColumnsMode), Value);
                if (name == SizeColumnsCmb.Text) {
                    GridView.AutoSizeColumnsMode = Value;
                    //GridView.Rows[1]. = true;
                    label1.Text = Value.ToString();
                }
            }
        }
        /// <summary>
        /// リストボックスに名前を設定する
        /// </summary>
        private void LoadColumnsMode() {
            SizeColumnsCmb.Items.Clear();
            foreach (DataGridViewAutoSizeColumnsMode Value in Enum.GetValues(typeof(DataGridViewAutoSizeColumnsMode))) {
                string name = Enum.GetName(typeof(DataGridViewAutoSizeColumnsMode), Value);
                SizeColumnsCmb.Items.Add(name);
                SizeColumnsCmb.Text = name;
                label1.Text = name;
            }
        }
        /// <summary>
        /// 幅調整ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthAdjjustBtn_Click(object sender, EventArgs e) {
            //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// リスイズのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e) {
            if (diffWidth > 0) {
                GridView.Width = this.Width - diffWidth;
                GridView.Height = this.Height - diffHeight;
            }
        }
        /// <summary>
        /// 列を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddColumBtn_Click(object sender, EventArgs e) {
            //列が自動的に作成されないようにする
            GridView.AutoGenerateColumns = false;
            //データソースを設定する
            //dataGridView1.DataSource = BindingSource1;
#if true
            //DataGridViewTextBoxColumn列を作成する
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();

            //データソースの"Column1"をバインドする
            textColumn.DataPropertyName = "Column1";
            //名前とヘッダーを設定する
            textColumn.Name = "Column1";
            textColumn.HeaderText = "Column1";
            //列を追加する
            //dataGridView1.Columns.Add(textColumn);
            GridView.Columns.Insert(0, textColumn);
#endif
        }
        /// <summary>
        /// チェックつき列の チェック状態を調べる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCountBtn_Click(object sender, EventArgs e) {
            bool[] isChecked = new bool[GridView.Rows.Count];
            // チェックを調べる
            if (addCheckCoumCbx.Checked) {
                for (int i = 0; i < GridView.Rows.Count; i++) {
                    isChecked[i] = (bool)GridView.Rows[i].Cells[0].Value;
                }
            }
        }
        /// <summary>
        /// チェック列を追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCheckCoumCbx_CheckedChanged(object sender, EventArgs e) {
            string columName = "行選択";
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            if (addCheckCoumCbx.Checked) {
                column.Name = columName;
                column.HeaderText = columName;
                GridView.Columns.Insert(0, column);
                for (int i = 0; i < GridView.Rows.Count; i++) {
                    GridView.Rows[i].Cells[0].Value = true;
                }
                foreach (DataGridViewColumn c in GridView.Columns) {
                    //並び替えが不可
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                GridView.AllowUserToResizeRows = false;
            }
            else {
                //列を削除する
                GridView.Columns.Remove(columName);
                foreach (DataGridViewColumn c in GridView.Columns) {
                    //並び替えが可能
                    c.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                GridView.AllowUserToResizeRows = true;
            }
        }
        /// <summary>
        /// チェックを反転する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReverseCheckBtn_Click(object sender, EventArgs e) {
            if (addCheckCoumCbx.Checked) {
                for (int i = 0; i < GridView.Rows.Count; i++) {
                    var n = GridView.Rows[i].Cells[0].Value;
                    if (n != null) {
                        GridView.Rows[i].Cells[0].Value = !(bool)GridView.Rows[i].Cells[0].Value;
                    }
                }
            }
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (addCheckCoumCbx.Checked == true && e.RowIndex == -1 && e.ColumnIndex == 0) {
                DataGridView dgv = (DataGridView)sender;
                List<Point> selectedCell = new List<Point>();
                // 選択状態のセルを記憶
                foreach (DataGridViewCell c in GridView.SelectedCells) {
                    selectedCell.Add(new Point(c.RowIndex, c.ColumnIndex));
                }
                dgv.CurrentCell = null; // セルの選択を外す(この処理がないとチェック状態が更新されない)
                // チェック状態を反転
                for (int i = 0; i < GridView.Rows.Count; i++) {
                    GridView.Rows[i].Cells[0].Value = !(bool)GridView.Rows[i].Cells[0].Value;
                }
                // 選択状態のセルを再現
                for (int i = 0; i < selectedCell.Count; i++) {
                    if (i == 0) {
                        dgv.CurrentCell = this.GridView[selectedCell[i].Y, selectedCell[i].X];
                    }
                    GridView.Rows[selectedCell[i].X].Cells[selectedCell[i].Y].Selected = true;
                }
            }
        }
        private void TrueBtn_Click(object sender, EventArgs e) {
            GridView.Rows[2].Cells[0].Value = true;
        }
        private void FalseBtn_Click(object sender, EventArgs e) {
            GridView.Rows[2].Cells[0].Value = false;
        }
        /// <summary>
        ///チェック状態を調べる 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCheckStateBtn_Click(object sender, EventArgs e) {
            try {
                if (GridView.Rows[2].Cells[0].Value == null) {
                    return;
                }
                var b = (bool)GridView.Rows[2].Cells[0].Value;
                textBox1.Text = b.ToString();
            }
            catch (Exception ex) {
                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex.Message);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e) {
            try {
                if (addCheckCoumCbx.Checked) {
                    string s = string.Empty;
                    for (int i = 0; i < 10; i++) {
                        var n = GridView.Rows[i].Cells[0].Value;
                        if (n != null) {
                            var b = (bool)GridView.Rows[i].Cells[0].Value;
                            s += b.ToString() + Environment.NewLine;
                        }
                    }
                    textBox2.Text = s;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ex.Message);
            }
        }
    }
}
