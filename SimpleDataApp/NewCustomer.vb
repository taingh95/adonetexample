Imports System.Data.SqlClient

Public Class NewCustomer

    Private parsedCustomerID As Integer
    Private orderID As Integer

    Private ReadOnly Property IsCustomerNameValid As Boolean
        Get
            If _txtCustomerName.Text = "" Then
                MsgBox("Please enter a name.")
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    Private Function IsOrderDataValid() As Boolean
        If _txtCustomerId.Text = "" Then
            MsgBox("Please create a customer account before placing order.")
        ElseIf (_numOrderAmount.Value < 1) Then
            MsgBox("Please specify an order amount.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearForm()
        _txtCustomerName.Clear()
        _txtCustomerId.Clear()
        _dtpOrderDate.Value = DateTime.Now()
        _numOrderAmount.Value = 0
        Me.parsedCustomerID = 0
    End Sub

    Private Sub _btnCreateAccount_Click(sender As Object, e As EventArgs) Handles _btnCreateAccount.Click
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=testDB;Trusted_Connection=True;"
        If IsCustomerNameValid() Then
            Using connection As New SqlConnection(connectionString)
                Using sqlCommand As New SqlCommand("Sales.uspNewCustomer", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure

                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerName", SqlDbType.NVarChar, 40))
                    sqlCommand.Parameters("@CustomerName").Value = _txtCustomerName.Text

                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
                    sqlCommand.Parameters("@CustomerID").Direction = ParameterDirection.Output

                    Try
                        connection.Open()

                        sqlCommand.ExecuteNonQuery()

                        Me.parsedCustomerID = CInt(sqlCommand.Parameters("@CustomerID").Value)

                        Me._txtCustomerId.Text = Convert.ToString(parsedCustomerID)
                    Catch ex As Exception
                        MsgBox("Customer ID was not returned. Account could not be created.")
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub _btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles _btnPlaceOrder.Click
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=testDB;Trusted_Connection=True;"
        If IsOrderDataValid() Then
            ' Create the connection.  
            Using connection As New SqlConnection(connectionString)

                ' Create SqlCommand and identify it as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspPlaceNewOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add the @CustomerID parameter, which was an output parameter from uspNewCustomer.  
                    sqlCommand.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int))
                    sqlCommand.Parameters("@CustomerID").Value = Me.parsedCustomerID

                    ' Add the @OrderDate parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@OrderDate", SqlDbType.DateTime, 8))
                    sqlCommand.Parameters("@OrderDate").Value = _dtpOrderDate.Value

                    ' Add the @Amount parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@Amount", SqlDbType.Int))
                    sqlCommand.Parameters("@Amount").Value = _numOrderAmount.Value

                    ' Add the @Status parameter. For a new order, the status is always O (open).  
                    sqlCommand.Parameters.Add(New SqlParameter("@Status", SqlDbType.[Char], 1))
                    sqlCommand.Parameters("@Status").Value = "O"

                    ' Add a return value parameter for the stored procedure, which is the orderID.  
                    sqlCommand.Parameters.Add(New SqlParameter("@RC", SqlDbType.Int))
                    sqlCommand.Parameters("@RC").Direction = ParameterDirection.ReturnValue

                    Try
                        ' Open connection.  
                        connection.Open()

                        ' Run the stored procedure.  
                        sqlCommand.ExecuteNonQuery()

                        ' Display the order number.  
                        Me.orderID = CInt(sqlCommand.Parameters("@RC").Value)
                        MessageBox.Show("Order number " & (Me.orderID).ToString & " has been submitted.")
                    Catch
                        ' A simple catch.  
                        MessageBox.Show("Order could  not be placed.")
                    Finally
                        ' Always close a connection after you finish using it,
                        ' so that it can be released to the connection pool.
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub _btnAddFinish_Click(sender As Object, e As EventArgs) Handles _btnAddFinish.Click
        Me.Close()
    End Sub

    Private Sub _btnAddAnotherAccount_Click(sender As Object, e As EventArgs) Handles _btnAddAnotherAccount.Click
        Me.ClearForm()
    End Sub
End Class