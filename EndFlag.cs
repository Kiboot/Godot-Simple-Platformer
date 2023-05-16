using Godot;
using System;

public partial class EndFlag : Area2D
{
	[Export(PropertyHint.File, "*.tscn")]
	public string NextScene { get; set; }
	private void _on_body_entered(Node2D body)
	{
		if(body.IsInGroup("Player")){
			//get_tree().change_scene_to_file(NextScene)
			GetTree().ChangeSceneToFile(NextScene);
		}
	}
}
