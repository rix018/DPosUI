Imports System.Drawing
Public Class Lapagan
    Private Sub Lapagan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DposUIGroupbox1_Click(sender As Object, e As EventArgs) Handles DposUIGroupbox1.Click
        DposUIGroupbox1.BorderColor = Color.Red
        DposUIGroupbox1.Refresh()
    End Sub
End Class