Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Linq
Imports System.Transactions


Public Class FormUpd
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Linqを使った検索サンプル


        Using con As New SqlConnection(My.Settings.Item("connectionString").ToString())
            Using Db As New DataContext(con)
                'DataGridViewで行う場合
                Try
                    'Dim Emails = Db.GetTable(Of emails)()
                    'Dim Query = From email In Emails Where email.id = Integer.Parse(Me.txtIdFrom.Text) Select email.id, email.email, email.name, email.company
                    'Me.gViewEmails.DataSource = Query
                    'If (Me.gViewEmails.RowCount = 0) Then
                    '    Me.gViewEmails.Enabled = False

                    'Else
                    '    Me.gViewEmails.Enabled = True
                    'End If

                    Dim Emails = Db.GetTable(Of emails)()
                    Dim arr() = (From email In Emails Where email.id = Integer.Parse(Me.txtIdFrom.Text) Select email.email, email.name, email.company, email.date_in).ToArray()
                    If arr.Length = 0 Then
                        MessageBox.Show("検索しましたがデータがありませんでした。")
                    Else
                        Me.txtName.Text = arr(0).name.ToString()
                        Me.txtCompany.Text = arr(0).company.ToString()
                        Me.txtEmail.Text = arr(0).email.ToString()

                    End If

                Catch ex As Exception
                    MessageBox.Show("検索エラー：" & ex.Message)
                End Try

            End Using
        End Using



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'DBとのコネクションを確立(接続文字列はApp.Configから取得(プログラムから外だし)
        Using con As New SqlConnection(My.Settings.Item("connectionString").ToString())
            'DataConTextクラスにコネクションをセット
            Using Db As New DataContext(con)
                'テーブルを取得
                'TEntityをセットしてオブジェクトのコレクションをセット。
                Dim Emails = Db.GetTable(Of emails)()
                Using Tran = New TransactionScope()

                    Try
                        '参考URL
                        'https://msdn.microsoft.com/ja-jp/library/bb534800(v=vs.105).aspx
                        'http://densan-labs.net/tech/codefirst/adddelete.html
                        'Singleメソッドで二件以上結果が取得されたら、例外スローされる
                        Dim Email = Emails.Single(Function(x) x.id = Integer.Parse(Me.txtIdFrom.Text.Trim))

                        '以下のプロパティのセットとSummitChangesでSQLのUpdate文と同じ
                        Email.email = Me.txtEmail.Text.Trim
                        Email.name = Me.txtName.Text.Trim
                        Email.company = Me.txtCompany.Text.Trim
                        Email.date_in = Now
                        Db.SubmitChanges()
                        'トランザクションをコミットする
                        Tran.Complete()
                        MessageBox.Show("更新しました！")
                    Catch ex As TransactionAbortedException
                        MessageBox.Show("トランザクション失敗[UPDATE]：" & ex.Message)
                    Catch ex As Exception
                        MessageBox.Show("例外発生：" & ex.Message)
                    End Try
                End Using
                'クエリ式を使って再表示
                'SELECT * FROM emails order by id descと同じ
                'ASP.NETのGridViewでも使える
                'しかし、ASP.NETで非同期処理をする場合は、サーバー側でHTMLのテーブルタグを生成しないので、
                '使えません。
                MessageBox.Show("確認用にGridViewに出力します。")

                Me.gViewEmails.DataSource = From x In Emails Order By x.id Descending

            End Using
        End Using
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        'DBとのコネクションを確立(接続文字列はApp.Configから取得(プログラムから外だし)
        Using con As New SqlConnection(My.Settings.Item("connectionString").ToString())
            'DataConTextクラスにコネクションをセット
            Using Db As New DataContext(con)
                'テーブルを取得
                'TEntityをセットしてオブジェクトのコレクションをセット。
                Dim Emails = Db.GetTable(Of emails)()
                Using Tran = New TransactionScope()

                    Try
                        '参考URL
                        'https://msdn.microsoft.com/ja-jp/library/bb534800(v=vs.105).aspx
                        'http://densan-labs.net/tech/codefirst/adddelete.html
                        'Singleメソッドで二件以上結果が取得されたら、例外スローされる
                        'Single()には、ラムダ式をセット
                        'https://msdn.microsoft.com/ja-jp/library/bb531298.aspx

                        Dim Email = Emails.Single(Function(x) x.id = Integer.Parse(Me.txtIdFrom.Text.Trim))
                        '以下の二行で削除
                        Emails.DeleteOnSubmit(Email)
                        Db.SubmitChanges()

                        'トランザクションをコミットする
                        Tran.Complete()
                        MessageBox.Show("データベースから削除しました！")

                    Catch ex As TransactionAbortedException
                        MessageBox.Show("トランザクション失敗[INSERT]：" & ex.Message)
                    Catch ex As Exception
                        MessageBox.Show("例外発生：" & ex.Message)
                    End Try
                End Using
                'クエリ式を使って再表示
                'SELECT * FROM emails order by id descと同じ
                'ASP.NETのGridViewでも使える
                'しかし、ASP.NETで非同期処理をする場合は、サーバー側でHTMLのテーブルタグを生成しないので、
                '使えません。
                MessageBox.Show("確認用にGridViewに出力します。")

                Me.gViewEmails.DataSource = From x In Emails Order By x.id Descending

            End Using
        End Using



    End Sub
End Class