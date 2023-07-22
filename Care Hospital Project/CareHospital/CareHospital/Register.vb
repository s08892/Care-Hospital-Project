Public Class Register

    Private Sub TblDoctorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblDoctorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblDoctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)

    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set textbox controls to empty values
        IDTextBox.Clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        ' Set textbox controls to empty values
        User_IDTextBox.Clear()
        UsernameTextBox1.Clear()
        PasswordTextBox1.Clear()



    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Validate()
        Me.TblDoctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Registration Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        IntroForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.PatientLoginDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AppointmentBookingSystem1DataSet)
        MessageBox.Show("Registration Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        IntroForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

        IntroForm.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

        IntroForm.Show()
    End Sub
End Class