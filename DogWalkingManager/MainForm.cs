using DogWalkingManager.Infrastructure.DataContext;
using DogWalkingManager.Infrastructure.Repositories;

namespace DogWalkingManager;

/// <summary>
/// Main form for managing clients, dogs, and walks.
/// </summary>
public partial class MainForm : Form
{
 
    private readonly InMemoryContext _context;
    private readonly ClientRepository _clientRepository;
    private readonly DogRepository _dogRepository;
    private readonly WalkRepository _walkRepository;

    public MainForm()
    {
        InitializeComponent();

        _context = new InMemoryContext();
        _clientRepository = new ClientRepository(_context);
        _dogRepository = new DogRepository(_context);
        _walkRepository = new WalkRepository(_context);
    }
}
