
Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As New SqlConnection("Server=LAPDELL; DataBase=BDParcial2FranciscoyHugo; Integrated Security=True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Dim municipio, departamento As Integer
        Dim Selecmun As String = Convert.ToString(ComboB_Municipio.SelectedItem)
        Dim Selecdep As String = Convert.ToString(ComboB_Departamento.SelectedItem)
        Select Case Selecmun
            Case "San Salvador"
                municipio = 1
            Case "Santa Tecla"
                municipio = 2
            Case "Soyapango"
                municipio = 3
            Case "San Miguel"
                municipio = 4
            Case "Moncagua"
                municipio = 5
            Case "Quelepa"
                municipio = 6
            Case "Antiguo Cuscatlan"
                municipio = 7
            Case "Colon"
                municipio = 8
            Case "La Libertad"
                municipio = 9
            Case "Santa Ana"
                municipio = 10
            Case "Metapan"
                municipio = 11
            Case "Chalchuapa"
                municipio = 12
        End Select
        Select Case Selecdep
            Case "San Salvador"
                departamento = 1
            Case "San Miguel"
                departamento = 2
            Case "La Libertad"
                departamento = 3
            Case "Santa Ana"
                departamento = 4

        End Select
        'MsgBox(Selecmun)

        Try

            Dim comando As New SqlCommand("insert Into Cliente (Nombre, Apellido, DepartamentoID, MunicipioID) Values ('" & TextB_Nombre.Text & "', '" & TextB_Apellido.Text & "', '" & departamento & "', '" & municipio & "') ", conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Datos guardados con exito")
            MsgBox("Programa creado por Francisco Moreno y Hugo Ramirez")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try


    End Sub
End Class
