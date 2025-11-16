Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data

Public Class DataBase

#Region "Message_Exeption"
    Public Shared Function Message_Exeption(ByVal ex As Exception) As Boolean
        Try
            Select Case DirectCast(ex, System.Data.SqlClient.SqlException).Number
                Case 17 Or 17142 Or 11
                    MessageBox.Show("The connection to the database has been lost", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Message_Exeption = True
                Case 547
                    MessageBox.Show("This data cannot be deleted because it is being used in another part of the system", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Message_Exeption = True
                Case 2627
                    MessageBox.Show("This code has already been registered", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Message_Exeption = True
                Case Else
                    MessageBox.Show(ex.ToString() + "Please contact your system administrator" + vbNewLine, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Message_Exeption = False
            End Select
        Catch
        End Try
    End Function
#End Region

#Region "GetSrl"
    Public Shared Function GetSrl(ByVal dg As System.Windows.Forms.DataGridView) As String
        Dim str As New String("")
        Try
            str = dg.CurrentRow.Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("Please select a row from the table")
            Return "-1"
        End Try
        Return str
    End Function
#End Region

    Public Shared Function DataTable_SumOfRows(ByVal dg As DataTable _
                                                    , ByVal IndexToFilter As Integer _
                                                    , ByVal IndexToReturn As Integer _
                                                    , ByVal ParamArray ValuesToFilter() As Integer) As Object
        Dim result As Double = 0
        Try
            For Each dtg As DataRow In dg.Rows
                If ValuesToFilter.Contains(DirectCast(dtg(IndexToFilter), Double)) Then
                    result += DirectCast(dtg(IndexToFilter), Double)
                End If
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            Return 0
        End Try

        Return result
    End Function

    Public Shared Function DataTable_SumOfRow(ByVal dt As DataTable, ByVal index As Integer) As Double
        Dim result As Double = 0
        Try
            For Each dtg As DataRow In dt.Rows
                result += DirectCast(dtg(index), Double)
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            Return 0
        End Try

        Return result
    End Function

    Public Shared Function DataGrideView_SumOfRow(ByVal dg As DataGridView, ByVal index As Integer) As Double
        Dim result As Double = 0
        Try
            For Each dtg As DataGridViewRow In dg.Rows
                result += DirectCast(dtg.Cells(index).Value, Double)
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            Return 0
        End Try

        Return result
    End Function

    Public Shared Function DataGrideView_SumOfRow(ByVal dg As DataGridView _
                                                    , ByVal index As Integer _
                                                    , ByVal IndexToFilter As Integer _
                                                    , ByVal ValueToFilter As Integer) As Double
        Dim result As Double = 0
        Try
            For Each dtg As DataGridViewRow In dg.Rows
                If dtg.Cells(IndexToFilter).Value = ValueToFilter Then
                    result += DirectCast(dtg.Cells(index).Value, Double)
                End If
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            Return 0
        End Try

        Return result
    End Function

    Public Shared Function DataTable_Filter(ByVal dt As DataTable _
                                                    , ByVal IndexToFilter As Integer _
                                                    , ByVal ValueToFilter As Object) As DataView
        Dim dv As New DataView(dt)

        If (dt.Columns(IndexToFilter).DataType.ToString().Equals("System.String")) Then
            dv.RowFilter = "[" + dv.Table.Columns(IndexToFilter).ColumnName + "] like '%" + ValueToFilter.ToString + "%'"
        Else
            If ValueToFilter = "" Then
                dv.RowFilter = ""
            Else
                dv.RowFilter = "[" + dv.Table.Columns(IndexToFilter).ColumnName + "] >= " + Double.Parse(ValueToFilter.ToString)
            End If
        End If
        Return dv
    End Function

    Public Shared Function DataGridView_Search(ByVal dg As DataGridView _
                                                , ByVal IndexToFilter As Integer _
                                                , ByVal ValueToFilter As Object) As Boolean
        Try
            For Each dtg As DataGridViewRow In dg.Rows
                If dtg.Cells(IndexToFilter).Value = ValueToFilter Then
                    Return True
                End If
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Shared Function DataGridView_GetScalerValue(ByVal dg As DataGridView _
                                                    , ByVal IndexToFilter As Integer _
                                                    , ByVal ValueToFilter As Object _
                                                    , ByVal IndexToReturn As Integer) As Object
        Try
            For Each dtg As DataGridViewRow In dg.Rows
                If dtg.Cells(IndexToFilter).Value = ValueToFilter Then
                    Return dtg.Cells(IndexToReturn).Value
                End If
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            Return 0
        End Try

        Return 0
    End Function

    Public Shared Function getConnection(Optional ByVal line As Integer = 0, Optional ByVal FileAddress As String = "\ConStr.Con") As String
        Dim connectionstring As String = ""
        Try
            Dim i As Integer = 0
            Dim st As New StreamReader((Application.StartupPath & FileAddress))
            i = 0
            Do While (i <= line)
                connectionstring = st.ReadLine
                i += 1
            Loop
        Catch ee As Exception
            MessageBox.Show("The system is unable to read the server connection file. Please contact your system administrator." + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
        Return connectionstring
    End Function

    Public Shared Function Restore(ByVal ConnectionString As String, ByVal database As String, ByVal FilePath As String) As Boolean
        Dim flag As Boolean = False
        Dim connection As New SqlConnection(ConnectionString)
        Dim command As New SqlCommand
        command.Connection = connection
        connection.Open()

        Try
            Try
                command.CommandText = "use master"
                command.CommandText += " alter database " + database & " set single_user with rollback immediate "
                command.CommandText += " Restore DataBase " + database + " from disk ='" + FilePath + "' "
                command.CommandText += " WITH Replace"
                command.CommandText += " alter database " + database + " set multi_user"
                command.ExecuteNonQuery()
                flag = True
            Catch exception As SqlException
                flag = False
            End Try
        Finally
            connection.Close()
        End Try
        Return flag
    End Function

    Public Shared Function BackUp(ByVal ConnectionString As String, ByVal database As String, ByVal FilePath As String) As Boolean
        Dim sqc As New SqlClient.SqlConnection(ConnectionString)
        Dim cmd As New SqlClient.SqlCommand("BACKUP DATABASE " + database + " TO DISK = '" + FilePath + "'", sqc)
        cmd.CommandTimeout = 100000
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            MessageBoxFa.Show("Database backup completed successfully")
        Catch ex As Exception
            MessageBoxFa.Show("The system is unable to back up the database files")
        End Try
    End Function
End Class
