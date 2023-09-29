namespace GZDoomServerGUI;

// This partial class contains all Textbox-related logic
public partial class MainWindow
{
    /// <summary>
    /// Gets the values of all the Host textboxes
    /// </summary>
    private HostInputs GetHostInputs() {
        return new HostInputs {
            Wad = textboxWad.Text.Trim(),
            NPlayers = textboxNPlayer.Text.Trim(),
            Skill = textboxSkill.Text.Trim(),
            Level = textboxLevel.Text.Trim(),
            Port = textboxPort.Text.Trim(),
            Deathmatch = checkDeathmatch.Checked,
            Monsters = checkMonsters.Checked,
        };
    }

    /// <summary>
    /// Gets the values of all the Join textboxes
    /// </summary>
    private JoinInputs GetJoinInputs() {
        return new JoinInputs {
            Wad = textboxWadJoin.Text.Trim(),
            Ip = textboxHostIp.Text.Trim(),
        };
    }


    /// <summary>
    /// Host Inputs, checks which have been set and adds their values to the command
    /// </summary>
    private List<string> EvaluateHostInputs(HostInputs inputs) {
        var config = new List<string>();

        if (inputs.Wad != string.Empty) {
            config.Add($"-iwad {textboxWad.Text.Trim()}");
        }

        if (inputs.NPlayers != string.Empty) {
            config.Add($"-host {textboxNPlayer.Text.Trim()}");
        }

        if (inputs.Skill != string.Empty) {
            config.Add($"-skill {textboxSkill.Text.Trim()}");
        }

        if (inputs.Level != string.Empty) {
            config.Add($"-warp {textboxLevel.Text.Trim()}");
        }

        if (inputs.Port != string.Empty) {
            config.Add($"-port {textboxPort.Text}");
        }

        if (inputs.Deathmatch) {
            config.Add("-deathmatch");
        }

        if (!inputs.Monsters) {
            config.Add("-nomonsters");
        }

        return config;
    }


    /// <summary>
    /// Join Inputs, checks which have been set and adds their values to the command
    /// </summary>
    private List<string> EvaluateJoinInputs(JoinInputs inputs) {
        var config = new List<string>();

        if (inputs.Wad != string.Empty) {
            config.Add($"-iwad {textboxWadJoin.Text.Trim()}");
        }

        // If the IP textbox is empty, the program defaults to localhost with the default GZDoom port
        if (inputs.Ip != string.Empty) {
            config.Add($"-join {textboxHostIp.Text.Trim()}");
        } else {
            config.Add($"-join 127.0.0.1:5029");
        }

        return config;
    }
}