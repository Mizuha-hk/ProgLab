using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgLab
{
    public partial class MainWindow : Form
    {
        private ProgLabContext context;

        public MainWindow(ProgLabContext progLabContext)
        {
            InitializeComponent();

            context = progLabContext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// オブジェクトが押されたかどうかを判定する変数
        /// </summary>
        private bool mouseDownFrg = false;

        /// <summary>
        /// オブジェクトが押されたときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testObject_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseDownFrg = true;
            }
        }
        /// <summary>
        /// オブジェクト上でマウスが動かされた時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testObject_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDownFrg)
            {
                Panel pnlDrug = (Panel)sender;
                //ドラッグイベント開始
                pnlDrug.DoDragDrop(sender, DragDropEffects.All);
                mouseDownFrg= false;
            }
        }
        /// <summary>
        /// ドラッグ開始時に発生するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testObject_DragEnter(object sender, DragEventArgs e)
        {
            //移動エフェクト
            e.Effect = DragDropEffects.Move;
        }
        /// <summary>
        /// ドラッグドロップ操作中にマウスが動かされた時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testObject_DragOver(object sender, DragEventArgs e)
        {
            Panel pnlDrug = (Panel)sender;
            //マウスカーソルの位置にボタンを配置する
            pnlDrug.Location = PointToClient(new Point(e.X - (pnlDrug.Width / 2) - 206, e.Y - (pnlDrug.Height / 2) - 28));
        }
        /// <summary>
        /// ドラッグドロップした時に発生するエフェクト
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testObject_DragDrop(object sender, DragEventArgs e)
        {
            //初期エフェクトを設定
            e.Effect = DragDropEffects.None;
        }
    }
}
