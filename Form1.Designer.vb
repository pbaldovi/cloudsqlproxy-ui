<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ToolStrip1 = New ToolStrip()
        btnLogin = New ToolStripButton()
        btnAdd = New ToolStripButton()
        TreeView1 = New TreeView()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {btnLogin, btnAdd})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btnLogin
        ' 
        btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), Image)
        btnLogin.ImageTransparentColor = Color.Magenta
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(57, 22)
        btnLogin.Text = "Login"
        ' 
        ' btnAdd
        ' 
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.ImageTransparentColor = Color.Magenta
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(119, 22)
        btnAdd.Text = "Agregar Proyecto"
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(0, 28)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(273, 410)
        TreeView1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TreeView1)
        Controls.Add(ToolStrip1)
        Name = "Form1"
        Text = "Form1"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnLogin As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents TreeView1 As TreeView

End Class
