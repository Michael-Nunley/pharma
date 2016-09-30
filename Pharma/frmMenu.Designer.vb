<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdDoctor = New System.Windows.Forms.Button()
        Me.cmdPharma = New System.Windows.Forms.Button()
        Me.cmdAdmin = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDoctor
        '
        Me.cmdDoctor.Location = New System.Drawing.Point(12, 27)
        Me.cmdDoctor.Name = "cmdDoctor"
        Me.cmdDoctor.Size = New System.Drawing.Size(75, 23)
        Me.cmdDoctor.TabIndex = 0
        Me.cmdDoctor.Text = "Doctor"
        Me.cmdDoctor.UseVisualStyleBackColor = True
        '
        'cmdPharma
        '
        Me.cmdPharma.Location = New System.Drawing.Point(93, 27)
        Me.cmdPharma.Name = "cmdPharma"
        Me.cmdPharma.Size = New System.Drawing.Size(75, 23)
        Me.cmdPharma.TabIndex = 1
        Me.cmdPharma.Text = "Pharmacist"
        Me.cmdPharma.UseVisualStyleBackColor = True
        '
        'cmdAdmin
        '
        Me.cmdAdmin.Location = New System.Drawing.Point(174, 27)
        Me.cmdAdmin.Name = "cmdAdmin"
        Me.cmdAdmin.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdmin.TabIndex = 2
        Me.cmdAdmin.Text = "Admin"
        Me.cmdAdmin.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLogout, Me.cmdExit})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdLogout
        '
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(152, 22)
        Me.cmdLogout.Text = "Logout"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(152, 22)
        Me.cmdExit.Text = "Exit"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 65)
        Me.Controls.Add(Me.cmdAdmin)
        Me.Controls.Add(Me.cmdPharma)
        Me.Controls.Add(Me.cmdDoctor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDoctor As Button
    Friend WithEvents cmdPharma As Button
    Friend WithEvents cmdAdmin As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cmdFile As ToolStripMenuItem
    Friend WithEvents cmdLogout As ToolStripMenuItem
    Friend WithEvents cmdExit As ToolStripMenuItem
End Class
