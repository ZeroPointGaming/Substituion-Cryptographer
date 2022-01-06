Public Class Form1
    Public alphabet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Public cryptobet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IntegerRandom As Integer
        Dim objRandom As New Random
        IntegerRandom = objRandom.Next(0, 26)

        Dim current As Integer = 1

        For i = 1 To 26
            Dim Integer2Random = objRandom.Next(0, 26)

            If i = 1 Then
                TextBox1.Text = alphabet(Integer2Random)
            End If

            If i = 2 Then
                TextBox2.Text = alphabet(Integer2Random)
            End If

            If i = 3 Then
                TextBox3.Text = alphabet(Integer2Random)
            End If

            If i = 4 Then
                TextBox4.Text = alphabet(Integer2Random)
            End If

            If i = 5 Then
                TextBox5.Text = alphabet(Integer2Random)
            End If

            If i = 6 Then
                TextBox6.Text = alphabet(Integer2Random)
            End If

            If i = 7 Then
                TextBox7.Text = alphabet(Integer2Random)
            End If

            If i = 8 Then
                TextBox8.Text = alphabet(Integer2Random)
            End If

            If i = 9 Then
                TextBox9.Text = alphabet(Integer2Random)
            End If

            If i = 10 Then
                TextBox10.Text = alphabet(Integer2Random)
            End If

            If i = 11 Then
                TextBox11.Text = alphabet(Integer2Random)
            End If

            If i = 12 Then
                TextBox12.Text = alphabet(Integer2Random)
            End If

            If i = 13 Then
                TextBox13.Text = alphabet(Integer2Random)
            End If

            If i = 14 Then
                TextBox14.Text = alphabet(Integer2Random)
            End If

            If i = 15 Then
                TextBox15.Text = alphabet(Integer2Random)
            End If

            If i = 16 Then
                TextBox16.Text = alphabet(Integer2Random)
            End If

            If i = 17 Then
                TextBox17.Text = alphabet(Integer2Random)
            End If

            If i = 18 Then
                TextBox18.Text = alphabet(Integer2Random)
            End If

            If i = 19 Then
                TextBox19.Text = alphabet(Integer2Random)
            End If

            If i = 20 Then
                TextBox20.Text = alphabet(Integer2Random)
            End If

            If i = 21 Then
                TextBox21.Text = alphabet(Integer2Random)
            End If

            If i = 22 Then
                TextBox22.Text = alphabet(Integer2Random)
            End If

            If i = 23 Then
                TextBox23.Text = alphabet(Integer2Random)
            End If

            If i = 24 Then
                TextBox24.Text = alphabet(Integer2Random)
            End If

            If i = 25 Then
                TextBox25.Text = alphabet(Integer2Random)
            End If

            If i = 26 Then
                TextBox26.Text = alphabet(Integer2Random)
            End If

            current += 1
        Next
    End Sub

    Public cipherAlphabet As String = ""
    Public alphabet1 As String = "abcdefghijklmnopqrstuvwxyz"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stringtocrypt.Text = stringtocrypt.Text.ToLower

        cipherAlphabet = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text + TextBox6.Text + TextBox7.Text + TextBox8.Text + TextBox9.Text + TextBox10.Text + TextBox11.Text + TextBox12.Text + TextBox13.Text + TextBox14.Text + TextBox15.Text + TextBox16.Text + TextBox17.Text + TextBox18.Text + TextBox19.Text + TextBox20.Text + TextBox21.Text + TextBox22.Text + TextBox23.Text + TextBox24.Text + TextBox25.Text + TextBox26.Text

        Encipher(stringtocrypt.Text, cipherAlphabet, stringtocrypt.Text)

        stringtocrypt.Text = stringtocrypt.Text.ToUpper

        MessageBox.Show("Message Encoded | " + cipherAlphabet.ToString)
    End Sub

    Private Shared Function Cipher(input As String, oldAlphabet As String, newAlphabet As String, ByRef output As String) As Boolean
        output = String.Empty

        If oldAlphabet.Length <> newAlphabet.Length Then
            Return False
        End If

        For i As Integer = 0 To input.Length - 1
            Dim oldCharIndex As Integer = oldAlphabet.IndexOf(Char.ToLower(input(i)))

            If oldCharIndex >= 0 Then
                output += If(Char.IsUpper(input(i)), Char.ToUpper(newAlphabet(oldCharIndex)), newAlphabet(oldCharIndex))
            Else
                output += input(i)
            End If
        Next

        Return True
    End Function

    Public Shared Function Encipher(input As String, cipherAlphabet As String, ByRef output As String) As Boolean
        Dim plainAlphabet As String = "abcdefghijklmnopqrstuvwxyz"
        Return Cipher(input, plainAlphabet, cipherAlphabet, output)
    End Function

    Public Shared Function Decipher(input As String, cipherAlphabet As String, ByRef output As String) As Boolean
        Dim plainAlphabet As String = "abcdefghijklmnopqrstuvwxyz"
        Return Cipher(input, cipherAlphabet, plainAlphabet, output)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decipher(stringtocrypt.Text, cipherAlphabet, stringtocrypt.Text)
    End Sub
End Class
