Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Registration
    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged

        Dim leftblank As Boolean = True
        Dim usedletters As Boolean = True
        Dim Surname As String
        Surname = txtSurname.Text

        For Each ch As Char In Surname
            If Char.IsWhiteSpace(ch) Then
                leftblank = False
                MsgBox("do not leave anything blank")
            ElseIf Not Char.IsLetter(ch) Then
                usedletters = False
                MsgBox("please use letters")
            End If

        Next

    End Sub
    Private Sub txtForename_TextChanged(sender As Object, e As EventArgs) Handles txtForename.TextChanged

        Dim leftblank As Boolean = True
        Dim usedletters As Boolean = True
        Dim forename As String
        forename = txtForename.Text

        For Each ch As Char In forename
            If Char.IsWhiteSpace(ch) Then
                leftblank = False
                MsgBox("do not leave anything blank")
            ElseIf Not Char.IsLetter(ch) Then
                usedletters = False
                MsgBox("please use letters")
            End If

        Next
    End Sub
    Private Sub dtpdob_ValueChanged(sender As Object, e As EventArgs) Handles dtpdob.ValueChanged
        'set age limit to 11/12-you're too young!!!!!!!!
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

        Dim leftblank As Boolean = True
        Dim usedletters As Boolean = True
        Dim username As String
        username = txtusername.Text

        If Len(username) = 0 Then
            MsgBox("do not leave blank")
        End If


        For Each ch As Char In username
            If Char.IsWhiteSpace(ch) Then
                leftblank = False
                MsgBox("do not leave any spaces")
            End If
        Next

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'code for password'
        Dim password As String
        Dim hasLetter As Boolean = False
        Dim hasDigit As Boolean = False

        password = txtPassword.Text

        If Len(password) < 8 Then
            MsgBox("password is too short")
        End If

        For Each ch As Char In password
            If Char.IsLetter(ch) Then
                hasLetter = True
            ElseIf Char.IsDigit(ch) Then
                hasDigit = True
            End If
        Next

        If hasLetter AndAlso hasDigit Then
            MsgBox("your account has been created")
        Else
            MsgBox("password isnt strong")
        End If


    End Sub


End Class