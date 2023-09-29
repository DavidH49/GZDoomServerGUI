namespace GZDoomServerGUI;

// This partial class contains all Button-related logic
public partial class MainWindow
{
    // Tries to get the environment variable GZDOOM
    public static string? GzDoom
        => Environment.GetEnvironmentVariable("GZDOOM");


    // Executes when the Host button is pressed
    private void btnHostServer_Click(object sender, EventArgs e) {
        HostInputs inputs = GetHostInputs();
        List<string> inputsList = EvaluateHostInputs(inputs);

        // Converts the List to one string of cmd commands
        string configStr = string.Join(" ", inputsList.ToArray());

        // Executes GZDoom with the string of cmd commands
        System.Diagnostics.Process.Start(GzDoom ?? string.Empty, configStr);
    }


    // Executes when the Join button is pressed
    private void btnJoinServer_Click(object sender, EventArgs e) {
        JoinInputs inputs = GetJoinInputs();
        List<string> inputsList = EvaluateJoinInputs(inputs);

        // Converts the List to one string of cmd commands
        string configStr = string.Join(" ", inputsList.ToArray());

        // Executes GZDoom with the string of cmd commands
        System.Diagnostics.Process.Start(GzDoom ?? string.Empty, configStr);
    }
}