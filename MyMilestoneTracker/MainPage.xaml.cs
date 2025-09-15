namespace MyMilestoneTracker;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNextClicked(object sender, EventArgs e)
    {
        Wizard.NextStep();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Wizard.PreviousStep();
    }
}