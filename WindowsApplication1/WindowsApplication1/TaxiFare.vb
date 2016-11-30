

Public Class TaxiFare
    Const cdecFareCost As Decimal = 2.25D


    Private Sub btnFee_Click(sender As Object, e As EventArgs) Handles btnFee.Click

        Dim strTotoalMiles As String

        Dim intTotalMiles As Integer

        Dim decTotalCost As Decimal

        strTotoalMiles = txtMiles.Text

        intTotalMiles = Convert.ToInt32(strTotoalMiles)

        decTotalCost = intTotalMiles * cdecFareCost

        lblCostLabel.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPrice.Text = cdecFareCost.ToString("C") + " Plus Mileage "

        txtMiles.Focus()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtMiles.Text = ""

        txtMiles.Focus()

        lblCostLabel.Text = ""

        lblTotalFare.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
