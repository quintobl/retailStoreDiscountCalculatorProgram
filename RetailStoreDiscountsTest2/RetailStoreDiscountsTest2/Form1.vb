' ***************************************************************************************************
' 
' Brad Quinton
' July 8, 2020
' Test 2 Practical/Retail Store Discount - This program will calculate discounts for employees
' purchasing items at the retail location.  Discounts are based on number of years worked, as well
' as if the employee is in management or is an hourly employee.  Once the employee reaches $200 in
' discounts for the year, he/she is no longer allowed any more discounts, i.e., $200 is the max.
'
' ****************************************************************************************************

Public Class Form1

    ' These are class variables created to contain running totals for the day's employee purchases pre and post discount.
    Dim dblRunningTotalPreDiscount As Double
    Dim dblRunningTotalPostDiscount As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This button closes the program.
        Close()

    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click

        ' Clears out text box controls when "Next Employee" button is clicked.
        txtName.Clear()
        txtYears.Clear()
        txtYearToDatePurchases.Clear()
        txtTodayPurchases.Clear()

        ' This button clears all the output labels except the ones labeled "Running Total
        ' For All Employees Pre-Discount" and "Running Total For All Employees With Discount."
        lblOutputName.ResetText()
        lblOutputDiscountPercentage.ResetText()
        lblOutputYTDDiscount.ResetText()
        lblOutputTodayPurchase.ResetText()
        lblOutputDiscountTodayPurchase.ResetText()
        lblOutputTodayTotalWithDiscount.ResetText()

        ' This button sets the "Hourly" radio button back to checked.
        radHourly.Checked = True

        ' Sets focus into the first text box (i.e., the one for the Employee Name) when "Next Employee" 
        ' button is clicked.
        txtName.Focus()

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click

        ' Sets running total back to 0 (does this for each running total output label) when the Clear All button is clicked.
        dblRunningTotalPreDiscount = 0
        dblRunningTotalPostDiscount = 0

        ' Clears out text box controls when "Clear All" button is clicked.
        txtName.Clear()
        txtYears.Clear()
        txtYearToDatePurchases.Clear()
        txtTodayPurchases.Clear()

        ' This button clears all the output labels.
        lblOutputName.ResetText()
        lblOutputDiscountPercentage.ResetText()
        lblOutputYTDDiscount.ResetText()
        lblOutputTodayPurchase.ResetText()
        lblOutputDiscountTodayPurchase.ResetText()
        lblOutputTodayTotalWithDiscount.ResetText()
        lblOutputRunningTotalPreDiscount.ResetText()
        lblOutputRunningTotalPostDiscount.ResetText()

        ' This button sets the "Hourly" radio button back to checked.
        radHourly.Checked = True

        ' Sets focus into the first text box (i.e., the one for the Employee Name) when "Clear All" 
        ' button is clicked.
        txtName.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' These are constants for the discount rates for hourly employees.
        Const dblHourlyYearsOneToThree As Double = 0.1
        Const dblHourlyYearsFourToSix As Double = 0.14
        Const dblHourlyYearsSevenToTen As Double = 0.2
        Const dblHourlyYearsElevenToFifteen As Double = 0.25
        Const dblHourlyYearsAfterFifteen As Double = 0.3




        ' These are constants for the discount rates for employees in management.
        Const dblMgmtYearsOneToThree As Double = 0.2
        Const dblMgmtYearsFourToSix As Double = 0.24
        Const dblMgmtYearsSevenToTen As Double = 0.3
        Const dblMgmtYearsElevenToFifteen As Double = 0.35
        Const dblMgmtYearsAfterFifteen As Double = 0.4




        ' This is the constant for the maximum discount of $200.00.
        Const intMaxDiscount As Integer = 200




        ' This creates local variables that will be used to store integer, double, and string values.
        Dim strName As String
        Dim intYears As Integer
        Dim dblPercent As Double
        Dim dblPreviousPurchases As Double
        Dim dblTodayPurchases As Double
        Dim dblYtdDiscountAmt As Double
        Dim dblYtdDiscountAmtForOutput As Double
        Dim dblTodayDiscountAmt As Double
        Dim dblTodayDiscountAmtForOutput As Double
        Dim dblTotalWithDiscount As Double




        ' This changes the textbox to white backcolor in case it is yellow.  It will become
        ' yellow when the user enters something into the textbox that is not validated.  It will 
        ' also become yellow if the user doesn't enter anything into the textbox.
        txtName.BackColor = Color.White
        txtYears.BackColor = Color.White
        txtYearToDatePurchases.BackColor = Color.White
        txtTodayPurchases.BackColor = Color.White




        ' This validates whether a string is entered into the first text box (i.e., the text box for
        ' the employee name).  The data type is string.  If something other than a string is entered, or if
        ' nothing is entered, a message box will pop up asking the user to enter a name.
        If txtName.Text = String.Empty Then
            MessageBox.Show("Please enter employee name.") ' Error message box pops up.
            txtName.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtName.Focus() ' This puts the focus in the textbox with the error preserved.
            Exit Sub ' Exit sub since there is an issue that needs to be addressed.
        ElseIf IsNumeric(txtName.Text) Then
            MessageBox.Show("Please enter employee name.") ' Error message box pops up.
            txtName.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtName.Focus() ' This puts the focus in the textbox with the error preserved.
            Exit Sub ' Exit sub since there is an issue that needs to be addressed.
        Else
            strName = txtName.Text ' This puts the string into the text box.
        End If




        ' This validates whether a number is entered into the second text box (i.e., the text box for
        ' the years employed).  The data type is integer.  If something other than an integer is entered, or if
        ' nothing is entered, a message box will pop up asking the user to enter a value.
        If IsNumeric(txtYears.Text) Then
            intYears = txtYears.Text
        Else
            MessageBox.Show("Please enter numbers only for years employed.") ' Error message box pops up.
            txtYears.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtYears.Focus() ' This puts the focus in the textbox with the error preserved.
            Exit Sub ' Exit sub since there is an issue that needs to be addressed.
        End If




        ' This validates whether a number is entered into the third text box (i.e., the text box for
        ' the previous purchases total).  The data type is double.  If something other than a double 
        ' is entered, or if nothing is entered, a message box will pop up asking the user to enter a value.
        If IsNumeric(txtYearToDatePurchases.Text) Then
            dblPreviousPurchases = txtYearToDatePurchases.Text
        Else
            MessageBox.Show("Please enter numbers only for previous purchases.") ' Error message box pops up.
            txtYearToDatePurchases.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtYearToDatePurchases.Focus() ' This puts the focus in the textbox with the error preserved.
            Exit Sub ' Exit sub since there is an issue that needs to be addressed.
        End If




        ' This validates whether a number is entered into the fourth text box (i.e., the text box for
        ' the today's purchase total).  The data type is double.  If something other than a double 
        ' is entered, or if nothing is entered, a message box will pop up asking the user to enter a value.
        If IsNumeric(txtTodayPurchases.Text) Then
            dblTodayPurchases = txtTodayPurchases.Text
        Else
            MessageBox.Show("Please enter numbers only for today's purchases.") ' Error message box pops up.
            txtTodayPurchases.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtTodayPurchases.Focus() ' This puts the focus in the textbox with the error preserved.
            Exit Sub ' Exit sub since there is an issue that needs to be addressed.
        End If




        ' This first if statement will pop an error message if the number of years employed that are 
        ' entered are either zero or negative.
        If intYears <= 0 Then
            MessageBox.Show("Please enter positive numbers only for years employed.") ' Error message box pops up.
            txtYears.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtYears.Focus() ' This puts the focus in the textbox with the error preserved.
            Exit Sub ' Exit sub since there is an issue that needs to be addressed.




            ' This ElseIf statement calculates today's discount for an employee (hourly and management) that
            ' has worked at the retail store for between 1 and 3 years.
        ElseIf intYears <= 3 Then
            If radHourly.Checked = True Then ' Checks if the hourly button is checked.
                dblPercent = dblHourlyYearsOneToThree ' Puts lengthy-named hourly rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            Else ' Checks if the management button is checked.
                dblPercent = dblMgmtYearsOneToThree ' Puts lengthy-named management rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            End If


            ' This ElseIf statement calculates today's discount for an employee (hourly and management) that
            ' has worked at the retail store for between 4 and 6 years.
        ElseIf intYears <= 6 Then
            If radHourly.Checked = True Then ' Checks if the hourly button is checked.
                dblPercent = dblHourlyYearsFourToSix ' Puts lengthy-named hourly rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            Else ' Checks if the management button is checked.
                dblPercent = dblMgmtYearsFourToSix ' Puts lengthy-named management rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            End If


            ' This ElseIf statement calculates today's discount for an employee (hourly and management) that
            ' has worked at the retail store for between 7 and 10 years.
        ElseIf intYears <= 10 Then
            If radHourly.Checked = True Then ' Checks if the hourly button is checked.
                dblPercent = dblHourlyYearsSevenToTen ' Puts lengthy-named hourly rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            Else ' Checks if the management button is checked.
                dblPercent = dblMgmtYearsSevenToTen ' Puts lengthy-named management rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            End If


            ' This ElseIf statement calculates today's discount for an employee (hourly and management) that
            ' has worked at the retail store for between 11 and 15 years.
        ElseIf intYears <= 15 Then
            If radHourly.Checked = True Then ' Checks if the hourly button is checked.
                dblPercent = dblHourlyYearsElevenToFifteen ' Puts lengthy-named hourly rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            Else ' Checks if the management button is checked.
                dblPercent = dblMgmtYearsElevenToFifteen ' Puts lengthy-named management rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            End If


            ' This ElseIf statement calculates today's discount for an employee (hourly and management) that
            ' has worked at the retail store for over 15 years.
        Else
            If radHourly.Checked = True Then ' Checks if the hourly button is checked.
                dblPercent = dblHourlyYearsAfterFifteen ' Puts lengthy-named hourly rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            Else ' Checks if the management button is checked.
                dblPercent = dblMgmtYearsAfterFifteen ' Puts lengthy-named management rate into simply-named variable.
                dblYtdDiscountAmt = dblPreviousPurchases * dblPercent ' Calculates YTD discount amount.
                dblTodayDiscountAmt = dblTodayPurchases * dblPercent ' Calculates today's discount amount.
                If dblYtdDiscountAmt + dblTodayDiscountAmt <= intMaxDiscount Then ' Checks if YTD discount plus today's discount is less than/equal to $200.00 max discount.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, then YTD discount amount will be put into the YTD discount amount output variable so that it can be displayed on the form.
                    dblTodayDiscountAmtForOutput = dblTodayDiscountAmt ' If the above is true, then today's discount amount will be put into the today discount amount output variable so it can be displayed on the form.
                    dblTotalWithDiscount = dblTodayPurchases - dblTodayDiscountAmt ' This calculates today's total cost of goods less today's discount.
                ElseIf dblYtdDiscountAmt > intMaxDiscount Then ' Checks if the YTD discount has exceeded the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = intMaxDiscount ' If the above is true, then the $200.00 maximum will be placed into the YTD discount amount output variable for display on the form.
                    dblTodayDiscountAmtForOutput = 0 ' If the above is true, then the form will display $0.00 for today's discount.
                    dblTotalWithDiscount = dblTodayPurchases ' If the above is true, then the total purchases for today will display on the form, since there is no discount for the day.
                ElseIf dblYtdDiscountAmt <= intMaxDiscount Then ' This checks if the YTD discount amount is less than/equal to the maximum $200.00 discount.  This part of the ElseIf statement assumes that today's purchase amount would put the employee over the $200.00 maximum.
                    dblYtdDiscountAmtForOutput = dblYtdDiscountAmt ' If the above is true, this part of the ElseIf statement displays the YTD discount amount on the form.
                    dblTodayDiscountAmtForOutput = intMaxDiscount - dblYtdDiscountAmt ' If the above is true, this subtracts the YTD discount amount from the max of $200.00 because that amount is what is leftover from the YTD amount to get to $200.00.
                    dblTotalWithDiscount = dblTodayPurchases - (intMaxDiscount - dblYtdDiscountAmt) ' If the above is true, this calculates today's purchase total less the difference of the max discount and the YTD discount.
                End If
            End If
        End If




        ' This calculates running totals for employee purchases pre-discount and post-discount.  Every time the user enters 
        ' values in the "Today's Purchase Total" textbox, those values add to each other for a running total for the day. 
        dblRunningTotalPreDiscount += dblTodayPurchases
        dblRunningTotalPostDiscount += dblTotalWithDiscount



        ' This displays the values in the following textboxes in currency format when the Calculate button is clicked.
        txtYearToDatePurchases.Text = FormatCurrency(txtYearToDatePurchases.Text)
        txtTodayPurchases.Text = FormatCurrency(txtTodayPurchases.Text)




        ' The following displays each calculated output above into all the output labels, except the labels
        ' entitled "Running Total For All Employees Pre-Discount" and "Running Total For All Employees With 
        ' Discount."  The output is formatted as currency, except the employee's name and the employee's
        ' discount percentage (which is formatted as a percent).
        lblOutputName.Text = strName
        lblOutputDiscountPercentage.Text = FormatPercent(dblPercent)
        lblOutputYTDDiscount.Text = FormatCurrency(dblYtdDiscountAmtForOutput)
        lblOutputTodayPurchase.Text = FormatCurrency(dblTodayPurchases)
        lblOutputDiscountTodayPurchase.Text = FormatCurrency(dblTodayDiscountAmtForOutput)
        lblOutputTodayTotalWithDiscount.Text = FormatCurrency(dblTotalWithDiscount)

    End Sub

    Private Sub btnDiscountSummary_Click(sender As Object, e As EventArgs) Handles btnDiscountSummary.Click

        ' This displays on the form the running totals (of today's employee purchases, pre and post discount) when
        ' the Discount Summary button is clicked.  The output is in currency format.
        lblOutputRunningTotalPreDiscount.Text = FormatCurrency(dblRunningTotalPreDiscount)
        lblOutputRunningTotalPostDiscount.Text = FormatCurrency(dblRunningTotalPostDiscount)

    End Sub
End Class
