Public Class FileHeaderOutput
    Private FHOutput As Dictionary(Of String, String)
    Private BillHeaders As List(Of BillHeaderOutput)
    ''' <summary>
    ''' Accept XML file dataset to format output as kvp
    ''' </summary>
    ''' <param name="dataSet"></param>
    Public Sub New(ByVal dataSet As BILL_HEADER_Dataset)
        FHOutput = New Dictionary(Of String, String)
        FHOutput.Add("1", "FH")
        FHOutput.Add("2", "8203ACC7-2094-43CC-8F7A-B8F19AA9BDA2")
        FHOutput.Add("3", "Sample UT File")
        FHOutput.Add("4", DateTime.Today.ToString("MM/dd/yyyy"))

        'Set up Bill Headers prior to calculating totals
        BillHeaders = New List(Of BillHeaderOutput)
        For Each billHeader In dataSet.BILL_HEADER
            BillHeaders.Add(New BillHeaderOutput(billHeader))
        Next

        FHOutput.Add("5", dataSet.BILL_HEADER.Count)
        FHOutput.Add("6", dataSet.BILL_HEADER.Sum(Function(bh) bh.Bill.Bill_Amount))

    End Sub

    Public Property FHOutPutData() As Dictionary(Of String, String)
        Get
            Return Me.FHOutput
        End Get
        Set
            Me.FHOutput = Value
        End Set
    End Property

    Public Property BillHeadersData As List(Of BillHeaderOutput)
        Get
            Return Me.BillHeaders
        End Get
        Set
            Me.BillHeaders = Value
        End Set
    End Property

End Class
