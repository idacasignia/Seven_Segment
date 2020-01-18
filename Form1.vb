Public Class Form1
    Private Sub number0()
        A.BackColor = Color.Red
        B.BackColor = Color.Red
        C.BackColor = Color.Red
        D.BackColor = Color.Red
        E.BackColor = Color.Red
        F.BackColor = Color.Red

        G.BackColor = Color.DimGray
    End Sub

    Private Sub number1()
        B.BackColor = Color.Red
        C.BackColor = Color.Red

        A.BackColor = Color.DimGray
        D.BackColor = Color.DimGray
        E.BackColor = Color.DimGray
        F.BackColor = Color.DimGray
        G.BackColor = Color.DimGray
    End Sub

    Private Sub number2()
        A.BackColor = Color.Red
        B.BackColor = Color.Red
        G.BackColor = Color.Red
        E.BackColor = Color.Red
        D.BackColor = Color.Red

        C.BackColor = Color.DimGray
        F.BackColor = Color.DimGray
    End Sub

    Private Sub number3()
        A.BackColor = Color.Red
        B.BackColor = Color.Red
        G.BackColor = Color.Red
        C.BackColor = Color.Red
        D.BackColor = Color.Red

        E.BackColor = Color.DimGray
        F.BackColor = Color.DimGray
    End Sub

    Private Sub number4()
        F.BackColor = Color.Red
        G.BackColor = Color.Red
        B.BackColor = Color.Red
        C.BackColor = Color.Red

        A.BackColor = Color.DimGray
        D.BackColor = Color.DimGray
        E.BackColor = Color.DimGray
    End Sub

    Private Sub number5()
        A.BackColor = Color.Red
        F.BackColor = Color.Red
        G.BackColor = Color.Red
        C.BackColor = Color.Red
        D.BackColor = Color.Red

        B.BackColor = Color.DimGray
        E.BackColor = Color.DimGray
    End Sub

    Private Sub number6()
        A.BackColor = Color.Red
        F.BackColor = Color.Red
        G.BackColor = Color.Red
        E.BackColor = Color.Red
        D.BackColor = Color.Red
        C.BackColor = Color.Red

        B.BackColor = Color.DimGray
    End Sub

    Private Sub number7()
        A.BackColor = Color.Red
        B.BackColor = Color.Red
        C.BackColor = Color.Red

        D.BackColor = Color.DimGray
        E.BackColor = Color.DimGray
        F.BackColor = Color.DimGray
        G.BackColor = Color.DimGray
    End Sub

    Private Sub number8()
        A.BackColor = Color.Red
        B.BackColor = Color.Red
        C.BackColor = Color.Red
        D.BackColor = Color.Red
        E.BackColor = Color.Red
        F.BackColor = Color.Red
        G.BackColor = Color.Red

    End Sub

    Private Sub number9()
        A.BackColor = Color.Red
        B.BackColor = Color.Red
        G.BackColor = Color.Red
        F.BackColor = Color.Red
        C.BackColor = Color.Red
        D.BackColor = Color.Red

        E.BackColor = Color.DimGray
    End Sub

    Dim N As Int32 = -1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        N = N + 1

        If (N = 1) Then
            number1()

        ElseIf (N = 2) Then
            number2()

        ElseIf (N = 3) Then
            number3()

        ElseIf (N = 4) Then
            number4()

        ElseIf (N = 5) Then
            number5()

        ElseIf (N = 6) Then
            number6()

        ElseIf (N = 7) Then
            number7()

        ElseIf (N = 8) Then
            number8()

        ElseIf (N = 9) Then
            number9()

        Else
            number0()
            N = 0
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
