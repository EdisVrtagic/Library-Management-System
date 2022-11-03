Imports System.Data.SqlClient
Imports System.Configuration
Public Class BookReservation
    Dim Con = System.Configuration.ConfigurationManager.ConnectionStrings("LCS").ConnectionString
    Private Sub BookReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ispisik()
        ispisib()
        reslist()
        kobroj.Visible = False
        knbroj.Visible = False
    End Sub
    Private Sub ispisik()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim cmd = New SqlCommand("select * from UserTbl", kon)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        bkor.DataSource = Tbl
        bkor.DisplayMember = "Korisnik"
        bkor.ValueMember = "Korisnik"
        kobroj.DataSource = Tbl
        kobroj.DisplayMember = "IDK"
        kobroj.ValueMember = "IDK"
        kon.Close()
    End Sub
    Private Sub ispisib()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim cmd = New SqlCommand("select * from BooksTbl", kon)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        kbox.DataSource = Tbl
        kbox.DisplayMember = "Knjiga"
        kbox.ValueMember = "Knjiga"
        knbroj.DataSource = Tbl
        knbroj.DisplayMember = "BookID"
        knbroj.ValueMember = "BookID"
        aubox.DataSource = Tbl
        aubox.DisplayMember = "Autor"
        aubox.ValueMember = "Autor"
        kon.Close()
    End Sub
    Private Sub addres_Click(sender As Object, e As EventArgs) Handles addres.Click
        If bkor.SelectedIndex = -1 Or kbox.SelectedIndex = -1 Or ODD.Text = "" Or DOD.Text = "" Then
            MsgBox("Greška. Odaberite potrebne podatke!")
        Else
            Dim kone = New SqlConnection(Con)
            kone.Open()
            Dim queryy = "insert into BookResTbl values ('" & bkor.SelectedValue.ToString() & "','" & kbox.SelectedValue.ToString() & "','" & aubox.SelectedValue.ToString() & "','" & ODD.Text & "','" & DOD.Text & "','" & kobroj.SelectedValue.ToString() & "','" & knbroj.SelectedValue.ToString() & "')"
            Dim cmds As SqlCommand
            cmds = New SqlCommand(queryy, kone)
            cmds.ExecuteNonQuery()
            MsgBox("Rezervacija knjige izvrsena!")
            kone.Close()
            ResetRE()
            reslist()
        End If
    End Sub
    Dim key = 0
    Private Sub ResDG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ResDG.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = ResDG.Rows(e.RowIndex)
            bkor.Text = row.Cells(1).Value.ToString
            kbox.Text = row.Cells(2).Value.ToString
            aubox.Text = row.Cells(3).Value.ToString
            ODD.Text = row.Cells(4).Value.ToString
            DOD.Text = row.Cells(5).Value.ToString
            kobroj.Text = row.Cells(6).Value.ToString
            knbroj.Text = row.Cells(7).Value.ToString
            If bkor.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        End If
    End Sub
    Private Sub reslist()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim sql = "select * from BookResTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, kon)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ResDG.DataSource = ds.Tables(0)
        kon.Close()
    End Sub
    Private Sub ResetRE()
        bkor.Text = ""
        kbox.Text = ""
        aubox.Text = ""
        ODD.Text = ""
        DOD.Text = ""
        kobroj.Text = ""
        knbroj.Text = ""
    End Sub

    Private Sub resin_Click(sender As Object, e As EventArgs) Handles resin.Click
        ResetRE()
    End Sub
    Private Sub delin_Click(sender As Object, e As EventArgs) Handles delin.Click
        If key = 0 Then
            MsgBox("Greška. Odaberite rezervaciju!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "delete from BookResTbl where ResID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Rezervacija izbrisana iz baze!")
            kon.Close()
            ResetRE()
            reslist()
            key = 0
        End If
    End Sub

    Private Sub boox_Click(sender As Object, e As EventArgs) Handles boox.Click
        Dim stafu = New staffUser
        stafu.Show()
        Me.Hide()
    End Sub

    Private Sub editin_Click(sender As Object, e As EventArgs) Handles editin.Click
        If bkor.SelectedIndex = -1 Or kbox.SelectedIndex = -1 Or ODD.Text = "" Or DOD.Text = "" Or key = 0 Then
            MsgBox("Greška. Odaberite rezervaciju!")
        Else
            Try
                Dim kon = New SqlConnection(Con)
                kon.Open()
                Dim query = "update BookResTbl set ImePrezime='" & bkor.SelectedValue.ToString() & "', ImeKnjige='" & kbox.SelectedValue.ToString() & "', AutorKnjige='" & aubox.SelectedValue.ToString() & "', OdDatuma='" & ODD.Text & "',DoDatuma='" & DOD.Text & "',IDK='" & kobroj.SelectedValue.ToString() & "',BookID='" & knbroj.SelectedValue.ToString() & "' where ResID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()
                MsgBox("Promjena uspješna!")
                kon.Close()
                ResetRE()
                reslist()
                key = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class