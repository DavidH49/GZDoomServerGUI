namespace GZDoomServerGUI;

public partial class MainWindow
{
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