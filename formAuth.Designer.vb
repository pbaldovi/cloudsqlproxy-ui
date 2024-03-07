<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAuth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAuth))
        btnAuth = New Button()
        btnOauth = New Button()
        SuspendLayout()
        ' 
        ' btnAuth
        ' 
        btnAuth.Location = New Point(210, 141)
        btnAuth.Name = "btnAuth"
        btnAuth.Size = New Size(75, 23)
        btnAuth.TabIndex = 0
        btnAuth.Text = "Cancel"
        btnAuth.UseVisualStyleBackColor = True
        ' 
        ' btnOauth
        ' 
        btnOauth.Image = CType(resources.GetObject("btnOauth.Image"), Image)
        btnOauth.Location = New Point(12, 12)
        btnOauth.Name = "btnOauth"
        btnOauth.Size = New Size(476, 105)
        btnOauth.TabIndex = 1
        btnOauth.UseVisualStyleBackColor = True
        ' 
        ' formAuth
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 175)
        Controls.Add(btnOauth)
        Controls.Add(btnAuth)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "formAuth"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "formAuth"
        ResumeLayout(False)

    End Sub

    Friend WithEvents btnAuth As Button
    Friend WithEvents btnOauth As Button

End Class
