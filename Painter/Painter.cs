using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Painter
{
    public partial class Painter : Form
    {
        /// <summary>現在の描画ツール。デフォルトはペン (手書き)</summary>
        private Instrument currentInstrument = Instrument.Pen;
        /// <summary>グラフィクスオブジェクト</summary>
        private Graphics g;

        /// <summary>ペンで描画する際に必要なグラフィックパス</summary>
        private GraphicsPath path = new GraphicsPath();

        /// <summary>
        /// 描画している最中であるか否か。
        /// 即ち、一回クリックして始点を指定してから、もう一回クリックして終点を指定する間の状態であるか否か。
        /// </summary>
        private bool isDrawing = false;
        /// <summary>直線を描画する際の始点の座標</summary>
        private Point start = new Point(-1, -1);

        /// <summary>
        /// フォームを構成します。
        /// </summary>
        public Painter()
        {
            InitializeComponent();

            paintzone.Image = new Bitmap(paintzone.Width, paintzone.Height);
            g =  Graphics.FromImage(paintzone.Image);
            g.FillRectangle(new SolidBrush(paintzone.BackColor), 0, 0, paintzone.Width, paintzone.Height); // 保存時に背景色が、paintzone.BackColor になるように、背景色を設定。これがないと、背景が透明色で保存される。

        }

        /// <summary>
        /// マウスが押された時の動作です。
        /// </summary>
        private void paintzone_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return; // 左ボタンが押された状態でなければ、なにもしない。

            /* ----- ペンの時のクリック ----- */
            if (currentInstrument == Instrument.Pen)
            {
                isDrawing = true;
                path = new GraphicsPath(); // マウスが押される度に、新たにグラフィックパスを作成
                path.StartFigure(); // グラフィックパスの描画を開始
                paintzone.Invalidate(); // paintzone を再描画
            }
            /* ----- 直線の時のクリック ----- */
            else // if (currentInstrument == Instrument.Line)
            {
                if (!isDrawing) // 現在描画中でなければ
                {
                    start = paintzone.PointToClient(MousePosition);
                    isDrawing = true;
                }
                else // if (isDrawing) // 現在描画中であれば
                {
                    Point end = paintzone.PointToClient(MousePosition); // 終点を取得

                    g.DrawLine(new Pen(colorBox.Color, (float)numLineWidth.Value), start, end); // 描画

                    isDrawing = false; // 描画中ではない、という通知をする。

                    paintzone.Invalidate(); // paintzone を再描画
                }
            }
        }

        private void paintzone_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentInstrument == Instrument.Pen && isDrawing) // ペンで描画中の時は、
            {
                Point clicked = paintzone.PointToClient(MousePosition); // 現在のマウスの場所を取得
                path.AddLine(clicked, clicked); // パスに書きこむ
            }
            paintzone.Invalidate(); // マウスが移動中には、ペイントゾーンを再描画
        }

        /// <summary>マウスの押されなくなったときの処理です。主にペンの描画の際に、描画を止めるために用います。</summary>
        private void paintzone_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentInstrument == Instrument.Pen)
                isDrawing = false;
        }

        private void paintzone_Paint(object sender, PaintEventArgs e)
        {
            if (currentInstrument == Instrument.Line && isDrawing) // 直線記述中の時
            {
                e.Graphics.DrawLine(new Pen(colorBox.Color, (float)numLineWidth.Value), start, paintzone.PointToClient(MousePosition));
            }
            else if (currentInstrument == Instrument.Pen && isDrawing) // ペンで描画中の時
            {
                g.DrawPath(new Pen(colorBox.Color, (float)numLineWidth.Value), path); // 描画
            }
        }


        // ---------- ボタンの処理 ----------

        /// <summary>ペンボタンがクリックされた時</summary>
        private void cbPen_Click(object sender, EventArgs e)
        {
            currentInstrument = Instrument.Pen;
            cbPen.Checked = true;
            cbLine.Checked = false;
        }

        /// <summary>直線ボタンがクリックされた時</summary>
        private void cbLine_Click(object sender, EventArgs e)
        {
            currentInstrument = Instrument.Line;
            cbLine.Checked = true;
            cbPen.Checked = false;
        }

        /// <summary>色ボタンが押された時</summary>
        private void btColor_Click(object sender, EventArgs e)
        {
            colorBox.ShowDialog();
            btColor.BackColor = colorBox.Color;
        }

        /// <summary>保存ボタンが押された時</summary>
        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveBox.ShowDialog();
            if (result == DialogResult.OK)
                paintzone.Image.Save(saveBox.FileName);
        }

        /// <summary>開くボタンが押された時</summary>
        private void btLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                // paintzone.Image = Image.FromFile(openBox.FileName); // paintzone に読み込み
                g.DrawImage(Image.FromFile(openBox.FileName), 0, 0, paintzone.Image.Width, paintzone.Image.Height);
                paintzone.Invalidate();
            }
        }

        /// <summary>描画ツールの種類を表す列挙体です。</summary>
        enum Instrument
        {
            Pen, Line
        }
    }
}
