Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Linq
Imports System.Transactions



Public Class FormIns
    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click

        'DBとのコネクションを確立(接続文字列はApp.Configから取得(プログラムから外だし)
        Using con As New SqlConnection(My.Settings.Item("connectionString").ToString())
            'DataConTextクラスにコネクションをセット
            Using Db As New DataContext(con)
                'テーブルを取得
                'TEntityをセットしてオブジェクトのコレクションをセット。
                Dim Emails = Db.GetTable(Of emails)()
                Dim Enti As New emails

                Using Tran = New TransactionScope()

                    Try
                        'SQLパラメータをセット
                        Enti.email = Me.txtEmail.Text.Trim
                        Enti.name = Me.txtName.Text.Trim
                        Enti.company = Me.txtCompany.Text.Trim
                        Enti.date_in = Now
                        Enti.bit_col = True



                        '以下の二行でSQLのINSERTと同じ　↓
                        Emails.InsertOnSubmit(Enti)
                        Db.SubmitChanges()
                        'トランザクションをコミットする
                        Tran.Complete()
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
                Me.gViewEmails.DataSource = From x In Emails Order By x.id Descending

            End Using
        End Using


    End Sub
End Class