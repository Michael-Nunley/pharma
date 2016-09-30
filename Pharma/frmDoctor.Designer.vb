<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDoctor
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim NameLabel As System.Windows.Forms.Label
		Dim AgeLabel As System.Windows.Forms.Label
		Dim HeightLabel As System.Windows.Forms.Label
		Dim WeightLabel As System.Windows.Forms.Label
		Dim SexLabel As System.Windows.Forms.Label
		Me.gbPatient = New System.Windows.Forms.GroupBox()
		Me.SexTextBox = New System.Windows.Forms.TextBox()
		Me.TblPatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DatabaseDataSet = New Pharma.DatabaseDataSet()
		Me.WeightTextBox = New System.Windows.Forms.TextBox()
		Me.HeightTextBox = New System.Windows.Forms.TextBox()
		Me.AgeTextBox = New System.Windows.Forms.TextBox()
		Me.NameTextBox = New System.Windows.Forms.TextBox()
		Me.cmdAdd = New System.Windows.Forms.Button()
		Me.TblPatientsTableAdapter = New Pharma.DatabaseDataSetTableAdapters.tblPatientsTableAdapter()
		Me.TableAdapterManager = New Pharma.DatabaseDataSetTableAdapters.TableAdapterManager()
		Me.lstPatients = New System.Windows.Forms.ListBox()
		Me.cmdRefresh = New System.Windows.Forms.Button()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		NameLabel = New System.Windows.Forms.Label()
		AgeLabel = New System.Windows.Forms.Label()
		HeightLabel = New System.Windows.Forms.Label()
		WeightLabel = New System.Windows.Forms.Label()
		SexLabel = New System.Windows.Forms.Label()
		Me.gbPatient.SuspendLayout()
		CType(Me.TblPatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'NameLabel
		'
		NameLabel.AutoSize = True
		NameLabel.Location = New System.Drawing.Point(24, 28)
		NameLabel.Name = "NameLabel"
		NameLabel.Size = New System.Drawing.Size(38, 13)
		NameLabel.TabIndex = 0
		NameLabel.Text = "Name:"
		'
		'AgeLabel
		'
		AgeLabel.AutoSize = True
		AgeLabel.Location = New System.Drawing.Point(33, 54)
		AgeLabel.Name = "AgeLabel"
		AgeLabel.Size = New System.Drawing.Size(29, 13)
		AgeLabel.TabIndex = 2
		AgeLabel.Text = "Age:"
		'
		'HeightLabel
		'
		HeightLabel.AutoSize = True
		HeightLabel.Location = New System.Drawing.Point(21, 80)
		HeightLabel.Name = "HeightLabel"
		HeightLabel.Size = New System.Drawing.Size(41, 13)
		HeightLabel.TabIndex = 4
		HeightLabel.Text = "Height:"
		'
		'WeightLabel
		'
		WeightLabel.AutoSize = True
		WeightLabel.Location = New System.Drawing.Point(18, 106)
		WeightLabel.Name = "WeightLabel"
		WeightLabel.Size = New System.Drawing.Size(44, 13)
		WeightLabel.TabIndex = 6
		WeightLabel.Text = "Weight:"
		'
		'SexLabel
		'
		SexLabel.AutoSize = True
		SexLabel.Location = New System.Drawing.Point(34, 132)
		SexLabel.Name = "SexLabel"
		SexLabel.Size = New System.Drawing.Size(28, 13)
		SexLabel.TabIndex = 8
		SexLabel.Text = "Sex:"
		'
		'gbPatient
		'
		Me.gbPatient.Controls.Add(SexLabel)
		Me.gbPatient.Controls.Add(Me.SexTextBox)
		Me.gbPatient.Controls.Add(WeightLabel)
		Me.gbPatient.Controls.Add(Me.WeightTextBox)
		Me.gbPatient.Controls.Add(HeightLabel)
		Me.gbPatient.Controls.Add(Me.HeightTextBox)
		Me.gbPatient.Controls.Add(AgeLabel)
		Me.gbPatient.Controls.Add(Me.AgeTextBox)
		Me.gbPatient.Controls.Add(NameLabel)
		Me.gbPatient.Controls.Add(Me.NameTextBox)
		Me.gbPatient.Location = New System.Drawing.Point(138, 26)
		Me.gbPatient.Name = "gbPatient"
		Me.gbPatient.Size = New System.Drawing.Size(184, 163)
		Me.gbPatient.TabIndex = 1
		Me.gbPatient.TabStop = False
		Me.gbPatient.Text = "Patient"
		'
		'SexTextBox
		'
		Me.SexTextBox.Location = New System.Drawing.Point(68, 129)
		Me.SexTextBox.Name = "SexTextBox"
		Me.SexTextBox.Size = New System.Drawing.Size(100, 20)
		Me.SexTextBox.TabIndex = 9
		'
		'TblPatientsBindingSource
		'
		Me.TblPatientsBindingSource.DataMember = "tblPatients"
		Me.TblPatientsBindingSource.DataSource = Me.DatabaseDataSet
		'
		'DatabaseDataSet
		'
		Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
		Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'WeightTextBox
		'
		Me.WeightTextBox.Location = New System.Drawing.Point(68, 103)
		Me.WeightTextBox.Name = "WeightTextBox"
		Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
		Me.WeightTextBox.TabIndex = 7
		'
		'HeightTextBox
		'
		Me.HeightTextBox.Location = New System.Drawing.Point(68, 77)
		Me.HeightTextBox.Name = "HeightTextBox"
		Me.HeightTextBox.Size = New System.Drawing.Size(100, 20)
		Me.HeightTextBox.TabIndex = 5
		'
		'AgeTextBox
		'
		Me.AgeTextBox.Location = New System.Drawing.Point(68, 51)
		Me.AgeTextBox.Name = "AgeTextBox"
		Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
		Me.AgeTextBox.TabIndex = 3
		'
		'NameTextBox
		'
		Me.NameTextBox.Location = New System.Drawing.Point(68, 25)
		Me.NameTextBox.Name = "NameTextBox"
		Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
		Me.NameTextBox.TabIndex = 1
		'
		'cmdAdd
		'
		Me.cmdAdd.Location = New System.Drawing.Point(138, 195)
		Me.cmdAdd.Name = "cmdAdd"
		Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
		Me.cmdAdd.TabIndex = 2
		Me.cmdAdd.Text = "Add New"
		Me.cmdAdd.UseVisualStyleBackColor = True
		'
		'TblPatientsTableAdapter
		'
		Me.TblPatientsTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager.tblPatientsTableAdapter = Me.TblPatientsTableAdapter
		Me.TableAdapterManager.tblUsersTableAdapter = Nothing
		Me.TableAdapterManager.UpdateOrder = Pharma.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'lstPatients
		'
		Me.lstPatients.FormattingEnabled = True
		Me.lstPatients.Location = New System.Drawing.Point(12, 26)
		Me.lstPatients.Name = "lstPatients"
		Me.lstPatients.Size = New System.Drawing.Size(120, 355)
		Me.lstPatients.TabIndex = 3
		'
		'cmdRefresh
		'
		Me.cmdRefresh.Location = New System.Drawing.Point(139, 225)
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.cmdRefresh.Size = New System.Drawing.Size(75, 23)
		Me.cmdRefresh.TabIndex = 4
		Me.cmdRefresh.Text = "Refresh"
		Me.cmdRefresh.UseVisualStyleBackColor = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(334, 24)
		Me.MenuStrip1.TabIndex = 5
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'frmDoctor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(334, 393)
		Me.Controls.Add(Me.cmdRefresh)
		Me.Controls.Add(Me.lstPatients)
		Me.Controls.Add(Me.cmdAdd)
		Me.Controls.Add(Me.gbPatient)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frmDoctor"
		Me.Text = "Doctor"
		Me.gbPatient.ResumeLayout(False)
		Me.gbPatient.PerformLayout()
		CType(Me.TblPatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents gbPatient As GroupBox
	Friend WithEvents cmdAdd As Button
	Friend WithEvents DatabaseDataSet As DatabaseDataSet
	Friend WithEvents TblPatientsBindingSource As BindingSource
	Friend WithEvents TblPatientsTableAdapter As DatabaseDataSetTableAdapters.tblPatientsTableAdapter
	Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
	Friend WithEvents SexTextBox As TextBox
	Friend WithEvents WeightTextBox As TextBox
	Friend WithEvents HeightTextBox As TextBox
	Friend WithEvents AgeTextBox As TextBox
	Friend WithEvents NameTextBox As TextBox
	Friend WithEvents lstPatients As ListBox
	Friend WithEvents cmdRefresh As Button
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
