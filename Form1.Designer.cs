namespace file_organization_fth_oz
{
    partial class file_organization_algorithms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateNumberButton = new System.Windows.Forms.Button();
            this.arraySizeValue = new System.Windows.Forms.TextBox();
            this.LISCH_dataGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LICH_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LICH_textBox = new System.Windows.Forms.TextBox();
            this.EISCH_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EICH_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EICH_textBox = new System.Windows.Forms.TextBox();
            this.BEISCH_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.RLISCH_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.probCom_dataGrid = new System.Windows.Forms.DataGridView();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.ProbsStatistics_textBox = new System.Windows.Forms.TextBox();
            this.searchValue_textBox = new System.Windows.Forms.TextBox();
            this.searchResults_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.numberRange_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LISCH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LICH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISCH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EICH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEISCH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLISCH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probCom_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // generateNumberButton
            // 
            this.generateNumberButton.Location = new System.Drawing.Point(54, 49);
            this.generateNumberButton.Name = "generateNumberButton";
            this.generateNumberButton.Size = new System.Drawing.Size(163, 23);
            this.generateNumberButton.TabIndex = 2;
            this.generateNumberButton.Text = "Generate";
            this.generateNumberButton.UseVisualStyleBackColor = true;
            this.generateNumberButton.Click += new System.EventHandler(this.generateNumberButton_Click);
            // 
            // arraySizeValue
            // 
            this.arraySizeValue.Location = new System.Drawing.Point(147, 23);
            this.arraySizeValue.Name = "arraySizeValue";
            this.arraySizeValue.Size = new System.Drawing.Size(43, 20);
            this.arraySizeValue.TabIndex = 3;
            this.arraySizeValue.Text = "10";
            // 
            // LISCH_dataGrid
            // 
            this.LISCH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LISCH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Value,
            this.Link});
            this.LISCH_dataGrid.Location = new System.Drawing.Point(292, 210);
            this.LISCH_dataGrid.Name = "LISCH_dataGrid";
            this.LISCH_dataGrid.Size = new System.Drawing.Size(166, 443);
            this.LISCH_dataGrid.TabIndex = 4;
            // 
            // Index
            // 
            this.Index.Frozen = true;
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Index.Width = 40;
            // 
            // Value
            // 
            this.Value.Frozen = true;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 40;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Link.Width = 40;
            // 
            // LICH_dataGrid
            // 
            this.LICH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LICH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewLinkColumn1});
            this.LICH_dataGrid.Location = new System.Drawing.Point(464, 210);
            this.LICH_dataGrid.Name = "LICH_dataGrid";
            this.LICH_dataGrid.Size = new System.Drawing.Size(166, 443);
            this.LICH_dataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "Link";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Width = 40;
            // 
            // LICH_textBox
            // 
            this.LICH_textBox.Location = new System.Drawing.Point(466, 659);
            this.LICH_textBox.Multiline = true;
            this.LICH_textBox.Name = "LICH_textBox";
            this.LICH_textBox.Size = new System.Drawing.Size(164, 47);
            this.LICH_textBox.TabIndex = 6;
            // 
            // EISCH_dataGrid
            // 
            this.EISCH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EISCH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewLinkColumn2});
            this.EISCH_dataGrid.Location = new System.Drawing.Point(636, 210);
            this.EISCH_dataGrid.Name = "EISCH_dataGrid";
            this.EISCH_dataGrid.Size = new System.Drawing.Size(166, 443);
            this.EISCH_dataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Index";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.HeaderText = "Link";
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn2.Width = 40;
            // 
            // EICH_dataGrid
            // 
            this.EICH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EICH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewLinkColumn3});
            this.EICH_dataGrid.Location = new System.Drawing.Point(808, 210);
            this.EICH_dataGrid.Name = "EICH_dataGrid";
            this.EICH_dataGrid.Size = new System.Drawing.Size(166, 443);
            this.EICH_dataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Index";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewLinkColumn3
            // 
            this.dataGridViewLinkColumn3.HeaderText = "Link";
            this.dataGridViewLinkColumn3.Name = "dataGridViewLinkColumn3";
            this.dataGridViewLinkColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn3.Width = 40;
            // 
            // EICH_textBox
            // 
            this.EICH_textBox.Location = new System.Drawing.Point(810, 659);
            this.EICH_textBox.Multiline = true;
            this.EICH_textBox.Name = "EICH_textBox";
            this.EICH_textBox.Size = new System.Drawing.Size(164, 47);
            this.EICH_textBox.TabIndex = 6;
            // 
            // BEISCH_dataGrid
            // 
            this.BEISCH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BEISCH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewLinkColumn4});
            this.BEISCH_dataGrid.Location = new System.Drawing.Point(980, 210);
            this.BEISCH_dataGrid.Name = "BEISCH_dataGrid";
            this.BEISCH_dataGrid.Size = new System.Drawing.Size(166, 443);
            this.BEISCH_dataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Index";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Value";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewLinkColumn4
            // 
            this.dataGridViewLinkColumn4.HeaderText = "Link";
            this.dataGridViewLinkColumn4.Name = "dataGridViewLinkColumn4";
            this.dataGridViewLinkColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn4.Width = 40;
            // 
            // RLISCH_dataGrid
            // 
            this.RLISCH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RLISCH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewLinkColumn5});
            this.RLISCH_dataGrid.Location = new System.Drawing.Point(1152, 210);
            this.RLISCH_dataGrid.Name = "RLISCH_dataGrid";
            this.RLISCH_dataGrid.Size = new System.Drawing.Size(166, 443);
            this.RLISCH_dataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Index";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Value";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 40;
            // 
            // dataGridViewLinkColumn5
            // 
            this.dataGridViewLinkColumn5.HeaderText = "Link";
            this.dataGridViewLinkColumn5.Name = "dataGridViewLinkColumn5";
            this.dataGridViewLinkColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn5.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "LICH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "EISCH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(860, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "EICH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1021, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "BEISCH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1190, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "RLISCH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // probCom_dataGrid
            // 
            this.probCom_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probCom_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Values,
            this.LIS,
            this.LI,
            this.EIS,
            this.EI,
            this.BEI,
            this.RLI});
            this.probCom_dataGrid.Location = new System.Drawing.Point(28, 132);
            this.probCom_dataGrid.Name = "probCom_dataGrid";
            this.probCom_dataGrid.Size = new System.Drawing.Size(238, 521);
            this.probCom_dataGrid.TabIndex = 4;
            // 
            // Values
            // 
            this.Values.HeaderText = "Value";
            this.Values.Name = "Values";
            this.Values.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Values.Width = 40;
            // 
            // LIS
            // 
            this.LIS.HeaderText = "LIS";
            this.LIS.Name = "LIS";
            this.LIS.Width = 25;
            // 
            // LI
            // 
            this.LI.HeaderText = "LI";
            this.LI.Name = "LI";
            this.LI.Width = 25;
            // 
            // EIS
            // 
            this.EIS.HeaderText = "EIS";
            this.EIS.Name = "EIS";
            this.EIS.Width = 25;
            // 
            // EI
            // 
            this.EI.HeaderText = "EI";
            this.EI.Name = "EI";
            this.EI.Width = 25;
            // 
            // BEI
            // 
            this.BEI.HeaderText = "BEI";
            this.BEI.Name = "BEI";
            this.BEI.Width = 25;
            // 
            // RLI
            // 
            this.RLI.HeaderText = "RLI";
            this.RLI.Name = "RLI";
            this.RLI.Width = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prob Numbers";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProbsStatistics_textBox
            // 
            this.ProbsStatistics_textBox.Location = new System.Drawing.Point(28, 659);
            this.ProbsStatistics_textBox.Multiline = true;
            this.ProbsStatistics_textBox.Name = "ProbsStatistics_textBox";
            this.ProbsStatistics_textBox.Size = new System.Drawing.Size(280, 191);
            this.ProbsStatistics_textBox.TabIndex = 6;
            // 
            // searchValue_textBox
            // 
            this.searchValue_textBox.Location = new System.Drawing.Point(1001, 23);
            this.searchValue_textBox.Name = "searchValue_textBox";
            this.searchValue_textBox.Size = new System.Drawing.Size(145, 20);
            this.searchValue_textBox.TabIndex = 3;
            // 
            // searchResults_textBox
            // 
            this.searchResults_textBox.Location = new System.Drawing.Point(1001, 48);
            this.searchResults_textBox.Multiline = true;
            this.searchResults_textBox.Name = "searchResults_textBox";
            this.searchResults_textBox.Size = new System.Drawing.Size(317, 105);
            this.searchResults_textBox.TabIndex = 8;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1174, 23);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(144, 23);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // numberRange_textBox
            // 
            this.numberRange_textBox.Location = new System.Drawing.Point(79, 23);
            this.numberRange_textBox.Name = "numberRange_textBox";
            this.numberRange_textBox.Size = new System.Drawing.Size(43, 20);
            this.numberRange_textBox.TabIndex = 3;
            this.numberRange_textBox.Text = "900";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "0 -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Array Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(691, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Algorithms Comparator";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(876, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "by Fatih Özdemir";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(723, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 36);
            this.label13.TabIndex = 10;
            this.label13.Text = "Coalesced Hashing";
            // 
            // file_organization_algorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 884);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.searchResults_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EICH_textBox);
            this.Controls.Add(this.ProbsStatistics_textBox);
            this.Controls.Add(this.LICH_textBox);
            this.Controls.Add(this.EISCH_dataGrid);
            this.Controls.Add(this.RLISCH_dataGrid);
            this.Controls.Add(this.BEISCH_dataGrid);
            this.Controls.Add(this.EICH_dataGrid);
            this.Controls.Add(this.LICH_dataGrid);
            this.Controls.Add(this.probCom_dataGrid);
            this.Controls.Add(this.LISCH_dataGrid);
            this.Controls.Add(this.searchValue_textBox);
            this.Controls.Add(this.numberRange_textBox);
            this.Controls.Add(this.arraySizeValue);
            this.Controls.Add(this.generateNumberButton);
            this.Name = "file_organization_algorithms";
            this.Text = "organization_algo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LISCH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LICH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISCH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EICH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEISCH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLISCH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probCom_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.TextBox arraySizeValue;
        private System.Windows.Forms.DataGridView LISCH_dataGrid;
        private System.Windows.Forms.DataGridView LICH_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.TextBox LICH_textBox;
        private System.Windows.Forms.DataGridView EISCH_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridView EICH_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn3;
        private System.Windows.Forms.TextBox EICH_textBox;
        private System.Windows.Forms.DataGridView BEISCH_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridView RLISCH_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView probCom_dataGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProbsStatistics_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLI;
        private System.Windows.Forms.TextBox searchValue_textBox;
        private System.Windows.Forms.TextBox searchResults_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox numberRange_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

