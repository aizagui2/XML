Imports System.IO
Imports System.Xml.Serialization

Public Module Operations
    ''' <summary>
    ''' Read XML from provided file path
    ''' </summary>
    ''' <param name="fileName">Path to XML file</param>
    ''' <returns>XML Dataset from input file</returns>
    Function ProcessInput(ByVal fileName As String) As BILL_HEADER_Dataset
        Dim log As New StreamWriter("Import.log", True)

        Console.WriteLine("Beginning data import")
        log.WriteLine("Beginning data import")
        Dim s As New XmlSerializer(GetType(BILL_HEADER_Dataset))
        Dim dataset As BILL_HEADER_Dataset
        Try
            Using sr As New StreamReader(fileName)
                dataset = s.Deserialize(sr)
                Console.WriteLine("Data imported successfully: {0} records to be processed", dataset.BILL_HEADER.Count)
                log.WriteLine("Data imported successfully: {0} records to be processed", dataset.BILL_HEADER.Count)
            End Using
        Catch ex As Exception
            Console.WriteLine("Error importing file. See Import.log for details")
            log.WriteLine("Error importing file.\n{0}", ex)
            dataset = Nothing
        End Try
        log.Close()
        Return dataset
    End Function
    ''' <summary>
    ''' Output formatted XML dataset to file
    ''' </summary>
    ''' <param name="dataSet">XML dataset to output</param>
    Sub OutPutData(ByVal dataSet As BILL_HEADER_Dataset)
        Dim log As New StreamWriter("Import.log", True)
        If dataSet Is Nothing Then
            Console.WriteLine("No input data to process")
            log.WriteLine("No input data to process")
        Else
            Dim fhOutput = New FileHeaderOutput(dataSet)
            Console.WriteLine("Writing output to file")
            log.WriteLine("Writing output to file")
            WriteLines(fhOutput.FHOutPutData)
            For Each output In fhOutput.BillHeadersData
                WriteLines(output.IHOutPutData)
                WriteLines(output.CROutPutData)
            Next
            Console.WriteLine("Output completed: {0} records processed", dataSet.BILL_HEADER.Count)
            log.WriteLine("Output completed: {0} records processed", dataSet.BILL_HEADER.Count)
        End If
        log.Close()
    End Sub
    ''' <summary>
    ''' Write Dictionary keys and values to file
    ''' </summary>
    ''' <param name="dictionary">Set of KVPs to write</param>
    Private Sub WriteLines(ByVal dictionary As Dictionary(Of String, String))
        Dim outputFile As New StreamWriter("Output.txt", True)
        outputFile.WriteLine(String.Join("|", dictionary.Select(Function(kvp) String.Format("{0}~{1}", kvp.Key, kvp.Value))))
        outputFile.Close()
    End Sub

End Module
