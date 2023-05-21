namespace AppleMAUsIc.Pages.CustomControls;

public partial class AlbumCoverView : ContentView
{
    public static readonly BindableProperty ImageWidthProperty =
        BindableProperty.Create(nameof(ImageWidth), typeof(int), typeof(AlbumCoverView), 50);

    public int ImageWidth
    {
        get => (int)GetValue(AlbumCoverView.ImageWidthProperty);
        set => SetValue(AlbumCoverView.ImageWidthProperty, value);
    }

    public static readonly BindableProperty ImageHeightProperty =
        BindableProperty.Create(nameof(ImageHeight), typeof(int), typeof(AlbumCoverView), 50);

    public int ImageHeight
    {
        get => (int)GetValue(AlbumCoverView.ImageHeightProperty);
        set => SetValue(AlbumCoverView.ImageHeightProperty, value);
    }

    public static readonly BindableProperty CoverImageNameProperty =
        BindableProperty.Create(nameof(CoverImageName), typeof(string), typeof(AlbumCoverView), string.Empty);

    public string CoverImageName
    {
        get => (string)GetValue(AlbumCoverView.CoverImageNameProperty);
        set => SetValue(AlbumCoverView.CoverImageNameProperty, value);
    }

    public AlbumCoverView()
	{
        InitializeComponent();
        Content.BindingContext = this;
    }
}
