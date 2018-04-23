Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Namespace E586
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Function GetGridViewInfo(ByVal view As GridView) As GridViewInfo
'            FieldInfo fi;
'            fi = typeof(GridView).GetField("fViewInfo", BindingFlags.NonPublic | BindingFlags.Instance);
'            return fi.GetValue(view) as GridViewInfo;
			Return TryCast(view.GetViewInfo(), GridViewInfo)
		End Function


		Private Function GetCellRect(ByVal view As GridView, ByVal rowHandle As Integer, ByVal column As GridColumn) As Rectangle
			Dim viewInfo As GridViewInfo = GetGridViewInfo(view)
			Return viewInfo.GetGridCellInfo(rowHandle, column.AbsoluteIndex).Bounds
		End Function

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			textBox1.Text = GetCellRect(gridView1, gridView1.FocusedRowHandle, gridView1.FocusedColumn).ToString()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
		End Sub
	End Class
End Namespace