<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTT))
        Me.tabTabs = New System.Windows.Forms.TabControl()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tabAdd = New System.Windows.Forms.TabPage()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.pnlKeywords = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtKeyWord1 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord2 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord3 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord4 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord5 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord6 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord7 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord8 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord9 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord10 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord12 = New System.Windows.Forms.TextBox()
        Me.txtKeyWord11 = New System.Windows.Forms.TextBox()
        Me.txtPicureName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.picNewPicture = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewDefinition = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewWord = New System.Windows.Forms.TextBox()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.picPictureEdit = New System.Windows.Forms.PictureBox()
        Me.picFloppy = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnDeleteImg = New System.Windows.Forms.Button()
        Me.btnChangeImg = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEditSpelling = New System.Windows.Forms.TextBox()
        Me.txtDefinitionEdit = New System.Windows.Forms.TextBox()
        Me.flowPanelKeywords = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbWordEdit = New System.Windows.Forms.ComboBox()
        Me.tabList = New System.Windows.Forms.TabPage()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblKeywordTotal = New System.Windows.Forms.Label()
        Me.lstOngoingKeywords = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogEdit = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.tabTabs.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.tabAdd.SuspendLayout()
        Me.pnlKeywords.SuspendLayout()
        CType(Me.picNewPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEdit.SuspendLayout()
        CType(Me.picPictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFloppy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabList.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTabs
        '
        Me.tabTabs.Controls.Add(Me.tabSearch)
        Me.tabTabs.Controls.Add(Me.tabAdd)
        Me.tabTabs.Controls.Add(Me.tabEdit)
        Me.tabTabs.Controls.Add(Me.tabList)
        Me.tabTabs.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTabs.Location = New System.Drawing.Point(-3, -2)
        Me.tabTabs.Name = "tabTabs"
        Me.tabTabs.SelectedIndex = 0
        Me.tabTabs.Size = New System.Drawing.Size(430, 366)
        Me.tabTabs.TabIndex = 0
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.btnFind)
        Me.tabSearch.Controls.Add(Me.txtSearch)
        Me.tabSearch.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSearch.Location = New System.Drawing.Point(4, 37)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(422, 325)
        Me.tabSearch.TabIndex = 0
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.Red
        Me.btnFind.Location = New System.Drawing.Point(175, 144)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 42)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "FIND"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Red
        Me.txtSearch.Location = New System.Drawing.Point(70, 97)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(279, 41)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "write down what you remember"
        '
        'tabAdd
        '
        Me.tabAdd.Controls.Add(Me.btnSelectImage)
        Me.tabAdd.Controls.Add(Me.pnlKeywords)
        Me.tabAdd.Controls.Add(Me.txtPicureName)
        Me.tabAdd.Controls.Add(Me.btnAdd)
        Me.tabAdd.Controls.Add(Me.picNewPicture)
        Me.tabAdd.Controls.Add(Me.Label2)
        Me.tabAdd.Controls.Add(Me.txtNewDefinition)
        Me.tabAdd.Controls.Add(Me.Label1)
        Me.tabAdd.Controls.Add(Me.txtNewWord)
        Me.tabAdd.Location = New System.Drawing.Point(4, 37)
        Me.tabAdd.Name = "tabAdd"
        Me.tabAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdd.Size = New System.Drawing.Size(422, 325)
        Me.tabAdd.TabIndex = 1
        Me.tabAdd.Text = "Add"
        Me.tabAdd.UseVisualStyleBackColor = True
        '
        'btnSelectImage
        '
        Me.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectImage.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnSelectImage.Location = New System.Drawing.Point(215, 288)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(113, 27)
        Me.btnSelectImage.TabIndex = 10
        Me.btnSelectImage.Text = "Select Image"
        Me.btnSelectImage.UseVisualStyleBackColor = True
        '
        'pnlKeywords
        '
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord1)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord2)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord3)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord4)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord5)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord6)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord7)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord8)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord9)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord10)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord12)
        Me.pnlKeywords.Controls.Add(Me.txtKeyWord11)
        Me.pnlKeywords.Location = New System.Drawing.Point(215, 70)
        Me.pnlKeywords.Name = "pnlKeywords"
        Me.pnlKeywords.Size = New System.Drawing.Size(181, 212)
        Me.pnlKeywords.TabIndex = 9
        '
        'txtKeyWord1
        '
        Me.txtKeyWord1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord1.Location = New System.Drawing.Point(3, 3)
        Me.txtKeyWord1.Multiline = True
        Me.txtKeyWord1.Name = "txtKeyWord1"
        Me.txtKeyWord1.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord1.TabIndex = 11
        '
        'txtKeyWord2
        '
        Me.txtKeyWord2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord2.Location = New System.Drawing.Point(90, 3)
        Me.txtKeyWord2.Multiline = True
        Me.txtKeyWord2.Name = "txtKeyWord2"
        Me.txtKeyWord2.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord2.TabIndex = 12
        '
        'txtKeyWord3
        '
        Me.txtKeyWord3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord3.Location = New System.Drawing.Point(3, 36)
        Me.txtKeyWord3.Multiline = True
        Me.txtKeyWord3.Name = "txtKeyWord3"
        Me.txtKeyWord3.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord3.TabIndex = 13
        '
        'txtKeyWord4
        '
        Me.txtKeyWord4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord4.Location = New System.Drawing.Point(90, 36)
        Me.txtKeyWord4.Multiline = True
        Me.txtKeyWord4.Name = "txtKeyWord4"
        Me.txtKeyWord4.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord4.TabIndex = 14
        '
        'txtKeyWord5
        '
        Me.txtKeyWord5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord5.Location = New System.Drawing.Point(3, 69)
        Me.txtKeyWord5.Multiline = True
        Me.txtKeyWord5.Name = "txtKeyWord5"
        Me.txtKeyWord5.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord5.TabIndex = 15
        '
        'txtKeyWord6
        '
        Me.txtKeyWord6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord6.Location = New System.Drawing.Point(90, 69)
        Me.txtKeyWord6.Multiline = True
        Me.txtKeyWord6.Name = "txtKeyWord6"
        Me.txtKeyWord6.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord6.TabIndex = 16
        '
        'txtKeyWord7
        '
        Me.txtKeyWord7.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord7.Location = New System.Drawing.Point(3, 102)
        Me.txtKeyWord7.Multiline = True
        Me.txtKeyWord7.Name = "txtKeyWord7"
        Me.txtKeyWord7.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord7.TabIndex = 17
        '
        'txtKeyWord8
        '
        Me.txtKeyWord8.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord8.Location = New System.Drawing.Point(90, 102)
        Me.txtKeyWord8.Multiline = True
        Me.txtKeyWord8.Name = "txtKeyWord8"
        Me.txtKeyWord8.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord8.TabIndex = 18
        '
        'txtKeyWord9
        '
        Me.txtKeyWord9.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord9.Location = New System.Drawing.Point(3, 135)
        Me.txtKeyWord9.Multiline = True
        Me.txtKeyWord9.Name = "txtKeyWord9"
        Me.txtKeyWord9.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord9.TabIndex = 19
        '
        'txtKeyWord10
        '
        Me.txtKeyWord10.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord10.Location = New System.Drawing.Point(90, 135)
        Me.txtKeyWord10.Multiline = True
        Me.txtKeyWord10.Name = "txtKeyWord10"
        Me.txtKeyWord10.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord10.TabIndex = 20
        '
        'txtKeyWord12
        '
        Me.txtKeyWord12.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord12.Location = New System.Drawing.Point(3, 168)
        Me.txtKeyWord12.Multiline = True
        Me.txtKeyWord12.Name = "txtKeyWord12"
        Me.txtKeyWord12.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord12.TabIndex = 22
        '
        'txtKeyWord11
        '
        Me.txtKeyWord11.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyWord11.Location = New System.Drawing.Point(90, 168)
        Me.txtKeyWord11.Multiline = True
        Me.txtKeyWord11.Name = "txtKeyWord11"
        Me.txtKeyWord11.Size = New System.Drawing.Size(81, 27)
        Me.txtKeyWord11.TabIndex = 21
        '
        'txtPicureName
        '
        Me.txtPicureName.BackColor = System.Drawing.SystemColors.Window
        Me.txtPicureName.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPicureName.Location = New System.Drawing.Point(6, 292)
        Me.txtPicureName.Multiline = True
        Me.txtPicureName.Name = "txtPicureName"
        Me.txtPicureName.ReadOnly = True
        Me.txtPicureName.Size = New System.Drawing.Size(203, 23)
        Me.txtPicureName.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(262, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 27)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'picNewPicture
        '
        Me.picNewPicture.Location = New System.Drawing.Point(3, 158)
        Me.picNewPicture.Name = "picNewPicture"
        Me.picNewPicture.Size = New System.Drawing.Size(206, 128)
        Me.picNewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNewPicture.TabIndex = 5
        Me.picNewPicture.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Definition"
        '
        'txtNewDefinition
        '
        Me.txtNewDefinition.Location = New System.Drawing.Point(4, 70)
        Me.txtNewDefinition.Multiline = True
        Me.txtNewDefinition.Name = "txtNewDefinition"
        Me.txtNewDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNewDefinition.Size = New System.Drawing.Size(204, 84)
        Me.txtNewDefinition.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New Word"
        '
        'txtNewWord
        '
        Me.txtNewWord.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewWord.ForeColor = System.Drawing.Color.Red
        Me.txtNewWord.Location = New System.Drawing.Point(3, 20)
        Me.txtNewWord.Multiline = True
        Me.txtNewWord.Name = "txtNewWord"
        Me.txtNewWord.Size = New System.Drawing.Size(205, 27)
        Me.txtNewWord.TabIndex = 0
        Me.txtNewWord.Text = "type new word "
        '
        'tabEdit
        '
        Me.tabEdit.Controls.Add(Me.picPictureEdit)
        Me.tabEdit.Controls.Add(Me.picFloppy)
        Me.tabEdit.Controls.Add(Me.btnDelete)
        Me.tabEdit.Controls.Add(Me.btnDeleteImg)
        Me.tabEdit.Controls.Add(Me.btnChangeImg)
        Me.tabEdit.Controls.Add(Me.Label5)
        Me.tabEdit.Controls.Add(Me.Label4)
        Me.tabEdit.Controls.Add(Me.txtEditSpelling)
        Me.tabEdit.Controls.Add(Me.txtDefinitionEdit)
        Me.tabEdit.Controls.Add(Me.flowPanelKeywords)
        Me.tabEdit.Controls.Add(Me.cmbWordEdit)
        Me.tabEdit.Location = New System.Drawing.Point(4, 37)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEdit.Size = New System.Drawing.Size(422, 325)
        Me.tabEdit.TabIndex = 2
        Me.tabEdit.Text = "Edit"
        Me.tabEdit.ToolTipText = "Click to Save "
        Me.tabEdit.UseVisualStyleBackColor = True
        '
        'picPictureEdit
        '
        Me.picPictureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPictureEdit.Location = New System.Drawing.Point(4, 163)
        Me.picPictureEdit.Name = "picPictureEdit"
        Me.picPictureEdit.Size = New System.Drawing.Size(206, 128)
        Me.picPictureEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPictureEdit.TabIndex = 26
        Me.picPictureEdit.TabStop = False
        '
        'picFloppy
        '
        Me.picFloppy.Image = CType(resources.GetObject("picFloppy.Image"), System.Drawing.Image)
        Me.picFloppy.Location = New System.Drawing.Point(124, 291)
        Me.picFloppy.Name = "picFloppy"
        Me.picFloppy.Size = New System.Drawing.Size(29, 31)
        Me.picFloppy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFloppy.TabIndex = 29
        Me.picFloppy.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(61, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(57, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnDeleteImg
        '
        Me.btnDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteImg.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteImg.Location = New System.Drawing.Point(113, 134)
        Me.btnDeleteImg.Name = "btnDeleteImg"
        Me.btnDeleteImg.Size = New System.Drawing.Size(97, 23)
        Me.btnDeleteImg.TabIndex = 28
        Me.btnDeleteImg.Text = "Delete Image"
        Me.btnDeleteImg.UseVisualStyleBackColor = True
        '
        'btnChangeImg
        '
        Me.btnChangeImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeImg.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeImg.Location = New System.Drawing.Point(4, 134)
        Me.btnChangeImg.Name = "btnChangeImg"
        Me.btnChangeImg.Size = New System.Drawing.Size(97, 23)
        Me.btnChangeImg.TabIndex = 27
        Me.btnChangeImg.Text = "Change Image"
        Me.btnChangeImg.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Definition"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Spelling"
        '
        'txtEditSpelling
        '
        Me.txtEditSpelling.Location = New System.Drawing.Point(4, 19)
        Me.txtEditSpelling.Name = "txtEditSpelling"
        Me.txtEditSpelling.Size = New System.Drawing.Size(206, 36)
        Me.txtEditSpelling.TabIndex = 24
        '
        'txtDefinitionEdit
        '
        Me.txtDefinitionEdit.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefinitionEdit.Location = New System.Drawing.Point(4, 75)
        Me.txtDefinitionEdit.Multiline = True
        Me.txtDefinitionEdit.Name = "txtDefinitionEdit"
        Me.txtDefinitionEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDefinitionEdit.Size = New System.Drawing.Size(206, 53)
        Me.txtDefinitionEdit.TabIndex = 25
        '
        'flowPanelKeywords
        '
        Me.flowPanelKeywords.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowPanelKeywords.Location = New System.Drawing.Point(214, 60)
        Me.flowPanelKeywords.Name = "flowPanelKeywords"
        Me.flowPanelKeywords.Size = New System.Drawing.Size(205, 259)
        Me.flowPanelKeywords.TabIndex = 23
        '
        'cmbWordEdit
        '
        Me.cmbWordEdit.DropDownHeight = 300
        Me.cmbWordEdit.ForeColor = System.Drawing.Color.Black
        Me.cmbWordEdit.FormattingEnabled = True
        Me.cmbWordEdit.IntegralHeight = False
        Me.cmbWordEdit.Location = New System.Drawing.Point(214, 19)
        Me.cmbWordEdit.Name = "cmbWordEdit"
        Me.cmbWordEdit.Size = New System.Drawing.Size(206, 36)
        Me.cmbWordEdit.TabIndex = 1
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.btnPrint)
        Me.tabList.Controls.Add(Me.lblKeywordTotal)
        Me.tabList.Controls.Add(Me.lstOngoingKeywords)
        Me.tabList.Location = New System.Drawing.Point(4, 37)
        Me.tabList.Name = "tabList"
        Me.tabList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabList.Size = New System.Drawing.Size(422, 325)
        Me.tabList.TabIndex = 3
        Me.tabList.Text = "List"
        Me.tabList.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(243, 26)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(84, 30)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "Print Lists"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblKeywordTotal
        '
        Me.lblKeywordTotal.AutoSize = True
        Me.lblKeywordTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeywordTotal.Location = New System.Drawing.Point(243, 7)
        Me.lblKeywordTotal.Name = "lblKeywordTotal"
        Me.lblKeywordTotal.Size = New System.Drawing.Size(46, 16)
        Me.lblKeywordTotal.TabIndex = 26
        Me.lblKeywordTotal.Text = "count"
        '
        'lstOngoingKeywords
        '
        Me.lstOngoingKeywords.FormattingEnabled = True
        Me.lstOngoingKeywords.ItemHeight = 28
        Me.lstOngoingKeywords.Location = New System.Drawing.Point(4, 7)
        Me.lstOngoingKeywords.Name = "lstOngoingKeywords"
        Me.lstOngoingKeywords.Size = New System.Drawing.Size(233, 312)
        Me.lstOngoingKeywords.TabIndex = 25
        '
        'OpenFileDialogEdit
        '
        Me.OpenFileDialogEdit.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 362)
        Me.Controls.Add(Me.tabTabs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTT"
        Me.Text = "Tot's Trap"
        Me.tabTabs.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.tabSearch.PerformLayout()
        Me.tabAdd.ResumeLayout(False)
        Me.tabAdd.PerformLayout()
        Me.pnlKeywords.ResumeLayout(False)
        Me.pnlKeywords.PerformLayout()
        CType(Me.picNewPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEdit.ResumeLayout(False)
        Me.tabEdit.PerformLayout()
        CType(Me.picPictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFloppy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabList.ResumeLayout(False)
        Me.tabList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabTabs As System.Windows.Forms.TabControl
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents tabAdd As System.Windows.Forms.TabPage
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents picNewPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNewWord As System.Windows.Forms.TextBox
    Friend WithEvents cmbWordEdit As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents pnlKeywords As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtKeyWord1 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord2 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord3 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord4 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord5 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord6 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord7 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord8 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord9 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord10 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord11 As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyWord12 As System.Windows.Forms.TextBox
    Friend WithEvents txtPicureName As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectImage As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialogEdit As System.Windows.Forms.OpenFileDialog
    Friend WithEvents flowPanelKeywords As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tabList As System.Windows.Forms.TabPage
    Friend WithEvents lblKeywordTotal As System.Windows.Forms.Label
    Friend WithEvents lstOngoingKeywords As System.Windows.Forms.ListBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnDeleteImg As System.Windows.Forms.Button
    Friend WithEvents btnChangeImg As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEditSpelling As System.Windows.Forms.TextBox
    Friend WithEvents txtDefinitionEdit As System.Windows.Forms.TextBox
    Friend WithEvents picPictureEdit As System.Windows.Forms.PictureBox
    Friend WithEvents txtNewDefinition As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Protected WithEvents picFloppy As System.Windows.Forms.PictureBox

End Class
