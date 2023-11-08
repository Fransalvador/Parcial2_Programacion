<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboB_Municipio = New ComboBox()
        ComboB_Departamento = New ComboBox()
        Button_Aceptar = New Button()
        TextB_Nombre = New TextBox()
        TextB_Apellido = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' ComboB_Municipio
        ' 
        ComboB_Municipio.FormattingEnabled = True
        ComboB_Municipio.Items.AddRange(New Object() {"San Salvador", "Santa Tecla", "Soyapango", "San Miguel", "Moncagua", "Quelepa", "Antiguo Cuscatlan", "Colon", "La Libertad", "Santa Ana", "Metapan", "Chalchuapa"})
        ComboB_Municipio.Location = New Point(77, 244)
        ComboB_Municipio.Name = "ComboB_Municipio"
        ComboB_Municipio.Size = New Size(210, 23)
        ComboB_Municipio.TabIndex = 0
        ComboB_Municipio.Text = "Selecciones..."
        ' 
        ' ComboB_Departamento
        ' 
        ComboB_Departamento.FormattingEnabled = True
        ComboB_Departamento.Items.AddRange(New Object() {"San Salvador", "San Miguel", "La Libertad", "Santa Ana"})
        ComboB_Departamento.Location = New Point(77, 326)
        ComboB_Departamento.Name = "ComboB_Departamento"
        ComboB_Departamento.Size = New Size(210, 23)
        ComboB_Departamento.TabIndex = 1
        ComboB_Departamento.Text = "Seleccione..."
        ' 
        ' Button_Aceptar
        ' 
        Button_Aceptar.Location = New Point(145, 398)
        Button_Aceptar.Name = "Button_Aceptar"
        Button_Aceptar.RightToLeft = RightToLeft.No
        Button_Aceptar.Size = New Size(75, 23)
        Button_Aceptar.TabIndex = 2
        Button_Aceptar.Text = "Aceptar"
        Button_Aceptar.UseVisualStyleBackColor = True
        ' 
        ' TextB_Nombre
        ' 
        TextB_Nombre.Location = New Point(77, 97)
        TextB_Nombre.Name = "TextB_Nombre"
        TextB_Nombre.Size = New Size(210, 23)
        TextB_Nombre.TabIndex = 3
        ' 
        ' TextB_Apellido
        ' 
        TextB_Apellido.Location = New Point(77, 170)
        TextB_Apellido.Name = "TextB_Apellido"
        TextB_Apellido.Size = New Size(210, 23)
        TextB_Apellido.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(77, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 5
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(77, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 25)
        Label3.TabIndex = 7
        Label3.Text = "Parcial 2 - Programacion 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 8
        Label4.Text = "Municipio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(77, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 9
        Label5.Text = "Departamento"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(404, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextB_Apellido)
        Controls.Add(TextB_Nombre)
        Controls.Add(Button_Aceptar)
        Controls.Add(ComboB_Departamento)
        Controls.Add(ComboB_Municipio)
        Name = "Form1"
        Text = "Parcial 2 - Programacion 2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboB_Municipio As ComboBox
    Friend WithEvents ComboB_Departamento As ComboBox
    Friend WithEvents Button_Aceptar As Button
    Friend WithEvents TextB_Nombre As TextBox
    Friend WithEvents TextB_Apellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
