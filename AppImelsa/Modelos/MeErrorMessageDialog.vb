﻿Module MeErrorMessageDialog

    Public Sub ErrorMessage(ByVal CodeError As String)

        Dim Message As String = ""
        Select Case CodeError
            Case "Error-T01"
                Message = "Error, Para Guardar un nuevo dato debe rellenar todos los campos obligatorios"
            Case "Error-T02"
                Message = "Insercion de Datos de Turno Erronea! "
            Case "Error-T03"
                Message = "Error, Eliminación de Datos de Turno Erronea!"
            Case "Eror-T04"
                Message = "Error, Actualización de Datos de Turno Erronea!"
            Case "Error-C01"
                Message = "Error, Para Guardar un nuevo dato debe rellenar todos los campos obligatorios"
            Case "Error-C02"
                Message = "Insercion de Datos de Cargo Erronea! "
            Case "Error-C03"
                Message = "Error, Eliminación de Datos de Cargo Erronea!"
            Case "Error-C04"
                Message = "Error, Actualización de Datos de Cargo Erronea!"
            Case "Error-S01"
                Message = "Error, Para Guardar un nuevo dato debe rellenar todos los campos obligatorios"
            Case "Error-S02"
                Message = "Insercion de Datos de Salario Erronea! "
            Case "Error-S03"
                Message = "Error, Eliminación de Datos de Salario Erronea!"
            Case "Eror-S04"
                Message = "Error, Actualización de Datos de Salario Erronea!"
            Case "Error-L01"
                Message = "Error, No se logro cargar turnos"
            Case "Error-L02"
                Message = "Error, No se logro cargar Cargos"
            Case "Error-L03"
                Message = "Error, No se logro cargar Salarios"
            Case "Error-L04"
                Message = "Error, No se logro cargar Proyectos"
            Case "Error-Ph01"
                Message = "Error, El Numero de Telefono se ha detectado como invalido"
            Case "Error-Em01"
                Message = "Error, La Dirección de Correo Electronico se ha detectado como invalida"
            Case "Error-E01"
                Message = "Error, Debe Rellenar todos los campos Obligatorios"
            Case "Error-E02"
                Message = "Error, Inserción de Datos de Empleado Erronea"
            Case "Error-E03"
                Message = "Error, Eliminación de Datos de Empleado Erronea"
            Case "Error-CL01"
                Message = "Error, Para Guardar un nuevo dato debe rellenar todos los campos obligatorios"
            Case "Error-CL02"
                Message = "Insercion de Datos de Cliente Erronea! "
            Case "Error-CL03"
                Message = "Error, Eliminación de Datos de Cliente Erronea!"
            Case "Error-P03"
                Message = "Error, Eliminación de Datos de Proyecto Erronea!"
        End Select

        MsgBox(Message, MsgBoxStyle.Exclamation)

    End Sub

End Module
