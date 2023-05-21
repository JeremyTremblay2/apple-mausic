namespace AppleMAUsIc.Pages.CustomControls;

public partial class ImageButtonView : ContentView
{
    public static readonly BindableProperty MaximumIconHeightRequestProperty =
        BindableProperty.Create(nameof(MaximumIconHeightRequest), typeof(int), typeof(ImageButtonView), 24);

    public int MaximumIconHeightRequest
    {
        get => (int)GetValue(ImageButtonView.MaximumIconHeightRequestProperty);
        set => SetValue(ImageButtonView.MaximumIconHeightRequestProperty, value);
    }

    public static readonly BindableProperty MaximumIconWidthRequestProperty =
        BindableProperty.Create(nameof(MaximumIconWidthRequest), typeof(int), typeof(ImageButtonView), 24);

    public int MaximumIconWidthRequest
    {
        get => (int)GetValue(ImageButtonView.MaximumIconWidthRequestProperty);
        set => SetValue(ImageButtonView.MaximumIconWidthRequestProperty, value);
    }

    public static readonly BindableProperty MinimumButtonWidthRequestProperty =
        BindableProperty.Create(nameof(MinimumButtonWidthRequest), typeof(int), typeof(ImageButtonView), 200);

    public int MinimumButtonWidthRequest
    {
        get => (int)GetValue(ImageButtonView.MinimumButtonWidthRequestProperty);
        set => SetValue(ImageButtonView.MinimumButtonWidthRequestProperty, value);
    }

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(ImageButtonView), string.Empty);

    public string Text
    {
        get => (string)GetValue(ImageButtonView.TextProperty);
        set => SetValue(ImageButtonView.TextProperty, value);
    }

    public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(ImageButtonView), string.Empty);

    public string ImageSource
    {
        get => (string)GetValue(ImageButtonView.ImageSourceProperty);
        set => SetValue(ImageButtonView.ImageSourceProperty, value);
    }

    public ImageButtonView()
	{
		InitializeComponent();
		Content.BindingContext = this;
	}
}
