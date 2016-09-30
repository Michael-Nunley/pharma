Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdDoctor_Click(sender As Object, e As EventArgs) Handles cmdDoctor.Click
		Hide()
		frmDoctor.Show()
    End Sub

    Private Sub cmdPharma_Click(sender As Object, e As EventArgs) Handles cmdPharma.Click

    End Sub

    Private Sub cmdAdmin_Click(sender As Object, e As EventArgs) Handles cmdAdmin.Click

    End Sub
End Class
