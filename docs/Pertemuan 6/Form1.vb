Public Class Form1
    Private Sub btnfor_Click(sender As Object, e As EventArgs) Handles btnfor.Click
        For a = 1 To 15 Step 1
            cmbfor.Items.Add(a)
        Next
    End Sub

    Private Sub btnwhile_Click(sender As Object, e As EventArgs) Handles btnwhile.Click
        Dim b As Integer
        b = 1
        While b <= 15
            listboxwhile.Items.Add(b)
            b = b + 1
        End While
    End Sub

    Private Sub btnloopuntil_Click(sender As Object, e As EventArgs) Handles btnloopuntil.Click
        Dim c As Integer
        c = 1
        Do
            cmbloopuntil.Items.Add(c)
            c = c + 1
        Loop Until c > 15
    End Sub

    Private Sub btndowhile_Click(sender As Object, e As EventArgs) Handles btndowhile.Click
        Dim d As Integer
        d = 1
        Do While d <= 15
            If d Mod 2 = 1 Then
                listboxganjil.Items.Add(d)
            Else
                listboxgenap.Items.Add(d)
            End If
            d = d + 1
        Loop
    End Sub
End Class
