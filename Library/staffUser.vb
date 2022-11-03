Imports System.Data.SqlClient
Imports System.Configuration
Public Class staffUser
    Dim Con = System.Configuration.ConfigurationManager.ConnectionStrings("LCS").ConnectionString
    Private Sub staffUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userlist()
        dash()
        ispis()
        CKarta.SelectedIndex = -1
        pkclan.Visible = False
    End Sub
    Private Sub dash()
        Dim kobr As Integer
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim sql = "select COUNT (*) from UserTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, kon)
        kobr = cmd.ExecuteScalar
        broj.Text = kobr
        kon.Close()
    End Sub
    Private Sub ResetUS()
        UIme.Text = ""
        UsD.SelectedIndex = -1
        UDok.Text = ""
        nclan.Text = ""
        CKarta.SelectedIndex = -1
    End Sub
    Private Sub userlist()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim sql = "select * from UserTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, kon)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UserDG.DataSource = ds.Tables(0)
        kon.Close()
    End Sub
    Dim key = 0
    Private Sub UserDG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDG.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = UserDG.Rows(e.RowIndex)
            UIme.Text = row.Cells(1).Value.ToString
            CKarta.Text = row.Cells(2).Value.ToString
            UsD.SelectedItem = row.Cells(3).Value.ToString
            UDok.Text = row.Cells(4).Value.ToString
            pkclan.Text = row.Cells(5).Value.ToString
            If UIme.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        End If
    End Sub
    Private Sub addko_Click(sender As Object, e As EventArgs) Handles addko.Click
        If UIme.Text = "" Or CKarta.SelectedIndex = -1 Or UsD.SelectedIndex = -1 Or UDok.Text = "" Then
            MsgBox("Greška. Unesite potrebne podatke!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "select * from UserTbl where Korisnik ='" & UIme.Text & "' And Dokument ='" & UsD.SelectedItem.ToString() & "' And Serijskibroj ='" & UDok.Text & "'"
            Dim cmd = New SqlCommand(query, kon)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 1 Then
                MsgBox("Korisnik vec postoji!")
                ResetUS()
                userlist()
                dash()
            Else
                Dim kone = New SqlConnection(Con)
                kone.Open()
                Dim queryy = "insert into UserTbl values ('" & UIme.Text & "', '" & CKarta.SelectedValue.ToString() & "', '" & UsD.SelectedItem.ToString() & "','" & UDok.Text & "','" & pkclan.SelectedValue.ToString() & "')"
                Dim cmds As SqlCommand
                cmds = New SqlCommand(queryy, kone)
                cmds.ExecuteNonQuery()
                MsgBox("Korisnik dodan u bazu!")
                kone.Close()
                ResetUS()
                userlist()
                dash()
            End If
        kon.Close()
        End If
    End Sub

    Private Sub editko_Click(sender As Object, e As EventArgs) Handles editko.Click
        If UIme.Text = "" Or CKarta.SelectedIndex = -1 Or UsD.SelectedIndex = -1 Or UDok.Text = "" Or key = 0 Then
            MsgBox("Greška. Odaberite korisnika!")
        Else
            Try
                Dim kon = New SqlConnection(Con)
                kon.Open()
                Dim query = "update UserTbl set Korisnik='" & UIme.Text & "', Clanska='" & CKarta.SelectedValue.ToString() & "', Dokument='" & UsD.SelectedItem.ToString() & "', Serijskibroj='" & UDok.Text & "',KarticaID='" & pkclan.SelectedValue.ToString() & "' where IDK=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()
                MsgBox("Promjena uspješna!")
                kon.Close()
                ResetUS()
                userlist()
                dash()
                key = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub delko_Click(sender As Object, e As EventArgs) Handles delko.Click
        If key = 0 Then
            MsgBox("Greška. Odaberite korisnika!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "delete from UserTbl where IDK=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Korisnik izbrisan iz baze!")
            kon.Close()
            ResetUS()
            userlist()
            dash()
            key = 0
        End If
    End Sub

    Private Sub knji_Click(sender As Object, e As EventArgs) Handles knji.Click
        Dim boo = New BooksPage
        boo.Show()
        Me.Hide()
    End Sub

    Private Sub resko_Click(sender As Object, e As EventArgs) Handles resko.Click
        ResetUS()
    End Sub

    Private Sub odjavise_Click(sender As Object, e As EventArgs) Handles odjavise.Click
        Dim pocetnas = New loginForma
        pocetnas.Show()
        Me.Hide()
    End Sub

    Private Sub addcardbtn_Click(sender As Object, e As EventArgs) Handles addcardbtn.Click
        If nclan.Text = "" Then
            MsgBox("Greška. Unesite naziv nove kartice!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "insert into UserKartice values ('" & nclan.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Clanska kartica dodana u bazu!")
            kon.Close()
            nclan.Text = ""
            ispis()
            CKarta.SelectedIndex = -1
        End If
    End Sub
    Private Sub ispis()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim cmd = New SqlCommand("select * from UserKartice", kon)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        CKarta.DataSource = Tbl
        CKarta.DisplayMember = "Clanska"
        CKarta.ValueMember = "Clanska"
        pkclan.DataSource = Tbl
        pkclan.DisplayMember = "KarticaID"
        pkclan.ValueMember = "KarticaID"
        kon.Close()
    End Sub

    Private Sub reze_Click(sender As Object, e As EventArgs) Handles reze.Click
        Dim bores = New BookReservation
        bores.Show()
        Me.Hide()
    End Sub
End Class