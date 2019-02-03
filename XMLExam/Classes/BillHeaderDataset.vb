
' NOTE: Generated code may require at least .NET Framework 4.5 Or .NET Core/Standard 2.0.
'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
Partial Public Class BILL_HEADER_Dataset

    Private bILL_HEADERField() As BILL_HEADER_DatasetBILL_HEADER

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("BILL_HEADER")>
    Public Property BILL_HEADER() As BILL_HEADER_DatasetBILL_HEADER()
        Get
            Return Me.bILL_HEADERField
        End Get
        Set
            Me.bILL_HEADERField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class BILL_HEADER_DatasetBILL_HEADER

    Private invoice_NoField As String

    Private account_NoField As String

    Private customer_NameField As String

    Private cycle_CdField As Byte

    Private bill_DtField As DateTime

    Private due_DtField As DateTime

    Private billField As BILL_HEADER_DatasetBILL_HEADERBill

    Private address_InformationField As BILL_HEADER_DatasetBILL_HEADERAddress_Information

    Private account_ClassField As String

    '''<remarks/>
    Public Property Invoice_No() As String
        Get
            Return Me.invoice_NoField
        End Get
        Set
            Me.invoice_NoField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Account_No() As String
        Get
            Return Me.account_NoField
        End Get
        Set
            Me.account_NoField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Customer_Name() As String
        Get
            Return Me.customer_NameField
        End Get
        Set
            Me.customer_NameField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Cycle_Cd() As Byte
        Get
            Return Me.cycle_CdField
        End Get
        Set
            Me.cycle_CdField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Bill_Dt() As String
        Get
            Return Me.bill_DtField.ToString("MM/dd/yyyy")
        End Get
        Set
            Me.bill_DtField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Due_Dt() As String
        Get
            Return Me.due_DtField.ToString("MM/dd/yyyy")
        End Get
        Set
            Me.due_DtField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Bill() As BILL_HEADER_DatasetBILL_HEADERBill
        Get
            Return Me.billField
        End Get
        Set
            Me.billField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Address_Information() As BILL_HEADER_DatasetBILL_HEADERAddress_Information
        Get
            Return Me.address_InformationField
        End Get
        Set
            Me.address_InformationField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Account_Class() As String
        Get
            Return Me.account_ClassField
        End Get
        Set
            Me.account_ClassField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class BILL_HEADER_DatasetBILL_HEADERBill

    Private bill_AmountField As Decimal

    Private balance_DueField As Decimal

    Private bill_Run_DtField As String

    Private bill_Run_SeqField As UShort

    Private bill_Run_TmField As UInteger

    Private bill_TpField As String

    '''<remarks/>
    Public Property Bill_Amount() As Decimal
        Get
            Return Me.bill_AmountField
        End Get
        Set
            Me.bill_AmountField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Balance_Due() As Decimal
        Get
            Return Me.balance_DueField
        End Get
        Set
            Me.balance_DueField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Bill_Run_Dt() As String
        Get
            Return Me.bill_Run_DtField
        End Get
        Set
            Me.bill_Run_DtField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Bill_Run_Seq() As UShort
        Get
            Return Me.bill_Run_SeqField
        End Get
        Set
            Me.bill_Run_SeqField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Bill_Run_Tm() As UInteger
        Get
            Return Me.bill_Run_TmField
        End Get
        Set
            Me.bill_Run_TmField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Bill_Tp() As String
        Get
            Return Me.bill_TpField
        End Get
        Set
            Me.bill_TpField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class BILL_HEADER_DatasetBILL_HEADERAddress_Information

    Private mailing_Address_1Field As String

    Private mailing_Address_2Field As String

    Private cityField As String

    Private stateField As String

    Private zipField As UInteger

    '''<remarks/>
    Public Property Mailing_Address_1() As String
        Get
            Return Me.mailing_Address_1Field
        End Get
        Set
            Me.mailing_Address_1Field = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Mailing_Address_2() As String
        Get
            Return Me.mailing_Address_2Field
        End Get
        Set
            Me.mailing_Address_2Field = Value
        End Set
    End Property

    '''<remarks/>
    Public Property City() As String
        Get
            Return Me.cityField
        End Get
        Set
            Me.cityField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property State() As String
        Get
            Return Me.stateField
        End Get
        Set
            Me.stateField = Value
        End Set
    End Property

    '''<remarks/>
    Public Property Zip() As UInteger
        Get
            Return Me.zipField
        End Get
        Set
            Me.zipField = Value
        End Set
    End Property
End Class

