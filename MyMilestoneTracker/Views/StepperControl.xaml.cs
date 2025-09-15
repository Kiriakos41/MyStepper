using System.Collections.ObjectModel;

namespace MyMilestoneTracker.Views;

public partial class StepperControl : ContentView
{
    public static readonly BindableProperty StepsProperty =
        BindableProperty.Create(
            nameof(Steps),
            typeof(ObservableCollection<View>),
            typeof(StepperControl),
            new ObservableCollection<View>(),
            propertyChanged: OnStepsChanged);

    public ObservableCollection<View> Steps
    {
        get => (ObservableCollection<View>)GetValue(StepsProperty);
        set => SetValue(StepsProperty, value);
    }

    int currentIndex = 0;

    public StepperControl()
    {
        InitializeComponent();

        if (Steps != null)
            Steps.CollectionChanged += (_, __) => ShowStep();
    }

    static void OnStepsChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (StepperControl)bindable;

        if (oldValue is ObservableCollection<View> oldList)
            oldList.CollectionChanged -= (_, __) => control.ShowStep();

        if (newValue is ObservableCollection<View> newList)
            newList.CollectionChanged += (_, __) => control.ShowStep();

        control.currentIndex = 0;
        control.ShowStep();
    }

    void ShowStep()
    {
        if (Steps?.Count > 0 && currentIndex >= 0 && currentIndex < Steps.Count)
            StepPresenter.Content = Steps[currentIndex];
    }

    public void NextStep()
    {
        if (currentIndex < Steps.Count - 1)
        {
            currentIndex++;
            ShowStep();
        }
    }

    public void PreviousStep()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            ShowStep();
        }
    }

    private void OnNextClicked(object sender, EventArgs e) => NextStep();
    private void OnPreviousClicked(object sender, EventArgs e) => PreviousStep();
}
