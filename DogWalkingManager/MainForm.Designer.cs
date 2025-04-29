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
        this.txtClientName = new System.Windows.Forms.TextBox();
        this.txtPhoneNumber = new System.Windows.Forms.TextBox();
        this.txtDogName = new System.Windows.Forms.TextBox();
        this.txtBreed = new System.Windows.Forms.TextBox();
        this.nudAge = new System.Windows.Forms.NumericUpDown();
        this.dtpWalkDate = new System.Windows.Forms.DateTimePicker();
        this.nudDuration = new System.Windows.Forms.NumericUpDown();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.dgvData = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
        this.SuspendLayout();

        // txtClientName
        this.txtClientName.Location = new System.Drawing.Point(30, 30);
        this.txtClientName.Name = "txtClientName";
        this.txtClientName.PlaceholderText = "Client Name";
        this.txtClientName.Size = new System.Drawing.Size(200, 23);
        this.txtClientName.TabIndex = 0;

        // txtPhoneNumber
        this.txtPhoneNumber.Location = new System.Drawing.Point(250, 30);
        this.txtPhoneNumber.Name = "txtPhoneNumber";
        this.txtPhoneNumber.PlaceholderText = "Phone Number";
        this.txtPhoneNumber.Size = new System.Drawing.Size(200, 23);
        this.txtPhoneNumber.TabIndex = 1;

        // txtDogName
        this.txtDogName.Location = new System.Drawing.Point(30, 70);
        this.txtDogName.Name = "txtDogName";
        this.txtDogName.PlaceholderText = "Dog Name";
        this.txtDogName.Size = new System.Drawing.Size(200, 23);
        this.txtDogName.TabIndex = 2;

        // txtBreed
        this.txtBreed.Location = new System.Drawing.Point(250, 70);
        this.txtBreed.Name = "txtBreed";
        this.txtBreed.PlaceholderText = "Breed";
        this.txtBreed.Size = new System.Drawing.Size(200, 23);
        this.txtBreed.TabIndex = 3;

        // nudAge
        this.nudAge.Location = new System.Drawing.Point(470, 70);
        this.nudAge.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        this.nudAge.Name = "nudAge";
        this.nudAge.Size = new System.Drawing.Size(60, 23);
        this.nudAge.TabIndex = 4;

        // dtpWalkDate
        this.dtpWalkDate.Location = new System.Drawing.Point(30, 110);
        this.dtpWalkDate.Name = "dtpWalkDate";
        this.dtpWalkDate.Size = new System.Drawing.Size(250, 23);
        this.dtpWalkDate.TabIndex = 5;

        // nudDuration
        this.nudDuration.Location = new System.Drawing.Point(300, 110);
        this.nudDuration.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        this.nudDuration.Name = "nudDuration";
        this.nudDuration.Size = new System.Drawing.Size(80, 23);
        this.nudDuration.TabIndex = 6;

        // btnSave
        this.btnSave.Location = new System.Drawing.Point(30, 150);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(80, 30);
        this.btnSave.TabIndex = 7;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

        // btnClear
        this.btnClear.Location = new System.Drawing.Point(130, 150);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(80, 30);
        this.btnClear.TabIndex = 8;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

        // btnDelete
        this.btnDelete.Location = new System.Drawing.Point(230, 150);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(80, 30);
        this.btnDelete.TabIndex = 9;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

        // btnExit
        this.btnExit.Location = new System.Drawing.Point(330, 150);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(80, 30);
        this.btnExit.TabIndex = 10;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

        // dgvData
        this.dgvData.AllowUserToAddRows = false;
        this.dgvData.AllowUserToDeleteRows = false;
        this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvData.Location = new System.Drawing.Point(30, 200);
        this.dgvData.Name = "dgvData";
        this.dgvData.ReadOnly = true;
        this.dgvData.RowTemplate.Height = 25;
        this.dgvData.Size = new System.Drawing.Size(600, 200);
        this.dgvData.TabIndex = 11;

        // MainForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(680, 430);
        this.Controls.Add(this.dgvData);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.nudDuration);
        this.Controls.Add(this.dtpWalkDate);
        this.Controls.Add(this.nudAge);
        this.Controls.Add(this.txtBreed);
        this.Controls.Add(this.txtDogName);
        this.Controls.Add(this.txtPhoneNumber);
        this.Controls.Add(this.txtClientName);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Dog Walking Manager";
        ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}