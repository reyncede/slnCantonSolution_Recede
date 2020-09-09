Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intYear As Integer = 3 To 20
            lstUsefulLife.Items.Add(intYear.ToString)
        Next
        lstUsefulLife.SelectedIndex = 0
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Clear the contents of the list
        lstDoubleDeclining.Items.Clear()
        lstSumOfYears.Items.Clear()

        'Declaring the values
        Dim dblAssetCost As Double
        Dim dblSalvageValue As Double
        Dim intUsefulLife As Integer

        Double.TryParse(txtSalvageValue.Text, dblSalvageValue)
        Double.TryParse(txtAssetCost.Text, dblAssetCost)
        Integer.TryParse(lstUsefulLife.SelectedItem.ToString, intUsefulLife)

        'Adding values to the list
        lstDoubleDeclining.Items.Add("Year" & vbTab & "Depreciation")
        lstSumOfYears.Items.Add("Year" & vbTab & "Depreciation")
        For intYear As Integer = 1 To intUsefulLife
            lstDoubleDeclining.Items.Add(intYear & vbTab &
                    Financial.DDB(dblAssetCost, dblSalvageValue, intUsefulLife, intYear).ToString("N2"))
            lstSumOfYears.Items.Add(intYear & vbTab &
                    Financial.SYD(dblAssetCost, dblSalvageValue, intUsefulLife, intYear).ToString("N2"))
        Next intYear
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtKeyPresses(sender As Object, e As KeyPressEventArgs) Handles txtAssetCost.KeyPress, txtSalvageValue.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub valuesChanged(sender As Object, e As EventArgs) Handles txtAssetCost.TextChanged, txtSalvageValue.TextChanged, lstUsefulLife.SelectedIndexChanged
        lstDoubleDeclining.Items.Clear()
        lstSumOfYears.Items.Clear()
    End Sub

    Private Sub txtAssetCost_Enter(sender As Object, e As EventArgs) Handles txtAssetCost.Enter
        txtAssetCost.SelectAll()
    End Sub

    Private Sub txtSalvageValue_Enter(sender As Object, e As EventArgs) Handles txtSalvageValue.Enter
        txtSalvageValue.SelectAll()
    End Sub
End Class
