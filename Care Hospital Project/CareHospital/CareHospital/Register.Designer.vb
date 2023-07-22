<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TblDoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentBookingSystem1DataSet = New CareHospital.AppointmentBookingSystem1DataSet()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientLoginDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.TblDoctorTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.tblDoctorTableAdapter()
        Me.TableAdapterManager = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager()
        Me.PatientLoginDetailsTableAdapter = New CareHospital.AppointmentBookingSystem1DataSetTableAdapters.PatientLoginDetailsTableAdapter()
        Me.TblDoctorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblDoctorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        UsernameLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TblDoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PatientLoginDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDoctorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblDoctorBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(30, 59)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(30, 121)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(87, 20)
        UsernameLabel.TabIndex = 2
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(30, 189)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(82, 20)
        PasswordLabel.TabIndex = 4
        PasswordLabel.Text = "Password:"
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Location = New System.Drawing.Point(44, 28)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.Size = New System.Drawing.Size(68, 20)
        User_IDLabel.TabIndex = 0
        User_IDLabel.Text = "User ID:"
        '
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.Location = New System.Drawing.Point(44, 100)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(87, 20)
        UsernameLabel1.TabIndex = 2
        UsernameLabel1.Text = "Username:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(44, 172)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(82, 20)
        PasswordLabel1.TabIndex = 4
        PasswordLabel1.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(213, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 88)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(481, 372)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(IDLabel)
        Me.TabPage1.Controls.Add(Me.IDTextBox)
        Me.TabPage1.Controls.Add(UsernameLabel)
        Me.TabPage1.Controls.Add(Me.UsernameTextBox)
        Me.TabPage1.Controls.Add(PasswordLabel)
        Me.TabPage1.Controls.Add(Me.PasswordTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(473, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DOCTOR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(359, 274)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 33)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(183, 274)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 33)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "REGISTER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(34, 274)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 33)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "NEW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDoctorBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(34, 82)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(400, 26)
        Me.IDTextBox.TabIndex = 1
        '
        'TblDoctorBindingSource
        '
        Me.TblDoctorBindingSource.DataMember = "tblDoctor"
        Me.TblDoctorBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'AppointmentBookingSystem1DataSet
        '
        Me.AppointmentBookingSystem1DataSet.DataSetName = "AppointmentBookingSystem1DataSet"
        Me.AppointmentBookingSystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDoctorBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(34, 144)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(400, 26)
        Me.UsernameTextBox.TabIndex = 3
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDoctorBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(34, 222)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(400, 26)
        Me.PasswordTextBox.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(User_IDLabel)
        Me.TabPage2.Controls.Add(Me.User_IDTextBox)
        Me.TabPage2.Controls.Add(UsernameLabel1)
        Me.TabPage2.Controls.Add(Me.UsernameTextBox1)
        Me.TabPage2.Controls.Add(PasswordLabel1)
        Me.TabPage2.Controls.Add(Me.PasswordTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(473, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PATIENT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(373, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 33)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "REGISTER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientLoginDetailsBindingSource, "User_ID", True))
        Me.User_IDTextBox.Location = New System.Drawing.Point(48, 51)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.Size = New System.Drawing.Size(400, 26)
        Me.User_IDTextBox.TabIndex = 1
        '
        'PatientLoginDetailsBindingSource
        '
        Me.PatientLoginDetailsBindingSource.DataMember = "PatientLoginDetails"
        Me.PatientLoginDetailsBindingSource.DataSource = Me.AppointmentBookingSystem1DataSet
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientLoginDetailsBindingSource, "Username", True))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(48, 123)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.Size = New System.Drawing.Size(400, 26)
        Me.UsernameTextBox1.TabIndex = 3
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientLoginDetailsBindingSource, "Password", True))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(48, 211)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox1.Size = New System.Drawing.Size(400, 26)
        Me.PasswordTextBox1.TabIndex = 5
        '
        'TblDoctorTableAdapter
        '
        Me.TblDoctorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.Appointment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishedTableAdapter = Nothing
        Me.TableAdapterManager.ListOfDoctorsTableAdapter = Nothing
        Me.TableAdapterManager.PatientLoginDetailsTableAdapter = Me.PatientLoginDetailsTableAdapter
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.tblDoctorTableAdapter = Me.TblDoctorTableAdapter
        Me.TableAdapterManager.UpdateOrder = CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientLoginDetailsTableAdapter
        '
        Me.PatientLoginDetailsTableAdapter.ClearBeforeFill = True
        '
        'TblDoctorBindingNavigator
        '
        Me.TblDoctorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblDoctorBindingNavigator.BindingSource = Me.TblDoctorBindingSource
        Me.TblDoctorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblDoctorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblDoctorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblDoctorBindingNavigatorSaveItem})
        Me.TblDoctorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblDoctorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblDoctorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblDoctorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblDoctorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblDoctorBindingNavigator.Name = "TblDoctorBindingNavigator"
        Me.TblDoctorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblDoctorBindingNavigator.Size = New System.Drawing.Size(508, 25)
        Me.TblDoctorBindingNavigator.TabIndex = 2
        Me.TblDoctorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblDoctorBindingNavigatorSaveItem
        '
        Me.TblDoctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblDoctorBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblDoctorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblDoctorBindingNavigatorSaveItem.Name = "TblDoctorBindingNavigatorSaveItem"
        Me.TblDoctorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblDoctorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 463)
        Me.Controls.Add(Me.TblDoctorBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TblDoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBookingSystem1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PatientLoginDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDoctorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblDoctorBindingNavigator.ResumeLayout(False)
        Me.TblDoctorBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AppointmentBookingSystem1DataSet As CareHospital.AppointmentBookingSystem1DataSet
    Friend WithEvents TblDoctorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDoctorTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.tblDoctorTableAdapter
    Friend WithEvents TableAdapterManager As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDoctorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblDoctorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientLoginDetailsTableAdapter As CareHospital.AppointmentBookingSystem1DataSetTableAdapters.PatientLoginDetailsTableAdapter
    Friend WithEvents PatientLoginDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents User_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
