Imports System.Data.SqlClient
Imports System.Configuration
Public Class BooksPage
    Dim Con = System.Configuration.ConfigurationManager.ConnectionStrings("LCS").ConnectionString
    Private Sub kori_Click(sender As Object, e As EventArgs) Handles kori.Click
        Dim kor = New staffUser
        kor.Show()
        Me.Hide()
    End Sub

    Private Sub BooksPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ispisi()
        booklist()
        KaK.SelectedIndex = -1
        adkl.SelectedIndex = -1
        brkn.Visible = False
        idad.Visible = False
    End Sub

    Private Sub addcate_Click(sender As Object, e As EventArgs) Handles addcate.Click
        If nbka.Text = "" Then
            MsgBox("Greška. Unesite naziv nove kategorije!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "insert into BookCategory values ('" & nbka.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Kategorija knjige dodana u bazu!")
            kon.Close()
            nbka.Text = ""
            ispisi()
            ResetBO()
        End If
    End Sub
    Private Sub ispisi()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim cmd = New SqlCommand("select * from BookCategory", kon)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        KaK.DataSource = Tbl
        KaK.DisplayMember = "Vrsta"
        KaK.ValueMember = "Vrsta"
        brkn.DataSource = Tbl
        brkn.DisplayMember = "CateID"
        brkn.ValueMember = "CateID"
        kon.Close()

        Dim koni = New SqlConnection(Con)
        koni.Open()
        Dim cmds = New SqlCommand("select * from StaffTbl", koni)
        Dim adapters = New SqlDataAdapter(cmds)
        Dim Tbls = New DataTable()
        adapters.Fill(Tbls)
        adkl.DataSource = Tbls
        adkl.DisplayMember = "Zaposlenik"
        adkl.ValueMember = "Zaposlenik"
        idad.DataSource = Tbls
        idad.DisplayMember = "ID"
        idad.ValueMember = "ID"
        koni.Close()
    End Sub
    Private Sub resbo_Click(sender As Object, e As EventArgs) Handles resbo.Click
        ResetBO()
    End Sub
    Private Sub ResetBO()
        KIme.Text = ""
        AutK.Text = ""
        DIZ.Text = ""
        SBK.Text = ""
        nbka.Text = ""
        KaK.SelectedIndex = -1
        brkn.SelectedIndex = -1
        adkl.SelectedIndex = -1
        idad.SelectedIndex = -1
    End Sub
    Private Sub booklist()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim sql = "select * from BooksTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, kon)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BookDG.DataSource = ds.Tables(0)
        kon.Close()
    End Sub
    Dim key = 0
    Private Sub BookDG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BookDG.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = BookDG.Rows(e.RowIndex)
            KIme.Text = row.Cells(1).Value.ToString
            KaK.Text = row.Cells(2).Value.ToString
            AutK.Text = row.Cells(3).Value.ToString
            DIZ.Text = row.Cells(4).Value.ToString
            SBK.Text = row.Cells(5).Value.ToString
            brkn.Text = row.Cells(6).Value.ToString
            idad.Text = row.Cells(7).Value.ToString
            If KIme.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        End If
    End Sub

    Private Sub addbo_Click(sender As Object, e As EventArgs) Handles addbo.Click
        If KIme.Text = "" Or KaK.SelectedIndex = -1 Or idad.SelectedIndex = -1 Or AutK.Text = "" Or DIZ.Text = "" Or SBK.Text = "" Then
            MsgBox("Greška. Unesite potrebne podatke!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "select * from BooksTbl where Knjiga ='" & KIme.Text & "' And Autor ='" & AutK.Text & "'"
            Dim cmd = New SqlCommand(query, kon)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 1 Then
                MsgBox("Knjiga vec postoji sa tim nazivom i autorom!")
                ResetBO()
                booklist()
            Else
                Dim kone = New SqlConnection(Con)
                kone.Open()
                Dim queryy = "insert into BooksTbl values ('" & KIme.Text & "', '" & KaK.SelectedValue.ToString() & "', '" & AutK.Text & "','" & DIZ.Text & "','" & SBK.Text & "','" & brkn.SelectedValue.ToString() & "','" & idad.SelectedValue.ToString() & "')"
                Dim cmds As SqlCommand
                cmds = New SqlCommand(queryy, kone)
                cmds.ExecuteNonQuery()
                MsgBox("Knjiga dodana u bazu!")
                kone.Close()
                ResetBO()
                booklist()
            End If
            kon.Close()
        End If
    End Sub
    Private Sub editbo_Click(sender As Object, e As EventArgs) Handles editbo.Click
        If KIme.Text = "" Or KaK.SelectedIndex = -1 Or idad.SelectedIndex = -1 Or AutK.Text = "" Or DIZ.Text = "" Or SBK.Text = "" Or key = 0 Then
            MsgBox("Greška. Odaberite knjigu!")
        Else
            Try
                Dim kon = New SqlConnection(Con)
                kon.Open()
                Dim query = "update BooksTbl set Knjiga='" & KIme.Text & "', Kategorija='" & KaK.SelectedValue.ToString() & "', Autor='" & AutK.Text & "', Izdanje='" & DIZ.Text & "',SerijaKnjige='" & SBK.Text & "',CateID='" & brkn.SelectedValue.ToString() & "',ID='" & idad.SelectedValue.ToString() & "' where BookID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()
                MsgBox("Promjena uspješna!")
                kon.Close()
                ResetBO()
                booklist()
                key = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub delbo_Click(sender As Object, e As EventArgs) Handles delbo.Click
        If key = 0 Then
            MsgBox("Greška. Odaberite knjigu!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "delete from BooksTbl where BookID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Knjiga izbrisana iz baze!")
            kon.Close()
            ResetBO()
            booklist()
            key = 0
        End If
    End Sub
End Class