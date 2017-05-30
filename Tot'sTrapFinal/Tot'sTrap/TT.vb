Option Explicit On
Imports System.IO
Imports System.Drawing.Printing

Public Class frmTT 'MY PRESENTATION LAYER (1st tier)
    'Only the code to do with the user interface is here. I am accessing the logic in my TTServices class by initialising objects of that class

    Structure TWordTable
        Dim Word As String
        Dim Definiton As String
        Dim KeywordsAsStructure As String
    End Structure

    Dim WordTable As TWordTable
    Dim CurrentFileWriter As BinaryWriter
    Dim CurrentFileReader As BinaryReader
    Dim CurrentFileWriterStream, CurrentFileReaderStream As FileStream
    Dim Keywords(12) As String
    Dim KeywordNo As Integer
    Dim KeywordsAsOneString As String 'Varible that coverts the keywords stored as arrays into a single string of keywords so that it can be stored in the file

    Dim fileLines() As String = New String() {}
    Dim FileName As String = "TotsTrapTable.txt"

    WithEvents docToPrint As New PrintDocument

    Private Sub frmTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim serviceObject As TTServices = New TTServices()

        Dim comboWords = serviceObject.GetWordList(FileName)
        CType(comboWords, List(Of String)).Insert(0, "Select word to edit") 'to fire index change event when word is selected      
        cmbWordEdit.DataSource = comboWords  'get's all the words from wordlist (my datasource)

        Dim wordListForListBox = serviceObject.GetWordList(FileName)  'reusing my datasource

        lstOngoingKeywords.DataSource = wordListForListBox
        lblKeywordTotal.Text = wordListForListBox.Count & " words"


    End Sub

    Private Sub txtNewWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewWord.Click
        txtNewWord.Text = ""
    End Sub


    Private Sub txtNewWord_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewWord.Leave
        If txtNewWord.Text = "" Then txtNewWord.Text = "type new word here "
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        WordTable.Word = Me.txtNewWord.Text
        WordTable.Definiton = Me.txtNewDefinition.Text


        Keywords(1) = Me.txtKeyWord1.Text
        Keywords(2) = Me.txtKeyWord2.Text
        Keywords(3) = Me.txtKeyWord3.Text
        Keywords(4) = Me.txtKeyWord4.Text
        Keywords(5) = Me.txtKeyWord5.Text
        Keywords(6) = Me.txtKeyWord6.Text
        Keywords(7) = Me.txtKeyWord7.Text
        Keywords(8) = Me.txtKeyWord8.Text
        Keywords(9) = Me.txtKeyWord9.Text
        Keywords(10) = Me.txtKeyWord10.Text
        Keywords(11) = Me.txtKeyWord11.Text
        Keywords(12) = Me.txtKeyWord12.Text


        For count = 1 To 12
            KeywordsAsOneString += Keywords(count) & "~"
        Next

        WordTable.KeywordsAsStructure = KeywordsAsOneString
        'Via instansiation I have defined the object "serviccesObject" that belongs to class "TTServices"
        'Through this object, I now have access to all the methods of that class
        'In this case I shall be picking the method 'SaveWordRecord' to simply save my record. 
        Dim servicesObject As TTServices = New TTServices()

        If txtNewWord.Text = "type new word" Or txtNewWord.Text = "" Then
            MessageBox.Show("Please enter a word")
            Return
        End If

        Try
            servicesObject.SaveWordRecord(FileName, Me.txtNewWord.Text, Me.txtNewDefinition.Text, KeywordsAsOneString, picNewPicture.Image)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'resets all the values in the 'Add' tab
        txtNewWord.Text = "type new word"
        txtNewDefinition.Text = String.Empty
        For Each textbox As Control In pnlKeywords.Controls 'for any control in this FlowLayoutPanel 
            textbox.Text = String.Empty
        Next

        txtPicureName.Text = String.Empty
        picNewPicture.Image = Nothing
        frmTT_Load(Me, New System.EventArgs) 'By doing this, newly added words can be searched/edited immediately without having to close and reopen the form

    End Sub


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Dim searchWord As String = LTrim(RTrim(txtSearch.Text))
        Dim foundForm As Found = New Found()
        foundForm.lblSearchWord.Text = "No Match Found"

        For count = 0 To fileLines.Length - 1

            Dim wordSubString() As String = fileLines(count).Split("|")

            If wordSubString.Length > 2 Then

                If wordSubString(0).ToUpper().Contains(searchWord.ToUpper()) Or wordSubString(1).ToUpper().Contains(searchWord.ToUpper()) Or wordSubString(2).ToUpper().Contains(searchWord.ToUpper()) Then
                    Dim word As String = wordSubString(0)
                    Dim definition As String = wordSubString(1)

                    KeywordsAsOneString = wordSubString(2)

                    Dim linklabel As LinkLabel = New LinkLabel()

                    linklabel.Text = word

                    'the sought word(s) has/have been found, the label must be turned into a hyperlink to that the user can be- 
                    'directed to a form that shows the defintion and keywords that belong to this word-
                    'therefore a click event must be handeled when the sought word is clicked to take the user there:
                    Dim link As LinkLabel.Link = New LinkLabel.Link()

                    link.LinkData = definition & "|" & KeywordsAsOneString
                    linklabel.Links.Add(link)

                    foundForm.lblSearchWord.Text = searchWord
                    AddHandler linklabel.LinkClicked, AddressOf linklabel_LinkClicked
                    foundForm.flowPnlFound.Controls.Add(linklabel)
                End If
            End If
        Next
        foundForm.Show()

    End Sub

    'any handler function signature (parameters its taking and passing) will have a 1) sender object: fires the event-
    '2)event args object that carries data (Control+EventName+EventArgs)
    Private Sub linklabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
        Dim displayForm As Display = New Display()
        Dim foundWord As String = CType(sender, LinkLabel).Text

        displayForm.lblWord.Text = foundWord
        Dim defAndKeywords As String() = e.Link.LinkData.ToString().Split("|")
        displayForm.lblDefinition.Text = defAndKeywords(0)
        Dim keywordsAsArray As String() = defAndKeywords(1).Split("~")

        Dim imagePath As String = New TTServices().GetImagePath()
        imagePath = imagePath & foundWord & ".jpg"

        If File.Exists(imagePath) Then
            displayForm.picDisplay.Image = Image.FromFile(imagePath)
        End If


        For count = 0 To keywordsAsArray.Length - 1
            Dim lbl As Label = New Label()
            'links
            lbl.Text = keywordsAsArray(count)
            displayForm.FlowPnlKeywords.Controls.Add(lbl)

        Next
        displayForm.Show()
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then txtSearch.Text = "Enter any words associated with the word you're looking for..."
    End Sub


    'Selected index change is a combo box event that is fired when user selects a different element from it 
    Private Sub cmbWordEdit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWordEdit.SelectedIndexChanged

        Dim selectedWord As String = CType(sender, ComboBox).SelectedValue
        Dim searchWord As String = txtSearch.Text
        flowPanelKeywords.Controls.Clear()

        fileLines = New TTServices().GetFileLines(FileName)
        For count = 0 To fileLines.Length - 1

            Dim wordSubString() As String = fileLines(count).Split("|")
            Dim word As String = wordSubString(0)

            If word.ToUpper() = (selectedWord.ToUpper()) Then
                txtEditSpelling.Text = word

                If wordSubString.Length > 1 Then
                    txtDefinitionEdit.Text = wordSubString(1)
                End If

                If wordSubString.Length >= 3 Then
                    KeywordsAsOneString = wordSubString(2)

                    Dim keywordsEditArray() As String = KeywordsAsOneString.Split("~")
                    For countK = 0 To 11
                        Dim txtBox As TextBox = New TextBox()
                        'txtBox.BorderStyle = BorderStyle.None

                        If keywordsEditArray.Length > countK Then
                            txtBox.Text = keywordsEditArray(countK)
                        End If

                        flowPanelKeywords.Controls.Add(txtBox)

                    Next
                End If

            End If
        Next
        Dim imagePath As String = New TTServices().GetImagePath()
        imagePath = imagePath & selectedWord & ".jpg"

        If File.Exists(imagePath) Then
            picPictureEdit.Image = Image.FromFile(imagePath)
        Else
            picPictureEdit.Image = Nothing
        End If
    End Sub


    Private Sub btnChangeImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'it is a control that lets you pick up the files
        OpenFileDialogEdit.ShowDialog()

        Dim imageFileEdit As String = OpenFileDialogEdit.FileName
        picPictureEdit.Image = Image.FromFile(imageFileEdit)


    End Sub

  
    Private Sub btnDeleteImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        picPictureEdit.Image = Nothing
    End Sub

 
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim servicesObject As New TTServices()
        servicesObject.DeleteRecord(FileName, cmbWordEdit.SelectedValue, picPictureEdit.Image)

        txtEditSpelling.Text = String.Empty
        txtDefinitionEdit.Text = String.Empty

        For Each textbox As Control In flowPanelKeywords.Controls
            textbox.Text = String.Empty
        Next

        frmTT_Load(Me, New System.EventArgs)

    End Sub


    Private Sub btnChangeImg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeImg.Click
        OpenFileDialogEdit.ShowDialog()

        Dim imageFile As String = OpenFileDialogEdit.FileName

        Dim currentImage = picPictureEdit.Image

        If Not currentImage Is Nothing Then 'if there is there is an image
            picPictureEdit.Image = Nothing
            currentImage.Dispose()

        End If

        picPictureEdit.Image = Image.FromFile(imageFile)

    End Sub

    Private Sub picFloppy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFloppy.Click
        Dim SelectedWord As String = cmbWordEdit.SelectedValue
        Dim imageChanged As Boolean = False
        Dim servicesObject As TTServices = New TTServices()

        If (OpenFileDialogEdit.FileName <> "OpenFileDialog1") Then
            imageChanged = True

        End If

        'saves all the edited keywords back as a single string so that it can be stored back into the record 
        Dim keywords As String = ""
        For countKW = 0 To 11
            If flowPanelKeywords.Controls.Count > countKW Then
                keywords += flowPanelKeywords.Controls.Item(countKW).Text & "~"
            End If
        Next

        Try
            'calling the function "UpdateWordRecord" from my logic layer 
            servicesObject.UpdateWordRecord(SelectedWord, FileName, keywords, txtEditSpelling.Text, txtDefinitionEdit.Text, picPictureEdit.Image, imageChanged)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'RESET
        txtDefinitionEdit.Text = String.Empty
        txtEditSpelling.Text = String.Empty

        For Each control As Control In flowPanelKeywords.Controls
            control.Text = ""

        Next

        picPictureEdit.Image = Nothing

        frmTT_Load(Me, New System.EventArgs)
    End Sub


    Private Sub btnSelectImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectImage.Click
        OpenFileDialog.ShowDialog()

        Dim imageFile As String = OpenFileDialog.FileName

        picNewPicture.Image = Image.FromFile(imageFile)
        txtPicureName.Text = imageFile

    End Sub

    Private Sub lstOngoingKeywords_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOngoingKeywords.DoubleClick
        Dim selectedWord = (CType(sender, ListBox)).SelectedValue
        Dim serviceObject = New TTServices()

        serviceObject.GetWordRecord(selectedWord, FileName)

    End Sub

   
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim PrintDialog1 As New PrintDialog
        Dim result As DialogResult = PrintDialog1.ShowDialog()
        If result = DialogResult.OK Then docToPrint.Print()
    End Sub

    Private Sub document_PrintPage(ByVal sender As Object,ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
         Handles docToPrint.PrintPage

        Dim printFont As New Font("Arial", 15, System.Drawing.FontStyle.Regular)
        Dim YPosition As Integer = 40

        Try
            For Each word As String In lstOngoingKeywords.Items
                e.Graphics.DrawString(word, printFont, System.Drawing.Brushes.Black, 25, YPosition)
                YPosition += 40
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class