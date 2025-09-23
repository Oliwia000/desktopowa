namespace desktopowa;

public partial class MainPage : ContentPage
{
    int r = 255, g = 255, b = 255;

    public MainPage()
    {
        InitializeComponent();
        UpdateBigBox();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        r = (int)SliderR.Value;
        g = (int)SliderG.Value;
        b = (int)SliderB.Value;

        LabelR.Text = r.ToString();
        LabelG.Text = g.ToString();
        LabelB.Text = b.ToString();

        UpdateBigBox();
    }

    private void UpdateBigBox()
    {
        BigBox.Color = Color.FromRgb(r, g, b);
    }

    private void OnPobierzClicked(object sender, EventArgs e)
    {
        SmallBox.Color = Color.FromRgb(r, g, b);
        LabelRGB.Text = $"{r}, {g}, {b}";
    }
}
