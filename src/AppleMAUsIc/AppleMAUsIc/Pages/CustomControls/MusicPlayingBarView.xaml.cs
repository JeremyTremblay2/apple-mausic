namespace AppleMAUsIc.Pages.CustomControls;

public partial class MusicPlayingBarView : ContentView
{
    public static readonly BindableProperty TrackTitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(MusicPlayingBarView), string.Empty);

    public string Title
    {
        get => (string)GetValue(MusicPlayingBarView.TrackTitleProperty);
        set => SetValue(MusicPlayingBarView.TrackTitleProperty, value);
    }

    public static readonly BindableProperty ImageNameProperty =
        BindableProperty.Create(nameof(CoverImageName), typeof(string), typeof(MusicPlayingBarView), string.Empty);

    public string CoverImageName
    {
        get => (string)GetValue(MusicPlayingBarView.ImageNameProperty);
        set => SetValue(MusicPlayingBarView.ImageNameProperty, value);
    }

    public MusicPlayingBarView()
    {
        InitializeComponent();
    }
}
