<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIns
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.gViewEmails = New System.Windows.Forms.DataGridView()
        CType(Me.gViewEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(187, 31)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(75, 23)
        Me.btnIns.TabIndex = 5
        Me.btnIns.Text = "登録"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(59, 31)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 19)
        Me.txtEmail.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(59, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 7
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(59, 105)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(100, 19)
        Me.txtCompany.TabIndex = 8
        '
        'gViewEmails
        '
        Me.gViewEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gViewEmails.Location = New System.Drawing.Point(12, 146)
        Me.gViewEmails.Name = "gViewEmails"
        Me.gViewEmails.RowTemplate.Height = 21
        Me.gViewEmails.Size = New System.Drawing.Size(359, 150)
        Me.gViewEmails.TabIndex = 9
        '
        'FormIns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 330)
        Me.Controls.Add(Me.gViewEmails)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnIns)
        Me.Name = "FormIns"
        Me.Text = "FormIns"
        CType(Me.gViewEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIns As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents gViewEmails As DataGridView
End Class
