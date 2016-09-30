Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class frmLogin

    Enum HashMethod
        MD5
        SHA1
        SHA384
    End Enum

    Function GenerateHashDigest(ByVal source As String, ByVal algorithm As HashMethod) As String
        Dim hashAlgorithm As HashAlgorithm = Nothing
        Select Case algorithm
            Case HashMethod.MD5
                hashAlgorithm = New MD5CryptoServiceProvider
            Case HashMethod.SHA1
                hashAlgorithm = New SHA1CryptoServiceProvider
            Case HashMethod.SHA384
				hashAlgorithm = New SHA384Managed
		End Select

        Dim byteValue = Encoding.UTF8.GetBytes(source)
        Dim hashValue = hashAlgorithm.ComputeHash(byteValue)
        Return Convert.ToBase64String(hashValue)
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
		For index = 0 To (DatabaseDataSet.tblUsers.Rows.Count() - 1)
			If ((UsernameTextBox.Text.Trim() = DatabaseDataSet.tblUsers(index).Username.Trim()) And (GenerateHashDigest(PasswordTextBox.Text.Trim(), HashMethod.SHA1) = DatabaseDataSet.tblUsers(index).Password.ToString.Trim())) Then
				frmMenu.Show()
				Hide()
			Else
				MsgBox("No such username")
			End If
		Next
	End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
		Close()
	End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'DatabaseDataSet.tblUsers' table. You can move, or remove it, as needed.
		TblUsersTableAdapter.Fill(DatabaseDataSet.tblUsers)
	End Sub

	Private Sub cmdDebug_Click(sender As Object, e As EventArgs)
		DatabaseDataSet.tblUsers(1).Password = GenerateHashDigest(PasswordTextBox.Text.Trim(), HashMethod.SHA1)
		MsgBox(DatabaseDataSet.tblUsers(1).Password)
		Try
			Validate()
			TblUsersBindingSource.EndEdit()
			TblUsersTableAdapter.Update(DatabaseDataSet.tblUsers)
			TableAdapterManager.UpdateAll(DatabaseDataSet)
		Catch ex As Exception
			MsgBox("Error: " & ex.Message())
		End Try
	End Sub
End Class
