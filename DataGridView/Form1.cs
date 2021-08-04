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

namespace DataGridView
{
    public partial class Form1 : Form
    {

        // 幅の差
        int diffWidth = 0;
        // 高さの差
        int diffHeight = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".csv";
            string path = @"CSV_PowerData\" + fileName;
            // csvがなければ何もしない
            if (System.IO.File.Exists(path))
            {
                SetPowerData(path);
            }
            comboBox1.SelectedIndex = 6;

            // 幅とサイズの差を保存
            diffWidth = this.Width - dataGridView1.Width;
            diffHeight = this.Height - dataGridView1.Height;

            load1();
        }

        // データセットを作成
        private DataSet dataSet = new DataSet("データリスト");
        // データテーブルを作成
        DataTable table = new DataTable("Table");
        // フィルターのチェック状態
        List<bool> robotChecked = new List<bool>();


        // データセット
        void SetPowerData(string path)
        {
            dataSet = new DataSet("データリスト");
            table = new DataTable("Table");

            // 初期化
            table.Clear();
            table.Columns.Clear();
            dataSet.Clear();
            dataSet.Tables.Clear();

            // データテーブルに列を追加
            table.Columns.Add("時刻");
            table.Columns.Add("ロボット名");
            table.Columns.Add("現在位置");
            table.Columns.Add("Fx[N]");
            table.Columns.Add("Fy[N]");
            table.Columns.Add("Fz[N]");
            table.Columns.Add("Mx[Nm]");
            table.Columns.Add("My[N]");
            table.Columns.Add("Mz[N]");

            // データセットにデータテーブルを追加
            dataSet.Tables.Add(table);

            int num = 0;

            //// テーブルにデータを追加
            // 読み込みたいCSVファイルのパスを指定して開く
            StreamReader sr = new StreamReader(path);
            {
                // 末尾まで繰り返す
                while (!sr.EndOfStream)
                {
                    num++;

                    string line = sr.ReadLine();
                    string[] csvData = line.Split(',');
                    string curPos = "";
                    string tmpCurPos = "";
                    bool curPosExists = true;

                    for (int i = 2; i < 8; i++)
                    {
                        if (double.TryParse(csvData[i].ToString(), out double d))
                        {
                            if (2 < i)
                            {
                                tmpCurPos += ", ";
                            }
                            tmpCurPos += d.ToString("F3");
                        }
                        else
                        {
                            curPosExists = false;
                            break;
                        }
                    }

                    if (curPosExists)
                    {
                        curPos = tmpCurPos;
                    }

                    string fx = double.Parse(csvData[8]).ToString("F2");
                    string fy = double.Parse(csvData[9]).ToString("F2");
                    string fz = double.Parse(csvData[10]).ToString("F2");
                    string mx = double.Parse(csvData[11]).ToString("F3");
                    string my = double.Parse(csvData[12]).ToString("F3");
                    string mz = double.Parse(csvData[13]).ToString("F3");

                    table.Rows.Add(csvData[0], csvData[1], curPos, fx, fy, fz, mx, my, mz);
                }
            }
            // データグリッドにテーブルを表示する
            this.dataGridView1.DataSource = table;

            SetCommonGridView();
        }


        /// <summary>
        /// GridViewの共通設定
        /// </summary>
        void SetCommonGridView()
        {
            // ヘッダー列を中央揃え
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 列ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;
            // 行の追加をを無効
            dataGridView1.AllowUserToAddRows = false;
            //行の高さをユーザーが変更できないようにする
            dataGridView1.AllowUserToResizeRows = false;


            //降順で並び替えを行う (最新のデータを最上部に表示する)
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            // 全ての列を右寄せ
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // 文字列、日付は左寄せ
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            ////すべての行の高さを自動調整する
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //すべての列の幅を自動調整する
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // DataGridViewAutoSizeColumnsModeの確認
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int num = comboBox1.SelectedIndex;
                DataGridViewAutoSizeColumnsMode v;
                switch (num)
                {
                    case 0:
                        v = DataGridViewAutoSizeColumnsMode.AllCells;
                        break;
                    case 1:
                        v = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                        break;
                    case 2:
                        v = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        break;
                    case 3:
                        v = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                        break;
                    case 4:
                        v = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
                        break;
                    case 5:
                        v = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    default:
                        v = DataGridViewAutoSizeColumnsMode.None;
                        break;
                }
                dataGridView1.AutoSizeColumnsMode = v;
                label1.Text = v.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }


        void load1()
        {
            try
            {

                for (int i = 0; i < comboBox1.Items.Count; i++)
                {

                    int num = comboBox1.SelectedIndex;

                    num = i;
                    DataGridViewAutoSizeColumnsMode v;
                    switch (num)
                    {
                        case 0:
                            v = DataGridViewAutoSizeColumnsMode.AllCells;
                            break;
                        case 1:
                            v = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                            break;
                        case 2:
                            v = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                            break;
                        case 3:
                            v = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                            break;
                        case 4:
                            v = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
                            break;
                        case 5:
                            v = DataGridViewAutoSizeColumnsMode.Fill;
                            break;
                        default:
                            v = DataGridViewAutoSizeColumnsMode.None;
                            break;
                    }
                    dataGridView1.AutoSizeColumnsMode = v;

                    comboBox1.Items[i] = v.ToString();

                    label1.Text = v.ToString();

                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // リスイズのイベント
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (diffWidth > 0)
            {
                dataGridView1.Width = this.Width - diffWidth;
                dataGridView1.Height = this.Height - diffHeight;
            }
        }

    }
}
