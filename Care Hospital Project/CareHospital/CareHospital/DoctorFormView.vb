Imports System.Data.OleDb
Imports System.IO
Public Class DoctorFormView
    Private connection As OleDbConnection
    Private adapter As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim result As Integer
    Dim sql As String
    Dim Myconnection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb"

    Private dataset As New DataSet()
    Public Function GetData(ByVal doctorname As List(Of String)) As DataSet
        Dim dataset As New DataSet()

        Using connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb")
            connection.Open()

            Dim query As String = "SELECT * FROM Appointment WHERE Doctor_Name IN ("

            For i As Integer = 0 To doctorname.Count - 1
                query &= "@Doctor_Name" & i.ToString()
                If i <> doctorname.Count - 1 Then
                    query &= ", "
                End If
            Next

            query &= ")"

            Dim adapter As New OleDbDataAdapter(query, connection)

            For i As Integer = 0 To doctorname.Count - 1
                adapter.SelectCommand.Parameters.AddWithValue("@Doctor_Name" & i.ToString(), doctorname(i))
            Next

            adapter.Fill(dataset, "Data")
        End Using

        Return dataset
    End Function
    Private Sub AppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub DoctorFormView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
            Me.Validate()
            Me.AppointmentBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Return
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Login.Show()

            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            connection = New OleDbConnection(Myconnection)
            connection.Open()

            sql = "SELECT * FROM Appointment WHERE Doctor_ID LIKE '%" & TextBox1.Text & "%' OR Doctor_No LIKE '%" & TextBox1.Text & "%' OR Doctor_Name LIKE '%" & TextBox1.Text & "%'"
            cmd.CommandText = sql
            cmd.Connection = connection
            adapter = New OleDbDataAdapter(cmd)
            Dim dbdt As New DataTable
            adapter.Fill(dbdt)
            AppointmentDataGridView.DataSource = dbdt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class