Public Class Student
    Private _name As String
    ' Private _id As String
    Private _subject As String

#Region "Constructors"
    Public Sub New()
        'Default constructor
        _name = ""
        ' _id = ""
        _subject = ""
    End Sub

    Public Sub New(ByVal name As String, ByVal subject As String)
        Me._name = name
        'Me._id = Id
        Me._subject = subject
    End Sub
#End Region

#Region "Properties"
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    '  Public Property Id() As Integer
    '    Get
    '      Return _id
    ' End Get
    ' Set(ByVal value As Integer)
    '      _id = value
    ' End Set
    ' End Property
    Public Property Subject() As String
        Get
            Return _subject
        End Get
        Set(ByVal value As String)
            _subject = value
        End Set
    End Property
#End Region

End Class
