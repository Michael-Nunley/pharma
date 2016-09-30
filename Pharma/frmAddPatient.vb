Public Class frmAdd

	Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'DatabaseDataSet.tblPatients' table. You can move, or remove it, as needed.
		TblPatientsTableAdapter.Fill(DatabaseDataSet.tblPatients)
	End Sub

	Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
		TblPatientsTableAdapter.Fill(DatabaseDataSet.tblPatients)
		Try
			TblPatientsTableAdapter.Insert(DatabaseDataSet.tblPatients.Rows.Count(), txtName.Text, Val(txtAge.Text), Val(txtWeight.Text), Val(txtHeight.Text), txtSex.Text)
		Catch ex As Exception
			MsgBox("Error: " & ex.Message())
		End Try
		Try
			Validate()
			DatabaseDataSet.AcceptChanges()
			TblPatientsBindingSource.EndEdit()
			TblPatientsTableAdapter.Update(DatabaseDataSet.tblPatients)
			TableAdapterManager.UpdateAll(DatabaseDataSet)
		Catch ex As Exception
			MsgBox("Error: " & ex.Message())
		End Try
		Close()
	End Sub
End Class