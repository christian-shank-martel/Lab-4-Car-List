<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarListing
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
        Me.ttpCarForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvwCarList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.updYear = New System.Windows.Forms.NumericUpDown()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cobManufacturers = New System.Windows.Forms.ComboBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        CType(Me.updYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(159, 420)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.ttpCarForm.SetToolTip(Me.btnReset, "Clear the list.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(21, 420)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarForm.SetToolTip(Me.btnEnter, "add vehicle to the list")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(147, 91)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 7
        Me.ttpCarForm.SetToolTip(Me.txtPrice, "enter the Price of the vehicle")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(297, 420)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.ttpCarForm.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvwCarList
        '
        Me.lvwCarList.CheckBoxes = True
        Me.lvwCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCarList.FullRowSelect = True
        Me.lvwCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarList.HideSelection = False
        Me.lvwCarList.Location = New System.Drawing.Point(20, 156)
        Me.lvwCarList.MultiSelect = False
        Me.lvwCarList.Name = "lvwCarList"
        Me.lvwCarList.Size = New System.Drawing.Size(352, 186)
        Me.lvwCarList.TabIndex = 9
        Me.ttpCarForm.SetToolTip(Me.lvwCarList, "list of all entered cars, Click to edit one")
        Me.lvwCarList.UseCompatibleStateImageBehavior = False
        Me.lvwCarList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 48
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 41
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 57
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 57
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 49
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 96
        '
        'updYear
        '
        Me.updYear.Location = New System.Drawing.Point(147, 65)
        Me.updYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.updYear.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.updYear.Name = "updYear"
        Me.updYear.Size = New System.Drawing.Size(120, 20)
        Me.updYear.TabIndex = 5
        Me.ttpCarForm.SetToolTip(Me.updYear, "enter the year of the vehicle")
        Me.updYear.Value = New Decimal(New Integer() {1970, 0, 0, 0})
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(147, 39)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 3
        Me.ttpCarForm.SetToolTip(Me.txtModel, "Enter the model of the vehicle")
        '
        'cobManufacturers
        '
        Me.cobManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobManufacturers.FormattingEnabled = True
        Me.cobManufacturers.Items.AddRange(New Object() {"Ford", "General Motors", "Honda", "Hyundai", "Kia", "Nissan", "Subaru", "Suzuki", "Toyota", "Voltz Waggon"})
        Me.cobManufacturers.Location = New System.Drawing.Point(147, 12)
        Me.cobManufacturers.Name = "cobManufacturers"
        Me.cobManufacturers.Size = New System.Drawing.Size(121, 21)
        Me.cobManufacturers.Sorted = True
        Me.cobManufacturers.TabIndex = 1
        Me.ttpCarForm.SetToolTip(Me.cobManufacturers, "Select the make of the vehicle")
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.BackColor = System.Drawing.SystemColors.Control
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(99, 116)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(48, 17)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New"
        Me.ttpCarForm.SetToolTip(Me.chkNew, "is the vehicle new")
        Me.chkNew.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(21, 345)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(351, 65)
        Me.lblError.TabIndex = 10
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(99, 93)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(99, 66)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(83, 39)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(52, 20)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(89, 12)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(44, 15)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCarListing
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(387, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lvwCarList)
        Me.Controls.Add(Me.updYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cobManufacturers)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Listing"
        CType(Me.updYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ttpCarForm As ToolTip
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lvwCarList As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents updYear As NumericUpDown
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cobManufacturers As ComboBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
End Class
