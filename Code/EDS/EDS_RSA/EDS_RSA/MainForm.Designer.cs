namespace EDS_RSA;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        pLabel = new System.Windows.Forms.Label();
        qLabel = new System.Windows.Forms.Label();
        dLabel = new System.Windows.Forms.Label();
        pTextBox = new System.Windows.Forms.TextBox();
        qTextBox = new System.Windows.Forms.TextBox();
        dTextBox = new System.Windows.Forms.TextBox();
        getParamsButton = new System.Windows.Forms.Button();
        rLabel = new System.Windows.Forms.Label();
        rTextBox = new System.Windows.Forms.TextBox();
        eulerLabel = new System.Windows.Forms.Label();
        eulerTextBox = new System.Windows.Forms.TextBox();
        eLabel = new System.Windows.Forms.Label();
        eTextBox = new System.Windows.Forms.TextBox();
        createRadioButton = new System.Windows.Forms.RadioButton();
        checkRadioButton = new System.Windows.Forms.RadioButton();
        getEDSButton = new System.Windows.Forms.Button();
        sourceTextBox = new System.Windows.Forms.TextBox();
        sourceLabel = new System.Windows.Forms.Label();
        hashLabel = new System.Windows.Forms.Label();
        hashTextBox = new System.Windows.Forms.TextBox();
        EDSLabel = new System.Windows.Forms.Label();
        edsTextBox = new System.Windows.Forms.TextBox();
        
        SuspendLayout();
        // 
        // pLabel
        // 
        pLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        pLabel.Location = new System.Drawing.Point(9, 42);
        pLabel.Name = "pLabel";
        pLabel.Size = new System.Drawing.Size(49, 40);
        pLabel.TabIndex = 0;
        pLabel.Text = "P:";
        // 
        // qLabel
        // 
        qLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        qLabel.Location = new System.Drawing.Point(9, 92);
        qLabel.Name = "qLabel";
        qLabel.Size = new System.Drawing.Size(49, 35);
        qLabel.TabIndex = 1;
        qLabel.Text = "Q:";
        // 
        // dLabel
        // 
        dLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        dLabel.Location = new System.Drawing.Point(9, 144);
        dLabel.Name = "dLabel";
        dLabel.Size = new System.Drawing.Size(49, 35);
        dLabel.TabIndex = 2;
        dLabel.Text = "D:";
        // 
        // pTextBox
        // 
        pTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        pTextBox.Location = new System.Drawing.Point(64, 42);
        pTextBox.Name = "pTextBox";
        pTextBox.Size = new System.Drawing.Size(205, 39);
        pTextBox.TabIndex = 3;
        // 
        // qTextBox
        // 
        qTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        qTextBox.Location = new System.Drawing.Point(64, 92);
        qTextBox.Name = "qTextBox";
        qTextBox.Size = new System.Drawing.Size(205, 39);
        qTextBox.TabIndex = 4;
        // 
        // dTextBox
        // 
        dTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        dTextBox.Location = new System.Drawing.Point(64, 144);
        dTextBox.Name = "dTextBox";
        dTextBox.Size = new System.Drawing.Size(205, 39);
        dTextBox.TabIndex = 5;
        // 
        // getParamsButton
        // 
        getParamsButton.Location = new System.Drawing.Point(64, 202);
        getParamsButton.Name = "getParamsButton";
        getParamsButton.Size = new System.Drawing.Size(204, 43);
        getParamsButton.TabIndex = 6;
        getParamsButton.Text = "Рассчитать параметры";
        getParamsButton.UseVisualStyleBackColor = true;
        getParamsButton.Click += getParamsButton_Click;
        // 
        // rLabel
        // 
        rLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        rLabel.Location = new System.Drawing.Point(9, 263);
        rLabel.Name = "rLabel";
        rLabel.Size = new System.Drawing.Size(49, 35);
        rLabel.TabIndex = 7;
        rLabel.Text = "R:";
        // 
        // rTextBox
        // 
        rTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        rTextBox.Location = new System.Drawing.Point(64, 263);
        rTextBox.Name = "rTextBox";
        rTextBox.ReadOnly = true;
        rTextBox.Size = new System.Drawing.Size(205, 39);
        rTextBox.TabIndex = 8;
        // 
        // eulerLabel
        // 
        eulerLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        eulerLabel.Location = new System.Drawing.Point(9, 321);
        eulerLabel.Name = "eulerLabel";
        eulerLabel.Size = new System.Drawing.Size(59, 35);
        eulerLabel.TabIndex = 9;
        eulerLabel.Text = "F(r):";
        // 
        // eulerTextBox
        // 
        eulerTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        eulerTextBox.Location = new System.Drawing.Point(63, 321);
        eulerTextBox.Name = "eulerTextBox";
        eulerTextBox.ReadOnly = true;
        eulerTextBox.Size = new System.Drawing.Size(205, 39);
        eulerTextBox.TabIndex = 10;
        // 
        // eLabel
        // 
        eLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        eLabel.Location = new System.Drawing.Point(9, 387);
        eLabel.Name = "eLabel";
        eLabel.Size = new System.Drawing.Size(49, 35);
        eLabel.TabIndex = 11;
        eLabel.Text = "E:";
        // 
        // eTextBox
        // 
        eTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        eTextBox.Location = new System.Drawing.Point(64, 383);
        eTextBox.Name = "eTextBox";
        eTextBox.ReadOnly = true;
        eTextBox.Size = new System.Drawing.Size(205, 39);
        eTextBox.TabIndex = 12;
        // 
        // createRadioButton
        // 
        createRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F);
        createRadioButton.Location = new System.Drawing.Point(26, 459);
        createRadioButton.Name = "createRadioButton";
        createRadioButton.Size = new System.Drawing.Size(307, 39);
        createRadioButton.TabIndex = 13;
        createRadioButton.TabStop = true;
        createRadioButton.Text = "Создать цифровую подпись";
        createRadioButton.UseVisualStyleBackColor = true;
        // 
        // checkRadioButton
        // 
        checkRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F);
        checkRadioButton.Location = new System.Drawing.Point(26, 504);
        checkRadioButton.Name = "checkRadioButton";
        checkRadioButton.Size = new System.Drawing.Size(343, 39);
        checkRadioButton.TabIndex = 14;
        checkRadioButton.TabStop = true;
        checkRadioButton.Text = "Проверить цифровую подпись";
        checkRadioButton.UseVisualStyleBackColor = true;
        // 
        // getEDSButton
        // 
        getEDSButton.Enabled = false;
        getEDSButton.Location = new System.Drawing.Point(63, 572);
        getEDSButton.Name = "getEDSButton";
        getEDSButton.Size = new System.Drawing.Size(206, 42);
        getEDSButton.TabIndex = 15;
        getEDSButton.Text = "Рассчиатть";
        getEDSButton.UseVisualStyleBackColor = true;
        getEDSButton.Click += getEDSButton_Click;
        // 
        // sourceTextBox
        // 
        sourceTextBox.Location = new System.Drawing.Point(292, 92);
        sourceTextBox.Multiline = true;
        sourceTextBox.Name = "sourceTextBox";
        sourceTextBox.Size = new System.Drawing.Size(637, 171);
        sourceTextBox.TabIndex = 16;
        // 
        // sourceLabel
        // 
        sourceLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        sourceLabel.Location = new System.Drawing.Point(292, 49);
        sourceLabel.Name = "sourceLabel";
        sourceLabel.Size = new System.Drawing.Size(230, 40);
        sourceLabel.TabIndex = 17;
        sourceLabel.Text = "Исходный текст:";
        // 
        // hashLabel
        // 
        hashLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        hashLabel.Location = new System.Drawing.Point(292, 280);
        hashLabel.Name = "hashLabel";
        hashLabel.Size = new System.Drawing.Size(230, 40);
        hashLabel.TabIndex = 18;
        hashLabel.Text = "Хэш-образ:";
        // 
        // hashTextBox
        // 
        hashTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        hashTextBox.Location = new System.Drawing.Point(292, 323);
        hashTextBox.Name = "hashTextBox";
        hashTextBox.ReadOnly = true;
        hashTextBox.Size = new System.Drawing.Size(205, 39);
        hashTextBox.TabIndex = 19;
        // 
        // EDSLabel
        // 
        EDSLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        EDSLabel.Location = new System.Drawing.Point(563, 280);
        EDSLabel.Name = "EDSLabel";
        EDSLabel.Size = new System.Drawing.Size(230, 40);
        EDSLabel.TabIndex = 20;
        EDSLabel.Text = "ЭЦП:";
        // 
        // edsTextBox
        // 
        edsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        edsTextBox.Location = new System.Drawing.Point(563, 323);
        edsTextBox.Name = "edsTextBox";
        edsTextBox.ReadOnly = true;
        edsTextBox.Size = new System.Drawing.Size(205, 39);
        edsTextBox.TabIndex = 21;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(971, 654);
       
        Controls.Add(edsTextBox);
        Controls.Add(EDSLabel);
        Controls.Add(hashTextBox);
        Controls.Add(hashLabel);
        Controls.Add(sourceLabel);
        Controls.Add(sourceTextBox);
        Controls.Add(getEDSButton);
        Controls.Add(checkRadioButton);
        Controls.Add(createRadioButton);
        Controls.Add(eTextBox);
        Controls.Add(eLabel);
        Controls.Add(eulerTextBox);
        Controls.Add(eulerLabel);
        Controls.Add(rTextBox);
        Controls.Add(rLabel);
        Controls.Add(getParamsButton);
        Controls.Add(dTextBox);
        Controls.Add(qTextBox);
        Controls.Add(pTextBox);
        Controls.Add(dLabel);
        Controls.Add(pLabel);
        Controls.Add(qLabel);
        Location = new System.Drawing.Point(22, 22);
        Text = "MainForm";
        ResumeLayout(false);
        PerformLayout();
    }

    

    private System.Windows.Forms.TextBox hashTextBox;
    private System.Windows.Forms.Label EDSLabel;
    private System.Windows.Forms.TextBox edsTextBox;

    private System.Windows.Forms.Label hashLabel;

    private System.Windows.Forms.Label sourceLabel;

    private System.Windows.Forms.TextBox sourceTextBox;

    private System.Windows.Forms.Button getEDSButton;

    private System.Windows.Forms.RadioButton checkRadioButton;

    private System.Windows.Forms.RadioButton createRadioButton;

    private System.Windows.Forms.Label eLabel;
    private System.Windows.Forms.TextBox eTextBox;

    private System.Windows.Forms.Label rLabel;
    private System.Windows.Forms.TextBox rTextBox;
    private System.Windows.Forms.Label eulerLabel;
    private System.Windows.Forms.TextBox eulerTextBox;

    private System.Windows.Forms.Button getParamsButton;

    private System.Windows.Forms.Label dLabel;
    private System.Windows.Forms.TextBox pTextBox;
    private System.Windows.Forms.TextBox qTextBox;
    private System.Windows.Forms.TextBox dTextBox;

    private System.Windows.Forms.Label qLabel;

    private System.Windows.Forms.Label pLabel;

    #endregion
}