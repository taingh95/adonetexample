Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports SimpleDataApp.My

Public Class FillOrCancel
    Private parsedOrderID As Integer

    Private Function IsOrderIDValid() As Boolean

        ' Check for input in the Order ID text box.  
        If _txtOrderId.Text = "" Then
            MessageBox.Show("Please specify the Order ID.")
            Return False

            ' Check for characters other than integers.  
        ElseIf Regex.IsMatch(_txtOrderId.Text, "^\D*$") Then
            ' Show message and clear input.  
            MessageBox.Show("Please specify integers only.")
            _txtOrderId.Clear()
            Return False
        Else
            ' Convert the text in the text box to an integer to send to the database.  
            parsedOrderID = Int32.Parse(_txtOrderId.Text)
            Return True
        End If
    End Function

    Private Sub _btnFindByOrderId_Click(sender As Object, e As EventArgs) Handles _btnFindByOrderId.Click
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=testDB;Trusted_Connection=True;"

        If IsOrderIDValid() Then
            Using connection As New SqlConnection(connectionString)
                Const sql As String = "select * from Sales.Orders where orderID = @orderID"

                Using sqlCommand As New SqlCommand(sql, connection)
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    Try
                        ' Open connection.  
                        connection.Open()

                        ' Execute the query.  
                        Dim dataReader As SqlDataReader = sqlCommand.ExecuteReader()

                        ' Create a data table to hold the retrieved data.  
                        Dim dataTable As New DataTable()

                        ' Load the data from SqlDataReader into the data table.  
                        dataTable.Load(dataReader)

                        ' Display the data from the data table in the data grid view.  
                        Me.dgvCustomerOrders.DataSource = dataTable

                        ' Close the SqlDataReader.  
                        dataReader.Close()
                    Catch
                        MessageBox.Show("The requested order could not be loaded into the form.")
                    Finally
                        ' Close the connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub _btnCancelOrder_Click(sender As Object, e As EventArgs) Handles _btnCancelOrder.Click
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=testDB;Trusted_Connection=True;"

        ' Set up and run the stored procedure only if OrderID is ready.  
        If IsOrderIDValid() Then

            ' Create the connection. 
            Using connection As New SqlConnection(connectionString)

                ' Create the command and identify it as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspCancelOrder", connection)
                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add input parameter for the stored procedure.  
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    Try
                        ' Open the connection.  
                        connection.Open()

                        ' Run the SqlCommand.  
                        sqlCommand.ExecuteNonQuery()
                    Catch
                        ' A simple catch.  
                        MessageBox.Show("The cancel operation was not completed.")
                    Finally
                        ' Close connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub _btnFillOrder_Click(sender As Object, e As EventArgs) Handles _btnFillOrder.Click
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=testDB;Trusted_Connection=True;"

        If IsOrderIDValid() Then
            ' Create the connection. 
            Using connection As New SqlConnection(connectionString)

                ' Create command and identify it as a stored procedure.  
                Using sqlCommand As New SqlCommand("Sales.uspFillOrder", connection)

                    sqlCommand.CommandType = CommandType.StoredProcedure

                    ' Add input parameter for the stored procedure.  
                    sqlCommand.Parameters.Add(New SqlParameter("@orderID", SqlDbType.Int))
                    sqlCommand.Parameters("@orderID").Value = parsedOrderID

                    ' Add second input parameter.  
                    sqlCommand.Parameters.Add(New SqlParameter("@FilledDate", SqlDbType.DateTime, 8))
                    sqlCommand.Parameters("@FilledDate").Value = _dtpFillDate.Value

                    Try
                        ' Open the connection.  
                        connection.Open()

                        ' Run the SqlCommand.   
                        sqlCommand.ExecuteNonQuery()
                    Catch
                        ' A simple catch.  
                        MessageBox.Show("The fill operation was not completed.")
                    Finally
                        ' Close the connection.  
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub _btnFinishUpdates_Click(sender As Object, e As EventArgs) Handles _btnFinishUpdates.Click
        Me.Close()
    End Sub
End Class