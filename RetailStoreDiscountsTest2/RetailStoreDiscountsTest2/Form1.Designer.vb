<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYearToDatePurchases = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtTodayPurchases = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radManagement = New System.Windows.Forms.RadioButton()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblOutputName = New System.Windows.Forms.Label()
        Me.lblOutputDiscountPercentage = New System.Windows.Forms.Label()
        Me.lblOutputYTDDiscount = New System.Windows.Forms.Label()
        Me.lblOutputTodayPurchase = New System.Windows.Forms.Label()
        Me.lblOutputDiscountTodayPurchase = New System.Windows.Forms.Label()
        Me.lblOutputTodayTotalWithDiscount = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnDiscountSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblOutputRunningTotalPreDiscount = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblOutputRunningTotalPostDiscount = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(34, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(164, 22)
        Me.txtName.TabIndex = 0
        '
        'txtYearToDatePurchases
        '
        Me.txtYearToDatePurchases.Location = New System.Drawing.Point(258, 49)
        Me.txtYearToDatePurchases.Name = "txtYearToDatePurchases"
        Me.txtYearToDatePurchases.Size = New System.Drawing.Size(164, 22)
        Me.txtYearToDatePurchases.TabIndex = 2
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(34, 122)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(164, 22)
        Me.txtYears.TabIndex = 1
        '
        'txtTodayPurchases
        '
        Me.txtTodayPurchases.Location = New System.Drawing.Point(258, 122)
        Me.txtTodayPurchases.Name = "txtTodayPurchases"
        Me.txtTodayPurchases.Size = New System.Drawing.Size(165, 22)
        Me.txtTodayPurchases.TabIndex = 3
        Me.txtTodayPurchases.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radManagement)
        Me.GroupBox1.Controls.Add(Me.radHourly)
        Me.GroupBox1.Location = New System.Drawing.Point(495, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Status"
        '
        'radManagement
        '
        Me.radManagement.AutoSize = True
        Me.radManagement.Location = New System.Drawing.Point(43, 61)
        Me.radManagement.Name = "radManagement"
        Me.radManagement.Size = New System.Drawing.Size(111, 21)
        Me.radManagement.TabIndex = 1
        Me.radManagement.Text = "Management"
        Me.radManagement.UseVisualStyleBackColor = True
        '
        'radHourly
        '
        Me.radHourly.AutoSize = True
        Me.radHourly.Checked = True
        Me.radHourly.Location = New System.Drawing.Point(43, 22)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(70, 21)
        Me.radHourly.TabIndex = 1
        Me.radHourly.TabStop = True
        Me.radHourly.Text = "Hourly"
        Me.radHourly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Years Employed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Previous Purchases Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Today's Purchases Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Employee Discount Percentage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(634, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "YTD Amount of Discount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Today's Purchase Total Pre-Discount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(328, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Employee Discount With This Purchase"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(634, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Today's Total With Discount"
        '
        'lblOutputName
        '
        Me.lblOutputName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputName.Location = New System.Drawing.Point(31, 226)
        Me.lblOutputName.Name = "lblOutputName"
        Me.lblOutputName.Size = New System.Drawing.Size(250, 50)
        Me.lblOutputName.TabIndex = 15
        '
        'lblOutputDiscountPercentage
        '
        Me.lblOutputDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputDiscountPercentage.Location = New System.Drawing.Point(331, 226)
        Me.lblOutputDiscountPercentage.Name = "lblOutputDiscountPercentage"
        Me.lblOutputDiscountPercentage.Size = New System.Drawing.Size(250, 50)
        Me.lblOutputDiscountPercentage.TabIndex = 16
        '
        'lblOutputYTDDiscount
        '
        Me.lblOutputYTDDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputYTDDiscount.Location = New System.Drawing.Point(637, 226)
        Me.lblOutputYTDDiscount.Name = "lblOutputYTDDiscount"
        Me.lblOutputYTDDiscount.Size = New System.Drawing.Size(250, 50)
        Me.lblOutputYTDDiscount.TabIndex = 17
        '
        'lblOutputTodayPurchase
        '
        Me.lblOutputTodayPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTodayPurchase.Location = New System.Drawing.Point(28, 339)
        Me.lblOutputTodayPurchase.Name = "lblOutputTodayPurchase"
        Me.lblOutputTodayPurchase.Size = New System.Drawing.Size(250, 50)
        Me.lblOutputTodayPurchase.TabIndex = 18
        '
        'lblOutputDiscountTodayPurchase
        '
        Me.lblOutputDiscountTodayPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputDiscountTodayPurchase.Location = New System.Drawing.Point(331, 339)
        Me.lblOutputDiscountTodayPurchase.Name = "lblOutputDiscountTodayPurchase"
        Me.lblOutputDiscountTodayPurchase.Size = New System.Drawing.Size(250, 50)
        Me.lblOutputDiscountTodayPurchase.TabIndex = 19
        '
        'lblOutputTodayTotalWithDiscount
        '
        Me.lblOutputTodayTotalWithDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTodayTotalWithDiscount.Location = New System.Drawing.Point(637, 340)
        Me.lblOutputTodayTotalWithDiscount.Name = "lblOutputTodayTotalWithDiscount"
        Me.lblOutputTodayTotalWithDiscount.Size = New System.Drawing.Size(250, 50)
        Me.lblOutputTodayTotalWithDiscount.TabIndex = 20
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(25, 571)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 30)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(202, 571)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(150, 30)
        Me.btnNextEmployee.TabIndex = 6
        Me.btnNextEmployee.Text = "Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnDiscountSummary
        '
        Me.btnDiscountSummary.Location = New System.Drawing.Point(380, 571)
        Me.btnDiscountSummary.Name = "btnDiscountSummary"
        Me.btnDiscountSummary.Size = New System.Drawing.Size(150, 30)
        Me.btnDiscountSummary.TabIndex = 7
        Me.btnDiscountSummary.Text = "Discount Summary"
        Me.btnDiscountSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(732, 571)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(96, 434)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(300, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Running Total For All Employees Pre-Discount"
        '
        'lblOutputRunningTotalPreDiscount
        '
        Me.lblOutputRunningTotalPreDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputRunningTotalPreDiscount.Location = New System.Drawing.Point(99, 460)
        Me.lblOutputRunningTotalPreDiscount.Name = "lblOutputRunningTotalPreDiscount"
        Me.lblOutputRunningTotalPreDiscount.Size = New System.Drawing.Size(300, 50)
        Me.lblOutputRunningTotalPreDiscount.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(492, 434)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(305, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Running Total For All Employees With Discount"
        '
        'lblOutputRunningTotalPostDiscount
        '
        Me.lblOutputRunningTotalPostDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputRunningTotalPostDiscount.Location = New System.Drawing.Point(495, 460)
        Me.lblOutputRunningTotalPostDiscount.Name = "lblOutputRunningTotalPostDiscount"
        Me.lblOutputRunningTotalPostDiscount.Size = New System.Drawing.Size(300, 50)
        Me.lblOutputRunningTotalPostDiscount.TabIndex = 28
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(556, 571)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(150, 30)
        Me.btnClearAll.TabIndex = 8
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 653)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.lblOutputRunningTotalPostDiscount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblOutputRunningTotalPreDiscount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDiscountSummary)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutputTodayTotalWithDiscount)
        Me.Controls.Add(Me.lblOutputDiscountTodayPurchase)
        Me.Controls.Add(Me.lblOutputTodayPurchase)
        Me.Controls.Add(Me.lblOutputYTDDiscount)
        Me.Controls.Add(Me.lblOutputDiscountPercentage)
        Me.Controls.Add(Me.lblOutputName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTodayPurchases)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtYearToDatePurchases)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Retail Store Discounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYearToDatePurchases As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtTodayPurchases As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radManagement As RadioButton
    Friend WithEvents radHourly As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblOutputName As Label
    Friend WithEvents lblOutputDiscountPercentage As Label
    Friend WithEvents lblOutputYTDDiscount As Label
    Friend WithEvents lblOutputTodayPurchase As Label
    Friend WithEvents lblOutputDiscountTodayPurchase As Label
    Friend WithEvents lblOutputTodayTotalWithDiscount As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNextEmployee As Button
    Friend WithEvents btnDiscountSummary As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblOutputRunningTotalPreDiscount As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblOutputRunningTotalPostDiscount As Label
    Friend WithEvents btnClearAll As Button
End Class
