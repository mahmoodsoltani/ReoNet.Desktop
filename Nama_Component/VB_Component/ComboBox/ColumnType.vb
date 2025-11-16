Imports System
Imports System.Windows.Forms

Public Class ComboBoxColumn
    Inherits DataGridViewComboBoxColumn


    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a TimeCell.
            If (value IsNot Nothing) AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(ComboCell)) _
                Then
                Throw New InvalidCastException("Must be a ComboCell")
            End If
            MyBase.CellTemplate = value

        End Set
    End Property

End Class

Public Class ComboCell
    Inherits DataGridViewComboBoxCell

    Public Sub New()
        ' Use the short date format.
        ' Me.Style.Format = "d"
        Me.Value = ""
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
        ByVal initialFormattedValue As Object, _
        ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, _
            dataGridViewCellStyle)

        Dim ctl As ComboEditingControl = _
            CType(DataGridView.EditingControl, ComboEditingControl)
        ' Use the default row value when Value property is null.
        If (Me.Value Is Nothing Or Me.Value Is DBNull.Value) Then
            ctl.SelectedValue = CType(Me.DefaultNewRowValue, String)
        Else
            ctl.SelectedValue = CType(Me.Value, String)
        End If
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing control that TimeCell uses.
            Return GetType(ComboEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that TimeCell contains.
            Return GetType(String)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return -1
        End Get
    End Property

End Class

Class ComboEditingControl
    Inherits VB_Component.ComboBox
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer

    Public Sub New()
        'Me.Format = DateTimePickerFormat.Short

    End Sub

    Public Property EditingControlFormattedValue() As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue

        Get
            Return Me.SelectedValue
        End Get

        Set(ByVal value As Object)
            Try
                ' This will throw an exception of the string is 
                ' null, empty, or not in the format of a date.
                Me.SelectedValue = value
            Catch
                ' In the case of an exception, just use the default
                ' value so we're not left with a null value.
                Me.SelectedValue = -1
            End Try
        End Set

    End Property

    Public Function GetEditingControlFormattedValue(ByVal context _
        As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.SelectedValue

    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As  _
        DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

        Me.Font = dataGridViewCellStyle.Font
        'Me.TimeForeColor = dataGridViewCellStyle.ForeColor
        'Me.TimeMonthBackground = dataGridViewCellStyle.BackColor

    End Sub

    Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set

    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey

        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

                Return True

            Case Else
                Return Not dataGridViewWantsInputKey
        End Select

    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

        ' No preparation needs to be done.

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() _
        As Boolean Implements _
        IDataGridViewEditingControl.RepositionEditingControlOnValueChange

        Get
            Return False
        End Get

    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set

    End Property

    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged

        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set

    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor

        Get
            Return MyBase.Cursor
        End Get

    End Property


    'Public Overrides Sub NDU_Hour_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim i As Integer = 0
    '    i = i / i
    '    'MyBase.NDU_Hour_ValueChanged(sender, e)
    '    'Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
    '    'valueIsChanged = True
    'End Sub
    'Public Overrides Sub NDU_Second_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    MyBase.NDU_Second_ValueChanged(sender, e)
    '    Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
    '    valueIsChanged = True
    'End Sub
    'Public Overrides Sub NDU_Min_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    MyBase.NDU_Min_ValueChanged(sender, e)
    '    Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
    '    valueIsChanged = True
    'End Sub

    'Public Overrides (ByVal eventargs As EventArgs)

    '' Notify the DataGridView that the contents of the cell have changed.
    '    valueIsChanged = True
    '    Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
    '    MyBase.Finalize_Result ()

    'End Sub

End Class