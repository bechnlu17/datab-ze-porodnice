<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Porodnice_databáze0203DataSet = New WindowsApp2.Porodnice_databáze0203DataSet()
        Me.Dítě__auto_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dítě__auto_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.dítě__auto_TableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.TableAdapterManager()
        Me.Dítě__auto_BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Dítě__auto_BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Dítě__auto_DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rodička__majitel_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rodička__majitel_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.Rodička__majitel_TableAdapter()
        Me.Rodička__majitel_DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dítě__Rodička__auto__Majitel_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dítě__Rodička__auto__Majitel_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.dítě__Rodička__auto__Majitel_TableAdapter()
        Me.Dítě__Rodička__auto__Majitel_DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox21 = New System.Windows.Forms.ComboBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Button51 = New System.Windows.Forms.Button()
        CType(Me.Porodnice_databáze0203DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dítě__auto_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dítě__auto_BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dítě__auto_BindingNavigator.SuspendLayout()
        CType(Me.Dítě__auto_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rodička__majitel_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rodička__majitel_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dítě__Rodička__auto__Majitel_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dítě__Rodička__auto__Majitel_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Porodnice_databáze0203DataSet
        '
        Me.Porodnice_databáze0203DataSet.DataSetName = "Porodnice_databáze0203DataSet"
        Me.Porodnice_databáze0203DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dítě__auto_BindingSource
        '
        Me.Dítě__auto_BindingSource.DataMember = "dítě (auto)"
        Me.Dítě__auto_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'Dítě__auto_TableAdapter
        '
        Me.Dítě__auto_TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dítě__auto_TableAdapter = Me.Dítě__auto_TableAdapter
        Me.TableAdapterManager.dítě__Rodička__auto__Majitel_TableAdapter = Me.Dítě__Rodička__auto__Majitel_TableAdapter
        Me.TableAdapterManager.Porodnice__Servis_TableAdapter = Nothing
        Me.TableAdapterManager.Rodička__majitel_TableAdapter = Me.Rodička__majitel_TableAdapter
        Me.TableAdapterManager.Rodička__porodnice__Majitel__Servis_TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dítě__auto_BindingNavigator
        '
        Me.Dítě__auto_BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Dítě__auto_BindingNavigator.BindingSource = Me.Dítě__auto_BindingSource
        Me.Dítě__auto_BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Dítě__auto_BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Dítě__auto_BindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Dítě__auto_BindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Dítě__auto_BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Dítě__auto_BindingNavigatorSaveItem})
        Me.Dítě__auto_BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Dítě__auto_BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Dítě__auto_BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Dítě__auto_BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Dítě__auto_BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Dítě__auto_BindingNavigator.Name = "Dítě__auto_BindingNavigator"
        Me.Dítě__auto_BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Dítě__auto_BindingNavigator.Size = New System.Drawing.Size(373, 33)
        Me.Dítě__auto_BindingNavigator.TabIndex = 0
        Me.Dítě__auto_BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Přesunout na první"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMovePreviousItem.Text = "Přesunout na předchozí"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Umístění"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuální pozice"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 25)
        Me.BindingNavigatorCountItem.Text = "z {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Celkový počet položek"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Přesunout na další"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Přesunout na poslední"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Přidat nový"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Odstranit"
        '
        'Dítě__auto_BindingNavigatorSaveItem
        '
        Me.Dítě__auto_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dítě__auto_BindingNavigatorSaveItem.Image = CType(resources.GetObject("Dítě__auto_BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Dítě__auto_BindingNavigatorSaveItem.Name = "Dítě__auto_BindingNavigatorSaveItem"
        Me.Dítě__auto_BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Dítě__auto_BindingNavigatorSaveItem.Text = "Uložit data"
        '
        'Dítě__auto_DataGridView
        '
        Me.Dítě__auto_DataGridView.AutoGenerateColumns = False
        Me.Dítě__auto_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dítě__auto_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Dítě__auto_DataGridView.DataSource = Me.Dítě__auto_BindingSource
        Me.Dítě__auto_DataGridView.Location = New System.Drawing.Point(0, 71)
        Me.Dítě__auto_DataGridView.Name = "Dítě__auto_DataGridView"
        Me.Dítě__auto_DataGridView.RowHeadersWidth = 62
        Me.Dítě__auto_DataGridView.RowTemplate.Height = 28
        Me.Dítě__auto_DataGridView.Size = New System.Drawing.Size(816, 220)
        Me.Dítě__auto_DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "váha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "váha"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "potřeba inkubátoru"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "potřeba inkubátoru"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "výška"
        Me.DataGridViewTextBoxColumn3.HeaderText = "výška"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "datum narození"
        Me.DataGridViewTextBoxColumn4.HeaderText = "datum narození"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "jméno"
        Me.DataGridViewTextBoxColumn5.HeaderText = "jméno"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "příjmení"
        Me.DataGridViewTextBoxColumn6.HeaderText = "příjmení"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'Rodička__majitel_BindingSource
        '
        Me.Rodička__majitel_BindingSource.DataMember = "Rodička (majitel)"
        Me.Rodička__majitel_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'Rodička__majitel_TableAdapter
        '
        Me.Rodička__majitel_TableAdapter.ClearBeforeFill = True
        '
        'Rodička__majitel_DataGridView
        '
        Me.Rodička__majitel_DataGridView.AutoGenerateColumns = False
        Me.Rodička__majitel_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rodička__majitel_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Rodička__majitel_DataGridView.DataSource = Me.Rodička__majitel_BindingSource
        Me.Rodička__majitel_DataGridView.Location = New System.Drawing.Point(1068, 71)
        Me.Rodička__majitel_DataGridView.Name = "Rodička__majitel_DataGridView"
        Me.Rodička__majitel_DataGridView.RowHeadersWidth = 62
        Me.Rodička__majitel_DataGridView.RowTemplate.Height = 28
        Me.Rodička__majitel_DataGridView.Size = New System.Drawing.Size(552, 220)
        Me.Rodička__majitel_DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Příjmení"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Příjmení"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Jméno"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Jméno"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'Dítě__Rodička__auto__Majitel_BindingSource
        '
        Me.Dítě__Rodička__auto__Majitel_BindingSource.DataMember = "dítě__Rodička (auto__Majitel)"
        Me.Dítě__Rodička__auto__Majitel_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'Dítě__Rodička__auto__Majitel_TableAdapter
        '
        Me.Dítě__Rodička__auto__Majitel_TableAdapter.ClearBeforeFill = True
        '
        'Dítě__Rodička__auto__Majitel_DataGridView
        '
        Me.Dítě__Rodička__auto__Majitel_DataGridView.AutoGenerateColumns = False
        Me.Dítě__Rodička__auto__Majitel_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dítě__Rodička__auto__Majitel_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Dítě__Rodička__auto__Majitel_DataGridView.DataSource = Me.Dítě__Rodička__auto__Majitel_BindingSource
        Me.Dítě__Rodička__auto__Majitel_DataGridView.Location = New System.Drawing.Point(708, 460)
        Me.Dítě__Rodička__auto__Majitel_DataGridView.Name = "Dítě__Rodička__auto__Majitel_DataGridView"
        Me.Dítě__Rodička__auto__Majitel_DataGridView.RowHeadersWidth = 62
        Me.Dítě__Rodička__auto__Majitel_DataGridView.RowTemplate.Height = 28
        Me.Dítě__Rodička__auto__Majitel_DataGridView.Size = New System.Drawing.Size(455, 220)
        Me.Dítě__Rodička__auto__Majitel_DataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID_dítě"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID_dítě"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_Rodička"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID_Rodička"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'ComboBox21
        '
        Me.ComboBox21.FormattingEnabled = True
        Me.ComboBox21.Location = New System.Drawing.Point(1169, 380)
        Me.ComboBox21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox21.Name = "ComboBox21"
        Me.ComboBox21.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox21.TabIndex = 40
        '
        'ComboBox11
        '
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Location = New System.Drawing.Point(484, 380)
        Me.ComboBox11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox11.TabIndex = 39
        '
        'Button51
        '
        Me.Button51.BackColor = System.Drawing.Color.LightGreen
        Me.Button51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button51.Location = New System.Drawing.Point(760, 380)
        Me.Button51.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button51.Name = "Button51"
        Me.Button51.Size = New System.Drawing.Size(321, 35)
        Me.Button51.TabIndex = 38
        Me.Button51.Text = "Přiřadit dítě matce"
        Me.Button51.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1808, 701)
        Me.Controls.Add(Me.ComboBox21)
        Me.Controls.Add(Me.ComboBox11)
        Me.Controls.Add(Me.Button51)
        Me.Controls.Add(Me.Dítě__Rodička__auto__Majitel_DataGridView)
        Me.Controls.Add(Me.Rodička__majitel_DataGridView)
        Me.Controls.Add(Me.Dítě__auto_DataGridView)
        Me.Controls.Add(Me.Dítě__auto_BindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Porodnice_databáze0203DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dítě__auto_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dítě__auto_BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dítě__auto_BindingNavigator.ResumeLayout(False)
        Me.Dítě__auto_BindingNavigator.PerformLayout()
        CType(Me.Dítě__auto_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rodička__majitel_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rodička__majitel_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dítě__Rodička__auto__Majitel_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dítě__Rodička__auto__Majitel_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Porodnice_databáze0203DataSet As Porodnice_databáze0203DataSet
    Friend WithEvents Dítě__auto_BindingSource As BindingSource
    Friend WithEvents Dítě__auto_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.dítě__auto_TableAdapter
    Friend WithEvents TableAdapterManager As Porodnice_databáze0203DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Dítě__auto_BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Dítě__auto_BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Rodička__majitel_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.Rodička__majitel_TableAdapter
    Friend WithEvents Dítě__auto_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Rodička__majitel_BindingSource As BindingSource
    Friend WithEvents Dítě__Rodička__auto__Majitel_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.dítě__Rodička__auto__Majitel_TableAdapter
    Friend WithEvents Rodička__majitel_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Dítě__Rodička__auto__Majitel_BindingSource As BindingSource
    Friend WithEvents Dítě__Rodička__auto__Majitel_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox21 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents Button51 As Button
End Class
