<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMB_Keys = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Mod_Shift = New System.Windows.Forms.CheckBox()
        Me.CB_Mod_Ctrl = New System.Windows.Forms.CheckBox()
        Me.CB_Mod_Alt = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "+"
        '
        'CMB_Keys
        '
        Me.CMB_Keys.DropDownHeight = 100
        Me.CMB_Keys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Keys.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CMB_Keys.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Keys.FormattingEnabled = True
        Me.CMB_Keys.IntegralHeight = False
        Me.CMB_Keys.Location = New System.Drawing.Point(18, 66)
        Me.CMB_Keys.Name = "CMB_Keys"
        Me.CMB_Keys.Size = New System.Drawing.Size(185, 21)
        Me.CMB_Keys.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Key"
        '
        'CB_Mod_Shift
        '
        Me.CB_Mod_Shift.AutoSize = True
        Me.CB_Mod_Shift.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB_Mod_Shift.Location = New System.Drawing.Point(84, 26)
        Me.CB_Mod_Shift.Name = "CB_Mod_Shift"
        Me.CB_Mod_Shift.Size = New System.Drawing.Size(63, 18)
        Me.CB_Mod_Shift.TabIndex = 17
        Me.CB_Mod_Shift.Text = "SHIFT"
        Me.CB_Mod_Shift.UseVisualStyleBackColor = True
        '
        'CB_Mod_Ctrl
        '
        Me.CB_Mod_Ctrl.AutoSize = True
        Me.CB_Mod_Ctrl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB_Mod_Ctrl.Location = New System.Drawing.Point(18, 26)
        Me.CB_Mod_Ctrl.Name = "CB_Mod_Ctrl"
        Me.CB_Mod_Ctrl.Size = New System.Drawing.Size(60, 18)
        Me.CB_Mod_Ctrl.TabIndex = 16
        Me.CB_Mod_Ctrl.Text = "CTRL"
        Me.CB_Mod_Ctrl.UseVisualStyleBackColor = True
        '
        'CB_Mod_Alt
        '
        Me.CB_Mod_Alt.AutoSize = True
        Me.CB_Mod_Alt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB_Mod_Alt.Location = New System.Drawing.Point(153, 26)
        Me.CB_Mod_Alt.Name = "CB_Mod_Alt"
        Me.CB_Mod_Alt.Size = New System.Drawing.Size(52, 18)
        Me.CB_Mod_Alt.TabIndex = 15
        Me.CB_Mod_Alt.Text = "ALT"
        Me.CB_Mod_Alt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Modifiers"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(220, 102)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_Keys)
        Me.Controls.Add(Me.CB_Mod_Alt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Mod_Ctrl)
        Me.Controls.Add(Me.CB_Mod_Shift)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotkey Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMB_Keys As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_Mod_Shift As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Mod_Ctrl As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Mod_Alt As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
