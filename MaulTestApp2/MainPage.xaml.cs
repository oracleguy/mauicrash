namespace MaulTestApp2;

public partial class MainPage : ContentPage
{
    private readonly PageViewModel vm;
    int count = 0;

	public MainPage(PageViewModel vm)
	{
		InitializeComponent();
        this.vm = vm;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

