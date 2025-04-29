namespace DogWalkingManager;

partial class MainForm
{    


    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtClientName;
    private System.Windows.Forms.TextBox txtPhoneNumber;
    private System.Windows.Forms.TextBox txtDogName;
    private System.Windows.Forms.TextBox txtBreed;
    private System.Windows.Forms.NumericUpDown nudAge;
    private System.Windows.Forms.DateTimePicker dtpWalkDate;
    private System.Windows.Forms.NumericUpDown nudDuration;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.DataGridView dgvData;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtClientName = new TextBox();
        txtPhoneNumber = new TextBox();
        txtDogName = new TextBox();
        txtBreed = new TextBox();
        nudAge = new NumericUpDown();
        dtpWalkDate = new DateTimePicker();
        nudDuration = new NumericUpDown();
        btnSave = new Button();
        btnClear = new Button();
        btnDelete = new Button();
        btnExit = new Button();
        dgvData = new DataGridView();
        Age = new Label();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
        SuspendLayout();
        // 
        // txtClientName
        // 
        txtClientName.Location = new Point(30, 30);
        txtClientName.Name = "txtClientName";
        txtClientName.PlaceholderText = "Client Name";
        txtClientName.Size = new Size(200, 23);
        txtClientName.TabIndex = 0;
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new Point(250, 30);
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.PlaceholderText = "Phone Number";
        txtPhoneNumber.Size = new Size(200, 23);
        txtPhoneNumber.TabIndex = 1;
        // 
        // txtDogName
        // 
        txtDogName.Location = new Point(30, 70);
        txtDogName.Name = "txtDogName";
        txtDogName.PlaceholderText = "Dog Name";
        txtDogName.Size = new Size(200, 23);
        txtDogName.TabIndex = 2;
        // 
        // txtBreed
        // 
        txtBreed.Location = new Point(250, 70);
        txtBreed.Name = "txtBreed";
        txtBreed.PlaceholderText = "Breed";
        txtBreed.Size = new Size(200, 23);
        txtBreed.TabIndex = 3;
        // 
        // nudAge
        // 
        nudAge.Location = new Point(470, 70);
        nudAge.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        nudAge.Name = "nudAge";
        nudAge.Size = new Size(60, 23);
        nudAge.TabIndex = 4;
        // 
        // dtpWalkDate
        // 
        dtpWalkDate.Location = new Point(30, 110);
        dtpWalkDate.Name = "dtpWalkDate";
        dtpWalkDate.Size = new Size(250, 23);
        dtpWalkDate.TabIndex = 5;
        // 
        // nudDuration
        // 
        nudDuration.Location = new Point(350, 110);
        nudDuration.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        nudDuration.Name = "nudDuration";
        nudDuration.Size = new Size(80, 23);
        nudDuration.TabIndex = 6;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(30, 150);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 30);
        btnSave.TabIndex = 7;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(130, 150);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(80, 30);
        btnClear.TabIndex = 8;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(230, 150);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(80, 30);
        btnDelete.TabIndex = 9;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(330, 150);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(80, 30);
        btnExit.TabIndex = 10;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // dgvData
        // 
        dgvData.AllowUserToAddRows = false;
        dgvData.AllowUserToDeleteRows = false;
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvData.Location = new Point(30, 200);
        dgvData.Name = "dgvData";
        dgvData.ReadOnly = true;
        dgvData.RowTemplate.Height = 25;
        dgvData.Size = new Size(600, 200);
        dgvData.TabIndex = 11;
        // 
        // Age
        // 
        Age.AutoSize = true;
        Age.Location = new Point(471, 50);
        Age.Name = "Age";
        Age.Size = new Size(28, 15);
        Age.TabIndex = 12;
        Age.Text = "Age";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(291, 112);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 13;
        label1.Text = "Duration";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(680, 430);
        Controls.Add(label1);
        Controls.Add(Age);
        Controls.Add(dgvData);
        Controls.Add(btnExit);
        Controls.Add(btnDelete);
        Controls.Add(btnClear);
        Controls.Add(btnSave);
        Controls.Add(nudDuration);
        Controls.Add(dtpWalkDate);
        Controls.Add(nudAge);
        Controls.Add(txtBreed);
        Controls.Add(txtDogName);
        Controls.Add(txtPhoneNumber);
        Controls.Add(txtClientName);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dog Walking Manager";
        ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Age;
    private Label label1;
}