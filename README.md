# 🏆 MyMilestoneTracker - .NET MAUI Stepper/Wizard App

A simple **cross-platform .NET MAUI application** that allows users to go through multiple steps (wizard) and enter information in each step. Each step can contain any type of UI elements like labels, entries, or custom views.

---

## 📚 Features

- Step-based navigation with **Next** and **Back** buttons  
- Fully customizable step content (labels, entries, grids, etc.)  
- Define steps entirely in **XAML**, no need for C# population  
- Automatically shows the **first step** when the app starts  
- Supports multiple input fields per step  
- Responsive UI for mobile and desktop  

---

## 📺 Video

https://github.com/user-attachments/assets/964ba4b2-044e-438d-9dfd-6f6eb27b011f

---

## 🚀 Getting Started

### Prerequisites
- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/get-started/installation) installed  
- Visual Studio 2022/2025 with MAUI workload  
- Windows or Mac for building the project  

### Running the App
1. Clone the repository:  
```bash
git clone https://github.com/Kiriakos41/MyMilestoneTracker.git
```
2. Open the solution in Visual Studio.
3. Set the target platform (Android, iOS, Windows) and run the app.
4. The app will launch and display a stepper wizard with multiple steps.
5. 
---

## 🚀 Usage

1. Click Next to go to the next step.
2. Click Back to return to the previous step.
3. Customize steps by editing the XAML inside StepperControl.Steps.
4. Each step can contain multiple inputs, labels, or custom views.

---

## ⚙️ How It Works

1. StepperControl is a custom ContentView that holds an ObservableCollection<View> called Steps.
2. Each step is a View (usually a VerticalStackLayout) containing labels, entries, or any content.
3. Navigation updates the displayed content with a ContentPresenter.
4. The first step is displayed automatically on app start.

---

🤝 Contributing

Feel free to contribute by creating pull requests or issues. Suggestions to improve the StepperControl or add features are welcome.
