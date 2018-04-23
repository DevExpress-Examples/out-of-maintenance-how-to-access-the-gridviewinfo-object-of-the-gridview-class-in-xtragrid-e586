using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace E586
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        GridViewInfo GetGridViewInfo(GridView view)
        {
          /*  FieldInfo fi;
            fi = typeof(GridView).GetField("fViewInfo", BindingFlags.NonPublic | BindingFlags.Instance);
            return fi.GetValue(view) as GridViewInfo;*/
            return view.GetViewInfo() as GridViewInfo;
        }


        Rectangle GetCellRect(GridView view, int rowHandle, GridColumn column)
        {
            GridViewInfo viewInfo = GetGridViewInfo(view);
            return viewInfo.GetGridCellInfo(rowHandle, column).Bounds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetCellRect(gridView1, gridView1.FocusedRowHandle, gridView1.FocusedColumn).ToString() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
        }
    }
}