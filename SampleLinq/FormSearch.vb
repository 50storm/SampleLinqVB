Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Linq


Public Class FormSearch
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Linq To SQLを使った
        'プログラム起動時の初期表示
        Using con As New SqlConnection(My.Settings.Item("connectionString").ToString())
            Using Db As New DataContext(con)
                Try
                    Dim Emails = Db.GetTable(Of emails)()
                    'Linqのクエリ式でデータを取得
                    'SQL:SELECT * From emailsと同じ
                    Dim Query = From p In Emails
                    'DataGridViewに検索結果をセット
                    Me.gViewEmails.DataSource = Query
                    If (Me.gViewEmails.RowCount = 0) Then
                        '検索ゼロ件の時のコード


                    End If

                Catch ex As Exception

                End Try


            End Using
        End Using

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Linqを使った検索サンプル


        Using con As New SqlConnection(My.Settings.Item("connectionString").ToString())
            Using Db As New DataContext(con)
                Try
                    Dim Emails = Db.GetTable(Of emails)()
                    Dim Query = From p In Emails Where p.id >= Integer.Parse(Me.txtIdFrom.Text) And p.id <= Integer.Parse(Me.txtIdTo.Text)
                                Select p.email, p.company


                    Me.gViewEmails.DataSource = Query
                    If (Me.gViewEmails.RowCount = 0) Then
                        MessageBox.Show("検索しましたが0件でした。")
                        Me.gViewEmails.Enabled = False
                    Else
                        Me.gViewEmails.Enabled = True


                    End If

                Catch ex As Exception
                    MessageBox.Show("検索エラー：" & ex.Message)

                End Try


            End Using
        End Using


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formIns As New FormIns
        formIns.Show()

    End Sub

    Private Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpd.Click
        Dim formUpd As New FormUpd
        formUpd.Show()


    End Sub
End Class
