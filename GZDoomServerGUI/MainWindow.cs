namespace GZDoomServerGUI;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // If it can't find environment variable "GZDOOM", it defaults to the path of the dev's GZDoom installation
    private string GzDoom
    {
        get
        {
            string? env = Environment.GetEnvironmentVariable("GZDOOM");
            return env ?? @"C:\Apps\DOOM\gzdoom\gzdoom.exe";
        }
    }

    private void btnHostServer_Click(object sender, EventArgs e)
    {
        List<string> config = GetAllHostInputs();
        string configStr = String.Join(" ", config.ToArray());

        System.Diagnostics.Process.Start(GzDoom, configStr);
    }

    private void btnJoinServer_Click(object sender, EventArgs e)
    {
        var config = GetAllJoinInputs();
        string configStr = String.Join(" ", config.ToArray());

        System.Diagnostics.Process.Start(GzDoom, configStr);
    }

    // Checks which textboxes have been set and adds their values to the command
    private List<string> GetAllHostInputs()
    {
        var config = new List<string>();

        if (textWadName.Text.Trim() != string.Empty)
            config.Add($"-iwad {textWadName.Text.Trim()}");

        if (textboxNPlayer.Text.Trim() != string.Empty)
            config.Add($"-host {textboxNPlayer.Text.Trim()}");

        if (textboxSkill.Text.Trim() != string.Empty)
            config.Add($"-skill {textboxSkill.Text.Trim()}");

        if (textboxLevel.Text.Trim() != string.Empty)
            config.Add($"-warp {textboxLevel.Text.Trim()}");

        if (checkDeathmatch.Checked)
            config.Add("-deathmatch");

        if (!checkMonsters.Checked)
            config.Add("-nomonsters");

        return config;
    }

    // Checks which textboxes have been set and adds their values to the command
    private List<string> GetAllJoinInputs()
    {
        var config = new List<string>();

        if (textboxWadJoin.Text.Trim() != string.Empty)
            config.Add($"-iwad {textboxWadJoin.Text.Trim()}");

        config.Add($"-join {textboxHostIp.Text.Trim()}");

        return config;
    }
}