' This class implements the outgoing interface defined by WriteLog for notifying change-of-focus events
Public Class WlFocusEvent
    Implements WriteLogClrTypes._IWriteLogFocusStateEvents
    Dim m As MainForm

    Public Sub New(f As MainForm)
        m = f
    End Sub

    Public Sub KeyboardChanged(radio As Short) Implements WriteLogClrTypes._IWriteLogFocusStateEvents.KeyboardChanged
        ' we get called here when WriteLog's keyboard focus changes
        Dim display As String
        display = "Keyboard on Radio " + radio.ToString()
        m.UpdateKbd(display)
    End Sub


    Public Sub TransmitChanged(radio As Short) Implements WriteLogClrTypes._IWriteLogFocusStateEvents.TransmitChanged
        ' we get called here when WriteLog's transmit focus changes
        Dim display As String
        display = " Transmit on Radio " + radio.ToString()
        m.UpdateXmt(display)
    End Sub
End Class
