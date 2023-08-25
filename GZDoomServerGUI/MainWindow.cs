using System;
using System.IO;

namespace GZDoomServerGUI;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Tries to get the environment variable GZDOOM
    private string? GzDoom
        => Environment.GetEnvironmentVariable("GZDOOM");

    private void btnHostServer_Click(object sender, EventArgs e)
    {
        string configStr = String.Join(
            " ",
            GetAllHostInputs().ToArray());

        System.Diagnostics.Process.Start(GzDoom, configStr);
    }

    private void btnJoinServer_Click(object sender, EventArgs e)
    {
        string configStr = String.Join(
            " ",
            GetAllJoinInputs().ToArray());

        System.Diagnostics.Process.Start(GzDoom, configStr);
    }
}