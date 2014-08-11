Public Class Form1

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button1.Text = "0."

        Label1.Text = ""

        Label2.Text = ""

        Label3.Text = ""
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        End
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Label1.Text > "" And Label2.Text = "+" Then

            Button1.Text = Val(Label1.Text) + Val(Button1.Text)

            Label3.Text = Button1.Text

        ElseIf Label2.Text > "" And Label2.Text = "-" Then

            Button1.Text = Val(Label1.Text) - Val(Button1.Text)

            Label3.Text = Button1.Text

        ElseIf Label2.Text > "" And Label2.Text = "*" Then

            Button1.Text = Val(Label1.Text) * Val(Button1.Text)

            Label3.Text = Button1.Text

        ElseIf Label2.Text > "" And Label2.Text = "/" Then

            Button1.Text = Val(Label1.Text) / Val(Button1.Text)

            Label3.Text = Button1.Text

        Else

        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Label2.Text = "+"

        Label1.Text = Button1.Text
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Label2.Text = "-"

        Label1.Text = Button1.Text
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label2.Text = "*"

        Label1.Text = Button1.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label2.Text = "/"

        Label1.Text = Button1.Text
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "0."

        ElseIf Button1.Text = "0." Then

            Button1.Text = "0."

        ElseIf Button1.Text = "0" Then

            Button1.Text = "0."

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "0."

        Else

            Button1.Text = Button1.Text & "0"
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Button1.Text = "0." Then

            Button1.Text = "."

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "."

        ElseIf Button1.Text = Label1.Text Then

            Button1.Text = "."

        Else

            If Button1.Text.Contains(".") Then

            Else

                Button1.Text = Button1.Text & "."

            End If



        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "1"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "1"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "1"

        Else

            Button1.Text = Button1.Text & "1"

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "2"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "2"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "2"

        Else

            Button1.Text = Button1.Text & "2"

        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "3"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "3"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "3"

        Else

            Button1.Text = Button1.Text & "3"

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "4"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "4"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "4"

        Else

            Button1.Text = Button1.Text & "4"

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "5"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "5"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "5"

        Else

            Button1.Text = Button1.Text & "5"

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "6"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "6"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "6"

        Else

            Button1.Text = Button1.Text & "6"

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "7"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "7"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "7"

        Else

            Button1.Text = Button1.Text & "7"

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "8"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "8"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "8"

        Else

            Button1.Text = Button1.Text & "8"

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button1.Text = Label1.Text Then

            Button1.Text = "9"

        ElseIf Button1.Text = "0." Then

            Button1.Text = "9"

        ElseIf Button1.Text = Label3.Text Then

            Button1.Text = "9"

        Else

            Button1.Text = Button1.Text & "9"

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit the program
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Victoria's Calculator." & vbCrLf & vbCrLf & _
               "Programmed by Victoria" & vbCrLf & vbCrLf & _
               "August 2010")
    End Sub
End Class
