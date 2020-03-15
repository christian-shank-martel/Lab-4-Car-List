' Author:   Christian Shank-Martel
' Date:     2020-03-08
' Description:
'       This is a car class emt to hold the standered needs of most cars
'       like, Year, Make, Model, and Price for a lab in .NET dev
'

Option Strict On

Public Class Car

#Region "Variables"

    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carIsNew As Boolean = True

#End Region

#Region "Contructors"

    Friend Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    ''' <summary>
    ''' Parameter Constructor, makes new car bassed on parameters passed in
    ''' </summary>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer,
      priceValue As Decimal, newValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carIsNew = newValue

    End Sub

#End Region

#Region "property Procedures"

    Public Shared ReadOnly Property Count() As Integer

        Get
            Return carCount
        End Get

    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns>Car identification Number</returns>
    Public ReadOnly Property ID() As Integer

        Get
            Return carIdentificationNumber
        End Get

    End Property

    ''' <summary>
    ''' Get's a car or sets a car Make value
    ''' </summary>
    ''' <returns>the car's manufacturer</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Get's a car or sets a car Model value
    ''' </summary>
    ''' <returns>the car's model</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' Get's a car or sets a car Make Price
    ''' </summary>
    ''' <returns>the car's Price</returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Get's a car or sets a car Make value
    ''' </summary>
    ''' <returns>the car's manufacturer</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Get's a car or sets a car Make value
    ''' </summary>
    ''' <returns>the car's manufacturer</returns>
    Public Property IsNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property
#End Region

#Region "Methods"

    ''' <summary>
    ''' Returns a String describing the CAr
    ''' </summary>
    ''' <returns>A String Describing the Car</returns>
    Friend Function GetCarDate() As String

        Return IIf(carIsNew, "New", "Used").ToString & carYear & " " & carMake & " " & carModel & " " & carPrice.ToString("c")

    End Function


#End Region


End Class
