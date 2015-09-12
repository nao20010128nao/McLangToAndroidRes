Imports System.IO
Public Class Form1
    Dim mcpescMap As IDictionary(Of String, String()) = New Dictionary(Of String, String())
    Dim mcpescExtractIssues As IDictionary(Of String, String) = New Dictionary(Of String, String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mcpescMap("skin.name.steve") = {"Steve", "SteveN"}
        mcpescMap("skin.name.alex") = {"AlexN"}
        mcpescMap("entity.Zombie.name") = {"Zombie"}
        mcpescMap("entity.PigZombie.name") = {"ZombiePigman"}
        mcpescMap("entity.Cow.name") = {"Cow"}
        mcpescMap("entity.Creeper.name") = {"Creeper"}
        mcpescMap("entity.Pig.name") = {"Pig"}
        mcpescMap("entity.Sheep.name") = {"Sheep"}
        mcpescMap("entity.Ghast.name") = {"GhastNormal"} ', "GhastShooting"}
        mcpescMap("entity.SnowMan.name") = {"SnowGolem"}
        mcpescMap("entity.Squid.name") = {"Squid"}
        mcpescMap("entity.Wolf.name") = {"WolfNormal"} ', "WolfAngry"}
        mcpescMap("entity.Chicken.name") = {"Chicken"}
        mcpescMap("entity.IronGolem.name") = {"IronGolem"}
        mcpescMap("entity.Bat.name") = {"Bat"}
        mcpescMap("entity.Blaze.name") = {"Blaze"}
        mcpescMap("entity.MushroomCow.name") = {"Mooshroom"}
        mcpescMap("entity.LavaSlime.name") = {"MagmaCube"}
        mcpescMap("entity.Silverfish.name") = {"SilverFish"}
        mcpescMap("entity.Slime.name") = {"Slime"}
        mcpescMap("entity.Skeleton.name") = {"Skeleton"}

        mcpescExtractIssues("Sheep0") = "White Sheep"
        mcpescExtractIssues("Sheep1") = "Orange Sheep"
        mcpescExtractIssues("Sheep2") = "Light Purple Sheep"
        mcpescExtractIssues("Sheep3") = "Light Blue Sheep"
        mcpescExtractIssues("Sheep4") = "Yellow Sheep"
        mcpescExtractIssues("Sheep5") = "Lime Sheep"
        mcpescExtractIssues("Sheep6") = "Pink Sheep"
        mcpescExtractIssues("Sheep7") = "Dark Gray Sheep"
        mcpescExtractIssues("Sheep8") = "Gray Sheep"
        mcpescExtractIssues("Sheep9") = "Cyan Sheep"
        mcpescExtractIssues("Sheep10") = "Purple Sheep"
        mcpescExtractIssues("Sheep11") = "Blue Sheep"
        mcpescExtractIssues("Sheep12") = "Brown Sheep"
        mcpescExtractIssues("Sheep13") = "Green Sheep"
        mcpescExtractIssues("Sheep14") = "Red Sheep"
        mcpescExtractIssues("Sheep15") = "Black Sheep"
        mcpescExtractIssues("GhastShooting") = "Shooting Ghast"
        mcpescExtractIssues("WolfAngry") = "Angry Wolf"
        mcpescExtractIssues("CreeperArmor") = "Powered Creeper \""Armor\"""
        mcpescExtractIssues("WitherSkeleton") = "Wither Skeleton"
    End Sub

    Private Sub LangSelect_Click(sender As Object, e As EventArgs) Handles LangSelect.Click
        LangSelector.ShowDialog()
    End Sub

    Private Sub ResXmlSelect_Click(sender As Object, e As EventArgs) Handles ResXmlSelect.Click
        ResXmlSelector.ShowDialog()
    End Sub

    Private Sub LangSelector_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles LangSelector.FileOk
        LangFile.Text = LangSelector.FileName
    End Sub

    Private Sub ResXmlSelector_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ResXmlSelector.FileOk
        ResXmlFile.Text = ResXmlSelector.FileName
    End Sub

    Private Sub DataProcessor_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DataProcessor.DoWork
        Dim direct As Boolean = Invoke(Function() ConvertDirect.Checked)
        Dim loadFrom As String = Invoke(Function() LangFile.Text)
        Dim saveTo As String = Invoke(Function() ResXmlFile.Text)
        Dim xml = XDocument.Parse("<resources></resources>")
        Using lang As New StreamReader(loadFrom)
            While Not lang.EndOfStream
                Dim splited = lang.ReadLine.TrimEnd(vbTab, "#").Split("="c)
                If splited.Length <> 2 Then
                    Continue While
                End If
                If direct Then
                    Dim node = <string name=""></string>
                    node.@name = splited(0)
                    node.Value = EscapeForAndroid(splited(1))
                    xml.Root.Add(node)
                Else
                    If Not mcpescMap.ContainsKey(splited(0)) Then
                        Continue While
                    End If
                    For Each s In mcpescMap(splited(0))
                        Dim tmp = <string name=""></string>
                        tmp.@name = s
                        tmp.Value = EscapeForAndroid(splited(1))
                        xml.Root.Add(tmp)
                    Next
                End If
            End While
        End Using
        'If Not direct Then
        '    xml.Root.Add(<!--These resources cannot be converted by this program because they're not in the game lang file.-->)
        '    xml.Root.Add(<!--Please translate them yourself.-->)
        '    For Each kvp In mcpescExtractIssues
        '        Dim tmp = <string name=""></string>
        '        tmp.@name = kvp.Key
        '        tmp.Value = kvp.Value
        '        xml.Root.Add(tmp)
        '    Next
        'End If
        xml.Save(saveTo)
        Invoke(Sub() Enabled = True)
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        DataProcessor.RunWorkerAsync()
        Enabled = False
    End Sub
    Private Function EscapeForAndroid(s As String) As String
        Dim sb As New System.Text.StringBuilder(CType(s.Length * 1.1, Integer))
        For Each c In s
            Select Case c
                Case """"c
                    sb.Append("\").Append(c)
                Case "'"c
                    sb.Append("\").Append(c)
                Case Else
                    sb.Append(c)
            End Select
        Next
        Return sb.ToString
    End Function
End Class
