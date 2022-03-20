Public Class Testeos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sBeneficio As String
        sBeneficio = FormatearBeneficio(TextBox1.Text)
        Label1.Text = sBeneficio
    End Sub
End Class