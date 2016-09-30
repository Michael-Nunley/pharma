Public Class frmDoctor
	Public selected As Int16

	Private Sub frmDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'DatabaseDataSet.tblPatients' table. You can move, or remove it, as needed.
		TblPatientsTableAdapter.Fill(DatabaseDataSet.tblPatients)
	End Sub

	Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
		frmAdd.Show()
	End Sub

	Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
		TblPatientsTableAdapter.Fill(DatabaseDataSet.tblPatients)
		selected = lstPatients.SelectedIndex
		lstPatients.Items.Clear()
		For index = 0 To (DatabaseDataSet.tblPatients.Rows.Count() - 1)
			lstPatients.Items.Add(DatabaseDataSet.tblPatients(index).Name)
		Next
		lstPatients.SelectedIndex = selected
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		End
	End Sub

	Private Sub lstPatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPatients.SelectedIndexChanged
		Try
			NameTextBox.Text = DatabaseDataSet.tblPatients(lstPatients.SelectedIndex).Name.ToString
			AgeTextBox.Text = DatabaseDataSet.tblPatients(lstPatients.SelectedIndex).Age.ToString
			WeightTextBox.Text = DatabaseDataSet.tblPatients(lstPatients.SelectedIndex).Weight.ToString
			HeightTextBox.Text = DatabaseDataSet.tblPatients(lstPatients.SelectedIndex).Height.ToString
			SexTextBox.Text = DatabaseDataSet.tblPatients(lstPatients.SelectedIndex).Sex.ToString
		Catch ex As Exception
			MsgBox("Error: " & ex.Message())
		End Try
	End Sub
End Class