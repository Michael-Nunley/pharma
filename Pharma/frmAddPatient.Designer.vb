<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdd
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
		Me.cmdOk = New System.Windows.Forms.Button()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblAge = New System.Windows.Forms.Label()
		Me.txtAge = New System.Windows.Forms.TextBox()
		Me.lblHeight = New System.Windows.Forms.Label()
		Me.txtHeight = New System.Windows.Forms.TextBox()
		Me.lblWeight = New System.Windows.Forms.Label()
		Me.txtWeight = New System.Windows.Forms.TextBox()
		Me.lblSex = New System.Windows.Forms.Label()
		Me.txtSex = New System.Windows.Forms.TextBox()
		Me.DatabaseDataSet = New Pharma.DatabaseDataSet()
		Me.TblPatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblPatientsTableAdapter = New Pharma.DatabaseDataSetTableAdapters.tblPatientsTableAdapter()
		Me.TableAdapterManager = New Pharma.DatabaseDataSetTableAdapters.TableAdapterManager()
		CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblPatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cmdOk
		'
		Me.cmdOk.Location = New System.Drawing.Point(12, 136)
		Me.cmdOk.Name = "cmdOk"
		Me.cmdOk.Size = New System.Drawing.Size(75, 23)
		Me.cmdOk.TabIndex = 0
		Me.cmdOk.Text = "Ok"
		Me.cmdOk.UseVisualStyleBackColor = True
		'
		'cmdCancel
		'
		Me.cmdCancel.Location = New System.Drawing.Point(93, 136)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
		Me.cmdCancel.TabIndex = 1
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.UseVisualStyleBackColor = True
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(54, 6)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(114, 20)
		Me.txtName.TabIndex = 2
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(13, 9)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 3
		Me.lblName.Text = "Name"
		'
		'lblAge
		'
		Me.lblAge.AutoSize = True
		Me.lblAge.Location = New System.Drawing.Point(13, 35)
		Me.lblAge.Name = "lblAge"
		Me.lblAge.Size = New System.Drawing.Size(26, 13)
		Me.lblAge.TabIndex = 5
		Me.lblAge.Text = "Age"
		'
		'txtAge
		'
		Me.txtAge.Location = New System.Drawing.Point(54, 32)
		Me.txtAge.Name = "txtAge"
		Me.txtAge.Size = New System.Drawing.Size(114, 20)
		Me.txtAge.TabIndex = 4
		'
		'lblHeight
		'
		Me.lblHeight.AutoSize = True
		Me.lblHeight.Location = New System.Drawing.Point(13, 61)
		Me.lblHeight.Name = "lblHeight"
		Me.lblHeight.Size = New System.Drawing.Size(38, 13)
		Me.lblHeight.TabIndex = 7
		Me.lblHeight.Text = "Height"
		'
		'txtHeight
		'
		Me.txtHeight.Location = New System.Drawing.Point(54, 58)
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(114, 20)
		Me.txtHeight.TabIndex = 6
		'
		'lblWeight
		'
		Me.lblWeight.AutoSize = True
		Me.lblWeight.Location = New System.Drawing.Point(13, 87)
		Me.lblWeight.Name = "lblWeight"
		Me.lblWeight.Size = New System.Drawing.Size(41, 13)
		Me.lblWeight.TabIndex = 9
		Me.lblWeight.Text = "Weight"
		'
		'txtWeight
		'
		Me.txtWeight.Location = New System.Drawing.Point(54, 84)
		Me.txtWeight.Name = "txtWeight"
		Me.txtWeight.Size = New System.Drawing.Size(114, 20)
		Me.txtWeight.TabIndex = 8
		'
		'lblSex
		'
		Me.lblSex.AutoSize = True
		Me.lblSex.Location = New System.Drawing.Point(13, 113)
		Me.lblSex.Name = "lblSex"
		Me.lblSex.Size = New System.Drawing.Size(25, 13)
		Me.lblSex.TabIndex = 11
		Me.lblSex.Text = "Sex"
		'
		'txtSex
		'
		Me.txtSex.Location = New System.Drawing.Point(54, 110)
		Me.txtSex.Name = "txtSex"
		Me.txtSex.Size = New System.Drawing.Size(114, 20)
		Me.txtSex.TabIndex = 10
		'
		'DatabaseDataSet
		'
		Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
		Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TblPatientsBindingSource
		'
		Me.TblPatientsBindingSource.DataMember = "tblPatients"
		Me.TblPatientsBindingSource.DataSource = Me.DatabaseDataSet
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
		'frmAdd
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(189, 173)
		Me.Controls.Add(Me.lblSex)
		Me.Controls.Add(Me.txtSex)
		Me.Controls.Add(Me.lblWeight)
		Me.Controls.Add(Me.txtWeight)
		Me.Controls.Add(Me.lblHeight)
		Me.Controls.Add(Me.txtHeight)
		Me.Controls.Add(Me.lblAge)
		Me.Controls.Add(Me.txtAge)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.cmdCancel)
		Me.Controls.Add(Me.cmdOk)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "frmAdd"
		Me.Text = "New Patient"
		CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblPatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cmdOk As Button
	Friend WithEvents cmdCancel As Button
	Friend WithEvents txtName As TextBox
	Friend WithEvents lblName As Label
	Friend WithEvents lblAge As Label
	Friend WithEvents txtAge As TextBox
	Friend WithEvents lblHeight As Label
	Friend WithEvents txtHeight As TextBox
	Friend WithEvents lblWeight As Label
	Friend WithEvents txtWeight As TextBox
	Friend WithEvents lblSex As Label
	Friend WithEvents txtSex As TextBox
	Friend WithEvents DatabaseDataSet As DatabaseDataSet
	Friend WithEvents TblPatientsBindingSource As BindingSource
	Friend WithEvents TblPatientsTableAdapter As DatabaseDataSetTableAdapters.tblPatientsTableAdapter
	Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
End Class
