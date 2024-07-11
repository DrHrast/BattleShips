using Battleship.GUI.Models;

namespace Battleship.GUI;

public partial class GamePage : ContentPage
{
	private GameModel _enemyGrid;
	private GameModel _friendlyGrid;

	public GamePage(int rows, int columns)
	{
		InitializeComponent();
	}

	private void LoadGameData(int rows, int columns)
	{
		_enemyGrid = new GameModel(rows, columns);
		_friendlyGrid = new GameModel(rows, columns);
	}
}