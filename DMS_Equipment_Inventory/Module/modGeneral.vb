Module modGeneral
    Public Const sServerLocal As String = "192.168.9.121"
    Public Const sPort As String = "1433"
    Public Const sDatabase As String = "DMSX"
    Public Const sUsername As String = "sa"
    Public Const sPassword As String = "intok"

    Public Function getConnectionString() As String
        Return "Data Source=" & sServerLocal & "," & sPort & "; Initial Catalog=" & sDatabase & "; Uid=" & sUsername & "; Pwd=" & sPassword & ";"
    End Function
End Module
