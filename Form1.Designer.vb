<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMinimaUnidad = New System.Windows.Forms.Label()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMinimaUnidad
        '
        Me.lblMinimaUnidad.AutoSize = True
        Me.lblMinimaUnidad.Location = New System.Drawing.Point(9, 47)
        Me.lblMinimaUnidad.Name = "lblMinimaUnidad"
        Me.lblMinimaUnidad.Size = New System.Drawing.Size(39, 13)
        Me.lblMinimaUnidad.TabIndex = 0
        Me.lblMinimaUnidad.Text = "Label1"
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(118, 12)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 1
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(12, 12)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtIngresar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIngresar)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.lblMinimaUnidad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMinimaUnidad As Label
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents txtIngresar As TextBox
End Class
