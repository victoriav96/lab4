'Victoria Valdron - Lab 4 Class Car file'
Option Strict On
Public Class Car

    Private Shared identification As Integer
    Private carIdentificationNumber As Integer = 0
    Private carYear As String = String.Empty
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carPrice As String = String.Empty
    Private cartVeryImportantPersonStatus As Boolean = False


    Public Sub New()

        identification += 1
        carIdentificationNumber = identification

    End Sub


    Public Sub New(year As String, make As String, model As String, price As String, veryImportantPersonStatus As Boolean)

        Me.New()

        carYear = year
        carMake = make
        carModel = model
        carPrice = price
        cartVeryImportantPersonStatus = veryImportantPersonStatus

    End Sub


    Public ReadOnly Property Count() As Integer
        Get
            Return identification
        End Get
    End Property


    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property


    Public Property VeryImportantPersonStatus() As Boolean
        Get
            Return cartVeryImportantPersonStatus
        End Get
        Set(ByVal value As Boolean)
            cartVeryImportantPersonStatus = value
        End Set
    End Property


    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property


    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property




End Class
