namespace GZDoomServerGUI;

// This partial class contains all Textbox-related logic
public partial class MainWindow
{
    // Host Inputs, checks which textboxes have been set and adds their values to the command
    private List<string> GetAllHostInputs()
    {
        var config = new List<string>();

        if (textboxWad.Text.Trim() != string.Empty)
            config.Add($"-iwad {textboxWad.Text.Trim()}");

        if (textboxNPlayer.Text.Trim() != string.Empty)
            config.Add($"-host {textboxNPlayer.Text.Trim()}");

        if (textboxSkill.Text.Trim() != string.Empty)
            config.Add($"-skill {textboxSkill.Text.Trim()}");

        if (textboxLevel.Text.Trim() != string.Empty)
            config.Add($"-warp {textboxLevel.Text.Trim()}");

        if (textboxPort.Text.Trim() != string.Empty)
            config.Add($"-port {textboxPort.Text}");

        if (checkDeathmatch.Checked)
            config.Add("-deathmatch");

        if (!checkMonsters.Checked)
            config.Add("-nomonsters");

        return config;
    }


    // Join Inputs, checks which textboxes have been set and adds their values to the command
    private List<string> GetAllJoinInputs()
    {
        var config = new List<string>();

        if (textboxWadJoin.Text.Trim() != string.Empty)
            config.Add($"-iwad {textboxWadJoin.Text.Trim()}");

        // If the IP textbox is empty, the program defaults to localhost with the default GZDoom port
        if (textboxHostIp.Text.Trim() != string.Empty)
            config.Add($"-join 127.0.0.1:5029");
        else
            config.Add($"-join {textboxHostIp.Text.Trim()}");

        return config;
    }
}