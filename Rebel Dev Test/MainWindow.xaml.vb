'Written March 24th. 2019 by Samuel Heersink for the Rebel Developer Test
'This is a simple application that enables adding and removing key-value pairs to a collection and permits the exporting of these elements to XML.
Class RebelDevTest
    Private data As DataModel

    'Initialization method called on application load
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Initialize the data model
        data = New DataModel

        'Bind the controls to the data
        dgInput.ItemsSource = data.Inputs
        lvValues.ItemsSource = data.Values

        ' Add a blank element to the input field that can be edited by the user
        data.Inputs.Add(New Input(""))

        'Add some entries to the data field to start with
        data.Values.Add(New Entry("Lorem", "Ipsum"))
        data.Values.Add(New Entry("Sample", "Text"))
        data.Values.Add(New Entry("Super", "Smash Brothers"))

    End Sub

    'Add each selected element from the input box to the collection of values
    Private Sub BtnAdd_Click(sender As Object, e As RoutedEventArgs) Handles btnAdd.Click
        Dim toInsert = ""
        'Finish the current edit
        dgInput.CommitEdit()

        'For each selected element:
        For Each elem In dgInput.SelectedCells
            'Get the string stored in of the selected Input object
            toInsert = CType(elem.Item, Input).Contents

            'Use regex to make sure that the format is correct 
            Dim pattern As String = "[A-Za-z0-9]* *= *[A-Za-z0-9]*"
            Dim match As Text.RegularExpressions.Match = Text.RegularExpressions.Regex.Match(toInsert, pattern)
            If match.Success Then

                'Add the key value pair to the list of values
                Dim toInsertSplit = toInsert.Split("=")

                'Add the pair to the collection of values
                data.Values.Add(New Entry(toInsertSplit(0), toInsertSplit(1)))

                'Remove the entry that was added from the input box
                data.Inputs.Remove(CType(elem.Item, Input))

                'If this was the last element in the input field, add a blank and editable item
                If data.Inputs.Count = 0 Then
                    data.Inputs.Add(New Input(""))
                End If
            End If
        Next

    End Sub
    'Remove the selected element from the right column from the list of values, then add it back into the Input box in case it needs to be edited
    Private Sub BtnRemove_Click(sender As Object, e As RoutedEventArgs) Handles btnRemove.Click
        'Get the contents of the entry before removing it
        Dim entryToDelete = CType(lvValues.SelectedItem, Entry)
        Dim toReinsert = entryToDelete.Key + "=" + entryToDelete.Value

        'Remove the entry
        data.Values.Remove(CType(lvValues.SelectedItem, Entry))

        'Add the entry back to the Input box
        data.Inputs.Add(New Input(toReinsert))
    End Sub

    'Clear all the elements from the list of values 
    Private Sub BtnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        'Very simple, just clear the data element
        data.Values.Clear()
    End Sub

    'Export the elements in the list of values to XML
    Private Sub BtnExport_Click(sender As Object, e As RoutedEventArgs) Handles btnExport.Click
        'Serialize the contents of the Values object to XML
        Dim xmlSerializer As New Xml.Serialization.XmlSerializer(data.Values.GetType)

        Using writer As New IO.StreamWriter("output.xml")
            xmlSerializer.Serialize(writer, data.Values)
        End Using
    End Sub

    'Sort the list of elements in the list alphabetically by their keys
    Private Sub BtnSortKey_Click(sender As Object, e As RoutedEventArgs) Handles btnSortKey.Click
        'We sort in the listview instead of sorting the underlying data
        lvValues.Items.SortDescriptions.Clear()
        lvValues.Items.SortDescriptions.Add(New ComponentModel.SortDescription("Key", ComponentModel.ListSortDirection.Ascending))
    End Sub

    'Sort the list of elements in the list alphabetically by their values
    Private Sub BtnSortValue_Click(sender As Object, e As RoutedEventArgs) Handles btnSortValue.Click
        'We sort in the listview instead of sorting the underlying data
        lvValues.Items.SortDescriptions.Clear()
        lvValues.Items.SortDescriptions.Add(New ComponentModel.SortDescription("Value", ComponentModel.ListSortDirection.Ascending))
    End Sub

End Class

'The DataModel contains the observable data structures that will update the UI when data is changed
Class DataModel
    Public Property Inputs() As ObjectModel.ObservableCollection(Of Input)
    Public Property Values() As ObjectModel.ObservableCollection(Of Entry)

    'Initialization method
    Public Sub New()
        Inputs = New ObjectModel.ObservableCollection(Of Input)
        Values = New ObjectModel.ObservableCollection(Of Entry)
    End Sub
End Class

'A wrapper class for the input string to enable binding
Class Input
    Public Property Contents() As String
    Public Sub New(contents As String)
        Me.Contents = contents
    End Sub
End Class

'Simple tuple to contain entries that enables binding
Public Class Entry
    Public Property Key() As String
    Public Property Value() As String
    Public Sub New(key As String, value As String)
        Me.Key = key
        Me.Value = value
    End Sub

    'Blank constructor to enable serialization
    Public Sub New()
    End Sub
End Class