<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearch
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtIdFrom = New System.Windows.Forms.TextBox()
        Me.gViewEmails = New System.Windows.Forms.DataGridView()
        Me.txtIdTo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpd = New System.Windows.Forms.Button()
        CType(Me.gViewEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(197, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtIdFrom
        '
        Me.txtIdFrom.Location = New System.Drawing.Point(42, 12)
        Me.txtIdFrom.Name = "txtIdFrom"
        Me.txtIdFrom.Size = New System.Drawing.Size(100, 19)
        Me.txtIdFrom.TabIndex = 1
        '
        'gViewEmails
        '
        Me.gViewEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.gViewEmails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gViewEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gViewEmails.Location = New System.Drawing.Point(12, 79)
        Me.gViewEmails.Name = "gViewEmails"
        Me.gViewEmails.RowTemplate.Height = 21
        Me.gViewEmails.Size = New System.Drawing.Size(403, 150)
        Me.gViewEmails.TabIndex = 2
        '
        'txtIdTo
        '
        Me.txtIdTo.Location = New System.Drawing.Point(42, 38)
        Me.txtIdTo.Name = "txtIdTo"
        Me.txtIdTo.Size = New System.Drawing.Size(100, 19)
        Me.txtIdTo.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "登録サンプル"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUpd
        '
        Me.btnUpd.Location = New System.Drawing.Point(287, 41)
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(75, 23)
        Me.btnUpd.TabIndex = 5
        Me.btnUpd.Text = "修正サンプル"
        Me.btnUpd.UseVisualStyleBackColor = True
        '
        'FormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 251)
        Me.Controls.Add(Me.btnUpd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIdTo)
        Me.Controls.Add(Me.gViewEmails)
        Me.Controls.Add(Me.txtIdFrom)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "FormSearch"
        Me.Text = "Form1"
        CType(Me.gViewEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtIdFrom As TextBox
    Friend WithEvents gViewEmails As DataGridView
    Friend WithEvents txtIdTo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUpd As Button
End Class
