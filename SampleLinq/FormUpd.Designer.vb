<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpd
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
        Me.txtIdFrom = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.gViewEmails = New System.Windows.Forms.DataGridView()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        CType(Me.gViewEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdFrom
        '
        Me.txtIdFrom.Location = New System.Drawing.Point(80, 9)
        Me.txtIdFrom.Name = "txtIdFrom"
        Me.txtIdFrom.Size = New System.Drawing.Size(100, 19)
        Me.txtIdFrom.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(186, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "修正データ検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'gViewEmails
        '
        Me.gViewEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.gViewEmails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gViewEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gViewEmails.Location = New System.Drawing.Point(26, 208)
        Me.gViewEmails.Name = "gViewEmails"
        Me.gViewEmails.RowTemplate.Height = 21
        Me.gViewEmails.Size = New System.Drawing.Size(473, 150)
        Me.gViewEmails.TabIndex = 4
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(36, 154)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(100, 19)
        Me.txtCompany.TabIndex = 11
        Me.txtCompany.Text = "Company"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(36, 120)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 10
        Me.txtName.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(36, 88)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 19)
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.Text = "email"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(186, 75)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "データ修正"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "修正する値をセット"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ID検索"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(359, 75)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 15
        Me.btnDel.Text = "データ削除"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'FormUpd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 394)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.gViewEmails)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtIdFrom)
        Me.Name = "FormUpd"
        Me.Text = "FormUpd"
        CType(Me.gViewEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdFrom As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents gViewEmails As DataGridView
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDel As Button
End Class
