Imports System.IO

Public Class TTServices 'MY BUSINESS LOGIC LAYER (2nd tier)
    'I have created this class to collect my methods, it is the logic behind my project that provides its functionality 


    'gets the file path for the image so that it can be stored
    Function GetImagePath()
        Dim imagePath As String = Application.ExecutablePath 'Gets the filepath of the executable file
        'tweeking the above filepath to create a location named "Resources" in the debug folder in which the images will be saved to
        imagePath = imagePath.Substring(0, imagePath.LastIndexOf("\")) & "\Resources\"

        Return imagePath
    End Function

    'ADD tab
    Sub SaveWordRecord(ByVal fileName As String, ByVal word As String, ByVal definition As String, ByVal keywordsAsOneString As String, ByVal image As Image)
        Dim CurrentFileWriter As BinaryWriter
        Dim CurrentFileWriterStream As FileStream
        Dim imagePath As String = GetImagePath()

        'Creates a stream (a connection/medium through which files can be read and written)
        CurrentFileWriterStream = New FileStream(fileName, FileMode.Append)

        'writes to the file: binarywriter 
        CurrentFileWriter = New BinaryWriter(CurrentFileWriterStream)
        'Writes to the text file; each field of the record (word, definition, associated keywords and image -->THESE ARE ALL PARAMETERS) 
        'is separated with a unique delimiter
        'I have different symbols for delimiters, as that's how my data's logically separated into columns, for extraction later on
        CurrentFileWriter.Write("{" & word & "|" & definition & "|" & keywordsAsOneString & "|" & word & "}")

        'Ensures that the new word is still saved if the user chooses not to link an image to it
        If Not image Is Nothing Then 'If there is an image
            image.Save(imagePath & word & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg) 'Converts image to Jpeg

        End If

        CurrentFileWriter.Close()
        CurrentFileWriterStream.Close()

    End Sub

    'Word Total
    Function GetWordList(ByVal fileName As String)
        'list lets us collect all the words in one place; it's the data source for the combobox
        Dim wordList As List(Of String) = New List(Of String)()
        Dim fileLines() As String = New String() {}

        'Creates the flat file database (txt file) if it doesn't exist 
        If Not IO.File.Exists(fileName) Then
            File.Create(fileName)
        End If

        'creates a file where all the images are saved
        If (Not System.IO.Directory.Exists("Resources")) Then
            System.IO.Directory.CreateDirectory("Resources")
        End If

        fileLines = GetFileLines(fileName)
        For count = 0 To fileLines.Length - 1

            Dim wordSubString() As String = fileLines(count).Split("|") 'splits each record into an array, and stores the firt element as that's the word 
            Dim word As String = wordSubString(0)

            If Not String.IsNullOrEmpty(word) Then 'ensures an empty word is not added to the list
                wordList.Add(word)
            End If
        Next

        wordList.Sort()
        Return wordList
    End Function

    'gets all the records in the file
    Function GetFileLines(ByVal fileName As String)
        Dim fileLines() As String = New String() {} 'Empty NOT null; size of array will grow depending upon the number of filelines (records)

        If IO.File.ReadAllLines(fileName).Length > 0 Then
            'reads all the lines of the txt file
            'the 'ReadAllLines' method populates the array-'fileLines'
            fileLines = IO.File.ReadAllLines(fileName)(0).Split("{") 'start splitting at the start of the record (because each line DOES NOT contain one record only)
        End If
        Return fileLines
    End Function

    'EDIT tab
    Sub UpdateWordRecord(ByVal SelectedWord As String, ByVal FileName As String, ByVal editKeywords As String, ByVal editWord As String, ByVal editDefinition As String, ByVal editImage As Image, ByVal imageHasChanged As Boolean)
        Dim imagePath As String = GetImagePath()
        Dim fileLines = GetFileLines(FileName)

        'reads all the lines of the txt file
        If IO.File.ReadAllLines(FileName).Length > 0 Then
            'starts splitting at the start of the record (because each line DOES NOT contain one record only)
            fileLines = IO.File.ReadAllLines(FileName)(0).Split("{")
        End If


        For count = 0 To fileLines.Length - 1

            Dim wordSubString() As String = fileLines(count).Split("|")
            Dim word As String = wordSubString(0)
            If word.ToUpper() = (SelectedWord.ToUpper()) Then

                Dim updatedRecord As String = editWord & "|" & editDefinition & "|" & editKeywords & "}"
                'replaces the current record with a 'new' record (so it appears that've I've made changes to the record that I wanted to edit)
                File.WriteAllText(FileName, File.ReadAllText(FileName).Replace(fileLines(count), updatedRecord))
                If Not editImage Is Nothing And imageHasChanged Then 'If there is an image

                    editImage.Save(imagePath & editWord & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

                End If
            End If
        Next



    End Sub

    'deleting a record
    Sub DeleteRecord(ByVal fileName As String, ByVal editWord As String, ByVal editPic As Image)

        Dim fileLines = GetFileLines(fileName)
        Dim imagePath = GetImagePath()

        'reads all the lines of the txt file
        If IO.File.ReadAllLines(fileName).Length > 0 Then
            'starts splitting at the start of the record (because each line DOES NOT contain one record only)
            fileLines = IO.File.ReadAllLines(fileName)(0).Split("{")
        End If

        '
        For count = 0 To fileLines.Length - 1

            Dim wordSubString() As String = fileLines(count).Split("|")
            Dim word As String = wordSubString(0)
            If word.ToUpper() = (editWord.ToUpper()) Then

                Dim fileLine As String = CStr(fileLines(count))
                File.WriteAllText(fileName, File.ReadAllText(fileName).Remove(0, fileLine.Length)) 'removes fileline (record)

                Dim imageIsNull As Boolean = editPic Is Nothing
                If Not imageIsNull Then 'If there is an image
                    Dim tempImage = editPic
                    editPic = Nothing
                    tempImage.Dispose()

                    File.Delete(imagePath & editWord & ".jpg")
                End If
            End If
        Next

    End Sub

    'gets a record 
    Sub GetWordRecord(ByVal findWord As String, ByVal fileName As String)
        Dim searchWord As String = LTrim(RTrim(findWord))
        Dim foundForm As Found = New Found()
        Dim displayform As Display = New Display
        Dim fileLines() As String = GetFileLines(fileName)
        Dim KeywordsAsOneString As String

        For count = 0 To fileLines.Length - 1

            Dim wordSubString() As String = fileLines(count).Split("|")

            If wordSubString.Length > 2 Then

                If wordSubString(0).ToUpper().Contains(searchWord.ToUpper()) Or wordSubString(1).ToUpper().Contains(searchWord.ToUpper()) Or wordSubString(2).ToUpper().Contains(searchWord.ToUpper()) Then
                    Dim word As String = wordSubString(0)
                    Dim definition As String = wordSubString(1)

                    KeywordsAsOneString = wordSubString(2)
                  
                    displayForm.lblWord.Text = findWord
                    displayForm.lblDefinition.Text = definition
                    Dim keywordsAsArray As String() = KeywordsAsOneString.Split("~")

                    Dim imagePath As String = New TTServices().GetImagePath()
                    imagePath = imagePath & findWord & ".jpg"

                    If File.Exists(imagePath) Then
                        displayForm.picDisplay.Image = Image.FromFile(imagePath)
                    End If

                    For ct = 0 To keywordsAsArray.Length - 1
                        Dim lbl As Label = New Label()
                        'links
                        lbl.Text = keywordsAsArray(ct)
                        displayForm.FlowPnlKeywords.Controls.Add(lbl)

                    Next
                    displayForm.Show()
                End If
            End If
        Next

    End Sub
End Class
