Module Module1

    Sub Main(args As String())
        'Read provided filename from Command line args or TestXML file by default
        Dim inputFileName As String = If(args.Length > 0, args(0), "TestXML.xml")
        Dim data = Operations.ProcessInput(inputFileName)
        Operations.OutPutData(data)
    End Sub

End Module
