namespace GZDoomServerGUI;

// This partial class contains all Button-related logic
public partial class MainWindow
{
    // Tries to get the environment variable GZDOOM
    public static string? GzDoom
        => Environment.GetEnvironmentVariable("GZDOOM");


    // Button to host a game
    private void btnHostServer_Click(object sender, EventArgs e)
    {
        // Converts the List to one string of cmd commands
        string configStr = string.Join(
            " ",
            GetAllHostInputs().ToArray());

        // Executes GZDoom with the string of cmd commands
        System.Diagnostics.Process.Start(GzDoom ?? string.Empty, configStr);
    }


    // Button to join a game
    private void btnJoinServer_Click(object sender, EventArgs e)
    {
        // Converts the List to one string of cmd commands
        string configStr = string.Join(
            " ",
            GetAllJoinInputs().ToArray());

        // Executes GZDoom with the string of cmd commands
        System.Diagnostics.Process.Start(GzDoom ?? string.Empty, configStr);
    }
}