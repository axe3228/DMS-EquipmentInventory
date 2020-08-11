Imports System.Data.SqlClient

Module modServerBridge

    Private msg As String = ""
    Private sQuery As String = ""
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

    Public Function unidEqStockDataGenerator(control As Integer) As Integer
        Dim result As Integer = 0
        sQuery = "SELECT COUNT(*) FROM EngrEquipmentStockData WHERE idEngrEquipmentStockControl = " & control

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

    Public Function isEquipmentxBrandInUse(type As String, eq As String, brand As String) As Boolean
        Dim result As Boolean = False

        If type = "Equipment" Then
            sQuery = "SELECT COUNT(*) FROM EngrEquipmentStockData WHERE EESDEquipment = @EESDEquipment AND Status = 1"
        Else
            sQuery = "SELECT COUNT(*) FROM EngrEquipmentStockData WHERE EESDEquipment = @EESDEquipment AND EESDBrand = @EESDBrand AND Status = 1"
        End If


        Using oConnection As New SqlConnection(modGeneral.getConnectionString())

            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@EESDEquipment", eq)
                    If type <> "Equipment" Then
                        oCommand.Parameters.AddWithValue("@EESDBrand", brand)
                    End If

                    Dim count = oCommand.ExecuteScalar
                    If count > 0 Then result = True
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function

#Region "EQUIPMENT"
    Public Function POSTEquipment(name As String) As String
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

    Public Function GetEquipment() As List(Of cConstant)
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
                        c.EngrEquipmentName = oReader("EngrEqptName")

                        result.Add(c)
                    End While
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function

    Public Function UpdateEquipment(id As String, name As String) As String
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
#End Region

#Region "BRAND"
    Public Function POSTBrand(equipment As String, brand As String) As String
        sQuery = "INSERT INTO EngrEquipmentBrand (unEngrEquipmentBrand, EngrEquipmentName, EEBName, unAccountUser) VALUES (@unEngrEquipmentBrand, @EngrEquipmentName, @EEBName, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrEquipmentBrand", unidGenerator("EngrEquipmentBrand"))
                    oCommand.Parameters.AddWithValue("@EngrEquipmentName", equipment)
                    oCommand.Parameters.AddWithValue("@EEBName", brand)
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
        sQuery = "SELECT idEngrEquipmentBrand, unEngrEquipmentBrand, EngrEquipmentName, EEBName
                  FROM EngrEquipmentBrand
                  WHERE Status = 1"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    While oReader.Read
                        Dim c As New cConstant
                        c.idEngrEquipmentBrand = oReader("idEngrEquipmentBrand")
                        c.unEngrEquipmentBrand = oReader("unEngrEquipmentBrand")
                        c.EngrEquipmentName = oReader("EngrEquipmentName")
                        c.BrandName = oReader("EEBName")

                        result.Add(c)
                    End While
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return result
    End Function

    Public Function UpdateBrand(id As String, eq As String, brand As String) As String
        Dim result As String = ""
        sQuery = "UPDATE EngrEquipmentBrand
                  SET EngrEquipmentName = @EngrEquipmentName, EEBName = @EEBName
                  WHERE idEngrEquipmentBrand = @idEngrEquipmentBrand"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentBrand", id)
                    oCommand.Parameters.AddWithValue("@EngrEquipmentName", eq)
                    oCommand.Parameters.AddWithValue("@EEBName", brand)

                    oCommand.ExecuteNonQuery()

                    result = "Brand has been updated"
                End Using
            Catch ex As Exception
                result = ex.ToString
            End Try
        End Using

        Return result
    End Function

#End Region

#Region "Location"
    Public Function POSTLocation(name) As String
        sQuery = "INSERT INTO EngrLocations (unEngrLocation, elLocationName, unAccountUser) VALUES (@unEngrLocation, @elLocationName, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrLocation", unidGenerator("EngrLocations"))
                    oCommand.Parameters.AddWithValue("@elLocationName", name)
                    oCommand.Parameters.AddWithValue("@unAccountUser", "admin")
                    oCommand.ExecuteNonQuery()

                    msg = "Location has been added"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return msg
    End Function

    Public Function GetLocation() As List(Of cConstant)
        Dim result As New List(Of cConstant)
        sQuery = "SELECT idEngrLocation, unEngrLocation, elLocationName, unAccountUser FROM EngrLocations"

        Using oConn As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConn.Open()
                Using oCmd As New SqlCommand(sQuery, oConn)
                    Dim oReader As SqlDataReader = oCmd.ExecuteReader

                    While oReader.Read
                        Dim c As New cConstant
                        c.idEngrLocation = oReader("idEngrLocation")
                        c.unEngrLocation = oReader("unEngrLocation")
                        c.LocatioName = oReader("elLocationName")
                        c.unAccountUser = oReader("unAccountUser")

                        result.Add(c)
                    End While
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function

    Public Function UpdateLocation(id As String, name As String) As String
        Dim result As String = ""
        sQuery = "UPDATE EngrLocations
                  SET elLocationName = @elLocationName
                  WHERE idEngrLocation = @idEngrLocation"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrLocation", id)
                    oCommand.Parameters.AddWithValue("@elLocationName", name)

                    oCommand.ExecuteNonQuery()

                    result = "Location has been updated"
                End Using
            Catch ex As Exception
                result = ex.ToString
            End Try
        End Using

        Return result
    End Function
