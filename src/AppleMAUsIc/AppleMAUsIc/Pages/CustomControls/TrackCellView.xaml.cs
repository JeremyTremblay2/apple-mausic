namespace AppleMAUsIc.Pages.CustomControls;

public partial class TrackCellView : ContentView
{
    public static readonly BindableProperty IsSingleProperty =
        BindableProperty.Create(nameof(IsSingle), typeof(bool), typeof(TrackCellView), false);

    public bool IsSingle
    {
        get => (bool) GetValue(TrackCellView.IsSingleProperty);
        set => SetValue(TrackCellView.IsSingleProperty, value);
    }

    public static readonly BindableProperty PositionProperty =
        BindableProperty.Create(nameof(Position), typeof(int), typeof(TrackCellView), 1);

    public int Position
    {
        get => (int) GetValue(TrackCellView.PositionProperty);
        set => SetValue(TrackCellView.PositionProperty, value);
    }

    public static readonly BindableProperty TrackTitleProperty =
        BindableProperty.Create(nameof(TrackTitle), typeof(string), typeof(TrackCellView), string.Empty);

    public string TrackTitle
    {
        get => (string) GetValue(TrackCellView.TrackTitleProperty);
        set => SetValue(TrackCellView.TrackTitleProperty, value);
    }

    public TrackCellView()
	{
		InitializeComponent();
        BindingContext = this;
    }
}
