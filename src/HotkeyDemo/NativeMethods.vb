Imports System.Runtime.InteropServices

Friend Module NativeMethods
    Public Const WM_HOTKEY = &H312

    <Flags()>
    Public Enum RegHotKeyModFlags
        MOD_ALT = &H1
        MOD_CONTROL = &H2
        MOD_SHIFT = &H4
        MOD_WIN = &H8
        MOD_NOREPEAT = &H4000
    End Enum

    <DllImport("kernel32", SetLastError:=True)>
    Public Function GlobalAddAtom(<MarshalAs(UnmanagedType.LPTStr)> lpString As String) As Integer
    End Function

    <DllImport("kernel32", SetLastError:=True)>
    Public Function GlobalDeleteAtom(nAtom As Integer) As Integer
    End Function

    <DllImport("user32", SetLastError:=True)>
    Public Function RegisterHotKey(hWnd As IntPtr, id As Integer,
                                   fsModifiers As Integer, vk As Integer) As Integer
    End Function

    <DllImport("user32", SetLastError:=True)>
    Public Function UnregisterHotKey(hWnd As IntPtr, id As Integer) As Integer
    End Function
End Module