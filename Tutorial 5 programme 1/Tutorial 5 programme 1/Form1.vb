Public Class Form1

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        Dim start As Single
        Dim total As Single
        start = 0
        If chkrose.Checked = True Then
            total = start + total + 1
        End If
        If chkcarnations.Checked = True Then
            total = start + total + 1
        End If
        If chkchrys.Checked = True Then
            total = start + total + 1
        End If
        If chklillies.Checked = True Then
            total = start + total + 1
        End If
        If chkfreesia.Checked = True Then
            total = start + total + 1
        End If
        If chkgerberas.Checked = True Then
            total = start + total + 1
        End If
        If Not total = 4 Then
            MsgBox("Error Please select four types of flowers")
        End If
        If radcheque.Checked Then
            MsgBox("Send cheque using post")
        ElseIf radmaster.Checked Or radswitch.Checked Or radvisa.Checked Then
            grppayment.Enabled = True
        End If

    End Sub

    Private Sub btnpayment_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        MsgBox("Payment was successful")
        grppayment.Enabled = False
    End Sub
End Class
