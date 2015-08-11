Public Class Assets


    'Private str_serie As String
    Private str_marca As String
    Private str_modelo As String
    Private str_nombre As String
    Private str_descripcion As String
    Private str_color As String
    Private str_departamento As String
    Private str_codicion As String


    'Public Property serie As String

    '    Get
    '        Return Me.str_serie
    '    End Get
    '    Set(ByVal value As String)
    '        If value.Trim.Equals("") Then
    '            Throw New Exception("No se permite el campo de numero de serie en blanco")
    '        Else
    '            Me.str_serie = value.Trim
    '        End If
    '    End Set
    'End Property

    Public Property marca As String

        Get
            Return Me.str_marca
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de marca en blanco")
            Else
                Me.str_marca = value.Trim
            End If
        End Set
    End Property


    Public Property modelo As String

        Get
            Return Me.str_modelo
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de modelo en blanco")
            Else
                Me.str_modelo = value.Trim
            End If
        End Set
    End Property


    Public Property nombre As String

        Get
            Return Me.str_nombre
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de nombre en blanco")
            Else
                Me.str_nombre = value.Trim
            End If
        End Set
    End Property


    Public Property descripcion As String

        Get
            Return Me.str_descripcion
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de descripcion en blanco")
            Else
                Me.str_descripcion = value.Trim
            End If
        End Set
    End Property

    Public Property color As String

        Get
            Return Me.str_color
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de color en blanco")
            Else
                Me.str_color = value.Trim
            End If
        End Set
    End Property


    Public Property departamento As String

        Get
            Return Me.str_departamento
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de departamento en blanco")
            Else
                Me.str_departamento = value.Trim
            End If
        End Set
    End Property

    Public Property condicion As String

        Get
            Return Me.str_codicion
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de condicion en blanco")
            Else
                Me.str_codicion = value.Trim
            End If
        End Set
    End Property




#Region "Constructores"

    Public Sub New()

        'Me.serie = ""
        Me.marca = ""
        Me.modelo = ""
        Me.descripcion = ""
        Me.nombre = ""
        Me.color = ""
        Me.departamento = ""
        Me.condicion = ""


    End Sub

#End Region


    Public Sub New(ByVal bienmarca As String, _
                  ByVal bienmodelo As String, ByVal biennombre As String, ByVal biendescripcion As String, _
                   ByVal biencolor As String, ByVal biendepartamento As String, _
                   ByVal biencondicion As String)

        'ByVal bienserie As String,

        'Me.serie = bienserie
        Me.marca = bienmarca
        Me.modelo = bienmodelo
        Me.nombre = biennombre
        Me.descripcion = biendescripcion

        Me.color = biencolor
        Me.departamento = biendepartamento
        Me.condicion = biencondicion




    End Sub


End Class
