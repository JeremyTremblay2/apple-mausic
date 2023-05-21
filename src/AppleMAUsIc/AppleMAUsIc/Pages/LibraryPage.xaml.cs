using AppleMAUsIc.Model;

namespace AppleMAUsIc.Pages;

public partial class LibraryPage : ContentPage
{
	private Album album;

	public LibraryPage()
	{
        var albums = new Stub().LoadAlbums();
        album = albums[new Random().Next(albums.Count)];
        BindingContext = album;
        InitializeComponent();
	}
}
