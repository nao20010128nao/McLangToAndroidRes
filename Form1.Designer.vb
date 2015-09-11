<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LangFile = New System.Windows.Forms.TextBox()
        Me.LangSelect = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ResXmlSelect = New System.Windows.Forms.Button()
        Me.ResXmlFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.ConvertDirect = New System.Windows.Forms.RadioButton()
        Me.Convert4MCPESC = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lang:"
        '
        'LangFile
        '
        Me.LangFile.Location = New System.Drawing.Point(49, 6)
        Me.LangFile.Name = "LangFile"
        Me.LangFile.Size = New System.Drawing.Size(184, 19)
        Me.LangFile.TabIndex = 1
        '
        'LangSelect
        '
        Me.LangSelect.Location = New System.Drawing.Point(239, 4)
        Me.LangSelect.Name = "LangSelect"
        Me.LangSelect.Size = New System.Drawing.Size(43, 23)
        Me.LangSelect.TabIndex = 2
        Me.LangSelect.Text = "選択"
        Me.LangSelect.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Convert4MCPESC)
        Me.GroupBox1.Controls.Add(Me.ConvertDirect)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "モード"
        '
        'ResXmlSelect
        '
        Me.ResXmlSelect.Location = New System.Drawing.Point(239, 137)
        Me.ResXmlSelect.Name = "ResXmlSelect"
        Me.ResXmlSelect.Size = New System.Drawing.Size(43, 23)
        Me.ResXmlSelect.TabIndex = 6
        Me.ResXmlSelect.Text = "選択"
        Me.ResXmlSelect.UseVisualStyleBackColor = True
        '
        'ResXmlFile
        '
        Me.ResXmlFile.Location = New System.Drawing.Point(49, 139)
        Me.ResXmlFile.Name = "ResXmlFile"
        Me.ResXmlFile.Size = New System.Drawing.Size(184, 19)
        Me.ResXmlFile.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "XML:"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'ConvertDirect
        '
        Me.ConvertDirect.AutoSize = True
        Me.ConvertDirect.Location = New System.Drawing.Point(6, 20)
        Me.ConvertDirect.Name = "ConvertDirect"
        Me.ConvertDirect.Size = New System.Drawing.Size(71, 16)
        Me.ConvertDirect.TabIndex = 0
        Me.ConvertDirect.TabStop = True
        Me.ConvertDirect.Text = "直接変換"
        Me.ConvertDirect.UseVisualStyleBackColor = True
        '
        'Convert4MCPESC
        '
        Me.Convert4MCPESC.AutoSize = True
        Me.Convert4MCPESC.Location = New System.Drawing.Point(6, 42)
        Me.Convert4MCPESC.Name = "Convert4MCPESC"
        Me.Convert4MCPESC.Size = New System.Drawing.Size(126, 16)
        Me.Convert4MCPESC.TabIndex = 1
        Me.Convert4MCPESC.TabStop = True
        Me.Convert4MCPESC.Text = "MCPE Skin Changer"
        Me.Convert4MCPESC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 166)
        Me.Controls.Add(Me.ResXmlSelect)
        Me.Controls.Add(Me.ResXmlFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LangSelect)
        Me.Controls.Add(Me.LangFile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "変換"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LangFile As TextBox
    Friend WithEvents LangSelect As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResXmlSelect As Button
    Friend WithEvents ResXmlFile As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents Convert4MCPESC As RadioButton
    Friend WithEvents ConvertDirect As RadioButton
End Class
