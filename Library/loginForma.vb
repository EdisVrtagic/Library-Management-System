Imports System.Data.SqlClient
Imports System.Configuration
Public Class loginForma
    Dim Con = System.Configuration.ConfigurationManager.ConnectionStrings("LCS").ConnectionString
    Private Sub izlazak_Click(sender As Object, e As EventArgs) Handles izlazak.Click
        Application.Exit()
    End Sub
    Private Sub cekbox_CheckedChanged(sender As Object, e As EventArgs) Handles cekbox.CheckedChanged
        If cekbox.CheckState = CheckState.Checked Then
            pass.PasswordChar = ""
        Else
            pass.PasswordChar = "*"
        End If
    End Sub
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If usern.Text = "" Or pass.Text = "" Then
            MsgBox("Greška. Unesite potrebne podatke!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "select * from StaffTbl where Zaposlenik ='" & usern.Text & "' And Lozinka ='" & pass.Text & "'"
            Dim cmd = New SqlCommand(query, kon)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim mojcitac As SqlDataReader
            mojcitac = cmd.ExecuteReader
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Pogrešan username ili password,pokušajte ponovo!")
            Else
                Dim proit = New staffUser
                proit.Show()
                Me.Hide()
            End If
            kon.Close()
        End If
    End Sub
    Private Sub alogbtn_Click(sender As Object, e As EventArgs) Handles alogbtn.Click
        If usern.Text = "" Or pass.Text = "" Then
            MsgBox("Greška. Unesite potrebne podatke!")
        ElseIf usern.Text = "admin" And pass.Text = "123" Then
            Dim adpage As New adminPage
            adpage.Show()
            Me.Hide()
        Else
            MsgBox("Pogrešan username ili password,pokušajte ponovo!")
        End If
    End Sub
End Class
