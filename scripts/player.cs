using Godot;
using System;


public class player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }

    public override void _PhysicsProcess(float delta) 
    {
        Vector2 movement = new Vector2(); //mojimmy actually
        if(Input.IsActionPressed("up"))
        {
            movement.y -= 1;
        }

        if(Input.IsActionPressed("down"))
        {
            movement.y += 1;
        }

        if(Input.IsActionPressed("left"))
        {
            movement.x -= 1;
        }

        if(Input.IsActionPressed("right"))
        {
            movement.x += 1;
        }

        MoveAndSlide(30*movement);


    }
}
