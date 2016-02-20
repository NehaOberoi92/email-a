Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(4, 8)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(212, 20)
    Me.TextBox1.TabIndex = 0
    Me.TextBox1.Text = "nospam@hotmail.com"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(4, 36)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(212, 28)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Check"
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(4, 68)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(212, 16)
    Me.Label1.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(4, 88)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(212, 16)
    Me.Label2.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(4, 108)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(212, 16)
    Me.Label3.TabIndex = 4
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(224, 126)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.Label2, Me.Label1, Me.Button1, Me.TextBox1})
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    ' go to www.cdyne.com for more information

    Dim ev As New com.cdyne.ws.ev()
    Dim ri As com.cdyne.ws.ReturnIndicator
    ri = ev.VerifyEmail(TextBox1.Text)
    Label1.Text = ri.ResponseText
    Label2.Text = ri.ResponseCode
    Label3.Text = ri.LastMailServer
  End Sub
End Class
