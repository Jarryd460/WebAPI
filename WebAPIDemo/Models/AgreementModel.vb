Public Class AgreementModel

    Private c_idAgreement As Guid
    Private c_strName As String
    Private c_guidType As Guid
    Private c_guidStatus As Integer
    Private c_dteEndDate As Date

    Public Sub New(idAgreement As Guid, strName As String, guidType As Guid, guidStatus As Integer, dteEndDate As Date)
        Me.c_idLicense = idAgreement
        Me.c_strName = strName
        Me.c_guidType = guidType
        Me.c_guidStatus = guidStatus
        Me.c_dteEndDate = dteEndDate

    End Sub

    Public Property ID() As Guid
        Get
            Return c_idAgreement
        End Get
        Set(Value As Guid)
            c_idAgreement = Value
        End Set
    End Property

    Public Property c_strName As String
        Get
            Return c_strName
        End Get
        Set(Value As String)
            c_strName = Value
        End Set
    End Property

    Public Property c_guidType As Guid
        Get
            Return c_guidType
        End Get
        Set(Value As Guid)
            c_guidType = Value
        End Set
    End Property

    Public Property c_guidStatus As Integer
        Get
            Return c_guidStatus
        End Get
        Set(Value As Integer)
            c_guidStatus = Value
        End Set
    End Property

    Public Property c_dteEndDate As Date
        Get
            Return c_dteEndDate
        End Get
        Set(Value As Date)
            c_dteEndDate = Value
        End Set
    End Property

End Class
