Imports System.Data.SqlClient
Imports System.Configuration
Public Class adminPage
    Dim Con = System.Configuration.ConfigurationManager.ConnectionStrings("LCS").ConnectionString
    Private Sub adminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stafflist()
        pozz.Visible = False
        FillCategory()
        zpoz.SelectedIndex = -1
    End Sub
    Private Sub ResetS()
        RIme.Text = ""
        RSpol.SelectedIndex = -1
        RLoz.Text = ""
        RPla.Text = ""
        npoz.Text = ""
        zpoz.SelectedIndex = -1
    End Sub
    Private Sub stafflist()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim sql = "select * from StaffTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, kon)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StaffDG.DataSource = ds.Tables(0)
        kon.Close()
    End Sub
    Dim key = 0
    Private Sub StaffDG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StaffDG.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = StaffDG.Rows(e.RowIndex)
            RIme.Text = row.Cells(1).Value.ToString
            RSpol.SelectedItem = row.Cells(2).Value.ToString
            RLoz.Text = row.Cells(3).Value.ToString
            RPla.Text = row.Cells(4).Value.ToString
            zpoz.Text = row.Cells(5).Value.ToString
            If RIme.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        End If
    End Sub
    Private Sub addz_Click(sender As Object, e As EventArgs) Handles addz.Click
        If RIme.Text = "" Or RSpol.SelectedIndex = -1 Or zpoz.SelectedIndex = -1 Or RLoz.Text = "" Or RPla.Text = "" Then
            MsgBox("Greška. Unesite potrebne podatke!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "select * from StaffTbl where Zaposlenik ='" & RIme.Text & "' And Lozinka ='" & RLoz.Text & "'"
            Dim cmd = New SqlCommand(query, kon)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 1 Then
                MsgBox("Taj zaposlenik vec postoji,pokušajte ponovo!")
                ResetS()
                stafflist()
            Else
                Dim kone = New SqlConnection(Con)
                kone.Open()
                Dim queryy = "insert into StaffTbl values ('" & RIme.Text & "', '" & RSpol.SelectedItem.ToString() & "', '" & RLoz.Text & "', '" & RPla.Text & "','" & zpoz.SelectedValue.ToString() & "','" & pozz.SelectedValue.ToString() & "')"
                Dim cmds As SqlCommand
                cmds = New SqlCommand(queryy, kone)
                cmds.ExecuteNonQuery()
                MsgBox("Zaposlenik dodan u bazu!")
                kone.Close()
                ResetS()
                stafflist()
            End If
            kon.Close()
        End If
    End Sub
    Private Sub editz_Click(sender As Object, e As EventArgs) Handles editz.Click
        If RIme.Text = "" Or RSpol.SelectedIndex = -1 Or zpoz.SelectedIndex = -1 Or RLoz.Text = "" Or RPla.Text = "" Or key = 0 Then
            MsgBox("Greška. Odaberite zaposlenika!")
        Else
            Try
                Dim kon = New SqlConnection(Con)
                kon.Open()
                Dim query = "update StaffTbl set Zaposlenik='" & RIme.Text & "', Spol='" & RSpol.SelectedItem.ToString() & "', Lozinka='" & RLoz.Text & "', Plata='" & RPla.Text & "',Uloga='" & zpoz.SelectedValue.ToString() & "',PosID='" & pozz.SelectedValue.ToString() & "' where ID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()
                MsgBox("Promjena uspješna!")
                kon.Close()
                ResetS()
                stafflist()
                key = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub delz_Click(sender As Object, e As EventArgs) Handles delz.Click
        If key = 0 Then
            MsgBox("Greška. Odaberite zaposlenika!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "delete from StaffTbl where ID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Zaposlenik izbrisan iz baze!")
            kon.Close()
            ResetS()
            stafflist()
            key = 0
        End If
    End Sub
    Private Sub zres_Click(sender As Object, e As EventArgs) Handles zres.Click
        ResetS()
    End Sub
    Private Sub zlogou_Click(sender As Object, e As EventArgs) Handles zlogou.Click
        Dim pocetnas = New loginForma
        pocetnas.Show()
        Me.Hide()
    End Sub

    Private Sub addpos_Click(sender As Object, e As EventArgs) Handles addpos.Click
        If npoz.Text = "" Then
            MsgBox("Greška. Unesite naziv nove pozicije!")
        Else
            Dim kon = New SqlConnection(Con)
            kon.Open()
            Dim query = "insert into SRoles values ('" & npoz.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, kon)
            cmd.ExecuteNonQuery()
            MsgBox("Pozicija dodana u bazu!")
            kon.Close()
            npoz.Text = ""
            FillCategory()
            zpoz.SelectedIndex = -1
        End If
    End Sub
    Private Sub FillCategory()
        Dim kon = New SqlConnection(Con)
        kon.Open()
        Dim cmd = New SqlCommand("select * from SRoles", kon)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        zpoz.DataSource = Tbl
        zpoz.DisplayMember = "Pozicija"
        zpoz.ValueMember = "Pozicija"
        pozz.DataSource = Tbl
        pozz.DisplayMember = "PosID"
        pozz.ValueMember = "PosID"
        kon.Close()
    End Sub
End Class