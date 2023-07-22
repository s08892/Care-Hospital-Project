Imports System.Data.OleDb
Imports System.IO
Public Class BookAppointment
    Private connection As OleDbConnection
    Private adapter As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim result As Integer
    Dim sql As String
    Dim Myconnection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb"
   
    Private dataset As New DataSet()
    Public Function RequestData(ByVal patientID As List(Of Integer)) As DataSet
        Dim dataset As New DataSet()

        Using connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb")
            connection.Open()

            Dim query As String = "SELECT * FROM Patient WHERE Patient_ID IN ("

            ' Filter out non-positive patient IDs
            Dim filteredPatientIDs As List(Of Integer) = patientID.Where(Function(id) id > 0).ToList()

            For i As Integer = 0 To filteredPatientIDs.Count - 1
                query &= "@Patient_ID" & i.ToString()
                If i <> filteredPatientIDs.Count - 1 Then
                    query &= ", "
                End If
            Next

            query &= ")"

            Dim adapter As New OleDbDataAdapter(query, connection)

            For i As Integer = 0 To filteredPatientIDs.Count - 1
                adapter.SelectCommand.Parameters.AddWithValue("@Patient_ID " & i.ToString(), filteredPatientIDs(i))
            Next

            adapter.Fill(dataset, "Data")
        End Using

        Return dataset
    End Function


    Public Function GetData(ByVal doctorIDs As List(Of Integer)) As DataSet
        Dim dataset As New DataSet()

        Using connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Desktop\project\CareHospital\CareHospital\AppointmentBookingSystem1.mdb")
            connection.Open()

            Dim query As String = "SELECT * FROM ListOfDoctors WHERE Doctor_ID IN ("

            For i As Integer = 0 To doctorIDs.Count - 1
                query &= "@Doctor_ID" & i.ToString()
                If i <> doctorIDs.Count - 1 Then
                    query &= ", "
                End If
            Next

            query &= ")"

            Dim adapter As New OleDbDataAdapter(query, connection)

            For i As Integer = 0 To doctorIDs.Count - 1
                adapter.SelectCommand.Parameters.AddWithValue("@Doctor_ID" & i.ToString(), doctorIDs(i))
            Next

            adapter.Fill(dataset, "Data")
        End Using

        Return dataset
    End Function
    Private Sub bringData(ByVal patientID As Integer)
        Try
            connection = New OleDbConnection(Myconnection)
            connection.Open()

            sql = "SELECT * FROM Patient WHERE Patient_ID = @Patient_ID"
            cmd.CommandText = sql
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@Patient_ID", patientID)
            adapter = New OleDbDataAdapter(cmd)
            dataset.Clear()

            ' Give each DataTable a meaningful name corresponding to the data it represents
            adapter.Fill(dataset, "Patient")

            If dataset.Tables("Patient").Rows.Count > 0 Then
                Dim row As DataRow = dataset.Tables("Patient").Rows(0)

                First_NameTextBox.Text = row("First_Name").ToString()
                Last_NameTextBox.Text = row("Last_Name").ToString()
                AgeTextBox.Text = row("Age").ToString()
                Cellphone_NoTextBox.Text = row("Cellphone_No").ToString()
                Telephone_NoTextBox.Text = row("Telephone_No").ToString()
                Street_AddressTextBox.Text = row("Street_address").ToString()
                City_TownTextBox.Text = row("City/Town").ToString()
                ' Assign other textbox values based on the respective columns

                ' You can also assign values to other controls, such as ComboBoxes or DatePickers, if needed
                ' Example: ComboBoxGender.SelectedItem = row("Gender").ToString()
            Else
                ' Clear the textboxes if no matching data found
                Doctor_NameTextBox.Text = ""
                Doctor_NoTextBox.Text = ""
                ColorTextBox.Text = ""
                Fee_HourTextBox.Text = ""
                ' Clear other textboxes
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadData(ByVal doctorID As Integer)
        Try
            connection = New OleDbConnection(Myconnection)
            connection.Open()

            sql = "SELECT * FROM ListOfDoctors WHERE Doctor_ID = @Doctor_ID"
            cmd.CommandText = sql
            cmd.Connection = connection
            cmd.Parameters.AddWithValue("@Doctor_ID", doctorID)
            adapter = New OleDbDataAdapter(cmd)
            dataset.Clear()

            ' Give each DataTable a meaningful name corresponding to the data it represents
            adapter.Fill(dataset, "ListOfDoctors")

            If dataset.Tables("ListOfDoctors").Rows.Count > 0 Then
                Dim row As DataRow = dataset.Tables("ListOfDoctors").Rows(0)

                Doctor_NameTextBox.Text = row("Doctor_Name").ToString()
                Doctor_NoTextBox.Text = row("Doctor_No").ToString()
                ColorTextBox.Text = row("Color").ToString()
                Fee_HourTextBox.Text = row("Fee/Hour").ToString()

                ' Assign other textbox values based on the respective columns

                ' You can also assign values to other controls, such as ComboBoxes or DatePickers, if needed
                ' Example: ComboBoxGender.SelectedItem = row("Gender").ToString()
            Else
                ' Clear the textboxes if no matching data found
                Doctor_NameTextBox.Text = ""
                Doctor_NoTextBox.Text = ""
                ColorTextBox.Text = ""
                Fee_HourTextBox.Text = ""
                ' Clear other textboxes
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

   
    Private Sub AppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub BookAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set textbox controls to empty values
        Appointment_IDTextBox.Clear()
        Patient_IDTextBox.Clear()
        Last_NameTextBox.Clear()
        AgeTextBox.Clear()
        Cellphone_NoTextBox.Clear()
        Telephone_NoTextBox.Clear()
        Street_AddressTextBox.Clear()
        City_TownTextBox.Clear()
        Doctor_IDTextBox.Clear()
        Doctor_NameTextBox.Clear()
        Doctor_NoTextBox.Clear()
        ColorTextBox.Clear()
        Fee_HourTextBox.Clear()
        No_of_HoursTextBox.Clear()
        Total_DueTextBox.Clear()




        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.Appointment_Details' table. You can move, or remove it, as needed.
        Me.Appointment_DetailsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.Appointment_Details)
        'TODO: This line of code loads data into the 'AppointmentBookingSystem1DataSet.ListOfDoctors' table. You can move, or remove it, as needed.
        Me.ListOfDoctorsTableAdapter.Fill(Me.AppointmentBookingSystem1DataSet.ListOfDoctors)
       

    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Login.Show()

            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub No_of_HoursTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Total_DueTextBox.Text = Val(No_of_HoursTextBox.Text) * Val(Fee_HourTextBox.Text)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            connection = New OleDbConnection(Myconnection)
            connection.Open()

            sql = "SELECT * FROM ListOfDoctors WHERE Doctor_ID LIKE '%" & TextBox1.Text & "%' OR Doctor_No LIKE '%" & TextBox1.Text & "%'"
            cmd.CommandText = sql
            cmd.Connection = connection
            adapter = New OleDbDataAdapter(cmd)
            Dim dbdt As New DataTable
            adapter.Fill(dbdt)
            ListOfDoctorsDataGridView.DataSource = dbdt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
   
    Private Sub Doctor_IDTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Doctor_IDTextBox.TextChanged
        Dim doctorID As Integer

        If Integer.TryParse(Doctor_IDTextBox.Text, doctorID) Then
            LoadData(doctorID)
        Else
            ' Clear the textboxes if the input is not a valid integer
            Doctor_NameTextBox.Text = ""
            Doctor_NoTextBox.Text = ""
            ColorTextBox.Text = ""
            Fee_HourTextBox.Text = ""
            ' Clear other textboxes
        End If
    End Sub

    Private Sub Patient_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient_IDTextBox.TextChanged
        Dim patientID As Integer

        If Integer.TryParse(Patient_IDTextBox.Text, patientID) Then
            bringData(patientID)
        Else
            ' Clear the textboxes if the input is not a valid integer
            First_NameTextBox.Clear()
            Last_NameTextBox.Clear()
            AgeTextBox.Clear()
            Cellphone_NoTextBox.Clear()
            Telephone_NoTextBox.Clear()
            Street_AddressTextBox.Clear()
            City_TownTextBox.Clear()


        End If
    End Sub

    Private Sub Total_DueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total_DueTextBox.TextChanged

    End Sub

    Private Sub DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.ValueChanged
        Dim days As Integer = (DateDateTimePicker.Value - DateTime.Today).Days
        If days < 0 Then
            days = 0
        End If
        Dim hours As Integer = days * 24
        No_of_HoursTextBox.Text = hours.ToString()

    End Sub

    Private Sub No_of_HoursTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_of_HoursTextBox.TextChanged
        Total_DueTextBox.Text = Val(No_of_HoursTextBox.Text) * Val(Fee_HourTextBox.Text)
    End Sub
End Class