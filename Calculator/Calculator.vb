Imports System.IO

Public Class Calculator
    'Icon is made by Ipanpun
    'https://www.iconfinder.com/icons/51223/calculator_icon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "1"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "2"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "3"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "4"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "5"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "6"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "7"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "8"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""
            'Set num as textbox's text
            Dim num As String = ResultBox.Text
            'If there is a zero at the start, then remove it
            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "9"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        'Code for deleting zero at beginning
        If My.Settings.EnterText = True Then
            'Goes to first char

            ResultBox.SelectionLength = 0
            'Replaces first char with empty string. If it doesn't work, then make box empty

            'ResultBox.Paste("")
            'ResultBox.Text = ""

            Dim num As String = ResultBox.Text

            If num.Substring(0, 1) = "0" Then
                ResultBox.Text = num.Remove(0, 1)
            End If
            'Runs EnterTextDone
            My.Settings.EnterTextDone = True
        End If
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = "0"
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub ResultBox_TextChanged(sender As Object, e As EventArgs) Handles ResultBox.TextChanged
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
    End Sub

    Private Sub CalculatorTimer_Tick(sender As Object, e As EventArgs) Handles CalculatorTimer.Tick
        'Move cursor to back
        'ResultBox.Focus()
        'ResultBox.Select(ResultBox.TextLength, 0)
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = " + "
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = " - "
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = " * "
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        'Move cursor to back
        ResultBox.Focus()
        ResultBox.Select(ResultBox.TextLength, 0)
        'Get current position of cursor
        Dim currcaretpos = ResultBox.SelectionStart
        'Get length of inputted text
        Dim currsellength = ResultBox.SelectionLength
        'Go behind selected character
        ResultBox.SelectionLength = 0
        'Input text
        ResultBox.SelectedText = " / "
        'Input text infront of 0
        ResultBox.SelectionStart = currcaretpos + 1
        ResultBox.SelectionLength = currsellength
        'Checks if EnterText was performed. Sets to false to prevent deleting again.
        If My.Settings.EnterTextDone = True Then
            My.Settings.EnterText = False
        End If
        'Runs EnterText
        My.Settings.EnterText = True
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        'Replaces textbox text with a 0
        ResultBox.Text = "0"
    End Sub

    Private Sub Calculator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'If certain key pressed, then hit connected button.
        If e.KeyCode = Keys.Enter Then
            ButtonEqual.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad0 Then
            Button0.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad1 Then
            Button1.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad2 Then
            Button2.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad3 Then
            Button3.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad4 Then
            Button4.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad5 Then
            Button5.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad6 Then
            Button6.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad7 Then
            Button7.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad8 Then
            Button8.PerformClick()
        End If
        If e.KeyCode = Keys.NumPad9 Then
            Button9.PerformClick()
        End If
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        'Program path
        Dim appPath As String = Application.StartupPath()
        'Send output to a file
        Shell("cmd.exe /C SET /A Result = " + ResultBox.Text + " >" + appPath + "\calchistory.log")
        'Start 2nd timer
        CalculatorTimer2.Enabled = True
    End Sub

    Private Sub CalculatorTimer2_Tick(sender As Object, e As EventArgs) Handles CalculatorTimer2.Tick
        'Enable timer 3
        CalculatorTimer3.Enabled = True
        'Read output of the history file
        ResultBox.Text = File.ReadLines("calchistory.log").Last()
        'Read output of the history file
        ResultBox.Text = File.ReadLines("calchistory.log").Last()
        'Disable timer
        CalculatorTimer2.Enabled = False
        'If vale is false, then click again
        If My.Settings.EqualClicked = False Then
            ButtonEqual.PerformClick()
        End If
        'Change value to true
        My.Settings.EqualClicked = True
    End Sub

    Private Sub CalculatorTimer3_Tick(sender As Object, e As EventArgs) Handles CalculatorTimer3.Tick
        'Disabled self, and set EqualClicked to false
        My.Settings.EqualClicked = False
        CalculatorTimer3.Enabled = False
    End Sub
End Class
