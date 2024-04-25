Public Class Navigation
    Private Sub _btnGotoAdd_Click(sender As Object, e As EventArgs) Handles _btnGotoAdd.Click
        Dim frm As Form = New NewCustomer()
        frm.Show()
    End Sub

    Private Sub _btnGoToFillOrCancel_Click(sender As Object, e As EventArgs) Handles _btnGoToFillOrCancel.Click
        Dim frm As Form = New FillOrCancel()
        frm.Show()
    End Sub

    Private Sub _btnExit_Click(sender As Object, e As EventArgs) Handles _btnExit.Click
        Me.Close()
    End Sub
End Class
