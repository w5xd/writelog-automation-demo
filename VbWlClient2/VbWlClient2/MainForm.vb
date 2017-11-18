Public Class MainForm

    Dim wl As WriteLogClrTypes.Document
    Dim cookie As Integer
    Dim cp As System.Runtime.InteropServices.ComTypes.IConnectionPoint

    Delegate Sub ThreadDele(UpdateLabel As Label, updateTxt As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TransmitLabel.Text = ""
        KeyboardLabel.Text = ""

        ' in the Solution explorer, right click this Project, Add, then Reference
        ' ...Go to the Assemblies tab, Browse, and go to WriteLog's Programs folder
        ' and select the file WriteLogClrTypes.dll
        ' That will make the WriteLogClrTypes work

        wl = GetObject(, "writelog.document") ' connects to the running WriteLog instance

        ' This demo is for the focus state object
        Dim focusState As WriteLogClrTypes.IWriteLogFocusState
        focusState = wl.GetFocusState()

        ' demonstrate we can read the keyboard focus
        Dim fcs As Short
        fcs = focusState.KeyboardFocus
        Dim d As String
        d = "Initial Keyboard on radio " + fcs.ToString()
        KeyboardLabel.Text = d
        fcs = focusState.TransmitFocus
        d = "Initial Transmit on radio " + fcs.ToString()
        TransmitLabel.Text = d

        ' goop for setting up callbck on our WlFocusEvent
        Dim cpc As System.Runtime.InteropServices.ComTypes.IConnectionPointContainer
        cpc = focusState
        cpc.FindConnectionPoint(GetType(WriteLogClrTypes._IWriteLogFocusStateEvents).GUID, cp)
        cp.Advise(New WlFocusEvent(Me), cookie)

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not cp Is Nothing Then
            On Error Resume Next ' If WriteLog has gone away, then just ignore this error
            cp.Unadvise(cookie)
        End If
    End Sub

    ' The notifications come on a different thread, so we cannot directly update our controls.
    ' we have to BeginInvoke to get on our own thread
    Public Sub UpdateKbd(t As String)
        BeginInvoke(New ThreadDele(AddressOf UpdateLabel), KeyboardLabel, t)
    End Sub
    Public Sub UpdateXmt(t As String)
        BeginInvoke(New ThreadDele(AddressOf UpdateLabel), TransmitLabel, t)
    End Sub

    Private Sub UpdateLabel(l As Label, s As String)
        l.Text = s
    End Sub
End Class
