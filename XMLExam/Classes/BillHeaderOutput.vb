Imports System.IO

Public Class BillHeaderOutput
    Private IHOutput As Dictionary(Of String, String)
    Private CROutput As Dictionary(Of String, String)
    ''' <summary>
    ''' Accept XML Dataset to format in Output KVP format
    ''' </summary>
    ''' <param name="billHeader">XML Dataset</param>
    Public Sub New(ByVal billHeader As BILL_HEADER_DatasetBILL_HEADER)
        IHOutput = New Dictionary(Of String, String)
        CROutput = New Dictionary(Of String, String)

        'IH Record
        Try
            IHOutput.Add("7", "IH")
            IHOutput.Add("8", "R")
            IHOutput.Add("9", "8E2FEA69-5D77-4D0F-898E-DFA25677D19E")
            IHOutput.Add("10", billHeader.Invoice_No)
            IHOutput.Add("11", billHeader.Bill_Dt)
            IHOutput.Add("12", billHeader.Due_Dt)
            IHOutput.Add("13", billHeader.Bill.Bill_Amount)
            IHOutput.Add("23", DateTime.Today.AddDays(5).ToString("MM/dd/yyyy"))
            IHOutput.Add("24", DateTime.Parse(billHeader.Due_Dt).AddDays(-5).ToString("MM/dd/yyyy"))
            IHOutput.Add("93", billHeader.Bill.Balance_Due)
            IHOutput.Add("106", DateTime.Today.ToString("MM/dd/yyyy"))
        Catch ex As Exception
            Using sw As New StreamWriter("Import.log")
                sw.WriteLine("Error parsing IH record \nException: {0}", ex)
            End Using
        End Try

        'CR Record
        Try
            CROutput.Add("58", "CR")
            CROutput.Add("59", billHeader.Account_No)
            CROutput.Add("60", billHeader.Customer_Name)
            CROutput.Add("61", billHeader.Address_Information.Mailing_Address_1)
            CROutput.Add("62", billHeader.Address_Information.Mailing_Address_2)
            CROutput.Add("63", billHeader.Address_Information.City)
            CROutput.Add("64", billHeader.Address_Information.State)
            CROutput.Add("65", billHeader.Address_Information.Zip)
        Catch ex As Exception
            Using sw As New StreamWriter("Import.log")
                sw.WriteLine("Error parsing CR record \nException: {0}")
            End Using
        End Try

    End Sub

    Public Property IHOutPutData() As Dictionary(Of String, String)
        Get
            Return Me.IHOutput
        End Get
        Set
            Me.IHOutput = Value
        End Set
    End Property

    Public Property CROutPutData() As Dictionary(Of String, String)
        Get
            Return Me.CROutput
        End Get
        Set
            Me.CROutput = Value
        End Set
    End Property
End Class
