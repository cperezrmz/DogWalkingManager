using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Infrastructure.DataContext;
using DogWalkingManager.Infrastructure.Repositories;
using DogWalkingManager.Infrastructure.Persistence;
using DogWalkingManager.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DogWalkingManager
{
    /// <summary>
    /// Main form for managing clients, dogs, and walks.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly InMemoryContext _context;
        private readonly DogWalkingService _dogWalkingService;
        private readonly ClientRepository _clientRepository;
        private readonly DogRepository _dogRepository;
        private readonly WalkRepository _walkRepository;
        private readonly JsonDataStoreService _dataStore;

        /// <summary>
        /// Initializes the MainForm and sets up dependencies and UI.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _context = new InMemoryContext();
            _dataStore = new JsonDataStoreService();
            _dataStore.LoadData(_context.Clients, _context.Dogs, _context.Walks);

            _dogWalkingService = new DogWalkingService(_context);
            _clientRepository = new ClientRepository(_context);
            _dogRepository = new DogRepository(_context);
            _walkRepository = new WalkRepository(_context);

            dgvData.Columns.Clear();
            dgvData.Columns.Add("ClientName", "Client Name");
            dgvData.Columns.Add("PhoneNumber", "Phone Number");
            dgvData.Columns.Add("DogName", "Dog Name");
            dgvData.Columns.Add("Breed", "Breed");
            dgvData.Columns.Add("Age", "Age");
            dgvData.Columns.Add("WalkDate", "Walk Date");
            dgvData.Columns.Add("Duration", "Duration (min)");

            RefreshDataGrid();

            this.FormClosing += MainForm_FormClosing;
        }

        /// <summary>
        /// Saves entered data after validating all fields.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string clientName = txtClientName.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string dogName = txtDogName.Text.Trim();
            string breed = txtBreed.Text.Trim();
            int age = (int)nudAge.Value;
            DateTime walkDate = dtpWalkDate.Value;
            int duration = (int)nudDuration.Value;

            if (string.IsNullOrWhiteSpace(clientName))
            {
                MessageBox.Show("Client name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(dogName))
            {
                MessageBox.Show("Dog name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidationHelper.IsValidPhone(phone))
            {
                MessageBox.Show("Phone number must be at least 8 digits and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidationHelper.IsValidAge(age))
            {
                MessageBox.Show("Age must be between 1 and 30.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dogWalkingService.SaveClientDogAndWalk(clientName, phone, dogName, breed, age, walkDate, duration);
            RefreshDataGrid();
            ClearFields();
            MessageBox.Show("Information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Deletes the selected client and related data.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                var clientName = dgvData.SelectedRows[0].Cells[0].Value?.ToString();
                _dogWalkingService.DeleteClientByName(clientName);
                RefreshDataGrid();
            }
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Reloads the data grid with the latest data.
        /// </summary>
        private void RefreshDataGrid()
        {
            dgvData.Rows.Clear();
            foreach (var client in _clientRepository.GetAll())
            {
                var dog = _dogRepository.GetAll().FirstOrDefault(d => d.ClientId == client.Id);
                if (dog != null)
                {
                    var walk = _walkRepository.GetAll().FirstOrDefault(w => w.DogId == dog.Id);
                    dgvData.Rows.Add(
                        client.Name,
                        client.PhoneNumber,
                        dog.Name,
                        dog.Breed,
                        dog.Age,
                        walk?.WalkDate.ToShortDateString(),
                        walk?.DurationMinutes
                    );
                }
            }
        }

        /// <summary>
        /// Clears all input fields on the form.
        /// </summary>
        private void ClearFields()
        {
            txtClientName.Clear();
            txtPhoneNumber.Clear();
            txtDogName.Clear();
            txtBreed.Clear();
            nudAge.Value = 0;
            dtpWalkDate.Value = DateTime.Now;
            nudDuration.Value = 30;
        }

        /// <summary>
        /// Handles form closing event to persist data.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataStore.SaveData(_context.Clients, _context.Dogs, _context.Walks);
        }
    }
}
