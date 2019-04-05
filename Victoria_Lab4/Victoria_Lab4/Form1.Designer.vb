<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvwInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(44, 9)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(46, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(44, 39)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "Model:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(44, 70)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 17)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(44, 100)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price:"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(44, 133)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(39, 17)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New:"
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Cheverolet", "Crysler", "Toyota", "Nissan", "Mercedes"})
        Me.cmbMake.Location = New System.Drawing.Point(96, 9)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 24)
        Me.cmbMake.TabIndex = 1
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(96, 40)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(96, 100)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 4
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbYear.Location = New System.Drawing.Point(96, 70)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 24)
        Me.cmbYear.TabIndex = 3
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(96, 133)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(30, 21)
        Me.chkNew.TabIndex = 5
        Me.chkNew.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(230, 478)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 7
        Me.btnEnter.Text = "Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(311, 478)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(392, 478)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvwInventory
        '
        Me.lvwInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwInventory.FullRowSelect = True
        Me.lvwInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwInventory.Location = New System.Drawing.Point(47, 160)
        Me.lvwInventory.MultiSelect = False
        Me.lvwInventory.Name = "lvwInventory"
        Me.lvwInventory.Size = New System.Drawing.Size(398, 195)
        Me.lvwInventory.TabIndex = 6
        Me.lvwInventory.UseCompatibleStateImageBehavior = False
        Me.lvwInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(47, 358)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(398, 106)
        Me.lblOutput.TabIndex = 14
        '
        'frmInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(486, 513)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lvwInventory)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lvwInventory As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblOutput As Label
End Class
