namespace AppleMAUsIc.Pages.CustomControls;

public partial class MusicPlayingBarView : ContentView
{
    public static readonly BindableProperty TrackTitleProperty =
        BindableProperty.Create(nameof(TrackTitle), typeof(string), typeof(MusicPlayingBarView), string.Empty);

    public string TrackTitle
    {
        get => (string)GetValue(MusicPlayingBarView.TrackTitleProperty);
        set => SetValue(MusicPlayingBarView.TrackTitleProperty, value);
    }

    public static readonly BindableProperty CoverImageNameProperty =
        BindableProperty.Create(nameof(CoverImageName), typeof(string), typeof(MusicPlayingBarView), string.Empty);

    public string CoverImageName
    {
        get => (string)GetValue(MusicPlayingBarView.CoverImageNameProperty);
        set => SetValue(MusicPlayingBarView.CoverImageNameProperty, value);
    }

    public MusicPlayingBarView()
    {
        InitializeComponent();
        Content.BindingContext = this;
    }
}
