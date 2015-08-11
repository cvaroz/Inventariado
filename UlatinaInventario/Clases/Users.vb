Public Class Users


    'Private str_serie As String
    Private str_identificacion As String
    Private str_nombre As String
    Private str_nombreUsuario As String
    Private str_descripcion As String
    Private int_edad As Integer
    Private str_sexo As String
    Private str_telefono As String
    Private str_email As String
    Private str_contraseña As String


    Public Property identificacion As String

        Get
            Return Me.str_identificacion
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de identificacion en blanco")
            Else
                Me.str_identificacion = value.Trim
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


    Public Property nombreusuario As String

        Get
            Return Me.str_nombreUsuario
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de nombre de usuario en blanco")
            Else
                Me.str_nombreUsuario = value.Trim
            End If
        End Set
    End Property


    Public Property edad As Integer

        Get
            Return Me.int_edad
        End Get
        Set(ByVal value As Integer)
            If value.Equals("") Then
                Throw New Exception("No se permite el campo de edad en blanco")
            Else
                Me.int_edad = value
            End If
        End Set
    End Property


    Public Property sexo As String

        Get
            Return Me.str_sexo
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de sexo en blanco")
            Else
                Me.str_sexo = value.Trim
            End If
        End Set
    End Property

    Public Property telefono As String

        Get
            Return Me.str_telefono
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de telefono en blanco")
            Else
                Me.str_telefono = value.Trim
            End If
        End Set
    End Property


    Public Property email As String

        Get
            Return Me.str_email
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de email en blanco")
            Else
                Me.str_email = value.Trim
            End If
        End Set
    End Property

    Public Property usuarioContraseña As String

        Get
            Return Me.str_contraseña
        End Get
        Set(ByVal value As String)
            If value.Trim.Equals("") Then
                Throw New Exception("No se permite el campo de contraseña en blanco")
            Else
                Me.str_contraseña = value.Trim
            End If
        End Set
    End Property




#Region "Constructores"

    Public Sub New()

        'Me.serie = ""
        Me.identificacion = ""
        Me.nombre = ""
        Me.nombreusuario = ""
        Me.edad = ""
        Me.sexo = ""
        Me.telefono = ""
        Me.email = ""
        Me.usuarioContraseña = ""


    End Sub

#End Region


    Public Sub New(ByVal usu_identi As String, _
                  ByVal usu_nombre As String, ByVal usu_nombreusuario As String, ByVal usu_edad As Integer, _
                   ByVal usu_Sexo As String, ByVal usu_telefono As String, _
                   ByVal usu_email As String, ByVal usu_usucontraseña As String)

        'ByVal bienserie As String,

        Me.identificacion = usu_identi
        Me.nombre = usu_nombre
        Me.nombreusuario = usu_nombreusuario
        Me.edad = usu_edad
        Me.sexo = usu_Sexo
        Me.telefono = usu_telefono
        Me.email = usu_email
        Me.usuarioContraseña = usu_usucontraseña



    End Sub


End Class


