namespace AppleMAUsIc.Pages;

using AppleMAUsIc.Model;

public partial class ListenPage : ContentPage
{
	private Album album;

    public ListenPage()
	{
		var albums = new Stub().LoadAlbums();
		album = albums[new Random().Next(albums.Count)];
		BindingContext = album;
		InitializeComponent();
	}
}
