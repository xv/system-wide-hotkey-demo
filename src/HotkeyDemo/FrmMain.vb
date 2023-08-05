Imports System.ComponentModel

Public Class FrmMain
    Private keyAtomId As Integer

    Private key As Integer
    Private keyModifiers As Integer

    Private registeredModifiers As Integer
    Private registeredKey As Integer

    Private Sub SubEventHandlers()
        AddHandler CB_Mod_Ctrl.CheckedChanged, AddressOf CB_KeyModifier_CheckedChanged
        AddHandler CB_Mod_Shift.CheckedChanged, AddressOf CB_KeyModifier_CheckedChanged
        AddHandler CB_Mod_Alt.CheckedChanged, AddressOf CB_KeyModifier_CheckedChanged
        AddHandler CMB_Keys.SelectedIndexChanged, AddressOf CMB_Keys_SelectedIndexChanged
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' These names must match those in System.Windows.Forms.Keys enum
        Dim keyStrings() As String = {
            "Home", "End", "Delete",
            "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        }

        CMB_Keys.Items.AddRange(keyStrings)
        CMB_Keys.SelectedItem = "Home"

        CB_Mod_Ctrl.Checked = True

        SubEventHandlers()
        SaveKeySettings()
    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        UnregisterHotkey()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            Call HotkeyPressed()
        End If

        MyBase.WndProc(m)
    End Sub

    Public Sub UnregisterHotkey()
        NativeMethods.UnregisterHotKey(Handle, keyAtomId)
        NativeMethods.GlobalDeleteAtom(keyAtomId)
    End Sub

    Public Sub RegisterHotkey()
        ' Cache the hotkey currently registered
        registeredModifiers = keyModifiers
        registeredKey = key

        keyAtomId = GlobalAddAtom(Guid.NewGuid().ToString())

        NativeMethods.RegisterHotKey(Handle, keyAtomId, keyModifiers, key)
    End Sub

    Sub SetKeyModifiers(ByRef srcMod As Integer,
                        isCtrl As Boolean,
                        isShift As Boolean,
                        isAlt As Boolean)
        srcMod = RegHotKeyModFlags.MOD_NOREPEAT

        If isCtrl Then srcMod = srcMod Or RegHotKeyModFlags.MOD_CONTROL
        If isShift Then srcMod = srcMod Or RegHotKeyModFlags.MOD_SHIFT
        If isAlt Then srcMod = srcMod Or RegHotKeyModFlags.MOD_ALT
    End Sub

    Public Sub SaveKeySettings()
        Try
            SetKeyModifiers(keyModifiers, CB_Mod_Ctrl.Checked, CB_Mod_Shift.Checked, CB_Mod_Alt.Checked)
            key = DirectCast([Enum].Parse(GetType(Keys), CMB_Keys.Text), Keys)

            If registeredKey <> key Or registeredModifiers <> keyModifiers Then
                UnregisterHotkey()
                RegisterHotkey()
            End If
        Catch up As Exception
            Throw up
        End Try
    End Sub

    Private Sub CMB_Keys_SelectedIndexChanged(sender As Object, e As EventArgs)
        SaveKeySettings()
    End Sub

    Private Sub CB_KeyModifier_CheckedChanged(sender As Object, e As EventArgs)
        SaveKeySettings()
    End Sub

    Public Sub HotkeyPressed()
        Console.Beep(555, 333)
    End Sub
End Class