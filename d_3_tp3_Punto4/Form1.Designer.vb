<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        dtvMatriz = New DataGridView()
        cmdEjecutar = New Button()
        lstVector = New ListBox()
        Label1 = New Label()
        CType(dtvMatriz, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvMatriz
        ' 
        dtvMatriz.AllowUserToAddRows = False
        dtvMatriz.AllowUserToDeleteRows = False
        dtvMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dtvMatriz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMatriz.ColumnHeadersVisible = False
        dtvMatriz.Location = New Point(12, 67)
        dtvMatriz.Name = "dtvMatriz"
        dtvMatriz.ReadOnly = True
        dtvMatriz.RowHeadersVisible = False
        dtvMatriz.RowHeadersWidth = 51
        dtvMatriz.Size = New Size(759, 324)
        dtvMatriz.TabIndex = 0
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 12)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(94, 29)
        cmdEjecutar.TabIndex = 1
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstVector
        ' 
        lstVector.FormattingEnabled = True
        lstVector.Location = New Point(777, 67)
        lstVector.Name = "lstVector"
        lstVector.Size = New Size(202, 324)
        lstVector.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 20)
        Label1.TabIndex = 3
        Label1.Text = "La Matriz ingresada al azar es:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1050, 450)
        Controls.Add(Label1)
        Controls.Add(lstVector)
        Controls.Add(cmdEjecutar)
        Controls.Add(dtvMatriz)
        Name = "Form1"
        Text = "Form1"
        CType(dtvMatriz, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtvMatriz As DataGridView
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lstVector As ListBox
    Friend WithEvents Label1 As Label

End Class
