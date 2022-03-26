using OOPProject.SourceFiles.Repositories;

namespace OOPProject;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
		UsersRepository repository = new UsersRepository();
		repository.List();
	}
}