#End Region

#Region "Receiving"
    '- - - - - - - - - - Equipment Stock Cotrol - - - - - - - - - - -
    Public Function POSTEquipmentStockControl() As String
        sQuery = "INSERT INTO EngrEquipmentStockControl (unEngrEquipmentStockControl, EESCRemarks, unAccountUser) VALUES (@unEngrEquipmentStockControl, @EESCRemarks, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrEquipmentStockControl", unidGenerator("EngrEquipmentStockControl"))
                    oCommand.Parameters.AddWithValue("@EESCRemarks", " ")
                    oCommand.Parameters.AddWithValue("@unAccountUser", "admin")
                    oCommand.ExecuteNonQuery()

                    msg = "Location has been added"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return msg
    End Function

    Public Function GetStockControl() As List(Of cEquipmentStockControl)
        Dim result As New List(Of cEquipmentStockControl)
        sQuery = "SELECT idEngrEquipmentStockControl, unEngrEquipmentStockControl, EESCRemarks, EESCState, TimeStamp FROM EngrEquipmentStockControl"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            oConnection.Open()
            Using oCommand As New SqlCommand(sQuery, oConnection)
                Dim oReader As SqlDataReader = oCommand.ExecuteReader

                While oReader.Read
                    Dim c As New cEquipmentStockControl
                    c.idEngrEquipmentStockControl = oReader("idEngrEquipmentStockControl")
                    c.unEngrEquipmentStockControl = oReader("unEngrEquipmentStockControl")
                    c.EESCRemarks = oReader("EESCRemarks")
                    c.EESCState = oReader("EESCState")
                    c.TimeStamp = oReader("TimeStamp")

                    result.Add(c)
                End While
            End Using
        End Using

        Return result
    End Function

    Public Function UpdateStockControl(_class As cEquipmentStockControl) As String
        sQuery = "UPDATE EngrEquipmentStockControl SET EESCRemarks = @EESCRemarks WHERE idEngrEquipmentStockControl = @idEngrEquipmentStockControl"
        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockControl", _class.idEngrEquipmentStockControl)
                    oCommand.Parameters.AddWithValue("@EESCRemarks", _class.EESCRemarks)

                    oCommand.ExecuteNonQuery()

                    msg = "Document Control has been save."
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using
        Return msg
    End Function

    Public Function CloseStockControl(id As Integer) As String
        sQuery = "UPDATE EngrEquipmentStockControl SET EESCState = 'Close' WHERE idEngrEquipmentStockControl = @idEngrEquipmentStockControl"
        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockControl", id)

                    oCommand.ExecuteNonQuery()

                    msg = "Document Control has been closed"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using
        Return msg
    End Function

    Public Sub AutoCloseStockControl()
        Dim id As Integer = 0
        sQuery = "SELECT MAX(idEngrEquipmentStockControl) FROM EngrEquipmentStockControl"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())

            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    id = oCommand.ExecuteScalar
                    If id <> 0 Then CloseStockControl(id)
                End Using
            Catch ex As Exception

            End Try
        End Using
    End Sub

    '- - - - - - - - - - Equipment Stock Data - - - - - - - - - - -
    Public Function POSTEquipmentStockData(_class As cEquipmentStockData) As String
        sQuery = "INSERT INTO EngrEquipmentStockData (unEngrEquipmentStockData, idEngrEquipmentStockControl, EESDEquipment, EESDBrand, EESDSerial, EESDModel, unAccountUser) 
                  VALUES (@unEngrEquipmentStockData, @idEngrEquipmentStockControl, @EESDEquipment, @EESDBrand, @EESDSerial, @EESDModel, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrEquipmentStockData", unidEqStockDataGenerator(_class.idEngrEquipmentStockControl))
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockControl", _class.idEngrEquipmentStockControl)
                    oCommand.Parameters.AddWithValue("@EESDEquipment", _class.EESDEquipment)
                    oCommand.Parameters.AddWithValue("@EESDBrand", _class.EESDBrand)
                    oCommand.Parameters.AddWithValue("@EESDSerial", _class.EESDSerial)
                    oCommand.Parameters.AddWithValue("@EESDModel", _class.EESDModel)
                    oCommand.Parameters.AddWithValue("@unAccountUser", "admin")

                    oCommand.ExecuteNonQuery()
                    msg = "Equipment has been receive"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return msg
    End Function

    Public Function GetStockData(id As Integer) As List(Of cEquipmentStockData)
        Dim result As New List(Of cEquipmentStockData)

        If id <> 0 Then
            sQuery = "SELECT idEngrEquipmentStockData, unEngrEquipmentStockData, idEngrEquipmentStockControl, EESDEquipment, EESDBrand, EESDSerial, EESDModel, EESDState, EESDLocation
                 FROM EngrEquipmentStockData WHERE idEngrEquipmentStockControl = @idEngrEquipmentStockControl"
        Else
            sQuery = "SELECT idEngrEquipmentStockData, unEngrEquipmentStockData, idEngrEquipmentStockControl, EESDEquipment, EESDBrand, EESDSerial, EESDModel, EESDState, EESDLocation 
                 FROM EngrEquipmentStockData"
        End If


        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            oConnection.Open()
            Using oCommand As New SqlCommand(sQuery, oConnection)
                oCommand.Parameters.AddWithValue("idEngrEquipmentStockControl", id)
                oCommand.ExecuteNonQuery()

                Dim oReader As SqlDataReader = oCommand.ExecuteReader
                While oReader.Read
                    Dim c As New cEquipmentStockData
                    c.idEngrEquipmentStockData = oReader("idEngrEquipmentStockData")
                    c.unEngrEquipmentStockData = oReader("unEngrEquipmentStockData")
                    c.idEngrEquipmentStockControl = oReader("idEngrEquipmentStockControl")
                    c.EESDEquipment = oReader("EESDEquipment")
                    c.EESDBrand = oReader("EESDBrand")
                    c.EESDSerial = oReader("EESDSerial")
                    c.EESDModel = oReader("EESDModel")
                    c.EESDState = oReader("EESDState")
                    c.EESDLocation = oReader("EESDLocation")

                    If id = 0 Then
                        c.eqnamexbrandname = oReader("EESDEquipment") & " - " & oReader("EESDBrand")
                        c.eqnamexbrandnamexstate = oReader("EESDEquipment") & " - " & oReader("EESDBrand") & " - " & oReader("EESDState")
                        c.eqnamexbrandnamexlocation = oReader("EESDEquipment") & " - " & oReader("EESDBrand") & " - " & oReader("EESDLocation")
                    End If

                    result.Add(c)
                End While
            End Using
        End Using

        Return result
    End Function

    Public Function UpdateStockData(id As Integer, location As String, state As String) As Boolean
        Dim result = False

        sQuery = "UPDATE EngrEquipmentStockData SET EESDLocation = @EESDLocation, EESDState = @EESDState WHERE idEngrEquipmentStockData = @idEngrEquipmentStockData"
        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockData", id)
                    oCommand.Parameters.AddWithValue("@EESDLocation", location)
                    oCommand.Parameters.AddWithValue("@EESDState", state)

                    oCommand.ExecuteNonQuery()

                    result = True
                End Using
            Catch ex As Exception
                result = False
            End Try
        End Using

        Return result
    End Function

    Public Function UpdateStockDataEqDetails(_class As cEquipmentStockData) As String
        Dim result = ""

        sQuery = "UPDATE EngrEquipmentStockData 
                  SET EESDEquipment = @EESDEquipment, EESDBrand = @EESDBrand, EESDSerial = @EESDSerial, EESDModel = @EESDModel 
                  WHERE idEngrEquipmentStockData = @idEngrEquipmentStockData"
        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockData", _class.idEngrEquipmentStockData)
                    oCommand.Parameters.AddWithValue("@EESDEquipment", _class.EESDEquipment)
                    oCommand.Parameters.AddWithValue("@EESDBrand", _class.EESDBrand)
                    oCommand.Parameters.AddWithValue("@EESDSerial", _class.EESDSerial)
                    oCommand.Parameters.AddWithValue("@EESDModel", _class.EESDModel)

                    oCommand.ExecuteNonQuery()

                    result = "Stock Data has been updated"
                End Using
            Catch ex As Exception
                result = ex.ToString
            End Try
        End Using

        Return Result
    End Function

#End Region

#Region "Deployment"
    Public Function POSTDeployment(_class As cDeployment) As String
        sQuery = "INSERT INTO EngrEquipmentDeployment (unEngrEquipmentDeployment, idEngrEquipmentStockData, EEDLocation, EESDEquipment, EESDBrand, EESDSerial, EESDModel, DeploymentDate, unAccountUser) 
                  VALUES (@unEngrEquipmentDeployment, @idEngrEquipmentStockData, @EEDLocation, @EESDEquipment, @EESDBrand, @EESDSerial, @EESDModel, @DeploymentDate, @unAccountUser)"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@unEngrEquipmentDeployment", unidGenerator("EngrEquipmentDeployment"))
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockData", _class.idEngrEquipmentStockData)
                    oCommand.Parameters.AddWithValue("@EEDLocation", _class.EEDLocation)
                    oCommand.Parameters.AddWithValue("@EESDEquipment", _class.EESDEquipment)
                    oCommand.Parameters.AddWithValue("@EESDBrand", _class.EESDBrand)
                    oCommand.Parameters.AddWithValue("@EESDSerial", _class.EESDSerial)
                    oCommand.Parameters.AddWithValue("@EESDModel", _class.EESDModel)
                    oCommand.Parameters.AddWithValue("@DeploymentDate", _class.DeploymentDate)
                    oCommand.Parameters.AddWithValue("@unAccountUser", "admin")

                    oCommand.ExecuteNonQuery()

                    msg = "Equipment has been deployed"
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return msg
    End Function

    Public Function GetDeployedEquipments(location As String) As List(Of cDeployment)
        Dim result As New List(Of cDeployment)

        sQuery = "SELECT idEngrEquipmentDeployment, unEngrEquipmentDeployment, idEngrEquipmentStockData, EEDLocation, EESDEquipment, EESDBrand, EESDSerial, EESDModel, DeploymentDate, unAccountUser
                 FROM EngrEquipmentDeployment
                 WHERE EEDLocation = @EEDLocation AND Status = 1"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString)
            oConnection.Open()

            Using oCommand As New SqlCommand(sQuery, oConnection)
                oCommand.Parameters.AddWithValue("@EEDLocation", location)
                oCommand.ExecuteNonQuery()

                Dim oReader As SqlDataReader = oCommand.ExecuteReader
                While oReader.Read
                    Dim c As New cDeployment
                    c.idDeployment = oReader("idEngrEquipmentDeployment")
                    c.unDeployment = oReader("unEngrEquipmentDeployment")
                    c.idEngrEquipmentStockData = oReader("idEngrEquipmentStockData")
                    c.EEDLocation = oReader("EEDLocation")
                    c.EESDEquipment = oReader("EESDEquipment")
                    c.EESDBrand = oReader("EESDBrand")
                    c.EESDSerial = oReader("EESDSerial")
                    c.EESDModel = oReader("EESDModel")
                    c.DeploymentDate = oReader("DeploymentDate")

                    result.Add(c)
                End While
            End Using
        End Using

        Return result
    End Function

    Public Function UpdateDeploymentStatus(id As Integer, status As Integer, remark As String, message As String) As String
        sQuery = "UPDATE EngrEquipmentDeployment
                  SET Status = @Status, EESDRemarks = @EESDRemarks
                  WHERE idEngrEquipmentDeployment = @idEngrEquipmentDeployment"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@Status", status)
                    oCommand.Parameters.AddWithValue("@EESDRemarks", remark)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentDeployment", id)

                    oCommand.ExecuteNonQuery()
                    msg = message
                End Using
            Catch ex As Exception
                msg = ex.ToString
            End Try
        End Using

        Return msg
    End Function

    Public Function isEquipmentExist(id As Integer, location As String) As Boolean
        Dim result As Boolean = False
        sQuery = "SELECT COUNT(*) FROM EngrEquipmentDeployment WHERE idEngrEquipmentStockData = @idEngrEquipmentStockData AND EEDLocation = @EEDLocation"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())

            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@idEngrEquipmentStockData", id)
                    oCommand.Parameters.AddWithValue("@EEDLocation", location)
                    'oCommand.ExecuteNonQuery()

                    Dim i = oCommand.ExecuteScalar
                    If i <> 0 Then result = True
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function

    Public Function DeployedEqCounter(location As String) As Integer
        Dim result = 0
        sQuery = "SELECT COUNT(*) FROM EngrEquipmentDeployment WHERE EEDLocation = @EEDLocation AND Status = 1"

        Using oConnection As New SqlConnection(modGeneral.getConnectionString())

            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@EEDLocation", location)
                    'oCommand.ExecuteNonQuery()

                    result = oCommand.ExecuteScalar
                End Using
            Catch ex As Exception

            End Try
        End Using

        Return result
    End Function
#End Region

End Module
