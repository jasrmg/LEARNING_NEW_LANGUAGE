//App.xaml.cs
public App()
{
  InitializeComponent();
  MainPage = new MainPage();
}

static SQLiteHelper db;

public static SQLiteHelper SQLiteDb
{
  get
  {
    if (db == null)
    {
      db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LoaclApplicationData),"sample.db3"));
    }
    return db;
  }
}
