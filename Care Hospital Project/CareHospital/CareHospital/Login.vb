Imports System.Data.OleDb

Public Class Login
    Dim con As New OleDbConnection
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb"
    End Sub
    Public Function ask()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from Admin", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If UsernameTextBox.Text = datarow.item(1) And PasswordTextBox.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adminName As String = UsernameTextBox.Text
        If ask() = True Then
            MessageBox.Show("Welcome," & adminName & "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.None)
            Main_Form.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

        IntroForm.Show()

    End Sub
    Public Function find()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from PatientLoginDetails", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If txtUsername.Text = datarow.item(1) And txtPassword.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim patientName As String = txtUsername.Text
        If find() = True Then
            MessageBox.Show("Welcome," & patientName & "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.None)
            BookAppointment.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()

        IntroForm.Show()

    End Sub
    Public Function Recieve()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from tblDoctor", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If TextBox1.Text = datarow.item(1) And TextBox2.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim doctorname As String = TextBox1.Text
        If Recieve() = True Then
            MessageBox.Show("Welcome," & doctorname & "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.None)
            DoctorFormView.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        IntroForm.Show()


    End Sub
End Class