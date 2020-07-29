Imports System.Data.SqlClient

Module modServerBridge

    Private msg As String = ""
    Private sQuery As String = ""

    'Item *
    Public Function unidGenerator(tbl As String) As Integer
        Dim result As Integer = 0
        sQuery = "SELECT COUNT(*) FROM " & tbl

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())

            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    result = oCommand.ExecuteScalar + 1
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function

    Public Function POSTItem(name As String) As String
        sQuery = "INSERT INTO EngrEquipment (unEngrEquipment, EngrEqptName, unAccountUser) VALUES (@unEngrEquipment, @EngrEqptName, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrEquipment", unidGenerator("EngrEquipment"))
                    oCommand.Parameters.AddWithValue("@EngrEqptName", name)
                    oCommand.Parameters.AddWithValue("@unAccountUser", "admin")
                    oCommand.ExecuteNonQuery()

                    msg = "Item has been added"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try

        End Using

        Return msg
    End Function

    Public Function GETItem() As List(Of cConstant)
        Dim result As New List(Of cConstant)
        sQuery = "SELECT idEngrEquipment, unEngrEquipment, EngrEqptName, unAccountUser FROM EngrEquipment"

        Using oConn As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConn.Open()
                Using oCmd As New SqlCommand(sQuery, oConn)
                    Dim oReader As SqlDataReader = oCmd.ExecuteReader

                    While oReader.Read
                        Dim c As New cConstant
                        c.idEngrEquipment = oReader("idEngrEquipment")
                        c.unEngrEquipment = oReader("unEngrEquipment")
                        c.EngrEqptName = oReader("EngrEqptName")

                        result.Add(c)
                    End While
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function

    Public Function UpdateItem(id As String, name As String) As String
        Dim result As String = ""
        sQuery = "UPDATE EngrEquipment
                  SET EngrEqptName = @EngrEqptName
                  WHERE idEngrEquipment = @idEngrEquipment"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipment", id)
                    oCommand.Parameters.AddWithValue("@EngrEqptName", name)

                    oCommand.ExecuteNonQuery()

                    result = "Item has been updated"
                End Using
            Catch ex As Exception
                result = ex.ToString
            End Try
        End Using

        Return result
    End Function
    '* Item 

    'Brand *
    Public Function POSTBrand(idEquip As Integer, name As String) As String
        sQuery = "INSERT INTO EngrEquipmentBrand (unEngrEquipmentBrand, idEngrEquipment, EEBName, unAccountUser) VALUES (@unEngrEquipmentBrand, @idEngrEquipment, @EEBName, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrEquipmentBrand", unidGenerator("EngrEquipmentBrand"))
                    oCommand.Parameters.AddWithValue("@idEngrEquipment", idEquip)
                    oCommand.Parameters.AddWithValue("@EEBName", name)
                    oCommand.Parameters.AddWithValue("@unAccountUser", "admin")

                    oCommand.ExecuteNonQuery()
                    msg = "Brand has been added"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return msg
    End Function

    Public Function GetBrand() As List(Of cConstant)
        Dim result As New List(Of cConstant)
        sQuery = "SELECT EngrEquipmentBrand.idEngrEquipmentBrand, EngrEquipmentBrand.unEngrEquipmentBrand, EngrEquipmentBrand.unEngrEquipmentBrand, EngrEquipmentBrand.idEngrEquipment, EngrEquipmentBrand.EEBName, EngrEquipment.EngrEqptName
                  FROM EngrEquipmentBrand
                  INNER JOIN EngrEquipment ON EngrEquipmentBrand.idEngrEquipment = EngrEquipment.idEngrEquipment"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    While oReader.Read
                        Dim c As New cConstant
                        c.idEngrEquipmentBrand = oReader("idEngrEquipmentBrand")
                        c.unEngrEquipmentBrand = oReader("unEngrEquipmentBrand")
                        c.EngrEqptName = oReader("EngrEqptName")
                        c.EEBName = oReader("EEBName")

                        result.Add(c)
                    End While
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return result
    End Function
    '* Brand
End Module
